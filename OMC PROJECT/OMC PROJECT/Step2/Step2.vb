Imports System.Data.OleDb

Public Class Step2
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")
    Private Sub Step2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Step1.Show()
        Me.Hide()
    End Sub

    Private Sub Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblCardNumber.Location = Me.PictureBox4.PointToClient(Me.PointToScreen(Me.lblCardNumber.Location))
        Me.lblCardNumber.Parent = Me.PictureBox4

        Me.lblExpirationDate.Location = Me.PictureBox4.PointToClient(Me.PointToScreen(Me.lblExpirationDate.Location))
        Me.lblExpirationDate.Parent = Me.PictureBox4

        Me.lblCVV.Location = Me.PictureBox4.PointToClient(Me.PointToScreen(Me.lblCVV.Location))
        Me.lblCVV.Parent = Me.PictureBox4
    End Sub

    Private Sub txtCardOwner_Click(sender As Object, e As EventArgs) Handles txtCardOwner.Click
        lblCardNumber.Text = txtCardNumber.Text
    End Sub

    Private Sub txtExpirationDate_Click(sender As Object, e As EventArgs) Handles txtExpirationDate.Click
        lblCVV.Text = txtCVV.Text
    End Sub

    Private Sub txtCVV_Click(sender As Object, e As EventArgs) Handles txtCVV.Click
        lblExpirationDate.Text = txtExpirationDate.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lblCVV.Text = txtCVV.Text
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim mycmd As New OleDbCommand("Insert into [Omc]([Card Number], [Card Owner], [Expiration Date], [CVV]) values ('" & txtCardNumber.Text & "', '" & txtCardOwner.Text & "', '" & txtExpirationDate.Text & "', '" & txtCVV.Text & "')", mycon)
        mycon.Open()
        Try
            mycmd.ExecuteNonQuery()
            txtCardNumber.Clear()
            txtCardOwner.Clear()
            txtExpirationDate.Clear()
            txtCVV.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mycon.Close()
        Dim responce As String
        responce = MsgBox("You Have SuccessFul Paid")

        If responce = MsgBoxResult.Ok Then
            Home.Show()
            Me.Hide()
        End If

        If PurchaseHistory.Item1.Image Is Nothing Then
            PurchaseHistory.Item1.Image = Cart.PictureBox1.Image
            PurchaseHistory.lblItemName1.Text = Cart.lblItemName1.Text
            PurchaseHistory.lblPrice1.Text = Cart.lblPrice1.Text
        ElseIf Not PurchaseHistory.Item1.Image Is Nothing And PurchaseHistory.Item2.Image Is Nothing Then
            PurchaseHistory.Item2.Image = Cart.PictureBox1.Image
            PurchaseHistory.lblItemName2.Text = Cart.lblItemName1.Text
            PurchaseHistory.lblPrice2.Text = Cart.lblPrice1.Text
        ElseIf Not PurchaseHistory.Item2.Image Is Nothing And PurchaseHistory.Item3.Image Is Nothing Then
            PurchaseHistory.Item3.Image = Cart.PictureBox1.Image
            PurchaseHistory.lblItemName3.Text = Cart.lblItemName1.Text
            PurchaseHistory.lblPrice3.Text = Cart.lblPrice1.Text
        ElseIf Not PurchaseHistory.Item3.Image Is Nothing And PurchaseHistory.Item4.Image Is Nothing Then
            PurchaseHistory.Item4.Image = Cart.PictureBox1.Image
            PurchaseHistory.lblItemName4.Text = Cart.lblItemName1.Text
            PurchaseHistory.lblPrice4.Text = Cart.lblPrice1.Text
        End If

        If PurchaseHistory.Item1.Image Is Nothing Then
            PurchaseHistory.Item1.Image = Cart.PictureBox2.Image
            PurchaseHistory.lblItemName1.Text = Cart.lblItemName2.Text
            PurchaseHistory.lblPrice1.Text = Cart.lblPrice2.Text
        ElseIf Not PurchaseHistory.Item1.Image Is Nothing And PurchaseHistory.Item2.Image Is Nothing Then
            PurchaseHistory.Item2.Image = Cart.PictureBox2.Image
            PurchaseHistory.lblItemName2.Text = Cart.lblItemName2.Text
            PurchaseHistory.lblPrice2.Text = Cart.lblPrice2.Text
        ElseIf Not PurchaseHistory.Item2.Image Is Nothing And PurchaseHistory.Item3.Image Is Nothing Then
            PurchaseHistory.Item3.Image = Cart.PictureBox2.Image
            PurchaseHistory.lblItemName3.Text = Cart.lblItemName2.Text
            PurchaseHistory.lblPrice3.Text = Cart.lblPrice2.Text
        ElseIf Not PurchaseHistory.Item3.Image Is Nothing And PurchaseHistory.Item4.Image Is Nothing Then
            PurchaseHistory.Item4.Image = Cart.PictureBox2.Image
            PurchaseHistory.lblItemName4.Text = Cart.lblItemName2.Text
            PurchaseHistory.lblPrice4.Text = Cart.lblPrice2.Text
        End If

        If PurchaseHistory.Item1.Image Is Nothing Then
            PurchaseHistory.Item1.Image = Cart.PictureBox3.Image
            PurchaseHistory.lblItemName1.Text = Cart.lblItemName3.Text
            PurchaseHistory.lblPrice1.Text = Cart.lblPrice3.Text
        ElseIf Not PurchaseHistory.Item1.Image Is Nothing And PurchaseHistory.Item2.Image Is Nothing Then
            PurchaseHistory.Item2.Image = Cart.PictureBox3.Image
            PurchaseHistory.lblItemName2.Text = Cart.lblItemName3.Text
            PurchaseHistory.lblPrice2.Text = Cart.lblPrice3.Text
        ElseIf Not PurchaseHistory.Item2.Image Is Nothing And PurchaseHistory.Item3.Image Is Nothing Then
            PurchaseHistory.Item3.Image = Cart.PictureBox3.Image
            PurchaseHistory.lblItemName3.Text = Cart.lblItemName3.Text
            PurchaseHistory.lblPrice3.Text = Cart.lblPrice3.Text
        ElseIf Not PurchaseHistory.Item3.Image Is Nothing And PurchaseHistory.Item4.Image Is Nothing Then
            PurchaseHistory.Item4.Image = Cart.PictureBox3.Image
            PurchaseHistory.lblItemName4.Text = Cart.lblItemName3.Text
            PurchaseHistory.lblPrice4.Text = Cart.lblPrice3.Text
        End If
    End Sub
End Class