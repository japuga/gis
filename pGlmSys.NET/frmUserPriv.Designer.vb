<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUserPriv
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
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbUserDesc As System.Windows.Forms.ComboBox
	Public WithEvents cmdAddMember As System.Windows.Forms.Button
	Public WithEvents cmdRemoveMember As System.Windows.Forms.Button
	Public WithEvents dgState As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgAssgState As AxMSDataGridLib.AxDataGrid
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbUserName As System.Windows.Forms.ComboBox
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserPriv))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbUserDesc = New System.Windows.Forms.ComboBox
		Me.cmdAddMember = New System.Windows.Forms.Button
		Me.cmdRemoveMember = New System.Windows.Forms.Button
		Me.dgState = New AxMSDataGridLib.AxDataGrid
		Me.dgAssgState = New AxMSDataGridLib.AxDataGrid
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbUserName = New System.Windows.Forms.ComboBox
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripSeparator
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgState, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgAssgState, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "User Privileges"
		Me.ClientSize = New System.Drawing.Size(603, 363)
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
		Me.Name = "frmUserPriv"
		Me.cbCustName.Enabled = False
		Me.cbCustName.Size = New System.Drawing.Size(217, 21)
		Me.cbCustName.Location = New System.Drawing.Point(160, 128)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbCustName.TabIndex = 10
		Me.cbCustName.Text = "cbCustName"
		Me.cbCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustName.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustName.CausesValidation = True
		Me.cbCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustName.IntegralHeight = True
		Me.cbCustName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustName.Sorted = False
		Me.cbCustName.TabStop = True
		Me.cbCustName.Visible = True
		Me.cbCustName.Name = "cbCustName"
		Me.cbUserDesc.Enabled = False
		Me.cbUserDesc.Size = New System.Drawing.Size(177, 21)
		Me.cbUserDesc.Location = New System.Drawing.Point(200, 80)
		Me.cbUserDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbUserDesc.TabIndex = 8
		Me.cbUserDesc.Text = "cbUserDesc"
		Me.cbUserDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbUserDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbUserDesc.CausesValidation = True
		Me.cbUserDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbUserDesc.IntegralHeight = True
		Me.cbUserDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbUserDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbUserDesc.Sorted = False
		Me.cbUserDesc.TabStop = True
		Me.cbUserDesc.Visible = True
		Me.cbUserDesc.Name = "cbUserDesc"
		Me.cmdAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAddMember.Text = "<"
		Me.cmdAddMember.Size = New System.Drawing.Size(41, 25)
		Me.cmdAddMember.Location = New System.Drawing.Point(288, 264)
		Me.cmdAddMember.TabIndex = 7
		Me.cmdAddMember.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAddMember.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddMember.CausesValidation = True
		Me.cmdAddMember.Enabled = True
		Me.cmdAddMember.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddMember.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAddMember.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddMember.TabStop = True
		Me.cmdAddMember.Name = "cmdAddMember"
		Me.cmdRemoveMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRemoveMember.Text = ">"
		Me.cmdRemoveMember.Size = New System.Drawing.Size(41, 25)
		Me.cmdRemoveMember.Location = New System.Drawing.Point(288, 208)
		Me.cmdRemoveMember.TabIndex = 6
		Me.cmdRemoveMember.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRemoveMember.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRemoveMember.CausesValidation = True
		Me.cmdRemoveMember.Enabled = True
		Me.cmdRemoveMember.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRemoveMember.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRemoveMember.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRemoveMember.TabStop = True
		Me.cmdRemoveMember.Name = "cmdRemoveMember"
		dgState.OcxState = CType(resources.GetObject("dgState.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgState.Size = New System.Drawing.Size(217, 145)
		Me.dgState.Location = New System.Drawing.Point(360, 184)
		Me.dgState.TabIndex = 5
		Me.dgState.Name = "dgState"
		dgAssgState.OcxState = CType(resources.GetObject("dgAssgState.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgAssgState.Size = New System.Drawing.Size(217, 145)
		Me.dgAssgState.Location = New System.Drawing.Point(24, 184)
		Me.dgAssgState.TabIndex = 4
		Me.dgAssgState.Name = "dgAssgState"
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(80, 128)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 3
		Me.cbCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustId.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustId.CausesValidation = True
		Me.cbCustId.Enabled = True
		Me.cbCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustId.IntegralHeight = True
		Me.cbCustId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustId.Sorted = False
		Me.cbCustId.TabStop = True
		Me.cbCustId.Visible = True
		Me.cbCustId.Name = "cbCustId"
		Me.cbUserName.Size = New System.Drawing.Size(97, 21)
		Me.cbUserName.Location = New System.Drawing.Point(80, 80)
		Me.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbUserName.TabIndex = 1
		Me.cbUserName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbUserName.BackColor = System.Drawing.SystemColors.Window
		Me.cbUserName.CausesValidation = True
		Me.cbUserName.Enabled = True
		Me.cbUserName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbUserName.IntegralHeight = True
		Me.cbUserName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbUserName.Sorted = False
		Me.cbUserName.TabStop = True
		Me.cbUserName.Visible = True
		Me.cbUserName.Name = "cbUserName"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(603, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 9
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button2.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button2.AutoSize = False
		Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button2.ToolTipText = "Exit without changes"
		Me._Toolbar1_Button2.Width = 10
		Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Label2.Text = "Customer"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 128)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "User"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 80)
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
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(cbUserDesc)
		Me.Controls.Add(cmdAddMember)
		Me.Controls.Add(cmdRemoveMember)
		Me.Controls.Add(dgState)
		Me.Controls.Add(dgAssgState)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbUserName)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button2)
		CType(Me.dgAssgState, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgState, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class