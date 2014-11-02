Public Class frm_splash

    'DECLARATIONS
    Dim loadvalue As Integer

    'FORM LOAD
    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timersplash.Start()
        timerfade.Start()
        lbl_version.Text = "Version " + My.Settings.Version
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
            frm_login.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub frm_splash_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)

        e.Graphics.DrawRectangle(Pens.White, rect)
    End Sub
End Class