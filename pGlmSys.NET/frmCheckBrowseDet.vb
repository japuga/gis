Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCheckBrowseDet
	Inherits System.Windows.Forms.Form
    Private rsLocal As DataTable
    Private rsCheckDet As DataTable
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		
		If dgChecks.SelBookmarks.Count > 0 Then
			If (MsgBox("Do you want to Delete Check:" & dgChecks.Columns("check_no").Text & " ?", MsgBoxStyle.YesNo, "GLM Message") = MsgBoxResult.Yes) Then
				cancel_check()
				'Refresh Checks Grid
                'grsCheck.Requery()
				load_dgChecks()
			End If
		Else
			MsgBox("Please choose a check to Cancel.", MsgBoxStyle.OKOnly, "GLM Message")
		End If
		
	End Sub
	'Deletes a Check from DB
	Private Sub cancel_check()
		Dim nCheckNo As Integer
		Dim nBankCustSeq As Short
		Dim bOk As Boolean
		Dim nRecords As Short
        Dim nTran As SqlTransaction
		
        'On Error GoTo ErrorHandler
		
		bOk = False
		nCheckNo = CInt(dgChecks.Columns("check_no").Text)
		nBankCustSeq = CShort(dgChecks.Columns("bank_cust_seq").Text)
		
		'Verify if check has been extracted
		sStmt = "SELECT DISTINCT invoice_no, cust_id, " & " store_id, account_no, vend_seq, qb_exported_flag FROM BCheck " & " WHERE check_no =" & Str(nCheckNo) & " AND bank_cust_seq =" & Str(nBankCustSeq)
        Try
            rsLocal = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If rsLocal.Rows.Count > 0 Then
                nRecords = rsLocal.Rows.Count

                If rsLocal.Rows(0).Item("qb_exported_flag").Value = "Y" Then
                    MsgBox("This Check can not be Cancelled. " & vbCrLf & "It was yet exported to Quick Books.", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "GLM Message")
                    Exit Sub
                Else
                    bOk = True ' OK to Update Check
                End If
            Else
                'Check was not found, but this is not an error
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Failed to access Check Data", MsgBoxStyle.OkOnly, "GLM Message")
            Exit Sub
        End Try


        If bOk Then
            nTran = cn.BeginTransaction()
            'Update invoices status  back to CRE included in this Check
            sStmt = "UPDATE Vinvoice SET vinvoice_status='CRE' " & "WHERE EXISTS (SELECT * FROM Bcheck " & " WHERE BCheck.check_no = " & Str(nCheckNo) & " AND BCheck.bank_cust_seq = " & Str(nBankCustSeq) & " AND BCheck.invoice_no = Vinvoice.invoice_no " & " AND BCheck.cust_id = Vinvoice.cust_id " & " AND BCheck.store_id = Vinvoice.store_id " & " AND BCheck.account_no = Vinvoice.account_no " & " AND BCheck.vend_seq = Vinvoice.vend_seq)"

            cm = cn.CreateCommand '.let_ActiveConnection(cn)
            cm.CommandText = sStmt
            nRecords = cm.ExecuteNonQuery()

            If nRecords = rsLocal.Rows.Count Then
                'Delete Check
                sStmt = "DELETE FROM BCheck " & " WHERE check_no=" & Str(nCheckNo) & " AND bank_cust_seq =" & Str(nBankCustSeq)
                cm.CommandText = sStmt
                nRecords = cm.ExecuteNonQuery()
                If nRecords > 0 Then
                    'ok
                    nTran.Commit()
                    MsgBox("Check was successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
                Else
                    nTran.Rollback()
                    MsgBox("Failed to delete all Check Details.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Message")
                End If
            Else
                nTran.Rollback()
                MsgBox("Not all Invoices status were updated. Try again", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Message")
            End If

        End If 'bOk

        Exit Sub

ErrorHandler:

        nTran.Rollback()

        save_error(Me.Name, "Cancel_check")
        MsgBox("Unexpected error ocurred while removing Check. Review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        If dgChecks.SelBookmarks.Count > 0 Then
            set_check()
        Else
            MsgBox("Please choose a check to Reprint.", MsgBoxStyle.OkOnly, "GLM Message")
        End If
    End Sub

    Private Sub cmdRenumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRenumber.Click
        If dgChecks.SelBookmarks.Count > 0 Then
            renumber_check()
        Else
            MsgBox("Please choose a Check to Renumber.", MsgBoxStyle.OkOnly, "GLM Message")
        End If

    End Sub

    Private Sub renumber_check()

        clear_gCheckRenumber()

        gCheckRenumber.bOk = False
        gCheckRenumber.nBankCustSeq = CShort(dgChecks.Columns("bank_cust_seq").Text)
        gCheckRenumber.nVoidCheckNo = CInt(dgChecks.Columns("check_no").Text)

        VB6.ShowForm(frmCheckRenumber, VB6.FormShowConstants.Modal, Me)

        If gCheckRenumber.bOk = True Then
            'grsCheck.Requery()
            load_dgChecks()
        End If

    End Sub
    Private Sub dgChecks_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgChecks.ClickEvent
        If dgChecks.Row >= 0 Then
            load_check_detail(CInt(dgChecks.Columns("check_no").Text), CShort(dgChecks.Columns("bank_cust_seq").Text))
        End If
    End Sub
    Private Sub load_check_detail(ByRef nCheckNo As Integer, ByRef nBankCustSeq As Short)

        'sStmt = "SELECT bcheck.invoice_no AS Invoice," + _
        '" store.store_number AS Store, " + _
        '" vinvoice.account_no AS Account, " + _
        '" vinvoice.vinvoice_date AS Date, " + _
        '" bcheck.store_id, bcheck.invoice_total as Total, " + _
        '" VAccount.account_mask, VInvoice.vend_seq  " + _
        '" FROM Bcheck, Vinvoice, Store, VAccount " + _
        '" WHERE Vinvoice.store_id = Store.store_id " + _
        '" AND Vinvoice.cust_id = Store.cust_id " + _
        '" AND Bcheck.invoice_no = Vinvoice.invoice_no " + _
        '" AND Bcheck.cust_id = Vinvoice.cust_id " + _
        '" AND Bcheck.store_id = Vinvoice.store_id " + _
        '" AND Bcheck.account_no = Vinvoice.account_no " + _
        '" AND Bcheck.vend_seq = Vinvoice.vend_seq " + _
        '" AND VAccount.cust_id = VInvoice.cust_id " + _
        '" AND VAccount.account_no = VInvoice.account_no " + _
        '" AND VAccount.store_id = VInvoice.store_id " + _
        '" AND VAccount.vend_seq = VInvoice.vend_seq " + _
        '" AND Bcheck.check_no =" + Str(nCheckNo) + _
        '" AND Bcheck.bank_cust_seq = " + Str(nBankCustSeq)

        sStmt = get_check_query(nCheckNo, nBankCustSeq)
        'Limpiar datagrid
        'If bClear Then
        '    sStmt = sStmt + " AND Bcheck.check_detail_no =-1"
        'End If

        rsCheckDet = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsCheckDet.Rows.Count > 0 Then
            dgCheckDetail.DataSource = rsCheckDet
        Else
            MsgBox("Failed to load check details.")
            'UPGRADE_NOTE: Object dgCheckDetail.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            dgCheckDetail.DataSource = Nothing
            Exit Sub
        End If

        'Formato datagrid
        dgCheckDetail.Columns("store_id").Visible = False
        dgCheckDetail.Columns("account_mask").Visible = False
        dgCheckDetail.Columns("vend_seq").Visible = False

        dgCheckDetail.Columns("Invoice").Width = VB6.TwipsToPixelsX(1300)
        dgCheckDetail.Columns("Store").Width = VB6.TwipsToPixelsX(1000)
        dgCheckDetail.Columns("Account").Width = VB6.TwipsToPixelsX(1300)
        dgCheckDetail.Columns("Date").Width = VB6.TwipsToPixelsX(1000)
        dgCheckDetail.Columns("Total").Width = VB6.TwipsToPixelsX(800)

    End Sub

    Private Sub dgChecks_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgChecks.DblClick
        'set_check
    End Sub
    'Guarda los datos del cheque a reimprimir
    Private Sub set_check()
        'Guardo los datos para el preview
        gCheck.reprint = True 'Se imprime por primera vez
        gCheck.VoidCheckNo = CInt(dgChecks.Columns("check_no").Text)
        gCheck.BankCustSeq = dgChecks.Columns("bank_cust_seq").Text
        'gCheck.VendorSeq = dgChecks.Columns("vend_seq")

        gCheck.VendorSeq = CShort(dgCheckDetail.Columns("vend_seq").Text)

        gCheck.VendorName = dgChecks.Columns("vend_name").Text
        gCheck.custId = dgChecks.Columns("cust_id").Text
        gCheck.Amount = CDbl(dgChecks.Columns("amount").Text)
        gCheck.Date_Renamed = Today
        gCheck.CustName = dgChecks.Columns("cust_name").Text
        

        gCheck.rsStore = rsCheckDet.Clone

        'Solicita numero de cheque a imprimir
        clear_gCheckVoid()
        gCheckVoid.bOk = False
        gCheckVoid.nBankCustSeq = CShort(dgChecks.Columns("bank_cust_seq").Text)
        gCheckVoid.nVoidCheckNo = CInt(dgChecks.Columns("check_no").Text)

        VB6.ShowForm(frmCheckVoid, VB6.FormShowConstants.Modal, Me)
        If gCheckVoid.bOk = True Then
            'Muestra cheque antes de imprimir
            gCheck.CheckNo = gCheckVoid.nNewCheckNo
            gCheck.bSameCheck = gCheckVoid.bSameCheck
            VB6.ShowForm(frmCheckRep, VB6.FormShowConstants.Modal, Me)

            'grsCheck.Requery()
            format_dgChecks()
        End If

    End Sub
    Private Sub frmCheckBrowseDet_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        init_vars()
        load_dgChecks()
    End Sub

    Private Sub init_vars()
        Dim nTmp As Short

        '1.9.2 Hide Print Button when Browsing
        If General.gCheckBrowseDetMode = General.CheckBrowseDetMode.CheckBrowse Then
            cmdPrint.Visible = False
            cmdCancel.Visible = False
            cmdRenumber.Visible = False
            'cmdCLose.Move 3000
            nTmp = (VB6.PixelsToTwipsX(dgCheckDetail.Width) / 2) + VB6.PixelsToTwipsX(dgCheckDetail.Left)
            cmdCLose.SetBounds(VB6.TwipsToPixelsX(nTmp - (VB6.PixelsToTwipsX(cmdCLose.Width) / 2)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
        End If
    End Sub
    Private Sub load_dgChecks()
        On Error GoTo ErrorHandler

        dgChecks.DataSource = grsCheck
        If grsCheck.Rows.Count > 0 Then
            '    grsCheck.MoveFirst
            '   dgChecks.SelBookmarks.Add grsCheck.Bookmark
            dgChecks.Row = 0
            load_check_detail(grsCheck.Rows(0).Item("check_no").Value, grsCheck.Rows(0).Item("bank_cust_seq").Value)
        End If

        'Formato de Datagrid
        format_dgChecks()
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "load_dgChecks")
    End Sub

    Private Sub format_dgChecks()
        'Formato
        dgChecks.Columns("Vendor").Width = VB6.TwipsToPixelsX(1500)
        dgChecks.Columns("Check No").Width = VB6.TwipsToPixelsX(800)
        dgChecks.Columns("Check Date").Width = VB6.TwipsToPixelsX(900)
        dgChecks.Columns("Amount").Width = VB6.TwipsToPixelsX(1200)

        dgChecks.Columns("check_no").Visible = False
        'dgChecks.Columns("vend_seq").Visible = False
        dgChecks.Columns("bank_cust_seq").Visible = False
        dgChecks.Columns("cust_id").Visible = False
        dgChecks.Columns("cust_name").Visible = False
        dgChecks.Columns("vend_name").Visible = False

    End Sub
End Class