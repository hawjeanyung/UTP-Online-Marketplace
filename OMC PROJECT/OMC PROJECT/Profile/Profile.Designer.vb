<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        btnBack = New PictureBox()
        PictureBox1 = New PictureBox()
        btnProfile2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPassword = New Label()
        btnResetPassword = New Button()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnProfile2, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 12
        btnBack.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(278, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnProfile2
        ' 
        btnProfile2.BackColor = Color.Transparent
        btnProfile2.Image = CType(resources.GetObject("btnProfile2.Image"), Image)
        btnProfile2.Location = New Point(102, 96)
        btnProfile2.Name = "btnProfile2"
        btnProfile2.Size = New Size(172, 177)
        btnProfile2.SizeMode = PictureBoxSizeMode.Zoom
        btnProfile2.TabIndex = 18
        btnProfile2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 302)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 25)
        Label1.TabIndex = 19
        Label1.Text = "NAME : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(45, 381)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 20
        Label2.Text = "EMAIL : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(45, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 25)
        Label3.TabIndex = 21
        Label3.Text = "PASSWORD : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblName.Location = New Point(134, 302)
        lblName.Name = "lblName"
        lblName.Size = New Size(0, 25)
        lblName.TabIndex = 23
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblEmail.Location = New Point(129, 381)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(0, 25)
        lblEmail.TabIndex = 24
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblPassword.Location = New Point(183, 459)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(0, 25)
        lblPassword.TabIndex = 25
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.Black
        btnResetPassword.Font = New Font("STHupo", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        btnResetPassword.ForeColor = SystemColors.Control
        btnResetPassword.Location = New Point(102, 537)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(172, 40)
        btnResetPassword.TabIndex = 26
        btnResetPassword.Text = "LOG OUT"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(btnResetPassword)
        Controls.Add(lblPassword)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnProfile2)
        Controls.Add(PictureBox1)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "Profile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnProfile2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProfile2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnResetPassword As Button
End Class
