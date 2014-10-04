Public Class frm_notify

    'FORM LOAD
    Private Sub frm_notify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.Bounds.Height)
        timerfadein.Start()
        timertimeout.Start()
        lbl_notification.SelectionStart = 0
    End Sub

    'GLIDE ONTO SCREEN
    Private Sub timerfadein_Tick(sender As Object, e As EventArgs) Handles timerfadein.Tick
        If Not Me.Location.Y < Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        Else
            timerfadein.Stop()
        End If
    End Sub

    'CLOSE NOTIFICATION AFTER A CERTAIN PERIOD OF TIME
    Private Sub timertimeout_Tick(sender As Object, e As EventArgs) Handles timertimeout.Tick
        Me.Close()
        timertimeout.Stop()
    End Sub

    'HIDE NOTIFICATION
    Private Sub frm_notify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.Bounds.Height)
        timertimeout.Stop()
    End Sub
End Class