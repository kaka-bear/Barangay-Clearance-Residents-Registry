Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class FrmClearancesList
    Private _printRows As List(Of DataRow)
    Private _printIndex As Integer = 0
    Private _pageNum As Integer = 0

    Private Sub FrmClearancesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClearanceTypes()
        CboSort.SelectedIndex = 0 ' "Issue Date"
        LoadData()
    End Sub

    ''' <summary>
    ''' Populates the Clearance Type filter dropdown from database records.
    ''' </summary>
    Private Sub LoadClearanceTypes()
        Try
            Dim sql As String = "SELECT ClearanceTypeID, TypeName FROM ClearanceTypes ORDER BY TypeName ASC"
            Dim dt As DataTable = DbHelper.GetTable(sql)
            
            Dim allRow As DataRow = dt.NewRow()
            allRow("ClearanceTypeID") = 0
            allRow("TypeName") = "All Types"
            dt.Rows.InsertAt(allRow, 0)

            CboClearanceType.DisplayMember = "TypeName"
            CboClearanceType.ValueMember = "ClearanceTypeID"
            CboClearanceType.DataSource = dt
            CboClearanceType.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading clearance templates: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkDateRange_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDateRange.CheckedChanged
        DtpFrom.Enabled = ChkDateRange.Checked
        DtpTo.Enabled = ChkDateRange.Checked
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadData()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtResidentName.Clear()
        CboClearanceType.SelectedIndex = 0
        ChkDateRange.Checked = False
        DtpFrom.Value = DateTime.Today
        DtpTo.Value = DateTime.Today
        CboSort.SelectedIndex = 0
        LoadData()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadData()
    End Sub

    ''' <summary>
    ''' Searches the Clearances log with filters, sorting, and database joins.
    ''' </summary>
    Private Sub LoadData()
        ' Join Clearances, Residents, and ClearanceTypes tables
        Dim query As String = "SELECT c.ClearanceID, r.FullName As [Resident Name], t.TypeName As [Clearance Type], " &
                              "c.Purpose, c.ORNo As [OR Number], c.IssueDate As [Issue Date], c.Fee As [Amount], c.Status " &
                              "FROM (Clearances c " &
                              "INNER JOIN Residents r ON c.ResidentID = r.ResidentID) " &
                              "INNER JOIN ClearanceTypes t ON c.ClearanceTypeID = t.ClearanceTypeID"
        
        Dim whereClauses As New List(Of String)()
        Dim params As New List(Of OleDbParameter)()

        ' Filter: Resident Name
        If Not String.IsNullOrWhiteSpace(TxtResidentName.Text) Then
            whereClauses.Add("r.FullName LIKE ?")
            params.Add(New OleDbParameter("@resName", OleDbType.VarWChar) With {.Value = "%" & TxtResidentName.Text.Trim() & "%"})
        End If

        ' Filter: Clearance Type
        If CboClearanceType.SelectedValue IsNot Nothing AndAlso Convert.ToInt32(CboClearanceType.SelectedValue) > 0 Then
            whereClauses.Add("c.ClearanceTypeID = ?")
            params.Add(New OleDbParameter("@typeId", OleDbType.Integer) With {.Value = Convert.ToInt32(CboClearanceType.SelectedValue)})
        End If

        ' Filter: Date Range
        If ChkDateRange.Checked Then
            whereClauses.Add("c.IssueDate BETWEEN ? AND ?")
            params.Add(New OleDbParameter("@dateFrom", OleDbType.Date) With {.Value = DtpFrom.Value.Date})
            ' Filter through the end of the selected day
            params.Add(New OleDbParameter("@dateTo", OleDbType.Date) With {.Value = DtpTo.Value.Date.AddDays(1).AddSeconds(-1)})
        End If

        If whereClauses.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", whereClauses)
        End If

        ' Whitelisted Sorting
        Dim sortCol As String = "c.IssueDate"
        Dim sortDir As String = "DESC"

        Select Case CboSort.SelectedItem.ToString()
            Case "Resident Name"
                sortCol = "r.FullName"
                sortDir = "ASC"
            Case "Fee"
                sortCol = "c.Fee"
                sortDir = "DESC"
            Case Else ' Issue Date
                sortCol = "c.IssueDate"
                sortDir = "DESC"
        End Select

        query &= $" ORDER BY {sortCol} {sortDir}, c.ClearanceID DESC"

        Dim dt As DataTable = DbHelper.GetTable(query, params)
        DgvClearances.DataSource = dt

        ' Style columns
        If DgvClearances.Columns.Contains("ClearanceID") Then
            DgvClearances.Columns("ClearanceID").HeaderText = "ID"
            DgvClearances.Columns("ClearanceID").Width = 50
        End If
        If DgvClearances.Columns.Contains("Issue Date") Then
            DgvClearances.Columns("Issue Date").DefaultCellStyle.Format = "yyyy-MM-dd"
            DgvClearances.Columns("Issue Date").Width = 100
        End If
        If DgvClearances.Columns.Contains("Amount") Then
            DgvClearances.Columns("Amount").DefaultCellStyle.Format = "C2"
            DgvClearances.Columns("Amount").Width = 90
        End If
        If DgvClearances.Columns.Contains("Status") Then
            DgvClearances.Columns("Status").Width = 80
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Using fEdit As New FrmClearanceEdit()
            If fEdit.ShowDialog() = DialogResult.OK Then
                LoadData()
                ' Refresh Main Dashboard if open
                Dim fMain As FrmMain = CType(Me.MdiParent, FrmMain)
                For Each child In fMain.MdiChildren
                    If TypeOf child Is FrmDashboard Then
                        CType(child, FrmDashboard).RefreshDashboard()
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub BtnCancelClearance_Click(sender As Object, e As EventArgs) Handles BtnCancelClearance.Click
        If DgvClearances.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a clearance record to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim status As String = DgvClearances.CurrentRow.Cells("Status").Value.ToString()
        If status = "Cancelled" Then
            MessageBox.Show("This clearance certificate is already marked as Cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim clrId As Integer = Convert.ToInt32(DgvClearances.CurrentRow.Cells("ClearanceID").Value)
        Dim resName As String = DgvClearances.CurrentRow.Cells("Resident Name").Value.ToString()
        Dim orNo As String = DgvClearances.CurrentRow.Cells("OR Number").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to cancel the clearance certificate for '{resName}' (OR: {orNo})? " & vbCrLf &
                                                    "This action will change the certificate status to Cancelled and cannot be undone.", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        
        If result = DialogResult.Yes Then
            Try
                ' Cancel clearance transaction
                Dim sql As String = "UPDATE Clearances SET Status = 'Cancelled', UpdatedAt = ? WHERE ClearanceID = ?"
                Dim params As New List(Of OleDbParameter) From {
                    New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now},
                    New OleDbParameter("@clrId", OleDbType.Integer) With {.Value = clrId}
                }

                Dim rows As Integer = DbHelper.Exec(sql, params)
                If rows > 0 Then
                    MessageBox.Show("Clearance certificate has been successfully cancelled.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                    ' Refresh Dashboard
                    Dim fMain As FrmMain = CType(Me.MdiParent, FrmMain)
                    For Each child In fMain.MdiChildren
                        If TypeOf child Is FrmDashboard Then
                            CType(child, FrmDashboard).RefreshDashboard()
                        End If
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Error cancelling clearance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- REPORT PRINTING ---
    Private Sub BtnPrintReport_Click(sender As Object, e As EventArgs) Handles BtnPrintReport.Click
        If DgvClearances.Rows.Count = 0 Then
            MessageBox.Show("No transaction logs to print.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dt As DataTable = CType(DgvClearances.DataSource, DataTable)
        _printRows = dt.Rows.Cast(Of DataRow)().ToList()
        _printIndex = 0
        _pageNum = 0

        PrintDocument1.DefaultPageSettings.Landscape = True
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

        ' 1. Print Header
        g.DrawString("BARANGAY CLEARANCE & RESIDENTS REGISTRY SYSTEM", New Font("Segoe UI", 9, FontStyle.Bold), Brushes.Gray, marginL, y)
        y += 20
        g.DrawString("Clearance Transaction Registry Report", fontTitle, Brushes.Black, marginL, y)
        g.DrawString("Date Generated: " & DateTime.Now.ToShortDateString(), fontBody, Brushes.Black, marginR - 180, y + 10)
        y += 40

        ' Columns widths for Landscape
        Dim colIdW As Integer = 50
        Dim colDateW As Integer = 100
        Dim colResW As Integer = 200
        Dim colTypeW As Integer = 220
        Dim colOrW As Integer = 100
        Dim colAmtW As Integer = 100
        Dim colStatW As Integer = 100

        g.FillRectangle(Brushes.LightGray, marginL, y, marginR - marginL, 25)
        g.DrawRectangle(Pens.Black, marginL, y, marginR - marginL, 25)

        g.DrawString("ID", fontHeader, Brushes.Black, marginL + 5, y + 4)
        g.DrawString("Issue Date", fontHeader, Brushes.Black, marginL + colIdW + 5, y + 4)
        g.DrawString("Resident Name", fontHeader, Brushes.Black, marginL + colIdW + colDateW + 5, y + 4)
        g.DrawString("Clearance Type", fontHeader, Brushes.Black, marginL + colIdW + colDateW + colResW + 5, y + 4)
        g.DrawString("OR Number", fontHeader, Brushes.Black, marginL + colIdW + colDateW + colResW + colTypeW + 5, y + 4)
        g.DrawString("Fee Paid", fontHeader, Brushes.Black, marginL + colIdW + colDateW + colResW + colTypeW + colOrW + 5, y + 4)
        g.DrawString("Status", fontHeader, Brushes.Black, marginL + colIdW + colDateW + colResW + colTypeW + colOrW + colAmtW + 5, y + 4)

        y += 25

        Dim pageTotal As Decimal = 0D

        Using sf As New StringFormat() With {
            .Trimming = StringTrimming.EllipsisCharacter,
            .FormatFlags = StringFormatFlags.NoWrap
        }
            ' 2. Draw Table Rows
            While _printIndex < _printRows.Count
                Dim r As DataRow = _printRows(_printIndex)

                ' Draw row border
                g.DrawRectangle(Pens.LightGray, marginL, y, marginR - marginL, 22)

                g.DrawString(r("ClearanceID").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + 5, y + 3, colIdW - 10, 18), sf)
                
                Dim iDate As DateTime = Convert.ToDateTime(r("Issue Date"))
                g.DrawString(iDate.ToString("yyyy-MM-dd"), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + 5, y + 3, colDateW - 10, 18), sf)
                g.DrawString(r("Resident Name").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colDateW + 5, y + 3, colResW - 10, 18), sf)
                g.DrawString(r("Clearance Type").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colDateW + colResW + 5, y + 3, colTypeW - 10, 18), sf)
                g.DrawString(r("OR Number").ToString(), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colDateW + colResW + colTypeW + 5, y + 3, colOrW - 10, 18), sf)
                
                Dim amt As Decimal = Convert.ToDecimal(r("Amount"))
                g.DrawString(amt.ToString("C2"), fontBody, Brushes.Black, New RectangleF(marginL + colIdW + colDateW + colResW + colTypeW + colOrW + 5, y + 3, colAmtW - 10, 18), sf)
                
                Dim status As String = r("Status").ToString()
                Dim statBrush As Brush = Brushes.Black
                If status = "Cancelled" Then statBrush = Brushes.Red
                g.DrawString(status, fontBody, statBrush, New RectangleF(marginL + colIdW + colDateW + colResW + colTypeW + colOrW + colAmtW + 5, y + 3, colStatW - 10, 18), sf)

                If status <> "Cancelled" Then
                    pageTotal += amt
                End If

                y += 22
                _printIndex += 1

                ' Page split validation
                If y > marginB - 50 AndAlso _printIndex < _printRows.Count Then
                    g.DrawString("Page " & _pageNum & " | Continued...", fontPage, Brushes.Gray, marginL, marginB - 20)
                    e.HasMorePages = True
                    Return
                End If
            End While
        End Using

        ' Draw Total Sum at the end of the report
        g.DrawString("Total Collections on this Report: " & CalculateTotalCollections().ToString("C2"), fontHeader, Brushes.Black, marginL + colIdW + colDateW + colResW + colTypeW + 5, y + 10)

        g.DrawString("Page " & _pageNum & " of Report | Total Records: " & _printRows.Count, fontPage, Brushes.Gray, marginL, marginB - 20)
        e.HasMorePages = False
        _printIndex = 0
    End Sub

    Private Function CalculateTotalCollections() As Decimal
        Dim total As Decimal = 0D
        For Each r As DataRow In _printRows
            If r("Status").ToString() <> "Cancelled" Then
                total += Convert.ToDecimal(r("Amount"))
            End If
        Next
        Return total
    End Function
End Class
