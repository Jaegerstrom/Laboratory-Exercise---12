Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Parameters
Public Class Form1

    Private conn As MySqlConnection
    Private COMMAND As MySqlCommand

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Dim mySqlConnection As MySqlConnection = New MySqlConnection()
        conn = mySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port=3307; userid=root; database=crud_demo_db;"

        Try
            conn.Open()
            MessageBox.Show("Connected!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim query As String = "INSERT INTO `crud_demo_db`.`students_tbl` (`name`, `age`, `email`) VALUES (@name, @age, @email);"
        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3307; userid=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextBoxAge.Text))
                    cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successful!")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM crud_demo_db.students_tbl;"
        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3307; userid=root; database=crud_demo_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBoxName.Text = selectedRow.Cells("name").Value.ToString()
            TextBoxAge.Text = selectedRow.Cells("age").Value.ToString()
            TextBoxEmail.Text = selectedRow.Cells("email").Value.ToString()

            TextBoxHiddenID.Text = selectedRow.Cells("id").Value.ToString()

        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim query As String = "UPDATE `crud_demo_db`.`students_tbl`
                                SET `name` = @name,
                                `age` = @age,
                                `email` = @email
                                WHERE (`id` = @id);"

        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3307; userid=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextBoxAge.Text))
                    cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successful!")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()
                    TextBoxHiddenID.Clear()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        'Dim query As String = "DELETE FROM `crud_demo_db`.`students_tbl` WHERE (`id` = '3');"
        Dim query As String = "UPDATE `crud_demo_db`.`students_tbl`
                                SET is_deleted = 1
                                WHERE (`id` = @id);"
        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3307; userid=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record removed successful!")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()
                    TextBoxHiddenID.Clear()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class