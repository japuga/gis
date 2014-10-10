Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmRateSearch
	Inherits System.Windows.Forms.Form
    Private rsLocal As sqldatareader
	
	'UPGRADE_WARNING: Event ckStateCity.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ckStateCity_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ckStateCity.CheckedChanged
		If eventSender.Checked Then
			
			
			cbState.Enabled = ckStateCity.Checked
			'UPGRADE_ISSUE: ComboBox property cbState.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'cbState.Locked = Not ckStateCity.Checked
			
			txtCity.Enabled = ckStateCity.Checked
			txtCity.ReadOnly = Not ckStateCity.Checked
			
			cbZip.Enabled = Not ckStateCity.Checked
			'UPGRADE_ISSUE: ComboBox property cbZip.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'cbZip.Locked = ckStateCity.Checked
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event ckZip.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ckZip_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ckZip.CheckedChanged
		If eventSender.Checked Then
			cbZip.Enabled = ckZip.Checked
			'UPGRADE_ISSUE: ComboBox property cbZip.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'cbZip.Locked = Not ckZip.Checked
			
			cbState.Enabled = Not ckZip.Checked
			'UPGRADE_ISSUE: ComboBox property cbState.Locked was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'cbState.Locked = ckZip.Checked
			
			txtCity.Enabled = Not ckZip.Checked
			txtCity.ReadOnly = ckZip.Checked
		End If
	End Sub
	
	
	Private Sub cmdFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFilter.Click
		
		Dim stmt As String
        Dim cmd As SqlCommand = cn.CreateCommand
		stmt = construct_query
        cmd.CommandText = stmt
        rsLocal = cmd.ExecuteReader() '.Open(stmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
        If rsLocal.HasRows() Then
            dgRates.DataSource = rsLocal
            dgRates.Columns("Vendor").Width = VB6.TwipsToPixelsX(2000)
            dgRates.Columns("State").Width = VB6.TwipsToPixelsX(300)
            dgRates.Columns("City").Width = VB6.TwipsToPixelsX(600)
            dgRates.Columns("Zip").Width = VB6.TwipsToPixelsX(600)
            dgRates.Columns("Serv").Width = VB6.TwipsToPixelsX(1500)

        End If
		
		
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgRates.Refresh()
	End Sub
	Private Function construct_query() As String
		Dim stmt As String
		
		stmt = " SELECT  vbranch.vend_name 'Vendor' , vbranch.state_id 'State' , vbranch.vend_city 'City' ," & " vbranch.vend_zip 'Zip', " & " dbo.format_eqpt (StoreEqpt.eqpt_qty, StoreEqpt.eqpt_desc, StoreEqpt.load_id) AS 'Eqpt'," & " CAST(dbo.format_freq2 (Frequency.freq_sched_flag," & " Frequency.freq_times_flag, VContract.freq_times, " & " ISNULL(VContract.freq_period,''), ISNULL(VContract.freq_day1,''), " & " ISNULL(VContract.freq_day2,''), ISNULL(VContract.freq_day3,''), " & " ISNULL(VContract.freq_day4,''), ISNULL(VContract.freq_day5,''), " & " ISNULL(VContract.freq_day6,''), ISNULL(VContract.freq_day7,''))  AS CHAR(60))AS 'Freq',  " & " service.serv_desc 'Serv', curr_rate Rate, old_rate 'Old Rate' " & " FROM vcontract, frequency, service, storeEqpt, vbranch, equipment, vaccountEqpt " & " WHERE vcontract.freq_id = frequency.freq_id " & " AND vContract.serv_id = service.serv_id " & " AND vContract.cust_id = storeEqpt.cust_id " & " AND vContract.store_id = storeEqpt.store_id " & " AND vContract.eqpt_seq = storeEqpt.eqpt_seq " & " AND vContract.vend_seq = vbranch.vend_seq " & " AND equipment.eqpt_id = storeEqpt.eqpt_id " & " AND vContract.cust_id = vAccountEqpt.cust_id " & " AND vContract.vend_seq = vAccountEqpt.vend_seq " & " AND vContract.store_id = vAccountEqpt.store_id " & " AND vContract.eqpt_seq = vAccountEqpt.eqpt_seq "
		
		
		
		
		If cbService.SelectedIndex > 0 Then
			stmt = stmt & " AND vContract.serv_id = " & Str(VB6.GetItemData(cbService, cbService.SelectedIndex))
		End If
		
		If cbEquipment.SelectedIndex > 0 Then
			stmt = stmt & " AND equipment.eqpt_id =  " & Str(VB6.GetItemData(cbEquipment, cbEquipment.SelectedIndex))
		End If
		
		If cbContent.SelectedIndex > 0 Then
			stmt = stmt & " AND storeEqpt.content_id = " & Str(VB6.GetItemData(cbContent, cbContent.SelectedIndex))
		End If
		
		
		If ckStateCity.Checked = True Then
			If cbState.SelectedIndex > 0 Then
				stmt = stmt & " AND vbranch.state_id = '" & cbState.Text & "' "
			End If
			
			If Len(Trim(txtCity.Text)) > 0 Then
				stmt = stmt & " AND vbranch.vend_city LIKE '" & Trim(txtCity.Text) & "%'"
			End If
		Else
			If cbZip.SelectedIndex > 0 Then
				stmt = stmt & " AND vbranch.vend_zip = '" & cbZip.Text & "' "
			End If
		End If
		
		If cbAccountStatus.SelectedIndex > 0 Then
			If cbAccountStatus.Text = "Active" Then
				stmt = stmt & " AND vAccountEqpt.account_status='A' "
			Else
				stmt = stmt & " AND vAccountEqpt.account_status = 'I' "
			End If
		End If
		
		stmt = stmt & " ORDER BY vbranch.vend_name, vbranch.state_id, vbranch.vend_city, vbranch.vend_zip "
		construct_query = stmt
		
	End Function
	Private Sub frmRateSearch_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	Private Sub init_vars()
		
        rsLocal = Nothing
		
		Dim stmt As String
		
		
		stmt = " SELECT DISTINCT a.serv_desc, a.serv_id FROM service a, vcontract b" & " WHERE a.serv_id = b.serv_id  " & " ORDER BY a.serv_desc "
		
		cbService.Items.Insert(0, "<All>")
		load_cb_query2(cbService, stmt, 2, False)
		
		If cbService.Items.Count > 0 Then
			cbService.SelectedIndex = 0
		End If
		
		stmt = "SELECT DISTINCT a.eqpt_desc, a.eqpt_id " & " FROM equipment a, vcontract b, storeEqpt c " & " WHERE a.eqpt_id = c.eqpt_id " & " AND b.cust_id = c.cust_id " & " AND b.store_id = c.store_id " & " AND b.eqpt_seq = c.eqpt_seq " & " ORDER BY a.eqpt_desc "
		
		cbEquipment.Items.Insert(0, "<All>")
		load_cb_query2(cbEquipment, stmt, 2, False)
		
		If cbEquipment.Items.Count > 0 Then
			cbEquipment.SelectedIndex = 0
		End If
		
		stmt = "SELECT DISTINCT a.content_desc, a.content_id" & " FROM content a, vcontract b, storeEqpt c " & " WHERE a.content_id = c.content_id " & " AND b.cust_id = c.cust_id " & " AND b.store_id = c.store_id " & " AND b.eqpt_seq = c.eqpt_seq " & " ORDER BY a.content_desc"
		cbContent.Items.Insert(0, "<All>")
		load_cb_query2(cbContent, stmt, 2, False)
		
		If cbContent.Items.Count > 0 Then
			cbContent.SelectedIndex = 0
		End If
		
		
		stmt = "SELECT DISTINCT state_id " & " FROM vcontract a , vbranch b " & " Where a.vend_seq = b.vend_seq " & " ORDER BY state_id "
		cbState.Items.Insert(0, "<All>")
		load_cb_query2(cbState, stmt, 1, False)
		
		If cbState.Items.Count > 0 Then
			cbState.SelectedIndex = 0
		End If
		
		stmt = "SELECT DISTINCT vend_zip" & " FROM vcontract a , vbranch b " & " WHERE a.vend_seq = b.vend_seq " & " ORDER BY vend_zip "
		cbZip.Items.Insert(0, "<All>")
		load_cb_query2(cbZip, stmt, 1, False)
		If cbZip.Items.Count > 0 Then
			cbZip.SelectedIndex = 0
		End If
		
		
		ckStateCity.Checked = True
		
		cbAccountStatus.Items.Insert(0, "<All>")
		cbAccountStatus.Items.Insert(1, "Active")
		cbAccountStatus.Items.Insert(2, "Inactive")
		
		cbAccountStatus.SelectedIndex = 0
		
	End Sub
End Class