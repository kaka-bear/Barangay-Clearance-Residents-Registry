<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClearanceEdit
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
        Me.LblResident = New System.Windows.Forms.Label()
        Me.CboResident = New System.Windows.Forms.ComboBox()
        Me.LblClearanceType = New System.Windows.Forms.Label()
        Me.CboClearanceType = New System.Windows.Forms.ComboBox()
        Me.LblFee = New System.Windows.Forms.Label()
        Me.TxtFee = New System.Windows.Forms.TextBox()
        Me.LblORNo = New System.Windows.Forms.Label()
        Me.TxtORNo = New System.Windows.Forms.TextBox()
        Me.LblIssueDate = New System.Windows.Forms.Label()
        Me.DtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.LblPurpose = New System.Windows.Forms.Label()
        Me.TxtPurpose = New System.Windows.Forms.TextBox()
        Me.LblPaymentMethod = New System.Windows.Forms.Label()
        Me.CboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.ChkSimulateError = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblHeader = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblResident
        '
        Me.LblResident.AutoSize = True
        Me.LblResident.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblResident.Location = New System.Drawing.Point(25, 75)
        Me.LblResident.Name = "LblResident"
        Me.LblResident.Size = New System.Drawing.Size(66, 15)
        Me.LblResident.TabIndex = 0
        Me.LblResident.Text = "Resident: *"
        '
        'CboResident
        '
        Me.CboResident.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboResident.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboResident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboResident.FormattingEnabled = True
        Me.CboResident.Location = New System.Drawing.Point(135, 72)
        Me.CboResident.Name = "CboResident"
        Me.CboResident.Size = New System.Drawing.Size(260, 23)
        Me.CboResident.TabIndex = 1
        '
        'LblClearanceType
        '
        Me.LblClearanceType.AutoSize = True
        Me.LblClearanceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClearanceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblClearanceType.Location = New System.Drawing.Point(25, 115)
        Me.LblClearanceType.Name = "LblClearanceType"
        Me.LblClearanceType.Size = New System.Drawing.Size(99, 15)
        Me.LblClearanceType.TabIndex = 2
        Me.LblClearanceType.Text = "Clearance Type: *"
        '
        'CboClearanceType
        '
        Me.CboClearanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClearanceType.FormattingEnabled = True
        Me.CboClearanceType.Location = New System.Drawing.Point(135, 112)
        Me.CboClearanceType.Name = "CboClearanceType"
        Me.CboClearanceType.Size = New System.Drawing.Size(260, 23)
        Me.CboClearanceType.TabIndex = 3
        '
        'LblFee
        '
        Me.LblFee.AutoSize = True
        Me.LblFee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblFee.Location = New System.Drawing.Point(25, 155)
        Me.LblFee.Name = "LblFee"
        Me.LblFee.Size = New System.Drawing.Size(43, 15)
        Me.LblFee.TabIndex = 4
        Me.LblFee.Text = "Fee: ₱*"
        '
        'TxtFee
        '
        Me.TxtFee.Location = New System.Drawing.Point(135, 152)
        Me.TxtFee.Name = "TxtFee"
        Me.TxtFee.ReadOnly = True
        Me.TxtFee.Size = New System.Drawing.Size(120, 23)
        Me.TxtFee.TabIndex = 5
        Me.TxtFee.TabStop = False
        '
        'LblORNo
        '
        Me.LblORNo.AutoSize = True
        Me.LblORNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblORNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblORNo.Location = New System.Drawing.Point(25, 195)
        Me.LblORNo.Name = "LblORNo"
        Me.LblORNo.Size = New System.Drawing.Size(84, 15)
        Me.LblORNo.TabIndex = 6
        Me.LblORNo.Text = "OR Number: *"
        '
        'TxtORNo
        '
        Me.TxtORNo.Location = New System.Drawing.Point(135, 192)
        Me.TxtORNo.Name = "TxtORNo"
        Me.TxtORNo.Size = New System.Drawing.Size(120, 23)
        Me.TxtORNo.TabIndex = 7
        '
        'LblIssueDate
        '
        Me.LblIssueDate.AutoSize = True
        Me.LblIssueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIssueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblIssueDate.Location = New System.Drawing.Point(25, 235)
        Me.LblIssueDate.Name = "LblIssueDate"
        Me.LblIssueDate.Size = New System.Drawing.Size(76, 15)
        Me.LblIssueDate.TabIndex = 8
        Me.LblIssueDate.Text = "Issue Date: *"
        '
        'DtpIssueDate
        '
        Me.DtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpIssueDate.Location = New System.Drawing.Point(135, 232)
        Me.DtpIssueDate.Name = "DtpIssueDate"
        Me.DtpIssueDate.Size = New System.Drawing.Size(120, 23)
        Me.DtpIssueDate.TabIndex = 9
        '
        'LblPurpose
        '
        Me.LblPurpose.AutoSize = True
        Me.LblPurpose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblPurpose.Location = New System.Drawing.Point(25, 275)
        Me.LblPurpose.Name = "LblPurpose"
        Me.LblPurpose.Size = New System.Drawing.Size(63, 15)
        Me.LblPurpose.TabIndex = 10
        Me.LblPurpose.Text = "Purpose: *"
        '
        'TxtPurpose
        '
        Me.TxtPurpose.Location = New System.Drawing.Point(135, 272)
        Me.TxtPurpose.Name = "TxtPurpose"
        Me.TxtPurpose.Size = New System.Drawing.Size(260, 23)
        Me.TxtPurpose.TabIndex = 11
        '
        'LblPaymentMethod
        '
        Me.LblPaymentMethod.AutoSize = True
        Me.LblPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblPaymentMethod.Location = New System.Drawing.Point(25, 315)
        Me.LblPaymentMethod.Name = "LblPaymentMethod"
        Me.LblPaymentMethod.Size = New System.Drawing.Size(92, 15)
        Me.LblPaymentMethod.TabIndex = 12
        Me.LblPaymentMethod.Text = "Pay Method: *"
        '
        'CboPaymentMethod
        '
        Me.CboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPaymentMethod.FormattingEnabled = True
        Me.CboPaymentMethod.Items.AddRange(New Object() {"Cash", "GCash", "PayMaya", "Bank Transfer"})
        Me.CboPaymentMethod.Location = New System.Drawing.Point(135, 312)
        Me.CboPaymentMethod.Name = "CboPaymentMethod"
        Me.CboPaymentMethod.Size = New System.Drawing.Size(120, 23)
        Me.CboPaymentMethod.TabIndex = 13
        '
        'ChkSimulateError
        '
        Me.ChkSimulateError.AutoSize = True
        Me.ChkSimulateError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSimulateError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ChkSimulateError.Location = New System.Drawing.Point(25, 355)
        Me.ChkSimulateError.Name = "ChkSimulateError"
        Me.ChkSimulateError.Size = New System.Drawing.Size(262, 19)
        Me.ChkSimulateError.TabIndex = 14
        Me.ChkSimulateError.Text = "Simulate Transaction Failure (Force Rollback)"
        Me.ChkSimulateError.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(219, 395)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 30)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Issue / Pay"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(315, 395)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 30)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblHeader)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(430, 50)
        Me.PanelHeader.TabIndex = 17
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LblHeader.Location = New System.Drawing.Point(20, 15)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(206, 21)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "New Clearance Certificate"
        '
        'FrmClearanceEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 445)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.ChkSimulateError)
        Me.Controls.Add(Me.CboPaymentMethod)
        Me.Controls.Add(Me.LblPaymentMethod)
        Me.Controls.Add(Me.TxtPurpose)
        Me.Controls.Add(Me.LblPurpose)
        Me.Controls.Add(Me.DtpIssueDate)
        Me.Controls.Add(Me.LblIssueDate)
        Me.Controls.Add(Me.TxtORNo)
        Me.Controls.Add(Me.LblORNo)
        Me.Controls.Add(Me.TxtFee)
        Me.Controls.Add(Me.LblFee)
        Me.Controls.Add(Me.CboClearanceType)
        Me.Controls.Add(Me.LblClearanceType)
        Me.Controls.Add(Me.CboResident)
        Me.Controls.Add(Me.LblResident)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmClearanceEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issue Clearance Certificate"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblResident As Label
    Friend WithEvents CboResident As ComboBox
    Friend WithEvents LblClearanceType As Label
    Friend WithEvents CboClearanceType As ComboBox
    Friend WithEvents LblFee As Label
    Friend WithEvents TxtFee As TextBox
    Friend WithEvents LblORNo As Label
    Friend WithEvents TxtORNo As TextBox
    Friend WithEvents LblIssueDate As Label
    Friend WithEvents DtpIssueDate As DateTimePicker
    Friend WithEvents LblPurpose As Label
    Friend WithEvents TxtPurpose As TextBox
    Friend WithEvents LblPaymentMethod As Label
    Friend WithEvents CboPaymentMethod As ComboBox
    Friend WithEvents ChkSimulateError As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblHeader As Label
End Class
