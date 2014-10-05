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

    'CHECK INFO AND LOGIN
    Public Sub login()
        If checkconn() Then
                newcmd("SELECT username, password, type from users where username='" & txt_username.Text & "' and password='" & hash(txt_password.Text) & "'")
                rd = cmd.ExecuteReader
                'IF PASSWORD CORRECT
                If rd.HasRows Then
                    rememberlogin()
                My.Settings.currentuser = txt_username.Text
                My.Settings.Save()
                    While rd.Read
                        My.Settings.usertype = rd.GetString(2)
                    End While
                    Me.Hide()
                    frm_home.Show()
                    'IF PASSWORD INCORRECT
                Else
                    MessageBox.Show("Incorrect username or password!", "Log In Error")
                    txt_password.ResetText()
                    txt_password.Focus()
                End If
                rd.Dispose()
        Else
            Dim response = MsgBox("Ridgeway Cover Manager could not connect to the database." + vbNewLine + _
                                      "Please ensure you are connected to the internet.", MsgBoxStyle.OkOnly)
        End If
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
            txt_username.Text = ""
            txt_password.Text = ""
        End If
    End Sub

    '---BUTTON ACTIONS---

    'LOGIN BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()
    End Sub

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        MsgBox("Ridgeway Cover Scheduler automatically detects your username from your Windows user account. Please ensure you are logged into your personal user account when signing up.")
        Me.Hide()
        frm_signup.Show()
    End Sub
End Class
