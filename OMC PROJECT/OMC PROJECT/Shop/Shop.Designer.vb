<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shop))
        btnBack = New PictureBox()
        PictureBox1 = New PictureBox()
        btnSignIn2 = New Button()
        btnCategory1 = New PictureBox()
        btnSearch1 = New PictureBox()
        btnNotification1 = New PictureBox()
        btnProfile1 = New PictureBox()
        btnHome1 = New PictureBox()
        lblShopName = New Label()
        lblPrice2 = New Label()
        lblItemName2 = New Label()
        lblPrice1 = New Label()
        lblItemName1 = New Label()
        Item2 = New PictureBox()
        Item1 = New PictureBox()
        lblPrice3 = New Label()
        lblItemName3 = New Label()
        Item3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        pbxProduct = New PictureBox()
        Button1 = New Button()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCategory1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnSearch1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnNotification1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnProfile1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnHome1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Item2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Item1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Item3, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 16
        btnBack.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(286, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' btnSignIn2
        ' 
        btnSignIn2.BackColor = SystemColors.ActiveCaptionText
        btnSignIn2.Font = New Font("STHupo", 12F)
        btnSignIn2.ForeColor = SystemColors.ButtonHighlight
        btnSignIn2.Location = New Point(192, 533)
        btnSignIn2.Name = "btnSignIn2"
        btnSignIn2.Size = New Size(144, 41)
        btnSignIn2.TabIndex = 18
        btnSignIn2.Text = "ADD PRODUCT"
        btnSignIn2.UseVisualStyleBackColor = False
        ' 
        ' btnCategory1
        ' 
        btnCategory1.BackColor = Color.Transparent
        btnCategory1.Cursor = Cursors.Hand
        btnCategory1.Image = CType(resources.GetObject("btnCategory1.Image"), Image)
        btnCategory1.Location = New Point(94, 591)
        btnCategory1.Name = "btnCategory1"
        btnCategory1.Size = New Size(56, 58)
        btnCategory1.SizeMode = PictureBoxSizeMode.Zoom
        btnCategory1.TabIndex = 23
        btnCategory1.TabStop = False
        ' 
        ' btnSearch1
        ' 
        btnSearch1.BackColor = Color.Transparent
        btnSearch1.Cursor = Cursors.Hand
        btnSearch1.Image = CType(resources.GetObject("btnSearch1.Image"), Image)
        btnSearch1.Location = New Point(156, 591)
        btnSearch1.Name = "btnSearch1"
        btnSearch1.Size = New Size(56, 58)
        btnSearch1.SizeMode = PictureBoxSizeMode.Zoom
        btnSearch1.TabIndex = 22
        btnSearch1.TabStop = False
        ' 
        ' btnNotification1
        ' 
        btnNotification1.BackColor = Color.Transparent
        btnNotification1.Cursor = Cursors.Hand
        btnNotification1.Image = CType(resources.GetObject("btnNotification1.Image"), Image)
        btnNotification1.Location = New Point(218, 591)
        btnNotification1.Name = "btnNotification1"
        btnNotification1.Size = New Size(56, 58)
        btnNotification1.SizeMode = PictureBoxSizeMode.Zoom
        btnNotification1.TabIndex = 21
        btnNotification1.TabStop = False
        ' 
        ' btnProfile1
        ' 
        btnProfile1.BackColor = Color.Transparent
        btnProfile1.Cursor = Cursors.Hand
        btnProfile1.Image = CType(resources.GetObject("btnProfile1.Image"), Image)
        btnProfile1.Location = New Point(280, 591)
        btnProfile1.Name = "btnProfile1"
        btnProfile1.Size = New Size(56, 58)
        btnProfile1.SizeMode = PictureBoxSizeMode.Zoom
        btnProfile1.TabIndex = 20
        btnProfile1.TabStop = False
        ' 
        ' btnHome1
        ' 
        btnHome1.BackColor = Color.Transparent
        btnHome1.Image = CType(resources.GetObject("btnHome1.Image"), Image)
        btnHome1.Location = New Point(32, 591)
        btnHome1.Name = "btnHome1"
        btnHome1.Size = New Size(56, 58)
        btnHome1.SizeMode = PictureBoxSizeMode.Zoom
        btnHome1.TabIndex = 19
        btnHome1.TabStop = False
        ' 
        ' lblShopName
        ' 
        lblShopName.AutoSize = True
        lblShopName.BackColor = Color.Transparent
        lblShopName.Font = New Font("STHupo", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        lblShopName.Location = New Point(156, 105)
        lblShopName.Name = "lblShopName"
        lblShopName.Size = New Size(0, 28)
        lblShopName.TabIndex = 24
        ' 
        ' lblPrice2
        ' 
        lblPrice2.AutoSize = True
        lblPrice2.BackColor = Color.Transparent
        lblPrice2.Font = New Font("STHupo", 9.75F)
        lblPrice2.Location = New Point(130, 359)
        lblPrice2.Name = "lblPrice2"
        lblPrice2.Size = New Size(0, 13)
        lblPrice2.TabIndex = 48
        ' 
        ' lblItemName2
        ' 
        lblItemName2.AutoSize = True
        lblItemName2.BackColor = Color.Transparent
        lblItemName2.Font = New Font("STHupo", 9.75F)
        lblItemName2.Location = New Point(130, 332)
        lblItemName2.Name = "lblItemName2"
        lblItemName2.Size = New Size(0, 13)
        lblItemName2.TabIndex = 47
        ' 
        ' lblPrice1
        ' 
        lblPrice1.AutoSize = True
        lblPrice1.BackColor = Color.Transparent
        lblPrice1.Font = New Font("STHupo", 9.75F)
        lblPrice1.Location = New Point(130, 252)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(0, 13)
        lblPrice1.TabIndex = 46
        ' 
        ' lblItemName1
        ' 
        lblItemName1.AutoSize = True
        lblItemName1.BackColor = Color.Transparent
        lblItemName1.Font = New Font("STHupo", 9.75F)
        lblItemName1.Location = New Point(130, 228)
        lblItemName1.Name = "lblItemName1"
        lblItemName1.Size = New Size(0, 13)
        lblItemName1.TabIndex = 45
        ' 
        ' Item2
        ' 
        Item2.BackColor = Color.Transparent
        Item2.Location = New Point(32, 312)
        Item2.Name = "Item2"
        Item2.Size = New Size(87, 102)
        Item2.SizeMode = PictureBoxSizeMode.CenterImage
        Item2.TabIndex = 44
        Item2.TabStop = False
        ' 
        ' Item1
        ' 
        Item1.BackColor = Color.Transparent
        Item1.Location = New Point(32, 204)
        Item1.Name = "Item1"
        Item1.Size = New Size(87, 102)
        Item1.SizeMode = PictureBoxSizeMode.CenterImage
        Item1.TabIndex = 43
        Item1.TabStop = False
        ' 
        ' lblPrice3
        ' 
        lblPrice3.AutoSize = True
        lblPrice3.BackColor = Color.Transparent
        lblPrice3.Font = New Font("STHupo", 9.75F)
        lblPrice3.Location = New Point(130, 469)
        lblPrice3.Name = "lblPrice3"
        lblPrice3.Size = New Size(0, 13)
        lblPrice3.TabIndex = 51
        ' 
        ' lblItemName3
        ' 
        lblItemName3.AutoSize = True
        lblItemName3.BackColor = Color.Transparent
        lblItemName3.Font = New Font("STHupo", 9.75F)
        lblItemName3.Location = New Point(130, 436)
        lblItemName3.Name = "lblItemName3"
        lblItemName3.Size = New Size(0, 13)
        lblItemName3.TabIndex = 50
        ' 
        ' Item3
        ' 
        Item3.BackColor = Color.Transparent
        Item3.Location = New Point(32, 420)
        Item3.Name = "Item3"
        Item3.Size = New Size(87, 102)
        Item3.SizeMode = PictureBoxSizeMode.CenterImage
        Item3.TabIndex = 49
        Item3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STHupo", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(143, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 17)
        Label1.TabIndex = 52
        Label1.Text = "Products"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(108, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 36)
        Label2.TabIndex = 54
        Label2.Text = "My Shop"
        ' 
        ' pbxProduct
        ' 
        pbxProduct.BackColor = Color.Transparent
        pbxProduct.Image = CType(resources.GetObject("pbxProduct.Image"), Image)
        pbxProduct.Location = New Point(42, 67)
        pbxProduct.Name = "pbxProduct"
        pbxProduct.Size = New Size(108, 109)
        pbxProduct.SizeMode = PictureBoxSizeMode.CenterImage
        pbxProduct.TabIndex = 55
        pbxProduct.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Font = New Font("STHupo", 12F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(32, 533)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 41)
        Button1.TabIndex = 56
        Button1.Text = "Become A Seller"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Shop
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(Button1)
        Controls.Add(pbxProduct)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblPrice3)
        Controls.Add(lblItemName3)
        Controls.Add(Item3)
        Controls.Add(lblPrice2)
        Controls.Add(lblItemName2)
        Controls.Add(lblPrice1)
        Controls.Add(lblItemName1)
        Controls.Add(Item2)
        Controls.Add(Item1)
        Controls.Add(lblShopName)
        Controls.Add(btnCategory1)
        Controls.Add(btnSearch1)
        Controls.Add(btnNotification1)
        Controls.Add(btnProfile1)
        Controls.Add(btnHome1)
        Controls.Add(btnSignIn2)
        Controls.Add(PictureBox1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "Shop"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCategory1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnSearch1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnNotification1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnProfile1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnHome1, ComponentModel.ISupportInitialize).EndInit()
        CType(Item2, ComponentModel.ISupportInitialize).EndInit()
        CType(Item1, ComponentModel.ISupportInitialize).EndInit()
        CType(Item3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignIn2 As Button
    Friend WithEvents btnCategory1 As PictureBox
    Friend WithEvents btnSearch1 As PictureBox
    Friend WithEvents btnNotification1 As PictureBox
    Friend WithEvents btnProfile1 As PictureBox
    Friend WithEvents btnHome1 As PictureBox
    Friend WithEvents lblShopName As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblItemName2 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblItemName1 As Label
    Friend WithEvents Item2 As PictureBox
    Friend WithEvents Item1 As PictureBox
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblItemName3 As Label
    Friend WithEvents Item3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxProduct As PictureBox
    Friend WithEvents Button1 As Button
End Class
