Imports MySql.Data.MySqlClient
Public Class frm_covermanagement

    'DECLARATIONS
    Dim ds As DataSet
    Dim selected As Integer = 1

    'FORM LOAD
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        hidecolumns()
    End Sub

    'MINIMIZE TO TRAY
    Private Sub frm_admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'minimizetotray()
    End Sub

    'HIDE COLUMNS
    Public Sub hidecolumns()
        With dg_covers
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
        With dg_rooms
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    'MARK REQUEST AS BOOKED
    Public Sub markbooked()
        Dim id As New ArrayList
        try
        Select Case selected
            Case 1
                For Each i As DataGridViewRow In dg_covers.SelectedRows
                    id.Add(i.Cells(0).Value)
                Next i
                For j As Integer = 0 To id.Count - 1
                    newcmd("update lessons set approved = 'Approved', booked = 'Booked', push ='1' where id='" & id(j) & "'")
                    cmd.ExecuteNonQuery()
                Next j
            Case 2
                For Each i As DataGridViewRow In dg_rooms.SelectedRows
                    id.Add(i.Cells(0).Value)
                Next i
                For j As Integer = 0 To id.Count - 1
                    newcmd("update roomchange set booked = 'Booked', push ='1' where id='" & id(j) & "'")
                    cmd.ExecuteNonQuery()
                Next j
            End Select
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        getalldata()
    End Sub

    'TAB INDEX CHANGED
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            selected = 1
            dg_rooms.ClearSelection()
        Else
            selected = 2
            dg_covers.ClearSelection()
        End If
    End Sub

    '---BUTTON CLICK ACTIONS---

    'MARK BOOKED BUTTON
    Private Sub btn_booked_Click(sender As Object, e As EventArgs) Handles btn_booked.Click
        markbooked()
    End Sub

    'BACK BUTTON
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_admin.Show()
    End Sub

    'UPDATE BUTTON
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        getalldata()
    End Sub
End Class