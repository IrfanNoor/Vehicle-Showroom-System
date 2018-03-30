Imports MySql.Data.MySqlClient
Public Class frmNonMotorEdit
    Inherits System.Windows.Forms.Form
    Dim connStr As String = "server=localhost;" & "username=root;" & "password=admin;" & "database=in-out "
    Dim conn As New MySqlConnection(connStr)
    Dim SQLCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim NonMotorData As New DataTable
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
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPremium As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSumInsured As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicyNo As System.Windows.Forms.TextBox
    Friend WithEvents cboInsuranceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboRecordId As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNonMotorEdit))
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtExpiryDate = New System.Windows.Forms.TextBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtPremium = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSumInsured = New System.Windows.Forms.TextBox
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.txtPolicyNo = New System.Windows.Forms.TextBox
        Me.cboInsuranceType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboRecordId = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBox1
        '
        Me.GBox1.Controls.Add(Me.Label14)
        Me.GBox1.Controls.Add(Me.txtExpiryDate)
        Me.GBox1.Controls.Add(Me.PictureBox3)
        Me.GBox1.Controls.Add(Me.Label11)
        Me.GBox1.Controls.Add(Me.txtRate)
        Me.GBox1.Controls.Add(Me.txtPremium)
        Me.GBox1.Controls.Add(Me.Label8)
        Me.GBox1.Controls.Add(Me.Label7)
        Me.GBox1.Controls.Add(Me.txtSumInsured)
        Me.GBox1.Controls.Add(Me.txtLocation)
        Me.GBox1.Controls.Add(Me.txtPolicyNo)
        Me.GBox1.Controls.Add(Me.cboInsuranceType)
        Me.GBox1.Controls.Add(Me.Label6)
        Me.GBox1.Controls.Add(Me.Label5)
        Me.GBox1.Controls.Add(Me.Label4)
        Me.GBox1.Controls.Add(Me.Label3)
        Me.GBox1.Controls.Add(Me.Label2)
        Me.GBox1.Controls.Add(Me.cboRecordId)
        Me.GBox1.Controls.Add(Me.Label1)
        Me.GBox1.Controls.Add(Me.Label12)
        Me.GBox1.Controls.Add(Me.Label13)
        Me.GBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.ForeColor = System.Drawing.Color.White
        Me.GBox1.Location = New System.Drawing.Point(48, 56)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(672, 355)
        Me.GBox1.TabIndex = 4
        Me.GBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(472, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "%"
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.ForeColor = System.Drawing.Color.Black
        Me.txtExpiryDate.Location = New System.Drawing.Point(152, 168)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(152, 23)
        Me.txtExpiryDate.TabIndex = 26
        Me.txtExpiryDate.Text = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(600, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Select a Record ID To Delete or Edit"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Black
        Me.txtRate.Location = New System.Drawing.Point(424, 128)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(48, 23)
        Me.txtRate.TabIndex = 15
        Me.txtRate.Text = ""
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.ForeColor = System.Drawing.Color.Black
        Me.txtPremium.Location = New System.Drawing.Point(424, 96)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(48, 23)
        Me.txtPremium.TabIndex = 14
        Me.txtPremium.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(328, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Rate"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(320, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Premium"
        '
        'txtSumInsured
        '
        Me.txtSumInsured.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumInsured.ForeColor = System.Drawing.Color.Black
        Me.txtSumInsured.Location = New System.Drawing.Point(168, 288)
        Me.txtSumInsured.Name = "txtSumInsured"
        Me.txtSumInsured.Size = New System.Drawing.Size(48, 23)
        Me.txtSumInsured.TabIndex = 11
        Me.txtSumInsured.Text = ""
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.ForeColor = System.Drawing.Color.Black
        Me.txtLocation.Location = New System.Drawing.Point(152, 208)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLocation.Size = New System.Drawing.Size(152, 72)
        Me.txtLocation.TabIndex = 10
        Me.txtLocation.Text = ""
        '
        'txtPolicyNo
        '
        Me.txtPolicyNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicyNo.ForeColor = System.Drawing.Color.Black
        Me.txtPolicyNo.Location = New System.Drawing.Point(152, 128)
        Me.txtPolicyNo.Name = "txtPolicyNo"
        Me.txtPolicyNo.Size = New System.Drawing.Size(152, 23)
        Me.txtPolicyNo.TabIndex = 8
        Me.txtPolicyNo.Text = ""
        '
        'cboInsuranceType
        '
        Me.cboInsuranceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsuranceType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInsuranceType.ForeColor = System.Drawing.Color.Black
        Me.cboInsuranceType.Location = New System.Drawing.Point(152, 96)
        Me.cboInsuranceType.MaxDropDownItems = 20
        Me.cboInsuranceType.Name = "cboInsuranceType"
        Me.cboInsuranceType.Size = New System.Drawing.Size(152, 24)
        Me.cboInsuranceType.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sum Insured"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Expiry Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Policy No"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insurance Type"
        '
        'cboRecordId
        '
        Me.cboRecordId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecordId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecordId.ForeColor = System.Drawing.Color.Black
        Me.cboRecordId.Location = New System.Drawing.Point(296, 48)
        Me.cboRecordId.Name = "cboRecordId"
        Me.cboRecordId.Size = New System.Drawing.Size(168, 24)
        Me.cboRecordId.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(192, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Record ID"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(152, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "$"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(408, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "$"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(248, 448)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 20)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(344, 448)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 20)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(440, 448)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 20)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(528, 448)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 20)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(232, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(296, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Edit Non Motor Insurance Record"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 49)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(80, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(600, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "To start editing click the edit button"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(48, 408)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(616, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Close"
        '
        'frmNonMotorEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(776, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GBox1)
        Me.Name = "frmNonMotorEdit"
        Me.Text = "Edit Non Motor Insuranc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEditNonMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        object_disabled()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        object_enabled()

        Dim queryStr As String = "Select * from nonmotorinsurance"
        SQLCommand.CommandText = queryStr
        SQLCommand.Connection = conn
        conn.Open()
        myAdapter.SelectCommand = SQLCommand
        NonMotorData.Clear()
        myAdapter.Fill(NonMotorData)
        cboRecordId.DataSource = NonMotorData
        cboRecordId.DisplayMember = "nonmotorinsurance"
        cboRecordId.ValueMember = "RecordID"

        cboInsuranceType.DataBindings.Add(New Binding("text", NonMotorData, "TypeInsurance"))
        txtPolicyNo.DataBindings.Add(New Binding("text", NonMotorData, "PolicyNo"))
        txtExpiryDate.DataBindings.Add(New Binding("text", NonMotorData, "ExpiryDate"))
        txtLocation.DataBindings.Add(New Binding("text", NonMotorData, "Location"))
        txtSumInsured.DataBindings.Add(New Binding("text", NonMotorData, "SumInsured"))
        txtPremium.DataBindings.Add(New Binding("text", NonMotorData, "Premium"))
        txtRate.DataBindings.Add(New Binding("text", NonMotorData, "Rate"))

        conn.Close()


        Dim queryLoad As String = "select InsuranceType From insurance_type"
        Dim InsuranceTypeData As New DataTable
        Dim SQLCommandload As New MySqlCommand

        SQLCommandload.Connection = conn
        conn.Open()
        SQLCommandload.CommandText = queryLoad
        myAdapter.SelectCommand = SQLCommandload
        myAdapter.Fill(InsuranceTypeData)
        cboInsuranceType.DataSource = InsuranceTypeData
        cboInsuranceType.DisplayMember = "insurance_type"
        cboInsuranceType.ValueMember = "InsuranceType"
        conn.Close()
        cboInsuranceType.Focus()
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation
        If Char.IsNumber(txtSumInsured.Text) = False Then
            MessageBox.Show("Please Enter Number Only For Sum Insured Field", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Char.IsNumber(txtPremium.Text) = False Then
            MessageBox.Show("Please Enter Number Only For Premium Field", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Char.IsDigit(txtRate.Text) = False Then
            MessageBox.Show("Please Enter Number Only For Rate Field", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (cboInsuranceType.Text = "" Or txtPolicyNo.Text = "" Or txtExpiryDate.Text = "" Or txtLocation.Text = "" Or _
                    txtSumInsured.Text = "" Or txtPremium.Text = "") Then
            MessageBox.Show("Please complete all fields before saving", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim updateQueryStr As String = "Update nonmotorinsurance SET TypeInsurance ='" & cboInsuranceType.Text & "'," _
        & "PolicyNo ='" & txtPolicyNo.Text & "'," & "ExpiryDate ='" & txtExpiryDate.Text & "'," & _
        "Location ='" & txtLocation.Text & "'," & "SumInsured ='" & txtSumInsured.Text & "'," & _
        "Premium ='" & txtPremium.Text & "'," & "Rate ='" & txtRate.Text & "' Where RecordID ='" & cboRecordId.Text & _
        "'"

        conn.Open()
        SQLCommand.CommandText = updateQueryStr
        SQLCommand.ExecuteNonQuery()
        MessageBox.Show("Record Has Been Updated!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

        conn.Close()
        'Clear Binding
        NonMotorData.Clear()
        cboInsuranceType.DataBindings.Clear()
        txtPolicyNo.DataBindings.Clear()
        txtExpiryDate.DataBindings.Clear()
        txtLocation.DataBindings.Clear()
        txtSumInsured.DataBindings.Clear()
        txtPremium.DataBindings.Clear()
        txtRate.DataBindings.Clear()

        btnEdit.Enabled = True
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        object_disabled()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim deleteQueryStr As String = "Delete From nonmotorinsurance Where RecordID ='" & cboRecordId.Text & "'"
        If MessageBox.Show("This Will Remove the selected Record?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            conn.Open()
            SQLCommand.CommandText = deleteQueryStr
            SQLCommand.ExecuteNonQuery()
            MessageBox.Show("Record Has Been Updated ", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            'Remove the row from datatable
            'Dim row As DataRow
            For Each row As DataRow In NonMotorData.Rows
                If row("RecordID") = cboRecordId.Text Then
                    row.Delete()

                End If

            Next
            NonMotorData.AcceptChanges()

            'Clear Binding
            NonMotorData.Clear()
            cboInsuranceType.DataBindings.Clear()
            txtPolicyNo.DataBindings.Clear()
            txtExpiryDate.DataBindings.Clear()
            txtLocation.DataBindings.Clear()
            txtSumInsured.DataBindings.Clear()
            txtPremium.DataBindings.Clear()
            txtRate.DataBindings.Clear()

            btnEdit.Enabled = True
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            object_disabled()

        End If
    End Sub
    Private Sub object_enabled()

        cboInsuranceType.Enabled = True
        txtPolicyNo.Enabled = True
        txtExpiryDate.Enabled = True
        txtLocation.Enabled = True
        txtSumInsured.Enabled = True
        txtPremium.Enabled = True
        txtRate.Enabled = True
    End Sub
    Private Sub object_disabled()

        cboInsuranceType.Enabled = False
        txtPolicyNo.Enabled = False
        txtExpiryDate.Enabled = False
        txtLocation.Enabled = False
        txtSumInsured.Enabled = False
        txtPremium.Enabled = False
        txtRate.Enabled = False
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

  
        NonMotorData.Clear()

        cboInsuranceType.DataBindings.Clear()
        txtPolicyNo.DataBindings.Clear()
        txtExpiryDate.DataBindings.Clear()
        txtLocation.DataBindings.Clear()
        txtSumInsured.DataBindings.Clear()
        txtPremium.DataBindings.Clear()
        txtRate.DataBindings.Clear()

        'conn.Close()
        object_disabled()
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False



 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
