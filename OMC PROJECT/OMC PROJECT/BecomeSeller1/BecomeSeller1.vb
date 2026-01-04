Imports System.ComponentModel.DataAnnotations
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class BecomeSeller1
    Private Sub BecomeSeller1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
            (Me.ClientRectangle, Color.DeepSkyBlue, Color.Yellow, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub BecomeSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPrevious.Visible = False
    End Sub

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Omc.accdb")

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim IC As Integer
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Please select the type of seller.")
        ElseIf txtSellerName.Text = "" Then
            MsgBox("Please enter the seller's name.")
        ElseIf txtICNumber.Text = "" Then
            IC = MsgBox("Please enter the seller's IC Number.")
        ElseIf txtICNumber.TextLength <> 12 Then
            IC = MsgBox("Please enter a valid ic.")
        Else
            save()
            BecomeSeller2.Show()
            Me.Hide()
        End If
    End Sub

    Sub save()
        Dim mycmd As New OleDbCommand("Insert into [Seller]([Full Name], [IC Number/Passport Number]) values ('" & txtSellerName.Text & "', '" & txtICNumber.Text & "')", mycon)
        mycon.Open()
        Try
            mycmd.ExecuteNonQuery()
            txtICNumber.Clear()
            txtSellerName.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class