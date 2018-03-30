Imports MySql.Data.MySqlClient
Public Class frmLogin
    Inherits System.Windows.Forms.Form
    Public Shared NuNameTB As TextBox
    Dim conn As New MySqlConnection
    Dim hasil As Integer
    Dim SQLLogin As String
    Dim myLoginCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim mydata As New DataSet
    Dim mytable As New DataTable
    Dim callFrmMain As New frmmain





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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(120, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(168, 23)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = ""
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(120, 59)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(168, 23)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdLogin)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 130)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Location = New System.Drawing.Point(208, 98)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 19)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.ForeColor = System.Drawing.Color.Black
        Me.cmdLogin.Location = New System.Drawing.Point(120, 98)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(80, 19)
        Me.cmdLogin.TabIndex = 3
        Me.cmdLogin.Text = "Log In"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 49)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter Username and Password to Login In"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(330, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;" _
          & "username=root;" _
          & "password=admin;" _
          & "database=in-out "

        'validate entriees
        If txtUsername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please Fill In the Information", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'if admin login
        If txtUsername.Text = "admin" Then
            SQLLogin = "Select * from user where username='" & txtUsername.Text & "'AND password='" & txtpassword.Text & "' "
            myLoginCommand.Connection = conn
            conn.Open()
            myLoginCommand.CommandText = SQLLogin
            myAdapter.SelectCommand = myLoginCommand
            myAdapter.Fill(mydata)
            If mydata.Tables(0).Rows.Count = 1 Then
                MessageBox.Show("Welcome: '" & txtUsername.Text & "'", "Succesfull Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                callFrmMain.StatusBarPanel2.Text = txtUsername.Text
                'Assing(Variables)
                NuNameTB = txtUsername
                Me.Hide()

                callFrmMain.Show()


            Else : MessageBox.Show("Wrong Authentication Password/Username", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Text = ""
                txtpassword.Text = ""
                txtUsername.Focus()
                conn.Close()
                conn.Dispose()
                Exit Sub

            End If
        End If

        'if not admin
        If txtUsername.Text <> "admin" Then
            SQLLogin = "Select * from user where username='" & txtUsername.Text & "'AND password='" & txtpassword.Text & "' "
            conn.Open()
            myLoginCommand.Connection = conn
            myLoginCommand.CommandText = SQLLogin
            myAdapter.SelectCommand = myLoginCommand
            myAdapter.Fill(mydata)

            If mydata.Tables(0).Rows.Count = 1 Then
                MessageBox.Show("Welcome: '" & txtUsername.Text & "'", "Succesfull Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                conn.Dispose()
                callFrmMain.StatusBarPanel2.Text = txtUsername.Text
                'Assing Variables
                NuNameTB = txtUsername
                Me.Hide()
                callFrmMain.mnuAddUser.Enabled = False
                callFrmMain.mnuDeleteUser.Enabled = False
                callFrmMain.mnuDataList.Enabled = False
                callFrmMain.Show()

            Else : MessageBox.Show("Wrong Authentication Password/Username", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Text = ""
                txtpassword.Text = ""
                txtUsername.Focus()
                conn.Close()
                conn.Dispose()
            End If
        End If



    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        End
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

