Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCustFeeBillRange
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Public ImageList2 As New ImageList()
	
	
	Private Sub frmCustFeeBillRange_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        init_vars()
    End Sub
	
	Private Sub init_vars()
		load_dgBillingRange()
	End Sub
	Private Sub load_dgBillingRange()
		On Error GoTo ErrorHandler
        Dim cmd As SqlCommand = cn.CreateCommand()
		sStmt = "SELECT range_seq, lower_bound 'From Amount', " & " upper_bound 'To Amount', range_fee_value 'Value' " & " FROM feeBillingRange " & " WHERE fee_id =" & Str(gFeeBillingRange.nFeeId)
		
		
		
		'Set dgBillingRange.DataSource = Nothing
        cmd.CommandText = sStmt
		
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            dgBillingRange.DataSource = rsLocal
        Else
            'UPGRADE_NOTE: Object dgBillingRange.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            dgBillingRange.DataSource = Nothing
            Exit Sub
        End If
		
		'Format Datagrid
		dgBillingRange.Columns("range_seq").Visible = False
		
		dgBillingRange.Columns("From Amount").Width = VB6.TwipsToPixelsX(1800)
		dgBillingRange.Columns("To Amount").Width = VB6.TwipsToPixelsX(1800)
		dgBillingRange.Columns("Value").Width = VB6.TwipsToPixelsX(1800)
		
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgBillingRange.Refresh()
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgBillingrange")
		MsgBox("Unexpected error found while loading Fee Billing Range Information." & vbCrLf & "Review lod file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "new"
                add_billingRange()
            Case "save"
                update_billingRange()
            Case "delete"
                delete_billingRange()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	Private Sub add_billingRange()
		
		gFeeBillingRangeDet.bFlag = General.modo.NewRecord
		gFeeBillingRangeDet.nFeeId = gFeeBillingRange.nFeeId
		
		VB6.ShowForm(frmCustFeeBillRangeDet, VB6.FormShowConstants.Modal, Me)
		If gFeeBillingRangeDet.bFlag = General.modo.SavedRecord Then
			save_billingRange((General.modo.NewRecord))
			load_dgBillingRange()
		End If
		
	End Sub
	Private Sub update_billingRange()
		gFeeBillingRangeDet.bFlag = General.modo.UpdateRecord
		
		If dgBillingRange.Row >= 0 Then
			gFeeBillingRangeDet.nFeeId = gFeeBillingRange.nFeeId
			gFeeBillingRangeDet.nRangeSeq = CShort(dgBillingRange.Columns("range_seq").Text)
			gFeeBillingRangeDet.nLowerBound = CDbl(dgBillingRange.Columns("From Amount").Text)
			gFeeBillingRangeDet.nUpperBound = CDbl(dgBillingRange.Columns("To Amount").Text)
			gFeeBillingRangeDet.nRangeFeeValue = CDbl(dgBillingRange.Columns("Value").Text)
		Else
			MsgBox("Please select a record before taking this option.", MsgBoxStyle.Information, "GLM Warning")
			Exit Sub
		End If
		
		VB6.ShowForm(frmCustFeeBillRangeDet, VB6.FormShowConstants.Modal, Me)
		If gFeeBillingRangeDet.bFlag = General.modo.SavedRecord Then
			save_billingRange((General.modo.UpdateRecord))
			load_dgBillingRange()
		End If
		
	End Sub
	Private Sub delete_billingRange()
		
		Dim nRecords As Short
        Dim cmd As sqlcommand = cn.CreateCommand()
		If dgBillingRange.Row >= 0 Then
			'Delete from FeeBillingRange
			sStmt = "DELETE FROM FeeBillingRange " & " WHERE fee_id=" & Str(gFeeBillingRange.nFeeId) & " AND range_seq =" & Str(CDbl(dgBillingRange.Columns("range_seq").Text))
            cmd.CommandText = sStmt
            nRecords = cmd.ExecuteNonQuery()
			If nRecords > 0 Then
				MsgBox("Record was successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
			End If
		Else
			MsgBox("Please select a record before attempting this command.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
		End If
		
		load_dgBillingRange()
	End Sub
	
	
	Private Sub save_billingRange(ByRef bOption As General.modo)
		Dim nRangeSeq As Short
		Dim nRecords As Short
        Dim cmd As SqlCommand = cn.CreateCommand()

		Select Case bOption
			Case General.modo.NewRecord
				'New range sequence
				sStmt = " SELECT MAX(range_seq) FROM FeeBillingRange " & " WHERE fee_id =" & Str(gFeeBillingRangeDet.nFeeId)
				nRangeSeq = 0
                cmd.CommandText = sStmt
                rs = getDataTable(sStmt) ' cmd.ExecuteReader()

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rs.Rows(0).Item(0).Value) Then
                    nRangeSeq = rs.Rows(0).Item(0).Value
                End If


                gFeeBillingRangeDet.nRangeSeq = nRangeSeq + 1
                'Insert
                sStmt = "INSERT INTO FeeBillingRange (fee_id, " & " range_seq, lower_bound, upper_bound, " & " range_fee_value) VALUES (" & Str(gFeeBillingRange.nFeeId) & "," & Str(gFeeBillingRangeDet.nRangeSeq) & "," & Str(gFeeBillingRangeDet.nLowerBound) & "," & Str(gFeeBillingRangeDet.nUpperBound) & "," & Str(gFeeBillingRangeDet.nRangeFeeValue) & ")"
                cmd.CommandText = sStmt
                nRecords = cm.ExecuteNonQuery()

                If nRecords = 0 Then
                    MsgBox("Failed to insert into Fee Billing Range table.")
                End If

            Case General.modo.UpdateRecord
                sStmt = "UPDATE FeeBillingRange " & " SET lower_bound =" & Str(gFeeBillingRangeDet.nLowerBound) & "," & " upper_bound =" & Str(gFeeBillingRangeDet.nUpperBound) & "," & " range_fee_value = " & Str(gFeeBillingRangeDet.nRangeFeeValue) & " WHERE fee_id = " & Str(gFeeBillingRange.nFeeId) & " AND range_seq =" & Str(gFeeBillingRangeDet.nRangeSeq)
                cmd.CommandText = sStmt
                nRecords = cm.ExecuteNonQuery()
                If nRecords > 0 Then
                    'ok
                Else
                    MsgBox("Failed to update FeeBillingRange table. Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                    Exit Sub
                End If
        End Select
		
		
		
	End Sub
End Class