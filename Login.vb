Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLGN_Click(sender As Object, e As EventArgs) Handles btnLGN.Click
        sql()
        Dim cmd As New MySqlCommand("SELECT username, password, role_id FROM users WHERE username = @usn AND password = @pw", conn)
        cmd.Parameters.AddWithValue("@usn", tbUSN.Text)
        cmd.Parameters.AddWithValue("@pw", tbPW.Text)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.read() Then
            Dim role_id As Integer = Convert.ToInt32(reader("role_id"))

            Dim dashboard As New Dashboard(role_id)
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!!", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        reader.Close()
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
