Imports MySql.Data.MySqlClient
Public Class frm_login

    'DECLARATIONS
    Dim drag As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer
    Dim loadvalue As Integer = 0

    'FORM LOAD
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrievelogin()
        txt_username.SelectionStart = txt_username.Text.Length
        txt_username.SelectionLength = 0
    End Sub

    'RETRIEVE LOGIN IF SAVED
    Public Sub retrievelogin()
        txt_username.Text = My.Settings.RememberUsername
        txt_password.Text = My.Settings.RememberPassword
        If My.Settings.RememberUsername IsNot "" Then
            remember.CheckState = CheckState.Checked
        Else
            remember.CheckState = CheckState.Unchecked
        End If
    End Sub

    'CHECK USER
    Public Sub CheckUser()

        If CheckData("SELECT * FROM users WHERE username = '" & txt_username.Text & "' AND password = '" & hash(txt_password.Text) & "'") Then
            login()
        Else
            If CheckConnection() Then
                If CheckData("SELECT * FROM users WHERE username = '" & txt_username.Text & "'") Then
                    MsgBox("Incorrect username or password.")
                Else
                    MsgBox("This user account does not exist")
                End If
            Else
                MsgBox("Cannot connect to the server. Please ensure you are connected to the internet.")
            End If
                btn_login.Text = "Log In"
            End If

    End Sub

    'LOGIN
    Public Sub login()
        rememberlogin()
        checktype()
        My.Settings.CurrentUsername = txt_username.Text
        My.Settings.Save()

        frm_home.load_home()
        frm_home.Show()
        frm_home.Location = Me.Location
        Me.BringToFront()

        timer_fadeout.Enabled = True
        timer_fadeout.Start()
    End Sub

    'CHECK USER TYPE
    Public Sub checktype()
        Dim ds As DataSet = NewDataCommand("SELECT * FROM users WHERE username = '" & txt_username.Text & "'")
        My.Settings.CurrentUserType = ds.Tables(0).Rows(0).Item(3).ToString
        My.Settings.Save()
        ds.Reset()
    End Sub

    'SAVE USER LOGIN DETAILS
    Public Sub rememberlogin()
        If remember.CheckState = CheckState.Checked Then
            My.Settings.RememberUsername = txt_username.Text
            My.Settings.RememberPassword = txt_password.Text
            My.Settings.Save()
        Else
            My.Settings.RememberUsername = ""
            My.Settings.RememberPassword = ""
            My.Settings.Save()
        End If
    End Sub

    'FORGET ME
    Public Sub forgetme()
        If Not My.Settings.RememberUsername = "" Then
            txt_username.ResetText()
            txt_password.ResetText()
            remember.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub txt_username_MouseDown(sender As Object, e As MouseEventArgs) Handles txt_username.MouseDown
        forgetme()
    End Sub
    Private Sub txt_password_MouseDown(sender As Object, e As MouseEventArgs) Handles txt_password.MouseDown
        forgetme()
    End Sub

    '---BUTTON ACTIONS---

    'LOGIN BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        btn_login.Text = "Please wait"
        CheckUser()
    End Sub

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles txt_signup.Click
        Me.Hide()
        MsgBox("Ridgeway Cover Manager automatically detects your username from your Windows user account." + vbNewLine + "Please ensure you are logged into your personal user account when signing up.")
        frm_signup.Show()
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Button8_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            frm_home.Top = Windows.Forms.Cursor.Position.Y - mousey
            frm_home.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub pic_logo_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub pic_logo_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_logo.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pic_logo_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_logo.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            frm_home.Top = Windows.Forms.Cursor.Position.Y - mousey
            frm_home.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles pic_logo.MouseUp
        drag = False
    End Sub

    Private Sub timer_fadeout_Tick(sender As Object, e As EventArgs) Handles timer_fadeout.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.1
        Else
            Me.ShowInTaskbar = False
            Me.Dispose()
            timer_fadeout.Stop()
            timer_fadeout.Enabled = False
        End If
    End Sub

    Private Sub frm_login_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)

        e.Graphics.DrawRectangle(Pens.DimGray, rect)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        frm_home.Visible = False
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            frm_home.Top = Windows.Forms.Cursor.Position.Y - mousey
            frm_home.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label3_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        MsgBox("If you have forgotton your password, please contact IT support.")
    End Sub

End Class
