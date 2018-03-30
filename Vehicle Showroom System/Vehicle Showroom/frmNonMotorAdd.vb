Imports MySql.Data.MySqlClient
Imports System.Globalization.NumberFormatInfo
Public Class frmNonMotorAdd
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRecordID As System.Windows.Forms.TextBox
    Friend WithEvents cboInsuranceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPremium As System.Windows.Forms.TextBox
    Friend WithEvents txtSumInsured As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicyNo As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboDate As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNonMotorAdd))
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboDate = New System.Windows.Forms.ComboBox
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtPremium = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSumInsured = New System.Windows.Forms.TextBox
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.txtPolicyNo = New System.Windows.Forms.TextBox
        Me.cboInsuranceType = New System.Windows.Forms.ComboBox
        Me.txtRecordID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(408, 440)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 19)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(504, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 19)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(600, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 19)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        '
        'GBox1
        '
        Me.GBox1.Controls.Add(Me.Label14)
        Me.GBox1.Controls.Add(Me.Label13)
        Me.GBox1.Controls.Add(Me.Label12)
        Me.GBox1.Controls.Add(Me.cboDate)
        Me.GBox1.Controls.Add(Me.cboMonth)
        Me.GBox1.Controls.Add(Me.Label11)
        Me.GBox1.Controls.Add(Me.Label10)
        Me.GBox1.Controls.Add(Me.Label9)
        Me.GBox1.Controls.Add(Me.txtRate)
        Me.GBox1.Controls.Add(Me.txtPremium)
        Me.GBox1.Controls.Add(Me.Label8)
        Me.GBox1.Controls.Add(Me.Label7)
        Me.GBox1.Controls.Add(Me.txtSumInsured)
        Me.GBox1.Controls.Add(Me.txtLocation)
        Me.GBox1.Controls.Add(Me.txtYear)
        Me.GBox1.Controls.Add(Me.txtPolicyNo)
        Me.GBox1.Controls.Add(Me.cboInsuranceType)
        Me.GBox1.Controls.Add(Me.txtRecordID)
        Me.GBox1.Controls.Add(Me.Label6)
        Me.GBox1.Controls.Add(Me.Label5)
        Me.GBox1.Controls.Add(Me.Label4)
        Me.GBox1.Controls.Add(Me.Label3)
        Me.GBox1.Controls.Add(Me.Label2)
        Me.GBox1.Controls.Add(Me.Label1)
        Me.GBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.Location = New System.Drawing.Point(104, 64)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(680, 364)
        Me.GBox1.TabIndex = 3
        Me.GBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(480, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 24)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(424, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "$"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(152, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "$"
        '
        'cboDate
        '
        Me.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDate.Location = New System.Drawing.Point(152, 168)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(48, 24)
        Me.cboDate.TabIndex = 4
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Location = New System.Drawing.Point(208, 168)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(56, 24)
        Me.cboMonth.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(264, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(8, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "-"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(200, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "-"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(320, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "(dd-mmm-yy)"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(440, 65)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(40, 23)
        Me.txtRate.TabIndex = 10
        Me.txtRate.Text = ""
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(440, 32)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(40, 23)
        Me.txtPremium.TabIndex = 9
        Me.txtPremium.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(352, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Rate"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(352, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Premium"
        '
        'txtSumInsured
        '
        Me.txtSumInsured.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumInsured.Location = New System.Drawing.Point(168, 296)
        Me.txtSumInsured.Name = "txtSumInsured"
        Me.txtSumInsured.Size = New System.Drawing.Size(56, 23)
        Me.txtSumInsured.TabIndex = 8
        Me.txtSumInsured.Text = ""
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(152, 208)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLocation.Size = New System.Drawing.Size(160, 72)
        Me.txtLocation.TabIndex = 7
        Me.txtLocation.Text = ""
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(272, 168)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(32, 23)
        Me.txtYear.TabIndex = 6
        Me.txtYear.Text = ""
        '
        'txtPolicyNo
        '
        Me.txtPolicyNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicyNo.Location = New System.Drawing.Point(152, 111)
        Me.txtPolicyNo.Name = "txtPolicyNo"
        Me.txtPolicyNo.Size = New System.Drawing.Size(160, 23)
        Me.txtPolicyNo.TabIndex = 3
        Me.txtPolicyNo.Text = ""
        '
        'cboInsuranceType
        '
        Me.cboInsuranceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsuranceType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInsuranceType.Location = New System.Drawing.Point(152, 65)
        Me.cboInsuranceType.MaxDropDownItems = 20
        Me.cboInsuranceType.Name = "cboInsuranceType"
        Me.cboInsuranceType.Size = New System.Drawing.Size(160, 24)
        Me.cboInsuranceType.TabIndex = 2
        '
        'txtRecordID
        '
        Me.txtRecordID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordID.Location = New System.Drawing.Point(152, 32)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.ReadOnly = True
        Me.txtRecordID.Size = New System.Drawing.Size(160, 23)
        Me.txtRecordID.TabIndex = 1
        Me.txtRecordID.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sum Insured"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Expiry Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Policy No"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insurance Type"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Record ID"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label31.Location = New System.Drawing.Point(304, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(336, 26)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Non Motor Insurance Add New Record"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(216, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 45)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(696, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Close"
        '
        'frmNonMotorAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(808, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmNonMotorAdd"
        Me.Text = " add non motor insurance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim connStr As String = "server=localhost;" & "username=root;" & "password=admin;" & "database=in-out "
    Dim conn As New MySqlConnection(connStr)
    Dim SQLCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim count As Integer
    Dim arraylist1 As New ArrayList
    Dim policyExist As Boolean = False
    Dim num As Integer = 100
    Dim strMonth As String = CStr(Month(Today.Date))
    Dim strYear As String = CStr(Year(Today.Date))
    Dim Str As String = "ID"

    Private Sub frmAddNonMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        'Generate record ID
        Dim queryStr As String = "Select * from nonmotorinsurance"
        Dim datareader As MySqlDataReader = GetDataReader(queryStr, 1)



        If datareader.HasRows = False Then
            txtRecordID.Text = txtRecordID.Text + Str + CStr(strMonth) _
                             + "-" + CStr(num) + "-" + CStr(strYear)
        Else
            num = num + count + 1
            txtRecordID.Text = Str + CStr(strMonth) _
                            + "-" + CStr(num) + "-" + CStr(strYear)

        End If


        'error prevention technique
        object_disabled()
        btnCancel.Enabled = False



    End Sub
    Private Function GetDataReader(ByVal queryStr As String, ByVal index As Integer) As MySqlDataReader
        SQLCommand.CommandText = queryStr
        SQLCommand.Connection = conn
        conn.Open()

        Dim datareader As MySqlDataReader = SQLCommand.ExecuteReader
        While datareader.Read()
            If index = 1 Then
                count += 1
            ElseIf index = 3 Then
                If txtPolicyNo.Text = datareader.Item("PolicyNo") Then
                    policyExist = True
                End If

            Else
                arraylist1.Add(datareader.Item("InsuranceType"))
            End If

        End While
        conn.Close()
        datareader.Close()

        Return datareader

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'validation
        If (cboInsuranceType.Text = "" Or txtPolicyNo.Text = "" Or cboDate.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or txtLocation.Text = "" Or _
                    txtSumInsured.Text = "" Or txtPremium.Text = "") Then
            MessageBox.Show("Please complete all fields before saving", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If



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

        If Len(txtYear.Text) <> 2 Then
            MessageBox.Show("Year Must be Two Digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtYear.Text = ""
            txtYear.Focus()
            Exit Sub
        End If

        Dim queryStr3 As String = "Select PolicyNo from nonmotorinsurance"
        GetDataReader(queryStr3, 3)
        If policyExist = True Then
            MessageBox.Show("Cannot add a policy number that already exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            policyExist = False
            Exit Sub
        End If


        Dim AddQueryStr As String = "INSERT INTO nonmotorinsurance VALUES('" & txtRecordID.Text & "','" & cboInsuranceType.Text & "','" & txtPolicyNo.Text & "'," _
                    & "'" & cboDate.Text & "-" & cboMonth.Text & "-" & txtYear.Text & "','" & txtLocation.Text & "','" & txtSumInsured.Text & "','" & txtPremium.Text & "'," _
                    & "'" & txtRate.Text & "')"
        SQLCommand.CommandText = AddQueryStr
        SQLCommand.Connection = conn
        conn.Open()
        SQLCommand.ExecuteNonQuery()
        MessageBox.Show("Non Motor Insurance Record has been succesfully Added Into Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

        conn.Close()
        'regenerate record ID




        cboInsuranceType.Text = ""
        clearTxtBox()
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        object_disabled()




        num = num + 1
        txtRecordID.Text = Str + CStr(strMonth) _
                        + "-" + CStr(num) + "-" + CStr(strYear)


    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        clearTxtBox()
        object_disabled()


    End Sub
    Private Sub clearTxtBox()
        cboInsuranceType.Text = ""
        txtPolicyNo.Text = ""
        cboDate.Items.Clear()
        cboMonth.Items.Clear()
        txtYear.Text = ""
        txtLocation.Text = ""
        txtSumInsured.Text = ""
        txtPremium.Text = ""
        txtRate.Text = ""
    End Sub
    Private Sub object_enabled()
        txtRecordID.Enabled = True
        cboInsuranceType.Enabled = True
        txtPolicyNo.Enabled = True
        cboDate.Enabled = True
        cboMonth.Enabled = True
        txtYear.Enabled = True
        txtLocation.Enabled = True
        txtSumInsured.Enabled = True
        txtPremium.Enabled = True
        txtRate.Enabled = True
    End Sub
    Private Sub object_disabled()
        txtRecordID.Enabled = False
        cboInsuranceType.Enabled = False
        txtPolicyNo.Enabled = False
        cboDate.Enabled = False
        cboMonth.Enabled = False
        txtYear.Enabled = False
        txtLocation.Enabled = False
        txtSumInsured.Enabled = False
        txtPremium.Enabled = False
        txtRate.Enabled = False
    End Sub

    Private Sub cboInsuranceType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInsuranceType.GotFocus
        'Populate insurance type combo box
        Dim queryStr2 As String = "Select * from Insurance_type"
        GetDataReader(queryStr2, 2)
        cboInsuranceType.DataSource = arraylist1
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        generateDate()
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        object_enabled()
        cboInsuranceType.Focus()
    End Sub

    Private Sub cboInsuranceType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInsuranceType.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub generateDate()
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
        'for month

        Dim a As Integer
        For a = 1 To 31
            cboDate.Items.Add(a)
        Next
    End Sub


End Class
