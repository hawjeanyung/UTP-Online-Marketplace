Public Class Category
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnHome3_Click(sender As Object, e As EventArgs) Handles btnHome3.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch3_Click(sender As Object, e As EventArgs) Handles btnSearch3.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Location = Me.btnTravelling.PointToClient(Me.PointToScreen(Me.Label2.Location))
        Me.Label2.Parent = Me.btnTravelling

        Me.Label3.Location = Me.btnClothes.PointToClient(Me.PointToScreen(Me.Label3.Location))
        Me.Label3.Parent = Me.btnClothes

        Me.Label4.Location = Me.btnKitchen.PointToClient(Me.PointToScreen(Me.Label4.Location))
        Me.Label4.Parent = Me.btnKitchen

        Me.Label5.Location = Me.btnSports.PointToClient(Me.PointToScreen(Me.Label5.Location))
        Me.Label5.Parent = Me.btnSports

        Me.Label6.Location = Me.btnPets.PointToClient(Me.PointToScreen(Me.Label6.Location))
        Me.Label6.Parent = Me.btnPets
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile3_Click(sender As Object, e As EventArgs) Handles btnProfile3.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotification3_Click(sender As Object, e As EventArgs) Handles btnNotification3.Click
        Notification.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class