<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReport
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
        DataGridView1 = New DataGridView()
        BtnGenerate = New Button()
        LblBookName = New Label()
        Lbl_Issue = New Label()
        LblDDate = New Label()
        BtnReturn = New Button()
        Label1 = New Label()
        txtID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(776, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnGenerate.Location = New Point(507, 206)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(243, 51)
        BtnGenerate.TabIndex = 1
        BtnGenerate.Text = "Generate Report"
        BtnGenerate.UseVisualStyleBackColor = True
        ' 
        ' LblBookName
        ' 
        LblBookName.AutoSize = True
        LblBookName.BackColor = Color.Transparent
        LblBookName.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        LblBookName.Location = New Point(26, 274)
        LblBookName.Name = "LblBookName"
        LblBookName.Size = New Size(136, 31)
        LblBookName.TabIndex = 2
        LblBookName.Text = "Book Name:"' 
        ' Lbl_Issue
        ' 
        Lbl_Issue.AutoSize = True
        Lbl_Issue.BackColor = Color.Transparent
        Lbl_Issue.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Issue.Location = New Point(26, 330)
        Lbl_Issue.Name = "Lbl_Issue"
        Lbl_Issue.Size = New Size(138, 31)
        Lbl_Issue.TabIndex = 3
        Lbl_Issue.Text = "Date Issued:"' 
        ' LblDDate
        ' 
        LblDDate.AutoSize = True
        LblDDate.BackColor = Color.Transparent
        LblDDate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        LblDDate.Location = New Point(26, 388)
        LblDDate.Name = "LblDDate"
        LblDDate.Size = New Size(114, 31)
        LblDDate.TabIndex = 4
        LblDDate.Text = "Due Date:"' 
        ' BtnReturn
        ' 
        BtnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnReturn.Location = New Point(654, 388)
        BtnReturn.Name = "BtnReturn"
        BtnReturn.Size = New Size(134, 50)
        BtnReturn.TabIndex = 5
        BtnReturn.Text = "Return"
        BtnReturn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(26, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 31)
        Label1.TabIndex = 6
        Label1.Text = "Enter Book ID:"' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtID.Location = New Point(188, 213)
        txtID.Name = "txtID"
        txtID.Size = New Size(277, 38)
        txtID.TabIndex = 7
        ' 
        ' BookReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient__1_
        ClientSize = New Size(800, 450)
        Controls.Add(txtID)
        Controls.Add(Label1)
        Controls.Add(BtnReturn)
        Controls.Add(LblDDate)
        Controls.Add(Lbl_Issue)
        Controls.Add(LblBookName)
        Controls.Add(BtnGenerate)
        Controls.Add(DataGridView1)
        Name = "BookReport"
        Text = "Book Report"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents LblBookName As Label
    Friend WithEvents Lbl_Issue As Label
    Friend WithEvents LblDDate As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
End Class
