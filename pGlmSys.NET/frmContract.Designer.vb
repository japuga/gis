<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContract
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
	Public WithEvents dgContract As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgEquipment As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgStore As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents cmdVendorSearch As System.Windows.Forms.Button
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents cbStateId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContract))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgContract = New AxMSDataGridLib.AxDataGrid
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.dgEquipment = New AxMSDataGridLib.AxDataGrid
        Me.dgStore = New AxMSDataGridLib.AxDataGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.frame1 = New System.Windows.Forms.GroupBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdVendorSearch = New System.Windows.Forms.Button
        Me.txtVendName = New System.Windows.Forms.TextBox
        Me.cbStateId = New System.Windows.Forms.ComboBox
        Me.cbCustId = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dgContract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frame1.SuspendLayout()
        Me.Toolbar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgContract
        '
        Me.dgContract.DataSource = Nothing
        Me.dgContract.Location = New System.Drawing.Point(16, 376)
        Me.dgContract.Name = "dgContract"
        Me.dgContract.OcxState = CType(resources.GetObject("dgContract.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dgContract.Size = New System.Drawing.Size(681, 177)
        Me.dgContract.TabIndex = 3
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.dgEquipment)
        Me.Frame2.Controls.Add(Me.dgStore)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(248, 56)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(449, 289)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        '
        'dgEquipment
        '
        Me.dgEquipment.DataSource = Nothing
        Me.dgEquipment.Location = New System.Drawing.Point(16, 168)
        Me.dgEquipment.Name = "dgEquipment"
        Me.dgEquipment.OcxState = CType(resources.GetObject("dgEquipment.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dgEquipment.Size = New System.Drawing.Size(417, 105)
        Me.dgEquipment.TabIndex = 15
        '
        'dgStore
        '
        Me.dgStore.DataSource = Nothing
        Me.dgStore.Location = New System.Drawing.Point(16, 32)
        Me.dgStore.Name = "dgStore"
        Me.dgStore.OcxState = CType(resources.GetObject("dgStore.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dgStore.Size = New System.Drawing.Size(321, 97)
        Me.dgStore.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(16, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(153, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Equipment Assigned to Store "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(169, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Choose an Store"
        '
        'frame1
        '
        Me.frame1.BackColor = System.Drawing.SystemColors.Control
        Me.frame1.Controls.Add(Me.cmdSearch)
        Me.frame1.Controls.Add(Me.cmdVendorSearch)
        Me.frame1.Controls.Add(Me.txtVendName)
        Me.frame1.Controls.Add(Me.cbStateId)
        Me.frame1.Controls.Add(Me.cbCustId)
        Me.frame1.Controls.Add(Me.Label4)
        Me.frame1.Controls.Add(Me.Label3)
        Me.frame1.Controls.Add(Me.Label1)
        Me.frame1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame1.ForeColor = System.Drawing.Color.Blue
        Me.frame1.Location = New System.Drawing.Point(16, 56)
        Me.frame1.Name = "frame1"
        Me.frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame1.Size = New System.Drawing.Size(233, 289)
        Me.frame1.TabIndex = 0
        Me.frame1.TabStop = False
        Me.frame1.Text = "Criteria"
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSearch.Location = New System.Drawing.Point(16, 152)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSearch.Size = New System.Drawing.Size(81, 25)
        Me.cmdSearch.TabIndex = 11
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdVendorSearch
        '
        Me.cmdVendorSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVendorSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVendorSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVendorSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVendorSearch.Image = CType(resources.GetObject("cmdVendorSearch.Image"), System.Drawing.Image)
        Me.cmdVendorSearch.Location = New System.Drawing.Point(168, 96)
        Me.cmdVendorSearch.Name = "cmdVendorSearch"
        Me.cmdVendorSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVendorSearch.Size = New System.Drawing.Size(41, 21)
        Me.cmdVendorSearch.TabIndex = 10
        Me.cmdVendorSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVendorSearch.UseVisualStyleBackColor = False
        '
        'txtVendName
        '
        Me.txtVendName.AcceptsReturn = True
        Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
        Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVendName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVendName.Location = New System.Drawing.Point(16, 96)
        Me.txtVendName.MaxLength = 0
        Me.txtVendName.Name = "txtVendName"
        Me.txtVendName.ReadOnly = True
        Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVendName.Size = New System.Drawing.Size(145, 21)
        Me.txtVendName.TabIndex = 9
        '
        'cbStateId
        '
        Me.cbStateId.BackColor = System.Drawing.SystemColors.Window
        Me.cbStateId.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStateId.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStateId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbStateId.Location = New System.Drawing.Point(136, 48)
        Me.cbStateId.Name = "cbStateId"
        Me.cbStateId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbStateId.Size = New System.Drawing.Size(73, 22)
        Me.cbStateId.TabIndex = 7
        '
        'cbCustId
        '
        Me.cbCustId.BackColor = System.Drawing.SystemColors.Window
        Me.cbCustId.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustId.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbCustId.Location = New System.Drawing.Point(16, 48)
        Me.cbCustId.Name = "cbCustId"
        Me.cbCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbCustId.Size = New System.Drawing.Size(105, 22)
        Me.cbCustId.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Vendor"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(136, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "State"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer"
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button5})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(718, 39)
        Me.Toolbar1.TabIndex = 12
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.AutoSize = False
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        Me._Toolbar1_Button5.Size = New System.Drawing.Size(10, 39)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(24, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contract Info"
        '
        'frmContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(718, 574)
        Me.Controls.Add(Me.dgContract)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.frame1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContract"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Contract Info"
        CType(Me.dgContract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frame1.ResumeLayout(False)
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class