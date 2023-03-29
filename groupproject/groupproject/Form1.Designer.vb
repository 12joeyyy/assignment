<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.cmbbox2 = New System.Windows.Forms.ComboBox()
        Me.cmbbox1 = New System.Windows.Forms.ComboBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.cmbbox2)
        Me.GroupBox1.Controls.Add(Me.cmbbox1)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search here"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn1.Location = New System.Drawing.Point(601, 52)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(124, 28)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "Search"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'cmbbox2
        '
        Me.cmbbox2.FormattingEnabled = True
        Me.cmbbox2.Location = New System.Drawing.Point(410, 52)
        Me.cmbbox2.Name = "cmbbox2"
        Me.cmbbox2.Size = New System.Drawing.Size(151, 28)
        Me.cmbbox2.TabIndex = 3
        '
        'cmbbox1
        '
        Me.cmbbox1.FormattingEnabled = True
        Me.cmbbox1.Location = New System.Drawing.Point(132, 52)
        Me.cmbbox1.Name = "cmbbox1"
        Me.cmbbox1.Size = New System.Drawing.Size(151, 28)
        Me.cmbbox1.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl2.Location = New System.Drawing.Point(323, 52)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(81, 28)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Book ID"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.Location = New System.Drawing.Point(30, 52)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(96, 28)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Search By"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(26, 171)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(743, 250)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn1 As Button
    Friend WithEvents cmbbox2 As ComboBox
    Friend WithEvents cmbbox1 As ComboBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents ListView1 As ListView
End Class
