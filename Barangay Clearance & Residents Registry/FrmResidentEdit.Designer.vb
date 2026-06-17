<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmResidentEdit
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
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.LblSex = New System.Windows.Forms.Label()
        Me.CboSex = New System.Windows.Forms.ComboBox()
        Me.LblBirthDate = New System.Windows.Forms.Label()
        Me.DtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LblContact = New System.Windows.Forms.Label()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.LblCivilStatus = New System.Windows.Forms.Label()
        Me.CboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblHeader = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblFullName.Location = New System.Drawing.Point(25, 75)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(73, 15)
        Me.LblFullName.TabIndex = 0
        Me.LblFullName.Text = "Full Name: *"
        '
        'TxtFullName
        '
        Me.TxtFullName.Location = New System.Drawing.Point(120, 72)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(260, 23)
        Me.TxtFullName.TabIndex = 1
        '
        'LblSex
        '
        Me.LblSex.AutoSize = True
        Me.LblSex.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblSex.Location = New System.Drawing.Point(25, 115)
        Me.LblSex.Name = "LblSex"
        Me.LblSex.Size = New System.Drawing.Size(39, 15)
        Me.LblSex.TabIndex = 2
        Me.LblSex.Text = "Sex: *"
        '
        'CboSex
        '
        Me.CboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSex.FormattingEnabled = True
        Me.CboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSex.Location = New System.Drawing.Point(120, 112)
        Me.CboSex.Name = "CboSex"
        Me.CboSex.Size = New System.Drawing.Size(120, 23)
        Me.CboSex.TabIndex = 3
        '
        'LblBirthDate
        '
        Me.LblBirthDate.AutoSize = True
        Me.LblBirthDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblBirthDate.Location = New System.Drawing.Point(25, 155)
        Me.LblBirthDate.Name = "LblBirthDate"
        Me.LblBirthDate.Size = New System.Drawing.Size(76, 15)
        Me.LblBirthDate.TabIndex = 4
        Me.LblBirthDate.Text = "Birth Date: *"
        '
        'DtpBirthDate
        '
        Me.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpBirthDate.Location = New System.Drawing.Point(120, 152)
        Me.DtpBirthDate.Name = "DtpBirthDate"
        Me.DtpBirthDate.Size = New System.Drawing.Size(120, 23)
        Me.DtpBirthDate.TabIndex = 5
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblAddress.Location = New System.Drawing.Point(25, 195)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(63, 15)
        Me.LblAddress.TabIndex = 6
        Me.LblAddress.Text = "Address: *"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(120, 192)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(260, 50)
        Me.TxtAddress.TabIndex = 7
        '
        'LblContact
        '
        Me.LblContact.AutoSize = True
        Me.LblContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblContact.Location = New System.Drawing.Point(25, 258)
        Me.LblContact.Name = "LblContact"
        Me.LblContact.Size = New System.Drawing.Size(74, 15)
        Me.LblContact.TabIndex = 8
        Me.LblContact.Text = "Contact No.:"
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(120, 255)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(260, 23)
        Me.TxtContact.TabIndex = 9
        '
        'LblCivilStatus
        '
        Me.LblCivilStatus.AutoSize = True
        Me.LblCivilStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCivilStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblCivilStatus.Location = New System.Drawing.Point(25, 298)
        Me.LblCivilStatus.Name = "LblCivilStatus"
        Me.LblCivilStatus.Size = New System.Drawing.Size(78, 15)
        Me.LblCivilStatus.TabIndex = 10
        Me.LblCivilStatus.Text = "Civil Status: *"
        '
        'CboCivilStatus
        '
        Me.CboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCivilStatus.FormattingEnabled = True
        Me.CboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        Me.CboCivilStatus.Location = New System.Drawing.Point(120, 295)
        Me.CboCivilStatus.Name = "CboCivilStatus"
        Me.CboCivilStatus.Size = New System.Drawing.Size(120, 23)
        Me.CboCivilStatus.TabIndex = 11
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(224, 345)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save"
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
        Me.BtnCancel.Location = New System.Drawing.Point(305, 345)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancel.TabIndex = 13
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
        Me.PanelHeader.Size = New System.Drawing.Size(410, 50)
        Me.PanelHeader.TabIndex = 14
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LblHeader.Location = New System.Drawing.Point(20, 15)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(155, 21)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Resident Information"
        '
        'FrmResidentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 400)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CboCivilStatus)
        Me.Controls.Add(Me.LblCivilStatus)
        Me.Controls.Add(Me.TxtContact)
        Me.Controls.Add(Me.LblContact)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.DtpBirthDate)
        Me.Controls.Add(Me.LblBirthDate)
        Me.Controls.Add(Me.CboSex)
        Me.Controls.Add(Me.LblSex)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.LblFullName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmResidentEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resident Edit Form"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFullName As Label
    Friend WithEvents TxtFullName As TextBox
    Friend WithEvents LblSex As Label
    Friend WithEvents CboSex As ComboBox
    Friend WithEvents LblBirthDate As Label
    Friend WithEvents DtpBirthDate As DateTimePicker
    Friend WithEvents LblAddress As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LblContact As Label
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents LblCivilStatus As Label
    Friend WithEvents CboCivilStatus As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblHeader As Label
End Class
