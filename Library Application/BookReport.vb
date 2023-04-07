Imports System.Data.SQLite

Public Class BookReport
    Dim cs As String = "Data Source=C:\Users\hkind\Documents\Library.db;Version=3;"
    Dim conn As New SQLiteConnection(cs)
    Dim cmd As New SQLiteCommand(conn)
    Dim reader As SQLiteDataReader
    Dim sql As String = "SELECT * FROM book"
    Dim ds As New DataSet()
    Private Sub BookReport_Load() Handles MyBase.Load
        conn.Open()
        Dim cmdView As New SQLiteCommand("Select * from book", conn)
        'cmd.Parameters.AddWithValue("q")
        Dim da As New SQLiteDataAdapter
        da.SelectCommand = cmdView
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Sub Generate_Report() Handles BtnGenerate.Click
        conn.Open()
        cmd.CommandText = "SELECT * FROM book WHERE id=@id"
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        reader = cmd.ExecuteReader
        While reader.Read
            LblBookName.Text = ("Book Name: " & reader.GetString(1))
            'Lbl_Issue.Text = ("Date Issued: " & reader.GetString(5))
            'LblDDate.Text = ("Due Date: " & reader.GetString(6))
        End While
        reader.Close()
        conn.Close()
    End Sub

    Sub btnReturn_Click() Handles BtnReturn.Click
        If MessageBox.Show("Are you sure you want to return?", "Return?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub
End Class