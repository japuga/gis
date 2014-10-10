Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmGroupStore
	Inherits System.Windows.Forms.Form
    Private cmLocal As SqlCommand
    Private rsLocal As SqlDataReader
    Public ImageList2 As New ImageList()
	
	'UPGRADE_WARNING: Event cbCustId.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustId_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustId.SelectedIndexChanged
		If cbCustId.SelectedIndex >= 0 And cbTypeId.SelectedIndex >= 0 Then
			load_dgGroups((cbCustId.Text), (cbTypeId.Text))
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		cbCustId.SelectedIndex = cbCustName.SelectedIndex
		'load_dgGroups cbCustId
	End Sub
	
	'UPGRADE_WARNING: Event cbTypeId.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbTypeId_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTypeId.SelectedIndexChanged
		If cbCustId.SelectedIndex >= 0 And cbTypeId.SelectedIndex >= 0 Then
			load_dgGroups((cbCustId.Text), (cbTypeId.Text))
		End If
		
	End Sub
	
	Private Sub dgGroups_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgGroups.DblClick
		update_group()
	End Sub
	Private Sub update_group()
		If dgGroups.SelBookmarks.Count > 0 Then
			
			gGroupsRecord.bFlag = General.modo.UpdateRecord
			gGroupsRecord.sCustId = cbCustId.Text
			gGroupsRecord.sCustName = cbCustName.Text
			gGroupsRecord.sGroupName = dgGroups.Columns("name").Text
			gGroupsRecord.nGroupSeq = CShort(dgGroups.Columns("group_seq").Text)
			gGroupsRecord.sTypeId = RTrim(cbTypeId.Text)
			gGroupsRecord.sAttention = dgGroups.Columns("cinvoice_attention").Text
			gGroupsRecord.sContractNo = dgGroups.Columns("cinvoice_contract_no").Text
			gGroupsRecord.sText = dgGroups.Columns("cinvoice_text").Text
			VB6.ShowForm(frmGroupStoreEntry, VB6.FormShowConstants.Modal, Me)
			If gGroupsRecord.bFlag = General.modo.SavedRecord Then
				load_dgGroups((cbCustId.Text), (cbTypeId.Text))
			End If
		Else
			MsgBox("You must select a group to Update ," & vbCrLf & " before attempting this comand", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
			Exit Sub
		End If
		
	End Sub
	Private Sub frmGroupStore_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        cmLocal = cn.CreateCommand()

        'Combo Customer
        '1.8.8 Included customers that user has access to (i.e. states)
        'sStmt = "SELECT cust_name, cust_id FROM customer " + _
        '" ORDER BY cust_name "
        sStmt = "SELECT cust_name, cust_id FROM customer " & " WHERE cust_id IN (SELECT DISTINCT cust_id " & "   FROM suser_data " & "   WHERE suser_name='" & Trim(gsUser) & "')" & " ORDER BY cust_name "
        load_cb_query2(cbCustName, sStmt, 1, True)

        sStmt = "SELECT cust_id, cust_name FROM customer " & " WHERE cust_id IN (SELECT DISTINCT cust_id " & "   FROM suser_data " & "   WHERE suser_name='" & Trim(gsUser) & "')" & " ORDER BY cust_name "
        load_cb_query2(cbCustId, sStmt, 1, True)

        If cbCustName.Items.Count > 0 Then
            cbCustName.SelectedIndex = 0
        End If

        'TypeId
        sStmt = "SELECT type_id FROM GrpType " & " ORDER BY sort_id "

        load_cb_query2(cbTypeId, sStmt, 1, True)

        If cbTypeId.Items.Count > 0 Then
            cbTypeId.SelectedIndex = 0
        End If

        If cbCustId.Items.Count > 0 Then
            cbCustId.SelectedIndex = 0
            'If cbTypeId.ListIndex >= 0 Then
            '    load_dgGroups cbCustId
            'End If
        End If

    End Sub
	'Loads datagrid with available Groups
	'Private Sub load_dgGroups(sCustId As String, sTypeId As String)
    Private Sub load_dgGroups(ByRef sCustId As String, ByRef sTypeId As String)
        Dim cmd As SqlCommand = cn.CreateCommand()
        On Error GoTo ErrorHandler
        'sStmt = "SELECT group_seq, group_name AS Name, cust_id " + _
        '" FROM groups " + _
        '" WHERE cust_id = '" + Trim(sCustId) + "'" + _
        '" ORDER BY group_name"

        sStmt = "SELECT group_seq, group_name AS Name, cust_id, " & " cinvoice_attention, cinvoice_contract_no, cinvoice_text " & " FROM groups " & " WHERE cust_id = '" & Trim(sCustId) & "'" & " AND type_id = '" & sTypeId & "' " & " ORDER BY group_name"
        cmd.CommandText = sStmt

        rsLocal = cmd.ExecuteReader()
        If rsLocal.HasRows() Then
            dgGroups.DataSource = rsLocal
            dgGroups.Refresh()
            
        Else          
            dgGroups.DataSource = Nothing
            Exit Sub
        End If



        'Formatting datagrid
        dgGroups.Columns("cust_id").Visible = False
        dgGroups.Columns("group_seq").Visible = False
        dgGroups.Columns("Name").Width = VB6.TwipsToPixelsX(3000)
        dgGroups.Columns("cinvoice_attention").Visible = False
        dgGroups.Columns("cinvoice_contract_no").Visible = False
        dgGroups.Columns("cinvoice_text").Visible = False

        Exit Sub
ErrorHandler:
        save_error(Me.Name, "load_dgGroups")
        MsgBox("Error during Groups loading. Check logfile for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Message")
    End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                add_group()
            Case "save"
                update_group()
            Case "delete"
                delete_group()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	Private Sub add_group()
		gGroupsRecord.bFlag = General.modo.NewRecord
		gGroupsRecord.sCustId = cbCustId.Text
		gGroupsRecord.sCustName = cbCustName.Text
		gGroupsRecord.sTypeId = RTrim(cbTypeId.Text)
		
		VB6.ShowForm(frmGroupStoreEntry, VB6.FormShowConstants.Modal, Me)
		
		If gGroupsRecord.bFlag = General.modo.SavedRecord Then
			load_dgGroups((cbCustId.Text), Trim(cbTypeId.Text))
		End If
		
	End Sub
	
	Private Sub delete_group()
		Dim nRecords As Short
        Dim nTran As SqlTransaction
		
		On Error GoTo ErrorHandler
		
		If dgGroups.SelBookmarks.Count > 0 Then
			If MsgBox("Do you want to delete Group: " & dgGroups.Columns("Name").Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "GLM Warning") = MsgBoxResult.Yes Then
				
				If Not check_references(Trim(cbTypeId.Text), CShort(Str(CDbl(dgGroups.Columns("group_seq").Text)))) Then
					MsgBox("This record is referenced in a higher group level." & vbCrLf & "First remove the record from the group:" & Trim(gDump.str1) & " before removing this record", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
					
					Exit Sub
				End If
				
                nTran = cn.BeginTransaction()
                'General.bcnStatus = General.cnStatus.BeginTrans
				
				Select Case Trim(cbTypeId.Text)
					Case GROUP_LOCAL
						sStmt = "DELETE FROM GroupStore" & " WHERE cust_id ='" & cbCustId.Text & "'" & " AND group_seq = " & Str(CDbl(dgGroups.Columns("group_seq").Text))
						
					Case GROUP_AREA
						
						sStmt = "DELETE FROM AreaDet " & " WHERE area_seq = " & Str(CDbl(dgGroups.Columns("group_seq").Text))
						
					Case GROUP_DISTRICT
						sStmt = "DELETE FROM DistrictDet " & " WHERE district_seq = " & Str(CDbl(dgGroups.Columns("group_seq").Text))
						
					Case GROUP_REGION
						sStmt = "DELETE FROM RegionDet " & " WHERE region_seq = " & Str(CDbl(dgGroups.Columns("group_seq").Text))
						
				End Select
				
				'MsgBox sStmt
				cmLocal.CommandText = sStmt
                cmLocal.ExecuteNonQuery()
				
				sStmt = "DELETE FROM Groups " & " WHERE cust_id ='" & cbCustId.Text & "'" & " AND group_seq = " & Str(CDbl(dgGroups.Columns("group_seq").Text))
				'MsgBox sStmt
				cmLocal.CommandText = sStmt
                nRecords = cmLocal.ExecuteNonQuery()
				
				If nRecords > 0 Then
                    nTran.Commit()
					General.bcnStatus = General.cnStatus.NoTrans
					MsgBox("Data was sucessfully deleted.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
					load_dgGroups((cbCustId.Text), Trim(cbTypeId.Text))
				Else
                    nTran.Rollback()
					General.bcnStatus = General.cnStatus.NoTrans
				End If
			End If
		Else
			MsgBox("You must select a record to execute this command.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
			Exit Sub
		End If
		Exit Sub
		
ErrorHandler: 
		If General.bcnStatus = General.cnStatus.BeginTrans Then
            nTran.Rollback()
			General.bcnStatus = General.cnStatus.NoTrans
		End If
		save_error(Me.Name, "delete_group")
		MsgBox("Unexpected error while deleting groups table." & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	
	Private Function check_references(ByRef sType As String, ByRef nSeq As Short) As Boolean
        Dim cmd As SqlCommand = cn.CreateCommand()
		On Error GoTo ErrorHandler
		
		check_references = False
		
		Select Case sType
			Case GROUP_LOCAL
				sStmt = " SELECT b.group_name, a.area_seq " & " FROM AreaDet a, Groups b  " & " WHERE a.group_seq = " & Str(nSeq) & " AND a.area_seq = b.group_seq "
				
			Case GROUP_AREA
				sStmt = " SELECT b.group_name, a.district_seq " & " FROM DistrictDet a, Groups b " & " WHERE a.area_seq = " & Str(nSeq) & " AND a.district_seq = b.group_seq "
				
			Case GROUP_DISTRICT
				sStmt = " SELECT b.group_name, a.region_seq " & " FROM RegionDet a, Groups b " & " WHERE a.district_seq = " & Str(nSeq) & " AND a.region_seq = b.group_seq "
				
			Case GROUP_REGION
				check_references = True
				Exit Function
				
			Case Else
				check_references = True
				write_msg("check_references", "Invalid Parameter sType:" & sType)
				
				Exit Function
		End Select
		
        cmd.CommandText = sStmt
        rs = getDataTable(sStmt) ' cmd.ExecuteReader()

        If Not (rs.Rows.Count > 0) Then
            check_references = True
            Exit Function
        Else
            gDump.str1 = rs.Rows(0).Item(0).value
            gDump.str2 = Str(rs.Rows(0).Item(1).value)
        End If


        Exit Function

ErrorHandler:
        save_error(Me.Name, "check_references")
		
		
	End Function
End Class