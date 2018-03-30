Imports MySql.Data.MySqlClient

Public Class FrmDataManagement
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
    Friend WithEvents LstFuel As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdLocation As System.Windows.Forms.Button
    Friend WithEvents LstLocation As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFuel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LstVehicle As System.Windows.Forms.ListBox
    Friend WithEvents cmdVehicle As System.Windows.Forms.Button
    Friend WithEvents cmdInsurance As System.Windows.Forms.Button
    Friend WithEvents LstInsurance As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDataManagement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdVehicle = New System.Windows.Forms.Button
        Me.LstVehicle = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdLocation = New System.Windows.Forms.Button
        Me.LstLocation = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdFuel = New System.Windows.Forms.Button
        Me.LstFuel = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdInsurance = New System.Windows.Forms.Button
        Me.LstInsurance = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdVehicle)
        Me.GroupBox1.Controls.Add(Me.LstVehicle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdLocation)
        Me.GroupBox1.Controls.Add(Me.LstLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdFuel)
        Me.GroupBox1.Controls.Add(Me.LstFuel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(48, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motor Insurance Data"
        '
        'cmdVehicle
        '
        Me.cmdVehicle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdVehicle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVehicle.ForeColor = System.Drawing.Color.Black
        Me.cmdVehicle.Location = New System.Drawing.Point(320, 221)
        Me.cmdVehicle.Name = "cmdVehicle"
        Me.cmdVehicle.Size = New System.Drawing.Size(104, 20)
        Me.cmdVehicle.TabIndex = 8
        Me.cmdVehicle.Text = "Add Vehicle "
        '
        'LstVehicle
        '
        Me.LstVehicle.BackColor = System.Drawing.Color.White
        Me.LstVehicle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVehicle.ItemHeight = 16
        Me.LstVehicle.Location = New System.Drawing.Point(320, 46)
        Me.LstVehicle.Name = "LstVehicle"
        Me.LstVehicle.Size = New System.Drawing.Size(104, 148)
        Me.LstVehicle.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(320, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vehicle List:"
        '
        'cmdLocation
        '
        Me.cmdLocation.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocation.ForeColor = System.Drawing.Color.Black
        Me.cmdLocation.Location = New System.Drawing.Point(160, 221)
        Me.cmdLocation.Name = "cmdLocation"
        Me.cmdLocation.Size = New System.Drawing.Size(104, 20)
        Me.cmdLocation.TabIndex = 5
        Me.cmdLocation.Text = "Add Location"
        '
        'LstLocation
        '
        Me.LstLocation.BackColor = System.Drawing.Color.White
        Me.LstLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstLocation.ItemHeight = 16
        Me.LstLocation.Location = New System.Drawing.Point(160, 46)
        Me.LstLocation.Name = "LstLocation"
        Me.LstLocation.Size = New System.Drawing.Size(104, 148)
        Me.LstLocation.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(160, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Location List:"
        '
        'cmdFuel
        '
        Me.cmdFuel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFuel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFuel.ForeColor = System.Drawing.Color.Black
        Me.cmdFuel.Location = New System.Drawing.Point(16, 221)
        Me.cmdFuel.Name = "cmdFuel"
        Me.cmdFuel.Size = New System.Drawing.Size(104, 20)
        Me.cmdFuel.TabIndex = 2
        Me.cmdFuel.Text = "Add Fuel"
        '
        'LstFuel
        '
        Me.LstFuel.BackColor = System.Drawing.Color.White
        Me.LstFuel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFuel.ItemHeight = 16
        Me.LstFuel.Location = New System.Drawing.Point(16, 46)
        Me.LstFuel.Name = "LstFuel"
        Me.LstFuel.Size = New System.Drawing.Size(104, 148)
        Me.LstFuel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fuel Type List"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To remove an item from the list,double click the item"
        '
        'cmdInsurance
        '
        Me.cmdInsurance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdInsurance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsurance.ForeColor = System.Drawing.Color.Black
        Me.cmdInsurance.Location = New System.Drawing.Point(40, 221)
        Me.cmdInsurance.Name = "cmdInsurance"
        Me.cmdInsurance.Size = New System.Drawing.Size(104, 20)
        Me.cmdInsurance.TabIndex = 11
        Me.cmdInsurance.Text = "Add Insurance "
        '
        'LstInsurance
        '
        Me.LstInsurance.BackColor = System.Drawing.Color.White
        Me.LstInsurance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstInsurance.ItemHeight = 16
        Me.LstInsurance.Location = New System.Drawing.Point(40, 46)
        Me.LstInsurance.Name = "LstInsurance"
        Me.LstInsurance.Size = New System.Drawing.Size(104, 148)
        Me.LstInsurance.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Non-Motor Insurance List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdInsurance)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LstInsurance)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(504, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 260)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Non Motor Insurance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 377)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(312, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 20)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Add Vehicle "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(304, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 19)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add Vehicle "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(40, 332)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 26)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(96, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 45)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Data List Management"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(544, 338)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 20)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Close"
        '
        'FrmDataManagement
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(744, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDataManagement"
        Me.Text = "Data List Management"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim conn As New MySqlConnection
    'for fueltype
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim FuelDataTable As New DataTable
    Dim SQLLoadFuel As String
    Dim SQLDeleteFuel As String
    Dim SQLAddFuel As String
    Dim itemFuel As String
    'for location
    Dim locationDataTable As New DataTable
    Dim SQLLoadLocation As String
    Dim SQLDeletelocation As String
    Dim SQLAddLocation As String
    Dim itemLocation As String
    'for vehicle
    Dim vehicleDataTable As New DataTable
    Dim SQLLoadVehicle As String
    Dim SQLDeleteVehicle As String
    Dim SQLAddVehicle As String
    Dim itemVehicle As String
    'for vehicle
    Dim InsuranceDataTable As New DataTable
    Dim SQLLoadinsurance As String
    Dim SQLDeleteInsurance As String
    Dim SQLAddInsurance As String
    Dim itemInsurance As String


    Private Sub DataManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "
        'load fuel
        SQLLoadFuel = "SELECT * from fuel"
        conn.Open()
        myCommand.Connection = conn
        myCommand.CommandText = SQLLoadFuel
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(FuelDataTable)

        LstFuel.DataSource = FuelDataTable
        LstFuel.DisplayMember = "fuel"
        LstFuel.ValueMember = "FuelType"
        conn.Close()

        'load fuel
        SQLLoadLocation = "SELECT * from location"
        conn.Open()
        myCommand.Connection = conn
        myCommand.CommandText = SQLLoadLocation
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(locationDataTable)

        LstLocation.DataSource = locationDataTable
        LstLocation.DisplayMember = "location"
        LstLocation.ValueMember = "Location"
        conn.Close()

        'load vehicle
        SQLLoadVehicle = "SELECT * from vehicle"
        conn.Open()
        myCommand.Connection = conn
        myCommand.CommandText = SQLLoadVehicle
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(vehicleDataTable)

        Lstvehicle.DataSource = vehicleDataTable
        LstVehicle.DisplayMember = "vehicle"
        LstVehicle.ValueMember = "VehicleType"
        conn.Close()

        'load insurance
        SQLLoadinsurance = "SELECT * from insurance_type"
        conn.Open()
        myCommand.Connection = conn
        myCommand.CommandText = SQLLoadinsurance
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(InsuranceDataTable)

        LstInsurance.DataSource = InsuranceDataTable
        LstInsurance.DisplayMember = "insurance"
        LstInsurance.ValueMember = "InsuranceType"
        conn.Close()
    End Sub
    Private Sub LstFuel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstFuel.DoubleClick
        SQLDeleteFuel = "DELETE FROM fuel "
        SQLDeleteFuel &= "WHERE fueltype=’" & LstFuel.SelectedValue & "‘"
        itemFuel = LstFuel.SelectedValue
        If LstFuel.SelectedValue = Nothing Then
            MessageBox.Show("Unable to delete or item is not selected", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("This Will Remove the selected Fuel type", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                conn.Open()
                myCommand = New MySqlCommand(SQLDeleteFuel, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Item Has Been Removed", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataRow In FuelDataTable.Rows
                    If row("FuelType") = itemFuel Then
                        row.Delete()

                    End If

                Next
                FuelDataTable.AcceptChanges()
            End If
        End If
        
        conn.Close()

    End Sub

    Private Sub cmdFuel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFuel.Click
        Dim newfuel As String
        newfuel = InputBox("Please enter the New Fuel Data", "<Please Enter Here>")

        If newfuel <> "" Then
            Try
                SQLAddFuel = "INSERT INTO fuel(fueltype) values (’" & newfuel & "‘)"
                myCommand.CommandText = SQLAddFuel
                myCommand.Connection = conn
                conn.Open()
                myCommand.ExecuteNonQuery()
                MessageBox.Show("Data has been succesfully added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                'reload item
                SQLLoadFuel = "SELECT * from fuel"
                conn.Open()
                myCommand.Connection = conn
                myCommand.CommandText = SQLLoadFuel
                myAdapter.SelectCommand = myCommand
                FuelDataTable.Clear()
                myAdapter.Fill(FuelDataTable)
                LstFuel.DataSource = FuelDataTable
                LstFuel.DisplayMember = "fuel"
                LstFuel.ValueMember = "FuelType"
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show("Cannot add existing Fuel Type!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("No new fuel item is added to database", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocation.Click
        Dim newlocation As String
        newlocation = InputBox("Please enter the New Location Data", "<Please Enter Here>")


        If newlocation <> "" Then

            Try
                SQLAddLocation = "INSERT INTO location(Location) values (’" & newlocation & "‘)"
                myCommand.CommandText = SQLAddLocation
                myCommand.Connection = conn
                conn.Open()
                myCommand.ExecuteNonQuery()
                MessageBox.Show("Data has been succesfully added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                'reload item
                SQLLoadLocation = "SELECT * from location"
                conn.Open()
                myCommand.Connection = conn
                myCommand.CommandText = SQLLoadLocation
                myAdapter.SelectCommand = myCommand
                locationDataTable.Clear()
                myAdapter.Fill(locationDataTable)
                LstLocation.DataSource = locationDataTable
                LstLocation.DisplayMember = "location"
                LstLocation.ValueMember = "Location"
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show("Cannot add existing location!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Else
            MessageBox.Show("No new Location item is added to database", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub LstLocation_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstLocation.DoubleClick
        SQLDeletelocation = "DELETE FROM location "
        SQLDeletelocation &= "WHERE Location=’" & LstLocation.SelectedValue & "‘"
        itemLocation = LstLocation.SelectedValue
        If LstFuel.SelectedValue = Nothing Then
            MessageBox.Show("Unable to delete or item is not selected", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("This Will Remove the selected Location", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                conn.Open()
                myCommand = New MySqlCommand(SQLDeletelocation, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Location Has Been Removed", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataRow In locationDataTable.Rows
                    If row("location") = itemLocation Then
                        row.Delete()

                    End If

                Next
                locationDataTable.AcceptChanges()
            End If
        End If

        conn.Close()
    End Sub
    Private Sub LstVehicle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstVehicle.DoubleClick
        SQLDeleteVehicle = "DELETE FROM vehicle "
        SQLDeleteVehicle &= "WHERE VehicleType=’" & LstVehicle.SelectedValue & "‘"
        itemVehicle = LstVehicle.SelectedValue
        If LstVehicle.SelectedValue = Nothing Then
            MessageBox.Show("Unable to delete or item is not selected", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("This Will Remove the selected vehicle", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                conn.Open()
                myCommand = New MySqlCommand(SQLDeleteVehicle, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("vehicle Has Been Removed", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataRow In vehicleDataTable.Rows
                    If row("VehicleType") = itemVehicle Then
                        row.Delete()

                    End If

                Next
                vehicleDataTable.AcceptChanges()
            End If
        End If

        conn.Close()
    End Sub


    Private Sub LstInsurance_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstInsurance.DoubleClick
        SQLDeleteInsurance = "DELETE FROM insurance_type "
        SQLDeleteInsurance &= "WHERE InsuranceType=’" & LstInsurance.SelectedValue & "‘"
        itemInsurance = LstInsurance.SelectedValue
        If LstInsurance.SelectedValue = Nothing Then
            MessageBox.Show("Unable to delete or item is not selected", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("This Will Remove the selected Insurance", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                conn.Open()
                myCommand = New MySqlCommand(SQLDeleteInsurance, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Insurance Has Been Removed", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataRow In InsuranceDataTable.Rows
                    If row("InsuranceType") = itemInsurance Then
                        row.Delete()

                    End If

                Next
                InsuranceDataTable.AcceptChanges()
            End If
        End If

        conn.Close()
    End Sub

    Private Sub cmdInsurance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsurance.Click
        Dim newInsurance As String
        newInsurance = InputBox("Please enter the New Insurance Type Data", "<Please Enter Here>")

        If newInsurance <> "" Then
            Try
                SQLAddInsurance = "INSERT INTO insurance_type(InsuranceType) values (’" & newInsurance & "‘)"
                myCommand.CommandText = SQLAddInsurance
                myCommand.Connection = conn
                conn.Open()
                myCommand.ExecuteNonQuery()
                MessageBox.Show("Insurance has been succesfully added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                'reload item
                SQLLoadinsurance = "SELECT * from insurance_type"
                conn.Open()
                myCommand.Connection = conn
                myCommand.CommandText = SQLLoadinsurance
                myAdapter.SelectCommand = myCommand
                InsuranceDataTable.Clear()
                myAdapter.Fill(InsuranceDataTable)
                LstInsurance.DataSource = InsuranceDataTable
                LstInsurance.DisplayMember = "insurance_type"
                LstInsurance.ValueMember = "InsuranceType"
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show("Cannot add existing Insurance Type!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Else
            MessageBox.Show("No new Insurance item is added to database", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVehicle.Click
        Dim newVehicle As String
        newVehicle = InputBox("Please enter the New Vehicle Data", "<Please Enter Here>")

        If newVehicle <> "" Then
            Try
                SQLAddVehicle = "INSERT INTO vehicle(VehicleType) values (’" & newVehicle & "‘)"
                myCommand.CommandText = SQLAddVehicle
                myCommand.Connection = conn
                conn.Open()
                myCommand.ExecuteNonQuery()
                MessageBox.Show("Vehicle has been succesfully added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                'reload item
                SQLLoadVehicle = "SELECT * from vehicle"
                conn.Open()
                myCommand.Connection = conn
                myCommand.CommandText = SQLLoadVehicle
                myAdapter.SelectCommand = myCommand
                vehicleDataTable.Clear()
                myAdapter.Fill(vehicleDataTable)
                LstVehicle.DataSource = vehicleDataTable
                LstVehicle.DisplayMember = "vehicle"
                LstVehicle.ValueMember = "VehicleType"
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show("Cannot add existing Vehicle Type!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("No new Vehicle item is added to database", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LstInsurance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstInsurance.SelectedIndexChanged

    End Sub

    Private Sub cmdTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
