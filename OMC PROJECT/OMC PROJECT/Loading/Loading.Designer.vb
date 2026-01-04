<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        PBLoading1 = New ProgressBar()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        lblReportProgress = New Label()
        lblStatusText = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PBLoading1
        ' 
        PBLoading1.Location = New Point(31, 330)
        PBLoading1.Name = "PBLoading1"
        PBLoading1.Size = New Size(306, 12)
        PBLoading1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(43, 512)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(315, 222)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 30
        ' 
        ' lblReportProgress
        ' 
        lblReportProgress.AutoSize = True
        lblReportProgress.BackColor = Color.Transparent
        lblReportProgress.Font = New Font("STHupo", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        lblReportProgress.Location = New Point(298, 345)
        lblReportProgress.Name = "lblReportProgress"
        lblReportProgress.Size = New Size(39, 13)
        lblReportProgress.TabIndex = 4
        lblReportProgress.Text = "000%"
        ' 
        ' lblStatusText
        ' 
        lblStatusText.AutoSize = True
        lblStatusText.BackColor = Color.Transparent
        lblStatusText.Font = New Font("STHupo", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        lblStatusText.Location = New Point(27, 346)
        lblStatusText.Name = "lblStatusText"
        lblStatusText.Size = New Size(153, 13)
        lblStatusText.TabIndex = 5
        lblStatusText.Text = "Launching the application.."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 700)
        Controls.Add(PictureBox1)
        Controls.Add(lblStatusText)
        Controls.Add(lblReportProgress)
        Controls.Add(PictureBox2)
        Controls.Add(PBLoading1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Loading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loading"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBLoading1 As ProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblReportProgress As Label
    Friend WithEvents lblStatusText As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
