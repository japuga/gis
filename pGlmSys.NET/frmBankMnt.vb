Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmBankMnt
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private ImageList2 As New ImageList()
	
	Private Sub dgBank_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgBank.DblClick
		update_bank()
	End Sub
	
	Private Sub frmBankMnt_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        'rsLocal = SqlDataReader
		
		load_dgBank()
		
	End Sub
	Private Sub load_dgBank()
		
		On Error GoTo ErrorHandler
        Dim cmd As SqlCommand = cn.CreateCommand
		sStmt = "SELECT  " & " Bank.bank_id, Bank.bank_name AS 'Bank', " & " Bank.bank_aba 'Routing'," & " Bank.check_info1, Bank.check_info2, " & " Bank.check_info3, Bank.check_info4, " & " Bank.bank_status 'Status' " & "FROM Bank " & " ORDER BY Bank.bank_name "
        cmd.CommandText = sStmt
		'UPGRADE_NOTE: Object dgBank.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgBank.DataSource = Nothing
		
		
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            dgBank.DataSource = rsLocal
        Else
            'UPGRADE_NOTE: Object dgBank.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            dgBank.DataSource = Nothing
            Exit Sub
        End If
		
		'Format Datagrid
		dgBank.Columns("bank_id").Visible = False
		dgBank.Columns("check_info1").Visible = False
		dgBank.Columns("check_info2").Visible = False
		dgBank.Columns("check_info3").Visible = False
		dgBank.Columns("check_info4").Visible = False
		
		dgBank.Columns("Bank").Width = VB6.TwipsToPixelsX(1500)
		dgBank.Columns("Routing").Width = VB6.TwipsToPixelsX(1600)
		dgBank.Columns("Status").Width = VB6.TwipsToPixelsX(900)
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgBank.Refresh()
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgBank")
		MsgBox("Unexpected error found while loading Bank Information." & vbCrLf & "Review lod file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                add_bank()
            Case "save"
                update_bank()
            Case "delete"
                delete_bank()
            Case "exit"
                Me.Close()
        End Select
    End Sub
	
	Private Sub add_bank()
		gBank.bFlag = General.modo.NewRecord
		
		VB6.ShowForm(frmBankMntEntry, VB6.FormShowConstants.Modal, Me)
		If gBank.bFlag = General.modo.SavedRecord Then
			load_dgBank()
		End If
	End Sub
	
	Private Sub update_bank()
		If dgBank.Row < 0 Then
			MsgBox("Please select a Bank before attempting this command.", MsgBoxStyle.Exclamation, "GLM Warning")
		End If
		
		gBank.bFlag = General.modo.UpdateRecord
		gBank.nBankId = CShort(dgBank.Columns("bank_id").Text)
		gBank.sBankName = dgBank.Columns("Bank").Text
		gBank.sBankAba = dgBank.Columns("Routing").Text
		
		
		gBank.sBankStatus = ""
		gBank.sCheckInfo1 = ""
		gBank.sCheckInfo2 = ""
		gBank.sCheckInfo3 = ""
		gBank.sCheckInfo4 = ""
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If Not IsDbNull(dgBank.Columns("Status").Text) Then
			gBank.sBankStatus = dgBank.Columns("Status").Text
		End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If Not IsDbNull(dgBank.Columns("check_info1").Text) Then
			gBank.sCheckInfo1 = dgBank.Columns("check_info1").Text
		End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If Not IsDbNull(dgBank.Columns("check_info2").Text) Then
			gBank.sCheckInfo2 = dgBank.Columns("check_info2").Text
		End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If Not IsDbNull(dgBank.Columns("check_info3").Text) Then
			gBank.sCheckInfo3 = dgBank.Columns("check_info3").Text
		End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If Not IsDbNull(dgBank.Columns("check_info4").Text) Then
			gBank.sCheckInfo4 = dgBank.Columns("check_info4").Text
		End If
		
		
		VB6.ShowForm(frmBankMntEntry, VB6.FormShowConstants.Modal, Me)
		If gBank.bFlag = General.modo.SavedRecord Then
			load_dgBank()
		End If
		
	End Sub
	
	Private Sub delete_bank()
		Dim nRecords As Short
		nRecords = 0
        Dim cmd As sqlcommand = cn.CreateCommand()
		If dgBank.Row >= 0 Then
			If MsgBox("Do you want to delete this Bank", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "GLM Warning") = MsgBoxResult.No Then
				Exit Sub
			Else
				'Verify that no Account or Check exist
				'for this Bank before deleting it
				sStmt = "SELECT COUNT(*) FROM BankAccount " & "WHERE bank_id =" & Str(CDbl(dgBank.Columns("bank_id").Text))
                cmd.CommandText = sStmt
                rs = getDataTable(sStmt) 'cmd.ExecuteReader()

                If rs.Rows(0).Item(0).Value > 0 Then
                    MsgBox("Can not delete Bank. Found one or more accounts related to this Bank." & vbCrLf & "Remove accounts before attempting this action.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
                    Exit Sub
                End If

                'Delete
                sStmt = "DELETE FROM Bank" & " WHERE bank_id =" & Str(CDbl(dgBank.Columns("bank_id").Text))

                cmd.CommandText = sStmt
                nRecords = cm.ExecuteNonQuery()
                If nRecords > 0 Then
                    MsgBox("Bank was successfully removed.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Message")
                Else
                    MsgBox("Failed to delete record.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                    Exit Sub
                End If
            End If
		Else
			MsgBox("You must select a record before attempting this command.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		load_dgBank()
	End Sub
End Class