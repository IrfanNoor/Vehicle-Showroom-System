
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms





Public Class frmMotorReport
    Inherits System.Windows.Forms.Form
    Public sqlreport As String
    Public result As String
    Dim myDataSearch As New DataSet
    Dim file As file



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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdDisplay As System.Windows.Forms.Button
    Friend WithEvents LstFrom As System.Windows.Forms.ListBox
    Friend WithEvents LstTo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmdMoveTo As System.Windows.Forms.Button
    Friend WithEvents cmdMoveBack As System.Windows.Forms.Button
    Friend WithEvents chkLocation As System.Windows.Forms.CheckBox
    Friend WithEvents chkVehicle As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ad As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMotorReport))
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdDisplay = New System.Windows.Forms.Button
        Me.LstFrom = New System.Windows.Forms.ListBox
        Me.LstTo = New System.Windows.Forms.ListBox
        Me.cmdMoveTo = New System.Windows.Forms.Button
        Me.cmdMoveBack = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.btnUnSelectAll = New System.Windows.Forms.Button
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.ad = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cboVehicle = New System.Windows.Forms.ComboBox
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkVehicle = New System.Windows.Forms.CheckBox
        Me.chkLocation = New System.Windows.Forms.CheckBox
        Me.cmdExport = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.ad.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(192, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 20)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Close"
        '
        'cmdDisplay
        '
        Me.cmdDisplay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDisplay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplay.ForeColor = System.Drawing.Color.Black
        Me.cmdDisplay.Location = New System.Drawing.Point(64, 152)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(104, 19)
        Me.cmdDisplay.TabIndex = 6
        Me.cmdDisplay.Text = "Display"
        '
        'LstFrom
        '
        Me.LstFrom.BackColor = System.Drawing.Color.White
        Me.LstFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFrom.ForeColor = System.Drawing.Color.Black
        Me.LstFrom.ItemHeight = 16
        Me.LstFrom.Location = New System.Drawing.Point(16, 33)
        Me.LstFrom.Name = "LstFrom"
        Me.LstFrom.Size = New System.Drawing.Size(112, 180)
        Me.LstFrom.TabIndex = 7
        '
        'LstTo
        '
        Me.LstTo.BackColor = System.Drawing.Color.White
        Me.LstTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTo.ForeColor = System.Drawing.Color.Black
        Me.LstTo.ItemHeight = 16
        Me.LstTo.Location = New System.Drawing.Point(192, 33)
        Me.LstTo.Name = "LstTo"
        Me.LstTo.Size = New System.Drawing.Size(112, 180)
        Me.LstTo.TabIndex = 8
        '
        'cmdMoveTo
        '
        Me.cmdMoveTo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdMoveTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveTo.Location = New System.Drawing.Point(136, 85)
        Me.cmdMoveTo.Name = "cmdMoveTo"
        Me.cmdMoveTo.Size = New System.Drawing.Size(40, 19)
        Me.cmdMoveTo.TabIndex = 9
        Me.cmdMoveTo.Text = ">>"
        '
        'cmdMoveBack
        '
        Me.cmdMoveBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdMoveBack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveBack.Location = New System.Drawing.Point(136, 111)
        Me.cmdMoveBack.Name = "cmdMoveBack"
        Me.cmdMoveBack.Size = New System.Drawing.Size(40, 19)
        Me.cmdMoveBack.TabIndex = 10
        Me.cmdMoveBack.Text = "<<"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.btnUnSelectAll)
        Me.GroupBox1.Controls.Add(Me.btnSelectAll)
        Me.GroupBox1.Controls.Add(Me.cmdMoveTo)
        Me.GroupBox1.Controls.Add(Me.cmdMoveBack)
        Me.GroupBox1.Controls.Add(Me.LstTo)
        Me.GroupBox1.Controls.Add(Me.LstFrom)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 249)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(192, 13)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(100, 13)
        Me.lbl2.TabIndex = 14
        Me.lbl2.Text = "Selected Field:"
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(8, 13)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(112, 15)
        Me.lbl1.TabIndex = 13
        Me.lbl1.Text = "Available Field:"
        '
        'btnUnSelectAll
        '
        Me.btnUnSelectAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUnSelectAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnSelectAll.Location = New System.Drawing.Point(200, 224)
        Me.btnUnSelectAll.Name = "btnUnSelectAll"
        Me.btnUnSelectAll.Size = New System.Drawing.Size(96, 19)
        Me.btnUnSelectAll.TabIndex = 12
        Me.btnUnSelectAll.Text = "UnSelect All "
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelectAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(24, 224)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(96, 19)
        Me.btnSelectAll.TabIndex = 11
        Me.btnSelectAll.Text = "Select All"
        '
        'ad
        '
        Me.ad.BackColor = System.Drawing.Color.SteelBlue
        Me.ad.Controls.Add(Me.PictureBox2)
        Me.ad.Controls.Add(Me.PictureBox1)
        Me.ad.Controls.Add(Me.cboVehicle)
        Me.ad.Controls.Add(Me.cboLocation)
        Me.ad.Controls.Add(Me.Label1)
        Me.ad.Controls.Add(Me.chkVehicle)
        Me.ad.Controls.Add(Me.chkLocation)
        Me.ad.Controls.Add(Me.cmdExport)
        Me.ad.Controls.Add(Me.cmdClear)
        Me.ad.Controls.Add(Me.cmdDisplay)
        Me.ad.Controls.Add(Me.Button2)
        Me.ad.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.ForeColor = System.Drawing.Color.White
        Me.ad.Location = New System.Drawing.Point(352, 400)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(328, 249)
        Me.ad.TabIndex = 12
        Me.ad.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 176)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'cboVehicle
        '
        Me.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicle.Location = New System.Drawing.Point(168, 96)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(144, 24)
        Me.cboVehicle.TabIndex = 13
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.Location = New System.Drawing.Point(16, 96)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(144, 24)
        Me.cboLocation.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "To Return Result without Filtering,uncheck two boxes below "
        '
        'chkVehicle
        '
        Me.chkVehicle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehicle.ForeColor = System.Drawing.Color.White
        Me.chkVehicle.Location = New System.Drawing.Point(176, 64)
        Me.chkVehicle.Name = "chkVehicle"
        Me.chkVehicle.Size = New System.Drawing.Size(104, 13)
        Me.chkVehicle.TabIndex = 10
        Me.chkVehicle.Text = "Vehicle"
        '
        'chkLocation
        '
        Me.chkLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocation.ForeColor = System.Drawing.Color.White
        Me.chkLocation.Location = New System.Drawing.Point(24, 64)
        Me.chkLocation.Name = "chkLocation"
        Me.chkLocation.Size = New System.Drawing.Size(96, 13)
        Me.chkLocation.TabIndex = 9
        Me.chkLocation.Text = "Location"
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdExport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.ForeColor = System.Drawing.Color.Black
        Me.cmdExport.Location = New System.Drawing.Point(64, 184)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(104, 20)
        Me.cmdExport.TabIndex = 8
        Me.cmdExport.Text = "Export to Excel"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Black
        Me.cmdClear.Location = New System.Drawing.Point(192, 152)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(96, 19)
        Me.cmdClear.TabIndex = 7
        Me.cmdClear.Text = "Clear "
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Report - Motor Insurance"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(736, 400)
        Me.DataGrid1.TabIndex = 18
        '
        'frmMotorReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(736, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMotorReport"
        Me.Text = "Motor Insurance Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ad.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region




    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim conn As New MySqlConnection
        Dim myCommandReport As New MySqlCommand
        Dim myAdapterReport As New MySqlDataAdapter
        Dim dataNew As New DataSet
        DataGrid1.ReadOnly = True

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "

        Dim a(30) As String
        If LstTo.Items.Count = 0 Then
            MessageBox.Show("Please Select at least one Column", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf LstTo.Items.Count = 1 Then
            a(0) = LstTo.Items.Item(0)
            result = a(0)
        ElseIf LstTo.Items.Count = 2 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            result = (a(0) + "," + a(1))
        ElseIf LstTo.Items.Count = 3 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            result = (a(0) + "," + a(1) + "," + a(2))
        ElseIf LstTo.Items.Count = 4 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3))
        ElseIf LstTo.Items.Count = 5 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4))
        ElseIf LstTo.Items.Count = 6 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5))
        ElseIf LstTo.Items.Count = 7 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6))
        ElseIf LstTo.Items.Count = 8 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7))
        ElseIf LstTo.Items.Count = 9 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8))
        ElseIf LstTo.Items.Count = 10 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9))
        ElseIf LstTo.Items.Count = 11 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10))
        ElseIf LstTo.Items.Count = 12 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11))
        ElseIf LstTo.Items.Count = 13 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12))
        ElseIf LstTo.Items.Count = 14 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13))
        ElseIf LstTo.Items.Count = 15 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14))
        ElseIf LstTo.Items.Count = 16 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15))
        ElseIf LstTo.Items.Count = 17 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16))
        ElseIf LstTo.Items.Count = 18 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17))
        ElseIf LstTo.Items.Count = 19 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18))
        ElseIf LstTo.Items.Count = 20 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19))
        ElseIf LstTo.Items.Count = 21 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20))
        ElseIf LstTo.Items.Count = 22 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21))
        ElseIf LstTo.Items.Count = 23 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22))
        ElseIf LstTo.Items.Count = 24 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23))
        ElseIf LstTo.Items.Count = 25 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24))
        ElseIf LstTo.Items.Count = 26 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25))
        ElseIf LstTo.Items.Count = 27 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            a(26) = LstTo.Items.Item(26)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25) + "," + a(26))
        ElseIf LstTo.Items.Count = 28 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            a(26) = LstTo.Items.Item(26)
            a(27) = LstTo.Items.Item(27)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25) + "," + a(26) + "," + a(27))
        ElseIf LstTo.Items.Count = 29 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            a(26) = LstTo.Items.Item(26)
            a(27) = LstTo.Items.Item(27)
            a(28) = LstTo.Items.Item(28)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25) + "," + a(26) + "," + a(27) + "," + a(28))
        ElseIf LstTo.Items.Count = 30 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            a(26) = LstTo.Items.Item(26)
            a(27) = LstTo.Items.Item(27)
            a(28) = LstTo.Items.Item(28)
            a(29) = LstTo.Items.Item(29)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25) + "," + a(26) + "," + a(27) + "," + a(28) + "," + a(29))
        ElseIf LstTo.Items.Count = 31 Then
            a(0) = LstTo.Items.Item(0)
            a(1) = LstTo.Items.Item(1)
            a(2) = LstTo.Items.Item(2)
            a(3) = LstTo.Items.Item(3)
            a(4) = LstTo.Items.Item(4)
            a(5) = LstTo.Items.Item(5)
            a(6) = LstTo.Items.Item(6)
            a(7) = LstTo.Items.Item(7)
            a(8) = LstTo.Items.Item(8)
            a(9) = LstTo.Items.Item(9)
            a(10) = LstTo.Items.Item(10)
            a(11) = LstTo.Items.Item(11)
            a(12) = LstTo.Items.Item(12)
            a(13) = LstTo.Items.Item(13)
            a(14) = LstTo.Items.Item(14)
            a(15) = LstTo.Items.Item(15)
            a(16) = LstTo.Items.Item(16)
            a(17) = LstTo.Items.Item(17)
            a(18) = LstTo.Items.Item(18)
            a(19) = LstTo.Items.Item(19)
            a(20) = LstTo.Items.Item(20)
            a(21) = LstTo.Items.Item(21)
            a(22) = LstTo.Items.Item(22)
            a(23) = LstTo.Items.Item(23)
            a(24) = LstTo.Items.Item(24)
            a(25) = LstTo.Items.Item(25)
            a(26) = LstTo.Items.Item(26)
            a(27) = LstTo.Items.Item(27)
            a(28) = LstTo.Items.Item(28)
            a(29) = LstTo.Items.Item(29)
            result = (a(0) + "," + a(1) + "," + a(2) + "," + a(3) + "," + a(4) + "," + a(5) + "," + a(6) + "," + a(7) + "," + a(8) + "," + a(9) + "," + a(10) + "," + a(11) + "," + a(12) + "," + a(13) + "," + a(14) + "," + a(15) + "," + a(16) + "," + a(17) + "," + a(18) + "," + a(19) + "," + a(20) + "," + a(21) + "," + a(22) + "," + a(23) + "," + a(24) + "," + a(25) + "," + a(26) + "," + a(27) + "," + a(28) + "," + a(29) + "," + a(30))

        End If
        '
        'if user select location
        If chkLocation.Checked = True And chkVehicle.Checked = False Then
            If cboLocation.Text = "" Then
                MessageBox.Show("Please select any available location!", "Location Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                sqlreport = "select " & result & " from motorinsurance where Location='" & cboLocation.SelectedValue & "' "
            End If

            'if user select vehicle
        ElseIf chkLocation.Checked = False And chkVehicle.Checked = True Then
            If cboVehicle.Text = "" Then
                MessageBox.Show("Please select any available vehicle!", "Vehicle Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                sqlreport = "select " & result & " from motorinsurance where VehicleType='" & cboVehicle.SelectedValue & "' "
            End If


            'if user select two option
        ElseIf chkLocation.Checked = True And chkVehicle.Checked = True Then
            If cboLocation.Text = "" Then
                MessageBox.Show("Please select any available location!", "Location Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If cboVehicle.Text = "" Then
                MessageBox.Show("Please select any available vehicle!", "Vehicle Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub  
            End If

            sqlreport = "select " & result & " from motorinsurance where VehicleType='" & cboVehicle.SelectedValue & "' AND Location='" & cboLocation.SelectedValue & "'"
        ElseIf chkVehicle.Checked = False And chkLocation.Checked = False And cboLocation.Text = "" And cboVehicle.Text = "" Then
            If MsgBox("This Will Return A Result Without Filter ?", vbYesNo + vbInformation, "Warning") = vbYes Then
                cboLocation.Text = ""
                cboVehicle.Text = ""
                sqlreport = "select " & result & " from motorinsurance"
            End If
        ElseIf chkVehicle.Checked = False And chkLocation.Checked = False Then
            If MsgBox("This Will Return A Result Without Filter ?", vbYesNo + vbInformation, "Warning") = vbYes Then

                sqlreport = "select " & result & " from motorinsurance"
            End If
        End If


        myCommandReport.Connection = conn
        myCommandReport.CommandText = sqlreport
        conn.Open()
        myAdapterReport.SelectCommand = myCommandReport
        myAdapterReport.Fill(dataNew, "motorinsurance")
        DataGrid1.DataSource = dataNew.Tables("motorinsurance").DefaultView

        conn.Close()
        myDataSearch = dataNew
        If dataNew.Tables("motorinsurance").Rows.Count = 0 Then
            DataGrid1.DataSource = Nothing
            DataGrid1.Refresh()
            MessageBox.Show("No record found", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub frmMotorReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstFrom.Items.Add("RegistrationNo")
        LstFrom.Items.Add("EngineNo")
        LstFrom.Items.Add("CasisNo")
        LstFrom.Items.Add("Manufacturer")
        LstFrom.Items.Add("ModelName")
        LstFrom.Items.Add("EngineHorsePower")
        LstFrom.Items.Add("FuelType")
        LstFrom.Items.Add("VehicleType")
        LstFrom.Items.Add("YearManufacturer")
        LstFrom.Items.Add("YearRegistration")
        LstFrom.Items.Add("LicenseDuration")
        LstFrom.Items.Add("BDMBGK")
        LstFrom.Items.Add("BTM")
        LstFrom.Items.Add("DriverName")
        LstFrom.Items.Add("Location")
        LstFrom.Items.Add("SeriesNo")
        LstFrom.Items.Add("Status")
        LstFrom.Items.Add("LPKPFormNo")
        LstFrom.Items.Add("FileReferenceNo")
        LstFrom.Items.Add("LicenseExpire")
        LstFrom.Items.Add("PolicyNoInsurance")
        LstFrom.Items.Add("PolicyPeriodFrom")
        LstFrom.Items.Add("PolicyPeriodTo")
        LstFrom.Items.Add("VehicleSumInsured")
        LstFrom.Items.Add("ExcessApplicable")
        LstFrom.Items.Add("BasicPremium")
        LstFrom.Items.Add("NCTDTT")
        LstFrom.Items.Add("TotalPayable")
        LstFrom.Items.Add("InspectioDate")
        LstFrom.Items.Add("InspectionTime")
        If chkLocation.Checked = False Then
            cboLocation.Enabled = False
        ElseIf chkVehicle.Checked = False Then
            cboVehicle.Enabled = False
        End If

    End Sub

    Private Sub LstFrom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstFrom.DoubleClick
        If Not LstFrom.SelectedItem = Nothing Then

            LstTo.Items.Add(LstFrom.SelectedItem)
            LstFrom.Items.Remove(LstFrom.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LstTo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstTo.DoubleClick
        If Not LstTo.SelectedItem = Nothing Then

            LstFrom.Items.Add(LstTo.SelectedItem)
            LstTo.Items.Remove(LstTo.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Dim i As Integer
        For i = 0 To LstFrom.Items.Count - 1
            LstTo.Items.Add(LstFrom.Items(i))

        Next
        LstFrom.Items.Clear()
    End Sub

    Private Sub btnUnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnSelectAll.Click
        Dim i As Integer
        For i = 0 To LstTo.Items.Count - 1
            LstFrom.Items.Add(LstTo.Items(i))

        Next
        LstTo.Items.Clear()
    End Sub
    Private Sub cmdMoveTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveTo.Click
        If Not LstFrom.SelectedItem = Nothing Then

            LstTo.Items.Add(LstFrom.SelectedItem)
            LstFrom.Items.Remove(LstFrom.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdMoveBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveBack.Click
        If Not LstTo.SelectedItem = Nothing Then

            LstFrom.Items.Add(LstTo.SelectedItem)
            LstTo.Items.Remove(LstTo.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub cboLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocation.GotFocus
        Dim conn As New MySqlConnection
        Dim myLoadCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter

        'for location
        Dim datalocationTable As New DataTable
        Dim SQLLoadLocation As String


        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "

        'load location
        SQLLoadLocation = "SELECT * from location"
        conn.Open()
        myLoadCommand.Connection = conn
        myLoadCommand.CommandText = SQLLoadLocation
        myAdapter.SelectCommand = myLoadCommand
        datalocationTable.Clear()
        myAdapter.Fill(datalocationTable)

        cboLocation.DataSource = datalocationTable
        cboLocation.DisplayMember = "location"
        cboLocation.ValueMember = "Location"
      
        conn.Close()

    End Sub
    Private Sub cboVehicle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVehicle.GotFocus
        Dim conn As New MySqlConnection
        Dim myLoadCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter

        Dim datavehicletable As New DataTable
        Dim SQLLoadvehicle As String

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "

        'load vehicle
        SQLLoadvehicle = "SELECT * from vehicle"
        conn.Open()
        myLoadCommand.Connection = conn
        myLoadCommand.CommandText = SQLLoadvehicle
        myAdapter.SelectCommand = myLoadCommand
        datavehicletable.Clear()
        myAdapter.Fill(datavehicletable)

        cboVehicle.DataSource = datavehicletable
        cboVehicle.DisplayMember = "vehicle"
        cboVehicle.ValueMember = "VehicleType"
        conn.Close()


    

    End Sub

 

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        DataGrid1.DataSource = Nothing
        DataGrid1.Refresh()

        chkLocation.Checked = False
        chkVehicle.Checked = False
        cboLocation.Enabled = False
        cboVehicle.Enabled = False

        Dim i As Integer
        For i = 0 To LstTo.Items.Count - 1
            LstFrom.Items.Add(LstTo.Items(i))

        Next
        LstTo.Items.Clear()
    End Sub

   
   



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim conn As New MySqlConnection
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim save As New DataTable
        Dim SQLTemplateSave As String
        Dim i As Integer

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "
        conn.Open()
        For i = 0 To LstTo.Items.Count - 1
            SQLTemplateSave = "INSERT INTO template(temp1,temp2,temp3) values (’" & LstTo.Items.Item(i) & "‘)"
            myCommand.CommandText = SQLTemplateSave
            myCommand.Connection = conn

            myCommand.ExecuteNonQuery()

        Next
        conn.Close()


        MessageBox.Show("Data has been succesfully added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        'Now create a windows appliaction in vb.net
        'Now in the COM Reference section refer to the MIcrosoft Excel 10.0 Object library.

        'Now in the code view state of the form paste the following code

        Dim Excel As New Excel.Application
        Dim intColumn, intRow, intColumnValue As Integer
        Dim strExcelFile As String
        Dim strFileName As String

        Dim strAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location.Substring(0, System.Reflection.Assembly.GetExecutingAssembly.Location.LastIndexOf("\") + 1)
        With Excel
            .SheetsInNewWorkbook = 1
            .Workbooks.Add()
            .Worksheets(1).Select()

            ' For displaying the column name in the the excel file.
            For intColumn = 0 To myDataSearch.Tables(0).Columns.Count - 1
                .Cells(1, intColumn + 1).Value = myDataSearch.Tables(0).Columns(intColumn).ColumnName.ToString
            Next
            'For displaying the column value row-by-row in the the excel file.
            For intRow = 1 To myDataSearch.Tables(0).Rows.Count
                For intColumnValue = 0 To myDataSearch.Tables(0).Columns.Count - 1
                    .Cells(intRow + 1, intColumnValue + 1).Value = myDataSearch.Tables(0).Rows(intRow - 1).ItemArray(intColumnValue).ToString
                Next
            Next


            strExcelFile = strAppPath & "book1"
            .ActiveWorkbook.Close()
            .Workbooks.Close()

            Excel.Quit()
            Excel = Nothing
            GC.Collect()

           

        End With
        MessageBox.Show("File exported sucessfully.", "Exporting done", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub chkLocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocation.CheckedChanged
        If chkLocation.Checked = True Then
            cboLocation.Enabled = True
        Else
            cboLocation.Enabled = False
        End If
    End Sub

    Private Sub chkVehicle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVehicle.CheckedChanged
        If chkVehicle.Checked = True Then
            cboVehicle.Enabled = True
        Else
            cboVehicle.Enabled = False

        End If
    End Sub
End Class





