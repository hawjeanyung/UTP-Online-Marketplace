Public Class Cart
    Private Sub Purchase_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnHome3_Click(sender As Object, e As EventArgs) Handles btnHome3.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategory3_Click(sender As Object, e As EventArgs) Handles btnCategory3.Click
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch3_Click(sender As Object, e As EventArgs) Handles btnSearch3.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Step1.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddPink_Click(sender As Object, e As EventArgs) Handles btnAddPink.Click
        lblPink.Text += 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10

    End Sub

    Private Sub btnMinusPink_Click(sender As Object, e As EventArgs) Handles btnMinusPink.Click
        lblPink.Text -= 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10
    End Sub

    Private Sub btnAddBlue_Click(sender As Object, e As EventArgs) Handles btnAddBlue.Click
        lblBlue.Text += 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10
    End Sub

    Private Sub btnMinusBlue_Click(sender As Object, e As EventArgs) Handles btnMinusBlue.Click
        lblBlue.Text -= 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10
    End Sub

    Private Sub btnNotification3_Click(sender As Object, e As EventArgs) Handles btnNotification3.Click
        Notification.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile3_Click(sender As Object, e As EventArgs) Handles btnProfile3.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddWhite_Click(sender As Object, e As EventArgs) Handles btnAddWhite.Click
        lblWhite.Text += 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10
    End Sub

    Private Sub btnMinusWhite_Click(sender As Object, e As EventArgs) Handles btnMinusWhite.Click
        lblWhite.Text -= 1
        lblSubTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text))
        lblTotal.Text = (Val(lblPrice1.Text) * Val(lblPink.Text) + Val(lblPrice2.Text) * Val(lblBlue.Text) + Val(lblPrice3.Text) * Val(lblWhite.Text)) + 10
    End Sub


End Class