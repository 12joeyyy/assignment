<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Label1 = New Label()
        PBLoading = New ProgressBar()
        Timer1 = New Timer(components)
        lblPercent = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(121, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 46)
        Label1.TabIndex = 0
        Label1.Text = "Loading Binbows..."' 
        ' PBLoading
        ' 
        PBLoading.Location = New Point(9, 155)
        PBLoading.Margin = New Padding(3, 2, 3, 2)
        PBLoading.Name = "PBLoading"
        PBLoading.Size = New Size(475, 29)
        PBLoading.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.BackColor = Color.Transparent
        lblPercent.Location = New Point(445, 186)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(35, 15)
        lblPercent.TabIndex = 3
        lblPercent.Text = "000%"
        lblPercent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.PDZuPPl
        PictureBox1.Location = New Point(179, 40)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient__1_
        ClientSize = New Size(496, 207)
        Controls.Add(PictureBox1)
        Controls.Add(lblPercent)
        Controls.Add(PBLoading)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Loading"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PBLoading As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPercent As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
