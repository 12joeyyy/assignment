<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBooks
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
        ListView1 = New ListView()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        txtISBN = New TextBox()
        lblExe = New Label()
        DTP_PubD = New DateTimePicker()
        Btn_Del = New Button()
        Btn_Update = New Button()
        Btn_Add = New Button()
        Label4 = New Label()
        txtPub = New TextBox()
        Label5 = New Label()
        txtAuthor = New TextBox()
        Label3 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        txtID = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        BtnReturn = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(11, 264)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1102, 151)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtISBN)
        GroupBox1.Controls.Add(lblExe)
        GroupBox1.Controls.Add(DTP_PubD)
        GroupBox1.Controls.Add(Btn_Del)
        GroupBox1.Controls.Add(Btn_Update)
        GroupBox1.Controls.Add(Btn_Add)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtPub)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtAuthor)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(11, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1102, 193)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Book Details"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(926, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 23)
        Label7.TabIndex = 16
        Label7.Text = "ISBN"' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(926, 63)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(154, 30)
        txtISBN.TabIndex = 15
        ' 
        ' lblExe
        ' 
        lblExe.AutoSize = True
        lblExe.Location = New Point(926, 147)
        lblExe.Name = "lblExe"
        lblExe.Size = New Size(0, 23)
        lblExe.TabIndex = 14
        ' 
        ' DTP_PubD
        ' 
        DTP_PubD.Location = New Point(673, 63)
        DTP_PubD.Name = "DTP_PubD"
        DTP_PubD.Size = New Size(220, 30)
        DTP_PubD.TabIndex = 13
        ' 
        ' Btn_Del
        ' 
        Btn_Del.Location = New Point(673, 133)
        Btn_Del.Name = "Btn_Del"
        Btn_Del.Size = New Size(94, 37)
        Btn_Del.TabIndex = 12
        Btn_Del.Text = "Delete"
        Btn_Del.UseVisualStyleBackColor = True
        ' 
        ' Btn_Update
        ' 
        Btn_Update.Location = New Point(542, 133)
        Btn_Update.Name = "Btn_Update"
        Btn_Update.Size = New Size(94, 37)
        Btn_Update.TabIndex = 11
        Btn_Update.Text = "Update"
        Btn_Update.UseVisualStyleBackColor = True
        ' 
        ' Btn_Add
        ' 
        Btn_Add.Location = New Point(417, 133)
        Btn_Add.Name = "Btn_Add"
        Btn_Add.Size = New Size(94, 37)
        Btn_Add.TabIndex = 10
        Btn_Add.Text = "Add"
        Btn_Add.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(517, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 23)
        Label4.TabIndex = 8
        Label4.Text = "Publisher"' 
        ' txtPub
        ' 
        txtPub.Location = New Point(517, 63)
        txtPub.Name = "txtPub"
        txtPub.Size = New Size(125, 30)
        txtPub.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(673, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 23)
        Label5.TabIndex = 6
        Label5.Text = "Publishing Date"' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(351, 63)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(125, 30)
        txtAuthor.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(351, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 23)
        Label3.TabIndex = 4
        Label3.Text = "Author"' 
        ' txtName
        ' 
        txtName.Location = New Point(194, 63)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 30)
        txtName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 2
        Label2.Text = "Book Name"' 
        ' txtID
        ' 
        txtID.Location = New Point(27, 63)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 30)
        txtID.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 0
        Label1.Text = "Book ID"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(11, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 41)
        Label6.TabIndex = 2
        Label6.Text = "BOOK LIST"' 
        ' BtnReturn
        ' 
        BtnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnReturn.Location = New Point(1000, 421)
        BtnReturn.Name = "BtnReturn"
        BtnReturn.Size = New Size(114, 47)
        BtnReturn.TabIndex = 14
        BtnReturn.Text = "Return"
        BtnReturn.UseVisualStyleBackColor = True
        ' 
        ' AddBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient__1_
        ClientSize = New Size(1126, 480)
        Controls.Add(BtnReturn)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Controls.Add(ListView1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "AddBooks"
        Text = "Add, Edit or Delete Books"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP_PubD As DateTimePicker
    Friend WithEvents Btn_Del As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents lblExe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtISBN As TextBox
End Class
