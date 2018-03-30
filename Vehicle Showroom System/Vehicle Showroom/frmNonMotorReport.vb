Imports MySql.Data.MySqlClient
Imports Excel

Public Class frmNonMotorReport
    Inherits System.Windows.Forms.Form
    Dim NonMotorData1 As New DataSet

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
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LstFrom As System.Windows.Forms.ListBox
    Friend WithEvents LstTo As System.Windows.Forms.ListBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnUnselect As System.Windows.Forms.Button
    Friend WithEvents btnMoveBack As System.Windows.Forms.Button
    Friend WithEvents btnMoveTo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNonMotorReport))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.btnMoveBack = New System.Windows.Forms.Button
        Me.btnMoveTo = New System.Windows.Forms.Button
        Me.btnUnselect = New System.Windows.Forms.Button
        Me.btnAll = New System.Windows.Forms.Button
        Me.lbl2 = New System.Windows.Forms.Label
        Me.LstTo = New System.Windows.Forms.ListBox
        Me.LstFrom = New System.Windows.Forms.ListBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.GBox2 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Report - Non Motor Insurance"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(832, 312)
        Me.DataGrid1.TabIndex = 0
        '
        'GBox1
        '
        Me.GBox1.Controls.Add(Me.btnMoveBack)
        Me.GBox1.Controls.Add(Me.btnMoveTo)
        Me.GBox1.Controls.Add(Me.btnUnselect)
        Me.GBox1.Controls.Add(Me.btnAll)
        Me.GBox1.Controls.Add(Me.lbl2)
        Me.GBox1.Controls.Add(Me.LstTo)
        Me.GBox1.Controls.Add(Me.LstFrom)
        Me.GBox1.Controls.Add(Me.lbl1)
        Me.GBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.Location = New System.Drawing.Point(32, 328)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(400, 248)
        Me.GBox1.TabIndex = 1
        Me.GBox1.TabStop = False
        '
        'btnMoveBack
        '
        Me.btnMoveBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMoveBack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveBack.Location = New System.Drawing.Point(184, 124)
        Me.btnMoveBack.Name = "btnMoveBack"
        Me.btnMoveBack.Size = New System.Drawing.Size(40, 22)
        Me.btnMoveBack.TabIndex = 8
        Me.btnMoveBack.Text = "<<"
        '
        'btnMoveTo
        '
        Me.btnMoveTo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMoveTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveTo.Location = New System.Drawing.Point(184, 88)
        Me.btnMoveTo.Name = "btnMoveTo"
        Me.btnMoveTo.Size = New System.Drawing.Size(40, 22)
        Me.btnMoveTo.TabIndex = 7
        Me.btnMoveTo.Text = ">>"
        '
        'btnUnselect
        '
        Me.btnUnselect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUnselect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnselect.Location = New System.Drawing.Point(264, 208)
        Me.btnUnselect.Name = "btnUnselect"
        Me.btnUnselect.Size = New System.Drawing.Size(96, 20)
        Me.btnUnselect.TabIndex = 6
        Me.btnUnselect.Text = "Unselect All"
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(32, 208)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(96, 20)
        Me.btnAll.TabIndex = 5
        Me.btnAll.Text = "Select All"
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(264, 24)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(100, 15)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Selected Field"
        '
        'LstTo
        '
        Me.LstTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTo.ItemHeight = 16
        Me.LstTo.Location = New System.Drawing.Point(264, 46)
        Me.LstTo.Name = "LstTo"
        Me.LstTo.Size = New System.Drawing.Size(112, 148)
        Me.LstTo.TabIndex = 1
        '
        'LstFrom
        '
        Me.LstFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFrom.ItemHeight = 16
        Me.LstFrom.Location = New System.Drawing.Point(24, 46)
        Me.LstFrom.Name = "LstFrom"
        Me.LstFrom.Size = New System.Drawing.Size(112, 148)
        Me.LstFrom.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(24, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(112, 16)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Available Field"
        '
        'GBox2
        '
        Me.GBox2.Controls.Add(Me.PictureBox2)
        Me.GBox2.Controls.Add(Me.btnExport)
        Me.GBox2.Controls.Add(Me.btnClear)
        Me.GBox2.Controls.Add(Me.btnDisplay)
        Me.GBox2.Controls.Add(Me.btnCancel)
        Me.GBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox2.Location = New System.Drawing.Point(440, 328)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(288, 131)
        Me.GBox2.TabIndex = 2
        Me.GBox2.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(48, 80)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 19)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export to excel"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(168, 48)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 19)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(48, 48)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(104, 19)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(168, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 19)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Close"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(448, 568)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 6)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'frmNonMotorReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(832, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmNonMotorReport"
        Me.Text = "Non Motor Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBox1.ResumeLayout(False)
        Me.GBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmNonMotorReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LstFrom.Items.Add("RecordID")
        LstFrom.Items.Add("TypeInsurance")
        LstFrom.Items.Add("PolicyNo")
        LstFrom.Items.Add("ExpiryDate")
        LstFrom.Items.Add("Location")
        LstFrom.Items.Add("SumInsured")
        LstFrom.Items.Add("Premium")
        LstFrom.Items.Add("Rate")

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


    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim NonMotorData As New DataSet
        Dim result As String
        'Get user selected field from listbox
        Dim i As Integer
        For i = 0 To LstTo.Items.Count - 1

            If i = LstTo.Items.Count - 1 Then
                result += LstTo.Items.Item(i)
            Else
                result += LstTo.Items.Item(i) + ","

            End If
        Next
        'Check if there is any selected field
        If LstTo.Items.Count <> 0 Then
            Dim connStr As String = "server=localhost;" & "username=root;" & "password=admin;" & "database=in-out "
            Dim conn As New MySqlConnection(connStr)
            Dim SQLCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter

            Dim selectQueryStr As String = "select " & result & " from nonmotorinsurance"

            'NonMotorData.Clear()


            SQLCommand.CommandText = selectQueryStr
            SQLCommand.Connection = conn
            conn.Open()
            myAdapter.SelectCommand = SQLCommand
            myAdapter.Fill(NonMotorData, "nonmotorinsurance")

            DataGrid1.SetDataBinding(NonMotorData, "nonmotorinsurance")


            conn.Close()
            NonMotorData1 = NonMotorData
            If NonMotorData.Tables("nonmotorinsurance").Rows.Count = 0 Then
                DataGrid1.DataSource = Nothing
                DataGrid1.Refresh()
                MessageBox.Show("No record found", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Else

            MessageBox.Show("There is no selected field for display!", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        DataGrid1.DataSource = Nothing
        DataGrid1.Refresh()

        Dim i As Integer
        For i = 0 To LstTo.Items.Count - 1
            LstFrom.Items.Add(LstTo.Items(i))

        Next
        LstTo.Items.Clear()


    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        Dim i As Integer
        For i = 0 To LstFrom.Items.Count - 1
            LstTo.Items.Add(LstFrom.Items(i))

        Next
        LstFrom.Items.Clear()
    End Sub

    Private Sub btnUnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnselect.Click
        Dim i As Integer
        For i = 0 To LstTo.Items.Count - 1
            LstFrom.Items.Add(LstTo.Items(i))

        Next
        LstTo.Items.Clear()
    End Sub



    Private Sub btnMoveTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveTo.Click
        If Not LstFrom.SelectedItem = Nothing Then

            LstTo.Items.Add(LstFrom.SelectedItem)
            LstFrom.Items.Remove(LstFrom.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnMoveBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveBack.Click
        If Not LstTo.SelectedItem = Nothing Then

            LstFrom.Items.Add(LstTo.SelectedItem)
            LstTo.Items.Remove(LstTo.SelectedItem)

        Else
            MessageBox.Show("You can not select empty field", "Field Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmTemplate
        'frm.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LstTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstTo.SelectedIndexChanged

    End Sub

    Private Sub LstFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFrom.SelectedIndexChanged

    End Sub



    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
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
            For intColumn = 0 To NonMotorData1.Tables(0).Columns.Count - 1
                .Cells(1, intColumn + 1).Value = NonMotorData1.Tables(0).Columns(intColumn).ColumnName.ToString
            Next
            'For displaying the column value row-by-row in the the excel file.
            For intRow = 1 To NonMotorData1.Tables(0).Rows.Count
                For intColumnValue = 0 To NonMotorData1.Tables(0).Columns.Count - 1
                    .Cells(intRow + 1, intColumnValue + 1).Value = NonMotorData1.Tables(0).Rows(intRow - 1).ItemArray(intColumnValue).ToString
                Next
            Next
            Dim z As Integer


            'strFileName = InputBox("Please enter the file name.", "Swapnil")
            strExcelFile = strAppPath & "employee"
            .ActiveWorkbook().SaveAs(strExcelFile)
            .ActiveWorkbook.Close()
        End With
        MessageBox.Show("File exported sucessfully.", "Exporting done", MessageBoxButtons.OK, MessageBoxIcon.Information)
NormalExit:
        Excel.Quit()
        Excel = Nothing
        GC.Collect()



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class



