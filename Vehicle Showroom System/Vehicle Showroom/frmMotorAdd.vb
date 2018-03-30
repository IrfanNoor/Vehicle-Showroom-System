Imports MySql.Data.MySqlClient
Public Class frmMotorAdd
    Inherits System.Windows.Forms.Form
    Dim conn As New MySqlConnection
    Dim myData As New DataSet
    Dim hasil As Integer
    Dim SQLMOTORADD As String
    Dim cmd As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    'For fuel
    Dim SQLLoadFuel As String
    Dim myDataFuel As New DataTable
    Dim myCommandFuel As New MySqlCommand
    Dim myAdapterFuel As New MySqlDataAdapter
    'For vehicle
    Dim SQLLoadVehicle As String
    Dim myDataVehicle As New DataTable
    Dim myCommandVehicle As New MySqlCommand
    Dim myAdapterVehicle As New MySqlDataAdapter
    'for location
    Dim SQLLoadLocation As String
    Dim myDataLocation As New DataTable
    Dim myCommandLocation As New MySqlCommand
    Dim myAdapterLocation As New MySqlDataAdapter


    Private Sub frmMotorAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'error prevention techniques
        disable_object()
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
    End Sub
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Frame As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtYearRegistration As System.Windows.Forms.TextBox
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cboVehicleType As System.Windows.Forms.ComboBox
    Friend WithEvents cboFuelType As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents labe As System.Windows.Forms.Label
    Friend WithEvents labelLicese As System.Windows.Forms.Label
    Friend WithEvents labelRegist As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtYearManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtSeriesNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents txtBTM As System.Windows.Forms.TextBox
    Friend WithEvents txtBDM_BGK As System.Windows.Forms.TextBox
    Friend WithEvents txtEnginePower As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtChasisNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEngineNo As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistrationNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtLicenseReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLPKPFileReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLPKPFormNo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayable As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNCT_DTT As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicPremium As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtExcessApplicable As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleSum As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicyNo As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboDate As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cboInspectDate As System.Windows.Forms.ComboBox
    Friend WithEvents cboInspectMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtInspectYear As System.Windows.Forms.TextBox
    Friend WithEvents cboPolicyFromDate As System.Windows.Forms.ComboBox
    Friend WithEvents cboPolicyFromMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtPolicyFromYear As System.Windows.Forms.TextBox
    Friend WithEvents cboPolicyToDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtPolicyToYear As System.Windows.Forms.TextBox
    Friend WithEvents cboPolicyToMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboLicenseDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cboHour As System.Windows.Forms.ComboBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cboAM_PM As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label52 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMotorAdd))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Frame = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.tab = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.cboLicenseDuration = New System.Windows.Forms.ComboBox
        Me.txtYearRegistration = New System.Windows.Forms.TextBox
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.cboVehicleType = New System.Windows.Forms.ComboBox
        Me.cboFuelType = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.labe = New System.Windows.Forms.Label
        Me.labelLicese = New System.Windows.Forms.Label
        Me.labelRegist = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtYearManufacturer = New System.Windows.Forms.TextBox
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.txtSeriesNo = New System.Windows.Forms.TextBox
        Me.txtDriverName = New System.Windows.Forms.TextBox
        Me.txtBTM = New System.Windows.Forms.TextBox
        Me.txtBDM_BGK = New System.Windows.Forms.TextBox
        Me.txtEnginePower = New System.Windows.Forms.TextBox
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtManufacturer = New System.Windows.Forms.TextBox
        Me.txtChasisNo = New System.Windows.Forms.TextBox
        Me.txtEngineNo = New System.Windows.Forms.TextBox
        Me.txtRegistrationNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.Label48 = New System.Windows.Forms.Label
        Me.cboDate = New System.Windows.Forms.ComboBox
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.txtLicenseReferenceNo = New System.Windows.Forms.TextBox
        Me.txtLPKPFileReferenceNo = New System.Windows.Forms.TextBox
        Me.txtLPKPFormNo = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.cboPolicyToDate = New System.Windows.Forms.ComboBox
        Me.cboPolicyToMonth = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtPolicyToYear = New System.Windows.Forms.TextBox
        Me.cboPolicyFromDate = New System.Windows.Forms.ComboBox
        Me.cboPolicyFromMonth = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtPolicyFromYear = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalPayable = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtNCT_DTT = New System.Windows.Forms.TextBox
        Me.txtBasicPremium = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtExcessApplicable = New System.Windows.Forms.TextBox
        Me.txtVehicleSum = New System.Windows.Forms.TextBox
        Me.txtPolicyNo = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cboAM_PM = New System.Windows.Forms.ComboBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.cboHour = New System.Windows.Forms.ComboBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.cboInspectDate = New System.Windows.Forms.ComboBox
        Me.cboInspectMonth = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtInspectYear = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Frame.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        Me.tabpage2.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(208, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 45)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label31.Location = New System.Drawing.Point(296, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(288, 26)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Motor Insurance Add New Record"
        '
        'Frame
        '
        Me.Frame.BackColor = System.Drawing.Color.SteelBlue
        Me.Frame.Controls.Add(Me.Button1)
        Me.Frame.Controls.Add(Me.PictureBox2)
        Me.Frame.Controls.Add(Me.Label10)
        Me.Frame.Controls.Add(Me.cmdCancel)
        Me.Frame.Controls.Add(Me.cmdSave)
        Me.Frame.Controls.Add(Me.cmdAdd)
        Me.Frame.Controls.Add(Me.tab)
        Me.Frame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Frame.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame.Location = New System.Drawing.Point(24, 46)
        Me.Frame.Name = "Frame"
        Me.Frame.Size = New System.Drawing.Size(920, 466)
        Me.Frame.TabIndex = 3
        Me.Frame.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(624, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Close"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 429)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 436)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(392, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Please ensure that Registration Number is filled before saving"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(512, 403)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 20)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(400, 403)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 20)
        Me.cmdSave.TabIndex = 32
        Me.cmdSave.Text = "Save"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(288, 403)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 20)
        Me.cmdAdd.TabIndex = 31
        Me.cmdAdd.Text = "Add"
        '
        'tab
        '
        Me.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tab.Controls.Add(Me.tabpage1)
        Me.tab.Controls.Add(Me.tabpage2)
        Me.tab.Controls.Add(Me.tabPage3)
        Me.tab.Controls.Add(Me.TabPage4)
        Me.tab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.ItemSize = New System.Drawing.Size(222, 23)
        Me.tab.Location = New System.Drawing.Point(8, 20)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(904, 370)
        Me.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab.TabIndex = 3
        '
        'tabpage1
        '
        Me.tabpage1.BackColor = System.Drawing.Color.SteelBlue
        Me.tabpage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpage1.Controls.Add(Me.Label52)
        Me.tabpage1.Controls.Add(Me.Label44)
        Me.tabpage1.Controls.Add(Me.Label43)
        Me.tabpage1.Controls.Add(Me.cboLicenseDuration)
        Me.tabpage1.Controls.Add(Me.txtYearRegistration)
        Me.tabpage1.Controls.Add(Me.cboLocation)
        Me.tabpage1.Controls.Add(Me.cboVehicleType)
        Me.tabpage1.Controls.Add(Me.cboFuelType)
        Me.tabpage1.Controls.Add(Me.Label17)
        Me.tabpage1.Controls.Add(Me.Label16)
        Me.tabpage1.Controls.Add(Me.Label15)
        Me.tabpage1.Controls.Add(Me.Label14)
        Me.tabpage1.Controls.Add(Me.Label13)
        Me.tabpage1.Controls.Add(Me.labe)
        Me.tabpage1.Controls.Add(Me.labelLicese)
        Me.tabpage1.Controls.Add(Me.labelRegist)
        Me.tabpage1.Controls.Add(Me.Label9)
        Me.tabpage1.Controls.Add(Me.Label8)
        Me.tabpage1.Controls.Add(Me.Label7)
        Me.tabpage1.Controls.Add(Me.Label6)
        Me.tabpage1.Controls.Add(Me.Label5)
        Me.tabpage1.Controls.Add(Me.Label4)
        Me.tabpage1.Controls.Add(Me.Label3)
        Me.tabpage1.Controls.Add(Me.Label2)
        Me.tabpage1.Controls.Add(Me.txtYearManufacturer)
        Me.tabpage1.Controls.Add(Me.txtStatus)
        Me.tabpage1.Controls.Add(Me.txtSeriesNo)
        Me.tabpage1.Controls.Add(Me.txtDriverName)
        Me.tabpage1.Controls.Add(Me.txtBTM)
        Me.tabpage1.Controls.Add(Me.txtBDM_BGK)
        Me.tabpage1.Controls.Add(Me.txtEnginePower)
        Me.tabpage1.Controls.Add(Me.txtModel)
        Me.tabpage1.Controls.Add(Me.txtManufacturer)
        Me.tabpage1.Controls.Add(Me.txtChasisNo)
        Me.tabpage1.Controls.Add(Me.txtEngineNo)
        Me.tabpage1.Controls.Add(Me.txtRegistrationNo)
        Me.tabpage1.Controls.Add(Me.Label1)
        Me.tabpage1.Location = New System.Drawing.Point(4, 27)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(896, 339)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "JPJ"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(688, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 36
        Me.Label44.Text = "(e.g 2002)"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(264, 288)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 16)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "(e.g 1999)"
        '
        'cboLicenseDuration
        '
        Me.cboLicenseDuration.Location = New System.Drawing.Point(632, 48)
        Me.cboLicenseDuration.Name = "cboLicenseDuration"
        Me.cboLicenseDuration.Size = New System.Drawing.Size(112, 24)
        Me.cboLicenseDuration.TabIndex = 34
        '
        'txtYearRegistration
        '
        Me.txtYearRegistration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearRegistration.Location = New System.Drawing.Point(632, 16)
        Me.txtYearRegistration.Name = "txtYearRegistration"
        Me.txtYearRegistration.Size = New System.Drawing.Size(48, 23)
        Me.txtYearRegistration.TabIndex = 10
        Me.txtYearRegistration.Text = ""
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.Location = New System.Drawing.Point(632, 182)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(176, 24)
        Me.cboLocation.TabIndex = 15
        '
        'cboVehicleType
        '
        Me.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleType.Location = New System.Drawing.Point(208, 247)
        Me.cboVehicleType.Name = "cboVehicleType"
        Me.cboVehicleType.Size = New System.Drawing.Size(176, 24)
        Me.cboVehicleType.TabIndex = 8
        '
        'cboFuelType
        '
        Me.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuelType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuelType.Location = New System.Drawing.Point(208, 215)
        Me.cboFuelType.Name = "cboFuelType"
        Me.cboFuelType.Size = New System.Drawing.Size(176, 24)
        Me.cboFuelType.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(440, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(440, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Series No"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(440, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Location"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(440, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Driver Name"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(440, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "BTM"
        '
        'labe
        '
        Me.labe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labe.ForeColor = System.Drawing.Color.White
        Me.labe.Location = New System.Drawing.Point(440, 85)
        Me.labe.Name = "labe"
        Me.labe.Size = New System.Drawing.Size(128, 13)
        Me.labe.TabIndex = 28
        Me.labe.Text = "BDM/BGK"
        '
        'labelLicese
        '
        Me.labelLicese.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLicese.ForeColor = System.Drawing.Color.White
        Me.labelLicese.Location = New System.Drawing.Point(440, 52)
        Me.labelLicese.Name = "labelLicese"
        Me.labelLicese.Size = New System.Drawing.Size(152, 13)
        Me.labelLicese.TabIndex = 27
        Me.labelLicese.Text = "License Duration"
        '
        'labelRegist
        '
        Me.labelRegist.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegist.ForeColor = System.Drawing.Color.White
        Me.labelRegist.Location = New System.Drawing.Point(440, 20)
        Me.labelRegist.Name = "labelRegist"
        Me.labelRegist.Size = New System.Drawing.Size(152, 19)
        Me.labelRegist.TabIndex = 26
        Me.labelRegist.Text = "Year of Registration"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Year Manufacturer"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Vehicle Type"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fuel Type"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Engine Horsepower"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Model Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Manufacturer"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Chasis No"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Engine No"
        '
        'txtYearManufacturer
        '
        Me.txtYearManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearManufacturer.Location = New System.Drawing.Point(208, 280)
        Me.txtYearManufacturer.Name = "txtYearManufacturer"
        Me.txtYearManufacturer.Size = New System.Drawing.Size(48, 23)
        Me.txtYearManufacturer.TabIndex = 9
        Me.txtYearManufacturer.Text = ""
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(632, 247)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(176, 23)
        Me.txtStatus.TabIndex = 17
        Me.txtStatus.Text = ""
        '
        'txtSeriesNo
        '
        Me.txtSeriesNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeriesNo.Location = New System.Drawing.Point(632, 215)
        Me.txtSeriesNo.Name = "txtSeriesNo"
        Me.txtSeriesNo.Size = New System.Drawing.Size(176, 23)
        Me.txtSeriesNo.TabIndex = 16
        Me.txtSeriesNo.Text = ""
        '
        'txtDriverName
        '
        Me.txtDriverName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(632, 150)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(176, 23)
        Me.txtDriverName.TabIndex = 14
        Me.txtDriverName.Text = ""
        '
        'txtBTM
        '
        Me.txtBTM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTM.Location = New System.Drawing.Point(632, 117)
        Me.txtBTM.Name = "txtBTM"
        Me.txtBTM.Size = New System.Drawing.Size(176, 23)
        Me.txtBTM.TabIndex = 13
        Me.txtBTM.Text = ""
        '
        'txtBDM_BGK
        '
        Me.txtBDM_BGK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBDM_BGK.Location = New System.Drawing.Point(632, 85)
        Me.txtBDM_BGK.Name = "txtBDM_BGK"
        Me.txtBDM_BGK.Size = New System.Drawing.Size(176, 23)
        Me.txtBDM_BGK.TabIndex = 12
        Me.txtBDM_BGK.Text = ""
        '
        'txtEnginePower
        '
        Me.txtEnginePower.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnginePower.Location = New System.Drawing.Point(208, 182)
        Me.txtEnginePower.Name = "txtEnginePower"
        Me.txtEnginePower.Size = New System.Drawing.Size(176, 23)
        Me.txtEnginePower.TabIndex = 6
        Me.txtEnginePower.Text = ""
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(208, 150)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(176, 23)
        Me.txtModel.TabIndex = 5
        Me.txtModel.Text = ""
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(208, 117)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(176, 23)
        Me.txtManufacturer.TabIndex = 4
        Me.txtManufacturer.Text = ""
        '
        'txtChasisNo
        '
        Me.txtChasisNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChasisNo.Location = New System.Drawing.Point(208, 88)
        Me.txtChasisNo.Name = "txtChasisNo"
        Me.txtChasisNo.Size = New System.Drawing.Size(176, 23)
        Me.txtChasisNo.TabIndex = 3
        Me.txtChasisNo.Text = ""
        '
        'txtEngineNo
        '
        Me.txtEngineNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngineNo.Location = New System.Drawing.Point(208, 52)
        Me.txtEngineNo.Name = "txtEngineNo"
        Me.txtEngineNo.Size = New System.Drawing.Size(176, 23)
        Me.txtEngineNo.TabIndex = 1
        Me.txtEngineNo.Text = ""
        '
        'txtRegistrationNo
        '
        Me.txtRegistrationNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationNo.Location = New System.Drawing.Point(208, 20)
        Me.txtRegistrationNo.Name = "txtRegistrationNo"
        Me.txtRegistrationNo.Size = New System.Drawing.Size(176, 23)
        Me.txtRegistrationNo.TabIndex = 0
        Me.txtRegistrationNo.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration No"
        '
        'tabpage2
        '
        Me.tabpage2.BackColor = System.Drawing.Color.SteelBlue
        Me.tabpage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpage2.Controls.Add(Me.Label48)
        Me.tabpage2.Controls.Add(Me.cboDate)
        Me.tabpage2.Controls.Add(Me.cboMonth)
        Me.tabpage2.Controls.Add(Me.Label32)
        Me.tabpage2.Controls.Add(Me.Label33)
        Me.tabpage2.Controls.Add(Me.txtYear)
        Me.tabpage2.Controls.Add(Me.txtLicenseReferenceNo)
        Me.tabpage2.Controls.Add(Me.txtLPKPFileReferenceNo)
        Me.tabpage2.Controls.Add(Me.txtLPKPFormNo)
        Me.tabpage2.Controls.Add(Me.Label21)
        Me.tabpage2.Controls.Add(Me.Label20)
        Me.tabpage2.Controls.Add(Me.Label19)
        Me.tabpage2.Controls.Add(Me.Label18)
        Me.tabpage2.Location = New System.Drawing.Point(4, 27)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(896, 339)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "LPKP"
        Me.tabpage2.Visible = False
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(360, 120)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 20)
        Me.Label48.TabIndex = 26
        Me.Label48.Text = "(dd-mmm-yy)"
        '
        'cboDate
        '
        Me.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDate.Location = New System.Drawing.Point(208, 112)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(48, 24)
        Me.cboDate.TabIndex = 21
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Location = New System.Drawing.Point(264, 112)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(56, 24)
        Me.cboMonth.TabIndex = 22
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(320, 120)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(8, 16)
        Me.Label32.TabIndex = 25
        Me.Label32.Text = "-"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(256, 120)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(8, 16)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "-"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(328, 112)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(32, 23)
        Me.txtYear.TabIndex = 23
        Me.txtYear.Text = ""
        '
        'txtLicenseReferenceNo
        '
        Me.txtLicenseReferenceNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseReferenceNo.Location = New System.Drawing.Point(208, 85)
        Me.txtLicenseReferenceNo.Name = "txtLicenseReferenceNo"
        Me.txtLicenseReferenceNo.Size = New System.Drawing.Size(176, 23)
        Me.txtLicenseReferenceNo.TabIndex = 20
        Me.txtLicenseReferenceNo.Text = ""
        '
        'txtLPKPFileReferenceNo
        '
        Me.txtLPKPFileReferenceNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPKPFileReferenceNo.Location = New System.Drawing.Point(208, 52)
        Me.txtLPKPFileReferenceNo.Name = "txtLPKPFileReferenceNo"
        Me.txtLPKPFileReferenceNo.Size = New System.Drawing.Size(176, 23)
        Me.txtLPKPFileReferenceNo.TabIndex = 19
        Me.txtLPKPFileReferenceNo.Text = ""
        '
        'txtLPKPFormNo
        '
        Me.txtLPKPFormNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPKPFormNo.Location = New System.Drawing.Point(208, 20)
        Me.txtLPKPFormNo.Name = "txtLPKPFormNo"
        Me.txtLPKPFormNo.Size = New System.Drawing.Size(176, 23)
        Me.txtLPKPFormNo.TabIndex = 18
        Me.txtLPKPFormNo.Text = ""
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 35)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "License Expiry Date"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(16, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "License Reference No"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(16, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "File Reference No"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(16, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Form No"
        '
        'tabPage3
        '
        Me.tabPage3.BackColor = System.Drawing.Color.SteelBlue
        Me.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabPage3.Controls.Add(Me.Label51)
        Me.tabPage3.Controls.Add(Me.Label49)
        Me.tabPage3.Controls.Add(Me.Label47)
        Me.tabPage3.Controls.Add(Me.Label42)
        Me.tabPage3.Controls.Add(Me.Label41)
        Me.tabPage3.Controls.Add(Me.cboPolicyToDate)
        Me.tabPage3.Controls.Add(Me.cboPolicyToMonth)
        Me.tabPage3.Controls.Add(Me.Label38)
        Me.tabPage3.Controls.Add(Me.Label39)
        Me.tabPage3.Controls.Add(Me.txtPolicyToYear)
        Me.tabPage3.Controls.Add(Me.cboPolicyFromDate)
        Me.tabPage3.Controls.Add(Me.cboPolicyFromMonth)
        Me.tabPage3.Controls.Add(Me.Label36)
        Me.tabPage3.Controls.Add(Me.Label37)
        Me.tabPage3.Controls.Add(Me.txtPolicyFromYear)
        Me.tabPage3.Controls.Add(Me.Label12)
        Me.tabPage3.Controls.Add(Me.Label11)
        Me.tabPage3.Controls.Add(Me.Label28)
        Me.tabPage3.Controls.Add(Me.txtTotalPayable)
        Me.tabPage3.Controls.Add(Me.Label26)
        Me.tabPage3.Controls.Add(Me.Label27)
        Me.tabPage3.Controls.Add(Me.txtNCT_DTT)
        Me.tabPage3.Controls.Add(Me.txtBasicPremium)
        Me.tabPage3.Controls.Add(Me.Label22)
        Me.tabPage3.Controls.Add(Me.Label23)
        Me.tabPage3.Controls.Add(Me.Label24)
        Me.tabPage3.Controls.Add(Me.Label25)
        Me.tabPage3.Controls.Add(Me.txtExcessApplicable)
        Me.tabPage3.Controls.Add(Me.txtVehicleSum)
        Me.tabPage3.Controls.Add(Me.txtPolicyNo)
        Me.tabPage3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPage3.Location = New System.Drawing.Point(4, 27)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(896, 339)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Insurance"
        Me.tabPage3.Visible = False
        '
        'Label51
        '
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(208, 88)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(32, 24)
        Me.Label51.TabIndex = 46
        Me.Label51.Text = "RM:"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(576, 64)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(80, 20)
        Me.Label49.TabIndex = 45
        Me.Label49.Text = "(dd-mmm-yy)"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.SteelBlue
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(288, 184)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(32, 24)
        Me.Label47.TabIndex = 44
        Me.Label47.Text = "%"
        '
        'Label42
        '
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(208, 152)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 24)
        Me.Label42.TabIndex = 43
        Me.Label42.Text = "RM:"
        '
        'Label41
        '
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(208, 216)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(32, 24)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "RM:"
        '
        'cboPolicyToDate
        '
        Me.cboPolicyToDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolicyToDate.Location = New System.Drawing.Point(424, 56)
        Me.cboPolicyToDate.Name = "cboPolicyToDate"
        Me.cboPolicyToDate.Size = New System.Drawing.Size(48, 24)
        Me.cboPolicyToDate.TabIndex = 37
        '
        'cboPolicyToMonth
        '
        Me.cboPolicyToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolicyToMonth.Location = New System.Drawing.Point(480, 56)
        Me.cboPolicyToMonth.Name = "cboPolicyToMonth"
        Me.cboPolicyToMonth.Size = New System.Drawing.Size(56, 24)
        Me.cboPolicyToMonth.TabIndex = 38
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(536, 64)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(8, 16)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "-"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(472, 64)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(8, 16)
        Me.Label39.TabIndex = 40
        Me.Label39.Text = "-"
        '
        'txtPolicyToYear
        '
        Me.txtPolicyToYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicyToYear.Location = New System.Drawing.Point(544, 56)
        Me.txtPolicyToYear.Name = "txtPolicyToYear"
        Me.txtPolicyToYear.Size = New System.Drawing.Size(32, 23)
        Me.txtPolicyToYear.TabIndex = 39
        Me.txtPolicyToYear.Text = ""
        '
        'cboPolicyFromDate
        '
        Me.cboPolicyFromDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolicyFromDate.Location = New System.Drawing.Point(240, 56)
        Me.cboPolicyFromDate.Name = "cboPolicyFromDate"
        Me.cboPolicyFromDate.Size = New System.Drawing.Size(48, 24)
        Me.cboPolicyFromDate.TabIndex = 32
        '
        'cboPolicyFromMonth
        '
        Me.cboPolicyFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolicyFromMonth.Location = New System.Drawing.Point(296, 56)
        Me.cboPolicyFromMonth.Name = "cboPolicyFromMonth"
        Me.cboPolicyFromMonth.Size = New System.Drawing.Size(56, 24)
        Me.cboPolicyFromMonth.TabIndex = 33
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(352, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(8, 16)
        Me.Label36.TabIndex = 36
        Me.Label36.Text = "-"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(288, 64)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(8, 16)
        Me.Label37.TabIndex = 35
        Me.Label37.Text = "-"
        '
        'txtPolicyFromYear
        '
        Me.txtPolicyFromYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicyFromYear.Location = New System.Drawing.Point(360, 56)
        Me.txtPolicyFromYear.Name = "txtPolicyFromYear"
        Me.txtPolicyFromYear.Size = New System.Drawing.Size(24, 23)
        Me.txtPolicyFromYear.TabIndex = 34
        Me.txtPolicyFromYear.Text = ""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(392, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 24)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "To"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(192, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 24)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "From"
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(16, 216)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 24)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Total Payable"
        '
        'txtTotalPayable
        '
        Me.txtTotalPayable.Location = New System.Drawing.Point(240, 216)
        Me.txtTotalPayable.Name = "txtTotalPayable"
        Me.txtTotalPayable.Size = New System.Drawing.Size(48, 23)
        Me.txtTotalPayable.TabIndex = 28
        Me.txtTotalPayable.Text = ""
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(16, 184)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 24)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "NCT/DTT"
        '
        'Label27
        '
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(16, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Basic Premium"
        '
        'txtNCT_DTT
        '
        Me.txtNCT_DTT.Location = New System.Drawing.Point(240, 184)
        Me.txtNCT_DTT.Name = "txtNCT_DTT"
        Me.txtNCT_DTT.Size = New System.Drawing.Size(48, 23)
        Me.txtNCT_DTT.TabIndex = 27
        Me.txtNCT_DTT.Text = ""
        '
        'txtBasicPremium
        '
        Me.txtBasicPremium.Location = New System.Drawing.Point(240, 152)
        Me.txtBasicPremium.Name = "txtBasicPremium"
        Me.txtBasicPremium.Size = New System.Drawing.Size(48, 23)
        Me.txtBasicPremium.TabIndex = 26
        Me.txtBasicPremium.Text = ""
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(16, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 24)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Excess Applicable"
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(16, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Vehicle Sum"
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(16, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 24)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Policy Period"
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(16, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 16)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Policy No Insurance"
        '
        'txtExcessApplicable
        '
        Me.txtExcessApplicable.Location = New System.Drawing.Point(240, 120)
        Me.txtExcessApplicable.Name = "txtExcessApplicable"
        Me.txtExcessApplicable.Size = New System.Drawing.Size(48, 23)
        Me.txtExcessApplicable.TabIndex = 25
        Me.txtExcessApplicable.Text = ""
        '
        'txtVehicleSum
        '
        Me.txtVehicleSum.Location = New System.Drawing.Point(240, 88)
        Me.txtVehicleSum.Name = "txtVehicleSum"
        Me.txtVehicleSum.Size = New System.Drawing.Size(48, 23)
        Me.txtVehicleSum.TabIndex = 24
        Me.txtVehicleSum.Text = ""
        '
        'txtPolicyNo
        '
        Me.txtPolicyNo.Location = New System.Drawing.Point(240, 24)
        Me.txtPolicyNo.Name = "txtPolicyNo"
        Me.txtPolicyNo.Size = New System.Drawing.Size(144, 23)
        Me.txtPolicyNo.TabIndex = 22
        Me.txtPolicyNo.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.cboAM_PM)
        Me.TabPage4.Controls.Add(Me.Label45)
        Me.TabPage4.Controls.Add(Me.txtMin)
        Me.TabPage4.Controls.Add(Me.cboHour)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.cboInspectDate)
        Me.TabPage4.Controls.Add(Me.cboInspectMonth)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.txtInspectYear)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(896, 339)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Puspacom"
        Me.TabPage4.Visible = False
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(360, 24)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(80, 20)
        Me.Label50.TabIndex = 43
        Me.Label50.Text = "(dd-mmm-yy)"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(352, 56)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(104, 16)
        Me.Label46.TabIndex = 42
        Me.Label46.Text = "(e.g 9:20:PM)"
        '
        'cboAM_PM
        '
        Me.cboAM_PM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAM_PM.Location = New System.Drawing.Point(304, 48)
        Me.cboAM_PM.Name = "cboAM_PM"
        Me.cboAM_PM.Size = New System.Drawing.Size(48, 24)
        Me.cboAM_PM.TabIndex = 41
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(296, 48)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(8, 24)
        Me.Label45.TabIndex = 40
        Me.Label45.Text = ":"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(264, 48)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(32, 22)
        Me.txtMin.TabIndex = 38
        Me.txtMin.Text = "00"
        '
        'cboHour
        '
        Me.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHour.Location = New System.Drawing.Point(208, 48)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(48, 24)
        Me.cboHour.TabIndex = 37
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(256, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(8, 24)
        Me.Label40.TabIndex = 36
        Me.Label40.Text = ":"
        '
        'cboInspectDate
        '
        Me.cboInspectDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInspectDate.Location = New System.Drawing.Point(208, 16)
        Me.cboInspectDate.Name = "cboInspectDate"
        Me.cboInspectDate.Size = New System.Drawing.Size(48, 24)
        Me.cboInspectDate.TabIndex = 31
        '
        'cboInspectMonth
        '
        Me.cboInspectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInspectMonth.Location = New System.Drawing.Point(264, 16)
        Me.cboInspectMonth.Name = "cboInspectMonth"
        Me.cboInspectMonth.Size = New System.Drawing.Size(56, 24)
        Me.cboInspectMonth.TabIndex = 32
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(320, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(8, 16)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "-"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(256, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(8, 16)
        Me.Label35.TabIndex = 34
        Me.Label35.Text = "-"
        '
        'txtInspectYear
        '
        Me.txtInspectYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspectYear.Location = New System.Drawing.Point(328, 16)
        Me.txtInspectYear.Name = "txtInspectYear"
        Me.txtInspectYear.Size = New System.Drawing.Size(32, 23)
        Me.txtInspectYear.TabIndex = 33
        Me.txtInspectYear.Text = ""
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(8, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 13)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "Inspection Time"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(8, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 13)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Inspection Date"
        '
        'Label52
        '
        Me.Label52.ForeColor = System.Drawing.Color.Yellow
        Me.Label52.Location = New System.Drawing.Point(192, 24)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(8, 16)
        Me.Label52.TabIndex = 37
        Me.Label52.Text = "*"
        '
        'frmMotorAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(984, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMotorAdd"
        Me.Text = "Motor add record"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame.ResumeLayout(False)
        Me.tab.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        Me.tabpage2.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'error prevention techniques
        enable_object()
        cmdAdd.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = False

        txtRegistrationNo.Focus()


    End Sub
    Public Sub enable_object()
        txtRegistrationNo.Enabled = True
        txtEngineNo.Enabled = True
        txtChasisNo.Enabled = True
        txtManufacturer.Enabled = True
        txtModel.Enabled = True
        txtEnginePower.Enabled = True
        cboFuelType.Enabled = True
        cboVehicleType.Enabled = True
        txtYearManufacturer.Enabled = True
        txtYearRegistration.Enabled = True
        cboLicenseDuration.Enabled = True
        txtBDM_BGK.Enabled = True
        txtBTM.Enabled = True
        txtDriverName.Enabled = True
        cboLocation.Enabled = True
        txtSeriesNo.Enabled = True
        txtStatus.Enabled = True
        txtLPKPFormNo.Enabled = True
        txtLPKPFileReferenceNo.Enabled = True
        txtLicenseReferenceNo.Enabled = True
        cboDate.Enabled = True
        cboMonth.Enabled = True
        txtYear.Enabled = True
        txtPolicyNo.Enabled = True
        cboPolicyFromDate.Enabled = True
        cboPolicyFromMonth.Enabled = True
        txtPolicyFromYear.Enabled = True
        cboPolicyToDate.Enabled = True
        cboPolicyToMonth.Enabled = True
        txtPolicyToYear.Enabled = True
        txtVehicleSum.Enabled = True
        txtExcessApplicable.Enabled = True
        txtBasicPremium.Enabled = True
        txtNCT_DTT.Enabled = True
        txtTotalPayable.Enabled = True
        cboInspectDate.Enabled = True
        cboInspectMonth.Enabled = True
        txtInspectYear.Enabled = True
        cboHour.Enabled = True
        txtMin.Enabled = True
        cboAM_PM.Enabled = True

    End Sub
    Public Sub disable_object()
        txtRegistrationNo.Enabled = False
        txtEngineNo.Enabled = False
        txtChasisNo.Enabled = False
        txtManufacturer.Enabled = False
        txtModel.Enabled = False
        txtEnginePower.Enabled = False
        cboFuelType.Enabled = False
        cboVehicleType.Enabled = False
        txtYearManufacturer.Enabled = False
        txtYearRegistration.Enabled = False
        cboLicenseDuration.Enabled = False
        txtBDM_BGK.Enabled = False
        txtBTM.Enabled = False
        txtDriverName.Enabled = False
        cboLocation.Enabled = False
        txtSeriesNo.Enabled = False
        txtStatus.Enabled = False
        txtLPKPFormNo.Enabled = False
        txtLPKPFileReferenceNo.Enabled = False
        txtLicenseReferenceNo.Enabled = False
        cboDate.Enabled = False
        cboMonth.Enabled = False
        txtYear.Enabled = False
        txtPolicyNo.Enabled = False
        cboPolicyFromDate.Enabled = False
        cboPolicyFromMonth.Enabled = False
        txtPolicyFromYear.Enabled = False
        cboPolicyToDate.Enabled = False
        cboPolicyToMonth.Enabled = False
        txtPolicyToYear.Enabled = False
        txtVehicleSum.Enabled = False
        txtExcessApplicable.Enabled = False
        txtBasicPremium.Enabled = False
        txtNCT_DTT.Enabled = False
        txtTotalPayable.Enabled = False
        cboInspectDate.Enabled = False
        cboInspectMonth.Enabled = False
        txtInspectYear.Enabled = False
        cboHour.Enabled = False
        txtMin.Enabled = False
        cboAM_PM.Enabled = False

    End Sub
    Public Sub clear_object()
        txtRegistrationNo.Text = ""
        txtEngineNo.Text = ""
        txtChasisNo.Text = ""
        txtManufacturer.Text = ""
        txtModel.Text = ""
        txtEnginePower.Text = ""
        cboFuelType.Text = ""
        cboVehicleType.Text = ""
        txtYearManufacturer.Text = ""
        txtYearRegistration.Text = ""
        cboLicenseDuration.Items.Clear()
        txtBDM_BGK.Text = ""
        txtBTM.Text = ""
        txtDriverName.Text = ""
        cboLocation.Text = ""
        txtSeriesNo.Text = ""
        txtStatus.Text = ""
        txtLPKPFormNo.Text = ""
        txtLPKPFileReferenceNo.Text = ""
        txtLicenseReferenceNo.Text = ""
        cboDate.Text = ""
        cboMonth.Text = ""
        txtYear.Text = ""
        txtPolicyNo.Text = ""
        cboDate.Items.Clear()
        cboMonth.Items.Clear()
        txtYear.Text = ""
        cboPolicyFromDate.Items.Clear()
        cboPolicyFromMonth.Items.Clear()
        txtPolicyFromYear.Text = ""
        cboPolicyToDate.Items.Clear()
        cboPolicyToMonth.Items.Clear()
        txtPolicyToYear.Text = ""
        txtVehicleSum.Text = ""
        txtExcessApplicable.Text = ""
        txtBasicPremium.Text = ""
        txtNCT_DTT.Text = ""
        txtTotalPayable.Text = ""
        cboInspectDate.Items.Clear()
        cboInspectMonth.Items.Clear()
        txtInspectYear.Text = ""
        cboHour.Items.Clear()
        txtMin.Text = ""
        cboAM_PM.Items.Clear()

    End Sub

    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'validation 
        If txtRegistrationNo.Text = "" Then
            MessageBox.Show("Unable to add record!Please make sure registration No Is filled", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRegistrationNo.Text = ""
            txtRegistrationNo.Focus()
            Exit Sub
            'ElseIf txtYearManufacturer.Text <> "" Then
            '    If Len(txtYearManufacturer.Text) <> 4 Then
            '        MessageBox.Show("Year must be 4 Digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        txtYearManufacturer.Text = ""
            '        txtYearManufacturer.Focus()

            '    End If
            'ElseIf txtYearRegistration.Text <> "" Then
            '    If Len(txtYearRegistration.Text) <> 4 Then
            '        MessageBox.Show("Year must be 4 Digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        txtYearRegistration.Text = ""
            '        txtYearRegistration.Focus()

            '    End If

        ElseIf txtYearManufacturer.Text <> "" And Not IsNumeric(txtYearManufacturer.Text) Then
                MessageBox.Show("Please enter valid year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtYearManufacturer.Text = ""
                txtYearManufacturer.Focus()
            Exit Sub
        ElseIf txtYearRegistration.Text <> "" And Not IsNumeric(txtYearRegistration.Text) Then
            MessageBox.Show("Please enter valid year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYearRegistration.Text = ""
            txtYearRegistration.Focus()
            Exit Sub

        ElseIf txtYearRegistration.Text <> "" And txtYearManufacturer.Text <> "" And txtYearRegistration.Text < txtYearManufacturer.Text Then
            MessageBox.Show("Manufacturer year must not be later then registration date", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYearRegistration.Text = ""
            txtYearManufacturer.Text = ""
            txtYearManufacturer.Focus()
            Exit Sub

        ElseIf (txtMin.Text) > 60 Then
            MessageBox.Show("Please Enter a valid minutes", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMin.Text = ""
            txtMin.Focus()
            Exit Sub
        Else
            Try
                conn = New MySqlConnection
                conn.ConnectionString = "server=localhost;" _
                  & "username=root;" _
                  & "password=admin;" _
                  & "database=in-out "
                conn.Open()
                SQLMOTORADD = "INSERT INTO motorinsurance VALUES('" & txtRegistrationNo.Text & "','" & txtEngineNo.Text & "','" & txtChasisNo.Text & "'," _
                            & "'" & txtManufacturer.Text & "','" & txtModel.Text & "','" & txtEnginePower.Text & "','" & cboFuelType.Text & "'," _
                            & "'" & cboVehicleType.Text & "','" & txtYearManufacturer.Text & "','" & txtYearRegistration.Text & "','" & cboLicenseDuration.Text & "'," _
                            & "'" & txtBDM_BGK.Text & "','" & txtBTM.Text & "','" & txtDriverName.Text & "','" & cboLocation.Text & "','" & txtSeriesNo.Text & "'," _
                            & "'" & txtStatus.Text & "','" & txtLPKPFormNo.Text & "','" & txtLPKPFileReferenceNo.Text & "','" & txtLicenseReferenceNo.Text & "','" & cboDate.Text & "-" & cboMonth.Text & "-" & txtYear.Text & "'," _
                            & "'" & txtPolicyNo.Text & "','" & cboPolicyFromDate.Text & "-" & cboPolicyFromMonth.Text & "-" & txtPolicyFromYear.Text & " ','" & cboPolicyToDate.Text & "-" & cboPolicyToMonth.Text & "-" & txtPolicyToYear.Text & "','" & "RM" & txtVehicleSum.Text & "','" & txtExcessApplicable.Text & "','" & "RM" & txtBasicPremium.Text & "'," _
                            & "'" & txtNCT_DTT.Text & "%" & "','" & "RM" & txtTotalPayable.Text & "','" & cboInspectDate.Text & "-" & cboInspectMonth.Text & "-" & txtInspectYear.Text & " ' ,'" & cboHour.Text & ":" & txtMin.Text & ":" & cboAM_PM.Text & "')"


                cmd = New MySqlCommand(SQLMOTORADD, conn)
                hasil = cmd.ExecuteNonQuery()
                MessageBox.Show("Information has been succesfully Added Into Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                conn.Dispose()



            Catch ex As Exception
                MessageBox.Show("Registration No is already Exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRegistrationNo.Focus()
                Exit Sub
            End Try


            'error prevention techniques
            disable_object()
            myDataFuel.Clear()
            myDataVehicle.Clear()
            myDataLocation.Clear()
            clear_object() '
            cmdSave.Enabled = False
            cmdAdd.Enabled = True
            cmdCancel.Enabled = False

        End If
    End Sub

    Private Sub cmdAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'error prevention techniques
        enable_object()
        cmdAdd.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True

        txtRegistrationNo.Focus()
    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        clear_object()
        myDataFuel.Clear()
        myDataVehicle.Clear()
        myDataLocation.Clear()
        disable_object()
        cmdAdd.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False

    End Sub
    Private Sub cboFuelType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFuelType.GotFocus

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "


        'load fuel type
        SQLLoadFuel = "select FuelType From fuel"                 'select table"
        myCommandFuel.Connection = conn                                     'initialize connection or select which connection to use
        conn.Open() 'open connection                  
        myCommandFuel.CommandText = SQLLoadFuel                  'tell command which sql statement to execute
        myAdapterFuel.SelectCommand = myCommandFuel                        'execute command
        myDataFuel.Clear()
        myAdapterFuel.Fill(myDataFuel)                                          'fill into mydata temp container

        cboFuelType.DataSource = myDataFuel
        cboFuelType.DisplayMember = "fuel"
        cboFuelType.ValueMember = "FuelType"

        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub cboVehicleType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVehicleType.GotFocus

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "


        'load vehicle type
        SQLLoadVehicle = "select VehicleType from vehicle"                  'select table"
        myCommandVehicle.Connection = conn                                     'initialize connection or select which connection to use
        conn.Open() 'open connection                  
        myCommandVehicle.CommandText = SQLLoadVehicle                   'tell command which sql statement to execute
        myAdapterVehicle.SelectCommand = myCommandVehicle                        'execute command
        myDataVehicle.Clear()
        myAdapterVehicle.Fill(myDataVehicle)                                          'fill into mydata temp container

        cboVehicleType.DataSource = myDataVehicle
        cboVehicleType.DisplayMember = "vehicle"
        cboVehicleType.ValueMember = "VehicleType"

        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub cboLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocation.GotFocus

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "



        'load Location
        SQLLoadLocation = "select Location from location"                  'select table"
        myCommandLocation.Connection = conn                                     'initialize connection or select which connection to use
        conn.Open() 'open connection                  
        myCommandLocation.CommandText = SQLLoadLocation                   'tell command which sql statement to execute
        myAdapterLocation.SelectCommand = myCommandLocation                        'execute command
        myDataLocation.Clear()
        myAdapterLocation.Fill(myDataLocation)                                          'fill into mydata temp container

        cboLocation.DataSource = myDataLocation
        cboLocation.DisplayMember = "location"
        cboLocation.ValueMember = "Location"


        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub cboDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDate.GotFocus


        Dim a As Integer
        For a = 1 To 31
            cboDate.Items.Add(a)

        Next
    End Sub


    Private Sub cboMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMonth.GotFocus
        cboMonth.Items.Add("Jan")
        cboMonth.Items.Add("Feb")
        cboMonth.Items.Add("Mar")
        cboMonth.Items.Add("Apr")
        cboMonth.Items.Add("Jun")
        cboMonth.Items.Add("Jul")
        cboMonth.Items.Add("Aug")
        cboMonth.Items.Add("Sep")
        cboMonth.Items.Add("Oct")
        cboMonth.Items.Add("Nov")
        cboMonth.Items.Add("Dec")
    End Sub

    Private Sub cboPolicyFromDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPolicyFromDate.GotFocus
        Dim a As Integer
        For a = 1 To 31
            cboPolicyFromDate.Items.Add(a)
        Next
    End Sub


    Private Sub cboPolicyFromMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPolicyFromMonth.GotFocus
        cboPolicyFromMonth.Items.Add("Jan")
        cboPolicyFromMonth.Items.Add("Feb")
        cboPolicyFromMonth.Items.Add("Apr")
        cboPolicyFromMonth.Items.Add("Jun")
        cboPolicyFromMonth.Items.Add("Jul")
        cboPolicyFromMonth.Items.Add("Aug")
        cboPolicyFromMonth.Items.Add("Sep")
        cboPolicyFromMonth.Items.Add("Oct")
        cboPolicyFromMonth.Items.Add("Nov")
    End Sub


    Private Sub cboPolicyToDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPolicyToDate.GotFocus
        Dim a As Integer
        For a = 1 To 31
            cboPolicyToDate.Items.Add(a)
        Next
    End Sub


    Private Sub cboPolicyToMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPolicyToMonth.GotFocus
        cboPolicyToMonth.Items.Add("Jan")
        cboPolicyToMonth.Items.Add("Feb")
        cboPolicyToMonth.Items.Add("Apr")
        cboPolicyToMonth.Items.Add("Jun")
        cboPolicyToMonth.Items.Add("Jul")
        cboPolicyToMonth.Items.Add("Aug")
        cboPolicyToMonth.Items.Add("Sep")
        cboPolicyToMonth.Items.Add("Oct")
        cboPolicyToMonth.Items.Add("Nov")
        cboPolicyToMonth.Items.Add("Dec")
    End Sub


    Private Sub cboInspectDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInspectDate.GotFocus
        Dim a As Integer
        For a = 1 To 31
            cboInspectDate.Items.Add(a)
        Next
    End Sub


    Private Sub cboInspectMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInspectMonth.GotFocus
        cboInspectMonth.Items.Add("Jan")
        cboInspectMonth.Items.Add("Feb")
        cboInspectMonth.Items.Add("Apr")
        cboInspectMonth.Items.Add("Jun")
        cboInspectMonth.Items.Add("Jul")
        cboInspectMonth.Items.Add("Aug")
        cboInspectMonth.Items.Add("Sep")
        cboInspectMonth.Items.Add("Oct")
        cboInspectMonth.Items.Add("Nov")
        cboInspectMonth.Items.Add("Dec")
    End Sub


    Private Sub cboLicenseDuration_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLicenseDuration.GotFocus
        cboLicenseDuration.Items.Clear()
        cboLicenseDuration.Items.Add("6 Months")
        cboLicenseDuration.Items.Add("12 Months")
    End Sub


    Private Sub cboHour_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHour.GotFocus
        Dim i As Integer
        For i = 1 To 24
            cboHour.Items.Add(i)
        Next
    End Sub


    Private Sub cboAM_PM_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAM_PM.GotFocus
        cboAM_PM.Items.Add("AM")
        cboAM_PM.Items.Add("PM")
    End Sub

    Private Sub Frame_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame.Enter

    End Sub

    Private Sub txtChasisNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChasisNo.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
