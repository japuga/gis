<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUserEntry
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdPassword As System.Windows.Forms.Button
	Public WithEvents cbTypeId As System.Windows.Forms.ComboBox
	Public WithEvents cbTypeName As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtUserDesc As System.Windows.Forms.TextBox
	Public WithEvents txtUserName As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPassword = New System.Windows.Forms.Button
        Me.cbTypeId = New System.Windows.Forms.ComboBox
        Me.cbTypeName = New System.Windows.Forms.ComboBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.txtUserDesc = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdPassword
        '
        Me.cmdPassword.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPassword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPassword.Location = New System.Drawing.Point(224, 24)
        Me.cmdPassword.Name = "cmdPassword"
        Me.cmdPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPassword.Size = New System.Drawing.Size(129, 25)
        Me.cmdPassword.TabIndex = 9
        Me.cmdPassword.Text = "Change Password"
        Me.cmdPassword.UseVisualStyleBackColor = False
        '
        'cbTypeId
        '
        Me.cbTypeId.BackColor = System.Drawing.SystemColors.Window
        Me.cbTypeId.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeId.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbTypeId.Location = New System.Drawing.Point(288, 104)
        Me.cbTypeId.Name = "cbTypeId"
        Me.cbTypeId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbTypeId.Size = New System.Drawing.Size(65, 22)
        Me.cbTypeId.TabIndex = 8
        Me.cbTypeId.Visible = False
        '
        'cbTypeName
        '
        Me.cbTypeName.BackColor = System.Drawing.SystemColors.Window
        Me.cbTypeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbTypeName.Location = New System.Drawing.Point(104, 104)
        Me.cbTypeName.Name = "cbTypeName"
        Me.cbTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbTypeName.Size = New System.Drawing.Size(169, 22)
        Me.cbTypeName.TabIndex = 7
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(200, 160)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(65, 41)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(104, 160)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(65, 41)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'txtUserDesc
        '
        Me.txtUserDesc.AcceptsReturn = True
        Me.txtUserDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserDesc.Location = New System.Drawing.Point(104, 64)
        Me.txtUserDesc.MaxLength = 0
        Me.txtUserDesc.Name = "txtUserDesc"
        Me.txtUserDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserDesc.Size = New System.Drawing.Size(241, 21)
        Me.txtUserDesc.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.AcceptsReturn = True
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserName.Location = New System.Drawing.Point(104, 24)
        Me.txtUserName.MaxLength = 0
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserName.Size = New System.Drawing.Size(105, 21)
        Me.txtUserName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'frmUserEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(369, 227)
        Me.Controls.Add(Me.cmdPassword)
        Me.Controls.Add(Me.cbTypeId)
        Me.Controls.Add(Me.cbTypeName)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtUserDesc)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(299, 112)
        Me.Name = "frmUserEntry"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "User Data Entry"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class