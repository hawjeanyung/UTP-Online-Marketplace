<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BecomeSeller1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BecomeSeller1))
        btnBack = New PictureBox()
        Label1 = New Label()
        txtSellerName = New TextBox()
        Label2 = New Label()
        txtICNumber = New TextBox()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 14
        btnBack.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(24, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 19)
        Label1.TabIndex = 16
        Label1.Text = "SELLER NAME"
        ' 
        ' txtSellerName
        ' 
        txtSellerName.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtSellerName.Location = New Point(24, 327)
        txtSellerName.Multiline = True
        txtSellerName.Name = "txtSellerName"
        txtSellerName.PlaceholderText = "Mahesh Vigneswaren"
        txtSellerName.Size = New Size(312, 43)
        txtSellerName.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(24, 393)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 19)
        Label2.TabIndex = 18
        Label2.Text = "IC NUMBER / PASSPORT NUMBER"
        ' 
        ' txtICNumber
        ' 
        txtICNumber.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtICNumber.Location = New Point(24, 415)
        txtICNumber.MaxLength = 12
        txtICNumber.Multiline = True
        txtICNumber.Name = "txtICNumber"
        txtICNumber.Size = New Size(312, 43)
        txtICNumber.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(24, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 19)
        Label3.TabIndex = 20
        Label3.Text = "SELLER TYPE"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        CheckBox1.Location = New Point(42, 230)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(110, 23)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Individual"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        CheckBox2.Location = New Point(42, 268)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(188, 23)
        CheckBox2.TabIndex = 22
        CheckBox2.Text = "Registered Business"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.ActiveCaptionText
        btnPrevious.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnPrevious.ForeColor = SystemColors.Control
        btnPrevious.Location = New Point(196, 508)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(140, 52)
        btnPrevious.TabIndex = 23
        btnPrevious.Text = "Back"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaptionText
        btnNext.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnNext.ForeColor = SystemColors.Control
        btnNext.Location = New Point(196, 594)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(140, 52)
        btnNext.TabIndex = 24
        btnNext.Text = "Next"
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
        Label4.TabIndex = 25
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
        Label5.TabIndex = 26
        Label5.Text = "Step 1 of 2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(166, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(176, 176)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(24, 464)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 182)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 33
        PictureBox2.TabStop = False
        ' 
        ' BecomeSeller1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(txtICNumber)
        Controls.Add(Label2)
        Controls.Add(txtSellerName)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "BecomeSeller1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSellerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtICNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
