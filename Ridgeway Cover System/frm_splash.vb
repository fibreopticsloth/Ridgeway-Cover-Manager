Public Class frm_splash

    'DECLARATIONS
    Dim loadvalue As Integer

    'FORM LOAD
    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timersplash.Start()
        timerfade.Start()
        lbl_version.Text = "Version " + My.Settings.version
        Me.Opacity = 0
    End Sub

    'FORM FADE IN
    Private Sub timerfade_Tick(sender As Object, e As EventArgs) Handles timerfade.Tick
        Me.Opacity += 0.1
    End Sub

    'LOADING TEXT & TIMER
    Private Sub timersplash_Tick(sender As Object, e As EventArgs) Handles timersplash.Tick
        loadvalue += 1
        lbl_loading.Text = lbl_loading.Text + "."
        If loadvalue = 4 Then
            Me.Hide()
            frm_login.Show()
            frm_login.BringToFront()
        End If
    End Sub
End Class