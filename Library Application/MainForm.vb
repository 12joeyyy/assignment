Imports System.Globalization
Public Class MainForm
    Private Sub MainForm_Load() Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Sub btnExit_Click() Handles Exit_Btn.Click
        If MessageBox.Show("Are you sure you want to exit the program?", "Exit Program?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Sub Timer1_Tick() Handles Timer1.Tick
        Label7.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Sub PictureBox1_Click() Handles PictureBox1.Click
        AddBooks.Show()
        Me.Hide()
    End Sub

    Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        BookReport.Show()
        Me.Hide()
    End Sub

    Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SearchBook.Show()
        Me.Hide()
    End Sub
End Class