Imports System.Data.OleDb
Imports Windows.Win32.System

Public Class Profile
    Private Sub Profile_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        SignIn.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.Open()
        Dim cmd As New OleDbCommand("Select * from Omc where Email=@email", mycon)
        cmd.Parameters.AddWithValue("@email", SignIn.txtEmail1.Text)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader()

        If myreader.Read() Then
            lblName.Text = (myreader("First Name").ToString & vbCrLf & vbCrLf & myreader("Last Name").ToString & vbCrLf & vbCrLf)
            lblEmail.Text = myreader("Email").ToString & vbCrLf & vbCrLf
            lblPassword.Text = myreader("Password").ToString & vbCrLf & vbCrLf
        End If
        mycon.Close()
    End Sub

End Class