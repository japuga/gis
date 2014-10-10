Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Friend Class frmCheckRep
    Inherits System.Windows.Forms.Form
    'Private ImageList1 As New ImageList()
	Private sCustId As String
    Private rsCheckRep As sqldatareader
	'UPGRADE_WARNING: Lower bound of array sStore was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private sStore(16) As String 'List of Store names
	Private i As Short
	Private sVendAddress As String
	Private sVendCity As String
	Private sVendState As String
	Private sVendZip As String
	'UPGRADE_WARNING: Lower bound of array sLinea was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private sLinea(3) As String
    Private rsLocal As sqldatareader
    Private rsLocal2 As sqldatareader
	Private sCustName As String
	Private nStoreCounter As Short 'Used as index in sStore array on add_store function
	
	
	Private Sub frmCheckRep_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		init_comp()
		load_comp()
	End Sub
	
	Private Sub init_comp()
		Dim nIndex As Short
		Dim fso As Scripting.FileSystemObject
		fso = New Scripting.FileSystemObject
		
		
		
		
		
		
        rsCheckRep = Nothing
        rsLocal = Nothing
        rsLocal2 = Nothing
		sCustName = ""
		nStoreCounter = 0
		
		For nIndex = 1 To 3
			sLinea(nIndex) = ""
		Next nIndex
		
		For nIndex = 1 To 16
			sStore(nIndex) = ""
		Next nIndex
		
		txtDetail1.Text = "PLEASE CREDIT ALL ACCOUNTS "
		If fso.FileExists(gGlobSettings.sCheckLogoFile) Then
			picLogo.Image = System.Drawing.Image.FromFile(gGlobSettings.sCheckLogoFile)
		Else
			MsgBox("Could not find logo file:" & gGlobSettings.sCheckLogoFile, MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "GLM Warning")
			
		End If
	End Sub
	Private Sub load_comp()
		Dim nIndex As Short
        Dim cmd As SqlCommand = cn.CreateCommand
		On Error GoTo ErrorHandler
		
		'txtDate = gCheck.Date
		dtCheckDate._Value = gCheck.Date_Renamed
		txtVendor.Text = UCase(gCheck.VendorName)
		'UPGRADE_ISSUE: MSMask.MaskEdBox property txtAmount.Format was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtAmount.Mask = "#,###,##0.00"
		txtAmount.Text = CStr(gCheck.Amount)
		
		lCheckNo.Text = CStr(gCheck.CheckNo)
		lCheckNo.Font = VB6.FontChangeUnderline(lCheckNo.Font, True)
		
		txtAmountString.Text = num2str(gCheck.Amount)
		
		sCustId = gCheck.CustId
		
		'Obtener direccion del vendor
		'1.7.2
		sStmt = "SELECT vend_pay_address, vend_pay_city, " & "vend_pay_state, vend_pay_zip " & "FROM VBranch " & "WHERE vend_seq = " & Str(gCheck.VendorSeq)
        cmd.CommandText = sStmt
		
        rsCheckRep = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
        If Not rsCheckRep.HasRows() Then
            MsgBox("Unable to find Payment Address for vendor.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
            Exit Sub
        End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If Not IsDBNull(rsCheckRep.item("vend_pay_address").Value) Then
            sVendAddress = rsCheckRep.item("vend_pay_address").Value
        Else
            sVendAddress = ""
        End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If Not IsDBNull(rsCheckRep.item("vend_pay_city").Value) Then
            sVendCity = rsCheckRep.item("vend_pay_city").Value
        Else
            sVendCity = ""
        End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If Not IsDBNull(rsCheckRep.item("vend_pay_state").Value) And Not IsDBNull(rsCheckRep.item("vend_pay_zip").Value) Then
            sVendState = rsCheckRep.item("vend_pay_state").Value
            'sVendZip = rsCheckRep("vend_pay_state") + " - " + rsCheckRep("vend_pay_zip")
            sVendZip = rsCheckRep.item("vend_pay_zip").Value
        Else
            sVendState = ""
            sVendZip = ""
        End If
		
		'txtVendorAddress = Trim(txtVendor) + vbCrLf + _
		'Trim(sVendAddress) + vbCrLf + _
		'Trim(sVendCity) + " - " + Trim(sVendZip)
		
        txtVendorAddress.Text = Trim(txtVendor.Text) & vbCrLf & Trim(sVendAddress) & vbCrLf & Trim(sVendCity) & " - " & Trim(rsCheckRep.item("vend_pay_state").Value + " - " + rsCheckRep.item("vend_pay_zip").Value)
		
		
		'Obtener la lista de tiendas
		'1.7.2
		'txtStore = sCustId
		txtStore.Text = Trim(gCheck.CustName)
		nIndex = 0		

        For row As Integer = 0 To gCheck.rsStore.Rows.Count - 1
            add_store(gCheck.rsStore.Rows(row).Item("Store").Value)
            'Cargo detalle de forma
            lStore(nIndex).Text = gCheck.rsStore.Rows(row).Item("Store").Value
            'lAccount(nIndex) = gCheck.rsStore("Account")
            lAccount(nIndex).Text = gCheck.rsStore.Rows(row).Item("account_mask").Value
            lInvoice(nIndex).Text = gCheck.rsStore.Rows(row).Item("Invoice").Value
            lTotal(nIndex).Text = gCheck.rsStore.Rows(row).Item("Total").Value

            nIndex = nIndex + 1
        Next

        lList.Text = txtStore.Text
        txtSum.Text = txtAmount.Text
        'Elimino el resto de campos sin dato
        For i = nIndex To 15
            lStore(i).Visible = False
            lAccount(i).Visible = False
            lInvoice(i).Visible = False
            lTotal(i).Visible = False

        Next i

        Exit Sub

ErrorHandler:
        clear_detail()
        txtVendorAddress.Text = ""
        save_error("frmCheckRep", "load_comp")
        MsgBox("An error occured while loading Check Info." & vbCrLf & "Review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
	End Sub
	
	
	Private Sub add_store(ByRef sData As String)
		'1.9.4 Variable static no se destruye al cerrar forma. Se usa var global
		'Static nCounter As Integer
		
		On Error GoTo ErrorHandler
		
		'Verifica que el store no haya sido ingresada previamente
		For i = 1 To 16
			If sStore(i) = sData Then
				Exit Sub
			End If
		Next i
		nStoreCounter = nStoreCounter + 1
		sStore(nStoreCounter) = sData
		txtStore.Text = txtStore.Text & " - " & Trim(sData)
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "add_store")
		MsgBox("An unexpected has occurred , check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
	'Esconde los campos en caso de Error
	Private Sub clear_detail()
		Dim i As Short
		
		For i = 0 To 15
			lStore(i).Visible = False
			lAccount(i).Visible = False
			lInvoice(i).Visible = False
			lTotal(i).Visible = False
			
		Next i
		
	End Sub
	
	'Verifies printer and calls printing function
	'05.20.06 Replaced print_check3 with library function print_check5
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Dim sBankAba As String = ""
        Dim sBankAccount As String = ""
        Dim sBankCheckInfo1 As String = ""
        Dim sBankCheckInfo2 As String = ""
        Dim sBankCheckInfo3 As String = ""
        Dim sBankCheckInfo4 As String = ""

        Select Case Button.Name
            Case "Printer"
                If find_printer() Then
                    If save_check() Then
                        Select Case General.gCheckPaperSource
                            Case General.CheckPaper.Imprinted
                                'print_check3
                                'UPGRADE_WARNING: Str has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                                print_check5(gCheck.CustName, gCheck.CheckNo, Trim(Str(gCheck.Date_Renamed.ToOADate)), UCase(gCheck.VendorName), gCheck.Amount, num2str(gCheck.Amount), sVendAddress, sVendCity, sVendState, sVendZip, txtDetail1.Text, txtDetail2.Text, sBankAba, sBankAccount, sStore)

                            Case General.CheckPaper.Blank

                                sBankAccount = get_bank_account(CShort(gCheck.BankCustSeq))
                                sBankAba = get_bank_aba(CShort(gCheck.BankCustSeq))
                                sBankCheckInfo1 = get_bank_info(CShort(gCheck.BankCustSeq), "check_info1")
                                sBankCheckInfo2 = get_bank_info(CShort(gCheck.BankCustSeq), "check_info2")
                                sBankCheckInfo3 = get_bank_info(CShort(gCheck.BankCustSeq), "check_info3")
                                sBankCheckInfo4 = get_bank_info(CShort(gCheck.BankCustSeq), "check_info4")

                                'print_check_batch gCheck.CustName, gCheck.CheckNo, _
                                'Str(gCheck.Date), UCase(gCheck.VendorName), _
                                'gCheck.Amount, num2str(gCheck.Amount), _
                                'sVendAddress, sVendCity, _
                                'sVendState, sVendZip, _
                                'txtDetail1, txtDetail2, _
                                'sBankAba, sBankAccount
                                'UPGRADE_WARNING: Str has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                                print_check_batch3(gCheck.CustName, gCheck.CheckNo, Trim(Str(gCheck.Date_Renamed.ToOADate)), UCase(gCheck.VendorName), gCheck.Amount, num2str(gCheck.Amount), sVendAddress, sVendCity, sVendState, sVendZip, txtDetail1.Text, txtDetail2.Text, sBankAba, sBankAccount, sStore, sBankCheckInfo1, sBankCheckInfo2, sBankCheckInfo3, sBankCheckInfo4)


                        End Select

                        MsgBox("Invoice information has been successfully  updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Message")
                        close_form()
                    End If
                End If
            Case "Paper"
                VB6.ShowForm(frmCheckPaper, VB6.FormShowConstants.Modal, Me)
        End Select



    End Sub
	
	Private Sub print_check()
		Dim i As Short
		Dim nRate As Double
		Dim sAmount As Object
		
		On Error GoTo ErrorHandler
		'print_check = True
		
		'Verifica que exista por lo menos una impresora definida
		'If Not find_printer Then
		'    print_check = False
		'    Exit Function
		'End If
		
		'Valores de impresion
		'UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 12
		
		'Fecha
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6.82 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 0.6605 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtDate.Text)
		
		'Vendor
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sAmount = FormatCurrency(txtAmount.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sAmount = VB.Right(sAmount, Len(sAmount) - 1)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.9 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.2 * 1440 '1.15
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6.7 * 1440
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sAmount)
		
		'Amount
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.22 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.54 * 1440 '1.55
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtAmountString.Text)
		
		'Vendor Address
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontSize = 11
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440 '0.7
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.9 * 1440 ' 1.8
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sVendAddress)
		
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.05 * 1440 '1.95
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sVendCity)
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.2 * 1440 '2.1
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sVendZip)
		
		'Store list
		list_store(3, 30)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.5 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(1))
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.65 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(2))
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.8 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(3))
		
		'Check Detail
		'DETALLE
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontSize = 9 '*************
		'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = True
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 3.67 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtDate.Text)
		
		'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = True
		
		'TITULOS
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 3 * 1440 '2.7
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 3.87 * 1440 '3.67
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Store")
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 4 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Account")
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 5 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Invoice")
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Amount")
		
		'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = False
		'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = False
		
		'DATOS
		nRate = 0.13 '0.15
		i = 1
		'namount = 1012.23

        For row As Integer = 0 To gCheck.rsStore.Rows.Count - 1
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 3 * 1440
            'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentY = (3.92 + (nRate * i)) * 1440 '3.72
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Store").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 4 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Account").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 5 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Invoice").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 6 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True))

            i = i + 1
        Next row

        'Listado de Tiendas
        list_store(2, 60)
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 6.2 * 1440 '6.52
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(1))
        'Total del cheque
        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = True
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = False
        'Segunda linea de tiendas
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 6.35 * 1440
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(2))


        'COPIA *************************************

        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = True

        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 7.2 * 1440
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtDate.Text)

        'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = True

        'TITULOS
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 3 * 1440 '0.7
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 7.35 * 1440 '7.15
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Store")
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 4 * 1440 '1.7
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Account")
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 5 * 1440 '2.7
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Invoice")
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440 '3.7
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Amount")

        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = False
        'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = False


        i = 1

        'While gCheck.rsStore.Read()
        For row As Integer = 0 To gCheck.rsStore.Rows.Count - 1
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 3 * 1440
            'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentY = (7.4 + (nRate * i)) * 1440 '7.2
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Store").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 4 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Account").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 5 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Invoice").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 6 * 1440
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True))

            i = i + 1
        Next row

        'Stores
        list_store(2, 60)
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 9.68 * 1440 '9.9
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(1))

        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = True
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = False

        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
        'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 9.83 * 1440 '10.05
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(2))

        'UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.EndDoc()
        Exit Sub

