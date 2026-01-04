Imports System.Data.OleDb

Public Class Step1
    Private Sub Step1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Cart.Show()
        Hide()
    End Sub

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If txtName.Text = "" Then
            MsgBox("Please enter your name")
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please enter your address")
        ElseIf txtCity.Text = "" Then
            MsgBox("Please enter city")
        ElseIf txtCountry.Text = "" Then
            MsgBox("Please enter country")
        Else
            save()
        End If
    End Sub

    Sub save()
        Dim mycmd As New OleDbCommand("Insert into [Omc]([Phone Number], [Address], [City], [Country]) values ('" & txtPhoneNumber.Text & "', '" & txtAddress.Text & "', '" & txtCity.Text & "', '" & txtCountry.Text & "')", mycon)
        mycon.Open()
        Try
            mycmd.ExecuteNonQuery()
            txtName.Clear()
            txtPhoneNumber.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtCountry.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mycon.Close()
        Step2.Show()
        Me.Hide()
    End Sub
End Class