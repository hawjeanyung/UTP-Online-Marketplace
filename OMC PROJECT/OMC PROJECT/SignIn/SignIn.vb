Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles
Public Class SignIn
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")
    Dim myread As OleDbDataReader
    Private Sub btnSignIn1_Click(sender As Object, e As EventArgs) Handles btnSignIn1.Click
        save()
    End Sub
    Sub save()
        Dim mycmd As New OleDbCommand("Select * from [Omc] where Email = '" & txtEmail1.Text & "' And Password = '" & txtPassword1.Text & "'", mycon)
        mycon.Open()
        myread = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("ACCESS GRANTED")
            Home.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Email or Password. Try Again")
        End If
        mycon.Close()
    End Sub

    Private Sub btnCreate1_Click(sender As Object, e As EventArgs) Handles btnCreate1.Click
        CreateAccount.Show()
        Hide()
    End Sub

    Private Sub SignIn_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub chkRemember_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemember.CheckedChanged
        If chkRemember.Checked = True Then
            txtPassword1.UseSystemPasswordChar = False
        ElseIf chkRemember.Checked = False Then
            txtPassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class