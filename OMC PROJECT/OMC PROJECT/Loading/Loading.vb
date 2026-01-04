Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblReportProgress.Text = PBLoading1.Value & "%"

        PBLoading1.Value += 1

        If PBLoading1.Value > 10 Then
            LblStatusText.Text = "Loading.... Please wait"
        End If

        If PBLoading1.Value > 35 Then
            lblStatusText.Text = "Enjoy premium shopping!..."
        End If

        If PBLoading1.Value > 65 Then
            LblStatusText.Text = "Nice! What about a Like?"
        End If

        If PBLoading1.Value > 95 Then
            lblStatusText.Text = "Launching UniSustain!"
        End If

        If PBLoading1.Value = 100 Then
            lblStatusText.Text = "Thank You For Using UniSustain."
            SignIn.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub

    Private Sub Loading_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub PBLoading1_Click(sender As Object, e As EventArgs) Handles PBLoading1.Click

    End Sub
End Class
