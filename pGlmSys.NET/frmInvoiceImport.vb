Option Strict Off
Option Explicit On
Friend Class frmInvoiceImport
	Inherits System.Windows.Forms.Form
    Dim rsLocal As DataTable
    Dim custList As String
    Private ImageList2 As New ImageList()
	
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		cbCustId.SelectedIndex = cbCustName.SelectedIndex
		
		load_vendors((cbCustId.Text))
		'validateAndLoadInvoices
	End Sub
	Private Sub load_vendors(ByRef sCustId As String)
		sStmt = "SELECT DISTINCT RTRIM(a.vend_name) + ' - ' + a.vend_area AS vend_name, a.vend_seq" & " FROM vbranch a, VInvoice  b " & " Where a.vend_seq = b.vend_seq " & " AND cust_id='" & sCustId & "'" & " ORDER BY vend_name "
		
		cbVendor.Items.Clear()
		cbVendor.Items.Insert(0, "<All>")
		load_cb_query4(cbVendor, sStmt, 2, False, 2000)
		
		cbVendor.SelectedIndex = 0
	End Sub
	
	Private Sub validateAndLoadInvoices()
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		If cbStatusFlag.Text = "NEW" Then
			validate_invoiceImport("'" & cbCustId.Text & "'")
		End If
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		load_dgInvoiceImport(False)
		
	End Sub
	'UPGRADE_WARNING: Event cbStatusDesc.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbStatusDesc_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbStatusDesc.SelectedIndexChanged
		
		cbStatusFlag.SelectedIndex = cbStatusDesc.SelectedIndex
		
	End Sub
	
	Private Sub frmInvoiceImport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
		Dim i As Short
        rsLocal = Nothing
		
		sStmt = "SELECT state_id FROM state ORDER BY state_id"
		cbState.Items.Insert(0, "<All>")
		load_cb_query2(cbState, sStmt, 1, False)
		
		cbState.SelectedIndex = 0
		
		
		load_cb_customer(cbCustName, cbCustId, True)
		If cbCustId.Items.Count > 1 Then
			custList = ""
			
			
			'setMainStatusBarMessage ("Loading Laserfiche Invoices to Import")
			
			'frmMain.pbMain.Min = 0
			'frmMain.pbMain.Max = cbCustId.ListCount
			'frmMain.pbMain.Visible = True
			
			For i = 1 To cbCustId.Items.Count - 1
				cbCustId.SelectedIndex = i
				custList = custList & "'" & cbCustId.Text & "'"
				
				'frmMain.pbMain.value = i
				'validate_invoiceImport "'" + cbCustId.Text + "'"
				
				If i + 1 < cbCustId.Items.Count Then
					custList = custList & ","
				End If
			Next i
			
			'frmMain.pbMain.Visible = False
			'frmMain.pbMain.Min = 0
			
			'restoreMainStatusBarMessage
			
			If cbCustName.Items.Count > 1 Then
				cbCustName.SelectedIndex = 1
			Else
				cbCustName.SelectedIndex = 0
			End If
		End If
		
		sStmt = "SELECT field_option_desc, field_option FROM sdomain " & " WHERE domain_field ='lf2gis_status_flag' ORDER BY option_order"
		
		load_cb_query5(cbStatusDesc, sStmt, 0, True)
		
		load_cb_query5(cbStatusFlag, sStmt, 1, True)
		
		
		If gsUserType = CStr(General.UserType.Administrator) Then
			lbStatusFlag.Visible = True
			cbStatusDesc.Visible = True
		End If
		
		set_cb(cbStatusDesc, "New")
		
		load_dgInvoiceImport(True)
		
	End Sub
	
	Private Sub load_dgInvoiceImport(ByRef bInitFlag As Boolean)
		Dim stmt As String
		Dim sCustomer As String
		Dim sOrder As String
		
		If cbCustId.SelectedIndex > 0 Then
			sCustomer = "'" & cbCustId.Text & "'"
		Else
			'All
			sCustomer = custList
		End If
		
		If bInitFlag Then
			stmt = "SELECT a.cust_id 'Cust', b.state_id 'State', b.store_number 'Store No', c.vend_name 'Vendor', " & " a.account_no 'Account' , a.invoice_no 'Invoice', a.creation_date 'Creation Date', " & " a.store_id, a.vend_seq, b.state_id, a.status_flag 'Status' " & " FROM lf2gis_vinvoice a, store b, vbranch c " & " WHERE a.cust_id IN ('')" & " AND a.cust_id = b.cust_id " & " AND a.store_id = b.store_id " & " AND a.status_flag ='" & cbStatusFlag.Text & "' " & " AND a.vend_seq = c.vend_seq " & " ORDER BY 'Cust', 'Creation Date' desc"
		Else
			stmt = "SELECT a.cust_id 'Cust', b.state_id 'State',  b.store_number 'Store No', " & " RTRIM(c.vend_name) + ' - ' + c.vend_area  'Vendor', " & " a.account_no 'Account' , a.invoice_no 'Invoice', a.creation_date 'Creation Date', " & " a.store_id, a.vend_seq, b.state_id, a.status_flag 'Status' " & " FROM lf2gis_vinvoice a, store b, vbranch c " & " WHERE a.cust_id IN (" & sCustomer & ")" & " AND a.cust_id = b.cust_id " & " AND a.store_id = b.store_id " & " AND a.status_flag ='" & cbStatusFlag.Text & "' " & " AND a.vend_seq = c.vend_seq "
			
			'Vendor
			If cbVendor.SelectedIndex > 0 Then
				stmt = stmt & " AND a.vend_seq = " & Str(VB6.GetItemData(cbVendor, cbVendor.SelectedIndex))
			End If
			
			'Store
			If Len(Trim(txtStoreNumber.Text)) > 0 Then
				stmt = stmt & " AND b.store_number = '" & quotation_mask((txtStoreNumber.Text)) & "'"
			End If
			
			'State
			If cbState.SelectedIndex > 0 Then
				stmt = stmt & " AND b.state_id = '" & cbState.Text & "' "
			End If
			
			'Invoice
			If Len(Trim(txtInvoiceNo.Text)) > 0 Then
				stmt = stmt & " AND a.invoice_no =  '" & quotation_mask((txtInvoiceNo.Text)) & "' "
			End If
			
			'Account
			If Len(Trim(txtAccount.Text)) > 0 Then
				stmt = stmt & " AND a.account_no LIKE '%" & quotation_mask((txtAccount.Text)) & "%' "
			End If
			
			sOrder = " ORDER BY 'Cust', 'Creation Date' desc"
			
			stmt = stmt & sOrder
		End If
		
		
		
        rsLocal = getDataTable(stmt) '.Open(stmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
		
        If rsLocal.Rows.Count > 0 Then
            lbRecordCount.Text = "Total Records:" & Str(rsLocal.Rows.Count)

            dgPendingInvoices.DataSource = rsLocal
            dgPendingInvoices.Columns("store_id").Visible = False
            dgPendingInvoices.Columns("vend_seq").Visible = False
            dgPendingInvoices.Columns("state_id").Visible = False
            dgPendingInvoices.Columns("Vendor").Width = VB6.TwipsToPixelsX(3000)
            dgPendingInvoices.Columns("State").Width = VB6.TwipsToPixelsX(300)
            dgPendingInvoices.Columns("Store No").Width = VB6.TwipsToPixelsX(1200)
            If gsUserType <> CStr(General.UserType.Administrator) Then
                dgPendingInvoices.Columns("Status").Visible = False
            End If
        End If
		
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "upload"
                If dgPendingInvoices.SelBookmarks.Count = 0 Then
                    MsgBox("Please select at least one record to perform this action", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
                    Exit Sub
                End If

                uploadToGis((dgPendingInvoices.Columns("Cust").Text), (dgPendingInvoices.Columns("store_id").Text), (dgPendingInvoices.Columns("Store No").Text), (dgPendingInvoices.Columns("vend_seq").Text), (dgPendingInvoices.Columns("Account").Text), (dgPendingInvoices.Columns("Invoice").Text), (dgPendingInvoices.Columns("state_id").Text))


            Case "search"
                validateAndLoadInvoices()
            Case "exit"
                Me.Close()
        End Select


    End Sub
	
	
	Public Sub uploadToGis(ByRef sCustId As String, ByRef sStoreId As String, ByRef sStoreNumber As String, ByRef sVendSeq As String, ByRef sAccountNo As String, ByRef sInvoiceNo As String, ByRef sStateId As String)
		
		'Check if invoice is duplicate
		If isInvoiceDuplicate(sCustId, sStoreId, sVendSeq, sAccountNo, sInvoiceNo) Then
			
			update_lf2gis_vinvoice(sCustId, CShort(sStoreId), sAccountNo, CShort(sVendSeq), sInvoiceNo, "DUPLICATE", "Invoice already exists in DB")
			
			MsgBox("The selected invoice already exists in the database, it was marked as Duplicate." & vbCrLf & "Please try another.")
			
			load_dgInvoiceImport(False)
			
			Exit Sub
		End If
		
		'Populate Invoice form with header info
		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        frmInvoiceBooking.Show()

		frmInvoiceBooking.populateHeader(sCustId, sStoreId, sStoreNumber, sStateId, CShort(sVendSeq), sAccountNo, sInvoiceNo)
		
		frmInvoiceBooking.bImportedFromLF = True
		
		VB6.ShowForm(frmInvoiceBooking, VB6.FormShowConstants.Modal, Me)
		
		load_dgInvoiceImport(False)
		
	End Sub
	
	Public Function isInvoiceDuplicate(ByRef sCustId As String, ByRef sStoreId As String, ByRef sVendSeq As String, ByRef sAccountNo As String, ByRef sInvoiceNo As String) As Boolean
		
		
		isInvoiceDuplicate = False
		
		sStmt = "SELECT count(*) FROM vInvoice WHERE cust_Id = '" & sCustId & "'" & " AND store_id = " & sStoreId & " AND vend_seq = " & sVendSeq & " AND account_no = '" & sAccountNo & "' " & " AND invoice_no = '" & sInvoiceNo & "' "
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
        If rs.Rows.Count Then
            If rs.Rows(0).Item(0).value > 0 Then
                isInvoiceDuplicate = True
            End If
        End If
		
	End Function
End Class