Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frm_home

    'DECLARATIONS

    '1 = covers, 2 = rooms
    Dim auth_code As String
    Dim selected As Integer = 1
    Dim rd As MySqlDataReader
    Dim id As Integer
    Dim row As Integer = 0
    Dim accentcolour As Color = Color.FromArgb(236, 236, 236)

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    'FORM LOAD
    Private Sub frm_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'PUBLIC SUB LOAD FORM
    Public Sub load_home()

        resetall()
        panel_start.Show()

        lbl_currentuser.Text = "Logged in as " + My.Settings.CurrentUsername

        If My.Settings.CurrentUsername = My.Settings.PreviousUser Then
            lbl_notify.Text = My.Settings.UserNotificationsText
            If Not My.Settings.UserNotificationsCount = "" Then
                getdata.updatecount = My.Settings.UserNotificationsCount
            End If
            If Not My.Settings.FacultyNotificationsCount = "" Then
                getdata.facultycount = My.Settings.FacultyNotificationsCount
            End If
        Else
            My.Settings.UserNotificationsCount = Nothing
            My.Settings.UserNotificationsText = ""
            My.Settings.FacultyNotificationsCount = Nothing
        End If

        My.Settings.PreviousUser = My.Settings.CurrentUsername
        My.Settings.Save()

        nfi.Visible = True
        setdates()
        getalldata()
        viewrequest()
        data_timer.Enabled = True
        data_timer.Start()

    End Sub

    '--------REQUEST COVER PANEL--------

    'SUBMIT REQUEST
    Private Sub roomchange_btn_submit_Click(sender As Object, e As EventArgs) Handles roomchange_btn_submit.Click
        Dim singlelesson As Boolean
        If roomchange_chk_thislessononly.CheckState = CheckState.Checked Then
            singlelesson = True
        Else
            singlelesson = False
        End If
        If submit("room", My.Settings.CurrentUsername, roomchange_txt_room.Text, roomchange_dp_startdate, roomchange_txt_startperiod.Text, roomchange_dp_enddate, roomchange_txt_endperiod.Text, roomchange_txt_reason.Text, Nothing, singlelesson) = 1 Then
            MsgBox("Request submitted")
            resetroomchange()
            getalldata()
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
        Dim singlelesson As Boolean
        If requestcover_chk_thislessononly.CheckState = CheckState.Checked Then
            singlelesson = True
        Else
            singlelesson = False
        End If
        Dim response = MsgBox("Is this cover for an external training course or conference?", MsgBoxStyle.YesNo)
        If submit("lesson", My.Settings.CurrentUsername, requestcover_txt_facultyhead.Text, requestcover_dp_startdate, requestcover_txt_startperiod.Text, requestcover_dp_enddate, requestcover_txt_endperiod.Text, requestcover_txt_reason.Text, response.ToString, singlelesson) = 1 Then
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
        My.Settings.UserNotificationsText = ""
        My.Settings.UserNotificationsCount = ""
        My.Settings.Save()
        lbl_notify.Text = "No notifications to show!"
        btn_notifications.Text = "Notifications" + " (0)"
        getdata.updatecount = 0
        getalldata()
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
        If selected = 1 Then
            If CheckData("select booked from lessons where id = '" & id & "' and booked = 'booked'") Then
                Return 1
            ElseIf CheckData("select booked from roomchange where id = '" & id & "' and booked = 'booked'") Then
                Return 1
            Else
                Return 0
            End If
        ElseIf selected = 2 Then
            If CheckData("select booked from roomchange where id = '" & id & "' and booked = 'booked'") Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'CANCEL SELECTED REQUEST(S)
    Public Sub cancelrequest()
        Dim id As New ArrayList
        Dim cancellationerror As Boolean = False
        Select Case selected
            Case 1
                For Each i As DataGridViewRow In dg_mycovers.SelectedRows
                    id.Add(i.Cells(0).Value)
                Next i
                For j As Integer = 0 To id.Count - 1
                    If checkifbooked(id(j)) = 0 Then
                        NewCommand("delete from lessons where id ='" & id(j) & "'")
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
                        NewCommand("delete from roomchange where id ='" & id(j) & "'")
                    Else
                        cancellationerror = True
                    End If
                Next j
        End Select

        If cancellationerror = True Then
            MsgBox("One or more of your selected cancellations has already been booked." + vbNewLine + _
                   "These cannot be cancelled, and have been skipped from the cancellation process.")
        Else
            MsgBox("The selected request(s) have been cancelled.")
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
            Dim id As Integer = dg_viewrequests.Item(0, dg_viewrequests.CurrentCell.RowIndex).Value
            NewCommand("update lessons set approved = 'Approved', booked = 'Pending', push ='1' where id='" & id & "'")
            resetstart()
            resetend()
            getalldata()
            viewrequest()
        End If
    End Sub

    'REJECT REQUEST
    Public Sub rejectrequest()
        If confirm("reject") = 1 Then
            Dim id As Integer = dg_viewrequests.Item(0, dg_viewrequests.CurrentCell.RowIndex).Value
            NewCommand("update lessons set approved = 'Rejected', booked = 'N/A', push = '1' where id='" & id & "'")
            resetstart()
            resetend()
            getalldata()
            viewrequest()
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
        btn_requestcover.BackColor = Color.White
        btn_roomchange.BackColor = Color.White
        btn_notifications.BackColor = Color.White
        btn_myrequests.BackColor = Color.White
        btn_facultyarea.BackColor = Color.White
        btn_accountdetails.BackColor = Color.White
        panel_start.Hide()
        panel_requestcover.Hide()
        panel_roomchange.Hide()
        panel_notifications.Hide()
        panel_myrequests.Hide()
        panel_facultyarea.Hide()
        panel_accountdetails.Hide()
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

    'GET DATA
    Private Sub data_timer_Tick(sender As Object, e As EventArgs) Handles data_timer.Tick
        getalldata()
    End Sub

    'LOGOUT
    Public Sub logout()
        frm_login.Show()
        Me.Location = frm_login.Location
        My.Settings.CurrentUsername = ""
        My.Settings.CurrentUserType = ""
        My.Settings.Save()
        lbl_currentuser.Text = "Not Logged In"
        data_timer.Stop()
        nfi.Visible = False
        Me.Dispose()
    End Sub

    '--------PANEL BUTTONS--------

    'REQUEST COVER
    Private Sub btn_requestcover_Click(sender As Object, e As EventArgs) Handles btn_requestcover.Click
        setdates()
        resetall()
        btn_requestcover.BackColor = Accentcolour
        panel_requestcover.Show()
        getalldata()
    End Sub

    'ROOM CHANGE
    Private Sub btn_roomchange_Click(sender As Object, e As EventArgs) Handles btn_roomchange.Click
        setdates()
        resetall()
        btn_roomchange.BackColor = Accentcolour
        panel_roomchange.Show()
    End Sub

    'NOTIFICATIONS
    Private Sub btn_notifications_Click(sender As Object, e As EventArgs) Handles btn_notifications.Click
        resetall()
        btn_notifications.BackColor = Accentcolour
        panel_notifications.Show()
        getalldata()
    End Sub

    'MY REQUESTS
    Private Sub btn_myrequests_Click(sender As Object, e As EventArgs) Handles btn_myrequests.Click
        resetall()
        btn_myrequests.BackColor = Accentcolour
        panel_myrequests.Show()
        getalldata()
    End Sub

    'FACULTY AREA
    Private Sub btn_facultyarea_Click(sender As Object, e As EventArgs) Handles btn_facultyarea.Click
        If My.Settings.CurrentUserType <> "teacher" Then
            resetall()
            viewrequest()
            btn_facultyarea.BackColor = accentcolour
            panel_facultyarea.Show()
            getalldata()
        Else
            MsgBox("You are not granted permission to access this area.")
        End If
    End Sub

    'ACCOUNT DETAILS
    Private Sub btn_accountdetails_Click(sender As Object, e As EventArgs) Handles btn_accountdetails.Click
        resetall()
        btn_accountdetails.BackColor = Accentcolour
        panel_accountdetails.Show()
    End Sub

    '--------BUTTONS--------

    'LOGO
    Private Sub pic_logo_Click(sender As Object, e As EventArgs) Handles pic_logo.Click
        resetall()
        panel_start.Show()
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
        panel_start.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    'SHOW OPTION
    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        resetall()
        panel_start.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    'EXIT OPTION
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        nfi.Visible = False
        My.Settings.CurrentUsername = ""
        Application.Exit()
    End Sub

    '--------MENU BAR--------

    'QUIT
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        nfi.Visible = False
        My.Settings.CurrentUsername = ""
        Application.Exit()
    End Sub

    'LOGOUT
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        logout()
    End Sub

    'ADMIN CENTRE
    Private Sub LaunchAdminCentreToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If My.Settings.CurrentUserType = "admin" Or My.Settings.CurrentUserType = "covermanager" Then
            Me.hidecolumns()
            frm_admin.Show()
        Else
            MsgBox("You are not granted permission to access this area.")
        End If
    End Sub

    'COVER MANAGEMENT
    Private Sub LaunchCoverManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If My.Settings.CurrentUserType = "admin" Or My.Settings.CurrentUserType = "covermanager" Then
            frm_covermanagement.Show()
        Else
            MsgBox("You are not granted permission to access this area.")
        End If
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Button8_MouseMove(sender As Object, e As MouseEventArgs) Handles Button8.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp
        drag = False
    End Sub

    Private Sub lbl_main_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_main.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub lbl_main_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_main.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub lbl_main_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_main.MouseUp
        drag = False
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        If My.Settings.CurrentUserType = "admin" Or My.Settings.CurrentUserType = "covermanager" Then
            getalldata()
            frm_admin.Show()
        Else
            MsgBox("You are not authorised to access this area.")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
            nfi.BalloonTipText = "Ridgeway Cover Manager has " + vbNewLine + "been closed to the system tray."
        nfi.ShowBalloonTip(3)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        logout()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        logout()
        Application.Exit()
    End Sub

    Private Sub SubmitBugReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitBugReportToolStripMenuItem.Click
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Ridgeway Cover Manager" + vbNewLine + "Version: " + My.Application.Deployment.CurrentVersion.ToString + vbNewLine + "Copyright © 2014 The Ridgeway School & Sixth Form College" + vbNewLine + "Created by George Dunk for The Ridgeway School & Sixth Form College", "About Ridgeway Cover Manager")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("Ridgeway Cover Manager" + vbNewLine + "Version: " + My.Settings.Version + vbNewLine + "Copyright © 2014 The Ridgeway School & Sixth Form College" + vbNewLine + "Created by George Dunk for The Ridgeway School & Sixth Form College", "About Ridgeway Cover Manager")
    End Sub

    Private Sub CoverManagementAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoverManagementAreaToolStripMenuItem.Click
        If My.Settings.CurrentUserType = "covermanager" Or My.Settings.CurrentUserType = "admin" Then
            frm_covermanagement.Show()
        Else
            MsgBox("You are not authorised to access this area.")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        logout()
    End Sub

    Private Sub frm_home_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub frm_home_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)

        e.Graphics.DrawRectangle(Pens.DimGray, rect)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        resetall()
        panel_start.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
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
            e_mail.To.Add("08dunkg@ridgewayschool.com")
            e_mail.Subject = "New Bug Report"
            e_mail.IsBodyHtml = False
            e_mail.Body = bugreport
            Smtp_Server.Send(e_mail)
            MsgBox("Success!")
        Catch ex As Exception
            MsgBox("Failed.")
        End Try
    End Sub

    Private Sub txt_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_type.SelectedIndexChanged
        Select Case txt_type.SelectedIndex
            Case 0
            Case 1
                auth_code = InputBox("Please provide your authorisation code, this will have been emailed to you")
                If CheckData("SELECT * FROM auth_codes WHERE auth_code = '" & auth_code & "' AND type = 'faculty'") Then
                    MsgBox("Authorisation code accepted, now click 'Submit'.")
                Else
                    MsgBox("This is not a valid authorisation code.")
                    txt_type.SelectedIndex = -1
                End If
            Case 2
                auth_code = InputBox("Please provide your authorisation code, this will have been emailed to you")
                If CheckData("SELECT * FROM auth_codes WHERE auth_code = '" & auth_code & "' AND type = 'covermanager'") Then
                    MsgBox("Authorisation code accepted, now click 'Submit'.")
                Else
                    MsgBox("This is not a valid authorisation code.")
                    txt_type.SelectedIndex = -1
                End If
        End Select
    End Sub

    Private Sub btn_submitpassword_Click(sender As Object, e As EventArgs) Handles btn_submitpassword.Click
        If CheckData("SELECT * FROM users WHERE username = '" & My.Settings.CurrentUsername & "' AND password = '" & hash(txt_oldpassword.Text) & "'") Then
                Try
                    If txt_newpassword1.Text = "" Or txt_newpassword2.Text = "" Then
                    MsgBox("You must fill all fields!")
                    txt_newpassword1.ResetText()
                    txt_newpassword2.ResetText()
                    ElseIf txt_newpassword1.TextLength < 8 Then
                    MsgBox("Your password must be at least 8 characters")
                    txt_newpassword1.ResetText()
                    txt_newpassword2.ResetText()
                    ElseIf txt_newpassword1.Text = txt_newpassword2.Text Then
                        NewCommand("update users set password = '" & hash(txt_newpassword1.Text) & "' where username = '" & My.Settings.CurrentUsername & "'")
                        txt_oldpassword.ResetText()
                        txt_newpassword1.ResetText()
                        txt_newpassword2.ResetText()
                        MsgBox("Your password was changed successfully.")
                    Else
                    MsgBox("The new passwords do not match!")
                    txt_newpassword1.ResetText()
                    txt_newpassword2.ResetText()
                    End If
                Catch ex As Exception
                    MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
                End Try
        Else
            MsgBox("The password you entered is incorrect.")
            txt_oldpassword.ResetText()
            txt_newpassword1.ResetText()
            txt_newpassword2.ResetText()
        End If
    End Sub

    Private Sub btn_submittype_Click(sender As Object, e As EventArgs) Handles btn_submittype.Click
        Dim stafftype As String
        Select Case txt_type.SelectedIndex
            Case 0
                stafftype = "teacher"
            Case 1
                stafftype = "faculty"
            Case 2
                stafftype = "covermanager"
        End Select
        NewCommand("update users set type = '" & stafftype & "' where username = '" & My.Settings.CurrentUsername & "'")
        NewCommand("DELETE FROM auth_codes WHERE auth_code = '" & auth_code & "'")
        MsgBox("Your account type was changed successfully.")
        txt_type.SelectedIndex = -1
    End Sub
End Class