Imports MySql.Data.MySqlClient
Module getdata

    Public updatecount As Integer

    'GET ALL DATA
    Public Sub getalldata()

        'MY REQUESTS - LESSONS
        NewQuery("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked from lessons where teacher='" & My.Settings.currentuser & "'", frm_home.dg_mycovers)
        'MY REQUESTS - ROOMS
        NewQuery("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Booked from roomchange where teacher='" & My.Settings.currentuser & "'", frm_home.dg_myroomchanges)
        'FACULTY AREA
        NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Reason from lessons where facultyhead='" & My.Settings.currentuser & "' and approved = 'Pending'", frm_home.dg_viewrequests)
        'COVER MANAGEMENT - LESSONS
        NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked, Push from lessons where approved = 'approved' and booked = 'pending'", frm_covermanagement.dg_covers)
        'COVER MANAGEMENT - ROOMS
        NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Booked, Push from roomchange where booked = 'pending'", frm_covermanagement.dg_rooms)
        'ADMIN - USERS
        NewQuery("select ID, username, type from users", frm_admin.dg_users)
        frm_home.hidecolumns()

        Dim rd As MySqlDataReader = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push='1' and booked = 'booked' and teacher = '" & My.Settings.currentuser & "'")
        CheckEmpty()
        If rd.HasRows Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
            NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & rd.Item(0).ToString & "'")
            updatecount += 1
        End If

        Dim rd2 As MySqlDataReader = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and approved = 'Approved' and booked = 'Pending' and teacher = '" & My.Settings.currentuser & "'")
        CheckEmpty()
        If rd.HasRows Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been approved." + vbNewLine + vbNewLine
            NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & rd.Item(0).ToString & "'")
            updatecount += 1
        End If

        Dim rd3 As MySqlDataReader = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and booked = 'N/A' and teacher = '" & My.Settings.currentuser & "'")
        CheckEmpty()
        If rd.HasRows Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been rejected." + vbNewLine + vbNewLine
            NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & rd.Item(0).ToString & "'")
            updatecount += 1
        End If

        Dim rd4 As MySqlDataReader = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from roomchange where push = '1' and teacher = '" & My.Settings.currentuser & "'")
        CheckEmpty()
        If rd.HasRows Then
            frm_home.lbl_notify.Text += "Room change from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
            NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & rd.Item(0).ToString & "'")
            updatecount += 1
        End If

        frm_home.btn_notifications.Text = "       Notifications" + " (" + updatecount.ToString + ")"
        My.Settings.usernotifications = frm_home.lbl_notify.Text
        My.Settings.usernotificationcount = updatecount.ToString
        My.Settings.Save()
        frm_home.hidecolumns()

    End Sub

    'CHECK IF NOTIFICATION ARE EMPTY
    Public Sub CheckEmpty()

        If frm_home.lbl_notify.Text = "No notifications to show!" Then
            frm_home.lbl_notify.ResetText()
        ElseIf frm_home.lbl_notify.Text = "" Then
            frm_home.lbl_notify.Text = "No notifications to show!"
        End If

    End Sub

End Module
