<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Label1 = New Label()
        txtEmail1 = New TextBox()
        chkRemember = New CheckBox()
        btnSignIn1 = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        btnCreate1 = New Button()
        txtPassword1 = New TextBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        BindingSource1 = New BindingSource(components)
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("STHupo", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(45, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 17)
        Label1.TabIndex = 3
        Label1.Text = "Sign In"
        ' 
        ' txtEmail1
        ' 
        txtEmail1.BackColor = Color.White
        txtEmail1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtEmail1.Location = New Point(45, 262)
        txtEmail1.Name = "txtEmail1"
        txtEmail1.PlaceholderText = "Email"
        txtEmail1.Size = New Size(256, 26)
        txtEmail1.TabIndex = 6
        txtEmail1.TabStop = False
        ' 
        ' chkRemember
        ' 
        chkRemember.AutoSize = True
        chkRemember.BackColor = Color.Transparent
        chkRemember.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkRemember.Location = New Point(45, 350)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(128, 21)
        chkRemember.TabIndex = 8
        chkRemember.Text = "Show Password ?"
        chkRemember.UseVisualStyleBackColor = False
        ' 
        ' btnSignIn1
        ' 
        btnSignIn1.BackColor = SystemColors.ActiveCaptionText
        btnSignIn1.Font = New Font("STHupo", 12F)
        btnSignIn1.ForeColor = SystemColors.ButtonHighlight
        btnSignIn1.Location = New Point(45, 386)
        btnSignIn1.Name = "btnSignIn1"
        btnSignIn1.Size = New Size(256, 41)
        btnSignIn1.TabIndex = 9
        btnSignIn1.Text = "SIGN IN"
        btnSignIn1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(81, 433)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(184, 178)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(45, 621)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 15)
        Label2.TabIndex = 11
        Label2.Text = "Don't Have Account ?"
        ' 
        ' btnCreate1
        ' 
        btnCreate1.BackColor = Color.Transparent
        btnCreate1.Location = New Point(201, 617)
        btnCreate1.Name = "btnCreate1"
        btnCreate1.Size = New Size(100, 23)
        btnCreate1.TabIndex = 12
        btnCreate1.Text = "Create Account"
        btnCreate1.UseVisualStyleBackColor = False
        ' 
        ' txtPassword1
        ' 
        txtPassword1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtPassword1.Location = New Point(45, 305)
        txtPassword1.Name = "txtPassword1"
        txtPassword1.PlaceholderText = "Password"
        txtPassword1.Size = New Size(256, 26)
        txtPassword1.TabIndex = 13
        txtPassword1.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(342, -1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(txtPassword1)
        Controls.Add(btnCreate1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(btnSignIn1)
        Controls.Add(chkRemember)
        Controls.Add(txtEmail1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign In"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswordSignIN As RichTextBox
    Friend WithEvents txtEmail1 As TextBox
   
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents btnSignIn1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreate1 As Button
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
