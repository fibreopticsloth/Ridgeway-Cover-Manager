Imports MySql.Data.MySqlClient
Public Class frm_login

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
        rememberlogin()
        checktype()
        My.Settings.CurrentUsername = txt_username.Text
        My.Settings.Save()
        frm_home.lbl_currentuser.Text += My.Settings.CurrentUsername

        Me.Hide()
        frm_home.Show()
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
        checkuser()
    End Sub

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        MsgBox("Ridgeway Cover Manager automatically detects your username from your Windows user account. Please ensure you are logged into your personal user account when signing up.")
        Me.Hide()
        frm_signup.Show()
    End Sub
End Class
