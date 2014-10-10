Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Friend Class frmCustInvBatchEntry
	Inherits System.Windows.Forms.Form
	'Private Declare Function GetTempPath Lib "kernel32" _
	'Alias "GetTempPathA" (ByVal nBufferLength As Long, _
	'ByVal lpBuffer As String) As Long
	
	'Private Declare Function GetTempFileName Lib "kernel32" _
	'Alias "GetTempFileNameA" (ByVal lpszPath As String, _
	'ByVal lpPrefixString As String, ByVal wUnique As Long, _
	'ByVal lpTempFileName As String) As Long
	
	Private oWord As Object 'New Word.Application
	Public stre As ADODB.Stream
	Public stmt As String
    Private rsLocal As DataTable
	Private period_start_date() As Date
	Private sAddress As String
	Private sAccountNo As String
	
	Private mInvoiceTotal As Double
	Private mSavings As Double
	Private mSavingsPercent As Double
	Private mStoreFlatFee As Double
	Private mInvoiceFee As Double
	Private mTax As Double
	Private mGrandTotal As Double
	
	Public sReport_Id As String
	Private nFile As String
	
	Public scbPeriod As Short
	Public scbCustId As Short
	Public scbStoreGroup As Short
	Public sdtInvoiceDate As Date
	Public scbCustName As Short
	
	
	'UPGRADE_WARNING: Event cbPeriod.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbPeriod_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbPeriod.SelectedIndexChanged
		txtInvoiceNo.Text = "NV-" & Trim(cbCustId.Text)
		txBillingPeriod.Text = ""
		If cbPeriod.Items.Count > 0 Then
			txtInvoiceNo.Text = txtInvoiceNo.Text & "-" & VB6.Format(period_start_date(cbPeriod.SelectedIndex + 1), "MM") & VB6.Format(period_start_date(cbPeriod.SelectedIndex + 1), "yy")
			txBillingPeriod.Text = VB6.Format(period_start_date(cbPeriod.SelectedIndex + 1), "MMMM yyyy")
		End If
	End Sub
	
	'Private Sub create_param_rs(nombreParametro As String, tipo As DataTypeEnum, destino As ParameterDirectionEnum, valor As Variant, raCmd As ADODB.Command, Optional tamanio As Long)
	'    Dim raPrm As ADODB.Parameter
	'
	'    If raCmd Is Nothing Then
	'        Set raCmd = New ADODB.Command
	'    End If
	'
	'    Set raPrm = raCmd.CreateParameter(nombreParametro, tipo, destino, tamanio)
	'    raCmd.Parameters.Append raPrm
	'    raPrm.Value = valor
	'End Sub
	
	
	Private Function iCust_invoice_seq() As Integer
		
		'***********************************************************************
		'
		'     Obtener último secuencial...!!!
		'
		'***********************************************************************
        Dim rs As New DataTable
		sStmt = "SELECT max(cust_invoice_seq) as iSeq " & " FROM CustomerInvoice "
		
		rs = exec_sql(sStmt)
		
        'If rs.State <> ADODB.ObjectStateEnum.adStateOpen Then
        '	MsgBox("Your Account does not have access to such Information." & vbCrLf & "Contact your System Administrator to get proper access.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Warning")
        '	iCust_invoice_seq = 0
        '	Exit Function
        'Else
        If rs.Rows.Count <= 0 Then
            MsgBox("No GIR report was found for selected combination: " & vbCrLf & "Customer, Period", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            iCust_invoice_seq = 0
            Exit Function
        End If
        'End If


        iCust_invoice_seq = IIf(IsDBNull(rs.Rows(0).Item("iSeq").value), 0, rs.Rows(0).Item("iSeq").value) + 1
		
	End Function
	
	Private Function iCust_invoice_seq_batch() As Integer
		
		'***********************************************************************
		'
		'     Obtener último secuencial de batch...!!!
		'
		'***********************************************************************
		
        Dim rs As DataTable
		sStmt = "SELECT max(cust_inv_batch_seq) as iSeq " & " FROM customerInvoiceBatch "
        Try
            rs = exec_sql(sStmt)
            If rs.Rows.Count <= 0 Then
                iCust_invoice_seq_batch = 1
            Else
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                iCust_invoice_seq_batch = IIf(IsDBNull(rs.Rows(0).Item("iSeq").value), 0, rs.Rows(0).Item("iSeq").value) + 1
            End If
        Catch ex As Exception
            MsgBox("Your Account does not have access to such Information." & vbCrLf & "Contact your System Administrator to get proper access.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            iCust_invoice_seq_batch = 0
            Exit Function
        End Try
        


    End Function
	'Verify that locations are available for the given Store Group
	'Inserts header record in CustomerInvoiceBatch
	Private Sub cmdBuildDoc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBuildDoc.Click
        Dim nCounter As Integer = 0
        Dim nRecords As Object = 0
		Dim Cust_invoice_seq_batch As Object
		Dim Cust_invoice_seq As Short
		Dim countBatch As Short
        Dim nDbTran As sqltransaction
		Dim iStoreId As String
		Dim nReportId As Integer
		Dim nGroupSeq As Short
		Dim sStoreNumber As String
		Dim sContact As String
		
		If cbStoreGroup.SelectedIndex < 0 Then
			Exit Sub
		End If
		
		
		
		
		'Verify that locations are available for the given Store Group
		'***********************************************************************
		
		sStmt = "SELECT * " & "FROM groupStore " & "WHERE group_seq = " & VB6.GetItemData(cbStoreGroup, cbStoreGroup.SelectedIndex) & " AND cust_id = '" & Trim(Me.cbCustId.Text) & "'"
		
        Try
            rsLocal = exec_sql(sStmt)
            If rsLocal.Rows.Count <= 0 Then
                MsgBox("Could not find Stores for selected combination: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Store Group: " & Me.cbStoreGroup.Text, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Could not find Stores for selected combination: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Store Group: " & Me.cbStoreGroup.Text, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            Exit Sub
        End Try


		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cust_invoice_seq_batch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Cust_invoice_seq_batch = iCust_invoice_seq_batch
		
		'Insert BATCH header
		'**********************************************************
		countBatch = 0
        nDbTran = cn.BeginTransaction()
		
		
		sStmt = "INSERT INTO customerInvoiceBatch (cust_inv_batch_seq, cust_id , period_seq, invoice_date, " & " group_seq, batch_desc, batch_date) " & " VALUES (?,?,?,?,?,?,?)"
		
		'
        cm = cn.CreateCommand
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cust_invoice_seq_batch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		create_param_rs("cust_inv_batch_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, Trim(Cust_invoice_seq_batch), cm, 10)
		create_param_rs("cust_id", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, Trim(cbCustId.Text), cm, 10)
		create_param_rs("period_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex), cm, 10)
		create_param_rs("invoice_date", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.dtInvoiceDate.value, 10), cm, 10)
		create_param_rs("group_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, VB6.GetItemData(cbStoreGroup, cbStoreGroup.SelectedIndex), cm, 10)
		create_param_rs("batch_desc", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, (txBatchDesc.Text), cm, 100)
		create_param_rs("batch_date", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, Trim(VB6.Format(Today, "yyyy-MM-dd")), cm, 20)
		'& " " & Trim(Format(Time, "HH:mm:ss"))
		
        cm = cn.CreateCommand '.let_ActiveConnection(cn)
        cm.CommandType = CommandType.Text
		cm.CommandText = sStmt
		
        'On Error Resume Next
        nRecords = cm.ExecuteNonQuery()
		
		If Err.Number <> 0 Then
            nDbTran.Rollback()
			MsgBox(Err.Description, MsgBoxStyle.Critical, "GML")
			Exit Sub
		End If
		
        'On Error GoTo 0
		
		
		
		'**********************************************************
		'Insert BATCH Details
		'**********************************************************
		
		
		'Getting "Address" y "Account No"
		'getAddress_Account
		
		
		
		
		
		
		'***********************************************************************
		'Get a list of Stores
		'***********************************************************************
		
		
		'sStmt = "SELECT tb1.*, tb3.address, city, state_id, zip FROM " _
		'& " groupStore tb1 LEFT OUTER JOIN store_address tb2 " _
		'& " ON (tb1.store_id = tb2.store_id) " _
		'& " LEFT OUTER JOIN address_catalog tb3 " _
		'& " ON (tb2.address_seq = tb3.address_seq) " _
		'& " WHERE tb1.group_seq = " & cbStoreGroup.ItemData(cbStoreGroup.ListIndex) _
		'& " AND tb1.cust_id = '" & Trim(Me.cbCustId.Text) & "'" _
		'& " AND tb2.cust_id = '" & Trim(Me.cbCustId.Text) & "'"
		
		sStmt = "SELECT tb1.*, tb4.address, tb4.city, tb4.state_id, tb4.zip, tb5.store_billing_contact, tb5.store_number, tb5.store_billing_account " & " FROM  groupStore tb1 INNER JOIN  store tb5 " & " ON tb1.cust_id = tb5.cust_id " & " AND tb1.store_id = tb5.store_id " & " LEFT OUTER JOIN (SELECT tb2.cust_id, tb2.store_id, tb2.store_address_seq," & "                          tb3.Address , tb3.city, tb3.state_id, tb3.zip " & "                  FROM store_address tb2 " & "                  INNER JOIN address_catalog tb3 " & "                  ON tb2.address_seq = tb3.address_seq " & " ) tb4 " & " ON tb1.store_id = tb4.store_id " & " AND tb1.cust_id = tb4.cust_id " & " AND tb5.store_address_seq = tb4.store_address_seq " & " WHERE tb1.cust_id = '" & Trim(Me.cbCustId.Text) & "' " & " AND tb1.group_seq =" & Str(VB6.GetItemData(cbStoreGroup, cbStoreGroup.SelectedIndex))
		
		rsLocal = exec_sql(sStmt)

        For row As Integer = 0 To rsLocal.Rows.Count - 1

            countBatch = countBatch + 1
            Cust_invoice_seq = iCust_invoice_seq()

            'cbCustId.AddItem rsLocal.item("cust_id"), nCounter
            'cbCustName.AddItem rsLocal.item("cust_name"), nCounter


            'Check that locations have a GIR report
            '***********************************************************************
            iStoreId = rsLocal.Rows(row).Item("store_id").value
            sStoreNumber = rsLocal.Rows(row).Item("store_number").value

            'UPGRADE_WARNING: Couldn't resolve default property of object gDump. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gDump = existGIRForStore((cbCustId.Text), VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex), iStoreId)

            nGroupSeq = CShort(gDump.str1)
            nReportId = CInt(gDump.str2)


            If nReportId <= 0 Then
                nDbTran.Rollback()

                MsgBox("Operation was cancelled. " & vbCrLf & "No GIR report was found for a Store in the selected Group in the combination: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Store Group: " & Me.cbStoreGroup.Text & vbCrLf & "  Store No: " & sStoreNumber, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                Exit Sub
            End If

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rsLocal.Rows(row).Item("address").value) Then
                nDbTran.Rollback()

                MsgBox("Operation was cancelled. A Billing Address was not found for Store: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Store Group: " & Me.cbStoreGroup.Text & vbCrLf & "  Store No: " & sStoreNumber, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                Exit Sub
            End If


            If existInvoice((cbCustId.Text), VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex), CShort(nGroupSeq), VB6.GetItemData(cbTemplate, cbTemplate.SelectedIndex)) Then
                nDbTran.Rollback()

                MsgBox("Operation was cancelled. Another invoice was found for Store in the given Period, " & " remove before continuing: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Master Store Group: " & Me.cbStoreGroup.Text & vbCrLf & "  Store Group:" & nGroupSeq & vbCrLf & "  Store No: " & sStoreNumber, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                Exit Sub

            End If


            'UPGRADE_WARNING: Couldn't resolve default property of object Cust_invoice_seq_batch. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sStmt = "INSERT INTO CustomerInvoiceBatchDet (cust_inv_batch_seq, cust_invoice_seq) " & " VALUES (" & Cust_invoice_seq_batch & "," & Cust_invoice_seq & " )"

            exec_sql(sStmt)

            '***************************
            'Computing Amounts
            '***************************
            calculateDisplayAmounts(nReportId, (cbCustId.Text), VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex), 0)


            sStmt = "INSERT INTO CustomerInvoice (cust_invoice_seq, cust_id , invoice_date, invoice_date_desc, " & " Address, period_seq, billing_period, account_no, " & "invoice_no, body_desc, invoice_total, savings, savings_percent, store_flag_fee," & "invoice_fee , tax, grand_total, greeting_desc, fileName, group_seq, template_id) " & " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

            cm = cn.CreateCommand()

            'Contact info

            gDump = getCustNameContact((cbCustId.Text))

            sContact = "Attn:"

            If IsDBNull(rsLocal.Rows(row).Item("store_billing_contact").Value) Then
                If IsDBNull(gDump.str2) Then
                    sContact = sContact & ""
                Else
                    sContact = sContact & gDump.str2
                End If
            Else
                sContact = sContact + rsLocal.Rows(row).Item("store_billing_contact").Value
            End If

            'Account info
            If obCustomer.Checked Then
                'No action required, since yet loaded from Customer
            ElseIf obStore.Checked Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                sAccountNo = IIf(IsDBNull(rsLocal.Rows(row).Item("store_billing_account").Value), "", rsLocal.Rows(row).Item("store_billing_account").Value)

            End If


            sAddress = CStr(Nothing)
            'sAddress = sAddress & IIf(IsNull(rsLocal.item("cust_name")), "", Trim(rsLocal.item("cust_name")) & vbCrLf)
            sAddress = sAddress & gDump.str1 & vbCrLf
            sAddress = sAddress & sContact & vbCrLf

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(row).Item("address").Value), "", Trim(rsLocal.Rows(row).Item("address").Value) & vbCrLf)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(row).Item("city").Value), "", Trim(rsLocal.Rows(row).Item("city").Value) & " ")
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(row).Item("state_id").Value), "", Trim(rsLocal.Rows(row).Item("state_id").Value) & " ")
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(row).Item("zip").Value), "", Trim(rsLocal.Rows(row).Item("zip").Value) & " ") & vbCrLf
            'sAddress = sAddress & IIf(IsNull(rsLocal.item("cust_contact")), "", "Attn: " & Trim(rsLocal.item("cust_contact")) & vbCrLf)

            create_param_rs("cust_invoice_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, Trim(CStr(Cust_invoice_seq)), cm, 6)
            create_param_rs("cust_id", ADODB.DataTypeEnum.adChar, ADODB.ParameterDirectionEnum.adParamInput, Trim(Me.cbCustId.Text), cm, 2)
            create_param_rs("invoice_date", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.dtInvoiceDate.Value, 10), cm, 10)
            create_param_rs("invoice_date_desc", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.txtInvoiceDate.Text, 50), cm, 50)
            create_param_rs("address", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(sAddress, 200), cm, 200)
            create_param_rs("period_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, VB6.GetItemData(Me.cbPeriod, Me.cbPeriod.SelectedIndex), cm, 10)
            create_param_rs("billing_period", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.txBillingPeriod.Text, 50), cm, 50)
            create_param_rs("account_no", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(sAccountNo, 50), cm, 50)
            create_param_rs("invoice_no", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.txtInvoiceNo.Text, 50), cm, 50)
            create_param_rs("body_desc", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, VB.Left(Me.txtDescription.Text, 500), cm, 500)

            create_param_rs("invoice_total", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mInvoiceTotal, cm, 16)
            create_param_rs("savings", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mSavings, cm, 16)
            create_param_rs("savings_percent", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mSavingsPercent, cm, 16)
            create_param_rs("store_flag_fee", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mStoreFlatFee, cm, 16)
            create_param_rs("invoice_fee", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mInvoiceFee, cm, 16)
            create_param_rs("tax", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mTax, cm, 16)
            create_param_rs("grand_total", ADODB.DataTypeEnum.adDouble, ADODB.ParameterDirectionEnum.adParamInput, mGrandTotal, cm, 16)

            create_param_rs("greeting_desc", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, (Me.txtGreeting.Text), cm, 500)
            create_param_rs("fileName", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, "", cm, 200)
            create_param_rs("group_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, nGroupSeq, cm, 6)
            create_param_rs("template_id", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, VB6.GetItemData(cbTemplate, cbTemplate.SelectedIndex), cm, 6)

            cm = cn.CreateCommand '.let_ActiveConnection(cn)
            cm.CommandType = CommandType.Text
            cm.CommandText = sStmt

            nRecords = cm.ExecuteNonQuery()
            'UPGRADE_WARNING: Couldn't resolve default property of object nRecords. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If nRecords > 0 Then
                'ok

                create_document_word(Cust_invoice_seq, sAddress, sAccountNo)

            Else
                nDbTran.Rollback()
                MsgBox("Failed to insert in Transaction table. " & vbCrLf & "Review logfile for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Me.Close()
            End If

            'UPGRADE_WARNING: Couldn't resolve default property of object nCounter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nCounter = nCounter + 1
        Next row
		
		
		If countBatch < 1 Then
            nDbTran.Rollback()

            MsgBox("Operation was cancelled. " & "Missing one or more Store(s) information for selected combination: " & vbCrLf & "  Customer: " & Me.cbCustName.Text & vbCrLf & "  Period: " & cbPeriod.Text & vbCrLf & "  Store Group: " & Me.cbStoreGroup.Text & vbCrLf, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")

            Exit Sub
        End If
        nDbTran.Commit()
		
		MsgBox("Transaction was saved successfully." & vbCrLf & "this process generated " & Str(countBatch) & " documents", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
		
		scbPeriod = cbPeriod.SelectedIndex
		scbCustId = cbCustId.SelectedIndex
		scbCustName = cbCustName.SelectedIndex
		scbStoreGroup = Me.cbStoreGroup.SelectedIndex
		'UPGRADE_WARNING: Couldn't resolve default property of object dtInvoiceDate._Value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sdtInvoiceDate = dtInvoiceDate._Value
		
		
		Me.Close()
		
		'Load frmCustInvGenPreview
		'frmCustInvGenPreview.build_document ' .create_document_word
		'frmCustInvGenPreview.Show vbModal
	End Sub
	
	'Private Function pFreeFile3() As String
	'   Dim sTmpPath As String * 512
	'   Dim sTmpName As String * 576
	'   Dim nRet As Long
	'
	'   sPrefix = "VBT"
	
	'   nRet = GetTempPath(512, sTmpPath)
	'   If (nRet > 0 And nRet < 512) Then
	'      nRet = GetTempFileName(sTmpPath, sPrefix, 0, sTmpName)
	'      If nRet <> 0 Then
	'         pFreeFile = Left$(sTmpName, _
	''            InStr(sTmpName, vbNullChar) - 1)
	'      End If
	'   End If
	'End Function
	
	
	
	Public Sub create_document_word_original(ByRef Cust_invoice_seq As Short)
        Dim rs2 As DataTable
		Dim j As Object
		Dim i As Object
		Dim nPorc As Object
		Dim get_porcent As Object
		Dim wdToggle As Object
		Dim wdUnderlineNone As Object
		Dim wdUnderlineDouble As Object
		Dim wdUnderlineSingle As Object
		Dim wdFormatDocument As Object
		Dim wdAlignTabLeft As Object
		Dim wdTabLeaderSpaces As Object
		Dim wdAlignTabDecimal As Object
		Dim wdAlignParagraphCenter As Object
		Dim wdAlignParagraphJustify As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignParagraphJustify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdAlignParagraphJustify = 3
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignParagraphCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdAlignParagraphCenter = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignTabDecimal. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdAlignTabDecimal = 3
		'UPGRADE_WARNING: Couldn't resolve default property of object wdTabLeaderSpaces. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdTabLeaderSpaces = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignTabLeft. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdAlignTabLeft = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object wdFormatDocument. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdFormatDocument = 0
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineSingle. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdUnderlineSingle = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineDouble. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdUnderlineDouble = 3
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineNone. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdUnderlineNone = 0
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wdToggle. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdToggle = 9999998
		
		oWord = CreateObject("Word.Application")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Visible. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Visible = False
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Documents. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Documents.Add("Normal", False, 0)
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Documents. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Documents.Open(My.Application.Info.DirectoryPath & "\GLM_Watermark_Template.doc")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.name = "Tahoma"
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.size = 14
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignParagraphJustify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.Alignment = wdAlignParagraphJustify
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(Me.txtInvoiceDate.Text)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdToggle. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Bold = wdToggle
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.size = 20
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignParagraphCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.Alignment = wdAlignParagraphCenter
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(Text_Renamed:="INVOICE")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdToggle. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Bold = wdToggle
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.name = "Tahoma"
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.size = 14
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdAlignParagraphJustify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.Alignment = wdAlignParagraphJustify
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        oWord.Selection.TypeText(sAddress) 'IIf(IsNull(oRS.item("address").value), "", oRS.item("address").value) ' frmCustInvGen.txtAddress.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText("For the month of " & Trim(Me.txBillingPeriod.Text))
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        oWord.Selection.TypeText("ACCOUNT NO:" & sAccountNo) 'IIf(IsNull(oRS.item("account_no").value), "", oRS.item("account_no").value) ' Trim(frmCustInvGen.txtAccountNo.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText("INVOICE NO:" & Trim(txtInvoiceNo.Text))
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(txtDescription.Text)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.TabStops(56.69291).Clear()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.TabStops.Add(Position:=56.69291, Alignment:=wdAlignTabLeft, Leader:=wdTabLeaderSpaces)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.ParagraphFormat.TabStops.Add(Position:=269.2914, Alignment:=wdAlignTabDecimal, Leader:=wdTabLeaderSpaces)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Bill Payment: " & vbTab & mInvoiceTotal) 'frmCustInvGen.txtInvoiceTotal.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Savings: " & vbTab & mSavings) 'frmCustInvGen.txtSavings.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object get_porcent. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object nPorc. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        nPorc = -999
        'nPorc = get_porcent
		'UPGRADE_WARNING: Couldn't resolve default property of object nPorc. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "GLM charges at " & nPorc & " %: " & vbTab & mSavingsPercent)
		'Format((frmCustInvGen.txtSavings.Text * nPorc / 100), "#######0.00")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Store Flat Fee: " & vbTab & mStoreFlatFee) 'frmCustInvGen.txtStoreFlatFee.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Invoice Fee: " & vbTab & mInvoiceFee) 'frmCustInvGen.txtInvoiceFee.Text
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Tax: " & vbTab)
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineSingle. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Underline = wdUnderlineSingle
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(VB6.Format(mTax, "0.00")) 'frmCustInvGen.txtTax.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineNone. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Underline = wdUnderlineNone
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(vbTab & "Grand Total: " & vbTab)
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineDouble. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Underline = wdUnderlineDouble
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(VB6.Format(mGrandTotal, "0.00")) 'frmCustInvGen.txtGrandTotal.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object wdUnderlineNone. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.Font.Underline = wdUnderlineNone
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeParagraph()
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Selection. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Selection.TypeText(Me.txtGreeting.Text & vbCrLf)
		
		
		nFile = pFreeFile ' App.Path & "\tmp" & Trim(Cust_invoice_seq) '"C:\archivos\test2.doc"
		
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Visible. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Visible = False
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.ActiveDocument. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.ActiveDocument.SaveAs(FileName:=nFile, FileFormat:=wdFormatDocument, LockComments:=False, Password:="", AddToRecentFiles:=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts:=False, SaveNativePictureFormat:=False, SaveFormsData:=False, SaveAsAOCELetter:=False)
		If Err.Number <> 0 Then
			MsgBox(Err.Description & vbCrLf, MsgBoxStyle.Critical, "")
		Else
			'MsgBox "Document saved...!"
		End If
		On Error GoTo 0
		
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Documents. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Documents.Close(False)
		'UPGRADE_WARNING: Couldn't resolve default property of object oWord.Quit. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oWord.Quit(False)
		For i = 1 To 10000
			For j = 1 To 10000
			Next 
		Next 
		
		
		'OLEInvoice.CreateLink nFile 'oWord.Application.ActiveDocument
		'OLEInvoice.Refresh
		'OLEInvoice.Close
		
		'**** actualizando tabla con reporte...
		stre = New ADODB.Stream
		stre.Open()
		stre.Type = ADODB.StreamTypeEnum.adTypeBinary
		stre.LoadFromFile(nFile)
		stmt = "SELECT * FROM customerInvoice WHERE Cust_invoice_seq = " & Trim(CStr(Cust_invoice_seq))
		'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Open. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rs2 = getDataTable(stmt) '.Open(stmt, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Fields. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object stre.Read. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rs2.Rows(0).Item("filecontent").value = stre.Read
		'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Update. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'rs2.Update()
		'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Close. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

		
	End Sub
	
	Private Sub create_document_word(ByRef Cust_invoice_seq As Short, ByRef sAddress As String, ByRef sAccount As String)
		
		Dim sTemplateFile As String
		Dim flags As gWordDocFlagUDT
		
        Dim wordDoc As gWordDocUDT = New gWordDocUDT()
		wordDoc.sInvoiceDate = Me.txtInvoiceDate.Text
		wordDoc.sAddress = sAddress
		wordDoc.sBillingPeriod = Me.txBillingPeriod.Text
		wordDoc.sAccountNo = sAccount
		wordDoc.sInvoiceNo = Me.txtInvoiceNo.Text
		wordDoc.sDescription = Me.txtDescription.Text
		wordDoc.sInvoiceTotalFormatted = VB6.Format(mInvoiceTotal, "$#,###,##0.00")
		wordDoc.sSavings = CStr(mSavings)
		wordDoc.sSavingsFormatted = VB6.Format(mSavings, "$#,###,##0.00")
		wordDoc.sPercent = get_percent((Me.cbCustId.Text), (Me.sReport_Id))
		wordDoc.sStoreFlatFeeFormatted = VB6.Format(mStoreFlatFee, "$#,###,##0.00")
		wordDoc.sGrandTotalFormatted = VB6.Format(mGrandTotal, "$#,###,##0.00")
		
		'Get Tmp file
		nFile = pFreeFile
		
		'Template file name
		sTemplateFile = get_msword_template((Me.cbTemplate.Text))
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(sTemplateFile) Or sTemplateFile = "" Then
			sTemplateFile = gGlobSettings.sMswordTemplateFile
		End If
		
		'jp.20110103.begin
		'Added flags
		flags.bSavingsPercent = True
		flags.bStoreFlatFee = True
		flags.bInvoiceFee = True
		flags.bTax = True
		flags.bTotal = True
		'jp.20110103.end
		
		'Populate content
		'jp.20110103.begin
		'create_document_word_content oWord, wordDoc, nFile, sTemplateFile
		create_document_word_content(oWord, wordDoc, nFile, sTemplateFile, flags)
		'jp.20110103.end
		
		'Update content
		updateContent(Cust_invoice_seq, nFile)
	End Sub
	'Updates CustomerInvoice content with binary word doc file
	Private Sub updateContent(ByRef Cust_invoice_seq As Short, ByRef sFile As String)
        Dim rs2 As DataTable
		
		'**** actualizando tabla con reporte...
		stre = New ADODB.Stream
		stre.Open()
		stre.Type = ADODB.StreamTypeEnum.adTypeBinary
		'stre.LoadFromFile nFile
		stre.LoadFromFile(sFile)
		stmt = "SELECT * FROM customerInvoice WHERE Cust_invoice_seq = " & Trim(CStr(Cust_invoice_seq))

        rs2 = getDataTable(stmt) '.Open(stmt, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        rs2.Rows(0).Item("filecontent").value = stre.Read

        'rs2.Update()

        'rs2.Close()
		
	End Sub
	
	Private Sub calculateDisplayAmounts(ByRef nReportId As Integer, ByRef sCustId As String, ByRef nPeriodSeq As Integer, ByRef nGroupSeq As Integer)
        Dim rsAmount As New DataTable
		
		mInvoiceTotal = 0
		mSavings = 0
		mSavingsPercent = 0
		mStoreFlatFee = 0
		mInvoiceFee = 0
		mTax = 0
		mGrandTotal = 0
		
		If nReportId <= 0 Then
			sStmt = "SELECT report_id " & " FROM rptCriteriaGlmInvoice " & " WHERE rptCriteriaGlmInvoice.cust_id = '" & Trim(sCustId) & "'" & " AND rep_no = (SELECT rep_no FROM repDef WHERE rep_caption = 'GLM Invoice Report')" & " AND use_for_customer_billing = 'TRUE' " & " AND is_period_seq = 'TRUE' " & " AND period_seq = " & nPeriodSeq & " AND group_seq = " & nGroupSeq
			
            Try
                rsAmount = exec_sql(sStmt)
                If rsAmount.Rows.Count <= 0 Then
                    MsgBox("No GIR report was found for selected combination: " & vbCrLf & "Customer:" & sCustId & vbCrLf & "Period:" & Str(nPeriodSeq), MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("No GIR report was found for selected combination: " & vbCrLf & "Customer:" & sCustId & vbCrLf & "Period:" & Str(nPeriodSeq), MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
                Exit Sub
            End Try
			
            sReport_Id = rsAmount.Rows(0).Item("report_id").value
		Else
			sReport_Id = Str(nReportId)
		End If
		
		'***************************************************
		' Found data
		'***************************************************
		sStmt = "SELECT SUM (invoice_total) bill_payment," & " SUM(savings) savings," & " SUM(savings_percent) savings_percent," & " SUM(savings_flat_fee) store_flat_fee," & " SUM(savings_invoice_fee) invoice_fee" & " FROM rptGlmInvoice " & " WHERE cust_id = '" & Trim(cbCustId.Text) & "'" & " AND report_id = " & sReport_Id
		
		rsAmount = exec_sql(sStmt)
		

        If rsAmount.Rows.Count <= 0 Then
            MsgBox("No GIR report was found for selected combination: " & vbCrLf & "Customer, Period", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            Exit Sub
        End If



        mInvoiceTotal = IIf(IsDBNull(rsAmount.Rows(0).Item("bill_payment").value), "0.00", rsAmount.Rows(0).Item("bill_payment").value)
        mSavings = IIf(IsDBNull(rsAmount.Rows(0).Item("savings").value), "0.00", rsAmount.Rows(0).Item("savings").value)
        mSavingsPercent = IIf(IsDBNull(rsAmount.Rows(0).Item("savings_percent").value), "0.00", rsAmount.Rows(0).Item("savings_percent").value)
        mStoreFlatFee = IIf(IsDBNull(rsAmount.Rows(0).Item("store_flat_fee").value), "0.00", rsAmount.Rows(0).Item("store_flat_fee").value)
        mInvoiceFee = IIf(IsDBNull(rsAmount.Rows(0).Item("invoice_fee").value), "0.00", rsAmount.Rows(0).Item("invoice_fee").value)
        mTax = CDbl("0.00")
        mGrandTotal = CDbl("0.00")


        mInvoiceTotal = IIf(Not IsNumeric(mInvoiceTotal), "0.00", mInvoiceTotal)
        mSavingsPercent = IIf(Not IsNumeric(mSavingsPercent), "0.00", mSavingsPercent)
        mStoreFlatFee = IIf(Not IsNumeric(mStoreFlatFee), "0.00", mStoreFlatFee)
        mInvoiceFee = IIf(Not IsNumeric(mInvoiceFee), "0.00", mInvoiceFee)
        mTax = IIf(Not IsNumeric(mTax), "0.00", mTax)

        mGrandTotal = mInvoiceTotal + mSavingsPercent + IIf(mStoreFlatFee > 0, mStoreFlatFee, 0) + IIf(mInvoiceFee > 0, mInvoiceFee, 0) + mTax

        'UPGRADE_NOTE: Object rsAmount may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsAmount = Nothing
		
	End Sub
	
	Private Sub getAddress_Account()
		
		sStmt = "SELECT cust_name, cust_address, " & " cust_city, state_id, cust_city, " & " state_id, cust_zip, cust_contact, billing_account_no " & " FROM customer " & " WHERE customer.cust_id =  '" & Trim(cbCustId.Text) & "'"
		
		
		
		rsLocal = exec_sql(sStmt)
		
		
        If rsLocal.Rows.Count <= 0 Then
            MsgBox("Unable to access Customer Address information." & vbCrLf & "Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            Exit Sub
        End If



        'En caso de haber datos
        sAddress = CStr(Nothing)
        sAccountNo = CStr(Nothing)

        If rsLocal.Rows.Count > 0 Then
            'sAddress = sAddress & IIf(IsNull(rsLocal.item("cust_name")), "", Trim(rsLocal.item("cust_name")) & vbCrLf)

            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(0).Item("cust_address").Value), "", Trim(rsLocal.Rows(0).Item("cust_address").Value) & vbCrLf)
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(0).Item("cust_city").Value), "", Trim(rsLocal.Rows(0).Item("cust_city").Value) & " ")
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(0).Item("state_id").Value), "", Trim(rsLocal.Rows(0).Item("state_id").Value) & " ")
            sAddress = sAddress & IIf(IsDBNull(rsLocal.Rows(0).Item("cust_zip").Value), "", Trim(rsLocal.Rows(0).Item("cust_zip").Value) & " ") & vbCrLf
            'sAddress = sAddress & IIf(IsNull(rsLocal.item("cust_contact")), "", "Attn: " & Trim(rsLocal.item("cust_contact")) & vbCrLf)

            sAccountNo = IIf(IsDBNull(rsLocal.Rows(0).Item("billing_account_no").Value), "", Trim(rsLocal.Rows(0).Item("billing_account_no").Value) & vbCrLf)
        End If
		
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub
	
	Private Sub dtInvoiceDate_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtInvoiceDate.Change
		txtInvoiceDate.Text = VB6.Format(dtInvoiceDate.value, "MMMM dd, yyyy")
	End Sub
	
	Private Sub frmCustInvBatchEntry_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
		load_comp()
	End Sub
	Private Sub init_vars()
		
        'rsLocal = New SqlDataReader
		'Inicializo parametros de retorno
		Me.dtInvoiceDate.value = Today
		dtInvoiceDate_Change(dtInvoiceDate, New System.EventArgs())
		
		gbStoreSearch.bFlag = False
		gbStoreSearch.sCustId = ""
		gbStoreSearch.sCustName = ""
		gbStoreSearch.sStateId = ""
		
		mInvoiceTotal = 0
		mSavings = 0
		mSavingsPercent = 0
		mStoreFlatFee = 0
		mInvoiceFee = 0
		mTax = 0
		mGrandTotal = 0
		
		
		scbPeriod = -1
		scbCustId = -1
		scbStoreGroup = -1
		scbCustName = -1
		sdtInvoiceDate = Today
		
		obCustomer.Checked = True
		obStore.Checked = False
		
		Me.txtGreeting.Text = "Thank you for your business. Please remit payment upon receipt."
		
	End Sub
	Private Sub load_comp()
		
		load_cb_customer(cbCustName, cbCustId, False)
		
		cbCustName.SelectedIndex = 0
		
		
		load_cb_word_template(cbTemplate)
		If cbTemplate.Items.Count > 0 Then
			cbTemplate.SelectedIndex = 0
		End If
		
		Exit Sub
		
		
		'Dim nCounter As Integer
		'nCounter = 0
		
		
		'sStmt = "SELECT DISTINCT suser_data.cust_id, customer.cust_name " + _
		'"FROM customer, suser_data " + _
		'"WHERE customer.cust_id = suser_data.cust_id " + _
		'"AND suser_data.suser_name='" + Trim(gsUser) + "'"
		
		
		'Set rsLocal = exec_sql(sStmt)
		
		'If rsLocal.State <> adStateOpen Then
		'    MsgBox "Your Account does not have access to such Information." + vbCrLf + _
		'"Contact your System Administrator to get proper access.", _
		'vbOKOnly + vbCritical, "GLM Warning"
		'    Exit Sub
		'Else
		'  If rsLocal.RecordCount <= 0 Then
		'      MsgBox "Your Account does not have access to such Information." + vbCrLf + _
		'"Contact your System Administrator to get proper access.", _
		'vbOKOnly + vbCritical, "GLM Warning"
		'      Exit Sub
		'  End If
		'End If
		
		
		
		'cbCustId.Clear
		'cbCustName.Clear
		'rsLocal.MoveFirst
		'Do While Not rsLocal.EOF
        '    cbCustId.AddItem rsLocal.item("cust_id"), nCounter
        '    cbCustName.AddItem rsLocal.item("cust_name"), nCounter
		'    nCounter = nCounter + 1
		'    rsLocal.MoveNext
		'Loop
		
		'cbCustName.ListIndex = 0
		
	End Sub
	
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		cbCustId.SelectedIndex = cbCustName.SelectedIndex
		
		'UPGRADE_WARNING: Couldn't resolve default property of object load_billing_account(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sAccountNo = load_billing_account((cbCustId.Text))
		
		'Load period
		loadPeriodAndArray(cbPeriod, period_start_date, (cbCustId.Text), False)
		If cbPeriod.Items.Count > 0 Then
			cbPeriod.SelectedIndex = 0
		End If
		
		'Load Store Group
		'load_cb_groups cbStoreGroup, cbCustId.Text, False
		load_cb_groups(cbStoreGroup, (cbCustId.Text), False, True)
		If cbStoreGroup.Items.Count > 0 Then
			cbStoreGroup.SelectedIndex = 0
		End If
		
	End Sub
	
	'Returns the ReportId that contains the GIR report data, zero otherwise
	Private Function existGIRForStore(ByRef sCustId As String, ByRef nPeriodSeq As Short, ByRef nStoreId As String) As gDumpUDT
		
        Dim rsGroups As New DataTable
        Dim rsStores As New DataTable
		Dim sGroupSeq As Short
        'Dim nReportId As Short
		
		existGIRForStore.str1 = "0"
		existGIRForStore.str2 = "0"
		
		
		'Find storeGroup (hopefully one) that includes this only store
		sStmt = "SELECT a.group_name, b.group_seq, COUNT(*)" & " FROM groups a, groupstore b " & " WHERE b.cust_id = '" & sCustId & "' " & " AND a.group_seq = b.group_seq " & " AND b.group_seq IN (SELECT c.group_seq FROM groupstore c " & "       WHERE c.cust_id = b.cust_id " & "       AND c.store_id=  " & nStoreId & ")" & " GROUP BY  a.group_name, b.group_seq " & " HAVING COUNT(*) = 1"
		
		rsGroups = exec_sql(sStmt)
		

        If rsGroups.Rows.Count = 0 Then
            'Not found a GroupStore for this only store
            'existGIRForStore = 0
            Exit Function
        End If
		

        'On each groupStore check which ones were found in GIR report
        For row As Integer = 0 To rsGroups.Rows.Count - 1
            sGroupSeq = CShort(Str(rsGroups.Rows(row).Item("group_seq").Value))

            sStmt = "SELECT report_id " & " From rptCriteriaGlmInvoice " & " WHERE rptCriteriaGlmInvoice.cust_id = '" & sCustId & "'" & " AND rep_no = (SELECT rep_no FROM repDef WHERE rep_caption = 'GLM Invoice Report') " & " AND use_for_customer_billing = 'TRUE' " & " AND is_period_seq = 'TRUE' " & " AND period_seq = " & Str(VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex)) & " AND group_seq = " & Str(sGroupSeq)
            rsStores = exec_sql(sStmt)

            If rsStores.Rows.Count > 0 Then
                existGIRForStore.str1 = CStr(sGroupSeq)
                existGIRForStore.str2 = rsStores.Rows(row).Item("report_id").Value
                Exit Function
            End If


        Next row
        'existGIRForStore.str1 = "0"
		
	End Function
	
    Public Function load_billing_account(ByRef sCustId As String) As Boolean
        load_billing_account = False
        Dim sAccountNoLocal As String

        sStmt = "SELECT cust_name, cust_address, " & " cust_city, state_id, cust_city, " & " state_id, cust_zip, cust_contact, billing_account_no " & " FROM customer " & " WHERE customer.cust_id =  '" & Trim(sCustId) & "'"

        rsLocal = exec_sql(sStmt)

        If rsLocal.Rows.Count <= 0 Then
            write_msg("load_billing_account", "Missing customer data for cust_id:" & sCustId)
            Exit Function
        End If

        sAccountNoLocal = CStr(Nothing)

        If rsLocal.Rows.Count > 0 Then
            'sAccountNoLocal = IIf(IsNull(rsLocal.item("billing_account_no")), "", Trim(rsLocal.item("billing_account_no")) & vbCrLf)
            sAccountNoLocal = IIf(IsDBNull(rsLocal.Rows(0).Item("billing_account_no").Value), "", Trim(rsLocal.Rows(0).Item("billing_account_no").Value))

        End If

        load_billing_account = sAccountNoLocal

    End Function
	
	Private Function getCustNameContact(ByRef sCustId As String) As gDumpUDT
        Dim rsCust As New DataTable
        Dim gDump As gDumpUDT = New gDumpUDT()
		Dim stmt As String
		
		stmt = "SELECT cust_name, cust_contact " & " FROM customer WHERE cust_id = '" & sCustId & "'"
        rsCust = getDataTable(stmt) '.Open(stmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
        If rsCust.Rows.Count > 0 Then
            gDump.str1 = rsCust.Rows(0).Item("cust_name").value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gDump.str2 = IIf(IsDBNull(rsCust.Rows(0).Item("cust_contact").value), "", rsCust.Rows(0).Item("cust_contact").value)
        End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object getCustNameContact. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		getCustNameContact = gDump
		
	End Function
	
	'UPGRADE_WARNING: Event obCustomer.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub obCustomer_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles obCustomer.CheckedChanged
		If eventSender.Checked Then
			obStore.Checked = Not obCustomer.Checked
		End If
	End Sub
End Class