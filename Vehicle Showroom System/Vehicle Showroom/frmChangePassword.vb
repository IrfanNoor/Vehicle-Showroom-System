Imports MySql.Data.MySqlClient
Public Class frmChangePassword
    Inherits System.Windows.Forms.Form
    Dim conn As New MySqlConnection
    Dim hasil As Integer
    Dim UpdateQuery As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter


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
    Friend WithEvents frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmChangePassword))
        Me.frame1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblUsername = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdChange = New System.Windows.Forms.Button
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'frame1
        '
        Me.frame1.Controls.Add(Me.Label6)
        Me.frame1.Controls.Add(Me.PictureBox1)
        Me.frame1.Controls.Add(Me.lblUsername)
        Me.frame1.Controls.Add(Me.cmdClose)
        Me.frame1.Controls.Add(Me.cmdChange)
        Me.frame1.Controls.Add(Me.txtConfirmPassword)
        Me.frame1.Controls.Add(Me.txtNewPassword)
        Me.frame1.Controls.Add(Me.txtOldPassword)
        Me.frame1.Controls.Add(Me.Label4)
        Me.frame1.Controls.Add(Me.Label3)
        Me.frame1.Controls.Add(Me.Label2)
        Me.frame1.Controls.Add(Me.Label1)
        Me.frame1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame1.ForeColor = System.Drawing.Color.White
        Me.frame1.Location = New System.Drawing.Point(32, 26)
        Me.frame1.Name = "frame1"
        Me.frame1.Size = New System.Drawing.Size(464, 208)
        Me.frame1.TabIndex = 0
        Me.frame1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Change User Access Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 56)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(176, 72)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(160, 19)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Location = New System.Drawing.Point(264, 182)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 20)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "Close"
        '
        'cmdChange
        '
        Me.cmdChange.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdChange.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChange.ForeColor = System.Drawing.Color.Black
        Me.cmdChange.Location = New System.Drawing.Point(176, 182)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(72, 20)
        Me.cmdChange.TabIndex = 8
        Me.cmdChange.Text = "Change"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(176, 150)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(160, 23)
        Me.txtConfirmPassword.TabIndex = 7
        Me.txtConfirmPassword.Text = ""
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(176, 124)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(160, 23)
        Me.txtNewPassword.TabIndex = 6
        Me.txtNewPassword.Text = ""
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(176, 98)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(160, 23)
        Me.txtOldPassword.TabIndex = 5
        Me.txtOldPassword.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confrim New Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'frmChangePassword
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(510, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmChangePassword"
        Me.Text = "Change Password"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get username variables from login form
        Dim F2 As New frmLogin
        Me.lblUsername.Text = F2.NuNameTB.Text
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "
        'validate entries
        If txtOldPassword.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please Complete the Information", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Len(txtNewPassword.Text) <= 3 Or Len(txtConfirmPassword.Text) <= 3 Then
            MessageBox.Show("Please Enter Password More than 3 Character", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtNewPassword.Focus()
        ElseIf (txtNewPassword.Text <> txtConfirmPassword.Text) Then
            MessageBox.Show("Password Does Not Match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtNewPassword.Focus()
        Else
            conn.Open()
            UpdateQuery = "Update user set password='" & txtConfirmPassword.Text & "' " _
                            & "Where username='" & lblUsername.Text & " ';"
            myCommand = New MySqlCommand(UpdateQuery, conn)
            hasil = myCommand.ExecuteNonQuery()
            MessageBox.Show("Password has been succesfully Changed", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub
End Class

