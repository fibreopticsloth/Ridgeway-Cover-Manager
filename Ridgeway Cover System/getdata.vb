Imports MySql.Data.MySqlClient
Module getdata

    Public updatecount As Integer
    Public facultycount As Integer

    'GET ALL DATA
    Public Sub getalldata()

        If CheckConnection() Then

            'MY REQUESTS - LESSONS
            NewQuery("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked from lessons where teacher='" & My.Settings.CurrentUsername & "'", frm_home.dg_mycovers)
            'MY REQUESTS - ROOMS
            NewQuery("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Booked from roomchange where teacher='" & My.Settings.CurrentUsername & "'", frm_home.dg_myroomchanges)
            'FACULTY AREA
            NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Reason from lessons where facultyhead='" & My.Settings.CurrentUsername & "' and approved = 'Pending'", frm_home.dg_viewrequests)
            'COVER MANAGEMENT - LESSONS
            NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked, Push from lessons where approved = 'approved' and booked = 'pending'", frm_covermanagement.dg_covers)
            'COVER MANAGEMENT - ROOMS
            NewQuery("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Booked, Push from roomchange where booked = 'pending'", frm_covermanagement.dg_rooms)
            'ADMIN - USERS
            NewQuery("select ID, username, type from users", frm_admin.dg_users)
            frm_home.hidecolumns()

            Dim prv As String = frm_home.lbl_notify.Text

            Dim ds1 As DataSet = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push='1' and booked = 'booked' and teacher = '" & My.Settings.CurrentUsername & "'")

            If ds1.Tables(0).Rows.Count > 0 Then
                CheckEmpty()
                Dim row As DataRow = ds1.Tables(0).Rows(0)
                frm_home.lbl_notify.Text += "Cover from " + row.Item(1).ToString + " to " + row.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
                NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & row.Item(0).ToString & "'")
                updatecount += 1
                ds1.Reset()
            End If

            Dim ds2 As DataSet = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and approved = 'Approved' and booked = 'Pending' and teacher = '" & My.Settings.CurrentUsername & "'")

            If ds2.Tables(0).Rows.Count > 0 Then
                CheckEmpty()
                Dim row As DataRow = ds2.Tables(0).Rows(0)
                frm_home.lbl_notify.Text += "Cover from " + row.Item(1).ToString + " to " + row.Item(3).ToString + " has been approved." + vbNewLine + vbNewLine
                NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & row.Item(0).ToString & "'")
                updatecount += 1
                ds2.Reset()
            End If

            Dim ds3 As DataSet = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and booked = 'N/A' and teacher = '" & My.Settings.CurrentUsername & "'")

            If ds3.Tables(0).Rows.Count > 0 Then
                CheckEmpty()
                Dim row As DataRow = ds3.Tables(0).Rows(0)
                frm_home.lbl_notify.Text += "Cover from " + row.Item(1).ToString + " to " + row.Item(3).ToString + " has been rejected." + vbNewLine + vbNewLine
                NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & row.Item(0).ToString & "'")
                updatecount += 1
                ds3.Reset()
            End If

            Dim ds4 As DataSet = NewDataCommand("SELECT id, startdate, startperiod, enddate, endperiod from roomchange where push = '1' and teacher = '" & My.Settings.CurrentUsername & "'")

            If ds4.Tables(0).Rows.Count > 0 Then
                CheckEmpty()
                Dim row As DataRow = ds4.Tables(0).Rows(0)
                frm_home.lbl_notify.Text += "Room change from " + row.Item(1).ToString + " to " + row.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
                NewCommand("UPDATE lessons SET push = '0' WHERE id = '" & row.Item(0).ToString & "'")
                updatecount += 1
                ds4.Reset()
            End If

            facultycount = frm_home.dg_viewrequests.RowCount

            frm_home.btn_notifications.Text = "Notifications" + " (" + updatecount.ToString + ")"
            frm_home.btn_facultyarea.Text = "Faculty Area" + " (" + facultycount.ToString + ")"
            My.Settings.FacultyNotificationsCount = facultycount.ToString
            My.Settings.UserNotificationsText = frm_home.lbl_notify.Text
            My.Settings.UserNotificationsCount = updatecount.ToString
            My.Settings.Save()
            frm_home.hidecolumns()

            If prv <> frm_home.lbl_notify.Text Then
                frm_home.nfi.BalloonTipText = "You have new notifications."
                frm_home.nfi.ShowBalloonTip(6)
            End If

            If MySQL_Connection.CheckConnection Then

                Using Connection As New MySqlConnection(ConnectionString)

                    Using da As New MySqlDataAdapter("select username from users where type = 'faculty' or type = 'covermanager'", Connection)
                        Dim ds As New DataSet
                        da.Fill(ds, "users")
                        Dim dt As DataTable = ds.Tables(0)
                        frm_home.requestcover_txt_facultyhead.Items.Clear()
                        For Each DataRow In dt.Rows
                            frm_home.requestcover_txt_facultyhead.Items.Add(DataRow(0))
                        Next
                        ds.Dispose()
                        da.Dispose()
                    End Using

                End Using

            End If

            If frm_home.lbl_notify.Text = "" Then
                frm_home.lbl_notify.Text = "No notifications to show!"
            End If

        End If

    End Sub

    'CHECK IF NOTIFICATION AREA EMPTY
    Public Sub CheckEmpty()

        If frm_home.lbl_notify.Text = "No notifications to show!" Then
            frm_home.lbl_notify.ResetText()
        End If

    End Sub

End Module
