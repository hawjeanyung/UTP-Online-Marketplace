<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        txtFirstName2 = New TextBox()
        txtLastName2 = New TextBox()
        txtPassword2 = New TextBox()
        txtEmail2 = New TextBox()
        txtReenterPassword2 = New TextBox()
        btnSignIn2 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnBack = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName2
        ' 
        txtFirstName2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtFirstName2.Location = New Point(58, 225)
        txtFirstName2.Multiline = True
        txtFirstName2.Name = "txtFirstName2"
        txtFirstName2.PlaceholderText = "First Name"
        txtFirstName2.Size = New Size(256, 41)
        txtFirstName2.TabIndex = 7
        ' 
        ' txtLastName2
        ' 
        txtLastName2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtLastName2.Location = New Point(58, 284)
        txtLastName2.Multiline = True
        txtLastName2.Name = "txtLastName2"
        txtLastName2.PlaceholderText = "Last Name"
        txtLastName2.Size = New Size(256, 41)
        txtLastName2.TabIndex = 9
        ' 
        ' txtPassword2
        ' 
        txtPassword2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtPassword2.Location = New Point(58, 418)
        txtPassword2.Multiline = True
        txtPassword2.Name = "txtPassword2"
        txtPassword2.PlaceholderText = "Password"
        txtPassword2.Size = New Size(256, 41)
        txtPassword2.TabIndex = 10
        ' 
        ' txtEmail2
        ' 
        txtEmail2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtEmail2.Location = New Point(58, 352)
        txtEmail2.Multiline = True
        txtEmail2.Name = "txtEmail2"
        txtEmail2.PlaceholderText = "Email"
        txtEmail2.Size = New Size(256, 41)
        txtEmail2.TabIndex = 11
        ' 
        ' txtReenterPassword2
        ' 
        txtReenterPassword2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtReenterPassword2.Location = New Point(58, 485)
        txtReenterPassword2.Multiline = True
        txtReenterPassword2.Name = "txtReenterPassword2"
        txtReenterPassword2.PlaceholderText = "Re-enter Password"
        txtReenterPassword2.Size = New Size(256, 41)
        txtReenterPassword2.TabIndex = 12
        ' 
        ' btnSignIn2
        ' 
        btnSignIn2.BackColor = SystemColors.ActiveCaptionText
        btnSignIn2.Font = New Font("STHupo", 12F)
        btnSignIn2.ForeColor = SystemColors.ButtonHighlight
        btnSignIn2.Location = New Point(58, 577)
        btnSignIn2.Name = "btnSignIn2"
        btnSignIn2.Size = New Size(256, 41)
        btnSignIn2.TabIndex = 13
        btnSignIn2.Text = "SIGN IN"
        btnSignIn2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(342, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.Location = New Point(24, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(43, 49)
        btnBack.SizeMode = PictureBoxSizeMode.Zoom
        btnBack.TabIndex = 18
        btnBack.TabStop = False
        ' 
        ' CreateAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(370, 700)
        Controls.Add(btnBack)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnSignIn2)
        Controls.Add(txtReenterPassword2)
        Controls.Add(txtEmail2)
        Controls.Add(txtPassword2)
        Controls.Add(txtLastName2)
        Controls.Add(txtFirstName2)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName2 As TextBox
    Friend WithEvents txtLastName2 As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents txtReenterPassword2 As TextBox
    Friend WithEvents btnSignIn2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As PictureBox
End Class
