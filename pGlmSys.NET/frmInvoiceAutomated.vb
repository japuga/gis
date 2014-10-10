Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmInvoiceAutomated
	Inherits System.Windows.Forms.Form
    Private rsContract As SqlDataReader
	Private Structure values
		Dim nHeaders As Short
		Dim nDetails As Short
	End Structure
	
	
	
	'UPGRADE_WARNING: Event cbCustId.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustId_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustId.SelectedIndexChanged
		If cbCustId.SelectedIndex >= 0 Then
			load_StoreGroup(cbCustId.Text)
			load_period(cbCustId.Text)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		If cbCustName.SelectedIndex >= 0 Then
			cbCustId.SelectedIndex = cbCustName.SelectedIndex
		End If
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		
		If val_fields Then
			generate_invoice(cbCustId.Text, VB6.GetItemData(cbStoreGroup, cbStoreGroup.SelectedIndex), VB6.GetItemData(cbPeriodName, cbPeriodName.SelectedIndex))
			Me.Close()
		End If
		
		
	End Sub
	Private Function val_fields() As Boolean
        val_fields = False
        Dim cmd As SqlCommand = cn.CreateCommand()
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(txtInvoiceNo.Text) Then
			MsgBox("Please enter Invoice Number.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			txtInvoiceNo.Focus()
			Exit Function
		Else
			If Len(Trim(txtInvoiceNo.Text)) = 0 Then
				MsgBox("Please enter Invoice Number.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
				txtInvoiceNo.Focus()
				Exit Function
			Else
				'Check that Invoice No is not in DB
                sStmt = "SELECT COUNT(*) FROM VInvoice " & " WHERE invoice_no='" & quotation_mask(Trim(txtInvoiceNo.Text)) & "'"
                cmd.CommandText = sStmt
                rs = getDataTable(sStmt) ' cmd.ExecuteReader()

                If rs.Rows.Count > 0 Then
                    If rs.Rows(0).Item(0).Value > 0 Then
                        MsgBox("Found another Invoice with Number you specified." & vbCrLf & "This could potencially create duplicate invoices." & vbCrLf & "Enter another invoice number.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Warning")

                        txtInvoiceNo.Focus()
                        Exit Function
                    End If
                End If

            End If
        End If
        val_fields = True
        Exit Function

ErrorHandler:
        save_error(Me.Name, "val_fields")
        MsgBox("Unexpected error found while validating information.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
	End Function
	
	'Genera facturas automaticas usando informacion de contratos
	Private Function generate_invoice(ByRef sCustId As String, ByRef nGroupSeq As Short, ByRef nPeriodSeq As Short) As Boolean
		
		Dim nStoreId As Short
		Dim nHeaders As Object
		Dim nDetails As Short
        Dim valores As values
        Dim cmd As SqlCommand = cn.CreateCommand()
		
		On Error GoTo ErrorHandler
		
		'UPGRADE_WARNING: Couldn't resolve default property of object nHeaders. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		nHeaders = 0
		nDetails = 0
		
		'Obtener lista de tiendas
		sStmt = "SELECT store_id FROM groupStore " & " WHERE cust_id = '" & sCustId & "'" & " AND group_seq=" & Str(nGroupSeq)
        cmd.CommandText = sStmt
        rs = getDataTable(sStmt) 'cmd.ExecuteReader()

        If rs.Rows.Count > 0 Then

            For row As Integer = 0 To rs.Rows.Count - 1
                nStoreId = rs.Rows(0).Item("store_id").Value

                'UPGRADE_WARNING: Couldn't resolve default property of object valores. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                valores = get_contracts(sCustId, nStoreId, nPeriodSeq)
                'UPGRADE_WARNING: Couldn't resolve default property of object nHeaders. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                nHeaders = nHeaders + valores.nHeaders
                nDetails = nDetails + valores.nDetails

            Next row
        End If


        'UPGRADE_WARNING: Couldn't resolve default property of object nHeaders. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If nHeaders > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object nHeaders. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            MsgBox("Process complete." & vbCrLf & "Invoices generated:" & Str(nHeaders) & " Total invoice details:" & Str(nDetails), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
        End If
        Exit Function

ErrorHandler:
        save_error(Me.Name, "generate_invoice")
        MsgBox("Unexpected error while generating invoice." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
		
	End Function
	'Obtiene contratos para una tienda
	Private Function get_contracts(ByRef sCustId As String, ByRef nStoreId As Short, ByRef nPeriodSeq As Short) As values
		
        Dim nTranLevel As SqlTransaction
		Dim sInvoiceStatus As String
		Dim nHeaders As Short
		Dim nDetails As Short
		Dim nInvoiceDetNo As Short
		Dim nOldRate, nCurrRate As Object
		Dim nSubtotal As Double
		Dim nServId As Object
		Dim nEqptSeq As Short
		Dim sServDesc, sEqptDesc As Object
		Dim sUnitType As String
		Dim sBillSavingFlag As String
        Dim nRecords As Short
        Dim cmd As SqlCommand = cn.CreateCommand()
		
		Dim nPrevVendSeq As Object
		Dim nVendSeq As Short
		Dim sPrevAccountNo As Object
        Dim sAccountNo As String = ""
		
		get_contracts.nHeaders = 0
		get_contracts.nDetails = 0
		
		On Error GoTo ErrorHandler
		
		sStmt = "SELECT c.cust_id, c.vend_seq, c.store_id, c.eqpt_seq, " & "c.serv_id, c.curr_rate, " & "c.old_rate, a.account_no, e.eqpt_desc, " & "s.serv_desc, s.serv_measure_unit " & " FROM VContract c, VAccountEqpt a, StoreEqpt e, " & " Service s " & " WHERE c.cust_id='" & sCustId & "' " & " AND c.store_id =" & Str(nStoreId) & " " & " AND c.expiration_date > getdate ()" & " AND c.cust_id = e.cust_id " & " AND c.store_id = e.store_id " & " AND c.eqpt_seq = e.eqpt_seq " & " AND e.eqpt_status='A' " & " AND c.cust_id= a.cust_id " & " AND c.store_id = a.store_id " & " AND c.eqpt_seq = a.eqpt_seq " & " AND c.vend_seq = a.vend_seq " & " AND a.account_status ='A' " & " AND c.serv_id = s.serv_id "
        cmd.CommandText = sStmt
		
		
        rsContract = cmd.ExecuteReader()

        If rsContract.HasRows() Then
            'ok
        Else
            'No hay contratos para estas tiendas
            Exit Function
        End If


        'Por cada contrato insertar en Vinvoice y Vinvoicedet

        nHeaders = 0
        nDetails = 0
        nInvoiceDetNo = 0
        nSubtotal = 0
        sInvoiceStatus = "CRE"





        'UPGRADE_WARNING: Couldn't resolve default property of object nPrevVendSeq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        nPrevVendSeq = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object sPrevAccountNo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sPrevAccountNo = ""

        nTranLevel = cn.BeginTransaction()

        While rsContract.Read()

            nVendSeq = rsContract.Item("vend_seq").Value
            sAccountNo = rsContract.Item("account_no").Value

            'Verificar si aparece otro equipo ,vendor o Account            
            If nPrevVendSeq <> nVendSeq Or sPrevAccountNo <> sAccountNo Then

                'Actualizar total del factura anterior
                If nSubtotal > 0 Then
                    sStmt = "UPDATE VInvoice SET total =" & Str(nSubtotal) & " WHERE invoice_no='" & quotation_mask(Trim(txtInvoiceNo.Text)) & "' " & " AND cust_id = '" & sCustId & "' " & " AND store_id =" & Str(nStoreId) & " AND vend_seq =" & Str(nPrevVendSeq) & " AND account_no ='" & Trim(sPrevAccountNo) & "'"
                    nRecords = 0

                    cmd.CommandText = sStmt
                    nRecords = cmd.ExecuteNonQuery()

                    If nRecords <= 0 Then
                        nTranLevel.Rollback()
                        MsgBox("Failed to update Invoice Header. " & "Aborting process.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                        Exit Function
                    End If
                End If

                'UPGRADE_WARNING: Couldn't resolve default property of object nPrevVendSeq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                nPrevVendSeq = nVendSeq
                'UPGRADE_WARNING: Couldn't resolve default property of object sPrevAccountNo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sPrevAccountNo = sAccountNo


                nSubtotal = 0

                'CABECERA
                sStmt = "INSERT INTO VInvoice(invoice_no, cust_id, " & "store_id, account_no, vend_seq, total, " & " vinvoice_status, vinvoice_date, create_user, " & " change_user, change_time, period_seq) " & " VALUES ('" & quotation_mask(Trim(txtInvoiceNo.Text)) & "'," & "'" & cbCustId.Text & "'," & Str(nStoreId) & "," & "'" & Trim(sAccountNo) & "'," & Str(nVendSeq) & "," & Str(nSubtotal) & "," & "'" & sInvoiceStatus & "','" & Str(dtInvoiceDate._Value) & "','" & gsUser & "'," & "'" & gsUser & "','" & Str(dtInvoiceDate._Value) & "'," & Str(nPeriodSeq) & ")"

                'MsgBox sStmt
                cmd.CommandText = sStmt
                nRecords = cmd.ExecuteNonQuery()

                If nRecords <= 0 Then
                    nTranLevel.Rollback()
                    MsgBox("Failed to insert Invoice. " & "Aborting process.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                    Exit Function
                Else
                    'Contar registros insertados
                    nHeaders = nHeaders + 1
                End If
            End If 'Invoice Header

            'DETALLE
            nInvoiceDetNo = nInvoiceDetNo + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object nServId. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nServId = rsContract.Item("serv_id").Value
            nEqptSeq = rsContract.Item("eqpt_seq").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object nOldRate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nOldRate = rsContract.Item("old_rate").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object nCurrRate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nCurrRate = rsContract.Item("curr_rate").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object nCurrRate. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nSubtotal = nSubtotal + nCurrRate
            'UPGRADE_WARNING: Couldn't resolve default property of object sServDesc. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sServDesc = rsContract.Item("serv_desc").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object sEqptDesc. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sEqptDesc = rsContract.Item("eqpt_desc").Value
            sUnitType = rsContract.Item("serv_measure_unit").Value
            sBillSavingFlag = "YES"

            
            sStmt = " INSERT INTO VInvoiceDet (invoice_det_no, " & " invoice_no, cust_id, store_id, account_no, vend_seq, " & " serv_date, serv_id, eqpt_seq, old_rate, rate," & " subtotal,create_user, change_user, change_time, " & " serv_desc, eqpt_desc, serv_usage, units, " & " unit_type, bill_saving_flag) " & " VALUES (" & Str(nInvoiceDetNo) & ",'" & quotation_mask(Trim(txtInvoiceNo.Text)) & "'," & "'" & cbCustId.Text & "'," & Str(nStoreId) & "," & "'" & Trim(sAccountNo) & "'," & Str(nVendSeq) & "," & "getdate()," & Str(nServId) & "," & Str(nEqptSeq) & "," & Str(nOldRate) & "," & Str(nCurrRate) & "," & Str(nCurrRate) & ",'" & gsUser & "','" & gsUser & "'," & "getdate(),'" & Trim(sServDesc) & "','" & Trim(sEqptDesc) & "', " & "1, 1,'" & sUnitType & "', " & "'" & sBillSavingFlag & "')"
            cmd.CommandText = sStmt
            nRecords = cmd.ExecuteNonQuery()

            If nRecords <= 0 Then
                nTranLevel.Rollback()
                MsgBox("Failed to insert Invoice Detail. " & "Aborting process.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Function
            Else
                'Contar registros insertados
                nDetails = nDetails + 1
            End If
        End While


        'Actualizar total de ultima factura
        If nSubtotal > 0 Then
            sStmt = "UPDATE VInvoice SET total =" & Str(nSubtotal) & " WHERE invoice_no='" & quotation_mask(Trim(txtInvoiceNo.Text)) & "' " & " AND cust_id = '" & sCustId & "' " & " AND store_id =" & Str(nStoreId) & " AND vend_seq =" & Str(nVendSeq) & " AND account_no ='" & Trim(sAccountNo) & "'"
            cmd.CommandText = sStmt
            nRecords = cmd.ExecuteNonQuery()

            If nRecords <= 0 Then
                nTranLevel.Rollback()
                MsgBox("Failed to update Invoice Header. " & "Aborting process.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Function
            End If

        End If


        nTranLevel.Commit()

        get_contracts.nHeaders = nHeaders
        get_contracts.nDetails = nDetails

        Exit Function

ErrorHandler:

        nTranLevel.Rollback()

        save_error(Me.Name, "get_contracts")
        MsgBox("Unexpected error when inserting Automated Invoices." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
		
	End Function
	Private Sub frmInvoiceAutomated_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	Private Sub init_vars()
		'UPGRADE_WARNING: TextBox property txtInvoiceNo.MaxLength has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		txtInvoiceNo.Maxlength = 30
		
		'CustName
		sStmt = "SELECT DISTINCT c.cust_name, u.cust_id " & " FROM suser_data u, customer c " & " WHERE u.cust_id = c.cust_id " & " AND u.suser_name = '" & gsUser & "' " & " ORDER BY c.cust_name"
		load_cb_query2(cbCustName, sStmt, 1, True)
		
		'CustId
		sStmt = "SELECT DISTINCT u.cust_id, c.cust_name " & " FROM suser_data u, customer c " & " WHERE u.cust_id = c.cust_id " & " AND u.suser_name = '" & gsUser & "'" & " ORDER BY c.cust_name"
		load_cb_query2(cbCustId, sStmt, 1, True)
		
		If cbCustName.Items.Count > 0 Then
			cbCustName.SelectedIndex = 0
		End If
		
		dtInvoiceDate._Value = Today
		
	End Sub
	
	Private Sub load_StoreGroup(ByRef sCustId As String)
		On Error GoTo ErrorHandler
		
		'StoreGroup
		sStmt = "SELECT group_name, group_seq " & " FROM groups " & " WHERE cust_id='" & sCustId & "' " & " ORDER BY group_name"
		
		load_cb_query2(cbStoreGroup, sStmt, 2, True)
		If cbStoreGroup.Items.Count > 0 Then
			cbStoreGroup.SelectedIndex = 0
		End If
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_StoreGroup")
		MsgBox("Unexpected error has occurred.  " & "Check log file for details", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	
	Private Sub load_period(ByRef sCustId As String)
		
		On Error GoTo ErrorHandler
		'Periods
		sStmt = "SELECT period_name, period_seq, period_start_date " & " FROM period " & " WHERE cust_id='" & sCustId & "'" & " AND period_status_id='O' " & " ORDER BY period_start_date "
		load_cb_query2(cbPeriodName, sStmt, 2, True)
		
		If cbPeriodName.Items.Count > 0 Then
			cbPeriodName.SelectedIndex = 0
		End If
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_Period")
		MsgBox("Unexpected error has occurred.  " & "Check log file for details", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
	End Sub
End Class