Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms

Public Module DbHelper
    Public ReadOnly Property ConnString As String
        Get
            Dim dbPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App.accdb")
            Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"
        End Get
    End Property

    ''' <summary>
    ''' Initializes the database file and creates/seeds tables if they do not exist.
    ''' </summary>
    Public Sub InitializeDatabase()
        Dim dbFile As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App.accdb")
        Dim sqlFile As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_setup.sql")

        ' 1. Check if database file exists. If not, create it.
        If Not File.Exists(dbFile) Then
            Try
                Dim catType As Type = Type.GetTypeFromProgID("ADOX.Catalog")
                If catType IsNot Nothing Then
                    Dim cat As Object = Activator.CreateInstance(catType)
                    catType.InvokeMember("Create", System.Reflection.BindingFlags.InvokeMethod, Nothing, cat, New Object() {ConnString})
                    cat = Nothing
                Else
                    Throw New Exception("ADOX.Catalog class not found. Microsoft Access Database Engine 2016/2010 may be required.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error creating the database file: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If

        ' 2. Check if tables exist. If they do, we assume it's already initialized.
        Dim tablesExist As Boolean = False
        Using cn As New OleDbConnection(ConnString)
            Try
                cn.Open()
                Dim schemaTable As DataTable = cn.GetSchema("Tables", New String() {Nothing, Nothing, "Residents", "TABLE"})
                If schemaTable.Rows.Count > 0 Then
                    tablesExist = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error connecting to the database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        ' 3. If tables don't exist, read db_setup.sql and execute the DDL and DML commands.
        If Not tablesExist Then
            If Not File.Exists(sqlFile) Then
                MessageBox.Show($"Database is not initialized and '{Path.GetFileName(sqlFile)}' was not found in the application directory. Cannot seed database.", "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Dim sqlContent As String = File.ReadAllText(sqlFile)
                ' Split by "-- GO" delimiter
                Dim statements() As String = sqlContent.Split(New String() {"-- GO"}, StringSplitOptions.RemoveEmptyEntries)

                Using cn As New OleDbConnection(ConnString)
                    cn.Open()
                    For Each stmt As String In statements
                        ' Split statement into lines to filter out comments
                        Dim lines() As String = stmt.Split(New String() {vbCrLf, vbLf}, StringSplitOptions.None)
                        Dim cleanLines As New List(Of String)()
                        For Each line As String In lines
                            Dim trimmedLine As String = line.Trim()
                            If Not trimmedLine.StartsWith("--") Then
                                cleanLines.Add(line)
                            End If
                        Next
                        Dim cleanStmt As String = String.Join(Environment.NewLine, cleanLines).Trim()

                        If Not String.IsNullOrEmpty(cleanStmt) Then
                            Using cmd As New OleDbCommand(cleanStmt, cn)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next
                End Using
                MessageBox.Show("Database initialized and seeded successfully with demo data!", "Database Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error initializing database tables: " & ex.Message, "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Executes a parameterized SELECT query and returns a DataTable.
    ''' </summary>
    Public Function GetTable(sql As String, Optional params As List(Of OleDbParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(ConnString)
            Using cmd As New OleDbCommand(sql, cn)
                If params IsNot Nothing Then
                    For Each p In params
                        ' Clone the parameter to avoid connection sharing issues
                        Dim newParam As OleDbParameter = CType(CType(p, ICloneable).Clone(), OleDbParameter)
                        cmd.Parameters.Add(newParam)
                    Next
                End If
                Using da As New OleDbDataAdapter(cmd)
                    Try
                        da.Fill(dt)
                    Catch ex As Exception
                        MessageBox.Show("Query execution failed: " & ex.Message & vbCrLf & "SQL: " & sql, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>
    ''' Executes a parameterized INSERT, UPDATE, or DELETE statement. Returns rows affected.
    ''' </summary>
    Public Function Exec(sql As String, Optional params As List(Of OleDbParameter) = Nothing) As Integer
        Dim rowsAffected As Integer = 0
        Using cn As New OleDbConnection(ConnString)
            Using cmd As New OleDbCommand(sql, cn)
                If params IsNot Nothing Then
                    For Each p In params
                        Dim newParam As OleDbParameter = CType(CType(p, ICloneable).Clone(), OleDbParameter)
                        cmd.Parameters.Add(newParam)
                    Next
                End If
                Try
                    cn.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Execute statement failed: " & ex.Message & vbCrLf & "SQL: " & sql, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Throw
                End Try
            End Using
        End Using
        Return rowsAffected
    End Function

    ''' <summary>
    ''' Executes a parameterized query that returns a single scalar value.
    ''' </summary>
    Public Function ExecScalar(sql As String, Optional params As List(Of OleDbParameter) = Nothing) As Object
        Dim result As Object = Nothing
        Using cn As New OleDbConnection(ConnString)
            Using cmd As New OleDbCommand(sql, cn)
                If params IsNot Nothing Then
                    For Each p In params
                        Dim newParam As OleDbParameter = CType(CType(p, ICloneable).Clone(), OleDbParameter)
                        cmd.Parameters.Add(newParam)
                    Next
                End If
                Try
                    cn.Open()
                    result = cmd.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show("Scalar execution failed: " & ex.Message & vbCrLf & "SQL: " & sql, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return result
    End Function

    ''' <summary>
    ''' Saves a clearance certificate and its associated payment as a single database transaction.
    ''' If simulateError is True, it forces an error on step 2 to demonstrate transactional rollback.
    ''' </summary>
    Public Function SaveClearanceWithPayment(residentId As Integer, clearanceTypeId As Integer, purpose As String, orNo As String, issueDate As DateTime, fee As Decimal, paymentMethod As String, Optional simulateError As Boolean = False) As Boolean
        Using cn As New OleDbConnection(ConnString)
            cn.Open()
            Using tx As OleDbTransaction = cn.BeginTransaction()
                Try
                    ' 1. Insert into Clearances table
                    Dim sqlClearance As String = "INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) " &
                                                 "VALUES (?, ?, ?, ?, ?, ?, 'Issued', ?, ?)"
                    Using cmdClr As New OleDbCommand(sqlClearance, cn, tx)
                        cmdClr.Parameters.Add(New OleDbParameter("@rID", OleDbType.Integer) With {.Value = residentId})
                        cmdClr.Parameters.Add(New OleDbParameter("@ctID", OleDbType.Integer) With {.Value = clearanceTypeId})

                        Dim pPurpose As New OleDbParameter("@purp", OleDbType.VarWChar)
                        pPurpose.Value = If(String.IsNullOrEmpty(purpose), CObj(DBNull.Value), CObj(purpose))
                        cmdClr.Parameters.Add(pPurpose)

                        cmdClr.Parameters.Add(New OleDbParameter("@orNo", OleDbType.VarWChar) With {.Value = orNo})
                        cmdClr.Parameters.Add(New OleDbParameter("@iDate", OleDbType.Date) With {.Value = issueDate})
                        cmdClr.Parameters.Add(New OleDbParameter("@fee", OleDbType.Decimal) With {.Value = fee})
                        cmdClr.Parameters.Add(New OleDbParameter("@cAt", OleDbType.Date) With {.Value = DateTime.Now})
                        cmdClr.Parameters.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                        cmdClr.ExecuteNonQuery()
                    End Using

                    ' 2. Insert into Payments table
                    Dim sqlPayment As String = "INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) " &
                                               "VALUES (?, ?, ?, ?, ?, ?)"
                    
                    ' If we want to simulate a failure, we execute step 2 with intentionally bad SQL, or trigger a custom exception
                    If simulateError Then
                        Throw New InvalidOperationException("Simulation Error: An unexpected issue occurred during payment posting.")
                    End If

                    Using cmdPay As New OleDbCommand(sqlPayment, cn, tx)
                        cmdPay.Parameters.Add(New OleDbParameter("@orNo", OleDbType.VarWChar) With {.Value = orNo})
                        cmdPay.Parameters.Add(New OleDbParameter("@amt", OleDbType.Decimal) With {.Value = fee})
                        cmdPay.Parameters.Add(New OleDbParameter("@pDate", OleDbType.Date) With {.Value = issueDate})
                        cmdPay.Parameters.Add(New OleDbParameter("@pMethod", OleDbType.VarWChar) With {.Value = paymentMethod})
                        cmdPay.Parameters.Add(New OleDbParameter("@cAt", OleDbType.Date) With {.Value = DateTime.Now})
                        cmdPay.Parameters.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                        cmdPay.ExecuteNonQuery()
                    End Using

                    ' If everything succeeded, commit the transaction
                    tx.Commit()
                    Return True

                Catch ex As Exception
                    ' Roll back transaction on failure
                    Try
                        tx.Rollback()
                    Catch rollbackEx As Exception
                        ' Handle potential double-fault
                        MessageBox.Show("Failed to rollback transaction: " & rollbackEx.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    ' Re-throw the exception so the calling form can handle it
                    Throw
                End Try
            End Using
        End Using
    End Function
End Module
