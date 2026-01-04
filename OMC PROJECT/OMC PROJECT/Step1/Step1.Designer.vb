<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step1))
        btnBack = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtName = New TextBox()
        Label4 = New Label()
        txtPhoneNumber = New TextBox()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtCity = New TextBox()
        txtCountry = New TextBox()
        Label8 = New Label()
        cbxShipping = New ComboBox()
        CheckBox1 = New CheckBox()
        btnProceed = New Button()
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
        btnBack.TabIndex = 9
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
        Label1.TabIndex = 10
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
        Label2.TabIndex = 11
        Label2.Text = "Step 1 of 2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("STHupo", 12F)
        Label3.Location = New Point(24, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 17)
        Label3.TabIndex = 13
        Label3.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtName.Location = New Point(24, 168)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Anna Katrina Marchesi"
        txtName.Size = New Size(318, 44)
        txtName.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("STHupo", 12F)
        Label4.Location = New Point(24, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 17)
        Label4.TabIndex = 15
        Label4.Text = "Phone Number"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtPhoneNumber.Location = New Point(24, 249)
        txtPhoneNumber.MaxLength = 11
        txtPhoneNumber.Multiline = True
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.PlaceholderText = "+123-456-7890"
        txtPhoneNumber.Size = New Size(318, 44)
        txtPhoneNumber.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("STHupo", 12F)
        Label5.Location = New Point(24, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 17)
        Label5.TabIndex = 17
        Label5.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtAddress.Location = New Point(24, 330)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "123 Anywhere St., Any City, ST 12345"
        txtAddress.Size = New Size(318, 44)
        txtAddress.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("STHupo", 12F)
        Label6.Location = New Point(24, 394)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 17)
        Label6.TabIndex = 19
        Label6.Text = "City"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("STHupo", 12F)
        Label7.Location = New Point(198, 394)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 17)
        Label7.TabIndex = 20
        Label7.Text = "Country"
        ' 
        ' txtCity
        ' 
        txtCity.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtCity.Location = New Point(24, 414)
        txtCity.Multiline = True
        txtCity.Name = "txtCity"
        txtCity.PlaceholderText = "Any City"
        txtCity.Size = New Size(138, 44)
        txtCity.TabIndex = 21
        ' 
        ' txtCountry
        ' 
        txtCountry.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtCountry.Location = New Point(198, 414)
        txtCountry.Multiline = True
        txtCountry.Name = "txtCountry"
        txtCountry.PlaceholderText = "Any Country"
        txtCountry.Size = New Size(144, 44)
        txtCountry.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("STHupo", 12F)
        Label8.Location = New Point(24, 479)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 17)
        Label8.TabIndex = 23
        Label8.Text = "Shipping"
        ' 
        ' cbxShipping
        ' 
        cbxShipping.FormattingEnabled = True
        cbxShipping.Items.AddRange(New Object() {"Premium Shipping - RM15", "Standard Shipping = RM10", "Budget Shipping = RM 6"})
        cbxShipping.Location = New Point(24, 499)
        cbxShipping.Name = "cbxShipping"
        cbxShipping.Size = New Size(318, 23)
        cbxShipping.TabIndex = 24
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Location = New Point(24, 528)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(149, 19)
        CheckBox1.TabIndex = 25
        CheckBox1.Text = "Remember My Settings"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' btnProceed
        ' 
        btnProceed.BackColor = Color.Black
        btnProceed.Font = New Font("STCaiyun", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        btnProceed.ForeColor = SystemColors.Control
        btnProceed.Location = New Point(24, 590)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(318, 39)
        btnProceed.TabIndex = 43
        btnProceed.Text = "Proceed To Payment"
        btnProceed.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(278, 82)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 44
        PictureBox2.TabStop = False
        ' 
        ' Step1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox2)
        Controls.Add(btnProceed)
        Controls.Add(CheckBox1)
        Controls.Add(cbxShipping)
        Controls.Add(Label8)
        Controls.Add(txtCountry)
        Controls.Add(txtCity)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtAddress)
        Controls.Add(Label5)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label4)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "Step1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Step1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxShipping As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnProceed As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
