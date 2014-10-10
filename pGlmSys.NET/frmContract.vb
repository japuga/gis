Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmContract
	Inherits System.Windows.Forms.Form
    Public ImageList2 As New ImageList()
    Private rsLocal As SqlDataReader
    Private rsLocalDet As SqlDataReader
    Private rsStore As SqlDataReader
    Private rsEquipment As SqlDataReader
    Private rsContract As SqlDataReader
    Private cmLocal As SqlCommand

	
	'UPGRADE_WARNING: Event cbCustId.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustId_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustId.SelectedIndexChanged
		If cbCustId.SelectedIndex >= 0 Then
			load_state(cbCustId.Text)
		End If
	End Sub
	'Refresca combo de State
	Private Sub load_state(ByRef sCustId As String)
		
		cbStateId.Items.Clear()
		
		sStmt = "SELECT state_id FROM state " & " WHERE state_id IN (SELECT state_id FROM suser_data " & " WHERE suser_data.cust_id ='" & Trim(sCustId) & "' " & " AND suser_data.suser_name='" & Trim(gsUser) & "') "
		cbStateId.Items.Insert(0, "<All>")
		load_cb_query2(cbStateId, sStmt, 1, False)
		cbStateId.SelectedIndex = 0
		
	End Sub
	Private Sub cmdSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSearch.Click
		get_dg_defaults(False)
	End Sub
	
	Private Sub cmdVendorSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdVendorSearch.Click
		
		gVendorSearch.bFlag = False
		VB6.ShowForm(frmVendorBrowse, VB6.FormShowConstants.Modal, Me)
		If gVendorSearch.bFlag Then
			txtVendName.Text = gVendorSearch.sVendName
			txtVendName.Tag = gVendorSearch.nVendSeq
		Else
			txtVendName.Text = "<All>"
			txtVendName.Tag = 0
		End If
	End Sub
	
	Private Sub dgContract_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgContract.DblClick
		data_entry((General.modo.UpdateRecord))
	End Sub
	'Calls frmContractEntry to insert or update contracts
	Private Sub data_entry(ByRef bFlag As General.modo)
		'Verify that user has selected store and equipment
		Select Case bFlag
			Case General.modo.NewRecord
				If dgStore.Row >= 0 Then
					'Se escogio una tienda. OK
					If dgEquipment.Row >= 0 Then
						'OK Equipment
					Else
						MsgBox("Please choose an Equipment before Entering Contract Info.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
						Exit Sub
					End If
				Else
					MsgBox("Please choose an Store before entering Contract Info.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
					Exit Sub
				End If
			Case General.modo.UpdateRecord
				If dgStore.Row >= 0 Then
					'OK Store
					If dgEquipment.Row >= 0 Then
						'OK Equipment
						If dgContract.Row >= 0 Then
							'OK Contract
						Else
							MsgBox("Please choose a Contract to Update.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
							Exit Sub
						End If
					Else
						MsgBox("Please choose an Equipment before Entering Contract Info.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
						Exit Sub
					End If
					
				Else
					MsgBox("Please choose an Store before entering Contract Info.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
					Exit Sub
				End If
				
			Case Else
				Exit Sub
		End Select
		
		gContractRecord.bFlag = bFlag
		set_contract_data(bFlag)
		VB6.ShowForm(frmContractEntry, VB6.FormShowConstants.Modal, Me)
		If gContractRecord.bFlag = General.modo.SavedRecord Then
			'Se refresca datagrid para el mismo vendor de txtVendName
            get_dgContractData(False, gContractRecord.sCustId, gContractRecord.nStoreId, CShort(txtVendName.Tag), gContractRecord.nEqptSeq)
		End If
		
	End Sub
	
	'Loads data in global variable gContractRecord
	Private Sub set_contract_data(ByRef bFlag As General.modo)
		
		On Error GoTo ErrorHandler
		
        gContractRecord.sCustId = rsStore.Item("cust_id").Value
        gContractRecord.nStoreId = rsStore.Item("store_id").Value
        gContractRecord.sStoreNumber = rsStore.Item("Store").Value
        gContractRecord.nEqptSeq = rsEquipment.Item("eqpt_seq").Value
		gContractRecord.nServId = -1
		
		If bFlag = General.modo.UpdateRecord Then
            gContractRecord.nVendSeq = rsContract.Item("vend_seq").Value
            'gContractRecord.nEqptSeq = rsContract.item("eqpt_seq")
            gContractRecord.nServId = rsContract.Item("serv_id").Value
			
            gContractRecord.nFreqId = rsContract.Item("freq_id").Value
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqComments = IIf(IsDBNull(rsContract.Item("freq_comments").Value), "", rsContract.Item("freq_comments").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sContractComments = IIf(IsDBNull(rsContract.Item("contract_comments").Value), "", rsContract.Item("contract_comments").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqTimes = IIf(IsDBNull(rsContract.Item("freq_times").Value), "", rsContract.Item("freq_times").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqPeriod = IIf(IsDBNull(rsContract.Item("freq_period").Value), "", rsContract.Item("freq_period").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.nGlmRate = IIf(IsDBNull(rsContract.Item("GLM Rate").Value), 0, rsContract.Item("GLM Rate").Value)
			
            gContractRecord.nOldRate = rsContract.Item("Prev Rate").Value
            gContractRecord.nCurrRate = rsContract.Item("Rate").Value
            gContractRecord.sOpeningDate = rsContract.Item("Started").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sExpirationDate = IIf(IsDBNull(rsContract.Item("Until").Value), "", rsContract.Item("Until").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay1 = IIf(IsDBNull(rsContract.Item("freq_day1").Value), "", rsContract.Item("freq_day1").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay2 = IIf(IsDBNull(rsContract.Item("freq_day2").Value), "", rsContract.Item("freq_day2").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay3 = IIf(IsDBNull(rsContract.Item("freq_day3").Value), "", rsContract.Item("freq_day3").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay4 = IIf(IsDBNull(rsContract.Item("freq_day4").Value), "", rsContract.Item("freq_day4").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay5 = IIf(IsDBNull(rsContract.Item("freq_day5").Value), "", rsContract.Item("freq_day5").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay6 = IIf(IsDBNull(rsContract.Item("freq_day6").Value), "", rsContract.Item("freq_day6").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sFreqDay7 = IIf(IsDBNull(rsContract.Item("freq_day7").Value), "", rsContract.Item("freq_day7").Value)
			
            gContractRecord.sVendor = rsContract.Item("Vendor").Value
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sRateStatus = IIf(IsDBNull(rsContract.Item("rate_status").Value), "", rsContract.Item("rate_status").Value)
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            gContractRecord.sOverrideExpFlag = IIf(IsDBNull(rsContract.Item("override_exp_flag").Value), "", rsContract.Item("override_exp_flag").Value)
		End If
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "set_contract_data")
		MsgBox("An unexpected has occurred, please check log file for details.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Glm Error")
		
	End Sub
	Private Sub dgEquipment_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgEquipment.ClickEvent
		'jp BEG 01.29.03
		'If dgEquipment.Row >= 0 Then
		'dgEquipment.SelBookmarks.Add rsEquipment.Bookmark
		If dgEquipment.SelBookmarks.Count > 0 Then
            set_dgContractData()
		End If
	End Sub
	
	Private Sub dgStore_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgStore.ClickEvent
		'01/29/03
		'If dgStore.Row >= 0 Then
		'dgStore.SelBookmarks.Add rsStore.Bookmark
		If dgStore.SelBookmarks.Count > 0 Then
            'Busco los equipos para esta tienda
            'no se como implementar el bookmark.
            get_dgEquipmentData(False, rsStore.Item("store_id").Value)
            If dgEquipment.Row >= 0 Then
                'rsEquipment.Bookmark()
                'dgEquipment.SelBookmarks.Add()
                set_dgContractData()
            Else
                get_dgContractData(True)
            End If
			
		End If
	End Sub
	'Carga el datagrid Contract
    Private Sub get_dgContractData(ByRef bInit As Boolean, Optional ByRef sCustId As String = "", Optional ByRef nStoreId As Short = 0, Optional ByRef nVendSeq As Short = 0, Optional ByRef nEqptSeq As Short = 0)

        On Error GoTo ErrorHandler
        Dim cmd As SqlCommand = cn.CreateCommand()
        sStmt = "SELECT " & " RTRIM(VBranch.vend_name)+ ' - ' +RTRIM (VBranch.vend_area)  AS Vendor, " & " StoreEqpt.eqpt_desc AS Equipment, " & " Content.content_desc AS Content , " & " Service.serv_desc AS Service, " & " dbo.format_freq2 (Frequency.freq_sched_flag, " & " Frequency.freq_times_flag, " & " VContract.freq_times, " & " ISNULL(VContract.freq_period,''), " & " ISNULL(VContract.freq_day1,''), " & " ISNULL(VContract.freq_day2,''), " & " ISNULL(VContract.freq_day3,''), " & " ISNULL(VContract.freq_day4,''), " & " ISNULL(VContract.freq_day5,''), " & " ISNULL(VContract.freq_day6,''), " & " ISNULL(VContract.freq_day7,'')) " & " AS Frequency," & " VContract.glm_rate AS 'GLM Rate', " & " VContract.curr_rate AS Rate, " & " VContract.old_rate AS 'Prev Rate', " & " VContract.opening_date AS Started, " & " VContract.expiration_date AS Until, "
        sStmt = sStmt & " VContract.cust_id, VContract.store_id, " & " VContract.vend_seq, VContract.eqpt_seq , " & " VContract.serv_id , VContract.freq_times, " & " VContract.freq_period, VContract.freq_day1, " & " VContract.freq_day2, VContract.freq_day3, " & " VContract.freq_day4, VContract.freq_day5, " & " VContract.freq_day6, VContract.freq_day7, " & " VContract.freq_id, VContract.freq_comments, " & " VContract.contract_comments, VContract.rate_status,  " & " VContract.override_exp_flag "
        sStmt = sStmt & " FROM StoreEqpt, VContract, Content, Service, VBranch, Frequency " & " WHERE vContract.cust_id = StoreEqpt.cust_id " & " AND VContract.store_id = StoreEqpt.store_id " & " AND VContract.eqpt_seq = StoreEqpt.eqpt_seq " & " AND StoreEqpt.content_id = Content.content_id " & " AND VContract.serv_id = Service.serv_id " & " AND VContract.vend_seq = VBranch.vend_seq " & " AND VContract.cust_id = '" & Trim(sCustId) & "' " & " AND VContract.store_id = " & Str(nStoreId) & " " & " AND VContract.freq_id = Frequency.freq_id "

        'Solo se incluye si usuario selecciono un Vendor
        If nVendSeq > 0 Then
            sStmt = sStmt & " AND VContract.vend_seq = " & Str(nVendSeq)
        End If

        'Se agrega si ha seleccionado un equipo.
        If nEqptSeq > 0 Then
            sStmt = sStmt & " AND VContract.eqpt_seq = " & Str(nEqptSeq)
        End If

        'MsgBox sStmt

        If bInit Then
            sStmt = sStmt & " AND VContract.eqpt_seq = -1"
        End If



        'UPGRADE_NOTE: Object dgContract.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        dgContract.DataSource = Nothing

        cmd.CommandText = sStmt
        rsContract = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsContract.HasRows() Then
            dgContract.DataSource = rsContract

        End If

        'Formato
        dgContract.Columns("cust_id").Visible = False
        dgContract.Columns("store_id").Visible = False
        dgContract.Columns("vend_seq").Visible = False
        dgContract.Columns("eqpt_seq").Visible = False
        dgContract.Columns("serv_id").Visible = False
        dgContract.Columns("freq_times").Visible = False
        dgContract.Columns("freq_period").Visible = False
        dgContract.Columns("freq_day1").Visible = False
        dgContract.Columns("freq_day2").Visible = False
        dgContract.Columns("freq_day3").Visible = False
        dgContract.Columns("freq_day4").Visible = False
        dgContract.Columns("freq_day5").Visible = False
        dgContract.Columns("freq_day6").Visible = False
        dgContract.Columns("freq_day7").Visible = False
        dgContract.Columns("freq_id").Visible = False
        dgContract.Columns("freq_comments").Visible = False
        dgContract.Columns("contract_comments").Visible = False
        dgContract.Columns("rate_status").Visible = False
        dgContract.Columns("override_exp_flag").Visible = False

        dgContract.Columns("Vendor").Width = VB6.TwipsToPixelsX(2000)
        dgContract.Columns("Equipment").Width = VB6.TwipsToPixelsX(1000)
        dgContract.Columns("Content").Width = VB6.TwipsToPixelsX(800)
        dgContract.Columns("Service").Width = VB6.TwipsToPixelsX(1300)
        dgContract.Columns("GLM Rate").Width = VB6.TwipsToPixelsX(850)
        dgContract.Columns("Rate").Width = VB6.TwipsToPixelsX(850)
        dgContract.Columns("Prev Rate").Width = VB6.TwipsToPixelsX(850)
        dgContract.Columns("Started").Width = VB6.TwipsToPixelsX(1000)
        dgContract.Columns("Until").Width = VB6.TwipsToPixelsX(1000)

        'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgContract.Refresh()
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "get_dgContract")
        MsgBox("An error occurred while accessing contract table," & "check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, " GLM Error")
    End Sub
	Private Sub frmContract_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        Dim nCounter As Integer = 0
        Dim cmd As SqlCommand = cn.CreateCommand()
        Dim dt As DataTable
		'Combo CustId
		sStmt = "SELECT DISTINCT suser_data.cust_id, customer.cust_name " & "FROM customer, suser_data " & "WHERE customer.cust_id = suser_data.cust_id " & "AND suser_data.suser_name='" & Trim(gsUser) & "' ORDER BY suser_data.cust_id "
        cmd.CommandText = sStmt
		
        dt = exec_sql(sStmt)
		
        If Not dt.Rows.Count > 0 Then
            MsgBox("Your Account does not have access to such Information." & vbCrLf & "Contact your System Administrator to get proper access.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            Exit Sub
        End If
		
		
		'En caso de haber datos
		cbCustId.Items.Clear()

        While rsLocal.Read()
            cbCustId.Items.Insert(nCounter, rsLocal.Item("cust_id").Value)
            'UPGRADE_WARNING: Couldn't resolve default property of object nCounter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nCounter = nCounter + 1
        End While
		
		cbCustId.SelectedIndex = 0
		
		'Vendor
		txtVendName.Text = "<All>"
		txtVendName.Tag = 0 'VendSeq por defecto
		
		'Cargo Datagrids
		'get_dg_defaults True
        get_dgStoreData(True)
        get_dgEquipmentData(True)
        get_dgContractData(True)
		
	End Sub
	
	Private Sub get_dg_defaults(ByRef bInit As Boolean)
		
        get_dgStoreData(bInit)
        If dgStore.Row >= 0 Then
            'no se como implementar el bookmark
            'dgStore.SelBookmarks.Add(rsStore.Bookmark)
            get_dgEquipmentData(False, rsStore.Item("store_id").Value)
            If dgEquipment.Row >= 0 Then
                'dgEquipment.SelBookmarks.Add(rsEquipment.Bookmark)
                set_dgContractData()
            Else
                get_dgContractData(True)
            End If

        Else
            get_dgEquipmentData(True)
            get_dgContractData(True)
        End If
		
	End Sub
	'Busca y carga dgStore
    Private Sub get_dgStoreData(ByRef bInit As Boolean)
        Dim cmd As SqlCommand = cn.CreateCommand()
        On Error GoTo ErrorHandler

        sStmt = "SELECT store_number AS Store, " & " state_id as State, " & " store_address AS Address, " & " store_city AS City, " & " cust_id, store_id " & " FROM store " & " WHERE cust_id = '" & cbCustId.Text & "' "

        If bInit Then
            sStmt = sStmt & " AND store_id =-1"
        End If


        If Trim(cbStateId.Text) = "<All>" Then
            '1.8.8 Condicion para permitit usuario acceso exclusivo a
            ' estados permitidos
            sStmt = sStmt & " AND state_id IN (SELECT state_id FROM suser_data " & " WHERE suser_data.cust_id ='" & Trim(cbCustId.Text) & "' " & " AND suser_data.suser_name='" & Trim(gsUser) & "') "
        Else
            sStmt = sStmt & " AND state_id = '" & cbStateId.Text & "' "
        End If

        sStmt = sStmt & " ORDER BY store_number"
        'MsgBox sStmt
        cmd.CommandText = sStmt
        rsStore = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsStore.HasRows() Then
            dgStore.DataSource = rsStore
        End If

        'Formato de dgStore
        dgStore.Columns("cust_id").Visible = False
        dgStore.Columns("store_id").Visible = False

        dgStore.Columns("Store").Width = VB6.TwipsToPixelsX(1300)
        dgStore.Columns("State").Width = VB6.TwipsToPixelsX(500)
        dgStore.Columns("Address").Width = VB6.TwipsToPixelsX(1700)
        dgStore.Columns("City").Width = VB6.TwipsToPixelsX(800)



        Exit Sub

ErrorHandler:
        save_error(Me.Name, "get_store")
        Resume Next
    End Sub
    Private Sub set_dgEquipmentData()
        get_dgEquipmentData(False, rsStore.Item("store_id").Value)
        If dgEquipment.Row >= 0 Then
            'dgEquipment.SelBookmarks.Add(rsEquipment.Bookmark)
            set_dgContractData()
        End If
    End Sub
    Private Sub set_dgContractData()
        Dim nVendSeq As Short

        If CDbl(txtVendName.Tag) > 0 Then
            nVendSeq = CShort(txtVendName.Tag)
        Else
            nVendSeq = 0
        End If

        get_dgContractData(False, rsEquipment.Item("cust_id").Value, rsEquipment.Item("store_id").Value, nVendSeq, rsEquipment.Item("eqpt_seq").Value)
        'no se como implementar el bookmark
        If dgContract.Row >= 0 Then
            'dgContract.SelBookmarks.Add(rsContract.Bookmark)
        End If
    End Sub
	'Obtiene datos para datagrid dbEquipment
    Private Sub get_dgEquipmentData(ByRef bInit As Boolean, Optional ByRef nStoreId As Short = 0)

        Dim cmd As SqlCommand = cn.CreateCommand()
        Dim nVendSeq As Short

        On Error GoTo ErrorHandler

        'If IsNull(rsStore.item("store_id")) Then
        '    Exit Sub
        'End If


        'If gVendorSearch.bFlag Then
        '    nVendSeq = gVendorSearch.nVendSeq
        'Else
        '    nVendSeq = 0
        'End If

        nVendSeq = CShort(txtVendName.Tag)


        sStmt = ""
        sStmt = "SELECT StoreEqpt.eqpt_desc AS Eqpt, " & " Content.content_desc AS Content , " & " StoreEqpt.load_id AS Loading, " & " StoreEqpt.eqpt_status AS Status, " & " RTRIM(VBranch.vend_name) + ' - ' +RTRIM(VBranch.vend_area) AS Vendor, " & " StoreEqpt.cust_id, StoreEqpt.store_id, " & " StoreEqpt.eqpt_seq, " & " VAccountEqpt.vend_seq " & " FROM StoreEqpt, VAccountEqpt, VBranch, Content " & " WHERE StoreEqpt.cust_id = VAccountEqpt.cust_id " & " AND StoreEqpt.store_id = VAccountEqpt.store_id  " & " AND StoreEqpt.eqpt_seq = VAccountEqpt.eqpt_seq " & " AND VAccountEqpt.vend_seq = VBranch.vend_seq " & " AND StoreEqpt.content_id = Content.content_id " & " AND StoreEqpt.cust_id = '" & cbCustId.Text & "' " & " AND StoreEqpt.store_id = " & Str(nStoreId) & " AND StoreEqpt.eqpt_status = 'A' " & " AND VAccountEqpt.account_status = 'A' "

        sStmt = "SELECT StoreEqpt.eqpt_desc AS Eqpt, " & " Content.content_desc AS Content , " & " StoreEqpt.load_id AS Loading, " & " StoreEqpt.eqpt_status AS Status, " & " StoreEqpt.cust_id, StoreEqpt.store_id, " & " StoreEqpt.eqpt_seq " & " FROM StoreEqpt, Content " & " WHERE StoreEqpt.content_id = Content.content_id " & " AND StoreEqpt.cust_id = '" & cbCustId.Text & "' " & " AND StoreEqpt.store_id = " & Str(nStoreId) & " AND StoreEqpt.eqpt_status = 'A' "


        'If nVendSeq > 0 Then  'nVendSeq=0   -> <ALL> Vendors
        '    sStmt = sStmt + " AND VAccountEqpt.vend_seq = " + Str(nVendSeq)
        'End If

        'Inicializacion
        If bInit Then
            sStmt = sStmt & " AND StoreEqpt.eqpt_seq = -1"
        End If

        sStmt = sStmt & " ORDER BY Eqpt "
        'MsgBox sStmt
        'UPGRADE_NOTE: Object dgEquipment.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        dgEquipment.DataSource = Nothing

        cmd.CommandText = sStmt
        rsEquipment = cmd.ExecuteReader '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsEquipment.HasRows() Then
            dgEquipment.DataSource = rsEquipment

        End If


        'Formato
        dgEquipment.Columns("cust_id").Visible = False
        dgEquipment.Columns("store_id").Visible = False
        dgEquipment.Columns("eqpt_seq").Visible = False

        'Columnas
        dgEquipment.Columns("eqpt").Width = VB6.TwipsToPixelsX(1100)
        dgEquipment.Columns("Content").Width = VB6.TwipsToPixelsX(800)

        'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgEquipment.Refresh()
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "get_dgEquipmentData")
        MsgBox("Unexpected Error when loading equipment info." & vbCrLf & " Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")

    End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "new"
                data_entry((General.modo.NewRecord))
            Case "save"
                data_entry((General.modo.UpdateRecord))
            Case "search"
                get_dg_defaults(False)
            Case "delete"
                delete_contract()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	Private Sub delete_contract()
		Dim sInvoiceNo As String
		Dim sAccountNo As String
		Dim sInvoiceStatus As String
        Dim nRecords As Short
        Dim cmd As SqlCommand = cn.CreateCommand()
		
		If dgStore.Row >= 0 Then
			'Se escogio una tienda. OK
			If dgEquipment.Row >= 0 Then
				'OK Equipment
				If dgContract.Row >= 0 Then
					'OK. Escogio contrato
				Else
					MsgBox("Please select a Contract to Delete.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
					Exit Sub
				End If
			Else
				MsgBox("Please choose an Equipment.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
				Exit Sub
			End If
		Else
			MsgBox("Please choose an Store.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
			Exit Sub
		End If
		
		
		If (MsgBox("Do you want to delete the selected contract?", MsgBoxStyle.YesNo, "GLM Message") = MsgBoxResult.No) Then
			Exit Sub
		End If
		
		'Solo se puede borrar contratos sin facturas asociadas.
		'Las facturas deben ser impresas en cheques invoice_status=PRT
		'y dichos cheques debieron ser transferidos a Quick Books.
        sStmt = "SELECT DISTINCT VInvoiceDet.invoice_no, " & "VInvoiceDet.account_no, VInvoice.vinvoice_status " & " FROM VInvoice, VInvoiceDet " & " WHERE VInvoice.invoice_no = VInvoiceDet.invoice_no " & " AND VInvoice.cust_id = VInvoiceDet.cust_id " & " AND VInvoice.store_id = VInvoiceDet.store_id " & " AND VInvoice.vend_seq = VInvoiceDet.vend_seq " & " AND VInvoice.account_no = VInvoiceDet.account_no " & " AND VInvoiceDet.cust_id = '" + rsStore.Item("cust_id").Value + "' " + " AND VInvoiceDet.store_id = " + Str(rsStore.Item("store_id").Value) + " AND VInvoiceDet.vend_seq = " + Str(rsContract.Item("vend_seq").Value) + " AND VInvoiceDet.eqpt_seq = " + Str(rsEquipment.Item("eqpt_seq").Value) + " AND VInvoiceDet.serv_id =" + Str(rsContract.Item("serv_id").Value)
        cmd.CommandText = sStmt
		
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            While rsLocal.Read()
                sInvoiceNo = rsLocal.Item("invoice_no").Value
                sAccountNo = rsLocal.Item("account_no").Value
                sInvoiceStatus = rsLocal.Item("vinvoice_status").Value
                If sInvoiceStatus = "CRE" Then
                    'No se puede eliminar contrato. Ordenes sin pagar y sin transferir
                    MsgBox("Found some open invoices associated to this contract." & vbCrLf & "All invoices using this contract info " & "must be completed," & vbCrLf & "before attempting to delete contract.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Message")
                    Exit Sub
                Else

                    sStmt = "SELECT COUNT(*) " & " FROM VInvoice ,Bcheck " & " WHERE VInvoice.invoice_no = Bcheck.invoice_no " & " AND VInvoice.cust_id = Bcheck.cust_id " & " AND VInvoice.store_id = Bcheck.store_id " & " AND VInvoice.vend_seq = Bcheck.vend_seq " & " AND VInvoice.account_no = Bcheck.account_no " & " AND VInvoice.invoice_no = '" & Trim(sInvoiceNo) & "' " & " AND VInvoice.cust_id = '" + rsStore.Item("cust_id").Value + "' " + " AND VInvoice.store_id = " + Str(rsStore.Item("store_id").Value) + " AND VInvoice.vend_seq = " + Str(rsContract.Item("vend_seq").Value) + " AND VInvoice.account_no = '" + Trim(sAccountNo) + "' " + " AND Bcheck.qb_exported_flag IS NULL "
                    cmd.CommandText = sStmt
                    'qb_exported_flag puede ser : NULL o Y

                    'MsgBox sStmt
                    rsLocalDet = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                    'MsgBox Str(rsLocalDet.item(0))
                    If rsLocalDet.HasRows() Then
                        If rsLocalDet.Item(0).Value = 0 Then
                            'Siguiente factura
                        Else
                            MsgBox("Found some open invoices associated to this contract." & vbCrLf & "All invoices using this contract info " & "must be completed," & vbCrLf & "before attempting to delete contract.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Message")
                            Exit Sub
                        End If
                    Else
                        MsgBox("Error found while checking contract info.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                        Exit Sub
                    End If
                End If
            End While
        End If
		
		'Eliminar contrato
        sStmt = "DELETE FROM VContract " & " WHERE cust_id = '" + rsStore.Item("cust_id").Value + "' " + " AND store_id = " + Str(rsStore.Item("store_id").Value) + " AND vend_seq = " + Str(rsContract.Item("vend_seq").Value) + " AND eqpt_seq = " + Str(rsEquipment.Item("eqpt_seq").Value) + " AND serv_id = " + Str(rsContract.Item("serv_id").Value)
		'MsgBox sStmt
		
		cmLocal.CommandText = sStmt
        nRecords = cmLocal.ExecuteNonQuery()
		If nRecords > 0 Then
			MsgBox("Contract info successfully deleted.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
			'Refresco datagrid de Contratos
            get_dgContractData(False, rsStore.Item("cust_id").Value, rsStore.Item("store_id").Value, CShort(txtVendName.Tag), rsEquipment.Item("eqpt_seq").Value)
			
		End If
		
	End Sub
End Class