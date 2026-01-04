Imports System.Security.Authentication.ExtendedProtection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UploadProduct
    Private Sub UploadProduct_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Shop.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Dim openfile As OpenFileDialog = New OpenFileDialog()
    Dim picture As String

    Private Sub pbxProduct_Click(sender As Object, e As EventArgs) Handles pbxProduct.Click
        openfile.Title = "Search for Image"
        openfile.Filter = "Image File|*.JPG"
        openfile.Filter = "Image File|*.PNG"
        If openfile.ShowDialog = DialogResult.OK Then
            picture = openfile.FileName
            pbxProduct.Image = Image.FromFile(picture)
        End If
    End Sub
    Private Sub btnUploadProduct_Click(sender As Object, e As EventArgs) Handles btnUploadProduct.Click
        Dim money As Integer
        If txtProductName.Text = "" Then
            MsgBox("Please enter your shop's name.")
        ElseIf txtPrice.Text = "" Then
            money = MsgBox("Please enter the price of your product.")
        ElseIf cbxCategories.Text = "" Then
            MsgBox("Please choose your item category.")
        Else
            If Search.Item1.Image Is Nothing Then
                Search.Item1.Image = pbxProduct.Image
                Search.Item1.Visible = True
                Shop.Item1.Image = pbxProduct.Image
                Shop.Label1.Visible = True
                Search.btnAdd1.Visible = True
                Search.btnAdd1.Enabled = True
            ElseIf Not Search.Item1.Image Is Nothing And Search.Item2.Image Is Nothing Then
                Search.Item2.Image = pbxProduct.Image
                Search.Item2.Visible = True
                Shop.Item2.Image = pbxProduct.Image
                Shop.Label1.Visible = True
                Search.btnAdd2.Visible = True
                Search.btnAdd2.Enabled = True
            ElseIf Not Search.Item2.Image Is Nothing And Search.Item3.Image Is Nothing Then
                Search.Item3.Image = pbxProduct.Image
                Search.Item3.Visible = True
                Shop.Item3.Image = pbxProduct.Image
                Shop.Label1.Visible = True
                Search.btnAdd3.Visible = True
                Search.btnAdd3.Enabled = True
            ElseIf Not Search.Item3.Image Is Nothing And Search.Item4.Image Is Nothing Then
                Search.Item4.Image = pbxProduct.Image
                Search.Item4.Visible = True
                Search.btnAdd4.Visible = True
                Search.btnAdd4.Enabled = True
            End If

            If Search.lblItemName1.Text = "" Then
                Search.lblItemName1.Text = txtProductName.Text
                Search.lblItemName1.Visible = True
                Shop.lblItemName1.Text = txtProductName.Text
                Shop.lblItemName1.Visible = True
            ElseIf Search.lblItemName1.Text <> "" And Search.lblItemName2.Text = "" Then
                Search.lblItemName2.Text = txtProductName.Text
                Search.lblItemName2.Visible = True
                Shop.lblItemName2.Text = txtProductName.Text
                Shop.lblItemName2.Visible = True
            ElseIf Search.lblItemName2.Text <> "" And Search.lblItemName3.Text = "" Then
                Search.lblItemName3.Text = txtProductName.Text
                Search.lblItemName3.Visible = True
                Shop.lblItemName3.Text = txtProductName.Text
                Shop.lblItemName3.Visible = True
            ElseIf Search.lblItemName3.Text <> "" And Search.lblItemName4.Text = "" Then
                Search.lblItemName4.Text = txtProductName.Text
                Search.lblItemName4.Visible = True
            End If

            Dim price As Integer = Val(txtPrice.Text)

            If Search.lblPrice1.Text = "" Then
                Search.lblPrice1.Text = price
                Search.lblPrice1.Visible = True
                Shop.lblPrice1.Text = price
                Shop.lblPrice1.Visible = True
            ElseIf Search.lblPrice1.Text <> "" And Search.lblPrice2.Text = "" Then
                Search.lblPrice2.Text = txtPrice.Text
                Search.lblPrice2.Visible = True
                Shop.lblPrice2.Text = txtPrice.Text
                Shop.lblPrice2.Visible = True
            ElseIf Search.lblPrice2.Text <> "" And Search.lblPrice3.Text = "" Then
                Search.lblPrice3.Text = txtPrice.Text
                Search.lblPrice3.Visible = True
                Shop.lblPrice3.Text = txtPrice.Text
                Shop.lblPrice3.Visible = True
            ElseIf Search.lblPrice3.Text <> "" And Search.lblPrice4.Text = "" Then
                Search.lblPrice4.Text = txtPrice.Text
                Search.lblPrice4.Visible = True
            End If
            Shop.Show()
            Me.Hide()
        End If
    End Sub
End Class