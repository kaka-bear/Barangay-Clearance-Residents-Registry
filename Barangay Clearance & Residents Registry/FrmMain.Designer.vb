<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuResidents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuClearanceTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuIssueClearance = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuClearancesReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile, Me.MnuMaintenance, Me.MnuTransactions, Me.MnuReports, Me.MnuWindow})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.MnuWindow
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnuFile
        '
        Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuExit})
        Me.MnuFile.Name = "MnuFile"
        Me.MnuFile.Size = New System.Drawing.Size(39, 21)
        Me.MnuFile.Text = "&File"
        '
        'MnuExit
        '
        Me.MnuExit.Name = "MnuExit"
        Me.MnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MnuExit.Size = New System.Drawing.Size(180, 22)
        Me.MnuExit.Text = "E&xit"
        '
        'MnuMaintenance
        '
        Me.MnuMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuResidents, Me.MnuClearanceTypes})
        Me.MnuMaintenance.Name = "MnuMaintenance"
        Me.MnuMaintenance.Size = New System.Drawing.Size(96, 21)
        Me.MnuMaintenance.Text = "&Maintenance"
        '
        'MnuResidents
        '
        Me.MnuResidents.Name = "MnuResidents"
        Me.MnuResidents.Size = New System.Drawing.Size(180, 22)
        Me.MnuResidents.Text = "&Residents Registry"
        '
        'MnuClearanceTypes
        '
        Me.MnuClearanceTypes.Name = "MnuClearanceTypes"
        Me.MnuClearanceTypes.Size = New System.Drawing.Size(180, 22)
        Me.MnuClearanceTypes.Text = "Clearance &Types"
        '
        'MnuTransactions
        '
        Me.MnuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuIssueClearance})
        Me.MnuTransactions.Name = "MnuTransactions"
        Me.MnuTransactions.Size = New System.Drawing.Size(92, 21)
        Me.MnuTransactions.Text = "&Transactions"
        '
        'MnuIssueClearance
        '
        Me.MnuIssueClearance.Name = "MnuIssueClearance"
        Me.MnuIssueClearance.Size = New System.Drawing.Size(200, 22)
        Me.MnuIssueClearance.Text = "&Clearances Registry"
        '
        'MnuReports
        '
        Me.MnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuClearancesReport, Me.MnuDashboard})
        Me.MnuReports.Name = "MnuReports"
        Me.MnuReports.Size = New System.Drawing.Size(65, 21)
        Me.MnuReports.Text = "&Reports"
        '
        'MnuClearancesReport
        '
        Me.MnuClearancesReport.Name = "MnuClearancesReport"
        Me.MnuClearancesReport.Size = New System.Drawing.Size(193, 22)
        Me.MnuClearancesReport.Text = "Clearance &History"
        '
        'MnuDashboard
        '
        Me.MnuDashboard.Name = "MnuDashboard"
        Me.MnuDashboard.Size = New System.Drawing.Size(193, 22)
        Me.MnuDashboard.Text = "&Dashboard Summary"
        '
        'MnuWindow
        '
        Me.MnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCascade, Me.MnuTileHorizontal, Me.MnuTileVertical})
        Me.MnuWindow.Name = "MnuWindow"
        Me.MnuWindow.Size = New System.Drawing.Size(67, 21)
        Me.MnuWindow.Text = "&Window"
        '
        'MnuCascade
        '
        Me.MnuCascade.Name = "MnuCascade"
        Me.MnuCascade.Size = New System.Drawing.Size(159, 22)
        Me.MnuCascade.Text = "&Cascade"
        '
        'MnuTileHorizontal
        '
        Me.MnuTileHorizontal.Name = "MnuTileHorizontal"
        Me.MnuTileHorizontal.Size = New System.Drawing.Size(159, 22)
        Me.MnuTileHorizontal.Text = "Tile &Horizontal"
        '
        'MnuTileVertical
        '
        Me.MnuTileVertical.Name = "MnuTileVertical"
        Me.MnuTileVertical.Size = New System.Drawing.Size(159, 22)
        Me.MnuTileVertical.Text = "Tile &Vertical"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStatus, Me.LblDateTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblStatus
        '
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(39, 17)
        Me.LblStatus.Text = "Ready"
        '
        'LblDateTime
        '
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(930, 17)
        Me.LblDateTime.Spring = True
        Me.LblDateTime.Text = "Date & Time"
        Me.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Clearance & Residents Registry System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuFile As ToolStripMenuItem
    Friend WithEvents MnuExit As ToolStripMenuItem
    Friend WithEvents MnuMaintenance As ToolStripMenuItem
    Friend WithEvents MnuResidents As ToolStripMenuItem
    Friend WithEvents MnuClearanceTypes As ToolStripMenuItem
    Friend WithEvents MnuTransactions As ToolStripMenuItem
    Friend WithEvents MnuIssueClearance As ToolStripMenuItem
    Friend WithEvents MnuReports As ToolStripMenuItem
    Friend WithEvents MnuClearancesReport As ToolStripMenuItem
    Friend WithEvents MnuDashboard As ToolStripMenuItem
    Friend WithEvents MnuWindow As ToolStripMenuItem
    Friend WithEvents MnuCascade As ToolStripMenuItem
    Friend WithEvents MnuTileHorizontal As ToolStripMenuItem
    Friend WithEvents MnuTileVertical As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LblStatus As ToolStripStatusLabel
    Friend WithEvents LblDateTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
