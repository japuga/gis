<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckRenumber
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
	Public WithEvents txtNewCheck As System.Windows.Forms.TextBox
	Public WithEvents txtCurrentCheck As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckRenumber))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtNewCheck = New System.Windows.Forms.TextBox
		Me.txtCurrentCheck = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Check Renumbering"
		Me.ClientSize = New System.Drawing.Size(262, 239)
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
		Me.Name = "frmCheckRenumber"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(144, 176)
		Me.cmdCancel.TabIndex = 5
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
		Me.cmdOk.Location = New System.Drawing.Point(56, 176)
		Me.cmdOk.TabIndex = 4
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtNewCheck.AutoSize = False
		Me.txtNewCheck.Size = New System.Drawing.Size(81, 21)
		Me.txtNewCheck.Location = New System.Drawing.Point(112, 112)
		Me.txtNewCheck.TabIndex = 3
		Me.txtNewCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNewCheck.AcceptsReturn = True
		Me.txtNewCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNewCheck.BackColor = System.Drawing.SystemColors.Window
		Me.txtNewCheck.CausesValidation = True
		Me.txtNewCheck.Enabled = True
		Me.txtNewCheck.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNewCheck.HideSelection = True
		Me.txtNewCheck.ReadOnly = False
		Me.txtNewCheck.Maxlength = 0
		Me.txtNewCheck.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNewCheck.MultiLine = False
		Me.txtNewCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNewCheck.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNewCheck.TabStop = True
		Me.txtNewCheck.Visible = True
		Me.txtNewCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNewCheck.Name = "txtNewCheck"
		Me.txtCurrentCheck.AutoSize = False
		Me.txtCurrentCheck.Size = New System.Drawing.Size(81, 21)
		Me.txtCurrentCheck.Location = New System.Drawing.Point(112, 72)
		Me.txtCurrentCheck.TabIndex = 2
		Me.txtCurrentCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCurrentCheck.AcceptsReturn = True
		Me.txtCurrentCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCurrentCheck.BackColor = System.Drawing.SystemColors.Window
		Me.txtCurrentCheck.CausesValidation = True
		Me.txtCurrentCheck.Enabled = True
		Me.txtCurrentCheck.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCurrentCheck.HideSelection = True
		Me.txtCurrentCheck.ReadOnly = False
		Me.txtCurrentCheck.Maxlength = 0
		Me.txtCurrentCheck.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCurrentCheck.MultiLine = False
		Me.txtCurrentCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCurrentCheck.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCurrentCheck.TabStop = True
		Me.txtCurrentCheck.Visible = True
		Me.txtCurrentCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCurrentCheck.Name = "txtCurrentCheck"
		Me.Label3.Text = "Please  enter New  Check Number"
		Me.Label3.Size = New System.Drawing.Size(193, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 32)
		Me.Label3.TabIndex = 6
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
		Me.Label2.Text = "New Check"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 112)
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
		Me.label1.Text = "Current Check"
		Me.label1.Size = New System.Drawing.Size(73, 17)
		Me.label1.Location = New System.Drawing.Point(24, 72)
		Me.label1.TabIndex = 0
		Me.label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label1.BackColor = System.Drawing.SystemColors.Control
		Me.label1.Enabled = True
		Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label1.UseMnemonic = True
		Me.label1.Visible = True
		Me.label1.AutoSize = False
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label1.Name = "label1"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtNewCheck)
		Me.Controls.Add(txtCurrentCheck)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class