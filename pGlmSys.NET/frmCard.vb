Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCard
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private ImageList2 As New ImageList()
	
	'UPGRADE_WARNING: Event cbBankName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbBankName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbBankName.SelectedIndexChanged
		load_dgCard()
	End Sub
	Private Sub load_dgCard()
		sStmt = "SELECT card_seq, card_type as 'Type', " & " card_number AS  Card, card_balance AS Balance " & " FROM CreditCard " & " WHERE bank_id =" & Str(VB6.GetItemData(cbBankName, cbBankName.SelectedIndex))
        Dim cmd As SqlCommand = cn.CreateCommand
		'UPGRADE_NOTE: Object dgCard.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgCard.DataSource = Nothing
		
        cmd.CommandText = sStmt
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            dgCard.DataSource = rsLocal
        End If
		
		dgCard.Columns("card_seq").Visible = False
		dgCard.Columns("Type").Width = VB6.TwipsToPixelsX(2000)
		dgCard.Columns("Card").Width = VB6.TwipsToPixelsX(2000)
		dgCard.Columns("Balance").Width = VB6.TwipsToPixelsX(1500)
		
		
	End Sub
	
	Private Sub dgCard_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgCard.DblClick
		modify_card()
	End Sub
	
	Private Sub frmCard_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()

        sStmt = "SELECT bank_name, bank_id " & "FROM bank"
        load_cb_query2(cbBankName, sStmt, 2, True)


        If cbBankName.Items.Count > 0 Then
            cbBankName.SelectedIndex = 0
        End If

    End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                gCreditCard.bFlag = General.modo.NewRecord
                VB6.ShowForm(frmCardEntry, VB6.FormShowConstants.Modal, Me)
                If gCreditCard.bFlag = General.modo.SavedRecord Then
                    load_dgCard()
                End If

            Case "save"
                modify_card()
            Case "delete"
                If dgCard.SelBookmarks.Count > 0 Then
                    If MsgBox("Do you want to delete selected Credit Card?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "GLM Message") = MsgBoxResult.Yes Then

                        If delete_card(CShort(dgCard.Columns("card_seq").Text)) Then
                            load_dgCard()
                        End If
                    End If
                Else
                    MsgBox("Please select a record before attempting this action.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Message")
                End If
            Case "exit"
                Me.Close()
        End Select
    End Sub
	
	Private Function delete_card(ByRef nCardSeq As Short) As Boolean
		Dim nRecords As Short
        Dim cmd As sqlcommand = cn.CreateCommand()
		delete_card = False
		
		On Error GoTo ErrorHandler
		nRecords = 0
		sStmt = "SELECT COUNT(*) FROM BTransaction " & " WHERE card_seq =" & Str(nCardSeq)
        cmd.CommandText = sStmt
        rs = getDataTable(sStmt) ' cmd.ExecuteReader()
        If rs.Rows.Count > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rs.Rows(0).Item(0).Value) Or rs.Rows(0).Item(0).Value = 0 Then
                sStmt = "DELETE FROM CreditCard " & " WHERE card_seq = " & Str(nCardSeq)
                cmd.CommandText = sStmt
                nRecords = cmd.ExecuteNonQuery()
                If nRecords > 0 Then
                    MsgBox("Credit Card was successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
                    delete_card = True
                    Exit Function
                Else
                    MsgBox("Failed to delete Credit Card information." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                    write_msg("delete_card", "card_seq:" & Str(nCardSeq))
                    Exit Function
                End If
            Else
                MsgBox("Can not delete this Credit Card." & vbCrLf & "It has been used in one or more invoice payments.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Function
            End If
        End If
		Exit Function
		
ErrorHandler: 
		save_error(Me.Name, "delete_card")
		MsgBox("Unexpected error was found while deleting Credit Card." & vbCrLf & "Check log files for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
	End Function
	Private Sub modify_card()
		If set_data Then
			gCreditCard.bFlag = General.modo.UpdateRecord
			VB6.ShowForm(frmCardEntry, VB6.FormShowConstants.Modal, Me)
			If gCreditCard.bFlag = General.modo.SavedRecord Then
				load_dgCard()
			End If
			
		End If
		
	End Sub
	Private Function set_data() As Boolean
		
		set_data = False
		
		If cbBankName.SelectedIndex >= 0 Then
			gCreditCard.nBankId = VB6.GetItemData(cbBankName, cbBankName.SelectedIndex)
		Else
			Exit Function
		End If
		
		
		If dgCard.SelBookmarks.Count > 0 Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(dgCard.Columns("Card").Text) Then
				gCreditCard.sCardNumber = dgCard.Columns("Card").Text
			Else
				Exit Function
			End If
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(dgCard.Columns("card_seq").Text) Then
				gCreditCard.nCardSeq = CShort(dgCard.Columns("card_seq").Text)
			Else
				Exit Function
			End If
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(dgCard.Columns("Type").Text) Then
				gCreditCard.sCardType = dgCard.Columns("Type").Text
			Else
				Exit Function
			End If
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(dgCard.Columns("Balance").Text) Then
				gCreditCard.nCardBalance = CDbl(dgCard.Columns("Balance").Text)
			Else
				gCreditCard.nCardBalance = 0
			End If
			
			set_data = True
		Else
			MsgBox("Please select a record before attempting this action.", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "GLM Message")
			Exit Function
		End If
		
	End Function
End Class