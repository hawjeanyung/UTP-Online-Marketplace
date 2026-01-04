Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CreateAccount
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")
    Private Sub btnSignIn2_Click(sender As Object, e As EventArgs) Handles btnSignIn2.Click
        Dim mycmd As New OleDbCommand("Insert into [Omc]([First Name], [Last Name], [Email], [Password]) values ('" & txtFirstName2.Text & "', '" & txtLastName2.Text & "', '" & txtEmail2.Text & "', '" & txtPassword2.Text & "')", mycon)
        mycon.Open()
        Try
            mycmd.ExecuteNonQuery()
            txtFirstName2.Clear()
            txtLastName2.Clear()
            txtEmail2.Clear()
            txtPassword2.Clear()
            txtReenterPassword2.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mycon.Close()
        SignIn.Show()
        Me.Hide()
    End Sub

    Private Sub CreateAccount_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SignIn.Show()
        Me.Hide()
    End Sub
End Class