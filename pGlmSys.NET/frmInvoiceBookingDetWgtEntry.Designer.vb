<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInvoiceBookingDetWgtEntry
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
	Public WithEvents cbWeightUnitType As System.Windows.Forms.ComboBox
	Public WithEvents txtQty As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents dtTicketDate As AxMSComCtl2.AxDTPicker
	Public WithEvents txtTicket As System.Windows.Forms.TextBox
	Public WithEvents txtWeight As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInvoiceBookingDetWgtEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbWeightUnitType = New System.Windows.Forms.ComboBox
		Me.txtQty = New System.Windows.Forms.TextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.dtTicketDate = New AxMSComCtl2.AxDTPicker
		Me.txtTicket = New System.Windows.Forms.TextBox
		Me.txtWeight = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtTicketDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Weight Entry"
		Me.ClientSize = New System.Drawing.Size(312, 281)
		Me.Location = New System.Drawing.Point(647, 383)
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
		Me.Name = "frmInvoiceBookingDetWgtEntry"
		Me.cbWeightUnitType.Size = New System.Drawing.Size(81, 21)
		Me.cbWeightUnitType.Location = New System.Drawing.Point(208, 80)
		Me.cbWeightUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbWeightUnitType.TabIndex = 5
		Me.cbWeightUnitType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbWeightUnitType.BackColor = System.Drawing.SystemColors.Window
		Me.cbWeightUnitType.CausesValidation = True
		Me.cbWeightUnitType.Enabled = True
		Me.cbWeightUnitType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbWeightUnitType.IntegralHeight = True
		Me.cbWeightUnitType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbWeightUnitType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbWeightUnitType.Sorted = False
		Me.cbWeightUnitType.TabStop = True
		Me.cbWeightUnitType.Visible = True
		Me.cbWeightUnitType.Name = "cbWeightUnitType"
		Me.txtQty.AutoSize = False
		Me.txtQty.Size = New System.Drawing.Size(97, 21)
		Me.txtQty.Location = New System.Drawing.Point(96, 40)
		Me.txtQty.TabIndex = 1
		Me.txtQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQty.AcceptsReturn = True
		Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtQty.CausesValidation = True
		Me.txtQty.Enabled = True
		Me.txtQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQty.HideSelection = True
		Me.txtQty.ReadOnly = False
		Me.txtQty.Maxlength = 0
		Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQty.MultiLine = False
		Me.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQty.TabStop = True
		Me.txtQty.Visible = True
		Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQty.Name = "txtQty"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(176, 216)
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
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.cmdOK.Size = New System.Drawing.Size(65, 33)
		Me.cmdOK.Location = New System.Drawing.Point(64, 216)
		Me.cmdOK.TabIndex = 8
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		dtTicketDate.OcxState = CType(resources.GetObject("dtTicketDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtTicketDate.Size = New System.Drawing.Size(121, 21)
		Me.dtTicketDate.Location = New System.Drawing.Point(96, 168)
		Me.dtTicketDate.TabIndex = 7
		Me.dtTicketDate.Name = "dtTicketDate"
		Me.txtTicket.AutoSize = False
		Me.txtTicket.Size = New System.Drawing.Size(185, 21)
		Me.txtTicket.Location = New System.Drawing.Point(96, 120)
		Me.txtTicket.TabIndex = 6
		Me.txtTicket.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTicket.AcceptsReturn = True
		Me.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTicket.BackColor = System.Drawing.SystemColors.Window
		Me.txtTicket.CausesValidation = True
		Me.txtTicket.Enabled = True
		Me.txtTicket.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTicket.HideSelection = True
		Me.txtTicket.ReadOnly = False
		Me.txtTicket.Maxlength = 0
		Me.txtTicket.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTicket.MultiLine = False
		Me.txtTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTicket.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTicket.TabStop = True
		Me.txtTicket.Visible = True
		Me.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTicket.Name = "txtTicket"
		Me.txtWeight.AutoSize = False
		Me.txtWeight.Size = New System.Drawing.Size(97, 21)
		Me.txtWeight.Location = New System.Drawing.Point(96, 80)
		Me.txtWeight.TabIndex = 4
		Me.txtWeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWeight.AcceptsReturn = True
		Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWeight.BackColor = System.Drawing.SystemColors.Window
		Me.txtWeight.CausesValidation = True
		Me.txtWeight.Enabled = True
		Me.txtWeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWeight.HideSelection = True
		Me.txtWeight.ReadOnly = False
		Me.txtWeight.Maxlength = 0
		Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWeight.MultiLine = False
		Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWeight.TabStop = True
		Me.txtWeight.Visible = True
		Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWeight.Name = "txtWeight"
		Me.Label4.Text = "Qty"
		Me.Label4.Size = New System.Drawing.Size(57, 25)
		Me.Label4.Location = New System.Drawing.Point(24, 40)
		Me.Label4.TabIndex = 10
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
		Me.Label3.Text = "Date"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 168)
		Me.Label3.TabIndex = 3
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
		Me.Label2.Text = "PO Number / Ticket"
		Me.Label2.Size = New System.Drawing.Size(65, 33)
		Me.Label2.Location = New System.Drawing.Point(24, 120)
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
		Me.Label1.Text = "Weight"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
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
		Me.Controls.Add(cbWeightUnitType)
		Me.Controls.Add(txtQty)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(dtTicketDate)
		Me.Controls.Add(txtTicket)
		Me.Controls.Add(txtWeight)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.dtTicketDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class