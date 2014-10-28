Imports MySql.Data.MySqlClient

Public Class frm_signup

    'DECLARATIONS
    Dim rd As MySqlDataReader
    Public username As String
    Dim stafftype As String

    'FORM LOAD
    Private Sub frm_signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_username.Text = "Your username has been" + vbNewLine + "automatically detected as:" + vbNewLine + Environment.UserName
    End Sub

    'CHECK DETAILS AND SIGNUP
    Public Sub signup()
        Dim username As String = Environment.UserName
        If CheckData("select username from users where username = '" & username & "'") Then
            MsgBox("This user account already exists!")
        ElseIf txt_password.Text = "" Or txt_confirmpassword.Text = "" Then
            MsgBox("You must fill in both fields!")
        ElseIf txt_password.TextLength < 8 Then
            MsgBox("Your password must be at least 8 characters")
        ElseIf txt_password.Text = txt_confirmpassword.Text Then
            findstafftype()
            NewCommand("INSERT INTO users(username, password, type) values('" & username & "', '" & hash(txt_password.Text) & "', '" & stafftype & "')")
            MessageBox.Show("Please record your username and password in a safe place:" & vbNewLine & vbNewLine & "Username: " _
                     & username & vbNewLine & "Password: " & txt_password.Text, "Log In Details")
            With frm_login
                .txt_username.Text = username
                .txt_password.Text = ""
                .txt_password.Focus()
            End With
            Me.Dispose()
        Else
            MsgBox("Your passwords do not match!")
        End If
        resetsignup()
    End Sub

    'RESET SIGNUP FORM
    Public Sub resetsignup()
        txt_password.ResetText()
        txt_confirmpassword.ResetText()
        txt_password.Focus()
    End Sub

    'CHECK TO SEE IF FACULTY HEAD
    Public Sub findstafftype()
        Dim response = MsgBox("Are you a Faculty Leader?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Dim response2 = MsgBox("Please confirm that you are a Faculty Leader", MsgBoxStyle.YesNo)
            If response2 = MsgBoxResult.Yes Then
                stafftype = "faculty"
            Else
                findstafftype()
            End If
        Else
            Dim response2 = MsgBox("Please confirm that you are not a Faculty Leader", MsgBoxStyle.YesNo)
            If response2 = MsgBoxResult.Yes Then
                stafftype = "teacher"
            Else
                findstafftype()
            End If
        End If
    End Sub

    '---BUTTON ACTIONS---

    'SIGNUP BUTTON
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        signup()
    End Sub

    'BACK BUTTON
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub
End Class