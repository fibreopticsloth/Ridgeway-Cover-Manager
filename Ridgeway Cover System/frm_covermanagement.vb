Imports MySql.Data.MySqlClient
Public Class frm_covermanagement

    'DECLARATIONS
    Dim ds As DataSet
    Dim selected As Integer = 1

    'FORM LOAD
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getalldata()
        hidecolumns()
        getstats()
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
        With dg_external
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
                        NewCommand("update lessons set approved = 'Approved', booked = 'Booked', push ='1' where id='" & id(j) & "'")
                Next j
            Case 2
                For Each i As DataGridViewRow In dg_rooms.SelectedRows
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
            dg_rooms.ClearSelection()
            dg_external.ClearSelection()
        ElseIf TabControl1.SelectedIndex = 1 Then
            selected = 2
            dg_covers.ClearSelection()
            dg_external.ClearSelection()
        ElseIf TabControl1.SelectedIndex = 2 Then
            selected = 3
            dg_covers.ClearSelection()
            dg_rooms.ClearSelection()
        Else
            getstats()
        End If
        getalldata()
        hidecolumns()
        Cursor = Cursors.Default
    End Sub

    '---BUTTON CLICK ACTIONS---

    'MARK BOOKED BUTTON
    Private Sub btn_booked_Click(sender As Object, e As EventArgs) Handles btn_booked.Click
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

    Public Sub getstats()

        Dim ds As DataSet
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yy'-'MM'-'dd"

        DateTimePicker1.Value = Now
        Dim today As String = DateTimePicker1.Text

        DateTimePicker1.Value = Now.AddDays(1)
        Dim tomorrow As String = DateTimePicker1.Text

        DateTimePicker1.Value = Now.AddDays(2)
        Dim next1 As String = DateTimePicker1.Text

        DateTimePicker1.Value = Now.AddDays(3)
        Dim next2 As String = DateTimePicker1.Text

        DateTimePicker1.Value = Now.AddDays(4)
        Dim next3 As String = DateTimePicker1.Text

        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & today & "' BETWEEN startdate AND enddate OR '" & today & "' = date(startdate) OR '" & today & "' = date(enddate)")
        lbl_today.Text = "Today: " + ds.Tables(0).Rows.Count.ToString

        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & tomorrow & "' BETWEEN startdate AND enddate OR '" & tomorrow & "' = date(startdate) OR '" & tomorrow & "' = date(enddate)")
        lbl_tomorrow.Text = "Tomorrow: " + ds.Tables(0).Rows.Count.ToString

        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & next1 & "' BETWEEN startdate AND enddate OR '" & next1 & "' = date(startdate) OR '" & next1 & "' = date(enddate)")
        lbl_next1.Text = Now.AddDays(2).DayOfWeek.ToString + ": " + ds.Tables(0).Rows.Count.ToString

        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & next2 & "' BETWEEN startdate AND enddate OR '" & next2 & "' = date(startdate) OR '" & next2 & "' = date(enddate)")
        lbl_next2.Text = Now.AddDays(3).DayOfWeek.ToString + ": " + ds.Tables(0).Rows.Count.ToString

        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & next3 & "' BETWEEN startdate AND enddate OR '" & next3 & "' = date(startdate) OR '" & next3 & "' = date(enddate)")
        lbl_next3.Text = Now.AddDays(4).DayOfWeek.ToString + ": " + ds.Tables(0).Rows.Count.ToString
        ds.Dispose()

        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value = Now

    End Sub

    Private Sub btn_booked2_Click(sender As Object, e As EventArgs) Handles btn_booked2.Click
        markbooked()
    End Sub

    Private Sub btn_customcount_Click(sender As Object, e As EventArgs) Handles btn_customcount.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yy'-'MM'-'dd"
        ds = NewDataCommand("SELECT * FROM lessons WHERE '" & DateTimePicker1.Text & "' BETWEEN startdate AND enddate OR '" & DateTimePicker1.Text & "' = date(startdate) OR '" & DateTimePicker1.Text & "' = date(enddate)")
        DateTimePicker1.Format = DateTimePickerFormat.Long
        txt_custom.Text = ds.Tables(0).Rows.Count.ToString
        DateTimePicker1.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub btn_booked3_Click(sender As Object, e As EventArgs) Handles btn_booked3.Click
        markbooked()
    End Sub
End Class