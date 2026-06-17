Option Strict On

Imports System.Windows.Forms

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize the database (creates file/tables/seeds data if needed)
        DbHelper.InitializeDatabase()

        ' 2. Open the Dashboard on startup
        OpenChildForm(Of FrmDashboard)()
    End Sub

    ''' <summary>
    ''' Generic helper method to manage MDI Child Forms.
    ''' Prevents multiple instances of the same form from opening.
    ''' </summary>
    Public Sub OpenChildForm(Of T As {Form, New})()
        For Each f As Form In Me.MdiChildren
            If TypeOf f Is T Then
                f.Activate()
                If f.WindowState = FormWindowState.Minimized Then
                    f.WindowState = FormWindowState.Normal
                End If
                Return
            End If
        Next
        
        Dim child As New T()
        child.MdiParent = Me
        child.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MnuResidents_Click(sender As Object, e As EventArgs) Handles MnuResidents.Click
        OpenChildForm(Of FrmResidentsList)()
    End Sub

    Private Sub MnuClearanceTypes_Click(sender As Object, e As EventArgs) Handles MnuClearanceTypes.Click
        OpenChildForm(Of FrmClearanceTypesList)()
    End Sub

    Private Sub MnuIssueClearance_Click(sender As Object, e As EventArgs) Handles MnuIssueClearance.Click
        OpenChildForm(Of FrmClearancesList)()
    End Sub

    Private Sub MnuClearancesReport_Click(sender As Object, e As EventArgs) Handles MnuClearancesReport.Click
        OpenChildForm(Of FrmClearancesList)()
    End Sub

    Private Sub MnuDashboard_Click(sender As Object, e As EventArgs) Handles MnuDashboard.Click
        OpenChildForm(Of FrmDashboard)()
    End Sub

    Private Sub MnuCascade_Click(sender As Object, e As EventArgs) Handles MnuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MnuTileHorizontal_Click(sender As Object, e As EventArgs) Handles MnuTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MnuTileVertical_Click(sender As Object, e As EventArgs) Handles MnuTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
