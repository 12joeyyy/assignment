Public Class SearchBook
    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobox1()
    End Sub
    Sub combobox1()
        With cmbbox1
            .Items.Add("Author")
            .Items.Add("Book Name")
            .Items.Add("Publisher")
            .Items.Add("Status")
        End With
    End Sub

    Sub combobox2()
        With cmbbox2
            .Items.Add("")
        End With
    End Sub

    Sub Btn_Return_Click() Handles Btn_Return.Click
        If MessageBox.Show("Are you sure you want to return?", "Return?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub
End Class
