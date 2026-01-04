<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadProduct))
        btnBack = New PictureBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        pbxProduct = New PictureBox()
        Label1 = New Label()
        txtProductName = New TextBox()
        Label2 = New Label()
        txtDescription = New TextBox()
        chkPreorder = New CheckBox()
        cbxCategories = New ComboBox()
        Label4 = New Label()
        txtPrice = New TextBox()
        btnUploadProduct = New Button()
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
        btnBack.TabIndex = 17
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
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(24, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 19)
        Label3.TabIndex = 22
        Label3.Text = "Product Media"
        ' 
        ' pbxProduct
        ' 
        pbxProduct.BackColor = Color.Transparent
        pbxProduct.Image = CType(resources.GetObject("pbxProduct.Image"), Image)
        pbxProduct.Location = New Point(24, 123)
        pbxProduct.Name = "pbxProduct"
        pbxProduct.Size = New Size(134, 140)
        pbxProduct.SizeMode = PictureBoxSizeMode.CenterImage
        pbxProduct.TabIndex = 23
        pbxProduct.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(24, 283)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 19)
        Label1.TabIndex = 24
        Label1.Text = "Product Name"
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtProductName.Location = New Point(24, 305)
        txtProductName.MaxLength = 30
        txtProductName.Multiline = True
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "UniSustain                                                  30"
        txtProductName.Size = New Size(312, 43)
        txtProductName.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(24, 454)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 19)
        Label2.TabIndex = 26
        Label2.Text = "Product Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtDescription.Location = New Point(24, 476)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "This product is ......"
        txtDescription.Size = New Size(312, 43)
        txtDescription.TabIndex = 27
        ' 
        ' chkPreorder
        ' 
        chkPreorder.AutoSize = True
        chkPreorder.BackColor = Color.Transparent
        chkPreorder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkPreorder.Location = New Point(24, 539)
        chkPreorder.Name = "chkPreorder"
        chkPreorder.Size = New Size(87, 21)
        chkPreorder.TabIndex = 28
        chkPreorder.Text = "Pre-Order"
        chkPreorder.UseVisualStyleBackColor = False
        ' 
        ' cbxCategories
        ' 
        cbxCategories.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        cbxCategories.FormattingEnabled = True
        cbxCategories.Items.AddRange(New Object() {"Kitchen Product", "Clothes And Acessories", "Sports", "Pets", "Outdoor And Travel"})
        cbxCategories.Location = New Point(215, 537)
        cbxCategories.Name = "cbxCategories"
        cbxCategories.Size = New Size(121, 25)
        cbxCategories.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label4.Location = New Point(24, 368)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 19)
        Label4.TabIndex = 30
        Label4.Text = "Price"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtPrice.Location = New Point(24, 390)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "50"
        txtPrice.Size = New Size(312, 43)
        txtPrice.TabIndex = 31
        ' 
        ' btnUploadProduct
        ' 
        btnUploadProduct.BackColor = SystemColors.ActiveCaptionText
        btnUploadProduct.Font = New Font("STHupo", 12F)
        btnUploadProduct.ForeColor = SystemColors.ButtonHighlight
        btnUploadProduct.Location = New Point(57, 610)
        btnUploadProduct.Name = "btnUploadProduct"
        btnUploadProduct.Size = New Size(256, 41)
        btnUploadProduct.TabIndex = 32
        btnUploadProduct.Text = "UPLOAD PRODUCT"
        btnUploadProduct.UseVisualStyleBackColor = False
        ' 
        ' UploadProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(btnUploadProduct)
        Controls.Add(txtPrice)
        Controls.Add(Label4)
        Controls.Add(cbxCategories)
        Controls.Add(chkPreorder)
        Controls.Add(txtDescription)
        Controls.Add(Label2)
        Controls.Add(txtProductName)
        Controls.Add(Label1)
        Controls.Add(pbxProduct)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "UploadProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pbxProduct As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents chkPreorder As CheckBox
    Friend WithEvents cbxCategories As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnUploadProduct As Button
End Class
