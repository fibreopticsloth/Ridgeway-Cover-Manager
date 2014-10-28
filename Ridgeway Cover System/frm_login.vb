Imports MySql.Data.MySqlClient
Public Class frm_login

    'DECLARATIONS
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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
                MsgBox("Incorrect username or password.")
            Else
                MsgBox("Cannot connect to the server. Please ensure you are connected to the internet.")
            End If
        End If

    End Sub

    'LOGIN
    Public Sub login()
        btn_login.Text = "Please wait"
        rememberlogin()
        checktype()
        My.Settings.CurrentUsername = txt_username.Text
        My.Settings.Save()
        frm_home.lbl_currentuser.Text = "Logged in as " + My.Settings.CurrentUsername

        frm_home.load_home()
        timer_fadeout.Enabled = True
        timer_fadeout.Start()
        'frm_home.BringToFront()
        'frm_home.ShowInTaskbar = True
        'Me.Dispose()
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
        CheckUser()
    End Sub

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        MsgBox("Ridgeway Cover Manager automatically detects your username from your Windows user account. Please ensure you are logged into your personal user account when signing up.")
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

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub timer_fadeout_Tick(sender As Object, e As EventArgs) Handles timer_fadeout.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.1
        Else
            timer_fadeout.Stop()
            timer_fadeout.Enabled = False
            Me.Dispose()
        End If
    End Sub
End Class