ErrorHandler:
        'print_check = False
        save_error("frmCheckRep", "print_check")
        MsgBox("Failed to Print Check." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")

    End Sub
	'Rel1.7.2 Se cambio disenio para imprimir en cheques reales
	Private Sub print_check2()
		Dim i As Short
		Dim nRate As Double
		Dim sAmount As Object
		
		On Error GoTo ErrorHandler
		'print_check = True
		
		'Verifica que exista por lo menos una impresora definida
		'If Not find_printer Then
		'    print_check = False
		'    Exit Function
		'End If
		
		'Valores de impresion
		'UPGRADE_ISSUE: Constant vbPRPSLetter was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Printer property Printer.PaperSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.PaperSize = vbPRPSLetter
		'UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontName = "Times New Roman"
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontSize = 12
		
		'Fecha
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6.82 * 1440
		'rel1.4--Printer.CurrentY = 0.6605 * 1440
		'Printer.CurrentY = 0.65 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 0.56 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(dtCheckDate._Value)
		
		'Vendor
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sAmount = FormatCurrency(txtAmount.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sAmount = "**" & VB.Right(sAmount, Len(sAmount) - 1)
		'rel1.4---Printer.CurrentX = 0.9 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 1 * 1440
		'rel1.4--Printer.CurrentY = 1.2 * 1440 '1.15
		'Printer.CurrentY = 1.15 * 1440 '1.15
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.06 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
		'rel1.4---Printer.CurrentX = 6.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6.8 * 1440
		'UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sAmount)
		
		'Amount String
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.22 * 1440
		'rel1.4---Printer.CurrentY = 1.54 * 1440
		'Printer.CurrentY = 1.5 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.41 * 1440 '1.51
		'rel1.4---
		txtAmountString.Text = Trim(txtAmountString.Text) & "****************************"
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtAmountString.Text)
		
		'Vendor Address
		'Printer.FontSize = 11
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontSize = 10
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440 '0.7
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 1.9 * 1440 '1.75
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
		'rel1.4---Printer.CurrentY = 1.9 * 1440 ' 1.8
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440 '0.7
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.05 * 1440 ' 1.9
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sVendAddress)
		
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.2 * 1440 '2.05
		'rel1.4---
		sVendCity = Trim(sVendCity) & " - " & sVendZip
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sVendCity)
		
		'Printer.CurrentX = 0.7 * 1440
		'Printer.CurrentY = 2.2 * 1440  '2.1
		'Printer.Print sVendZip
		
		'Store list
		list_store(3, 30)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.5 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(1))
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.65 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(2))
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 2.8 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(sLinea(3))
		
		'Check Detail
		'DETALLE
		'UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontSize = 9 '*************
		'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = True
		
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 0.7 * 1440
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 3.67 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(txtVendor.Text)
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print(dtCheckDate._Value)
		
		'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = True
		
		'TITULOS
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 3 * 1440 '2.7
		'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentY = 3.87 * 1440 '3.67
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Store")
        'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 4 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Account")
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 5 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Invoice")
		'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.CurrentX = 6 * 1440
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.Print("Amount")
		
		'UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontBold = False
		'UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '		Printer.FontUnderline = False
		
		'DATOS
		nRate = 0.13 '0.15
		i = 1
		'namount = 1012.23


        'While gCheck.rsStore.Read()
        For row As Integer = 0 To gCheck.rsStore.Rows.Count - 1
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 3 * 1440
            'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentY = (3.92 + (nRate * i)) * 1440 '3.72
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.Print(gCheck.rsStore.item("Store").Value)
            'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '			Printer.CurrentX = 4 * 1440
            '05.15.03 Mascara de cuenta
            'Printer.Print gCheck.rsStore("Account");
            'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            'Printer.Print(gCheck.rsStore.item("account_mask").Value)
            ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            'Printer.CurrentX = 5 * 1440
            ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            'Printer.Print(gCheck.rsStore.item("Invoice").Value)
            ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            'Printer.CurrentX = 6 * 1440
            ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
            ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            'Printer.Print(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True))
            'gCheck.rsStore.MoveNext()
            i = i + 1
        Next row

        ''Listado de Tiendas
        'list_store(2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.2 * 1440 '6.52
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))
        ''---
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 2 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail2.Text)
        ''Total del cheque
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = False
        ''Segunda linea de tiendas
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.35 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))

        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.5 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail2.Text)


        ''COPIA *************************************

        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.2 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtVendor.Text)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(dtCheckDate._Value)

        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True

        ''TITULOS
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.35 * 1440 '7.15
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Store")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4 * 1440 '1.7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Account")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 5 * 1440 '2.7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Invoice")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440 '3.7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Amount")

        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = False
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False


        'i = 1
        'gCheck.rsStore.MoveFirst()
        'Do While Not gCheck.rsStore.EOF
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 3 * 1440
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (7.4 + (nRate * i)) * 1440 '7.2
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Store").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 4 * 1440
        '	'05.15.03 Mascara de Cuenta
        '	'Printer.Print gCheck.rsStore("Account");
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("account_mask").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 5 * 1440
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Invoice").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 6 * 1440
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True))
        '	gCheck.rsStore.MoveNext()
        '	i = i + 1
        'Loop 

        ''Stores
        'list_store(2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.68 * 1440 '9.68
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))

        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = False

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.83 * 1440 '9.83
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))
        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.98 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail1.Text)

        ''UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.EndDoc()
        Exit Sub

