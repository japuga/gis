<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustFeeBillRangeDet
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
	Public WithEvents txtRangeFeeValue As System.Windows.Forms.TextBox
	Public WithEvents txtUpperBound As System.Windows.Forms.TextBox
	Public WithEvents txtLowerBound As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustFeeBillRangeDet))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtRangeFeeValue = New System.Windows.Forms.TextBox
		Me.txtUpperBound = New System.Windows.Forms.TextBox
		Me.txtLowerBound = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Billing Range Detail"
		Me.ClientSize = New System.Drawing.Size(312, 228)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "frmCustFeeBillRangeDet"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(160, 168)
		Me.cmdCancel.TabIndex = 8
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
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(80, 168)
		Me.cmdOk.TabIndex = 7
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtRangeFeeValue.AutoSize = False
		Me.txtRangeFeeValue.Size = New System.Drawing.Size(113, 21)
		Me.txtRangeFeeValue.Location = New System.Drawing.Point(128, 120)
		Me.txtRangeFeeValue.TabIndex = 6
		Me.txtRangeFeeValue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRangeFeeValue.AcceptsReturn = True
		Me.txtRangeFeeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRangeFeeValue.BackColor = System.Drawing.SystemColors.Window
		Me.txtRangeFeeValue.CausesValidation = True
		Me.txtRangeFeeValue.Enabled = True
		Me.txtRangeFeeValue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRangeFeeValue.HideSelection = True
		Me.txtRangeFeeValue.ReadOnly = False
		Me.txtRangeFeeValue.Maxlength = 0
		Me.txtRangeFeeValue.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRangeFeeValue.MultiLine = False
		Me.txtRangeFeeValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRangeFeeValue.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRangeFeeValue.TabStop = True
		Me.txtRangeFeeValue.Visible = True
		Me.txtRangeFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRangeFeeValue.Name = "txtRangeFeeValue"
		Me.txtUpperBound.AutoSize = False
		Me.txtUpperBound.Size = New System.Drawing.Size(113, 21)
		Me.txtUpperBound.Location = New System.Drawing.Point(128, 80)
		Me.txtUpperBound.TabIndex = 4
		Me.txtUpperBound.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUpperBound.AcceptsReturn = True
		Me.txtUpperBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUpperBound.BackColor = System.Drawing.SystemColors.Window
		Me.txtUpperBound.CausesValidation = True
		Me.txtUpperBound.Enabled = True
		Me.txtUpperBound.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUpperBound.HideSelection = True
		Me.txtUpperBound.ReadOnly = False
		Me.txtUpperBound.Maxlength = 0
		Me.txtUpperBound.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUpperBound.MultiLine = False
		Me.txtUpperBound.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUpperBound.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUpperBound.TabStop = True
		Me.txtUpperBound.Visible = True
		Me.txtUpperBound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUpperBound.Name = "txtUpperBound"
		Me.txtLowerBound.AutoSize = False
		Me.txtLowerBound.Size = New System.Drawing.Size(113, 21)
		Me.txtLowerBound.Location = New System.Drawing.Point(128, 40)
		Me.txtLowerBound.TabIndex = 3
		Me.txtLowerBound.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLowerBound.AcceptsReturn = True
		Me.txtLowerBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLowerBound.BackColor = System.Drawing.SystemColors.Window
		Me.txtLowerBound.CausesValidation = True
		Me.txtLowerBound.Enabled = True
		Me.txtLowerBound.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLowerBound.HideSelection = True
		Me.txtLowerBound.ReadOnly = False
		Me.txtLowerBound.Maxlength = 0
		Me.txtLowerBound.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLowerBound.MultiLine = False
		Me.txtLowerBound.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLowerBound.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLowerBound.TabStop = True
		Me.txtLowerBound.Visible = True
		Me.txtLowerBound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLowerBound.Name = "txtLowerBound"
		Me.Label4.Text = "Value"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(40, 120)
		Me.Label4.TabIndex = 5
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
		Me.Label3.Text = "(Not Inclusive)"
		Me.Label3.Size = New System.Drawing.Size(81, 17)
		Me.Label3.Location = New System.Drawing.Point(40, 88)
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
		Me.Label2.Text = "To Amount"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.Location = New System.Drawing.Point(40, 72)
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
		Me.Label1.Text = "From Amount"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 40)
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
		Me.Controls.Add(txtRangeFeeValue)
		Me.Controls.Add(txtUpperBound)
		Me.Controls.Add(txtLowerBound)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class