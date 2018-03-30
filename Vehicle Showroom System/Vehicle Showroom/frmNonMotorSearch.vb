Imports MySql.Data.MySqlClient
Public Class frmNonMotorSearch
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents optTypeInsurance As System.Windows.Forms.RadioButton
    Friend WithEvents optPolicyNo As System.Windows.Forms.RadioButton
    Friend WithEvents optExpiryDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNonMotorSearch))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.optTypeInsurance = New System.Windows.Forms.RadioButton
        Me.optPolicyNo = New System.Windows.Forms.RadioButton
        Me.optExpiryDate = New System.Windows.Forms.RadioButton
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.GBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Search -  Non Motor Search"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(960, 280)
        Me.DataGrid1.TabIndex = 0
        '
        'optTypeInsurance
        '
        Me.optTypeInsurance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTypeInsurance.Location = New System.Drawing.Point(24, 24)
        Me.optTypeInsurance.Name = "optTypeInsurance"
        Me.optTypeInsurance.Size = New System.Drawing.Size(120, 16)
        Me.optTypeInsurance.TabIndex = 1
        Me.optTypeInsurance.Text = "Insurance Type"
        '
        'optPolicyNo
        '
        Me.optPolicyNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPolicyNo.Location = New System.Drawing.Point(24, 56)
        Me.optPolicyNo.Name = "optPolicyNo"
        Me.optPolicyNo.Size = New System.Drawing.Size(120, 15)
        Me.optPolicyNo.TabIndex = 2
        Me.optPolicyNo.Text = "Policy Number"
        '
        'optExpiryDate
        '
        Me.optExpiryDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optExpiryDate.Location = New System.Drawing.Point(24, 88)
        Me.optExpiryDate.Name = "optExpiryDate"
        Me.optExpiryDate.Size = New System.Drawing.Size(120, 13)
        Me.optExpiryDate.TabIndex = 3
        Me.optExpiryDate.Text = "Expiry Date"
        '
        'GBox1
        '
        Me.GBox1.Controls.Add(Me.optTypeInsurance)
        Me.GBox1.Controls.Add(Me.optPolicyNo)
        Me.GBox1.Controls.Add(Me.optExpiryDate)
        Me.GBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.ForeColor = System.Drawing.Color.White
        Me.GBox1.Location = New System.Drawing.Point(32, 320)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(200, 120)
        Me.GBox1.TabIndex = 5
        Me.GBox1.TabStop = False
        Me.GBox1.Text = "Search By"
        '
        'GBox2
        '
        Me.GBox2.Controls.Add(Me.Label1)
        Me.GBox2.Controls.Add(Me.Button1)
        Me.GBox2.Controls.Add(Me.btnSearch)
        Me.GBox2.Controls.Add(Me.txtSearch)
        Me.GBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox2.Location = New System.Drawing.Point(240, 320)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(328, 85)
        Me.GBox2.TabIndex = 6
        Me.GBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Search Data:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 19)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(144, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 19)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(144, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 23)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(624, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Please Select which information to search and key in the valid data according to " & _
        "the selected data"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 280)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmNonMotorSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(960, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmNonMotorSearch"
        Me.Text = "Non motor search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBox1.ResumeLayout(False)
        Me.GBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim connStr As String = "server=localhost;" & "username=root;" & "password=admin;" & "database=in-out "
    Dim conn As New MySqlConnection(connStr)
    Dim SQLCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter


    Private Sub frmSearchNonMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If optTypeInsurance.Checked = False And optPolicyNo.Checked = False And optExpiryDate.Checked = False Then
            MessageBox.Show("Please select any searching criteria!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If txtSearch.Text <> "" Then

                Dim searchQueryStr As String
                Dim NonMotorData As New DataSet

                If optTypeInsurance.Checked = True Then
                    searchQueryStr = "SELECT * from nonmotorinsurance where TypeInsurance='" & txtSearch.Text & "'"
                ElseIf optPolicyNo.Checked = True Then
                    searchQueryStr = "SELECT * from nonmotorinsurance where PolicyNo='" & txtSearch.Text & "'"
                ElseIf optExpiryDate.Checked = True Then
                    searchQueryStr = "SELECT * from nonmotorinsurance where ExpiryDate='" & txtSearch.Text & "'"

                End If

                SQLCommand.CommandText = searchQueryStr
                SQLCommand.Connection = conn
                conn.Open()
                myAdapter.SelectCommand = SQLCommand
                myAdapter.Fill(NonMotorData, "nonmotorinsurance")
                'DataGrid1.DataSource = NonMotorData.Tables("nonmotorinsurance").DefaultView
                DataGrid1.SetDataBinding(NonMotorData, "nonmotorinsurance")

                If NonMotorData.Tables(0).Rows.Count = 0 Then
                    MessageBox.Show("No Record Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                conn.Close()

            Else

                MessageBox.Show("Please enter any data in the search box!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
