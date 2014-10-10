Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmBank
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private ImageList2 As New ImageList()
	
	Private Sub dgBankAccount_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgBankAccount.DblClick
		update_bankAccount()
	End Sub
	
	Private Sub frmBank_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()

        load_dgBankAccount()

    End Sub
	Private Sub load_dgBankAccount()
		
		On Error GoTo ErrorHandler
        Dim cmd As SqlCommand = cn.CreateCommand()
		sStmt = "SELECT BankAccount.cust_id, " & " Customer.cust_name AS Cust, " & " Bank.bank_id, Bank.bank_name AS 'Bank', " & " BankAccount.bank_account AS Account , " & " BankAccount.bank_account_balance AS Balance," & " BankAccount.last_check_no AS LastCheck, " & " BankAccount.bank_cust_seq " & "FROM Bank, BankAccount, Customer " & "WHERE Bank.bank_id = BankAccount.bank_id " & " AND BankAccount.cust_id = Customer.cust_id " & " ORDER BY Customer.cust_name, Bank.bank_name, BankAccount.bank_account"
        cmd.CommandText = sStmt
		'UPGRADE_NOTE: Object dgBankAccount.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgBankAccount.DataSource = Nothing
		
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            dgBankAccount.DataSource = rsLocal
        Else
            'UPGRADE_NOTE: Object dgBankAccount.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            dgBankAccount.DataSource = Nothing
            Exit Sub
        End If
		
		'Format Datagrid
		dgBankAccount.Columns("cust_id").Visible = False
		dgBankAccount.Columns("bank_id").Visible = False
		dgBankAccount.Columns("bank_cust_seq").Visible = False
		'dgBankAccount.Columns("bank_account_balance_mask").Visible = False
		
		dgBankAccount.Columns("Cust").Width = VB6.TwipsToPixelsX(1800)
		dgBankAccount.Columns("Bank").Width = VB6.TwipsToPixelsX(1300)
		dgBankAccount.Columns("Account").Width = VB6.TwipsToPixelsX(1600)
		dgBankAccount.Columns("Balance").Width = VB6.TwipsToPixelsX(800)
		dgBankAccount.Columns("LastCheck").Width = VB6.TwipsToPixelsX(1100)
		
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgBankAccount.Refresh()
        'dgBankAccount.Refresh()
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgBankAccount")
		MsgBox("Unexpected error found while loading Bank Account Information." & vbCrLf & "Review lod file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "new"
                add_bankAccount()
            Case "save"
                update_bankAccount()
            Case "delete"
                delete_bankAccount()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	Private Sub add_bankAccount()
		gBankAccount.bFlag = General.modo.NewRecord
		If set_data Then
			VB6.ShowForm(frmBankEntry, VB6.FormShowConstants.Modal, Me)
			If gBankAccount.bFlag = General.modo.SavedRecord Then
				load_dgBankAccount()
			End If
		End If
		
	End Sub
	Private Sub update_bankAccount()
		If dgBankAccount.SelBookmarks.Count > 0 Then
			'ok
			gBankAccount.bFlag = General.modo.UpdateRecord
			If set_data Then
				VB6.ShowForm(frmBankEntry, VB6.FormShowConstants.Modal, Me)
				If gBankAccount.bFlag = General.modo.SavedRecord Then
					load_dgBankAccount()
				End If
			End If
		Else
			MsgBox("Please select a record before attempting this command.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
			Exit Sub
		End If
		
	End Sub
	
	Private Function set_data() As Boolean
		
		set_data = True
		
		Select Case gBankAccount.bFlag
			Case General.modo.NewRecord
				gBankAccount.sBankAccount = ""
				gBankAccount.nBankAccountBalance = 0
				gBankAccount.sBankAccountBalanceMask = ""
				gBankAccount.nLastCheckNo = 1
				
				
				
			Case General.modo.UpdateRecord
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("bank_cust_seq").Text) Then
					If CDbl(dgBankAccount.Columns("bank_cust_seq").Text) > 0 Then
						gBankAccount.nBankCustSeq = CShort(dgBankAccount.Columns("bank_cust_seq").Text)
					Else
						MsgBox("Failed to load Bank Id", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
						set_data = False
						Exit Function
					End If
				Else
					MsgBox("Failed to load Bank Id", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
					set_data = False
					Exit Function
				End If
				
				'BankId
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("bank_id").Text) Then
					gBankAccount.nBankId = CShort(dgBankAccount.Columns("bank_id").Text)
				Else
					MsgBox("Bank information was not properly loaded.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
					set_data = False
					Exit Function
				End If
				
				'CustId
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("cust_id").Text) Then
					gBankAccount.sCustId = dgBankAccount.Columns("cust_id").Text
				End If
				
				'Bank Account
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("Account").Text) Then
					gBankAccount.sBankAccount = dgBankAccount.Columns("Account").Text
				Else
					MsgBox("Failed to load Bank Account", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
					set_data = False
					Exit Function
				End If
				
				'Balance
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("balance").Text) Then
					gBankAccount.nBankAccountBalance = CDbl(dgBankAccount.Columns("balance").Text)
				Else
					gBankAccount.nBankAccountBalance = 0
				End If
				
				'Last Check No
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(dgBankAccount.Columns("LastCheck").Text) Then
					gBankAccount.nLastCheckNo = CInt(dgBankAccount.Columns("LastCheck").Text)
				Else
					MsgBox("Failed to get Last printed Check.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
					set_data = False
					Exit Function
				End If
				
		End Select
		
	End Function
	Private Sub delete_bankAccount()
		Dim nRecords As Short
        Dim cmd As SqlCommand = cn.CreateCommand()
		On Error GoTo ErrorHandler
		
		If dgBankAccount.SelBookmarks.Count > 0 Then
			'Verify if there is no check associated to this Bank Account
			sStmt = "SELECT COUNT(*) FROM BCheck " & " WHERE bank_cust_seq=" & Str(CDbl(dgBankAccount.Columns("bank_cust_seq").Text))
            cmd.CommandText = sStmt
			
            rs = getDataTable(sStmt) ' cmd.ExecuteReader()
            If rs.Rows.Count > 0 Then
                If rs.Rows(0).Item(0).Value > 0 Then
                    MsgBox("Failed to delete. Found some checks associated to this Bank Account.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
                    Exit Sub
                End If
            End If

            sStmt = "DELETE FROM BankAccount " & "WHERE bank_cust_seq =" & Str(CDbl(dgBankAccount.Columns("bank_cust_seq").Text))
            cmd.CommandText = sStmt
            nRecords = cm.ExecuteNonQuery()
            If nRecords > 0 Then
                'ok
                MsgBox("Bank Account was successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
                load_dgBankAccount()
                Exit Sub
            Else
                MsgBox("Failed to delete Bank Account.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Sub
            End If

        Else
            MsgBox("You must select a record before attempting this command.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
            Exit Sub
        End If

        Exit Sub

ErrorHandler:
        save_error(Me.Name, "delete_bankAccount")
        MsgBox("Unexpected error found while deleting Bank Account." & vbCrLf & "Please review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
		
	End Sub
End Class