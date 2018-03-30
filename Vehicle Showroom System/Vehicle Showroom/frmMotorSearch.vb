Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System
Imports System.Windows.Forms
Public Class frmMotorSearch
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optLocation As System.Windows.Forms.RadioButton
    Friend WithEvents optDriverName As System.Windows.Forms.RadioButton
    Friend WithEvents optManufacturer As System.Windows.Forms.RadioButton
    Friend WithEvents optLicenseDuration As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus As System.Windows.Forms.RadioButton
    Friend WithEvents optLicenseExpiry As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMotorSearch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optLicenseExpiry = New System.Windows.Forms.RadioButton
        Me.optStatus = New System.Windows.Forms.RadioButton
        Me.optLicenseDuration = New System.Windows.Forms.RadioButton
        Me.optManufacturer = New System.Windows.Forms.RadioButton
        Me.optDriverName = New System.Windows.Forms.RadioButton
        Me.optLocation = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.optLicenseExpiry)
        Me.GroupBox1.Controls.Add(Me.optStatus)
        Me.GroupBox1.Controls.Add(Me.optLicenseDuration)
        Me.GroupBox1.Controls.Add(Me.optManufacturer)
        Me.GroupBox1.Controls.Add(Me.optDriverName)
        Me.GroupBox1.Controls.Add(Me.optLocation)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By"
        '
        'optLicenseExpiry
        '
        Me.optLicenseExpiry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLicenseExpiry.ForeColor = System.Drawing.Color.White
        Me.optLicenseExpiry.Location = New System.Drawing.Point(40, 152)
        Me.optLicenseExpiry.Name = "optLicenseExpiry"
        Me.optLicenseExpiry.Size = New System.Drawing.Size(136, 20)
        Me.optLicenseExpiry.TabIndex = 5
        Me.optLicenseExpiry.Text = "License Expiry"
        '
        'optStatus
        '
        Me.optStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStatus.ForeColor = System.Drawing.Color.White
        Me.optStatus.Location = New System.Drawing.Point(40, 130)
        Me.optStatus.Name = "optStatus"
        Me.optStatus.Size = New System.Drawing.Size(136, 13)
        Me.optStatus.TabIndex = 4
        Me.optStatus.Text = "Status"
        '
        'optLicenseDuration
        '
        Me.optLicenseDuration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLicenseDuration.ForeColor = System.Drawing.Color.White
        Me.optLicenseDuration.Location = New System.Drawing.Point(40, 104)
        Me.optLicenseDuration.Name = "optLicenseDuration"
        Me.optLicenseDuration.Size = New System.Drawing.Size(136, 13)
        Me.optLicenseDuration.TabIndex = 3
        Me.optLicenseDuration.Text = "License Duration"
        '
        'optManufacturer
        '
        Me.optManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optManufacturer.ForeColor = System.Drawing.Color.White
        Me.optManufacturer.Location = New System.Drawing.Point(40, 78)
        Me.optManufacturer.Name = "optManufacturer"
        Me.optManufacturer.Size = New System.Drawing.Size(136, 13)
        Me.optManufacturer.TabIndex = 2
        Me.optManufacturer.Text = "Manufacturer"
        '
        'optDriverName
        '
        Me.optDriverName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDriverName.ForeColor = System.Drawing.Color.White
        Me.optDriverName.Location = New System.Drawing.Point(40, 52)
        Me.optDriverName.Name = "optDriverName"
        Me.optDriverName.Size = New System.Drawing.Size(136, 13)
        Me.optDriverName.TabIndex = 1
        Me.optDriverName.Text = "Driver Name"
        '
        'optLocation
        '
        Me.optLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLocation.ForeColor = System.Drawing.Color.White
        Me.optLocation.Location = New System.Drawing.Point(40, 26)
        Me.optLocation.Name = "optLocation"
        Me.optLocation.Size = New System.Drawing.Size(136, 13)
        Me.optLocation.TabIndex = 0
        Me.optLocation.Text = "Location"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Search Data:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(152, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 23)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(272, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 85)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.Black
        Me.cmdSearch.Location = New System.Drawing.Point(152, 56)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(80, 19)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Location = New System.Drawing.Point(256, 56)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 19)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Close"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please Select which information to search and key in the valid data according to " & _
        "the selected data"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Search - Motor Insurance"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(848, 306)
        Me.DataGrid1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 306)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMotorSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(848, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMotorSearch"
        Me.Text = "Motor Insurance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim SqlSearch As String
        Dim conn As New MySqlConnection
        Dim myCommandSearch As New MySqlCommand
        Dim myAdapterReaderSearch As New MySqlDataAdapter
        Dim myDataSearch As New DataSet("user table")
        Dim sqlQuery As String
        DataGrid1.ReadOnly = True

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "


        'validate optin 
        If optLocation.Checked = False And optDriverName.Checked = False And optManufacturer.Checked = False And _
            optLicenseDuration.Checked = False And optStatus.Checked = False And optLicenseExpiry.Checked = False Then
            MsgBox("Please Select At Least One Search Option", vbOKOnly + vbInformation, "")
            Exit Sub
        End If
    

        'sql statement for search
        If optLocation.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where Location='" & txtSearch.Text & "'"
        ElseIf optDriverName.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where DriverName='" & txtSearch.Text & "'"
        ElseIf optManufacturer.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where Manufacturer='" & txtSearch.Text & "'"
        ElseIf optLicenseDuration.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where LicenseDuration='" & txtSearch.Text & "'"
        ElseIf optStatus.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where Status='" & txtSearch.Text & "'"
        ElseIf optLicenseExpiry.Checked = True Then
            sqlQuery = "SELECT * from motorinsurance where LicenseExpire='" & txtSearch.Text & "'"
        End If

        conn.Open()
        SqlSearch = sqlQuery
        myCommandSearch.Connection = conn
        myCommandSearch.CommandText = SqlSearch
        myAdapterReaderSearch.SelectCommand = myCommandSearch
        myAdapterReaderSearch.Fill(myDataSearch, "motorinsurance")
        DataGrid1.DataSource = myDataSearch.Tables("motorinsurance").DefaultView
        If myDataSearch.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No Record Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub frmMotorSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
