Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Module DBFunctions
	'Retorna la semilla para usar
	Public Function get_seed(ByRef sTabla As String) As Integer
        Try
            cmSeed = cn.CreateCommand
            cmSeed.CommandType = CommandType.StoredProcedure
            cmSeed.CommandText = "usp_seed"
            'Obtengo los parametros del procedure de la base
            'cmSeed.Parameters.Refresh()

            cmSeed.Parameters.Add("@sField", SqlDbType.VarChar, Len(sTabla))
            cmSeed.Parameters("@sField").Value = sTabla
            cmSeed.Parameters.Add("@nSeed", SqlDbType.VarChar, 30)
            cmSeed.Parameters("@nSeed").Direction = ParameterDirection.Output
            cmSeed.ExecuteNonQuery()
            get_seed = cmSeed.Parameters("@nSeed").Value
            Exit Function
        Catch ex As Exception
            get_seed = -1
            save_error("DBfunctions.bas", "get_seed:" & sTabla)
            MsgBox("There was an error getting the document seed", MsgBoxStyle.Information, "Error getting seed")
        End Try
		
	End Function
	'Muestra el error de la base de datos
	Public Function show_db_error() As Boolean

		
        'If cn.Errors.Count > 0 Then
        '	show_db_error = True
        '	e = cn.Errors(0)
        '	Select Case e.NativeError
        '		Case 18456
        '			MsgBox("Wrong User or Password", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Warning")
        '		Case 15247
        '			MsgBox(e.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Warning")

        '		Case Else
        '			'MsgBox e.Description, _
        '			'vbExclamation + vbOKOnly, "Warning"
        '			show_db_error = False
        '	End Select



        'Else
        '	show_db_error = False
        'End If
	End Function
	'Retorna la longitud de un campo de la base de datos
	'Valores de Retorno: 0 si aplicacion no debe consultar base para obtener esta informacion
	'                   <0 si no se obtuvo la longitud del campo solicitado.
	Public Function get_column(ByRef sTabname As String, ByRef sColname As String) As Short
		On Error GoTo ErrorHandler
		
		If gGlobSettings.bFieldsFromDB = False Then
			get_column = 0
		End If
		
        cmSeed = cn.CreateCommand '.let_ActiveConnection(cn)
        cmSeed.CommandType = CommandType.StoredProcedure
		cmSeed.CommandText = "usp_get_column"
		'Obtengo los parametros del procedure de la base

		cmSeed.Parameters("@sTabname").Value = sTabname
        cmSeed.Parameters("@sColname").Value = sColname
        cmSeed.Parameters("@nColLength").Direction = ParameterDirection.Output
        cmSeed.ExecuteNonQuery()
		get_column = cmSeed.Parameters("@nColLength").Value
		Exit Function
		
ErrorHandler: 
		get_column = -1
		save_error("DBFunctions", "get_column")
		
	End Function
	'Retorna el tipo de usuario
	Public Function get_user_type(ByRef sUserName As String) As String
		
		get_user_type = ""
		
		On Error GoTo ErrorHandler
		
		sStmt = "SELECT type_id FROM suser " & " WHERE suser_name='" & Trim(sUserName) & "'"
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(rs.Rows(0).Item("type_id").Value) Then
                get_user_type = rs.Rows(0).Item("type_id").Value
            End If
        End If

        Exit Function

ErrorHandler:
        save_error("DBFunctions.bas", "get_user_type")
		
	End Function
	
	'Retorna TRUE si el usuario tiene acceso a Cliente
	Public Function has_customer_access(ByRef sUserName As String, ByRef sCustId As String) As Boolean
		
		has_customer_access = False
		
		On Error GoTo ErrorHandler
		
		sStmt = "SELECT DISTINCT suser_name FROM suser_data" & " WHERE cust_id ='" & sCustId & "'"
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then
            has_customer_access = True
        End If

        Exit Function

ErrorHandler:
        save_error("DBFunctions.bas", "has_customer_access")
		
	End Function
	'Registra mensaje en tabla Sevent
	Public Sub log_event(ByRef sMsg As String, ByRef nStep As Short, ByRef sProgram As String)
		Dim nRecords As Short
		
		On Error GoTo ErrorHandler
		
        cm = cn.CreateCommand '.let_ActiveConnection(cn)
        cm.CommandType = CommandType.StoredProcedure
		cm.CommandText = "usp_log_event"
		
        cm.Parameters("@sMsg").Value = Trim(sMsg)
		cm.Parameters("@nStep").Value = nStep
		cm.Parameters("@sProgram").Value = sProgram
		
        nRecords = cm.ExecuteNonQuery()
		Exit Sub
		
