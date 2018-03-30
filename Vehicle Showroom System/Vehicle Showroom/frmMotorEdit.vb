Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmMotorEdit
    Inherits System.Windows.Forms.Form
    Dim conn As New MySqlConnection
    Dim hasil As Integer
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQLLoadRegistrationNo As String
    Dim SQLUpdate As String




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
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
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
    Friend WithEvents txtLicenseDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtEnginePower As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtChasisNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEngineNo As System.Windows.Forms.TextBox
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtLicenseExpiry As System.Windows.Forms.TextBox
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
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtExcessApplicable As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleSum As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicyNo As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtInspectionTime As System.Windows.Forms.TextBox
    Friend WithEvents txtInspectionDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboRegistrationNo As System.Windows.Forms.ComboBox
    Friend WithEvents frame As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtPolicyPeriodTo As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicyPeriodFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMotorEdit))
        Me.frame = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cboRegistrationNo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.tab = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
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
        Me.txtLicenseDuration = New System.Windows.Forms.TextBox
        Me.txtEnginePower = New System.Windows.Forms.TextBox
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtManufacturer = New System.Windows.Forms.TextBox
        Me.txtChasisNo = New System.Windows.Forms.TextBox
        Me.txtEngineNo = New System.Windows.Forms.TextBox
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtLicenseExpiry = New System.Windows.Forms.TextBox
        Me.txtLicenseReferenceNo = New System.Windows.Forms.TextBox
        Me.txtLPKPFileReferenceNo = New System.Windows.Forms.TextBox
        Me.txtLPKPFormNo = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtPolicyPeriodTo = New System.Windows.Forms.TextBox
        Me.txtPolicyPeriodFrom = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalPayable = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtNCT_DTT = New System.Windows.Forms.TextBox
        Me.txtBasicPremium = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtExcessApplicable = New System.Windows.Forms.TextBox
        Me.txtVehicleSum = New System.Windows.Forms.TextBox
        Me.txtPolicyNo = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtInspectionTime = New System.Windows.Forms.TextBox
        Me.txtInspectionDate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.frame.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        Me.tabpage2.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'frame
        '
        Me.frame.BackColor = System.Drawing.Color.SteelBlue
        Me.frame.Controls.Add(Me.Button1)
        Me.frame.Controls.Add(Me.PictureBox2)
        Me.frame.Controls.Add(Me.Label33)
        Me.frame.Controls.Add(Me.cmdDelete)
        Me.frame.Controls.Add(Me.cboRegistrationNo)
        Me.frame.Controls.Add(Me.Label10)
        Me.frame.Controls.Add(Me.cmdCancel)
        Me.frame.Controls.Add(Me.cmdSave)
        Me.frame.Controls.Add(Me.cmdEdit)
        Me.frame.Controls.Add(Me.tab)
        Me.frame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.frame.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame.Location = New System.Drawing.Point(64, 46)
        Me.frame.Name = "frame"
        Me.frame.Size = New System.Drawing.Size(856, 429)
        Me.frame.TabIndex = 1
        Me.frame.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 376)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label33.Location = New System.Drawing.Point(48, 376)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(600, 13)
        Me.Label33.TabIndex = 35
        Me.Label33.Text = "To start editing click the edit button"
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(480, 400)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 19)
        Me.cmdDelete.TabIndex = 33
        Me.cmdDelete.Text = "Delete"
        '
        'cboRegistrationNo
        '
        Me.cboRegistrationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegistrationNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegistrationNo.Location = New System.Drawing.Point(336, 20)
        Me.cboRegistrationNo.Name = "cboRegistrationNo"
        Me.cboRegistrationNo.Size = New System.Drawing.Size(168, 24)
        Me.cboRegistrationNo.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Please Select Registration Number to Start Editing"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(584, 400)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 19)
        Me.cmdCancel.TabIndex = 34
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(384, 400)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 19)
        Me.cmdSave.TabIndex = 32
        Me.cmdSave.Text = "Save"
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(280, 400)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(88, 19)
        Me.cmdEdit.TabIndex = 0
        Me.cmdEdit.Text = "Edit"
        '
        'tab
        '
        Me.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tab.Controls.Add(Me.tabpage1)
        Me.tab.Controls.Add(Me.tabpage2)
        Me.tab.Controls.Add(Me.tabPage3)
        Me.tab.Controls.Add(Me.TabPage4)
        Me.tab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.ItemSize = New System.Drawing.Size(202, 23)
        Me.tab.Location = New System.Drawing.Point(16, 52)
        Me.tab.Name = "tab"
        Me.tab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(824, 319)
        Me.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab.TabIndex = 3
        '
        'tabpage1
        '
        Me.tabpage1.BackColor = System.Drawing.Color.SteelBlue
        Me.tabpage1.Controls.Add(Me.Label44)
        Me.tabpage1.Controls.Add(Me.Label43)
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
        Me.tabpage1.Controls.Add(Me.txtLicenseDuration)
        Me.tabpage1.Controls.Add(Me.txtEnginePower)
        Me.tabpage1.Controls.Add(Me.txtModel)
        Me.tabpage1.Controls.Add(Me.txtManufacturer)
        Me.tabpage1.Controls.Add(Me.txtChasisNo)
        Me.tabpage1.Controls.Add(Me.txtEngineNo)
        Me.tabpage1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpage1.Location = New System.Drawing.Point(4, 27)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(816, 288)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "JPJ"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(696, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 37
        Me.Label44.Text = "(e.g 2002)"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(320, 256)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(72, 16)
        Me.Label43.TabIndex = 36
        Me.Label43.Text = "(e.g 1999)"
        '
        'txtYearRegistration
        '
        Me.txtYearRegistration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearRegistration.Location = New System.Drawing.Point(536, 16)
        Me.txtYearRegistration.Name = "txtYearRegistration"
        Me.txtYearRegistration.Size = New System.Drawing.Size(160, 23)
        Me.txtYearRegistration.TabIndex = 10
        Me.txtYearRegistration.Text = ""
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.Location = New System.Drawing.Point(536, 184)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(160, 24)
        Me.cboLocation.TabIndex = 15
        '
        'cboVehicleType
        '
        Me.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleType.Location = New System.Drawing.Point(160, 215)
        Me.cboVehicleType.Name = "cboVehicleType"
        Me.cboVehicleType.Size = New System.Drawing.Size(160, 24)
        Me.cboVehicleType.TabIndex = 8
        '
        'cboFuelType
        '
        Me.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuelType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuelType.Location = New System.Drawing.Point(160, 182)
        Me.cboFuelType.Name = "cboFuelType"
        Me.cboFuelType.Size = New System.Drawing.Size(160, 24)
        Me.cboFuelType.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(400, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(400, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Series No"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(400, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Location"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(400, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Driver Name"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(400, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "BTM"
        '
        'labe
        '
        Me.labe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labe.ForeColor = System.Drawing.Color.White
        Me.labe.Location = New System.Drawing.Point(400, 80)
        Me.labe.Name = "labe"
        Me.labe.Size = New System.Drawing.Size(104, 13)
        Me.labe.TabIndex = 28
        Me.labe.Text = "BDM/BGK"
        '
        'labelLicese
        '
        Me.labelLicese.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLicese.ForeColor = System.Drawing.Color.White
        Me.labelLicese.Location = New System.Drawing.Point(400, 48)
        Me.labelLicese.Name = "labelLicese"
        Me.labelLicese.Size = New System.Drawing.Size(128, 13)
        Me.labelLicese.TabIndex = 27
        Me.labelLicese.Text = "License Duration"
        '
        'labelRegist
        '
        Me.labelRegist.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegist.ForeColor = System.Drawing.Color.White
        Me.labelRegist.Location = New System.Drawing.Point(400, 16)
        Me.labelRegist.Name = "labelRegist"
        Me.labelRegist.Size = New System.Drawing.Size(128, 13)
        Me.labelRegist.TabIndex = 26
        Me.labelRegist.Text = "Year of Registration"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Year Manufacturer"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Vehicle Type"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fuel Type"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Engine Horsepower"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Model Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Manufacturer"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Chasis No"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Engine No"
        '
        'txtYearManufacturer
        '
        Me.txtYearManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearManufacturer.Location = New System.Drawing.Point(160, 247)
        Me.txtYearManufacturer.Name = "txtYearManufacturer"
        Me.txtYearManufacturer.Size = New System.Drawing.Size(160, 23)
        Me.txtYearManufacturer.TabIndex = 9
        Me.txtYearManufacturer.Text = ""
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(536, 248)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(160, 23)
        Me.txtStatus.TabIndex = 17
        Me.txtStatus.Text = ""
        '
        'txtSeriesNo
        '
        Me.txtSeriesNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeriesNo.Location = New System.Drawing.Point(536, 216)
        Me.txtSeriesNo.Name = "txtSeriesNo"
        Me.txtSeriesNo.Size = New System.Drawing.Size(160, 23)
        Me.txtSeriesNo.TabIndex = 16
        Me.txtSeriesNo.Text = ""
        '
        'txtDriverName
        '
        Me.txtDriverName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(536, 152)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(160, 23)
        Me.txtDriverName.TabIndex = 14
        Me.txtDriverName.Text = ""
        '
        'txtBTM
        '
        Me.txtBTM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTM.Location = New System.Drawing.Point(536, 112)
        Me.txtBTM.Name = "txtBTM"
        Me.txtBTM.Size = New System.Drawing.Size(160, 23)
        Me.txtBTM.TabIndex = 13
        Me.txtBTM.Text = ""
        '
        'txtBDM_BGK
        '
        Me.txtBDM_BGK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBDM_BGK.Location = New System.Drawing.Point(536, 80)
        Me.txtBDM_BGK.Name = "txtBDM_BGK"
        Me.txtBDM_BGK.Size = New System.Drawing.Size(160, 23)
        Me.txtBDM_BGK.TabIndex = 12
        Me.txtBDM_BGK.Text = ""
        '
        'txtLicenseDuration
        '
        Me.txtLicenseDuration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseDuration.Location = New System.Drawing.Point(536, 48)
        Me.txtLicenseDuration.Name = "txtLicenseDuration"
        Me.txtLicenseDuration.Size = New System.Drawing.Size(160, 23)
        Me.txtLicenseDuration.TabIndex = 11
        Me.txtLicenseDuration.Text = ""
        '
        'txtEnginePower
        '
        Me.txtEnginePower.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnginePower.Location = New System.Drawing.Point(160, 150)
        Me.txtEnginePower.Name = "txtEnginePower"
        Me.txtEnginePower.Size = New System.Drawing.Size(160, 23)
        Me.txtEnginePower.TabIndex = 6
        Me.txtEnginePower.Text = ""
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(160, 117)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(160, 23)
        Me.txtModel.TabIndex = 5
        Me.txtModel.Text = ""
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(160, 85)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(160, 23)
        Me.txtManufacturer.TabIndex = 4
        Me.txtManufacturer.Text = ""
        '
        'txtChasisNo
        '
        Me.txtChasisNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChasisNo.Location = New System.Drawing.Point(160, 52)
        Me.txtChasisNo.Name = "txtChasisNo"
        Me.txtChasisNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChasisNo.TabIndex = 3
        Me.txtChasisNo.Text = ""
        '
        'txtEngineNo
        '
        Me.txtEngineNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngineNo.Location = New System.Drawing.Point(160, 20)
        Me.txtEngineNo.Name = "txtEngineNo"
        Me.txtEngineNo.Size = New System.Drawing.Size(160, 23)
        Me.txtEngineNo.TabIndex = 2
        Me.txtEngineNo.Text = ""
        '
        'tabpage2
        '
        Me.tabpage2.BackColor = System.Drawing.Color.SteelBlue
        Me.tabpage2.Controls.Add(Me.Label48)
        Me.tabpage2.Controls.Add(Me.txtLicenseExpiry)
        Me.tabpage2.Controls.Add(Me.txtLicenseReferenceNo)
        Me.tabpage2.Controls.Add(Me.txtLPKPFileReferenceNo)
        Me.tabpage2.Controls.Add(Me.txtLPKPFormNo)
        Me.tabpage2.Controls.Add(Me.Label21)
        Me.tabpage2.Controls.Add(Me.Label20)
        Me.tabpage2.Controls.Add(Me.Label19)
        Me.tabpage2.Controls.Add(Me.Label18)
        Me.tabpage2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpage2.Location = New System.Drawing.Point(4, 27)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(816, 288)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "LPKP"
        Me.tabpage2.Visible = False
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(320, 120)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 20)
        Me.Label48.TabIndex = 27
        Me.Label48.Text = "(dd-mmm-yy)"
        '
        'txtLicenseExpiry
        '
        Me.txtLicenseExpiry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseExpiry.Location = New System.Drawing.Point(160, 117)
        Me.txtLicenseExpiry.Name = "txtLicenseExpiry"
        Me.txtLicenseExpiry.Size = New System.Drawing.Size(160, 23)
        Me.txtLicenseExpiry.TabIndex = 21
        Me.txtLicenseExpiry.Text = ""
        '
        'txtLicenseReferenceNo
        '
        Me.txtLicenseReferenceNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseReferenceNo.Location = New System.Drawing.Point(160, 85)
        Me.txtLicenseReferenceNo.Name = "txtLicenseReferenceNo"
        Me.txtLicenseReferenceNo.Size = New System.Drawing.Size(160, 23)
        Me.txtLicenseReferenceNo.TabIndex = 20
        Me.txtLicenseReferenceNo.Text = ""
        '
        'txtLPKPFileReferenceNo
        '
        Me.txtLPKPFileReferenceNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPKPFileReferenceNo.Location = New System.Drawing.Point(160, 52)
        Me.txtLPKPFileReferenceNo.Name = "txtLPKPFileReferenceNo"
        Me.txtLPKPFileReferenceNo.Size = New System.Drawing.Size(160, 23)
        Me.txtLPKPFileReferenceNo.TabIndex = 19
        Me.txtLPKPFileReferenceNo.Text = ""
        '
        'txtLPKPFormNo
        '
        Me.txtLPKPFormNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPKPFormNo.Location = New System.Drawing.Point(160, 20)
        Me.txtLPKPFormNo.Name = "txtLPKPFormNo"
        Me.txtLPKPFormNo.Size = New System.Drawing.Size(160, 23)
        Me.txtLPKPFormNo.TabIndex = 18
        Me.txtLPKPFormNo.Text = ""
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 13)
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
        Me.tabPage3.Controls.Add(Me.Label11)
        Me.tabPage3.Controls.Add(Me.Label32)
        Me.tabPage3.Controls.Add(Me.Label24)
        Me.tabPage3.Controls.Add(Me.Label31)
        Me.tabPage3.Controls.Add(Me.txtPolicyPeriodTo)
        Me.tabPage3.Controls.Add(Me.txtPolicyPeriodFrom)
        Me.tabPage3.Controls.Add(Me.Label28)
        Me.tabPage3.Controls.Add(Me.txtTotalPayable)
        Me.tabPage3.Controls.Add(Me.Label26)
        Me.tabPage3.Controls.Add(Me.Label27)
        Me.tabPage3.Controls.Add(Me.txtNCT_DTT)
        Me.tabPage3.Controls.Add(Me.txtBasicPremium)
        Me.tabPage3.Controls.Add(Me.Label22)
        Me.tabPage3.Controls.Add(Me.Label23)
        Me.tabPage3.Controls.Add(Me.Label25)
        Me.tabPage3.Controls.Add(Me.txtExcessApplicable)
        Me.tabPage3.Controls.Add(Me.txtVehicleSum)
        Me.tabPage3.Controls.Add(Me.txtPolicyNo)
        Me.tabPage3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPage3.Location = New System.Drawing.Point(4, 27)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(816, 288)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Insurance"
        Me.tabPage3.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(544, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "(dd-mmm-yy)"
        '
        'Label32
        '
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(16, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 24)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Policy Period"
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(336, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 24)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "To"
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(112, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 24)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "From"
        '
        'txtPolicyPeriodTo
        '
        Me.txtPolicyPeriodTo.Location = New System.Drawing.Point(368, 56)
        Me.txtPolicyPeriodTo.Name = "txtPolicyPeriodTo"
        Me.txtPolicyPeriodTo.Size = New System.Drawing.Size(176, 23)
        Me.txtPolicyPeriodTo.TabIndex = 24
        Me.txtPolicyPeriodTo.Text = ""
        '
        'txtPolicyPeriodFrom
        '
        Me.txtPolicyPeriodFrom.Location = New System.Drawing.Point(160, 56)
        Me.txtPolicyPeriodFrom.Name = "txtPolicyPeriodFrom"
        Me.txtPolicyPeriodFrom.Size = New System.Drawing.Size(160, 23)
        Me.txtPolicyPeriodFrom.TabIndex = 23
        Me.txtPolicyPeriodFrom.Text = ""
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(16, 215)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 13)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Total Payable"
        '
        'txtTotalPayable
        '
        Me.txtTotalPayable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayable.Location = New System.Drawing.Point(160, 215)
        Me.txtTotalPayable.Name = "txtTotalPayable"
        Me.txtTotalPayable.Size = New System.Drawing.Size(160, 23)
        Me.txtTotalPayable.TabIndex = 29
        Me.txtTotalPayable.Text = ""
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(16, 182)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 13)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "NCT/DTT"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(16, 150)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Basic Premium"
        '
        'txtNCT_DTT
        '
        Me.txtNCT_DTT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCT_DTT.Location = New System.Drawing.Point(160, 182)
        Me.txtNCT_DTT.Name = "txtNCT_DTT"
        Me.txtNCT_DTT.Size = New System.Drawing.Size(160, 23)
        Me.txtNCT_DTT.TabIndex = 28
        Me.txtNCT_DTT.Text = ""
        '
        'txtBasicPremium
        '
        Me.txtBasicPremium.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasicPremium.Location = New System.Drawing.Point(160, 150)
        Me.txtBasicPremium.Name = "txtBasicPremium"
        Me.txtBasicPremium.Size = New System.Drawing.Size(160, 23)
        Me.txtBasicPremium.TabIndex = 27
        Me.txtBasicPremium.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(16, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Excess Applicable"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(16, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Vehicle Sum"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(16, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 13)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Policy No Insurance"
        '
        'txtExcessApplicable
        '
        Me.txtExcessApplicable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcessApplicable.Location = New System.Drawing.Point(160, 117)
        Me.txtExcessApplicable.Name = "txtExcessApplicable"
        Me.txtExcessApplicable.Size = New System.Drawing.Size(160, 23)
        Me.txtExcessApplicable.TabIndex = 26
        Me.txtExcessApplicable.Text = ""
        '
        'txtVehicleSum
        '
        Me.txtVehicleSum.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleSum.Location = New System.Drawing.Point(160, 85)
        Me.txtVehicleSum.Name = "txtVehicleSum"
        Me.txtVehicleSum.Size = New System.Drawing.Size(160, 23)
        Me.txtVehicleSum.TabIndex = 25
        Me.txtVehicleSum.Text = ""
        '
        'txtPolicyNo
        '
        Me.txtPolicyNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicyNo.Location = New System.Drawing.Point(160, 20)
        Me.txtPolicyNo.Name = "txtPolicyNo"
        Me.txtPolicyNo.Size = New System.Drawing.Size(160, 23)
        Me.txtPolicyNo.TabIndex = 22
        Me.txtPolicyNo.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.txtInspectionTime)
        Me.TabPage4.Controls.Add(Me.txtInspectionDate)
        Me.TabPage4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(816, 288)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Puspacom"
        Me.TabPage4.Visible = False
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(320, 56)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(104, 16)
        Me.Label46.TabIndex = 43
        Me.Label46.Text = "(e.g 9:20:PM)"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(320, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "(dd-mmm-yy)"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(8, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 20)
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
        'txtInspectionTime
        '
        Me.txtInspectionTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspectionTime.Location = New System.Drawing.Point(160, 52)
        Me.txtInspectionTime.Name = "txtInspectionTime"
        Me.txtInspectionTime.Size = New System.Drawing.Size(160, 23)
        Me.txtInspectionTime.TabIndex = 31
        Me.txtInspectionTime.Text = ""
        '
        'txtInspectionDate
        '
        Me.txtInspectionDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspectionDate.Location = New System.Drawing.Point(160, 20)
        Me.txtInspectionDate.Name = "txtInspectionDate"
        Me.txtInspectionDate.Size = New System.Drawing.Size(160, 23)
        Me.txtInspectionDate.TabIndex = 30
        Me.txtInspectionDate.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Edit Motor Insurance Record"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 39)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(688, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Close"
        '
        'frmMotorEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(968, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.frame)
        Me.Name = "frmMotorEdit"
        Me.Text = "Edit Motor Insurance Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frame.ResumeLayout(False)
        Me.tab.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        Me.tabpage2.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMotorEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'error prevention techniques
        disable_object()
        cmdEdit.Enabled = True
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        cmdCancel.Enabled = False


    End Sub
    Public Sub enable_object()
        txtEngineNo.Enabled = True
        txtChasisNo.Enabled = True
        txtManufacturer.Enabled = True
        txtModel.Enabled = True
        txtEnginePower.Enabled = True
        cboFuelType.Enabled = True
        cboVehicleType.Enabled = True
        txtYearManufacturer.Enabled = True
        txtYearRegistration.Enabled = True
        txtLicenseDuration.Enabled = True
        txtBDM_BGK.Enabled = True
        txtBTM.Enabled = True
        txtDriverName.Enabled = True
        cboLocation.Enabled = True
        txtSeriesNo.Enabled = True
        txtStatus.Enabled = True
        txtLPKPFormNo.Enabled = True
        txtLPKPFileReferenceNo.Enabled = True
        txtLicenseReferenceNo.Enabled = True
        txtLicenseExpiry.Enabled = True
        txtPolicyNo.Enabled = True
        txtPolicyPeriodFrom.Enabled = True
        txtPolicyPeriodTo.Enabled = True
        txtVehicleSum.Enabled = True
        txtExcessApplicable.Enabled = True
        txtBasicPremium.Enabled = True
        txtNCT_DTT.Enabled = True
        txtTotalPayable.Enabled = True
        txtInspectionDate.Enabled = True
        txtInspectionTime.Enabled = True
    End Sub
    Public Sub disable_object()
        txtEngineNo.Enabled = False
        txtChasisNo.Enabled = False
        txtManufacturer.Enabled = False
        txtModel.Enabled = False
        txtEnginePower.Enabled = False
        cboFuelType.Enabled = False
        cboVehicleType.Enabled = False
        txtYearManufacturer.Enabled = False
        txtYearRegistration.Enabled = False
        txtLicenseDuration.Enabled = False
        txtBDM_BGK.Enabled = False
        txtBTM.Enabled = False
        txtDriverName.Enabled = False
        cboLocation.Enabled = False
        txtSeriesNo.Enabled = False
        txtStatus.Enabled = False
        txtLPKPFormNo.Enabled = False
        txtLPKPFileReferenceNo.Enabled = False
        txtLicenseReferenceNo.Enabled = False
        txtLicenseExpiry.Enabled = False
        txtPolicyNo.Enabled = False
        txtPolicyPeriodFrom.Enabled = False
        txtPolicyPeriodTo.Enabled = False
        txtVehicleSum.Enabled = False
        txtExcessApplicable.Enabled = False
        txtBasicPremium.Enabled = False
        txtNCT_DTT.Enabled = False
        txtTotalPayable.Enabled = False
        txtInspectionDate.Enabled = False
        txtInspectionTime.Enabled = False
    End Sub
    Public Sub clear_object()
        txtEngineNo.Text = ""
        txtChasisNo.Text = ""
        txtManufacturer.Text = ""
        txtModel.Text = ""
        txtEnginePower.Text = ""
        cboFuelType.Text = ""
        cboVehicleType.Text = ""
        txtYearManufacturer.Text = ""
        txtYearRegistration.Text = ""
        txtLicenseDuration.Text = ""
        txtBDM_BGK.Text = ""
        txtBTM.Text = ""
        txtDriverName.Text = ""
        cboLocation.Text = ""
        txtSeriesNo.Text = ""
        txtStatus.Text = ""
        txtLPKPFormNo.Text = ""
        txtLPKPFileReferenceNo.Text = ""
        txtLicenseReferenceNo.Text = ""
        txtLicenseExpiry.Text = ""
        txtPolicyNo.Text = ""
        txtPolicyPeriodFrom.Text = ""
        txtPolicyPeriodTo.Text = ""
        txtVehicleSum.Text = ""
        txtExcessApplicable.Text = ""
        txtBasicPremium.Text = ""
        txtNCT_DTT.Text = ""
        txtTotalPayable.Text = ""
        txtInspectionDate.Text = ""
        txtInspectionTime.Text = ""
    End Sub


    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        'error prevention techniques
        cmdSave.Enabled = True
        cmdEdit.Enabled = False
        cmdDelete.Enabled = True
        cmdCancel.Enabled = True
        enable_object()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "



        'to load registrantion no and display all details
        SQLLoadRegistrationNo = "SELECT * from motorinsurance"          'select table
        myCommand.Connection = conn                                     'initialize connection or select which connection to use
        conn.Open() 'open connection                  
        myCommand.CommandText = SQLLoadRegistrationNo                   'tell command which sql statement to execute
        myAdapter.SelectCommand = myCommand                             'execute command
        myData.Clear()
        myAdapter.Fill(myData)                                          'fill into mydata temp container

        cboRegistrationNo.DataSource = myData
        cboRegistrationNo.DisplayMember = "motorinsurance"
        cboRegistrationNo.ValueMember = "RegistrationNo"
        txtEngineNo.DataBindings.Add(New Binding("text", myData, "EngineNo"))
        txtChasisNo.DataBindings.Add(New Binding("text", myData, "CasisNo"))
        txtManufacturer.DataBindings.Add(New Binding("text", myData, "Manufacturer"))
        txtModel.DataBindings.Add(New Binding("text", myData, "ModelName"))
        txtEnginePower.DataBindings.Add(New Binding("text", myData, "EngineHorsepower"))

        'cboFuelType.DataBindings.Add(New Binding("text", myData, "fueltype"))
        cboFuelType.DataSource = myData
        cboFuelType.DisplayMember = "motorinsurance"
        cboFuelType.ValueMember = "FuelType"

        'cboVehicleType.DataBindings.Add(New Binding("text", myData, "vehicletype"))
        cboVehicleType.DataSource = myData
        cboVehicleType.DisplayMember = "motorinsurance"
        cboVehicleType.ValueMember = "VehicleType"

        txtYearManufacturer.DataBindings.Add(New Binding("text", myData, "YearManufacturer"))
        txtYearRegistration.DataBindings.Add(New Binding("text", myData, "YearRegistration"))
        txtLicenseDuration.DataBindings.Add(New Binding("text", myData, "LicenseDuration"))
        txtBDM_BGK.DataBindings.Add(New Binding("text", myData, "BDMBGK"))
        txtBTM.DataBindings.Add(New Binding("text", myData, "BTM"))
        txtDriverName.DataBindings.Add(New Binding("text", myData, "DriverName"))

        'cboLocation.DataBindings.Add(New Binding("text", myData, "location"))
        cboLocation.DataSource = myData
        cboLocation.DisplayMember = "motorinsurance"
        cboLocation.ValueMember = "Location"

        txtSeriesNo.DataBindings.Add(New Binding("text", myData, "SeriesNo"))
        txtStatus.DataBindings.Add(New Binding("text", myData, "Status"))
        txtLPKPFormNo.DataBindings.Add(New Binding("text", myData, "LPKPFormNo"))
        txtLPKPFileReferenceNo.DataBindings.Add(New Binding("text", myData, "FileReferenceNo"))
        txtLicenseReferenceNo.DataBindings.Add(New Binding("text", myData, "LicenseReferenceNo"))
        txtLicenseExpiry.DataBindings.Add(New Binding("text", myData, "LicenseExpire"))
        txtPolicyNo.DataBindings.Add(New Binding("text", myData, "PolicyNoInsurance"))
        txtPolicyPeriodFrom.DataBindings.Add(New Binding("text", myData, "PolicyPeriodFrom"))
        txtPolicyPeriodTo.DataBindings.Add(New Binding("text", myData, "PolicyPeriodTo"))
        txtVehicleSum.DataBindings.Add(New Binding("text", myData, "VehicleSumInsured"))
        txtExcessApplicable.DataBindings.Add(New Binding("text", myData, "ExcessApplicable"))
        txtBasicPremium.DataBindings.Add(New Binding("text", myData, "BasicPremium"))
        txtNCT_DTT.DataBindings.Add(New Binding("text", myData, "NCTDTT"))
        txtTotalPayable.DataBindings.Add(New Binding("text", myData, "TotalPayable"))
        txtInspectionDate.DataBindings.Add(New Binding("text", myData, "InspectioDate"))
        txtInspectionTime.DataBindings.Add(New Binding("text", myData, "InspectionTime"))

        conn.Close()
        conn.Dispose()

        cboRegistrationNo.Focus()


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not IsNumeric(txtYearManufacturer.Text) Or Not IsNumeric(txtYearRegistration.Text) Then
            MessageBox.Show("Please ente numerical  valid year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYearManufacturer.Text = ""
            txtYearRegistration.Text = ""
            txtYearManufacturer.Focus()
        ElseIf txtYearManufacturer.Text > txtYearRegistration.Text Then
            MessageBox.Show("Manufacturer year must not be later then registration eary", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYearRegistration.Text = ""
            txtYearManufacturer.Text = ""
            txtYearManufacturer.Focus()
        ElseIf Len(txtYearManufacturer.Text) <> 4 Or Len(txtYearRegistration.Text) <> 4 Then
            MessageBox.Show("Year must be 4 Digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYearRegistration.Text = ""
            txtYearManufacturer.Text = ""
            txtYearManufacturer.Focus()
            Exit Sub
        Else
            conn.Open()
            SQLUpdate = "UPDATE motorinsurance SET EngineNo = '" & txtEngineNo.Text & "'," _
                        & "CasisNo = '" & txtChasisNo.Text & "'," & "Manufacturer = '" & txtManufacturer.Text & "'," _
                        & "ModelName = '" & txtModel.Text & "'," & "EngineHorsepower = '" & txtEnginePower.Text & "'," _
                        & "FuelType= '" & cboFuelType.Text & "'," & "VehicleType = '" & cboVehicleType.Text & "'," _
                        & "YearManufacturer= '" & txtYearManufacturer.Text & "'," & "YearRegistration = '" & txtYearRegistration.Text & "'," _
                        & "LicenseDuration= '" & txtLicenseDuration.Text & "'," & "BDMBGK = '" & txtBDM_BGK.Text & "'," _
                        & "BTM= '" & txtBTM.Text & "'," & "DriverName = '" & txtDriverName.Text & "'," _
                        & "Location= '" & cboLocation.Text & "'," & "SeriesNo = '" & txtSeriesNo.Text & "'," _
                        & "Status= '" & txtStatus.Text & "'," & "LPKPFormNo = '" & txtLPKPFormNo.Text & "'," _
                        & "FileReferenceNo= '" & txtLPKPFileReferenceNo.Text & "'," & "LicenseReferenceNo = '" & txtLicenseReferenceNo.Text & "'," _
                        & "LicenseExpire= '" & txtLicenseExpiry.Text & "'," & "PolicyNoInsurance = '" & txtPolicyNo.Text & "'," _
                        & "PolicyPeriodFrom= '" & txtPolicyPeriodFrom.Text & "'," & "PolicyPeriodTo= '" & txtPolicyPeriodTo.Text & "'," & "VehicleSumInsured = '" & txtVehicleSum.Text & "'," _
                        & "ExcessApplicable= '" & txtExcessApplicable.Text & "'," & "BasicPremium = '" & txtBasicPremium.Text & "'," _
                        & "NCTDTT= '" & txtNCT_DTT.Text & "'," & "TotalPayable= '" & txtTotalPayable.Text & "'," & "InspectioDate= '" & txtInspectionDate.Text & "'," _
                        & "InspectionTime = '" & txtInspectionTime.Text & "' " _
                        & "WHERE RegistrationNo = '" & cboRegistrationNo.Text & "';"

            myCommand = New MySqlCommand(SQLUpdate, conn)
            hasil = myCommand.ExecuteNonQuery()
            MessageBox.Show("Record Has Been Updated Sucessfully", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            conn.Dispose()
            dataset_clear()
     

            'error prevention technique
            disable_object()
            cmdSave.Enabled = False
            cmdEdit.Enabled = True
            cmdDelete.Enabled = False
            cmdCancel.Enabled = False
            cboRegistrationNo.Focus()


        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim SQLDelete As String
        Dim myCommandDelete As MySqlCommand
        If MessageBox.Show("Are you sure you want to delete the current record?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLDelete = "DELETE FROM motorinsurance WHERE RegistrationNo='" & cboRegistrationNo.Text & "'"
            conn.Open()
            myCommandDelete = New MySqlCommand(SQLDelete, conn)
            myCommandDelete.ExecuteNonQuery()
            myCommand.Dispose()
            conn.Close()
            clear_object()
            MessageBox.Show("A Record has been deleted.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dataset_clear()
        For Each row As DataRow In myData.Rows
            If row("RegistrationNo") = cboRegistrationNo.Text Then
                row.Delete()

            End If

        Next
        myData.AcceptChanges()

        cmdEdit.Enabled = True
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        cmdCancel.Enabled = False
        disable_object()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        dataset_clear()

        cmdEdit.Enabled = True
        cmdSave.Enabled = False
        cmdDelete.Enabled = True
        cmdCancel.Enabled = True
        disable_object()


    End Sub

    Private Sub cboFuelType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFuelType.GotFocus
        'for fuel
        Dim SQLLoadFuel As String
        Dim myDataFuel As New DataTable
        Dim myCommandFuel As New MySqlCommand
        Dim myAdapterFuel As New MySqlDataAdapter

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

        'for vehicle
        Dim SQLLoadVehicle As String
        Dim myDataVehicle As New DataTable
        Dim myCommandVehicle As New MySqlCommand
        Dim myAdapterVehicle As New MySqlDataAdapter

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "



        SQLLoadVehicle = "select VehicleType from vehicle"                  'select table"
        myCommandVehicle.Connection = conn                                     'initialize connection or select which connection to use
        conn.Open() 'open connection                  
        myCommandVehicle.CommandText = SQLLoadVehicle                   'tell command which sql statement to execute
        myAdapterVehicle.SelectCommand = myCommandVehicle               'execute command
        myDataVehicle.Clear()
        myAdapterVehicle.Fill(myDataVehicle)                                          'fill into mydata temp Container()

        cboVehicleType.DataSource = myDataVehicle
        cboVehicleType.DisplayMember = "vehicle"
        cboVehicleType.ValueMember = "VehicleType"

        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub cboLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocation.GotFocus
        'for location
        Dim SQLLoadLocation As String
        Dim myDataLocation As New DataTable
        Dim myCommandLocation As New MySqlCommand
        Dim myAdapterLocation As New MySqlDataAdapter

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
        myAdapterLocation.SelectCommand = myCommandLocation                        'execute command()
        myDataLocation.Clear()
        myAdapterLocation.Fill(myDataLocation)                                          'fill into mydata temp Container()

        cboLocation.DataSource = myDataLocation
        cboLocation.DisplayMember = "location"
        cboLocation.ValueMember = "Location"

        conn.Close()
        conn.Dispose()


    End Sub

    Public Sub dataset_clear()
        myData.Clear()
        txtEngineNo.DataBindings.Clear()
        txtChasisNo.DataBindings.Clear()
        txtManufacturer.DataBindings.Clear()
        txtModel.DataBindings.Clear()
        txtEnginePower.DataBindings.Clear()
        cboFuelType.DataBindings.Clear()
        cboVehicleType.DataBindings.Clear()
        txtYearManufacturer.DataBindings.Clear()
        txtYearRegistration.DataBindings.Clear()
        txtLicenseDuration.DataBindings.Clear()
        txtBDM_BGK.DataBindings.Clear()
        txtBTM.DataBindings.Clear()
        txtDriverName.DataBindings.Clear()
        cboLocation.DataBindings.Clear()
        txtSeriesNo.DataBindings.Clear()
        txtStatus.DataBindings.Clear()
        txtLPKPFormNo.DataBindings.Clear()
        txtLPKPFileReferenceNo.DataBindings.Clear()
        txtLicenseReferenceNo.DataBindings.Clear()
        txtLicenseExpiry.DataBindings.Clear()
        txtPolicyNo.DataBindings.Clear()
        txtPolicyPeriodFrom.DataBindings.Clear()
        txtPolicyPeriodTo.DataBindings.Clear()
        txtVehicleSum.DataBindings.Clear()
        txtExcessApplicable.DataBindings.Clear()
        txtBasicPremium.DataBindings.Clear()
        txtNCT_DTT.DataBindings.Clear()
        txtTotalPayable.DataBindings.Clear()
        txtInspectionDate.DataBindings.Clear()
        txtInspectionTime.DataBindings.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
