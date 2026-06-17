<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClearanceTypeEdit
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
        Me.LblTypeName = New System.Windows.Forms.Label()
        Me.TxtTypeName = New System.Windows.Forms.TextBox()
        Me.LblDefaultFee = New System.Windows.Forms.Label()
        Me.NumDefaultFee = New System.Windows.Forms.NumericUpDown()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblHeader = New System.Windows.Forms.Label()
        CType(Me.NumDefaultFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTypeName
        '
        Me.LblTypeName.AutoSize = True
        Me.LblTypeName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblTypeName.Location = New System.Drawing.Point(25, 80)
        Me.LblTypeName.Name = "LblTypeName"
        Me.LblTypeName.Size = New System.Drawing.Size(96, 15)
        Me.LblTypeName.TabIndex = 0
        Me.LblTypeName.Text = "Template Name: *"
        '
        'TxtTypeName
        '
        Me.TxtTypeName.Location = New System.Drawing.Point(135, 77)
        Me.TxtTypeName.Name = "TxtTypeName"
        Me.TxtTypeName.Size = New System.Drawing.Size(220, 23)
        Me.TxtTypeName.TabIndex = 1
        '
        'LblDefaultFee
        '
        Me.LblDefaultFee.AutoSize = True
        Me.LblDefaultFee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDefaultFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblDefaultFee.Location = New System.Drawing.Point(25, 125)
        Me.LblDefaultFee.Name = "LblDefaultFee"
        Me.LblDefaultFee.Size = New System.Drawing.Size(81, 15)
        Me.LblDefaultFee.TabIndex = 2
        Me.LblDefaultFee.Text = "Default Fee: *"
        '
        'NumDefaultFee
        '
        Me.NumDefaultFee.DecimalPlaces = 2
        Me.NumDefaultFee.Location = New System.Drawing.Point(135, 123)
        Me.NumDefaultFee.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumDefaultFee.Name = "NumDefaultFee"
        Me.NumDefaultFee.Size = New System.Drawing.Size(120, 23)
        Me.NumDefaultFee.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(199, 175)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 4
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
        Me.BtnCancel.Location = New System.Drawing.Point(280, 175)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancel.TabIndex = 5
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
        Me.PanelHeader.Size = New System.Drawing.Size(380, 50)
        Me.PanelHeader.TabIndex = 6
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LblHeader.Location = New System.Drawing.Point(20, 15)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(183, 21)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Clearance Type Details"
        '
        'FrmClearanceTypeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 225)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NumDefaultFee)
        Me.Controls.Add(Me.LblDefaultFee)
        Me.Controls.Add(Me.TxtTypeName)
        Me.Controls.Add(Me.LblTypeName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmClearanceTypeEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clearance Type Edit Form"
        CType(Me.NumDefaultFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTypeName As Label
    Friend WithEvents TxtTypeName As TextBox
    Friend WithEvents LblDefaultFee As Label
    Friend WithEvents NumDefaultFee As NumericUpDown
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblHeader As Label
End Class
