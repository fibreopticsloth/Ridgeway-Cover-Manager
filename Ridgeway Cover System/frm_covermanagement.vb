Imports MySql.Data.MySqlClient
Public Class frm_covermanagement

    'DECLARATIONS
    Dim ds As DataSet
    Dim selected As Integer = 1

    'FORM LOAD
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getalldata()
        hidecolumns()
    End Sub

    'HIDE COLUMNS
    Public Sub hidecolumns()
        With dg_covers
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
        With dg_external
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
        With dg_roomchanges
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    'MARK REQUEST AS BOOKED
    Public Sub markbooked()
        Dim id As New ArrayList
        Try
            Select Case selected
                Case 1
                    For Each i As DataGridViewRow In dg_covers.SelectedRows
                        id.Add(i.Cells(0).Value)
                    Next i
                    For j As Integer = 0 To id.Count - 1
                        NewCommand("update lessons set approved = 'Approved', booked = 'Booked', push ='1' where id='" & id(j) & "'")
                    Next j
                Case 2
                    For Each i As DataGridViewRow In dg_roomchanges.SelectedRows
                        id.Add(i.Cells(0).Value)
                    Next i
                    For j As Integer = 0 To id.Count - 1
                        NewCommand("update roomchange set booked = 'Booked', push ='1' where id='" & id(j) & "'")
                    Next j
                Case 3
                    For Each i As DataGridViewRow In dg_external.SelectedRows
                        id.Add(i.Cells(0).Value)
                    Next i
                    For j As Integer = 0 To id.Count - 1
                        NewCommand("update lessons set approved = 'Approved', booked = 'Booked', push ='1' where id='" & id(j) & "'")
                    Next j
            End Select
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        getalldata()
        hidecolumns()
    End Sub

    'TAB INDEX CHANGED
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If TabControl1.SelectedIndex = 0 Then
            selected = 1
            dg_roomchanges.ClearSelection()
            dg_external.ClearSelection()
        ElseIf TabControl1.SelectedIndex = 1 Then
            selected = 2
            dg_covers.ClearSelection()
            dg_external.ClearSelection()
        ElseIf TabControl1.SelectedIndex = 2 Then
            selected = 3
            dg_covers.ClearSelection()
            dg_roomchanges.ClearSelection()
        End If
        getalldata()
        hidecolumns()
        Cursor = Cursors.Default
    End Sub

    '---BUTTON CLICK ACTIONS---

    'MARK BOOKED BUTTONS
    Private Sub btn_booked_Click(sender As Object, e As EventArgs) Handles btn_booked.Click
        markbooked()
    End Sub
    Private Sub btn_booked2_Click(sender As Object, e As EventArgs) Handles btn_booked_2.Click
        markbooked()
    End Sub
    Private Sub btn_booked3_Click(sender As Object, e As EventArgs) Handles btn_booked_3.Click
        markbooked()
    End Sub

    'BACK BUTTON
    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        frm_admin.Show()
        Me.Dispose()
    End Sub

    'UPDATE BUTTON
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        getalldata()
    End Sub
End Class