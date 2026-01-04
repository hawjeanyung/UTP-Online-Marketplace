Public Class Search
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Search_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnCategory2_Click(sender As Object, e As EventArgs) Handles btnCategory2.Click
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotification2_Click(sender As Object, e As EventArgs) Handles btnNotification2.Click
        Notification.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile2_Click(sender As Object, e As EventArgs) Handles btnProfile2.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        If Cart.PictureBox1.Image Is Nothing Then
            Cart.PictureBox1.Image = Item1.Image
            Cart.lblPrice1.Text = lblPrice1.Text
            Cart.lblPrice1.Visible = True
            Cart.lblItemName1.Text = lblItemName1.Text
            Cart.lblItemName1.Visible = True
            Cart.btnAddPink.Visible = True
            Cart.btnMinusPink.Visible = True
            Cart.lblPink.Visible = True
            Cart.lblRM1.Visible = True
        ElseIf Not Cart.PictureBox1.Image Is Nothing And Cart.PictureBox2.Image Is Nothing Then
            Cart.PictureBox2.Image = Item1.Image
            Cart.lblPrice2.Text = lblPrice1.Text
            Cart.lblPrice2.Visible = True
            Cart.lblItemName2.Text = lblItemName1.Text
            Cart.lblItemName2.Visible = True
            Cart.btnAddBlue.Visible = True
            Cart.btnMinusBlue.Visible = True
            Cart.lblBlue.Visible = True
            Cart.lblRM2.Visible = True
        ElseIf Not Cart.PictureBox2.Image Is Nothing And Cart.PictureBox3.Image Is Nothing Then
            Cart.PictureBox3.Image = Item1.Image
            Cart.lblPrice3.Text = lblPrice1.Text
            Cart.lblPrice3.Visible = True
            Cart.lblItemName3.Text = lblItemName1.Text
            Cart.lblItemName3.Visible = True
                Cart.btnAddWhite.Visible = True
                Cart.btnMinusWhite.Visible = True
                Cart.lblWhite.Visible = True
            Cart.lblRM3.Visible = True
        End If
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        If Cart.PictureBox1.Image Is Nothing Then
            Cart.PictureBox1.Image = Item2.Image
            Cart.lblPrice1.Text = lblPrice2.Text
            Cart.lblPrice1.Visible = True
            Cart.lblItemName1.Text = lblItemName2.Text
            Cart.lblItemName1.Visible = True
            Cart.btnAddPink.Visible = True
            Cart.btnMinusPink.Visible = True
            Cart.lblPink.Visible = True
            Cart.lblRM1.Visible = True
        ElseIf Not Cart.PictureBox1.Image Is Nothing And Cart.PictureBox2.Image Is Nothing Then
            Cart.PictureBox2.Image = Item2.Image
            Cart.lblPrice2.Text = lblPrice2.Text
            Cart.lblPrice2.Visible = True
            Cart.lblItemName2.Text = lblItemName2.Text
            Cart.lblItemName2.Visible = True
            Cart.btnAddBlue.Visible = True
            Cart.btnMinusBlue.Visible = True
            Cart.lblBlue.Visible = True
            Cart.lblRM2.Visible = True
        ElseIf Not Cart.PictureBox2.Image Is Nothing And Cart.PictureBox3.Image Is Nothing Then
            Cart.PictureBox3.Image = Item2.Image
            Cart.lblPrice3.Text = lblPrice2.Text
            Cart.lblPrice3.Visible = True
            Cart.lblItemName3.Text = lblItemName2.Text
            Cart.lblItemName3.Visible = True
            Cart.btnAddWhite.Visible = True
            Cart.btnMinusWhite.Visible = True
            Cart.lblWhite.Visible = True
            Cart.lblRM3.Visible = True
        End If
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        If Cart.PictureBox1.Image Is Nothing Then
            Cart.PictureBox1.Image = Item3.Image
            Cart.lblPrice1.Text = lblPrice3.Text
            Cart.lblPrice1.Visible = True
            Cart.lblItemName1.Text = lblItemName3.Text
            Cart.lblItemName1.Visible = True
            Cart.btnAddPink.Visible = True
            Cart.btnMinusPink.Visible = True
            Cart.lblPink.Visible = True
            Cart.lblRM1.Visible = True
        ElseIf Not Cart.PictureBox1.Image Is Nothing And Cart.PictureBox2.Image Is Nothing Then
            Cart.PictureBox2.Image = Item3.Image
            Cart.lblPrice2.Text = lblPrice3.Text
            Cart.lblPrice2.Visible = True
            Cart.lblItemName2.Text = lblItemName3.Text
            Cart.lblItemName2.Visible = True
            Cart.btnAddBlue.Visible = True
            Cart.btnMinusBlue.Visible = True
            Cart.lblBlue.Visible = True
            Cart.lblRM2.Visible = True
        ElseIf Not Cart.PictureBox2.Image Is Nothing And Cart.PictureBox3.Image Is Nothing Then
            Cart.PictureBox3.Image = Item3.Image
            Cart.lblPrice3.Text = lblPrice3.Text
            Cart.lblPrice3.Visible = True
            Cart.lblItemName3.Text = lblItemName3.Text
            Cart.lblItemName3.Visible = True
            Cart.btnAddWhite.Visible = True
            Cart.btnMinusWhite.Visible = True
            Cart.lblWhite.Visible = True
            Cart.lblRM3.Visible = True
        End If
    End Sub

    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        If Cart.PictureBox1.Image Is Nothing Then
            Cart.PictureBox1.Image = Item4.Image
            Cart.lblPrice1.Text = lblPrice4.Text
            Cart.lblPrice1.Visible = True
            Cart.lblItemName1.Text = lblItemName4.Text
            Cart.lblItemName1.Visible = True
            Cart.btnAddPink.Visible = True
            Cart.btnMinusPink.Visible = True
            Cart.lblPink.Visible = True
            Cart.lblRM1.Visible = True
        ElseIf Not Cart.PictureBox1.Image Is Nothing And Cart.PictureBox2.Image Is Nothing Then
            Cart.PictureBox2.Image = Item4.Image
            Cart.lblPrice2.Text = lblPrice4.Text
            Cart.lblPrice2.Visible = True
            Cart.lblItemName2.Text = lblItemName4.Text
            Cart.lblItemName2.Visible = True
            Cart.btnAddBlue.Visible = True
            Cart.btnMinusBlue.Visible = True
            Cart.lblBlue.Visible = True
            Cart.lblRM2.Visible = True
        ElseIf Not Cart.PictureBox2.Image Is Nothing And Cart.PictureBox3.Image Is Nothing Then
            Cart.PictureBox3.Image = Item4.Image
            Cart.lblPrice3.Text = lblPrice4.Text
            Cart.lblPrice3.Visible = True
            Cart.lblItemName3.Text = lblItemName4.Text
            Cart.lblItemName3.Visible = True
            Cart.btnAddWhite.Visible = True
            Cart.btnMinusWhite.Visible = True
            Cart.lblWhite.Visible = True
            Cart.lblRM3.Visible = True
        End If
    End Sub
End Class