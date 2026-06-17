<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        BtnRefresh = New Button()
        LblTitle = New Label()
        TableLayoutCards = New TableLayoutPanel()
        CardCollections = New Panel()
        LblCollectionsVal = New Label()
        LblCollectionsSub = New Label()
        CardClearances = New Panel()
        LblClearancesVal = New Label()
        LblClearancesSub = New Label()
        CardResidents = New Panel()
        LblResidentsVal = New Label()
        LblResidentsSub = New Label()
        PanelGrid = New Panel()
        DgvRecent = New DataGridView()
        LblRecentTitle = New Label()
        PanelHeader.SuspendLayout()
        TableLayoutCards.SuspendLayout()
        CardCollections.SuspendLayout()
        CardClearances.SuspendLayout()
        CardResidents.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(DgvRecent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        PanelHeader.Controls.Add(BtnRefresh)
        PanelHeader.Controls.Add(LblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(800, 60)
        PanelHeader.TabIndex = 0
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnRefresh.BackColor = Color.FromArgb(CByte(54), CByte(185), CByte(204))
        BtnRefresh.Cursor = Cursors.Hand
        BtnRefresh.FlatAppearance.BorderSize = 0
        BtnRefresh.FlatStyle = FlatStyle.Flat
        BtnRefresh.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRefresh.ForeColor = Color.White
        BtnRefresh.Location = New Point(678, 15)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(110, 30)
        BtnRefresh.TabIndex = 1
        BtnRefresh.Text = "↻ Refresh Data"
        BtnRefresh.UseVisualStyleBackColor = False
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitle.ForeColor = Color.FromArgb(CByte(43), CByte(54), CByte(116))
        LblTitle.Location = New Point(12, 13)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(271, 37)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Dashboard Overview"
        ' 
        ' TableLayoutCards
        ' 
        TableLayoutCards.ColumnCount = 3
        TableLayoutCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutCards.Controls.Add(CardCollections, 2, 0)
        TableLayoutCards.Controls.Add(CardClearances, 1, 0)
        TableLayoutCards.Controls.Add(CardResidents, 0, 0)
        TableLayoutCards.Dock = DockStyle.Top
        TableLayoutCards.Location = New Point(0, 60)
        TableLayoutCards.Name = "TableLayoutCards"
        TableLayoutCards.Padding = New Padding(10)
        TableLayoutCards.RowCount = 1
        TableLayoutCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutCards.Size = New Size(800, 135)
        TableLayoutCards.TabIndex = 1
        ' 
        ' CardCollections
        ' 
        CardCollections.BackColor = Color.FromArgb(CByte(246), CByte(194), CByte(62))
        CardCollections.Controls.Add(LblCollectionsVal)
        CardCollections.Controls.Add(LblCollectionsSub)
        CardCollections.Dock = DockStyle.Fill
        CardCollections.Location = New Point(533, 13)
        CardCollections.Name = "CardCollections"
        CardCollections.Size = New Size(254, 109)
        CardCollections.TabIndex = 2
        ' 
        ' LblCollectionsVal
        ' 
        LblCollectionsVal.AutoSize = True
        LblCollectionsVal.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCollectionsVal.ForeColor = Color.White
        LblCollectionsVal.Location = New Point(13, 40)
        LblCollectionsVal.Name = "LblCollectionsVal"
        LblCollectionsVal.Size = New Size(116, 45)
        LblCollectionsVal.TabIndex = 1
        LblCollectionsVal.Text = "₱0.00"
        ' 
        ' LblCollectionsSub
        ' 
        LblCollectionsSub.AutoSize = True
        LblCollectionsSub.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCollectionsSub.ForeColor = Color.White
        LblCollectionsSub.Location = New Point(14, 15)
        LblCollectionsSub.Name = "LblCollectionsSub"
        LblCollectionsSub.Size = New Size(156, 20)
        LblCollectionsSub.TabIndex = 2
        LblCollectionsSub.Text = "TOTAL COLLECTIONS"
        ' 
        ' CardClearances
        ' 
        CardClearances.BackColor = Color.FromArgb(CByte(28), CByte(200), CByte(138))
        CardClearances.Controls.Add(LblClearancesVal)
        CardClearances.Controls.Add(LblClearancesSub)
        CardClearances.Dock = DockStyle.Fill
        CardClearances.Location = New Point(273, 13)
        CardClearances.Name = "CardClearances"
        CardClearances.Size = New Size(254, 109)
        CardClearances.TabIndex = 1
        ' 
        ' LblClearancesVal
        ' 
        LblClearancesVal.AutoSize = True
        LblClearancesVal.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblClearancesVal.ForeColor = Color.White
        LblClearancesVal.Location = New Point(13, 37)
        LblClearancesVal.Name = "LblClearancesVal"
        LblClearancesVal.Size = New Size(42, 48)
        LblClearancesVal.TabIndex = 1
        LblClearancesVal.Text = "0"
        ' 
        ' LblClearancesSub
        ' 
        LblClearancesSub.AutoSize = True
        LblClearancesSub.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblClearancesSub.ForeColor = Color.White
        LblClearancesSub.Location = New Point(14, 15)
        LblClearancesSub.Name = "LblClearancesSub"
        LblClearancesSub.Size = New Size(158, 20)
        LblClearancesSub.TabIndex = 2
        LblClearancesSub.Text = "CLEARANCES ISSUED"
        ' 
        ' CardResidents
        ' 
        CardResidents.BackColor = Color.FromArgb(CByte(78), CByte(115), CByte(223))
        CardResidents.Controls.Add(LblResidentsVal)
        CardResidents.Controls.Add(LblResidentsSub)
        CardResidents.Dock = DockStyle.Fill
        CardResidents.Location = New Point(13, 13)
        CardResidents.Name = "CardResidents"
        CardResidents.Size = New Size(254, 109)
        CardResidents.TabIndex = 0
        ' 
        ' LblResidentsVal
        ' 
        LblResidentsVal.AutoSize = True
        LblResidentsVal.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblResidentsVal.ForeColor = Color.White
        LblResidentsVal.Location = New Point(13, 37)
        LblResidentsVal.Name = "LblResidentsVal"
        LblResidentsVal.Size = New Size(42, 48)
        LblResidentsVal.TabIndex = 1
        LblResidentsVal.Text = "0"
        ' 
        ' LblResidentsSub
        ' 
        LblResidentsSub.AutoSize = True
        LblResidentsSub.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblResidentsSub.ForeColor = Color.White
        LblResidentsSub.Location = New Point(14, 15)
        LblResidentsSub.Name = "LblResidentsSub"
        LblResidentsSub.Size = New Size(137, 20)
        LblResidentsSub.TabIndex = 2
        LblResidentsSub.Text = "TOTAL RESIDENTS"
        ' 
        ' PanelGrid
        ' 
        PanelGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelGrid.BackColor = Color.White
        PanelGrid.Controls.Add(DgvRecent)
        PanelGrid.Controls.Add(LblRecentTitle)
        PanelGrid.Location = New Point(23, 212)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Padding = New Padding(10)
        PanelGrid.Size = New Size(754, 226)
        PanelGrid.TabIndex = 2
        ' 
        ' DgvRecent
        ' 
        DgvRecent.AllowUserToAddRows = False
        DgvRecent.AllowUserToDeleteRows = False
        DgvRecent.AllowUserToResizeRows = False
        DgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvRecent.BackgroundColor = Color.White
        DgvRecent.BorderStyle = BorderStyle.None
        DgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(43), CByte(54), CByte(116))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgvRecent.ColumnHeadersHeight = 35
        DgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(112), CByte(117), CByte(143))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(43), CByte(54), CByte(116))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DgvRecent.DefaultCellStyle = DataGridViewCellStyle2
        DgvRecent.Dock = DockStyle.Fill
        DgvRecent.EnableHeadersVisualStyles = False
        DgvRecent.GridColor = Color.FromArgb(CByte(241), CByte(243), CByte(247))
        DgvRecent.Location = New Point(10, 41)
        DgvRecent.MultiSelect = False
        DgvRecent.Name = "DgvRecent"
        DgvRecent.ReadOnly = True
        DgvRecent.RowHeadersVisible = False
        DgvRecent.RowHeadersWidth = 45
        DgvRecent.RowTemplate.Height = 30
        DgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvRecent.Size = New Size(734, 175)
        DgvRecent.TabIndex = 1
        ' 
        ' LblRecentTitle
        ' 
        LblRecentTitle.AutoSize = True
        LblRecentTitle.Dock = DockStyle.Top
        LblRecentTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblRecentTitle.ForeColor = Color.FromArgb(CByte(43), CByte(54), CByte(116))
        LblRecentTitle.Location = New Point(10, 10)
        LblRecentTitle.Name = "LblRecentTitle"
        LblRecentTitle.Padding = New Padding(0, 0, 0, 6)
        LblRecentTitle.Size = New Size(393, 31)
        LblRecentTitle.TabIndex = 0
        LblRecentTitle.Text = "Recent Transactions (Last 5 Issued Clearances)"
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(247))
        ClientSize = New Size(800, 450)
        Controls.Add(PanelGrid)
        Controls.Add(TableLayoutCards)
        Controls.Add(PanelHeader)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimumSize = New Size(816, 489)
        Name = "FrmDashboard"
        Text = "Dashboard Statistics"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        TableLayoutCards.ResumeLayout(False)
        CardCollections.ResumeLayout(False)
        CardCollections.PerformLayout()
        CardClearances.ResumeLayout(False)
        CardClearances.PerformLayout()
        CardResidents.ResumeLayout(False)
        CardResidents.PerformLayout()
        PanelGrid.ResumeLayout(False)
        PanelGrid.PerformLayout()
        CType(DgvRecent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents TableLayoutCards As TableLayoutPanel
    Friend WithEvents CardResidents As Panel
    Friend WithEvents LblResidentsSub As Label
    Friend WithEvents LblResidentsVal As Label
    Friend WithEvents CardClearances As Panel
    Friend WithEvents LblClearancesVal As Label
    Friend WithEvents LblClearancesSub As Label
    Friend WithEvents CardCollections As Panel
    Friend WithEvents LblCollectionsVal As Label
    Friend WithEvents LblCollectionsSub As Label
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents LblRecentTitle As Label
    Friend WithEvents DgvRecent As DataGridView
End Class