ErrorHandler:
        save_error("frmCheckRep", "print_check2")
        MsgBox("An unexpected error has ocurred while generating check." & vbCrLf & "Please review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "GLM Error")
	End Sub
	'Imprime cheque
	Private Sub print_check3()
		Dim i As Short
		Dim nRate As Double
		Dim sAmount As Object
		Dim nLines As Short
		Dim nCounter As Short
		
		On Error GoTo ErrorHandler
		'print_check = True
		
		'Verifica que exista por lo menos una impresora definida
		'If Not find_printer Then
		'    print_check = False
		'    Exit Function
		'End If
		
		'Valores de impresion
		'UPGRADE_ISSUE: Constant vbPRPSLetter was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Printer property Printer.PaperSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.PaperSize = vbPRPSLetter
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 12

        ''Fecha
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.82 * 1440
        ''rel1.4--Printer.CurrentY = 0.6605 * 1440
        ''Printer.CurrentY = 0.65 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.56 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(dtCheckDate._Value)

        ''Vendor
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'sAmount = FormatCurrency(txtAmount.Text)
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'sAmount = "**" & VB.Right(sAmount, Len(sAmount) - 1)
        ''rel1.4---Printer.CurrentX = 0.9 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1 * 1440
        ''rel1.4--Printer.CurrentY = 1.2 * 1440 '1.15
        ''Printer.CurrentY = 1.15 * 1440 '1.15
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.06 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtVendor.Text)
        ''rel1.4---Printer.CurrentX = 6.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.8 * 1440
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sAmount)

        ''Amount String
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440
        ''rel1.4---Printer.CurrentY = 1.54 * 1440
        ''Printer.CurrentY = 1.5 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.41 * 1440 '1.51
        ''rel1.4---
        'txtAmountString.Text = Trim(txtAmountString.Text) & "****************************"
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtAmountString.Text)

        ''Vendor Address
        ''Printer.FontSize = 11
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 10
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.9 * 1440 '1.75
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(txtVendor.Text))
        ''rel1.4---Printer.CurrentY = 1.9 * 1440 ' 1.8
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.05 * 1440 ' 1.9
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(sVendAddress))


        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.2 * 1440 '2.05
        ''rel1.4---
        'sVendCity = Trim(sVendCity) & " - " & sVendZip
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(sVendCity))

        ''Printer.CurrentX = 0.7 * 1440
        ''Printer.CurrentY = 2.2 * 1440  '2.1
        ''Printer.Print sVendZip

        ''Store list
        'list_store(3, 30)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.5 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.65 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.8 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(3))

        ''Check Detail
        ''DETALLE
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Courier New" '01.09.04
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 9 '*************
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''01.09.04
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 3.67 * 1440
        'nLines = parse_string(txtVendor.Text, 18)
        'If nLines > 0 Then
        '	'Printer.Print gParse(1);
        'Else
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(txtVendor.Text)
        'End If

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 7 * 1440 '7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(dtCheckDate._Value)

        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True

        ''TITULOS
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 3.67 * 1440 '3.87
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 2 * 1440 '3
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Store")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440 '4
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Account")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.5 * 1440 '5
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Invoice")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440 '6
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Amount")

        ''Printer.FontBold = False
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False

        ''DATOS
        'nRate = 0.13 '0.15
        'i = 1
        ''namount = 1012.23
        'gCheck.rsStore.MoveFirst()
        'nCounter = 0
        'Do While Not gCheck.rsStore.EOF
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (3.72 + (nRate * i)) * 1440 '3.92
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 2 * 1440 '3
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Store").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 3 * 1440 '4
        '	'05.15.03 Mascara de cuenta
        '	'Printer.Print gCheck.rsStore("Account");
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("account_mask").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 4.5 * 1440 '5
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Invoice").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 5.7 * 1440 '6
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(format_qty(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True)))
        '	gCheck.rsStore.MoveNext()
        '	i = i + 1
        'Loop 

        ''Nombre de vendedor multilinea
        'i = 1
        'For nCounter = 1 To nLines
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (3.72 + (nRate * i)) * 1440 '3.92
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 0.1 * 1440
        '	'Printer.FontBold = True
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gParse(nCounter))
        '	'Printer.FontBold = False
        '	i = i + 1
        'Next nCounter

        ''Listado de Tiendas
        'list_store(2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.2 * 1440 '6.52
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))
        ''---
        ''Total del cheque
        ''Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        ''Printer.FontBold = False
        ''Segunda linea de tiendas
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.35 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))

        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.35 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail1.Text)

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.55 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail2.Text)


        ''COPIA *************************************

        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.2 * 1440
        'nLines = parse_string(txtVendor.Text, 18)
        'If nLines > 0 Then
        '	'Printer.Print gParse(1);
        'Else
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(txtVendor.Text)
        'End If
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 7 * 1440 '6
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(dtCheckDate._Value)

        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True

        ''TITULOS
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.15 * 1440 '7.35
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 2 * 1440 '3
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Store")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440 '4
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Account")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.5 * 1440 '5
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Invoice")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440 '3.7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Amount")

        ''Printer.FontBold = False
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False


        'i = 1
        'gCheck.rsStore.MoveFirst()
        'Do While Not gCheck.rsStore.EOF
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (7.2 + (nRate * i)) * 1440 '7.4
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 2 * 1440 '3
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Store").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 3 * 1440 '4
        '	'05.15.03 Mascara de Cuenta
        '	'Printer.Print gCheck.rsStore("Account");
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("account_mask").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 4.5 * 1440 '5
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Invoice").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 5.7 * 1440 '6
        '	'Printer.Print FormatCurrency(gCheck.rsStore("Total"), 2, vbTrue)
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(format_qty(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True)))
        '	gCheck.rsStore.MoveNext()
        '	i = i + 1
        'Loop 

        ''Nombre de vendedor multilinea
        'i = 1
        'For nCounter = 1 To nLines
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (7.2 + (nRate * i)) * 1440 '7.4
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 0.1 * 1440
        '	'Printer.FontBold = True
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gParse(nCounter))
        '	'Printer.FontBold = False
        '	i = i + 1
        'Next nCounter

        ''Stores
        'list_store(2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.68 * 1440 '9.68
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))

        ''Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(txtAmount.Text, 2, TriState.True))
        ''Printer.FontBold = False

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.83 * 1440 '9.83
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))
        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.98 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail1.Text)

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 10.18 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(txtDetail2.Text)

        ''UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.EndDoc()
		Exit Sub
		
