Imports System.Data.OleDb

Public Class Shop
    Private Sub Shop_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome1_Click(sender As Object, e As EventArgs) Handles btnHome1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategory1_Click(sender As Object, e As EventArgs) Handles btnCategory1.Click
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotification1_Click(sender As Object, e As EventArgs) Handles btnNotification1.Click
        Notification.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile1_Click(sender As Object, e As EventArgs) Handles btnProfile1.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignIn2_Click(sender As Object, e As EventArgs) Handles btnSignIn2.Click
        UploadProduct.Show()
        Hide()
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        pbxProduct.Visible = False
        pbxProduct.Enabled = False
        btnSignIn2.Visible = False
        btnSignIn2.Enabled = False
    End Sub

    Private Sub pbxProduct_Click(sender As Object, e As EventArgs) Handles pbxProduct.Click
        BecomeSeller2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BecomeSeller1.Show()
        Me.Hide()
    End Sub
End Class