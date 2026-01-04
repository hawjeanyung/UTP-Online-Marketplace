Imports System.Data.OleDb

Public Class BecomeSeller2
    Private Sub BecomeSeller2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BecomeSeller1.Show()
        Me.Hide()
    End Sub

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Shop.Button1.Visible = False
        Shop.Button1.Enabled = False
        Shop.lblShopName.Text = txtShopName.Text
        Dim phone As Integer
        If txtShopName.Text = "" Then
            MsgBox("Please enter your shop name.")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please enter you email.")
        ElseIf txtPhoneNumber.Text = "" Then
            phone = MsgBox("Please enter your phone number.")
        Else
            save()
            Shop.Show()
            Me.Hide()
            Shop.btnSignIn2.Visible = True
            Shop.btnSignIn2.Enabled = True
            Shop.pbxProduct.Visible = True
            Shop.pbxProduct.Enabled = True
        End If
    End Sub
    Sub save()
        Dim mycmd As New OleDbCommand("Insert into [Seller]([Shop Name], [Email], [Phone Number]) values ('" & txtShopName.Text & "', '" & txtEmail.Text & "', '" & txtPhoneNumber.Text & "')", mycon)
        mycon.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mycon.Close()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BecomeSeller1.Show()
        Me.Hide()
    End Sub

    Dim openfile As OpenFileDialog = New OpenFileDialog()
    Dim picture As String
    Private Sub pbxProduct_Click(sender As Object, e As EventArgs) Handles pbxProduct.Click
        openfile.Title = "Search for Image"
        openfile.Filter = "Image File|*.JPG;*.PNG"

        If openfile.ShowDialog = DialogResult.OK Then
            picture = openfile.FileName
            pbxProduct.Image = Image.FromFile(picture)
            Shop.pbxProduct.Image = Image.FromFile(picture)
        End If
    End Sub
End Class