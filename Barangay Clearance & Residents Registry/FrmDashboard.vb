Option Strict On

Imports System.Data
Imports System.Windows.Forms

Public Class FrmDashboard

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDashboard()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshDashboard()
    End Sub

    ''' <summary>
    ''' Queries the database and updates all statistics cards and lists.
    ''' </summary>
    Public Sub RefreshDashboard()
        Try
            ' 1. Get total residents count
            Dim totalResidents As Object = DbHelper.ExecScalar("SELECT COUNT(*) FROM Residents")
            If totalResidents IsNot Nothing AndAlso Not IsDBNull(totalResidents) Then
                LblResidentsVal.Text = Convert.ToInt32(totalResidents).ToString("N0")
            Else
                LblResidentsVal.Text = "0"
            End If

            ' 2. Get total clearances count
            Dim totalClearances As Object = DbHelper.ExecScalar("SELECT COUNT(*) FROM Clearances")
            If totalClearances IsNot Nothing AndAlso Not IsDBNull(totalClearances) Then
                LblClearancesVal.Text = Convert.ToInt32(totalClearances).ToString("N0")
            Else
                LblClearancesVal.Text = "0"
            End If

            ' 3. Get total revenue/collections sum
            Dim totalCollections As Object = DbHelper.ExecScalar("SELECT SUM(Amount) FROM Payments")
            If totalCollections IsNot Nothing AndAlso Not IsDBNull(totalCollections) Then
                LblCollectionsVal.Text = Convert.ToDecimal(totalCollections).ToString("C2")
            Else
                LblCollectionsVal.Text = "₱0.00"
            End If

            ' 4. Get latest 5 clearances issued (using Access JOIN syntax)
            Dim sqlRecent As String = "SELECT TOP 5 c.ORNo, r.FullName As [Resident Name], t.TypeName As [Clearance Type], c.IssueDate As [Issue Date], c.Fee As [Amount Paid] " &
                                       "FROM (Clearances c " &
                                       "INNER JOIN Residents r ON c.ResidentID = r.ResidentID) " &
                                       "INNER JOIN ClearanceTypes t ON c.ClearanceTypeID = t.ClearanceTypeID " &
                                       "ORDER BY c.IssueDate DESC, c.ClearanceID DESC"
            Dim dtRecent As DataTable = DbHelper.GetTable(sqlRecent)
            DgvRecent.DataSource = dtRecent

            ' Style grid columns slightly
            If DgvRecent.Columns.Contains("Amount Paid") Then
                DgvRecent.Columns("Amount Paid").DefaultCellStyle.Format = "C2"
            End If
            If DgvRecent.Columns.Contains("Issue Date") Then
                DgvRecent.Columns("Issue Date").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
