Public Class Form3
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
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox17 = New System.Windows.Forms.CheckBox
        Me.CheckBox30 = New System.Windows.Forms.CheckBox
        Me.CheckBox24 = New System.Windows.Forms.CheckBox
        Me.CheckBox25 = New System.Windows.Forms.CheckBox
        Me.CheckBox26 = New System.Windows.Forms.CheckBox
        Me.CheckBox27 = New System.Windows.Forms.CheckBox
        Me.CheckBox28 = New System.Windows.Forms.CheckBox
        Me.CheckBox29 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox18 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.CheckBox19 = New System.Windows.Forms.CheckBox
        Me.CheckBox20 = New System.Windows.Forms.CheckBox
        Me.CheckBox21 = New System.Windows.Forms.CheckBox
        Me.CheckBox22 = New System.Windows.Forms.CheckBox
        Me.CheckBox23 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox17)
        Me.GroupBox1.Controls.Add(Me.CheckBox30)
        Me.GroupBox1.Controls.Add(Me.CheckBox24)
        Me.GroupBox1.Controls.Add(Me.CheckBox25)
        Me.GroupBox1.Controls.Add(Me.CheckBox26)
        Me.GroupBox1.Controls.Add(Me.CheckBox27)
        Me.GroupBox1.Controls.Add(Me.CheckBox28)
        Me.GroupBox1.Controls.Add(Me.CheckBox29)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.CheckBox12)
        Me.GroupBox1.Controls.Add(Me.CheckBox18)
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.Controls.Add(Me.CheckBox15)
        Me.GroupBox1.Controls.Add(Me.CheckBox16)
        Me.GroupBox1.Controls.Add(Me.CheckBox19)
        Me.GroupBox1.Controls.Add(Me.CheckBox20)
        Me.GroupBox1.Controls.Add(Me.CheckBox21)
        Me.GroupBox1.Controls.Add(Me.CheckBox22)
        Me.GroupBox1.Controls.Add(Me.CheckBox23)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(-66, -28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 328)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please Select Which Field To Choose"
        '
        'CheckBox17
        '
        Me.CheckBox17.Location = New System.Drawing.Point(160, 128)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox17.TabIndex = 27
        Me.CheckBox17.Text = "Status"
        '
        'CheckBox30
        '
        Me.CheckBox30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox30.ForeColor = System.Drawing.Color.Black
        Me.CheckBox30.Location = New System.Drawing.Point(296, 152)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox30.TabIndex = 26
        Me.CheckBox30.Text = "Inspection Time"
        '
        'CheckBox24
        '
        Me.CheckBox24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox24.ForeColor = System.Drawing.Color.Black
        Me.CheckBox24.Location = New System.Drawing.Point(160, 296)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox24.TabIndex = 21
        Me.CheckBox24.Text = "Vehicle Sum Insured"
        '
        'CheckBox25
        '
        Me.CheckBox25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox25.ForeColor = System.Drawing.Color.Black
        Me.CheckBox25.Location = New System.Drawing.Point(296, 32)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox25.TabIndex = 20
        Me.CheckBox25.Text = "Excess Applicable"
        '
        'CheckBox26
        '
        Me.CheckBox26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox26.ForeColor = System.Drawing.Color.Black
        Me.CheckBox26.Location = New System.Drawing.Point(296, 56)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox26.TabIndex = 25
        Me.CheckBox26.Text = "Basic Premium"
        '
        'CheckBox27
        '
        Me.CheckBox27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox27.ForeColor = System.Drawing.Color.Black
        Me.CheckBox27.Location = New System.Drawing.Point(296, 80)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox27.TabIndex = 24
        Me.CheckBox27.Text = "NCT/DTT"
        '
        'CheckBox28
        '
        Me.CheckBox28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox28.ForeColor = System.Drawing.Color.Black
        Me.CheckBox28.Location = New System.Drawing.Point(296, 104)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox28.TabIndex = 23
        Me.CheckBox28.Text = "Total Payable"
        '
        'CheckBox29
        '
        Me.CheckBox29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox29.ForeColor = System.Drawing.Color.Black
        Me.CheckBox29.Location = New System.Drawing.Point(296, 128)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox29.TabIndex = 22
        Me.CheckBox29.Text = "Inspection Date"
        '
        'CheckBox3
        '
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox3.ForeColor = System.Drawing.Color.Black
        Me.CheckBox3.Location = New System.Drawing.Point(16, 80)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Casis No"
        '
        'CheckBox4
        '
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox4.ForeColor = System.Drawing.Color.Black
        Me.CheckBox4.Location = New System.Drawing.Point(16, 104)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(104, 12)
        Me.CheckBox4.TabIndex = 2
        Me.CheckBox4.Text = "Manufacturer"
        '
        'CheckBox2
        '
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(16, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "EngineNo"
        '
        'CheckBox1
        '
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(16, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "RegistrantionNo"
        '
        'CheckBox5
        '
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox5.ForeColor = System.Drawing.Color.Black
        Me.CheckBox5.Location = New System.Drawing.Point(16, 128)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox5.TabIndex = 5
        Me.CheckBox5.Text = "ModelName"
        '
        'CheckBox6
        '
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox6.ForeColor = System.Drawing.Color.Black
        Me.CheckBox6.Location = New System.Drawing.Point(16, 152)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox6.TabIndex = 4
        Me.CheckBox6.Text = "Engine Power"
        '
        'CheckBox7
        '
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox7.ForeColor = System.Drawing.Color.Black
        Me.CheckBox7.Location = New System.Drawing.Point(16, 176)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox7.TabIndex = 9
        Me.CheckBox7.Text = "Fuel Type"
        '
        'CheckBox8
        '
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox8.ForeColor = System.Drawing.Color.Black
        Me.CheckBox8.Location = New System.Drawing.Point(16, 200)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(104, 12)
        Me.CheckBox8.TabIndex = 8
        Me.CheckBox8.Text = "Vehicle Type"
        '
        'CheckBox9
        '
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox9.ForeColor = System.Drawing.Color.Black
        Me.CheckBox9.Location = New System.Drawing.Point(16, 224)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox9.TabIndex = 7
        Me.CheckBox9.Text = "Year Manufactured"
        '
        'CheckBox10
        '
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox10.ForeColor = System.Drawing.Color.Black
        Me.CheckBox10.Location = New System.Drawing.Point(16, 248)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox10.TabIndex = 6
        Me.CheckBox10.Text = "Year Registered"
        '
        'CheckBox11
        '
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox11.ForeColor = System.Drawing.Color.Black
        Me.CheckBox11.Location = New System.Drawing.Point(16, 272)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox11.TabIndex = 11
        Me.CheckBox11.Text = "License Duration"
        '
        'CheckBox12
        '
        Me.CheckBox12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox12.ForeColor = System.Drawing.Color.Black
        Me.CheckBox12.Location = New System.Drawing.Point(16, 296)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox12.TabIndex = 10
        Me.CheckBox12.Text = "BMD/BGK"
        '
        'CheckBox18
        '
        Me.CheckBox18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox18.ForeColor = System.Drawing.Color.Black
        Me.CheckBox18.Location = New System.Drawing.Point(160, 152)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox18.TabIndex = 15
        Me.CheckBox18.Text = "LPKP Form No"
        '
        'CheckBox13
        '
        Me.CheckBox13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox13.ForeColor = System.Drawing.Color.Black
        Me.CheckBox13.Location = New System.Drawing.Point(160, 32)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox13.TabIndex = 13
        Me.CheckBox13.Text = "BTM"
        '
        'CheckBox14
        '
        Me.CheckBox14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox14.ForeColor = System.Drawing.Color.Black
        Me.CheckBox14.Location = New System.Drawing.Point(160, 56)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(104, 12)
        Me.CheckBox14.TabIndex = 12
        Me.CheckBox14.Text = "Driver Name"
        '
        'CheckBox15
        '
        Me.CheckBox15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox15.ForeColor = System.Drawing.Color.Black
        Me.CheckBox15.Location = New System.Drawing.Point(160, 80)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox15.TabIndex = 11
        Me.CheckBox15.Text = "Location"
        '
        'CheckBox16
        '
        Me.CheckBox16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox16.ForeColor = System.Drawing.Color.Black
        Me.CheckBox16.Location = New System.Drawing.Point(160, 104)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox16.TabIndex = 10
        Me.CheckBox16.Text = "Series No"
        '
        'CheckBox19
        '
        Me.CheckBox19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox19.ForeColor = System.Drawing.Color.Black
        Me.CheckBox19.Location = New System.Drawing.Point(160, 176)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox19.TabIndex = 14
        Me.CheckBox19.Text = "File Reference No"
        '
        'CheckBox20
        '
        Me.CheckBox20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox20.ForeColor = System.Drawing.Color.Black
        Me.CheckBox20.Location = New System.Drawing.Point(160, 200)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(128, 16)
        Me.CheckBox20.TabIndex = 19
        Me.CheckBox20.Text = "License Reference No"
        '
        'CheckBox21
        '
        Me.CheckBox21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox21.ForeColor = System.Drawing.Color.Black
        Me.CheckBox21.Location = New System.Drawing.Point(160, 224)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox21.TabIndex = 18
        Me.CheckBox21.Text = "License Expiry"
        '
        'CheckBox22
        '
        Me.CheckBox22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox22.ForeColor = System.Drawing.Color.Black
        Me.CheckBox22.Location = New System.Drawing.Point(160, 248)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox22.TabIndex = 17
        Me.CheckBox22.Text = "Policy No"
        '
        'CheckBox23
        '
        Me.CheckBox23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox23.ForeColor = System.Drawing.Color.Black
        Me.CheckBox23.Location = New System.Drawing.Point(160, 272)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox23.TabIndex = 16
        Me.CheckBox23.Text = "Policy Period"
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 16)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
