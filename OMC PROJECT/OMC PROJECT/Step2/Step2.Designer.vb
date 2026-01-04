<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step2))
        btnBack = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        txtCardNumber = New TextBox()
        PictureBox4 = New PictureBox()
        CheckBox1 = New CheckBox()
        lblCardNumber = New Label()
        lblExpirationDate = New Label()
        lblCVV = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtCardOwner = New TextBox()
        txtExpirationDate = New TextBox()
        txtCVV = New TextBox()
        Label6 = New Label()
        btnProceed = New Button()
        PictureBox5 = New PictureBox()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 10
        btnBack.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STCaiyun", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(110, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 24)
        Label1.TabIndex = 11
        Label1.Text = "Shipping Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("STHupo", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(278, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 13)
        Label2.TabIndex = 12
        Label2.Text = "Step 2 of 2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 47
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(278, 82)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 48
        PictureBox2.TabStop = False
        ' 
        ' txtCardNumber
        ' 
        txtCardNumber.Location = New Point(24, 398)
        txtCardNumber.MaxLength = 19
        txtCardNumber.Name = "txtCardNumber"
        txtCardNumber.PlaceholderText = "xxxx xxxx xxxx xxxx"
        txtCardNumber.Size = New Size(318, 23)
        txtCardNumber.TabIndex = 51
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(24, 146)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(318, 212)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 52
        PictureBox4.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Location = New Point(24, 550)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(92, 19)
        CheckBox1.TabIndex = 53
        CheckBox1.Text = "Remember ?"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' lblCardNumber
        ' 
        lblCardNumber.AutoSize = True
        lblCardNumber.BackColor = Color.Transparent
        lblCardNumber.ForeColor = SystemColors.Control
        lblCardNumber.Location = New Point(142, 221)
        lblCardNumber.Name = "lblCardNumber"
        lblCardNumber.Size = New Size(112, 15)
        lblCardNumber.TabIndex = 54
        lblCardNumber.Text = "xxxx xxxx xxxx xxxx"
        ' 
        ' lblExpirationDate
        ' 
        lblExpirationDate.AutoSize = True
        lblExpirationDate.BackColor = Color.Transparent
        lblExpirationDate.ForeColor = SystemColors.Control
        lblExpirationDate.Location = New Point(91, 261)
        lblExpirationDate.Name = "lblExpirationDate"
        lblExpirationDate.Size = New Size(52, 15)
        lblExpirationDate.TabIndex = 55
        lblExpirationDate.Text = "mm / yy"
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.BackColor = Color.Transparent
        lblCVV.ForeColor = SystemColors.Control
        lblCVV.Location = New Point(174, 261)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(25, 15)
        lblCVV.TabIndex = 56
        lblCVV.Text = "cvv"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(24, 380)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 57
        Label3.Text = "CARD NUMBER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(24, 493)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 58
        Label4.Text = "EXPIRATION DATE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(24, 436)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 59
        Label5.Text = "CARD OWNER"
        ' 
        ' txtCardOwner
        ' 
        txtCardOwner.Location = New Point(24, 454)
        txtCardOwner.Name = "txtCardOwner"
        txtCardOwner.PlaceholderText = "Justin Ong Eu Wei"
        txtCardOwner.Size = New Size(318, 23)
        txtCardOwner.TabIndex = 60
        ' 
        ' txtExpirationDate
        ' 
        txtExpirationDate.Location = New Point(24, 511)
        txtExpirationDate.MaxLength = 7
        txtExpirationDate.Name = "txtExpirationDate"
        txtExpirationDate.PlaceholderText = "mm / yy"
        txtExpirationDate.Size = New Size(131, 23)
        txtExpirationDate.TabIndex = 61
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(204, 511)
        txtCVV.MaxLength = 3
        txtCVV.Name = "txtCVV"
        txtCVV.PlaceholderText = "xxx"
        txtCVV.Size = New Size(138, 23)
        txtCVV.TabIndex = 62
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(204, 493)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 15)
        Label6.TabIndex = 63
        Label6.Text = "CVV"
        ' 
        ' btnProceed
        ' 
        btnProceed.BackColor = Color.Black
        btnProceed.Font = New Font("STCaiyun", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        btnProceed.ForeColor = SystemColors.Control
        btnProceed.Location = New Point(24, 593)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(318, 39)
        btnProceed.TabIndex = 64
        btnProceed.Text = "CHECKOUT"
        btnProceed.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(235, 261)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(57, 39)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 65
        PictureBox5.TabStop = False
        ' 
        ' Step2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox5)
        Controls.Add(btnProceed)
        Controls.Add(Label6)
        Controls.Add(txtCVV)
        Controls.Add(txtExpirationDate)
        Controls.Add(txtCardOwner)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblCVV)
        Controls.Add(lblExpirationDate)
        Controls.Add(lblCardNumber)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox4)
        Controls.Add(txtCardNumber)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "Step2"
        StartPosition = FormStartPosition.CenterScreen
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCardOwner As TextBox
    Friend WithEvents txtExpirationDate As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
