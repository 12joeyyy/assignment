Imports System.Data.SQLite
Public Class AddBooks
    Dim cs As String = "Data Source=C:\Users\hkind\Documents\Library.db;Version=3;"
    Dim conn As New SQLiteConnection(cs)
    Dim cmd As New SQLiteCommand(conn)
    Dim reader As SQLiteDataReader
    Private Sub AddBooks_Load() Handles MyBase.Load
        conn.Open()
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("ID", 80)
        ListView1.Columns.Add("Name", 130)
        ListView1.Columns.Add("Author", 130)
        ListView1.Columns.Add("Publisher", 130)
        ListView1.Columns.Add("Publishing Date", 200)
        ListView1.Columns.Add("ISBN", 80)
        cmd.CommandText = "SELECT * FROM book"
        reader = cmd.ExecuteReader
        While reader.Read
            Dim array As String() = New String(6) {}
            Dim itenary As ListViewItem
            array(0) = (reader.GetInt32(0))
            array(1) = (reader.GetString(1))
            array(2) = (reader.GetString(2))
            array(3) = (reader.GetString(3))
            array(4) = (reader.GetString(4))
            array(5) = (reader.GetString(5))
            itenary = New ListViewItem(array)
            ListView1.Items.Add(itenary)
        End While
        reader.Close()
        conn.Close()
    End Sub

    'Sub to Add Books into database
    Sub Button_Add() Handles Btn_Add.Click
        conn.Open()
        cmd.CommandText = "INSERT INTO book (id, name, author, publisher, pub_date, isbn) VALUES (@id, @name, @author, @publisher, @pub_date, @isbn);"
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
        cmd.Parameters.AddWithValue("@publisher", txtPub.Text)
        cmd.Parameters.AddWithValue("@pub_date", DTP_PubD.Text)
        cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        lblExe.Text = "Book Added!"

    End Sub

    'Sub to update an item within database
    Sub Update_List() Handles Btn_Update.Click
        conn.Open()
        cmd.CommandText = "UPDATE book SET name=@name, author=@author, publisher=@publisher, pub_date=@pub_date WHERE id=@id"
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
        cmd.Parameters.AddWithValue("@publisher", txtPub.Text)
        cmd.Parameters.AddWithValue("@pub_date", DTP_PubD.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        lblExe.Text = "Book Updated!"
    End Sub

    'Sub to delete an item within database
    Sub Delete_Item() Handles Btn_Del.Click
        If MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            conn.Open()
            cmd.CommandText = "DELETE FROM book where id=@id"
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            lblExe.Text = "Book Deleted"

        End If
    End Sub

    'Sub to return to MainForm
    Sub Return_Main() Handles BtnReturn.Click
        If MessageBox.Show("Are you sure you want to return?", "Return?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub
End Class