Imports MySql.Data.MySqlClient

Public Class Tipe
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub Tipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql()
        Dim cmd As New MySqlCommand("SELECT * FROM types", conn)
        Dim reader As MySqlDataReader

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("name", "Nama Kendaraan")
        DataGridView1.Columns.Add("price", "Biaya Parkir")

        reader = cmd.ExecuteReader()

        While reader.Read()
            DataGridView1.Rows.Add(reader("name"), reader("price"))
        End While

        reader.Close()
        conn.Close()
    End Sub
End Class