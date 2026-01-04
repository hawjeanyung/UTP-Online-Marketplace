<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BecomeSeller2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BecomeSeller2))
        btnBack = New PictureBox()
        Label3 = New Label()
        txtShopName = New TextBox()
        Label1 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtPhoneNumber = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        pbxProduct = New PictureBox()
        Label6 = New Label()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.Location = New Point(24, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(43, 49)
        btnBack.SizeMode = PictureBoxSizeMode.Zoom
        btnBack.TabIndex = 15
        btnBack.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(24, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 19)
        Label3.TabIndex = 21
        Label3.Text = "SHOP NAME"
        ' 
        ' txtShopName
        ' 
        txtShopName.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtShopName.Location = New Point(24, 294)
        txtShopName.Multiline = True
        txtShopName.Name = "txtShopName"
        txtShopName.PlaceholderText = "UniSustain"
        txtShopName.Size = New Size(312, 43)
        txtShopName.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(24, 365)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 23
        Label1.Text = "EMAIL"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtEmail.Location = New Point(24, 387)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "realfizzy@gmail.com"
        txtEmail.Size = New Size(312, 43)
        txtEmail.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(24, 450)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 19)
        Label2.TabIndex = 25
        Label2.Text = "PHONE NUMBER"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtPhoneNumber.Location = New Point(24, 472)
        txtPhoneNumber.MaxLength = 10
        txtPhoneNumber.Multiline = True
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.PlaceholderText = "0174162567"
        txtPhoneNumber.Size = New Size(312, 43)
        txtPhoneNumber.TabIndex = 26
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.ActiveCaptionText
        btnPrevious.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnPrevious.ForeColor = SystemColors.Control
        btnPrevious.Location = New Point(196, 540)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(140, 52)
        btnPrevious.TabIndex = 27
        btnPrevious.Text = "Back"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaptionText
        btnNext.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnNext.ForeColor = SystemColors.Control
        btnNext.Location = New Point(196, 624)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(140, 52)
        btnNext.TabIndex = 28
        btnNext.Text = "SUBMIT"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("STCaiyun", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label4.Location = New Point(144, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 24)
        Label4.TabIndex = 29
        Label4.Text = "Seller Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("STHupo", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label5.Location = New Point(278, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 13)
        Label5.TabIndex = 30
        Label5.Text = "Step 2 of 2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 524)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(155, 164)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' pbxProduct
        ' 
        pbxProduct.BackColor = Color.Transparent
        pbxProduct.Image = CType(resources.GetObject("pbxProduct.Image"), Image)
        pbxProduct.Location = New Point(24, 114)
        pbxProduct.Name = "pbxProduct"
        pbxProduct.Size = New Size(134, 140)
        pbxProduct.SizeMode = PictureBoxSizeMode.CenterImage
        pbxProduct.TabIndex = 32
        pbxProduct.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label6.Location = New Point(24, 92)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 19)
        Label6.TabIndex = 33
        Label6.Text = "UPLOAD LOGO"
        ' 
        ' BecomeSeller2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(Label6)
        Controls.Add(pbxProduct)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label2)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        Controls.Add(txtShopName)
        Controls.Add(Label3)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "BecomeSeller2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbxProduct As PictureBox
    Friend WithEvents Label6 As Label
End Class
