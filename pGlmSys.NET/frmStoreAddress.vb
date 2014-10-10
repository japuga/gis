Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmStoreAddress
	Inherits System.Windows.Forms.Form
    Private rsLocal As DataTable
    Private ImageList2 As New ImageList()
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		
		load_dgAddress("", 0)
		
		If cbCustName.SelectedIndex >= 0 Then
			cbCustId.SelectedIndex = cbCustName.SelectedIndex
		End If
		
		
		
		load_cbStoreNo((cbCustId.Text))
	End Sub
	
	Private Sub load_cbStoreNo(ByRef sCustId As String)
		sStmt = "SELECT store_number, store_id FROM store " & "WHERE cust_id = '" & sCustId & "'" & " ORDER BY store_number"
		
		load_cb_query2(cbStoreNo, sStmt, 2, True)
		If cbStoreNo.Items.Count > 0 Then
			cbStoreNo.SelectedIndex = 0
		End If
		
		
	End Sub
	
	'UPGRADE_WARNING: Event cbStoreNo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbStoreNo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbStoreNo.SelectedIndexChanged
		
		load_dgAddress((cbCustId.Text), VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex))
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		If dgAddress.SelBookmarks.Count <= 0 Then
			MsgBox("Select a record before continuing or Press Exit for no selection", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		Else
			populate_address_var()
			Me.Close()
		End If
		
		
	End Sub
	
	
	Private Sub clear_store_address_record()
		
		'gStoreAddress.nStoreAddressSeq = 0
		gStoreAddress.nStoreAddressSeq = 0
		gStoreAddress.nStoreId = 0
		gStoreAddress.sAddress = ""
		gStoreAddress.sCity = ""
		gStoreAddress.sState = ""
		gStoreAddress.sZip = ""
		
		
	End Sub
	Private Sub populate_address_var()
		
		gStoreAddress.bAddressFlag = General.addressMode.RecordSelected
		'gStoreAddress.bFlag = addressMode.RecordSelected
		
		gStoreAddress.nStoreAddressSeq = CShort(dgAddress.Columns("store_address_seq").Text)
		gStoreAddress.nAddressSeq = CShort(dgAddress.Columns("address_seq").Text)
		gStoreAddress.sAddress = dgAddress.Columns("Address").Text
		gStoreAddress.sCity = dgAddress.Columns("City").Text
		gStoreAddress.sState = dgAddress.Columns("State").Text
		gStoreAddress.sZip = dgAddress.Columns("Zip").Text
		
		
		'MsgBox rs("address")
		
		
		
	End Sub
	
	Private Sub dgAddress_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgAddress.ClickEvent
		
		Select Case gStoreAddress.bAddressFlag
			Case General.addressMode.LookupMode
				cmdOk_Click(cmdOk, New System.EventArgs())
			Case General.addressMode.InsertUpdateMode
				edit_address()
		End Select
		
	End Sub
	
	Private Sub frmStoreAddress_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	
	Private Sub init_vars()
		
        rsLocal = Nothing
		
		cbCustId.Visible = False
		
		sStmt = "SELECT cust_name FROM customer ORDER BY cust_name"
		load_cb_query2(cbCustName, sStmt, 1, True)
		
		sStmt = "SELECT cust_id, cust_name FROM customer ORDER BY cust_name"
		load_cb_query2(cbCustId, sStmt, 1, True)
		
		
		
		Select Case gStoreAddress.bAddressFlag
			Case General.addressMode.LookupMode
				set_cb(cbCustName, gStoreAddress.sCustName)
				set_cb_ItemData(cbStoreNo, gStoreAddress.nStoreId)
				
				cbCustName.Enabled = False
				'UPGRADE_ISSUE: ComboBox property cbCustName.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'cbCustName.Locked = True
				cbStoreNo.Enabled = False
				'UPGRADE_ISSUE: ComboBox property cbStoreNo.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'cbStoreNo.Locked = True
				
				Toolbar1.Items.Item("save").Visible = False
				Toolbar1.Items.Item("search").Visible = False
				
				load_dgAddress(gStoreAddress.sCustId, gStoreAddress.nStoreId)
			Case General.addressMode.InsertUpdateMode
				
				cmdOk.Visible = False
				
				If cbCustName.Items.Count > 0 Then
					cbCustName.SelectedIndex = 0
				End If
				
				If cbCustName.SelectedIndex >= 0 And cbStoreNo.SelectedIndex >= 0 Then
					load_dgAddress((cbCustId.Text), VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex))
				Else
					load_dgAddress("", 0)
				End If
				
		End Select
		
		
	End Sub
	
	
	Private Sub load_dgAddress(ByRef sCustId As String, ByRef nStoreId As Short)
		
		sStmt = " SELECT b.store_address_seq, a.address_seq, a.address Address, a.city City, a.state_id State, a.zip Zip " & " FROM address_catalog a, store_address b" & " WHERE a.address_seq = b.address_seq " & " AND a.context_table = '" & ADDRESS_CATALOG_CONTEXT_STORE & "' " & " AND b.cust_id = '" & sCustId & "' " & " AND b.store_id = " & Str(nStoreId) & " ORDER BY Address, City, State"
		
		
		'UPGRADE_NOTE: Object dgAddress.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgAddress.DataSource = Nothing
		
        rsLocal = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		
        If rsLocal.Rows.Count > 0 Then
            dgAddress.DataSource = rsLocal
        End If
		
		dgAddress.Columns("address_seq").Visible = False
		dgAddress.Columns("store_address_seq").Visible = False
		
		
		
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                add_address()
            Case "save"
                edit_address()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	Private Sub add_address()
		If cbCustId.SelectedIndex < 0 Or cbCustName.SelectedIndex < 0 Or cbStoreNo.SelectedIndex < 0 Then
			MsgBox("Please select a Customer and Store before attempting this command", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		set_address_record((General.modo.NewRecord))
		VB6.ShowForm(frmStoreAddressEntry, VB6.FormShowConstants.Modal, Me)
		'If gStoreAddressRecord.bFlag = modo.SavedRecord Then
		If gStoreAddress.bFlag = General.modo.SavedRecord Then
			load_dgAddress((cbCustId.Text), VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex))
		End If
		
	End Sub
	Private Sub edit_address()
		
		If cbCustId.SelectedIndex < 0 Or cbCustName.SelectedIndex < 0 Or cbStoreNo.SelectedIndex < 0 Then
			MsgBox("Please select a Customer and Store before attempting this command", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		If dgAddress.SelBookmarks.Count <= 0 Then
			MsgBox("Select a record before attempting this command", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		
		
		set_address_record((General.modo.UpdateRecord))
		VB6.ShowForm(frmStoreAddressEntry, VB6.FormShowConstants.Modal, Me)
		'If gStoreAddressRecord.bFlag = modo.SavedRecord Then
		If gStoreAddress.bFlag = General.modo.SavedRecord Then
			load_dgAddress((cbCustId.Text), VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex))
		End If
		
	End Sub
	Private Sub set_address_record(ByRef nOption As General.modo)
		
		Select Case nOption
			Case General.modo.NewRecord
				'gStoreAddressRecord.bFlag = modo.NewRecord
				'gStoreAddressRecord.sCustId = cbCustId.Text
				'gStoreAddressRecord.sCustName = cbCustName.Text
				'gStoreAddressRecord.nStoreId = cbStoreNo.ItemData(cbStoreNo.ListIndex)
				'gStoreAddressRecord.sStoreNumber = cbStoreNo.Text
				
				gStoreAddress.bFlag = General.modo.NewRecord
				'Just load Customer and Store when Insert/Update mode since these are
				'already populated when used in LookupMode at frmStoreEntry form
				'If gStoreAddress.bAddressFlag = addressMode.InsertUpdateMode Then
				gStoreAddress.sCustId = cbCustId.Text
				gStoreAddress.sCustName = cbCustName.Text
				gStoreAddress.nStoreId = VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex)
				gStoreAddress.sStoreNumber = cbStoreNo.Text
				'End If
				
			Case General.modo.UpdateRecord
				'gStoreAddressRecord.bFlag = modo.UpdateRecord
				'gStoreAddressRecord.sCustId = cbCustId
				'gStoreAddressRecord.sCustName = cbCustName
				'gStoreAddressRecord.nStoreId = cbStoreNo.ItemData(cbStoreNo.ListIndex)
				'gStoreAddressRecord.sStoreNumber = cbStoreNo.Text
				
				gStoreAddress.bFlag = General.modo.UpdateRecord
				gStoreAddress.sCustId = cbCustId.Text
				gStoreAddress.sCustName = cbCustName.Text
				gStoreAddress.nStoreId = VB6.GetItemData(cbStoreNo, cbStoreNo.SelectedIndex)
				gStoreAddress.sStoreNumber = cbStoreNo.Text
				
				
				'Details
				gStoreAddress.nAddressSeq = CShort(dgAddress.Columns("address_seq").Text)
				gStoreAddress.sAddress = dgAddress.Columns("Address").Text
				gStoreAddress.sCity = dgAddress.Columns("City").Text
				gStoreAddress.sState = dgAddress.Columns("State").Text
				gStoreAddress.sZip = dgAddress.Columns("Zip").Text
				
		End Select
		
		
	End Sub
End Class