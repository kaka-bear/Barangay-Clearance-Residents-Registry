Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class FrmResidentsList
    Private _printRows As List(Of DataRow)
    Private _printIndex As Integer = 0
    Private _pageNum As Integer = 0

    Private Sub FrmResidentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboSex.SelectedIndex = 0 ' "All"
        CboCivilStatus.SelectedIndex = 0 ' "All"
        CboSort.SelectedIndex = 0 ' "Full Name"
        LoadData()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadData()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Clear()
        CboSex.SelectedIndex = 0
        CboCivilStatus.SelectedIndex = 0
        CboSort.SelectedIndex = 0
        LoadData()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadData()
    End Sub

    ''' <summary>
    ''' Searches, filters, and sorts the list of residents from the database.
    ''' </summary>
    Private Sub LoadData()
        Dim query As String = "SELECT ResidentID, FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt FROM Residents"
        Dim whereClauses As New List(Of String)()
        Dim params As New List(Of OleDbParameter)()

        ' Name or Address Search
        If Not String.IsNullOrWhiteSpace(TxtSearch.Text) Then
            whereClauses.Add("(FullName LIKE ? OR Address LIKE ?)")
            params.Add(New OleDbParameter("@search1", OleDbType.VarWChar) With {.Value = "%" & TxtSearch.Text.Trim() & "%"})
            params.Add(New OleDbParameter("@search2", OleDbType.VarWChar) With {.Value = "%" & TxtSearch.Text.Trim() & "%"})
        End If

        ' Sex Filter
        If CboSex.SelectedItem IsNot Nothing AndAlso CboSex.SelectedItem.ToString() <> "All" Then
            whereClauses.Add("Sex = ?")
            params.Add(New OleDbParameter("@sex", OleDbType.VarWChar) With {.Value = CboSex.SelectedItem.ToString()})
        End If

        ' Civil Status Filter
        If CboCivilStatus.SelectedItem IsNot Nothing AndAlso CboCivilStatus.SelectedItem.ToString() <> "All" Then
            whereClauses.Add("CivilStatus = ?")
            params.Add(New OleDbParameter("@civil", OleDbType.VarWChar) With {.Value = CboCivilStatus.SelectedItem.ToString()})
        End If

        ' Combine filters
        If whereClauses.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", whereClauses)
        End If

        ' Whitelisted Sorting
        Dim sortCol As String = "FullName"
        Dim sortDir As String = "ASC"

        Select Case CboSort.SelectedItem.ToString()
            Case "Birth Date"
                sortCol = "BirthDate"
                sortDir = "ASC"
            Case "Created Date"
                sortCol = "CreatedAt"
                sortDir = "DESC"
            Case Else
                sortCol = "FullName"
                sortDir = "ASC"
        End Select

        query &= $" ORDER BY {sortCol} {sortDir}"

        Dim dt As DataTable = DbHelper.GetTable(query, params)
        DgvResidents.DataSource = dt

        ' Style columns for human readable format
        If DgvResidents.Columns.Contains("ResidentID") Then
            DgvResidents.Columns("ResidentID").HeaderText = "ID"
            DgvResidents.Columns("ResidentID").Width = 50
        End If
        If DgvResidents.Columns.Contains("FullName") Then
            DgvResidents.Columns("FullName").HeaderText = "Full Name"
        End If
        If DgvResidents.Columns.Contains("BirthDate") Then
            DgvResidents.Columns("BirthDate").HeaderText = "Birth Date"
            DgvResidents.Columns("BirthDate").DefaultCellStyle.Format = "yyyy-MM-dd"
        End If
        If DgvResidents.Columns.Contains("ContactNumber") Then
            DgvResidents.Columns("ContactNumber").HeaderText = "Contact"
        End If
        If DgvResidents.Columns.Contains("CivilStatus") Then
            DgvResidents.Columns("CivilStatus").HeaderText = "Civil Status"
        End If
        If DgvResidents.Columns.Contains("CreatedAt") Then
            DgvResidents.Columns("CreatedAt").HeaderText = "Date Added"
            DgvResidents.Columns("CreatedAt").DefaultCellStyle.Format = "yyyy-MM-dd"
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Using fEdit As New FrmResidentEdit(0) ' ID 0 indicates a new record
            If fEdit.ShowDialog() = DialogResult.OK Then
                LoadData()
                ' Trigger dashboard refresh if open
                Dim fMain As FrmMain = CType(Me.MdiParent, FrmMain)
                For Each child In fMain.MdiChildren
                    If TypeOf child Is FrmDashboard Then
                        CType(child, FrmDashboard).RefreshDashboard()
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DgvResidents.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a resident to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim residentId As Integer = Convert.ToInt32(DgvResidents.CurrentRow.Cells("ResidentID").Value)
        Using fEdit As New FrmResidentEdit(residentId)
            If fEdit.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvResidents.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a resident to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim residentId As Integer = Convert.ToInt32(DgvResidents.CurrentRow.Cells("ResidentID").Value)
        Dim residentName As String = DgvResidents.CurrentRow.Cells("FullName").Value.ToString()

        ' Check if resident has clearances before deleting (prevent SQL reference errors)
        Dim checkSql As String = "SELECT COUNT(*) FROM Clearances WHERE ResidentID = ?"
        Dim countParams As New List(Of OleDbParameter) From {
            New OleDbParameter("@rId", OleDbType.Integer) With {.Value = residentId}
        }
        Dim clearanceCount As Integer = Convert.ToInt32(DbHelper.ExecScalar(checkSql, countParams))

        If clearanceCount > 0 Then
            MessageBox.Show($"Resident '{residentName}' has {clearanceCount} active/past clearances in the system and cannot be deleted. " & vbCrLf &
                            "Delete or modify the associated clearances first.", "Delete Prevented", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ask for confirmation
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to permanently delete resident '{residentName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                Dim deleteSql As String = "DELETE FROM Residents WHERE ResidentID = ?"
                Dim delParams As New List(Of OleDbParameter) From {
                    New OleDbParameter("@rId", OleDbType.Integer) With {.Value = residentId}
                }
                Dim rows As Integer = DbHelper.Exec(deleteSql, delParams)
                If rows > 0 Then
                    MessageBox.Show("Resident record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                    ' Refresh dashboard
                    Dim fMain As FrmMain = CType(Me.MdiParent, FrmMain)
                    For Each child In fMain.MdiChildren
                        If TypeOf child Is FrmDashboard Then
                            CType(child, FrmDashboard).RefreshDashboard()
                        End If
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to delete resident: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- PRINTING MODULE ---
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If DgvResidents.Rows.Count = 0 Then
            MessageBox.Show("There is no data to print.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Extract data from DataGridView datasource
        Dim dt As DataTable = CType(DgvResidents.DataSource, DataTable)
        _printRows = dt.Rows.Cast(Of DataRow)().ToList()
        _printIndex = 0
        _pageNum = 0

        ' Configure Print Settings
        PrintDocument1.DefaultPageSettings.Landscape = True ' Better layout for residents table
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
        RemoveHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        _pageNum += 1
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontBody As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim fontPage As New Font("Segoe UI", 8, FontStyle.Italic)
        
        Dim marginL As Integer = e.MarginBounds.Left - 20
        Dim marginT As Integer = e.MarginBounds.Top - 20
        Dim marginR As Integer = e.MarginBounds.Right + 20
        Dim marginB As Integer = e.MarginBounds.Bottom

        Dim y As Integer = marginT

        ' 1. Header Details
        g.DrawString("BARANGAY CLEARANCE & RESIDENTS REGISTRY SYSTEM", New Font("Segoe UI", 9, FontStyle.Bold), Brushes.Gray, marginL, y)
        y += 20
        g.DrawString("Residents Registry Report", fontTitle, Brushes.Black, marginL, y)
        g.DrawString("Date Generated: " & DateTime.Now.ToShortDateString(), fontBody, Brushes.Black, marginR - 180, y + 10)
        y += 40

        ' 2. Table Column Headers
        ' Define columns widths for Landscape page (about 1100 px wide)
        Dim colIdW As Integer = 50
        Dim colNameW As Integer = 200
        Dim colSexW As Integer = 80
        Dim colBirthW As Integer = 100
        Dim colCivilW As Integer = 100
        Dim colPhoneW As Integer = 120
        Dim colAddrW As Integer = 350

        g.FillRectangle(Brushes.LightGray, marginL, y, marginR - marginL, 25)
        g.DrawRectangle(Pens.Black, marginL, y, marginR - marginL, 25)

        g.DrawString("ID", fontHeader, Brushes.Black, marginL + 5, y + 4)
        g.DrawString("Full Name", fontHeader, Brushes.Black, marginL + colIdW + 5, y + 4)
        g.DrawString("Sex", fontHeader, Brushes.Black, marginL + colIdW + colNameW + 5, y + 4)
        g.DrawString("Birth Date", fontHeader, Brushes.Black, marginL + colIdW + colNameW + colSexW + 5, y + 4)
        g.DrawString("Civil Status", fontHeader, Brushes.Black, marginL + colIdW + colNameW + colSexW + colBirthW + 5, y + 4)
        g.DrawString("Contact No.", fontHeader, Brushes.Black, marginL + colIdW + colNameW + colSexW + colBirthW + colCivilW + 5, y + 4)
        g.DrawString("Address", fontHeader, Brushes.Black, marginL + colIdW + colNameW + colSexW + colBirthW + colCivilW + colPhoneW + 5, y + 4)

        y += 25

        Using sf As New StringFormat() With {
            .Trimming = StringTrimming.EllipsisCharacter,
            .FormatFlags = StringFormatFlags.NoWrap
        }
            ' 3. Draw rows
            While _printIndex < _printRows.Count
                Dim r As DataRow = _printRows(_printIndex)

                ' Draw borders
                g.DrawRectangle(Pens.LightGray, marginL, y, marginR - marginL, 22)

                ' Column Values
                g.DrawString(r("ResidentID").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + 5, y + 3, colIdW - 10, 18), sf)
                g.DrawString(r("FullName").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + 5, y + 3, colNameW - 10, 18), sf)
                g.DrawString(r("Sex").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colNameW + 5, y + 3, colSexW - 10, 18), sf)
                
                Dim bDate As DateTime = Convert.ToDateTime(r("BirthDate"))
                g.DrawString(bDate.ToString("yyyy-MM-dd"), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colNameW + colSexW + 5, y + 3, colBirthW - 10, 18), sf)
                g.DrawString(r("CivilStatus").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colNameW + colSexW + colBirthW + 5, y + 3, colCivilW - 10, 18), sf)
                g.DrawString(r("ContactNumber").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colNameW + colSexW + colBirthW + colCivilW + 5, y + 3, colPhoneW - 10, 18), sf)
                
                Dim addr As String = r("Address").ToString()
                g.DrawString(addr, fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colNameW + colSexW + colBirthW + colCivilW + colPhoneW + 5, y + 3, colAddrW - 10, 18), sf)

                y += 22
                _printIndex += 1

                ' Page split validation
                If y > marginB - 50 AndAlso _printIndex < _printRows.Count Then
                    ' Footer
                    g.DrawString("Page " & _pageNum & " | Continued on next page...", fontPage, Brushes.Gray, marginL, marginB - 20)
                    e.HasMorePages = True
                    Return
                End If
            End While
        End Using

        ' Final Footer
        g.DrawString("Page " & _pageNum & " of Report | Total Residents: " & _printRows.Count, fontPage, Brushes.Gray, marginL, marginB - 20)
        e.HasMorePages = False
        _printIndex = 0
    End Sub
End Class
