Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Staff
    Private Sub tbNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNO.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If

        If tbNO.Text.Length >= 15 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub tbNO_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql()
        Dim cmd As New MySqlCommand("SELECT u.name, u.phone_number, u.address, u.username, r.name AS name_role FROM users u LEFT JOIN roles r ON u.role_id = r.id", conn)
        Dim reader As MySqlDataReader

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("name", "Nama")
        DataGridView1.Columns.Add("phone_number", "No Telepon")
        DataGridView1.Columns.Add("address", "Alamat")
        DataGridView1.Columns.Add("username", "Username")
        DataGridView1.Columns.Add("r.name", "Role")

        reader = cmd.ExecuteReader()

        While reader.Read()
            DataGridView1.Rows.Add(reader("name"), reader("phone_number"), reader("address"), reader("username"), reader("name_role"))
        End While

        reader.Close()
        conn.Close()
    End Sub
End Class