Public Class Form1
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
End Class
