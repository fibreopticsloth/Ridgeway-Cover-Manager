Imports MySql.Data.MySqlClient
Public Class frm_background

    'DECLARATIONS
    Dim rdupdate As MySqlDataReader
    Dim id As Integer
    Public updatecount As Integer

    'FORM LOAD
    Private Sub frm_background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        updatetimer.Start()
    End Sub

    'SHOW NUMBER OF NOTIFICATIONS
    Public Sub showupdates()
        frm_home.btn_notifications.Text = "      Notifications" + " (" + updatecount.ToString + ")"
    End Sub

    'UPDATE COMMAND
    Public Function updatecmd(ByVal cmdtext As String)
        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
        rdupdate = cmd.ExecuteReader()
        If rdupdate.HasRows Then
            rdupdate.Read()
            checkempty()
            Return 1
        Else
            rdupdate.Dispose()
            If frm_home.lbl_notify.Text = "" Then
                frm_home.lbl_notify.Text = "No notifications to show!"
            End If
            Return 0
        End If
    End Function

    'CHECK IF NOTIFICATIONS EMPTY
    Public Sub checkempty()
        If frm_home.lbl_notify.Text = "No notifications to show!" Then
            frm_home.lbl_notify.ResetText()
        End If
    End Sub

    'REGULARLY CHECK FOR UPDATES TO USERS REQUESTS
    Public Sub checknotifications()
        If checkconn() Then
            If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push='1' and booked = 'booked'") Then
                frm_home.lbl_notify.Text += "Cover from " + rdupdate.Item(1).ToString + " to " + rdupdate.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
                newcmd("update lessons set push = '0' where id = '" & rdupdate.Item(0).ToString & "'")
                rdupdate.Dispose()
                cmd.ExecuteNonQuery()
                updatecount += 1
            End If
            If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and approved = 'Approved' and booked = 'Pending'") Then
                frm_home.lbl_notify.Text += "Cover from " + rdupdate.Item(1).ToString + " to " + rdupdate.Item(3).ToString + " has been approved." + vbNewLine + vbNewLine
                newcmd("update lessons set push = '0' where id = '" & rdupdate.Item(0).ToString & "'")
                rdupdate.Dispose()
                cmd.ExecuteNonQuery()
                updatecount += 1
            End If
            If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from lessons where push ='1' and booked = 'N/A'") Then
                frm_home.lbl_notify.Text += "Cover from " + rdupdate.Item(1).ToString + " to " + rdupdate.Item(3).ToString + " has been rejected." + vbNewLine + vbNewLine
                newcmd("update lessons set push = '0' where id = '" & rdupdate.Item(0).ToString & "'")
                rdupdate.Dispose()
                cmd.ExecuteNonQuery()
                updatecount += 1
            End If
            If updatecmd("SELECT id, startdate, startperiod, enddate, endperiod from roomchange where push = '1'") Then
                frm_home.lbl_notify.Text += "Room change from " + rdupdate.Item(1).ToString + " to " + rdupdate.Item(3).ToString + " has been booked." + vbNewLine + vbNewLine
                newcmd("update roomchange set push = '0' where id = '" & rdupdate.Item(0).ToString & "'")
                rdupdate.Dispose()
                cmd.ExecuteNonQuery()
                updatecount += 1
            End If
        End If
        showupdates()
        My.Settings.usernotifications = frm_home.lbl_notify.Text
        My.Settings.usernotificationcount = updatecount.ToString
        My.Settings.Save()
        frm_home.hidecolumns()
    End Sub

    'HIDE FORM
    Private Sub frm_background_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Visible = False
    End Sub

    'CHECK UPDATES EVERY 5 SECONDS
    Private Sub updatetimer_Tick(sender As Object, e As EventArgs) Handles updatetimer.Tick
        checknotifications()
    End Sub
End Class