ErrorHandler: 
		save_error("DBFunctions.bas", "log_event")
		
	End Sub
	
	
	Public Function get_table_sequence(ByRef sTable As Object, ByRef sField As Object) As Short
        sStmt = "SELECT MAX(" + sField + ") FROM " + sTable
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rs.Rows(0).Item(0).Value) Then
                get_table_sequence = 1
            Else
                get_table_sequence = rs.Rows(0).Item(0).Value + 1
            End If
        End If

        Exit Function

ErrorHandler:
        save_error("DBFunctions.bas", "get_table_sequence")
        MsgBox("Unexpected error was found while obtaining next sequence." & "Check log file for details ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Error")
	End Function
	
	
	Public Function get_next_seq(ByRef sTable As String, ByRef sField As String) As Short
		Dim nSeq As Short
		
		nSeq = -1
		
		On Error GoTo ErrorHandler
		
		sStmt = "SELECT MAX(" & sField & ") " & " FROM " & sTable & ""
		
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rs.Rows(0).Item(0)) Then
                nSeq = 1
            Else
                nSeq = rs.Rows(0).Item(0) + 1
            End If
        Else
            nSeq = 1
        End If

        get_next_seq = nSeq
        Exit Function

ErrorHandler:
        save_error("DBFunctions.bas", "get_next_seq")
		
	End Function
	
	Public Sub create_param_rs(ByRef nombreParametro As String, ByRef tipo As ADODB.DataTypeEnum, ByRef destino As ADODB.ParameterDirectionEnum, ByRef valor As Object, ByRef raCmd As ADODB.Command, Optional ByRef tamanio As Integer = 0)
		Dim raPrm As ADODB.Parameter
		
		If raCmd Is Nothing Then
			raCmd = New ADODB.Command
		End If
		
		raPrm = raCmd.CreateParameter(nombreParametro, tipo, destino, tamanio)
		raCmd.Parameters.Append(raPrm)
		'UPGRADE_WARNING: Couldn't resolve default property of object valor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		raPrm.value = valor
	End Sub
	
	Public Sub load_cb_customer(ByRef cbCustName As System.Windows.Forms.ComboBox, ByRef cbCustId As System.Windows.Forms.ComboBox, ByRef bShowAll As Boolean)
		sStmt = "SELECT DISTINCT suser_data.cust_id, customer.cust_name " & "FROM customer, suser_data " & "WHERE customer.cust_id = suser_data.cust_id " & "AND suser_data.suser_name='" & Trim(gsUser) & "'" & " ORDER BY customer.cust_name"
		
		cbCustName.Items.Clear()
		cbCustId.Items.Clear()
		
		If bShowAll Then
			cbCustName.Items.Insert(0, UI_ALL)
			cbCustId.Items.Insert(0, UI_ALL)
		End If
		
		load_cb_query5(cbCustName, sStmt, 1, False)
		load_cb_query5(cbCustId, sStmt, 0, False)
		
		
		
	End Sub
	'Loads cbPeriod with periods and period_start_date array with period dates
	Public Sub loadPeriodAndArray(ByRef cbPeriod As System.Windows.Forms.ComboBox, ByRef period_start_date As Object, ByRef sCustId As String, ByRef bShowAll As Boolean)
		
        Dim rsLocal As DataTable
		Dim nCounter As Short
		
		cbPeriod.Items.Clear()
		
		nCounter = 0
		
		If bShowAll Then
			cbPeriod.Items.Insert(nCounter, UI_ALL)
			nCounter = nCounter + 1
		End If
		
		
		sStmt = "SELECT period_seq, period_name, period_start_date " & " FROM period " & " WHERE cust_id =  '" & Trim(sCustId) & "' AND period_status_id='O' " & " ORDER BY period.period_start_date DESC "
		
		
		'UPGRADE_WARNING: Lower bound of array period_start_date was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		'UPGRADE_ISSUE: As Date was removed from ReDim period_start_date(1 To 1) statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="19AFCB41-AA8E-4E6B-A441-A3E802E5FD64"'
		ReDim period_start_date(1)
		
		rsLocal = exec_sql(sStmt)
		
        If rsLocal.Rows.Count < 0 Then
            write_msg("loadPeriodAndArray", "Could not find Period for customer:" & sCustId)
            Exit Sub
        Else
            If rsLocal.Rows.Count <= 0 Then
                write_msg("loadPeriodAndArray", "Could not find Period for customer:" & sCustId)
                Exit Sub
            End If
        End If
		
		'In data was found
		
		'nCounter = 1
		
        For row As Integer = 0 To rsLocal.Rows.Count - 1

            If bShowAll Then


                ReDim Preserve period_start_date(nCounter)
                cbPeriod.Items.Insert(nCounter, New VB6.ListBoxItem(Trim(rsLocal.Rows(row).Item("period_name").value), rsLocal.Rows(row).Item("period_seq").value))
                'period_start_date(nCounter + 1) = rsLocal.Fields("period_start_date").value
                'UPGRADE_WARNING: Couldn't resolve default property of object period_start_date(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                period_start_date(nCounter) = rsLocal.Rows(row).Item("period_start_date").value
            Else
                'UPGRADE_WARNING: Lower bound of array period_start_date was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
                'UPGRADE_ISSUE: As Date was removed from ReDim period_start_date(1 To nCounter + 1) statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="19AFCB41-AA8E-4E6B-A441-A3E802E5FD64"'
                ReDim Preserve period_start_date(nCounter + 1)
                cbPeriod.Items.Insert(nCounter, New VB6.ListBoxItem(Trim(rsLocal.Rows(row).Item("period_name").value), rsLocal.Rows(row).Item("period_seq").value))
                'UPGRADE_WARNING: Couldn't resolve default property of object period_start_date(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                period_start_date(nCounter + 1) = rsLocal.Rows(row).Item("period_start_date").value

            End If

            nCounter = nCounter + 1
        Next row

		
		
		
	End Sub
	
	Public Sub load_cb_groups(ByRef cbStoreGroup As System.Windows.Forms.ComboBox, ByRef sCustId As String, ByRef bShowAll As Boolean, ByRef bClear As Boolean)
		
		
		sStmt = "SELECT group_name, group_seq FROM groups " & " WHERE cust_id =  '" & Trim(sCustId) & "' " & " ORDER BY group_name "
		
		If bClear Then
			cbStoreGroup.Items.Clear()
		End If
		
		If bShowAll Then
			'cbStoreGroup.AddItem UI_ALL, 0
			cbStoreGroup.Items.Insert(cbStoreGroup.Items.Count, UI_ALL)
			
		End If
		
		load_cb_query2(cbStoreGroup, sStmt, 2, False)
		
		
		'Set rsLocal = exec_sql(sStmt)
		
		'If rsLocal.State <> adStateOpen Then
		'    MsgBox "Your Account does not have access to such Information." + vbCrLf + _
		'"Contact your System Administrator to get proper access.", _
		'vbOKOnly + vbCritical, "GLM Warning"
		'    Exit Sub
		'Else
        '  If rsLocal.Rows.Count <= 0 Then
		'      MsgBox "Your Account does not have access to such Information." + vbCrLf + _
		''            "Contact your System Administrator to get proper access.", _
		''            vbOKOnly + vbCritical, "GLM Warning"
		'      Exit Sub
		'  End If
		'End If
		
		
		'nCounter = 0
		'rsLocal.MoveFirst
		'Do While Not rsLocal.EOF
		'    cbStoreGroup.AddItem Trim(rsLocal.Fields("group_name").value), nCounter
		'    cbStoreGroup.ItemData(cbStoreGroup.NewIndex) = rsLocal.Fields("group_seq").value
		'    nCounter = nCounter + 1
		'    rsLocal.MoveNext
		'Loop
		
		
	End Sub
	
	Public Sub load_cb_word_template(ByRef cbTemplate As System.Windows.Forms.ComboBox)
		
		sStmt = "SELECT template_name, template_id FROM CustomerInvoiceTemplate " & "ORDER BY template_name "
		
		load_cb_query2(cbTemplate, sStmt, 2, 1)
		
		
	End Sub
	
	Public Function insertAddressCatalog(ByRef sCustId As String, ByRef nStoreId As Short, ByRef sAddress As String, ByRef sCity As String, ByRef sStateId As String, ByRef sZip As String) As Short
		
		Dim nRecords As Short
        Dim nDbTran As sqltransaction
        Dim cmLocal As sqlcommand
		Dim nAddressSeq As Short
		Dim nStoreAddressSeq As Short
		
		insertAddressCatalog = 0
		
		nAddressSeq = get_table_sequence("address_catalog", "address_seq")
		
		nStoreAddressSeq = get_table_sequence("store_address", "store_address_seq")
		
		sStmt = "INSERT INTO address_catalog (address_seq, context_table, address, " & "   city, state_id, zip) " & " VALUES (?, ?, ?, ?, ?, ?) "
		
        nDbTran = cn.BeginTransaction '.BeginTransaction()
		
        cmLocal = cn.CreateCommand
		
		create_param_rs("address_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, nAddressSeq, cmLocal, 4)
		create_param_rs("context_table", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, ADDRESS_CATALOG_CONTEXT_STORE, cmLocal, 100)
		create_param_rs("address", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, quotation_mask(Trim(sAddress)), cmLocal, 80)
		create_param_rs("city", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, quotation_mask(Trim(sCity)), cmLocal, 40)
		create_param_rs("state_id", ADODB.DataTypeEnum.adChar, ADODB.ParameterDirectionEnum.adParamInput, sStateId, cmLocal, 2)
		create_param_rs("zip", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, sZip, cmLocal, 20)
		
		
		

        cmLocal.CommandType = CommandType.Text
		cmLocal.CommandText = sStmt
		
        nRecords = cmLocal.ExecuteNonQuery()
		If nRecords > 0 Then
			
			sStmt = "INSERT INTO store_address(store_address_seq, cust_id, " & "store_id, address_seq) VALUES (?, ?, ?, ? )"
			
			'UPGRADE_NOTE: Object cmLocal may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'

			create_param_rs("store_address_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, nStoreAddressSeq, cmLocal, 4)
			create_param_rs("cust_id", ADODB.DataTypeEnum.adChar, ADODB.ParameterDirectionEnum.adParamInput, sCustId, cmLocal, 2)
			'jp.begin.2010.02.16 - Address maintenance
			create_param_rs("store_id", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, nStoreId, cmLocal, 4)
			'create_param_rs "store_id", adInteger, adParamInput, gStoreAddressRecord.nStoreId, cmLocal, 4
			'jp.end.2010.02.16
			create_param_rs("address_seq", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, nAddressSeq, cmLocal, 4)
			
			
            cmLocal.CommandType = CommandType.Text
			cmLocal.CommandText = sStmt
            nRecords = cmLocal.ExecuteNonQuery()
			
			If nRecords > 0 Then

				
                nDbTran.Commit()
				insertAddressCatalog = nStoreAddressSeq
				
				Exit Function
			Else


                nDbTran.Rollback()

                Exit Function
            End If

        Else
            nDbTran.Rollback()

            Exit Function
        End If
			
			

	End Function
	
    Public Function getPeriodDatesStr(ByRef sCustId As String, ByRef nPeriodSeq As Short) As gDumpUDT
        getPeriodDatesStr = New gDumpUDT
        On Error GoTo ErrorHandler

        sStmt = "SELECT period_start_date, period_end_date " & " FROM period " & " WHERE cust_id ='" & Trim(sCustId) & "'" & " AND period_seq =" & Str(nPeriodSeq)

        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object rsLocal.Fields. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gDump.str1 = rs.Rows(0).Item("period_start_date")
            'UPGRADE_WARNING: Couldn't resolve default property of object rsLocal.Fields. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gDump.str2 = rs.Rows(0).Item("period_end_date")
        End If

        Exit Function

ErrorHandler:
        save_error("DbFunctions", "getPeriodDates")
        MsgBox("An error occurred while loading  Period Info. Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")

    End Function
	
	Public Function getPeriodStartEndDate(ByRef sCustId As String, ByRef nPeriodSeq As Short, ByRef sStartEnd As String) As String
        Dim sPeriodDate As String = ""
		
		On Error GoTo ErrorHandler
		sStmt = "SELECT period_start_date, period_end_date " & " FROM period " & " WHERE cust_id ='" & Trim(sCustId) & "'" & " AND period_seq =" & Str(nPeriodSeq)
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Rows.Count > 0 Then
            If sStartEnd = "START" Then
                sPeriodDate = rs.Rows(0).Item("period_start_date").Value
            Else
                sPeriodDate = rs.Rows(0).Item("period_end_date").Value
            End If
        End If


        getPeriodStartEndDate = sPeriodDate
        Exit Function

ErrorHandler:
        save_error("DBFunctions", "getPeriodDate")
        MsgBox("An error occurred while loading  Period Info. Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
		
	End Function
	
	'Returns a list of period sequences like this: 21,34,12
	
	Public Function getPeriodSeqList(ByRef sCustId As String, ByRef nPeriodStart As Short, ByRef nPeriodEnd As Short) As String
		
		Dim sPeriodList As String
		
		sPeriodList = ""
		
		On Error GoTo ErrorHandler
		sStmt = "SELECT a.period_seq, a.period_start_date, a.period_end_date " & " FROM period a, period b, period c WHERE a.cust_id = '" & sCustId & "' " & " AND a.period_start_date > b.period_start_date AND b.period_seq =" & Str(nPeriodStart) & " AND a.period_end_date < c.period_end_date AND c.period_seq = " & Str(nPeriodEnd) & " ORDER BY a.period_start_date"
		
        rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        For row As Integer = 0 To rs.Rows.Count - 1
            sPeriodList = sPeriodList & Str(rs.Rows(row).Item("period_seq").value) & ","
            sPeriodList = Trim(sPeriodList)
        Next row

        'Remove last comma
        If Len(sPeriodList) > 1 Then
            sPeriodList = Left(sPeriodList, Len(sPeriodList) - 1)
        End If

        getPeriodSeqList = sPeriodList
        Exit Function

ErrorHandler:
        save_error("DBFunctions", "getPeriodSeqList")
        MsgBox("An error occurred while Computing  Period Info. Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
		
	End Function
End Module