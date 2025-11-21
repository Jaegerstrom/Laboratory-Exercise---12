Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1

    Private conn As MySqlConnection
    Private COMMAND As MySqlCommand

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Dim mySqlConnection As MySqlConnection = New MySqlConnection()
        conn = mySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=crud_demo_db;"

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
    End Sub
End Class