ErrorHandler: 
		save_error("frmCheckRep", "print_check3")
		MsgBox("An unexpected error has ocurred while generating check." & vbCrLf & "Please review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "GLM Error")
	End Sub
	
	
	'Verifica que existan impresoras definidas
	Private Function find_printer() As Boolean
		
		'No existen impresora definidas en esta maquina
		'UPGRADE_ISSUE: Printers method Printers.Count was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count <= 0 Then
            MsgBox("There are not printers defined in this computer." & vbCrLf & "Please set up a default printer before proceeding.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Message")

            find_printer = False
            Exit Function
        End If
		
		VB6.ShowForm(frmPrinter, VB6.FormShowConstants.Modal, Me)
		If gbPrinter Then
			find_printer = True
		Else
			find_printer = False
		End If
		
		
	End Function
	'Muestra Ventana con impresoras
	Private Function find_printer2() As Boolean
		On Error GoTo ErrorHandler
		
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        'cdPrinter.CancelError = True
		'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdPrinter.PrinterDefault was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'cdPrinter.PrinterDefault = True
		
		cdPrinterPrint.ShowDialog()
		
		Exit Function
		
ErrorHandler: 
		find_printer2 = False
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			'Usuario cancelo impresion
			find_printer2 = False
		Else
			save_error(Me.Name, "find_printer2")
		End If
	End Function
	'Guarda la lista de facturas pagadas en este cheque,
	'actualiza el estado de las facturas a PRT = PRINT impresas.
	Private Function save_check() As Boolean
		Dim nCounter As Short
		Dim nRecords As Short
        Dim cmCheck As SqlCommand = cn.CreateCommand
        Dim nTran As SqlTransaction
		Dim qb As gDumpUDT
		Dim sDetailMemo As String
		Dim nLastCheckNo As Short
		
		Dim sMsg As String
		

		'NO actualizo/inserto en tablas  cuando se reimprime
		'If gCheck.reprint = True Then
		'    save_check = True
		'    Exit Function
		'End If
		
		save_check = True
		
        Try
            'NO actualizo/inserto en tablas  cuando se reimprime el mismo # de cheque
            If gCheck.reprint = True And gCheck.bSameCheck = True Then
                nTran = cn.BeginTransaction()
                'Actualizo fecha de reimpresion de cheque
                sStmt = "UPDATE Bcheck " & " SET check_date='" & Str(dtCheckDate._Value) & "'" & " WHERE bank_cust_seq = " & gCheck.BankCustSeq & " AND check_no =" & Str(gCheck.VoidCheckNo)

                'MsgBox sStmt

                nRecords = cmCheck.ExecuteNonQuery()
                If nRecords > 0 Then
                    'ok
                    If gbDebug Then
                        sMsg = "DEBUG...Reprinted Check#:" & Str(gCheck.VoidCheckNo)
                        write_error(sMsg, sLogfile, False)
                    End If
                    nTran.Commit()
                Else
                    save_check = False
                    MsgBox("Failed to update date on Check:" & Str(gCheck.VoidCheckNo))
                    'ROLLBACK
                    nTran.Rollback()
                End If

                Exit Function
            End If

        Catch e As Exception
            MsgBox("Unable to save invoice information.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            save_check = False
            Exit Function
        End Try


        nTran = cn.BeginTransaction()
        nCounter = 0


        For row As Integer = 0 To gCheck.rsStore.Rows.Count - 1
            nCounter = nCounter + 1
            gCheck.Memo = get_check_memo()
            sDetailMemo = get_detail_memo(gCheck.rsStore.Rows(row).Item("Store").Value, gCheck.rsStore.Rows(row).Item("Account").Value, gCheck.rsStore.Rows(row).Item("Invoice").Value)

            'UPGRADE_WARNING: Couldn't resolve default property of object qb. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            qb = get_qb_name(sCustId)
            If qb.str1 = "ERROR" Then
                nTran.Rollback() 'Error en informacion para QuickBooksPro
                save_check = False
                Exit Function
            End If


            sStmt = "INSERT INTO BCheck (check_no, bank_cust_seq,  " & " check_detail_no, vend_seq, " & " cust_id, store_id, " & " invoice_no, account_no, " & " check_date, check_amount, " & " check_memo, invoice_total, " & " detail_memo, qb_detail_name, voided_flag, " & " create_user, create_dtim) " & " VALUES " & "(" & Str(gCheck.CheckNo) & "," & gCheck.BankCustSeq & ", " & Str(nCounter) & ", " & Str(gCheck.rsStore.Rows(row).Item("vend_seq").Value) & ", '" & gCheck.custId & "', " & Str(gCheck.rsStore.Rows(row).Item("store_id").Value) & ", '" & Trim(gCheck.rsStore.Rows(row).Item("Invoice").Value) & "', '" & Trim(gCheck.rsStore.Rows(row).Item("Account").Value) & "', " & "'" & Str(dtCheckDate._Value) & "', " & Str(gCheck.Amount) & ", " & "'" & gCheck.Memo & "', " & Str(gCheck.rsStore.rows(row).Item("Total").Value) & ", " & "'" & Trim(sDetailMemo) & "', '" & Trim(qb.str1) & "', 'N', " & "'" & Trim(gsUser) & "', getdate())"
            'MsgBox sStmt
            cmCheck.CommandText = sStmt
            nRecords = cmCheck.ExecuteNonQuery()
            If nRecords > 0 Then
                'ok
                If gbDebug Then
                    sMsg = "DEBUG...Saving Check#:" & Str(gCheck.CheckNo) & " Step 1" & vbCrLf & "Rows Inserted:" & Str(nRecords)
                    write_error(sMsg, sLogfile, False)
                End If

            Else
                save_check = False
                nTran.Rollback()
                MsgBox("Failed to insert Check:" & Str(gCheck.CheckNo), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit For
            End If


            'Actualizo estado de la factura
            sStmt = "UPDATE VInvoice " & "SET vinvoice_status = 'PRT', " & " change_user ='" & gsUser & "', " & " change_time = GETDATE() " & "WHERE vend_seq=" & Str(gCheck.rsStore.Rows(row).Item("vend_seq").Value) & " " & "AND cust_id = '" & gCheck.custId & "' " & "AND store_id = " & Str(gCheck.rsStore.Rows(row).Item("store_id").Value) & " " & "AND invoice_no = '" & Trim(gCheck.rsStore.Rows(row).Item("Invoice").Value) & "' " & "AND account_no = '" & Trim(gCheck.rsStore.Rows(row).Item("Account").Value) & "' "
            'MsgBox sStmt
            cmCheck.CommandText = sStmt
            nRecords = cmCheck.ExecuteNonQuery()

            If nRecords > 0 Then
                'ok
                If gbDebug Then
                    sMsg = "DEBUG...Updating invoice:" + gCheck.rsStore.Rows(row).Item("Invoice").Value + " Step 2" + vbCrLf + "Rows Updated:" + Str(nRecords)
                    write_error(sMsg, sLogfile, False)
                End If

            Else
                save_check = False
                nTran.Rollback()
                MsgBox("Failed to update Invoice information. Check:" & Str(gCheck.CheckNo), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit For
            End If
        Next



        'actualizo el estado de las facturas

        'cn.CommitTrans 'Termino la transaccion
        If gCheck.reprint Then
            'Void Check
            sStmt = "UPDATE Bcheck " & " SET " & "   check_amount=0 , " & "   invoice_total = 0, " & "   voided_flag ='Y' " & " WHERE bank_cust_seq = " & gCheck.BankCustSeq & " AND check_no =" & Str(gCheck.VoidCheckNo)

            'MsgBox sStmt
            cmCheck.CommandText = sStmt
            nRecords = cmCheck.ExecuteNonQuery()
            If nRecords > 0 Then
                'ok
                nTran.Commit()
            Else
                save_check = False
                'ROLLBACK
                nTran.Rollback()
                MsgBox("Failed to void Check:" & Str(gCheck.VoidCheckNo), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
            End If

            '01.09.04 Actualizo ultimo cheque en Cuenta de Banco
            sStmt = "SELECT last_check_no FROM BankAccount " & " WHERE bank_cust_seq = " & Str(CDbl(gCheck.BankCustSeq))
            cmCheck.CommandText = sStmt
            rs = getDataTable(sStmt) ' cmCheck.ExecuteReader() ' .Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If rs.Rows.Count > 0 Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If IsDBNull(rs.Rows(0).Item(0).Value) Then
                    nLastCheckNo = gCheck.CheckNo
                Else
                    'Compare current LastCheck
                    If rs.Rows(0).Item(0).Value > gCheck.CheckNo Then
                        nLastCheckNo = rs.Rows(0).Item(0).Value
                    Else
                        nLastCheckNo = gCheck.CheckNo
                    End If
                End If
            Else
                'BankAccount notfound
                save_check = False
                nTran.Rollback()
                MsgBox("Failed to update Bank Account last check field." & vbCrLf & "Verify that record exists in Bank Account table.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
                Exit Function
            End If


            sStmt = "UPDATE BankAccount " & " SET last_check_no=" & Str(nLastCheckNo) & " " & " WHERE bank_cust_seq =" & Str(CDbl(gCheck.BankCustSeq))

            cmCheck.CommandText = sStmt
            nRecords = cmCheck.ExecuteNonQuery()

            If nRecords > 0 Then
                'ok
            Else
                save_check = False
                nTran.Rollback()
                MsgBox("Failed to update Bank Account information. Check:" & Str(gCheck.CheckNo), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Function
            End If

        Else
            '01.09.04 Actualizo Cuenta de Banco
            sStmt = "UPDATE BankAccount " & " SET last_check_no=" & Str(gCheck.CheckNo) & " ," & " bank_account_balance = bank_account_balance -" & Str(gCheck.Amount) & " " & " WHERE bank_cust_seq =" & Str(CDbl(gCheck.BankCustSeq))

            cmCheck.CommandText = sStmt
            nRecords = cmCheck.ExecuteNonQuery()

            If nRecords > 0 Then
                'ok
            Else
                save_check = False
                nTran.Rollback()
                MsgBox("Failed to update Bank Account information. Check:" & Str(gCheck.CheckNo), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                Exit Function
            End If

            'Termino la transaccion
            nTran.Commit()
        End If
        Exit Function

ErrorHandler:
        'Cierro cualquier transaccion abierta
        nTran.Rollback()

        save_check = False

        save_error("frmCheckRep", "save_check")
        MsgBox("An error ocurred while updating check info. Review log file for details", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
    End Function
	'Crea el listado de tiendas cuyas facturas estan pagadas en este cheque
	Private Function get_check_memo() As String
		Dim i As Short
		Dim sTmp As String
        Dim cmd As SqlCommand = cn.CreateCommand
		On Error GoTo ErrorHandler
		
		'Inicializo la variable con el nombre del cliente
		sTmp = ""
		
        sStmt = "SELECT cust_name FROM customer WHERE cust_id ='" & Trim(gCheck.custId) & "'"
        cmd.CommandText = sStmt
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        sCustName = rsLocal.Item("cust_name").Value
        rsLocal.Close()


        sTmp = sCustName
        'Agrego la lista de tiendas
        If Len(sTmp) > 0 Then
            sTmp = Trim(sTmp) & " - Stores:"
        End If

        For i = 1 To 16
            If sStore(i) <> "" Then
                sTmp = sTmp & "#" & Trim(sStore(i)) & ", "
            End If
        Next i
        'Saco la ultima coma y agrego un punto al final
        sTmp = VB.Left(sTmp, Len(sTmp) - 2) & "."

        get_check_memo = sTmp
        Exit Function

ErrorHandler:
        save_error(Me.Name, "get_check_memo")
        MsgBox("An error occurred while formatting Check Info. Review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
	End Function
	'Obtains the QuickBooks account name
	'Each customer is an account in Quickbooks, but the customer
	'just belongs to a single group: i.e. CS(Container Store), TR (Tony Roma), Nordstrom, etc
	'In case of error str1="ERROR" to be detected
	Private Function get_qb_name(ByRef sCustId As String) As gDumpUDT
		Dim qb As gDumpUDT
		Dim sGroupId As String
		Dim sCustName As String
		qb.str1 = "" 'qb_name
		qb.str2 = ""
        Dim cmd As SqlCommand = cn.CreateCommand()

		
		
        sStmt = "SELECT qb_group_id, qb_account_name, cust_name " & " FROM customer " & " WHERE cust_id = '" & Trim(sCustId) & "'"
        cmd.CommandText = sStmt
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            sCustName = rsLocal.Item("cust_name").Value
            'QB-Group
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rsLocal.Item("qb_group_id").Value) Then
                MsgBox("Quick Books Group has not been defined " & "for this customer " & sCustId & "." & vbCrLf & "Please check customer info and try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                qb.str1 = "ERROR"
                'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                get_qb_name = qb
                Exit Function
            Else
                sGroupId = rsLocal.Item("qb_group_id").Value
            End If

            'QB-Customer Account
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rsLocal.Item("qb_account_name").Value) Then
                MsgBox("Customer " & Trim(sCustName) & " does not have a Quick Books Account defined." & vbCrLf & "Please check customer info and try again later.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                qb.str1 = "ERROR"
                'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                get_qb_name = qb
                Exit Function
            Else
                qb.str1 = quotation_mask(rsLocal.Item("qb_account_name").Value)
                If Len(qb.str1) = 0 Then
                    MsgBox("Incorrect QuickBooks account for customer." & Trim(sCustName) & vbCrLf & "Please check customer info and try again later.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                    qb.str1 = "ERROR"
                    'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    get_qb_name = qb
                    Exit Function
                Else
                    'OK. Verificar que la cuenta exista en qb_account
                    sStmt = "SELECT COUNT(*) FROM qb_account " & " WHERE name ='" & Trim(qb.str1) & "' " & " AND qb_group_id ='" & Trim(sGroupId) & "'"
                    cmd.CommandText = sStmt
                    rsLocal2 = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                    Try
                        If rsLocal2.HasRows() Then
                            If rsLocal2.Item(0).Value > 0 Then
                                If rsLocal2.Item(0).Value > 1 Then
                                    MsgBox("QBooks setup error found." & vbCrLf & "Customer account was found more than once " & "on Qbooks Account table.")
                                    qb.str1 = "ERROR"
                                    'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    get_qb_name = qb
                                    Exit Function
                                Else
                                    'OK
                                End If
                            Else
                                MsgBox("Quick Books setup error found." & vbCrLf & "Either customer " & Trim(sCustName) & " does not belong to QBooks file " & sGroupId & vbCrLf & " or QBooks Account data needs to be updated", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Warning")
                                qb.str1 = "ERROR"
                                'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                get_qb_name = qb
                                Exit Function
                            End If
                        Else
                            MsgBox("Quick Books setup error found." & vbCrLf & "Either customer does not belong to QBooks file " & sGroupId & vbCrLf & " or QBooks Account data needs to be updated", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Warning")
                            qb.str1 = "ERROR"
                            'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            get_qb_name = qb
                            Exit Function
                        End If
                    Catch e As Exception
                        MsgBox("An unexpected error has occurred." & "Please check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
                        qb.str1 = "ERROR"
                        'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        get_qb_name = qb
                        Exit Function
                    End Try
                End If
            End If

            rsLocal.Close()
            rsLocal2.Close()
        End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object get_qb_name. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		get_qb_name = qb
		Exit Function
		
ErrorHandler: 
		get_qb_name.str1 = "ERROR"
		save_error(Me.Name, "get_qb_name")
	End Function
	'Linea de detalle en cheque
	Private Function get_detail_memo(ByRef sStore As String, ByRef sAccount As String, ByRef sInvoice As String) As String
		Dim sTmp As String
        Dim cmd As SqlCommand = cn.CreateCommand()
		On Error GoTo ErrorHandler
		'Busco nombre del cliente
		If Len(sCustName) = 0 Then
            sStmt = "SELECT cust_name FROM customer WHERE cust_id ='" & Trim(gCheck.custId) & "'"
            cmd.CommandText = sStmt
            rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If rsLocal.HasRows() Then
                sCustName = rsLocal.Item("cust_name").Value
                rsLocal.Close()
            End If
        End If
		
		sTmp = Trim(sCustName) & " #" & Trim(sStore) & "-Acct#" & Trim(sAccount) & "-Inv#" & Trim(sInvoice)
		get_detail_memo = sTmp
		Exit Function
		
ErrorHandler: 
		save_error(Me.Name, "get_detail_memo")
		MsgBox("An error occurred while formatting Check Info. Review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Function
	'Agrega las tiendas en dos o tres lineas (nLines) de longitud maxima nLen
	'En caso de que existan mas tiendas que las que se puedan mostrar en nLines,
	'las tiendas sobrantes se agregan a la ultima linea
	Private Sub list_store(ByRef nLines As Short, ByRef nLen As Short)
		Dim j As Short
		
		j = 1
		
		'1.7.2
		'sLinea(j) = sCustId + " - "
		sLinea(j) = Trim(gCheck.CustName) & " - "
		For i = 1 To 16
			If sStore(i) <> "" Then
				'If Len(sLinea(j)) >= 30 And j < 4 Then
				If Len(sLinea(j)) >= nLen And j < nLines + 1 Then
					j = j + 1
				End If
				'1.7.2
				'sLinea(j) = sLinea(j) + sStore(i)
				sLinea(j) = Trim(sLinea(j)) & "-" & Trim(sStore(i))
			End If
		Next i
		'MsgBox sLinea(1) + sLinea(2) + sLinea(3)
	End Sub
	
	Private Sub close_form()
		'Clear Vars
		
		'Unload the form
		Me.Close()
	End Sub
	
	
	'Prints Batch Checks
	Private Sub print_check_batch(ByRef sCustName As String, ByRef nCheckNo As Integer, ByRef sCheckDate As String, ByRef sVendName As String, ByRef nCheckAmount As Double, ByRef sAmountString As String, ByRef sVendPayAddress As String, ByRef sVendPayCity As String, ByRef sVendPayState As String, ByRef sVendPayZip As String, ByRef sDetail1 As String, ByRef sDetail2 As String, ByRef sBankAba As String, ByRef sBankAccount As String)
		
        'Dim i As Short
        'Dim nRate As Double
        'Dim sAmount As Object
        'Dim nLines As Short
        'Dim nCounter As Short
		Dim sCheckNo As String 'Formatted Check
        'Dim sMicrocode As String
		'UPGRADE_WARNING: Lower bound of array sLinea was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim sLinea(3) As String
		
		'On Error GoTo ErrorHandler
		'print_check = True
		
		sCheckNo = format_check_number(nCheckNo)
		'Bank Header Info
		'UPGRADE_ISSUE: Constant vbPRPSLetter was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Printer property Printer.PaperSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.PaperSize = vbPRPSLetter
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 7
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = False

        ''Image
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.85 * 1440 '0.95
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.14 * 1440 '0.24
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        ''UPGRADE_ISSUE: Printer method Printer.PaintPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.PaintPicture(picLogo.Image, Printer.CurrentX, Printer.CurrentY)
        ''Printer.PaintPicture Picture1.Picture, Printer.CurrentX, Printer.CurrentY

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.15 * 1440 '3.95
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.24 * 1440 '0.14
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("JPMORGAN CHASE BANK")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.45 * 1440 '4.25
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.34 * 1440 '0.24
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("P.O. BOX 2558")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.15 * 1440 '3.95
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.44 * 1440 '0.34
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("HOUSTON, TEXAS 77252")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.45 * 1440 '4.25
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.64 * 1440 '0.54
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("32-115/1110")

        ''Cabecera GLM
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 10

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1.95 * 1440 '3.75
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.34 * 1440 '0.24
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("GLM DFW, INC.")

        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 7

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1.55 * 1440 '1.95
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.5 * 1440 '0.54
        ''Printer.Print "7225 SAGE MEADOW PH. 972-702-6451"
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("3113 BROKEN BOW WAY PH. 972-702-6451")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1.95 * 1440 '3.75
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.6 * 1440 '0.64
        ''Printer.Print "PLANO, TEXAS 75024"
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("PLANO, TEXAS 75093")

        ''Valores de impresion
        ''Printer.PaperSize = vbPRPSLetter
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 12


        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.82 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.21 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sCheckNo)


        ''Fecha
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.21 * 1440 '6.15
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.56 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("DATE ")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.82 * 1440 '6.82
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 0.56 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sCheckDate)
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False


        ''Vendor
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 10

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.02 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Pay To The")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.21 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Order Of")



        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.1 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(" ____________________________________________________________________________ $ _______________")

        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 12

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.06 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sVendName)

        ''Cantidad
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'sAmount = FormatCurrency(nCheckAmount)
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'sAmount = "**" & VB.Right(sAmount, Len(sAmount) - 1)

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6.8 * 1440
        ''UPGRADE_WARNING: Couldn't resolve default property of object sAmount. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sAmount)

        ''Amount String
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.49 * 1440 '1.58
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("______________________________________________________________________________DOLLARS")

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.41 * 1440 '1.51
        'sAmountString = Trim(sAmountString) & "****************************"
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sAmountString)


        ''Vendor Address
        ''Printer.FontSize = 11
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 10
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 1.9 * 1440 '1.75
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(sVendName))
        ''rel1.4---Printer.CurrentY = 1.9 * 1440 ' 1.8
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.05 * 1440 ' 1.9
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(sVendPayAddress))


        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.2 * 1440 '2.05
        ''rel1.4---
        'sVendPayCity = Trim(sVendPayCity) & " - " & sVendPayState & " -" & sVendPayZip
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(UCase(sVendPayCity))

        ''Printer.CurrentX = 0.7 * 1440
        ''Printer.CurrentY = 2.2 * 1440  '2.1
        ''Printer.Print sVendZip

        ''Store list
        ''list_store 3, 30
        'list_store2(sLinea, sCustName, sStore, 3, 30)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.22 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.5 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("MEMO:" & sLinea(1))

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.65 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.7 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.8 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(3))

        ''Firma

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.95 * 1440 '5.75
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.41 * 1440 '2.49
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("________________________________________")

        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Times New Roman"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 6

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 5.85 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 2.59 * 1440 '1.58
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("AUTHORIZED SIGNATURE")

        ''Microcode
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "MRV MICR"
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 12

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 1.45 * 1440 '1.95
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 3.08 * 1440 '3.07

        'sMicrocode = "C" & Trim(sCheckNo) & "C A" & Trim(sBankAba) & "A C" & Trim(sBankAccount) & "C"
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sMicrocode)
        ''Printer.Print "C005290C A111001150A C12607078264C"


        ''Check Detail
        ''DETALLE
        ''UPGRADE_ISSUE: Printer property Printer.FontName was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontName = "Courier New" '01.09.04
        ''UPGRADE_ISSUE: Printer property Printer.FontSize was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontSize = 9 '*************
        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''01.09.04
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 3.67 * 1440
        'nLines = parse_string(sVendName, 18)
        'If nLines > 0 Then
        '	'Printer.Print gParse(1);
        'Else
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(sVendName)
        'End If

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 7 * 1440 '7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sCheckDate)

        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True

        ''TITULOS
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 3.67 * 1440 '3.87
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 2 * 1440 '3
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Store")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440 '4
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Account")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.5 * 1440 '5
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Invoice")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440 '6
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Amount")

        ''Printer.FontBold = False
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False

        ''DATOS
        'nRate = 0.13 '0.15
        'i = 1
        ''namount = 1012.23
        'gCheck.rsStore.MoveFirst()
        'nCounter = 0
        'Do While Not gCheck.rsStore.EOF
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (3.72 + (nRate * i)) * 1440 '3.92
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 2 * 1440 '3
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Store").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 3 * 1440 '4
        '	'05.15.03 Mascara de cuenta
        '	'Printer.Print gCheck.rsStore("Account");
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("account_mask").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 4.5 * 1440 '5
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Invoice").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 5.7 * 1440 '6
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(format_qty(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True)))
        '	gCheck.rsStore.MoveNext()
        '	i = i + 1
        'Loop 

        ''Nombre de vendedor multilinea
        'i = 1
        'For nCounter = 1 To nLines
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (3.72 + (nRate * i)) * 1440 '3.92
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 0.1 * 1440
        '	'Printer.FontBold = True
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gParse(nCounter))
        '	'Printer.FontBold = False
        '	i = i + 1
        'Next nCounter

        ''Listado de Tiendas
        ''list_store2 sCustName, 2, 60
        'list_store2(sLinea, sCustName, sStore, 2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.2 * 1440 '6.52
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))
        ''---
        ''Total del cheque
        ''Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(nCheckAmount, 2, TriState.True))
        ''Printer.FontBold = False
        ''Segunda linea de tiendas
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.35 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))

        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.35 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sDetail1)

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 6.55 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sDetail2)


        ''COPIA *************************************

        ''UPGRADE_ISSUE: Printer property Printer.FontBold was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontBold = True

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.2 * 1440
        'nLines = parse_string(sVendName, 18)
        'If nLines > 0 Then
        '	'Printer.Print gParse(1);
        'Else
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(sVendName)
        'End If
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 7 * 1440 '6
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sCheckDate)

        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = True

        ''TITULOS
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 7.15 * 1440 '7.35
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 2 * 1440 '3
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Store")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440 '4
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Account")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 4.5 * 1440 '5
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Invoice")
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440 '3.7
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print("Amount")

        ''Printer.FontBold = False
        ''UPGRADE_ISSUE: Printer property Printer.FontUnderline was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.FontUnderline = False


        'i = 1
        'gCheck.rsStore.MoveFirst()
        'Do While Not gCheck.rsStore.EOF
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (7.2 + (nRate * i)) * 1440 '7.4
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 2 * 1440 '3
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Store").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 3 * 1440 '4
        '	'05.15.03 Mascara de Cuenta
        '	'Printer.Print gCheck.rsStore("Account");
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("account_mask").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 4.5 * 1440 '5
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gCheck.rsStore.item("Invoice").Value)
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 5.7 * 1440 '6
        '	'Printer.Print FormatCurrency(gCheck.rsStore("Total"), 2, vbTrue)
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(format_qty(FormatCurrency(gCheck.rsStore.item("Total").Value, 2, TriState.True)))
        '	gCheck.rsStore.MoveNext()
        '	i = i + 1
        'Loop 

        ''Nombre de vendedor multilinea
        'i = 1
        'For nCounter = 1 To nLines
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentY = (7.2 + (nRate * i)) * 1440 '7.4
        '	'UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.CurrentX = 0.1 * 1440
        '	'Printer.FontBold = True
        '	'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        '	'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        '	Printer.Print(gParse(nCounter))
        '	'Printer.FontBold = False
        '	i = i + 1
        'Next nCounter

        ''Stores
        ''list_store 2, 60
        'list_store2(sLinea, sCustName, sStore, 2, 60)
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.68 * 1440 '9.68
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(1))

        ''Printer.FontBold = True
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 6 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(FormatCurrency(nCheckAmount, 2, TriState.True))
        ''Printer.FontBold = False

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 0.1 * 1440 '0.7
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.83 * 1440 '9.83
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sLinea(2))
        ''05.15.03
        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 9.98 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sDetail1)

        ''UPGRADE_ISSUE: Printer property Printer.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentX = 3 * 1440
        ''UPGRADE_ISSUE: Printer property Printer.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.CurrentY = 10.18 * 1440
        ''UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ''UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.Print(sDetail2)

        ''UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.EndDoc()
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "print_check_batch")
		MsgBox("An unexpected error has ocurred while generating check." & vbCrLf & "Please review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "GLM Error")
	End Sub
End Class