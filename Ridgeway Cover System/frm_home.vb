Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frm_home

    'DECLARATIONS

    '1 = covers, 2 = rooms
    Dim selected As Integer = 1
    Dim rd As MySqlDataReader
    Dim id As Integer
    Dim row As Integer = 0
    Dim buttoncolour As Color = Color.FromArgb(28, 28, 28)
    Dim activebutton As Color = Color.FromArgb(63, 63, 70)
    Dim mouseoverbutton As Color = Color.FromArgb(0, 122, 204)

    'FORM LOAD
    Private Sub frm_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_notify.Text = My.Settings.usernotifications
        If Not My.Settings.usernotificationcount = "" Then
            getdata.updatecount = My.Settings.usernotificationcount
        End If
        lbl_currentuser.Text += My.Settings.currentuser
        setdates()
        connect()
        getalldata()
        hidecolumns()
        facultyheads()
        viewrequest()
        nfi.Visible = True
        data_timer.Start()
        customfont()
        getalldata()
    End Sub

    '--------REQUEST COVER PANEL--------

    'SUBMIT REQUEST
    Private Sub roomchange_btn_submit_Click(sender As Object, e As EventArgs) Handles roomchange_btn_submit.Click
        If submit("room", My.Settings.currentuser, roomchange_txt_room.Text, roomchange_dp_startdate, roomchange_txt_startperiod.Text, roomchange_dp_enddate, roomchange_txt_endperiod.Text, roomchange_txt_reason.Text) = 1 Then
            MsgBox("Request submitted")
            resetroomchange()
            getalldata()
        End If
    End Sub

    'GET LIST OF FACULTY LEADERS
    Public Sub facultyheads()
        If checkconn() Then
            Dim da As New MySqlDataAdapter("select username from users where type = 'faculty' or type = 'covermanager'", conn)
            Dim ds As New DataSet
            da.Fill(ds, "users")
            Dim dt As DataTable = ds.Tables(0)
            For Each DataRow In dt.Rows
                requestcover_txt_facultyhead.Items.Add(DataRow(0))
            Next
            ds.Dispose()
            da.Dispose()
        End If
    End Sub

    'ENABLE/DISABLE END DATE
    Private Sub requestcover_chk_thislessononly_CheckStateChanged(sender As Object, e As EventArgs) Handles requestcover_chk_thislessononly.CheckStateChanged
        If requestcover_chk_thislessononly.CheckState = CheckState.Checked Then
            requestcover_dp_enddate.Enabled = False
            requestcover_txt_endperiod.Enabled = False
            requestcover_txt_endperiod.SelectedIndex = -1
        Else
            requestcover_dp_enddate.Enabled = True
            requestcover_txt_endperiod.Enabled = True
        End If
    End Sub

    '--------ROOM CHANGE PANEL--------

    'SUBMIT REQUEST
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles requestcover_btn_submit.Click
        If submit("lesson", My.Settings.currentuser, requestcover_txt_facultyhead.Text, requestcover_dp_startdate, requestcover_txt_startperiod.Text, requestcover_dp_enddate, requestcover_txt_endperiod.Text, requestcover_txt_reason.Text) = 1 Then
            MsgBox("Request submitted")
            resetrequestcover()
            getalldata()
        End If
    End Sub

    'ENABLE/DISABLE END DATE
    Private Sub roomchange_chk_thislessononly_CheckStateChanged(sender As Object, e As EventArgs) Handles roomchange_chk_thislessononly.CheckStateChanged
        If roomchange_chk_thislessononly.CheckState = CheckState.Checked Then
            roomchange_dp_enddate.Enabled = False
            roomchange_txt_endperiod.Enabled = False
            roomchange_txt_endperiod.SelectedIndex = -1
        Else
            roomchange_dp_enddate.Enabled = True
            roomchange_txt_endperiod.Enabled = True
        End If
    End Sub

    '--------NOTIFICATIONS PANEL

    'CLEAR NOTIFICATIONS BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles panel_notifications_clearnotifications.Click
        My.Settings.usernotifications = ""
        My.Settings.usernotificationcount = ""
        My.Settings.Save()
        lbl_notify.Text = ""
        btn_notifications.Text = "      Notifications" + " (0)"
        getdata.updatecount = 0
    End Sub

    '--------MY REQUESTS PANEL--------

    'CHECK SELECTED DATAGRIDVIEW
    Private Sub myrequests_tc_myrequests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles myrequests_tc_myrequests.SelectedIndexChanged
        If myrequests_tc_myrequests.SelectedIndex = 0 Then
            selected = 1
            dg_myroomchanges.ClearSelection()
        Else
            selected = 2
            dg_mycovers.ClearSelection()
        End If
    End Sub

    'CHECK IF SELECTED REQUEST(S) IS BOOKED
    Public Function checkifbooked(id As Integer)
        If checkconn() Then
            If selected = 1 Then
                newcmd("select booked from lessons where id = '" & id & "' and booked = 'booked'")
            ElseIf selected = 2 Then
                newcmd("select booked from roomchange where id = '" & id & "' and booked = 'booked'")
            End If
            rd = cmd.ExecuteReader
        End If
        If rd.Read = True Then
            rd.Dispose()
            Return 1
        Else : rd.Dispose()
            Return 0
        End If
    End Function

    'CANCEL SELECTED REQUEST(S)
    Public Sub cancelrequest()
        Dim id As New ArrayList
        Dim cancellationerror As Boolean = False
        If checkconn() Then
            Select Case selected
                Case 1
                    For Each i As DataGridViewRow In dg_mycovers.SelectedRows
                        id.Add(i.Cells(0).Value)
                    Next i
                    For j As Integer = 0 To id.Count - 1
                        If checkifbooked(id(j)) = 0 Then
                            newcmd("delete from lessons where id ='" & id(j) & "'")
                            cmd.ExecuteNonQuery()
                        Else
                            cancellationerror = True
                        End If
                    Next j
                Case 2
                    For Each i As DataGridViewRow In dg_myroomchanges.SelectedRows()
                        id.Add(i.Cells(0).Value)
                    Next i
                    For j As Integer = 0 To id.Count - 1
                        If checkifbooked(id(j)) = 0 Then
                            newcmd("delete from roomchange where id ='" & id(j) & "'")
                            cmd.ExecuteNonQuery()
                        Else
                            cancellationerror = True
                        End If
                    Next j
            End Select
        End If
        If cancellationerror = True Then
            MsgBox("One or more of your selected cancellations has already been booked." + vbNewLine + _
                   "These cannot be cancelled, and have been skipped from the cancellation process.")
        End If
        cancellationerror = False
        getalldata()
    End Sub

    '--------FACULTY AREA PANEL--------

    'GET ROW INDEX OF SELECTED REQUEST
    Private Sub dg_viewrequests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_viewrequests.CellClick
        row = dg_viewrequests.CurrentCell.RowIndex.ToString
        viewrequest()
    End Sub

    'VIEW SELECTED REQUEST
    Public Sub viewrequest()
        Try
            facultyarea_dp_startdate.Value = dg_viewrequests.Item(2, row).Value.ToString
            facultyarea_txt_startperiod.Text = dg_viewrequests.Item(3, row).Value.ToString
            facultyarea_txt_reason.Text = dg_viewrequests.Item(6, row).Value.ToString
            Dim startdate As DateTime = dg_viewrequests.Item(2, row).Value
            Dim enddate As DateTime = dg_viewrequests.Item(4, row).Value
            startdate = startdate.Date
            enddate = enddate.Date
            If startdate = enddate Then
                chk_thislessononly.CheckState = CheckState.Checked
                resetend()
                facultyarea_dp_enddate.Enabled = False
                facultyarea_txt_endperiod.Enabled = False
            Else
                chk_thislessononly.CheckState = CheckState.Unchecked
                facultyarea_dp_enddate.Enabled = True
                facultyarea_txt_endperiod.Enabled = True
                facultyarea_dp_enddate.Value = dg_viewrequests.Item(4, row).Value.ToString
                facultyarea_txt_endperiod.Text = dg_viewrequests.Item(5, row).Value.ToString
            End If
        Catch ex As Exception
        End Try
    End Sub

    'CONFIRM APPROVE/REJECT
    Public Function confirm(type As String)
        Dim response As MsgBoxResult
        If type = "approve" Then
            response = MsgBox("Are you sure you want to approve this request?", MsgBoxStyle.OkCancel)
        ElseIf type = "reject" Then
            response = MsgBox("Are you sure you want to reject this request?", MsgBoxStyle.OkCancel)
        End If
        If response = MsgBoxResult.Ok Then
            Return 1
        ElseIf response = MsgBoxResult.Cancel Then
            Return 0
        Else
            Return 0
        End If
    End Function

    'APPROVE REQUEST
    Public Sub approverequest()
        If confirm("approve") = 1 Then
            If checkconn() Then
                Dim id As Integer = dg_viewrequests.Item(0, dg_viewrequests.CurrentCell.RowIndex).Value
                newcmd("update lessons set approved = 'Approved', booked = 'Pending', push ='1' where id='" & id & "'")
                cmd.ExecuteNonQuery()
                resetstart()
                resetend()
                getalldata()
                viewrequest()
            End If
        End If
    End Sub

    'REJECT REQUEST
    Public Sub rejectrequest()
        If confirm("reject") = 1 Then
            If checkconn() Then
                Dim id As Integer = dg_viewrequests.Item(0, dg_viewrequests.CurrentCell.RowIndex).Value
                newcmd("update lessons set approved = 'Rejected', booked = 'N/A', push = '1' where id='" & id & "'")
                cmd.ExecuteNonQuery()
                resetstart()
                resetend()
                getalldata()
                viewrequest()
            End If
        End If
    End Sub

    'RESET START DATE/PERIOD
    Public Sub resetstart()
        facultyarea_dp_startdate.Value = Now
        facultyarea_txt_startperiod.SelectedIndex = -1
        facultyarea_txt_reason.ResetText()
    End Sub

    'RESET END DATE/PERIOD
    Public Sub resetend()
        facultyarea_dp_enddate.Value = Now
        facultyarea_txt_endperiod.SelectedIndex = -1
    End Sub

    '--------MISC--------

    'SET DATES
    Public Sub setdates()
        requestcover_dp_startdate.MinDate = Now.AddDays(3)
        requestcover_dp_startdate.Value = Now.AddDays(3)
        requestcover_dp_enddate.MinDate = Now.AddDays(3)
        requestcover_dp_enddate.Value = Now.AddDays(3)
        roomchange_dp_startdate.MinDate = Now.AddDays(3)
        roomchange_dp_startdate.Value = Now.AddDays(3)
        roomchange_dp_enddate.MinDate = Now.AddDays(3)
        roomchange_dp_enddate.Value = Now.AddDays(3)
    End Sub

    'RESET FORM
    Public Sub resetall()
        resetrequestcover()
        resetroomchange()
        btn_requestcover.BackColor = Me.BackColor
        btn_roomchange.BackColor = Me.BackColor
        btn_notifications.BackColor = Me.BackColor
        btn_myrequests.BackColor = Me.BackColor
        btn_facultyarea.BackColor = Me.BackColor
        btn_accountdetails.BackColor = Me.BackColor
        btn_userinterface.BackColor = Me.BackColor
        lbl_start.Show()
        panel_start.Show()
        lbl_requestcover.Hide()
        lbl_roomchange.Hide()
        lbl_notifications.Hide()
        lbl_myrequests.Hide()
        lbl_facultyarea.Hide()
        panel_requestcover.Hide()
        panel_roomchange.Hide()
        panel_notifications.Hide()
        panel_myrequests.Hide()
        panel_facultyarea.Hide()
        customfont()
    End Sub

    'RESET REQUEST COVER PANEL
    Public Sub resetrequestcover()
        setdates()
        requestcover_txt_startperiod.SelectedIndex = -1
        requestcover_txt_endperiod.SelectedIndex = -1
        requestcover_txt_facultyhead.ResetText()
        requestcover_txt_reason.ResetText()
        panel_requestcover.BringToFront()
    End Sub

    'RESET ROOM CHANGE PANEL
    Public Sub resetroomchange()
        setdates()
        roomchange_txt_startperiod.SelectedIndex = -1
        roomchange_txt_endperiod.SelectedIndex = -1
        roomchange_txt_room.ResetText()
        roomchange_txt_reason.ResetText()
        panel_roomchange.BringToFront()
    End Sub

    'HIDE UNWANTED COLUMNS
    Public Sub hidecolumns()
        dg_mycovers.Columns(0).Visible = False
        dg_myroomchanges.Columns(0).Visible = False
        With dg_viewrequests
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(1).HeaderText = "Submitted By"
        End With
    End Sub

    'HIDE START PANEL
    Public Sub hidestart()
        resetall()
        panel_start.Hide()
        lbl_start.Hide()
    End Sub

    'GET DATA
    Private Sub data_timer_Tick(sender As Object, e As EventArgs) Handles data_timer.Tick
        If checkconn() Then
            getalldata()
        End If
    End Sub

    'LOGOUT
    Public Sub logout()
        Me.Visible = False
        My.Settings.currentuser = ""
        frm_login.Show()
        frm_login.BringToFront()
    End Sub

    '--------PANEL BUTTONS--------

    'REQUEST COVER
    Private Sub btn_requestcover_Click(sender As Object, e As EventArgs) Handles btn_requestcover.Click
        getalldata()
        setdates()
        hidestart()
        lbl_requestcover.Show()
        btn_requestcover.BackColor = activebutton
        panel_requestcover.Show()
    End Sub

    'ROOM CHANGE
    Private Sub btn_roomchange_Click(sender As Object, e As EventArgs) Handles btn_roomchange.Click
        getalldata()
        setdates()
        hidestart()
        lbl_roomchange.Show()
        btn_roomchange.BackColor = activebutton
        panel_roomchange.Show()
    End Sub

    'NOTIFICATIONS
    Private Sub btn_notifications_Click(sender As Object, e As EventArgs) Handles btn_notifications.Click
        getalldata()
        hidestart()
        lbl_notifications.Show()
        btn_notifications.BackColor = activebutton
        panel_notifications.Show()
    End Sub

    'MY REQUESTS
    Private Sub btn_myrequests_Click(sender As Object, e As EventArgs) Handles btn_myrequests.Click
        getalldata()
        hidestart()
        lbl_myrequests.Show()
        btn_myrequests.BackColor = activebutton
        panel_myrequests.Show()
    End Sub

    'FACULTY AREA
    Private Sub btn_facultyarea_Click(sender As Object, e As EventArgs) Handles btn_facultyarea.Click
        getalldata()
        hidestart()
        lbl_facultyarea.Show()
        btn_facultyarea.BackColor = activebutton
        panel_facultyarea.Show()
    End Sub

    '--------BUTTONS--------

    'LOGO
    Private Sub pic_logo_Click(sender As Object, e As EventArgs) Handles pic_logo.Click
        getalldata()
        resetall()
    End Sub

    'START PANEL LOGOUT
    Private Sub txt_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txt_logout.LinkClicked
        logout()
    End Sub

    'SYNC
    Private Sub btn_sync_Click(sender As Object, e As EventArgs) Handles btn_sync.Click
        getalldata()
    End Sub

    'CANCEL MY REQUEST
    Private Sub myrequests_btn_cancel_Click(sender As Object, e As EventArgs) Handles myrequests_btn_cancel.Click
        cancelrequest()
    End Sub

    'APPROVE REQUEST
    Private Sub facultyarea_btn_approve_Click(sender As Object, e As EventArgs) Handles facultyarea_btn_approve.Click
        approverequest()
    End Sub

    'REJECT REQUEST
    Private Sub facultyarea_btn_reject_Click(sender As Object, e As EventArgs) Handles facultyarea_btn_reject.Click
        rejectrequest()
    End Sub

    '--------TRAY ICON--------

    'CLOSE TO TRAY
    Private Sub frm_home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Visible = False
        Me.ShowInTaskbar = False
        e.Cancel = True
    End Sub

    'MENU ON RIGHT CLICK
    Private Sub nfi_MouseClick(sender As Object, e As MouseEventArgs) Handles nfi.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            nfi.ContextMenuStrip.Show()
        End If
    End Sub

    'MENU ON DOUBLE CLICK
    Private Sub nfi_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfi.MouseDoubleClick
        resetall()
        Me.Visible = True
        Me.ShowInTaskbar = True
    End Sub

    'SHOW OPTION
    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Reset()
        Me.Visible = True
        Me.ShowInTaskbar = True
    End Sub

    'EXIT OPTION
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        My.Settings.currentuser = ""
        Application.Exit()
    End Sub

    '--------MENU BAR--------

    'QUIT
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        My.Settings.currentuser = ""
        Application.Exit()
    End Sub

    'LOGOUT
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        logout()
    End Sub

    'ADMIN CENTRE
    Private Sub LaunchAdminCentreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchAdminCentreToolStripMenuItem.Click
        Me.hidecolumns()
        frm_admin.Show()
    End Sub

    'COVER MANAGEMENT
    Private Sub LaunchCoverManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchCoverManagementToolStripMenuItem.Click
        frm_covermanagement.Show()
    End Sub

    'BUG REPORT
    Private Sub SubmitABugReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitABugReportToolStripMenuItem.Click
        Try
            Dim bugreport As String
            bugreport = InputBox("Please detail the bug:", "New Bug Report")
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rcmbugreport@gmail.com ", "rcmdlop890")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("rcmbugreport@gmail.com ")
            e_mail.To.Add("gdunkgd@gmail.com")
            e_mail.Subject = "New Bug Report"
            e_mail.IsBodyHtml = False
            e_mail.Body = bugreport
            Smtp_Server.Send(e_mail)
            MsgBox("Your bug report has been submitted. Thank you for your feedback.")
        Catch ex As Exception
            MsgBox("Could not connect to the internet.")
        End Try
    End Sub

    'ABOUT
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Ridgeway Cover Manager" + vbNewLine + "Version: Alpha 0.4" + vbNewLine + "Copyright © 2014 The Ridgeway School & Sixth Form College" + vbNewLine + "Created by George Dunk for The Ridgeway School & Sixth Form College", "About Ridgeway Cover Manager")
    End Sub
End Class