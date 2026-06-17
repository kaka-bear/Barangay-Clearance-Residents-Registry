<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClearancesList
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
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.ChkDateRange = New System.Windows.Forms.CheckBox()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.CboClearanceType = New System.Windows.Forms.ComboBox()
        Me.LblClearanceType = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CboSort = New System.Windows.Forms.ComboBox()
        Me.LblSort = New System.Windows.Forms.Label()
        Me.TxtResidentName = New System.Windows.Forms.TextBox()
        Me.LblResidentName = New System.Windows.Forms.Label()
        Me.PanelActions = New System.Windows.Forms.Panel()
        Me.BtnPrintReport = New System.Windows.Forms.Button()
        Me.BtnCancelClearance = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.DgvClearances = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PanelHeader.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.PanelActions.SuspendLayout()
        CType(Me.DgvClearances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblHeader)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(950, 50)
        Me.PanelHeader.TabIndex = 0
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(12, 12)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(183, 25)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Clearances Registry"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.Color.White
        Me.PanelSearch.Controls.Add(Me.ChkDateRange)
        Me.PanelSearch.Controls.Add(Me.DtpTo)
        Me.PanelSearch.Controls.Add(Me.LblTo)
        Me.PanelSearch.Controls.Add(Me.DtpFrom)
        Me.PanelSearch.Controls.Add(Me.LblFrom)
        Me.PanelSearch.Controls.Add(Me.CboClearanceType)
        Me.PanelSearch.Controls.Add(Me.LblClearanceType)
        Me.PanelSearch.Controls.Add(Me.BtnClear)
        Me.PanelSearch.Controls.Add(Me.BtnSearch)
        Me.PanelSearch.Controls.Add(Me.CboSort)
        Me.PanelSearch.Controls.Add(Me.LblSort)
        Me.PanelSearch.Controls.Add(Me.TxtResidentName)
        Me.PanelSearch.Controls.Add(Me.LblResidentName)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 50)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(950, 100)
        Me.PanelSearch.TabIndex = 1
        '
        'ChkDateRange
        '
        Me.ChkDateRange.AutoSize = True
        Me.ChkDateRange.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDateRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ChkDateRange.Location = New System.Drawing.Point(16, 61)
        Me.ChkDateRange.Name = "ChkDateRange"
        Me.ChkDateRange.Size = New System.Drawing.Size(124, 19)
        Me.ChkDateRange.TabIndex = 14
        Me.ChkDateRange.Text = "Filter Issue Dates:"
        Me.ChkDateRange.UseVisualStyleBackColor = True
        '
        'DtpTo
        '
        Me.DtpTo.Enabled = False
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpTo.Location = New System.Drawing.Point(344, 59)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(110, 23)
        Me.DtpTo.TabIndex = 13
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblTo.Location = New System.Drawing.Point(315, 62)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 15)
        Me.LblTo.TabIndex = 12
        Me.LblTo.Text = "To:"
        '
        'DtpFrom
        '
        Me.DtpFrom.Enabled = False
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpFrom.Location = New System.Drawing.Point(195, 59)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(110, 23)
        Me.DtpFrom.TabIndex = 11
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblFrom.Location = New System.Drawing.Point(150, 62)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(39, 15)
        Me.LblFrom.TabIndex = 10
        Me.LblFrom.Text = "From:"
        '
        'CboClearanceType
        '
        Me.CboClearanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClearanceType.FormattingEnabled = True
        Me.CboClearanceType.Location = New System.Drawing.Point(415, 20)
        Me.CboClearanceType.Name = "CboClearanceType"
        Me.CboClearanceType.Size = New System.Drawing.Size(150, 23)
        Me.CboClearanceType.TabIndex = 5
        '
        'LblClearanceType
        '
        Me.LblClearanceType.AutoSize = True
        Me.LblClearanceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClearanceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblClearanceType.Location = New System.Drawing.Point(315, 23)
        Me.LblClearanceType.Name = "LblClearanceType"
        Me.LblClearanceType.Size = New System.Drawing.Size(94, 15)
        Me.LblClearanceType.TabIndex = 4
        Me.LblClearanceType.Text = "Clearance Type:"
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatAppearance.BorderSize = 0
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(863, 37)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 25)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(782, 37)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 25)
        Me.BtnSearch.TabIndex = 8
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'CboSort
        '
        Me.CboSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSort.FormattingEnabled = True
        Me.CboSort.Items.AddRange(New Object() {"Issue Date", "Resident Name", "Fee"})
        Me.CboSort.Location = New System.Drawing.Point(640, 20)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(120, 23)
        Me.CboSort.TabIndex = 7
        '
        'LblSort
        '
        Me.LblSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSort.AutoSize = True
        Me.LblSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblSort.Location = New System.Drawing.Point(585, 23)
        Me.LblSort.Name = "LblSort"
        Me.LblSort.Size = New System.Drawing.Size(49, 15)
        Me.LblSort.TabIndex = 6
        Me.LblSort.Text = "Sort By:"
        '
        'TxtResidentName
        '
        Me.TxtResidentName.Location = New System.Drawing.Point(120, 20)
        Me.TxtResidentName.Name = "TxtResidentName"
        Me.TxtResidentName.Size = New System.Drawing.Size(180, 23)
        Me.TxtResidentName.TabIndex = 1
        '
        'LblResidentName
        '
        Me.LblResidentName.AutoSize = True
        Me.LblResidentName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResidentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblResidentName.Location = New System.Drawing.Point(12, 23)
        Me.LblResidentName.Name = "LblResidentName"
        Me.LblResidentName.Size = New System.Drawing.Size(92, 15)
        Me.LblResidentName.TabIndex = 0
        Me.LblResidentName.Text = "Resident Name:"
        '
        'PanelActions
        '
        Me.PanelActions.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelActions.Controls.Add(Me.BtnPrintReport)
        Me.PanelActions.Controls.Add(Me.BtnCancelClearance)
        Me.PanelActions.Controls.Add(Me.BtnAdd)
        Me.PanelActions.Controls.Add(Me.BtnRefresh)
        Me.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelActions.Location = New System.Drawing.Point(0, 490)
        Me.PanelActions.Name = "PanelActions"
        Me.PanelActions.Size = New System.Drawing.Size(950, 60)
        Me.PanelActions.TabIndex = 2
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintReport.FlatAppearance.BorderSize = 0
        Me.BtnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintReport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintReport.ForeColor = System.Drawing.Color.White
        Me.BtnPrintReport.Location = New System.Drawing.Point(828, 15)
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(110, 30)
        Me.BtnPrintReport.TabIndex = 4
        Me.BtnPrintReport.Text = "🖨 Print Report"
        Me.BtnPrintReport.UseVisualStyleBackColor = False
        '
        'BtnCancelClearance
        '
        Me.BtnCancelClearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnCancelClearance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelClearance.FlatAppearance.BorderSize = 0
        Me.BtnCancelClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelClearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelClearance.ForeColor = System.Drawing.Color.White
        Me.BtnCancelClearance.Location = New System.Drawing.Point(138, 15)
        Me.BtnCancelClearance.Name = "BtnCancelClearance"
        Me.BtnCancelClearance.Size = New System.Drawing.Size(120, 30)
        Me.BtnCancelClearance.TabIndex = 3
        Me.BtnCancelClearance.Text = "🛑 Cancel Clearance"
        Me.BtnCancelClearance.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(12, 15)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(120, 30)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "➕ Issue Clearance"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(264, 15)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.BtnRefresh.TabIndex = 0
        Me.BtnRefresh.Text = "↻ Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'DgvClearances
        '
        Me.DgvClearances.AllowUserToAddRows = False
        Me.DgvClearances.AllowUserToDeleteRows = False
        Me.DgvClearances.AllowUserToResizeRows = False
        Me.DgvClearances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvClearances.BackgroundColor = System.Drawing.Color.White
        Me.DgvClearances.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvClearances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvClearances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        dataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(116, Byte), Integer))
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvClearances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        Me.DgvClearances.ColumnHeadersHeight = 35
        Me.DgvClearances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(143, Byte), Integer))
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(116, Byte), Integer))
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvClearances.DefaultCellStyle = dataGridViewCellStyle2
        Me.DgvClearances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvClearances.EnableHeadersVisualStyles = False
        Me.DgvClearances.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DgvClearances.Location = New System.Drawing.Point(0, 150)
        Me.DgvClearances.MultiSelect = False
        Me.DgvClearances.Name = "DgvClearances"
        Me.DgvClearances.ReadOnly = True
        Me.DgvClearances.RowHeadersVisible = False
        Me.DgvClearances.RowTemplate.Height = 30
        Me.DgvClearances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvClearances.Size = New System.Drawing.Size(950, 340)
        Me.DgvClearances.TabIndex = 3
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmClearancesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.MinimumSize = New System.Drawing.Size(966, 589)
        Me.Controls.Add(Me.DgvClearances)
        Me.Controls.Add(Me.PanelActions)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmClearancesList"
        Me.Text = "Clearances Log Registry"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.PanelActions.ResumeLayout(False)
        CType(Me.DgvClearances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblHeader As Label
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents TxtResidentName As TextBox
    Friend WithEvents LblResidentName As Label
    Friend WithEvents CboSort As ComboBox
    Friend WithEvents LblSort As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CboClearanceType As ComboBox
    Friend WithEvents LblClearanceType As Label
    Friend WithEvents ChkDateRange As CheckBox
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents LblTo As Label
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents LblFrom As Label
    Friend WithEvents PanelActions As Panel
    Friend WithEvents BtnPrintReport As Button
    Friend WithEvents BtnCancelClearance As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents DgvClearances As DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
