Imports MySql.Data.MySqlClient

Public Class Tipe
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub Tipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql()
        Dim cmd As New MySqlCommand("SELECT p.*, t.name, t.price FROM parkings p left join types t on t.id = p.type_id", conn)
        Dim reader As MySqlDataReader

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("name", "Nama Kendaraan")
        DataGridView1.Columns.Add("price", "Biaya Parkir")
        DataGridView1.Columns.Add("plate_number", "Nomor Plat")
        DataGridView1.Columns.Add("time_in", "Jam Masuk")

        reader = cmd.ExecuteReader()

        While reader.Read()
            Dim waktuMasuk As String = Convert.ToDateTime(reader("time_in")).ToString("dd-MM-yyyy HH:mm")
            DataGridView1.Rows.Add(reader("name"), reader("price"), reader("plate_number"), waktuMasuk)
        End While

        reader.Close()
        conn.Close()
    End Sub
End Class