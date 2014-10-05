Public Class frm_admin

    'DECLARATIONS
    Dim password As String
    Dim row As Integer

    'FORM LOAD
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        txt_newusername.ResetText()
        txt_newtype.ResetText()
    End Sub

    'CHANGE USER PASSWORD
    Public Sub newpassword()
        Dim pw1 As String = txt_pw1.Text
        Dim pw2 As String = txt_pw2.Text
        If pw1 = pw2 Then
            password = pw1
            Try
                newcmd("update users set password = '" & hash(password) & "' where id = '" & dg_users.Item(0, row).Value & "'")
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
            End Try
            getalldata()
            txt_pw1.ResetText()
            txt_pw2.ResetText()
        Else
            MsgBox("These passwords do not match")
            txt_pw1.ResetText()
            txt_pw2.ResetText()
        End If
    End Sub

    'DELETE USER
    Public Sub deleteuser()
        Try
            newcmd("delete from users where id = '" & dg_users.Item(0, row).Value & "'")
            cmd.ExecuteNonQuery()
            getalldata()
            newqry("select ID, username, type from users where username like '%" & txt_search.Text & "%'", dg_users)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
    End Sub

    'UPDATE USER
    Public Sub updateuser()
        Try
            newcmd("update users set username = '" & txt_newusername.Text & "', type = '" & txt_newtype.Text & "' where id = '" & dg_users.Item(0, row).Value & "'")
            cmd.ExecuteNonQuery()
            getalldata()
            newqry("select ID, username, type from users where username like '%" & txt_search.Text & "%'", dg_users)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
    End Sub

    'SHOW SELECTED USER
    Public Sub showuser()
        If dg_users.RowCount > 0 Then
            row = dg_users.CurrentCell.RowIndex
            txt_newusername.Text = dg_users.Item(1, row).Value
            txt_newtype.Text = dg_users.Item(2, row).Value
        Else
            txt_newusername.Text = ""
            txt_newtype.Text = ""
        End If
    End Sub

    'ADD USER
    Public Sub newuser()
        If txt_password1.Text = txt_password2.Text Then
            Try
                newcmd("insert into users (username, password, type) values (@username, @password, @type)")
                cmd.Parameters.AddWithValue("@username", txt_username.Text)
                cmd.Parameters.AddWithValue("@password", hash(txt_password1.Text))
                cmd.Parameters.AddWithValue("@type", txt_type.Text)
                cmd.ExecuteNonQuery()
                txt_username.ResetText()
                txt_type.SelectedIndex = -1
                txt_password1.ResetText()
                txt_password2.ResetText()
                MsgBox("User added")
                getalldata()
            Catch ex As Exception
                MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
            End Try
        Else
            MsgBox("These passwords do not match")
        End If
    End Sub

    'CHANGE NEW USER BUTTON
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_type.SelectedIndexChanged
        If txt_type.SelectedIndex = 0 Then
            btn_submit.Text = "Add Teacher"
        ElseIf txt_type.SelectedIndex = 1 Then
            btn_submit.Text = "Add Faculty Leader"
        ElseIf txt_type.SelectedIndex = 2 Then
            btn_submit.Text = "Add Admin"
        End If
    End Sub

    'SEARCH USERS
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            newqry("select ID, username, type from users where username like '%" & txt_search.Text & "%'", dg_users)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
    End Sub

    'UPDATE SELECTED USER
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dg_users.SelectionChanged
        showuser()
    End Sub

    'CANCEL USER UPDATES
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        txt_newusername.ResetText()
        txt_newtype.ResetText()
    End Sub

    '---BUTTON CLICK ACTIONS---

    'SHOW COVER MANAGEMENT
    Private Sub dg_admins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dg_admins.SelectedIndexChanged
        If dg_admins.SelectedIndex = 2 Then
            Me.Hide()
            frm_covermanagement.Show()
        End If
    End Sub

    'BACK BUTTON
    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_home.Show()
        frm_home.BringToFront()
    End Sub

    'CHANGE PASSWORD BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_changepw.Click
        newpassword()
    End Sub

    'UPDATE USER BUTTON
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        updateuser()
    End Sub

    'DELETE USER BUTTON
    Private Sub btn_deleteuser_Click(sender As Object, e As EventArgs) Handles btn_deleteuser.Click
        deleteuser()
    End Sub

    'SUBMIT USER BUTTON
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        newuser()
    End Sub
End Class