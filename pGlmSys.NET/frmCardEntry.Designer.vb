<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCardEntry
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtCardBalance As System.Windows.Forms.TextBox
	Public WithEvents txtCardNumber As System.Windows.Forms.TextBox
	Public WithEvents cbCardtype As System.Windows.Forms.ComboBox
	Public WithEvents cbBankName As System.Windows.Forms.ComboBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCardEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtCardBalance = New System.Windows.Forms.TextBox
		Me.txtCardNumber = New System.Windows.Forms.TextBox
		Me.cbCardtype = New System.Windows.Forms.ComboBox
		Me.cbBankName = New System.Windows.Forms.ComboBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Credit Card Entry"
		Me.ClientSize = New System.Drawing.Size(312, 239)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCardEntry"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(168, 192)
		Me.cmdCancel.TabIndex = 9
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(73, 33)
		Me.cmdOk.Location = New System.Drawing.Point(72, 192)
		Me.cmdOk.TabIndex = 8
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtCardBalance.AutoSize = False
		Me.txtCardBalance.Size = New System.Drawing.Size(161, 19)
		Me.txtCardBalance.Location = New System.Drawing.Point(88, 144)
		Me.txtCardBalance.TabIndex = 7
		Me.txtCardBalance.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCardBalance.AcceptsReturn = True
		Me.txtCardBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCardBalance.BackColor = System.Drawing.SystemColors.Window
		Me.txtCardBalance.CausesValidation = True
		Me.txtCardBalance.Enabled = True
		Me.txtCardBalance.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCardBalance.HideSelection = True
		Me.txtCardBalance.ReadOnly = False
		Me.txtCardBalance.Maxlength = 0
		Me.txtCardBalance.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCardBalance.MultiLine = False
		Me.txtCardBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCardBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCardBalance.TabStop = True
		Me.txtCardBalance.Visible = True
		Me.txtCardBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCardBalance.Name = "txtCardBalance"
		Me.txtCardNumber.AutoSize = False
		Me.txtCardNumber.Size = New System.Drawing.Size(201, 19)
		Me.txtCardNumber.Location = New System.Drawing.Point(88, 104)
		Me.txtCardNumber.TabIndex = 6
		Me.txtCardNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCardNumber.AcceptsReturn = True
		Me.txtCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCardNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtCardNumber.CausesValidation = True
		Me.txtCardNumber.Enabled = True
		Me.txtCardNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCardNumber.HideSelection = True
		Me.txtCardNumber.ReadOnly = False
		Me.txtCardNumber.Maxlength = 0
		Me.txtCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCardNumber.MultiLine = False
		Me.txtCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCardNumber.TabStop = True
		Me.txtCardNumber.Visible = True
		Me.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCardNumber.Name = "txtCardNumber"
		Me.cbCardtype.Size = New System.Drawing.Size(169, 21)
		Me.cbCardtype.Location = New System.Drawing.Point(88, 64)
		Me.cbCardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCardtype.TabIndex = 5
		Me.cbCardtype.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCardtype.BackColor = System.Drawing.SystemColors.Window
		Me.cbCardtype.CausesValidation = True
		Me.cbCardtype.Enabled = True
		Me.cbCardtype.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCardtype.IntegralHeight = True
		Me.cbCardtype.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCardtype.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCardtype.Sorted = False
		Me.cbCardtype.TabStop = True
		Me.cbCardtype.Visible = True
		Me.cbCardtype.Name = "cbCardtype"
		Me.cbBankName.Size = New System.Drawing.Size(169, 21)
		Me.cbBankName.Location = New System.Drawing.Point(88, 24)
		Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankName.TabIndex = 4
		Me.cbBankName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBankName.BackColor = System.Drawing.SystemColors.Window
		Me.cbBankName.CausesValidation = True
		Me.cbBankName.Enabled = True
		Me.cbBankName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbBankName.IntegralHeight = True
		Me.cbBankName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbBankName.Sorted = False
		Me.cbBankName.TabStop = True
		Me.cbBankName.Visible = True
		Me.cbBankName.Name = "cbBankName"
		Me.Label4.Text = "Balance"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 144)
		Me.Label4.TabIndex = 3
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Bank"
		Me.Label3.Size = New System.Drawing.Size(41, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 24)
		Me.Label3.TabIndex = 2
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Card Number"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 104)
		Me.Label2.TabIndex = 1
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Type"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 64)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtCardBalance)
		Me.Controls.Add(txtCardNumber)
		Me.Controls.Add(cbCardtype)
		Me.Controls.Add(cbBankName)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class