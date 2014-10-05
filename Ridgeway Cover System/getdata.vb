Imports MySql.Data.MySqlClient
Module getdata

    Dim rd As MySqlDataReader
    Public updatecount As Integer

    'UPDATE COMMAND
    Public Function updatecmd(ByVal cmdtext As String)
            cmd = New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = cmdtext
            rd = cmd.ExecuteReader()
            If rd.HasRows Then
                rd.Read()
                If frm_home.lbl_notify.Text = "No notifications to show!" Then
                    frm_home.lbl_notify.ResetText()
                End If
                Return 1
            Else
                rd.Dispose()
                If frm_home.lbl_notify.Text = "" Then
                    frm_home.lbl_notify.Text = "No notifications to show!"
                End If
                Return 0
            End If
    End Function

    'GET DATA
    Public Sub newqry(ByVal cmdtext As String, ByVal table As DataGridView)
        Dim da As New MySqlDataAdapter(cmdtext, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Data")
        table.DataSource = ds
        table.DataMember = "Data"
        ds.Dispose()
        da.Dispose()
    End Sub


    Public Sub getalldata()


        Try


        
        connect()

        'MY REQUESTS - LESSONS
        newqry("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked from lessons where teacher='" & My.Settings.currentuser & "'", frm_home.dg_mycovers)
        'MY REQUESTS - ROOMS
        newqry("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Booked from roomchange where teacher='" & My.Settings.currentuser & "'", frm_home.dg_myroomchanges)
        'FACULTY AREA
        newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Reason from lessons where facultyhead='" & My.Settings.currentuser & "' and approved = 'Pending'", frm_home.dg_viewrequests)
        'COVER MANAGEMENT - LESSONS
        newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked, Push from lessons where approved = 'approved' and booked = 'pending'", frm_covermanagement.dg_covers)
        'COVER MANAGEMENT - ROOMS
        newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Booked, Push from roomchange where booked = 'pending'", frm_covermanagement.dg_rooms)
        'ADMIN - USERS
        newqry("select ID, username, type from users", frm_admin.dg_users)
        frm_home.hidecolumns()


        If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push='1' and booked = 'booked'") Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
            newcmd("update lessons set push = '0' where id = '" & rd.Item(0).ToString & "'")
            rd.Dispose()
            cmd.ExecuteNonQuery()
            updatecount += 1
        End If
        If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and approved = 'Approved' and booked = 'Pending'") Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been approved." + vbNewLine + vbNewLine
            newcmd("update lessons set push = '0' where id = '" & rd.Item(0).ToString & "'")
            rd.Dispose()
            cmd.ExecuteNonQuery()
            updatecount += 1
        End If
        If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and booked = 'N/A'") Then
            frm_home.lbl_notify.Text += "Cover from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been rejected." + vbNewLine + vbNewLine
            newcmd("update lessons set push = '0' where id = '" & rd.Item(0).ToString & "'")
            rd.Dispose()
            cmd.ExecuteNonQuery()
            updatecount += 1
        End If
        If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from roomchange where push = '1'") Then
            frm_home.lbl_notify.Text += "Room change from " + rd.Item(1).ToString + " to " + rd.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
            newcmd("update roomchange set push = '0' where id = '" & rd.Item(0).ToString & "'")
            rd.Dispose()
            cmd.ExecuteNonQuery()
            updatecount += 1
        End If

        frm_home.btn_notifications.Text = "      Notifications" + " (" + updatecount.ToString + ")"

        My.Settings.usernotifications = frm_home.lbl_notify.Text
        My.Settings.usernotificationcount = updatecount.ToString
        My.Settings.Save()
        frm_home.hidecolumns()


        Catch ex As Exception

        End Try

        frm_home.BackgroundWorker.Dispose()
    End Sub
End Module
