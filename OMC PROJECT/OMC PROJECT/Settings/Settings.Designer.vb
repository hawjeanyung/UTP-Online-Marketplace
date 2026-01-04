<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        btnBack = New PictureBox()
        PictureBox7 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        CType(btnBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 12
        btnBack.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(286, 12)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(50, 52)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 13
        PictureBox7.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(79, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 43)
        Label1.TabIndex = 14
        Label1.Text = "SETTINGS"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("STHupo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Button1.Location = New Point(30, 98)
        Button1.Name = "Button1"
        Button1.Size = New Size(306, 73)
        Button1.TabIndex = 15
        Button1.Text = "CHANGE EMAIL / USERNAME"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("STHupo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Button3.Location = New Point(30, 177)
        Button3.Name = "Button3"
        Button3.Size = New Size(306, 73)
        Button3.TabIndex = 17
        Button3.Text = "LANGUAGE" & vbCrLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(43, 512)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(315, 222)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox7)
        Controls.Add(btnBack)
        FormBorderStyle = FormBorderStyle.None
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
