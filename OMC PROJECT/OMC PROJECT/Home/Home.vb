Imports System.Data.OleDb

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Home_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategory1_Click(sender As Object, e As EventArgs) Handles btnCategory1.Click
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SignIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Cart.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile1_Click(sender As Object, e As EventArgs) Handles btnProfile1.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub btnHomeBlack_Click(sender As Object, e As EventArgs) Handles btnChallenges.Click
        Challenges.Show()
        Me.Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settings.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotification1_Click(sender As Object, e As EventArgs) Handles btnNotification1.Click
        Notification.Show()
        Me.Hide()
    End Sub

    Private Sub btnBeASeller_Click(sender As Object, e As EventArgs) Handles btnBeASeller.Click
        BecomeSeller1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub


    Private Sub btnCommunication_Click(sender As Object, e As EventArgs) Handles btnCommunication.Click
        Shop.Show()
        Me.Hide()
    End Sub

    Private Sub btnPaymentHistory_Click(sender As Object, e As EventArgs) Handles btnPaymentHistory.Click
        PurchaseHistory.Show()
        Me.Hide()
    End Sub
End Class