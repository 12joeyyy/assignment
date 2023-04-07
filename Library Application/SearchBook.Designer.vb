<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchBook
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
        GroupBox1 = New GroupBox()
        btn1 = New Button()
        cmbbox2 = New ComboBox()
        cmbbox1 = New ComboBox()
        lbl2 = New Label()
        lbl1 = New Label()
        ListView1 = New ListView()
        Btn_Return = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(btn1)
        GroupBox1.Controls.Add(cmbbox2)
        GroupBox1.Controls.Add(cmbbox1)
        GroupBox1.Controls.Add(lbl2)
        GroupBox1.Controls.Add(lbl1)
        GroupBox1.Location = New Point(23, 32)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(650, 77)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search here"' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn1.Location = New Point(526, 31)
        btn1.Margin = New Padding(3, 2, 3, 2)
        btn1.Name = "btn1"
        btn1.Size = New Size(108, 34)
        btn1.TabIndex = 4
        btn1.Text = "Search"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' cmbbox2
        ' 
        cmbbox2.FormattingEnabled = True
        cmbbox2.Location = New Point(359, 39)
        cmbbox2.Margin = New Padding(3, 2, 3, 2)
        cmbbox2.Name = "cmbbox2"
        cmbbox2.Size = New Size(133, 23)
        cmbbox2.TabIndex = 3
        ' 
        ' cmbbox1
        ' 
        cmbbox1.FormattingEnabled = True
        cmbbox1.Location = New Point(116, 39)
        cmbbox1.Margin = New Padding(3, 2, 3, 2)
        cmbbox1.Name = "cmbbox1"
        cmbbox1.Size = New Size(133, 23)
        cmbbox1.TabIndex = 2
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl2.Location = New Point(283, 39)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(64, 21)
        lbl2.TabIndex = 1
        lbl2.Text = "Book ID"' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl1.Location = New Point(26, 39)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(78, 21)
        lbl1.TabIndex = 0
        lbl1.Text = "Search By"' 
        ' ListView1
        ' 
        ListView1.Location = New Point(23, 128)
        ListView1.Margin = New Padding(3, 2, 3, 2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(651, 166)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Btn_Return
        ' 
        Btn_Return.Location = New Point(598, 303)
        Btn_Return.Name = "Btn_Return"
        Btn_Return.Size = New Size(75, 23)
        Btn_Return.TabIndex = 2
        Btn_Return.Text = "Return"
        Btn_Return.UseVisualStyleBackColor = True
        ' 
        ' SearchBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient__1_
        ClientSize = New Size(700, 338)
        Controls.Add(Btn_Return)
        Controls.Add(ListView1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SearchBook"
        Text = "Search a Book"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn1 As Button
    Friend WithEvents cmbbox2 As ComboBox
    Friend WithEvents cmbbox1 As ComboBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Btn_Return As Button
End Class
