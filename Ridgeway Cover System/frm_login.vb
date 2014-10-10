Imports MySql.Data.MySqlClient
Public Class frm_login

    'DECLARATIONS
    Dim rd As MySqlDataReader

    'FORM LOAD
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrievelogin()
    End Sub

    'RETRIEVE LOGIN IF SAVED
    Public Sub retrievelogin()
        txt_username.Text = My.Settings.rememberusername
        txt_password.Text = My.Settings.rememberpassword
        If My.Settings.rememberusername IsNot "" Then
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
            MsgBox("Incorrect username or password.")
        End If

    End Sub

    'LOGIN
    Public Sub login()
        rememberlogin()
        My.Settings.currentuser = txt_username.Text
        My.Settings.Save()
        frm_home.lbl_currentuser.Text += My.Settings.currentuser
        Me.Hide()
        frm_home.Show()
    End Sub

    'SAVE USER LOGIN DETAILS
    Public Sub rememberlogin()
        If remember.Checked = True Then
            My.Settings.rememberusername = txt_username.Text
            My.Settings.rememberpassword = txt_password.Text
            My.Settings.Save()
        Else
            My.Settings.rememberusername = ""
            My.Settings.rememberpassword = ""
            My.Settings.Save()
        End If
    End Sub

    '---BUTTON ACTIONS---

    'LOGIN BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        checkuser()
    End Sub

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        MsgBox("Ridgeway Cover Scheduler automatically detects your username from your Windows user account. Please ensure you are logged into your personal user account when signing up.")
        Me.Hide()
        frm_signup.Show()
    End Sub
End Class
