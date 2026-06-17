Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmClearanceTypeEdit
    Private _typeId As Integer = 0
    Private _isEditMode As Boolean = False

    Public Sub New(id As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Set mode
        _typeId = id
        _isEditMode = (id > 0)
    End Sub

    Private Sub FrmClearanceTypeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _isEditMode Then
            Me.Text = "Edit Clearance Template"
            LblHeader.Text = "Modify Clearance Template Details"
            LoadTypeData()
        Else
            Me.Text = "Add New Clearance Template"
            LblHeader.Text = "Enter New Clearance Template Details"
            NumDefaultFee.Value = 100.00D ' Default standard fee
        End If
    End Sub

    ''' <summary>
    ''' Load clearance type details if in edit mode.
    ''' </summary>
    Private Sub LoadTypeData()
        Try
            Dim sql As String = "SELECT * FROM ClearanceTypes WHERE ClearanceTypeID = ?"
            Dim params As New List(Of OleDbParameter) From {
                New OleDbParameter("@ctId", _typeId)
            }
            Dim dt As DataTable = DbHelper.GetTable(sql, params)

            If dt.Rows.Count > 0 Then
                Dim r As DataRow = dt.Rows(0)
                TxtTypeName.Text = r("TypeName").ToString()
                NumDefaultFee.Value = Convert.ToDecimal(r("DefaultFee"))
            Else
                MessageBox.Show("Clearance type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading clearance type: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateInput() Then
            Try
                Dim sql As String
                Dim params As New List(Of OleDbParameter)()

                params.Add(New OleDbParameter("@name", OleDbType.VarWChar) With {.Value = TxtTypeName.Text.Trim()})
                params.Add(New OleDbParameter("@fee", OleDbType.Decimal) With {.Value = NumDefaultFee.Value})

                If _isEditMode Then
                    ' UPDATE Mode
                    sql = "UPDATE ClearanceTypes SET TypeName = ?, DefaultFee = ?, UpdatedAt = ? WHERE ClearanceTypeID = ?"
                    params.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                    params.Add(New OleDbParameter("@ctId", OleDbType.Integer) With {.Value = _typeId})
                Else
                    ' INSERT Mode
                    sql = "INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES (?, ?, ?, ?)"
                    params.Add(New OleDbParameter("@cAt", OleDbType.Date) With {.Value = DateTime.Now})
                    params.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                End If

                Dim rows As Integer = DbHelper.Exec(sql, params)
                If rows > 0 Then
                    MessageBox.Show(If(_isEditMode, "Clearance template updated successfully.", "New clearance template added successfully."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error saving clearance template: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Performs client-side validation using the ErrorProvider control.
    ''' </summary>
    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear()

        ' Template Name Validation
        If String.IsNullOrWhiteSpace(TxtTypeName.Text) Then
            ErrorProvider1.SetError(TxtTypeName, "Template name is required.")
            isValid = False
        ElseIf TxtTypeName.Text.Trim().Length < 4 Then
            ErrorProvider1.SetError(TxtTypeName, "Template name must be at least 4 characters.")
            isValid = False
        End If

        ' Fee Validation (NumericUpDown already prevents non-numeric values, just validate range)
        If NumDefaultFee.Value < 0D Then
            ErrorProvider1.SetError(NumDefaultFee, "Default fee cannot be negative.")
            isValid = False
        End If

        Return isValid
    End Function
End Class
