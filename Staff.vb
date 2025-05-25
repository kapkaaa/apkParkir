Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Staff
    Dim lastChecked As RadioButton = Nothing
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

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        Dim code As String = GenerateKode()
        TextBox2.Text = code
    End Sub

    Private Sub btnBTL_Click(sender As Object, e As EventArgs) Handles btnBTL.Click
        bersih()
    End Sub

    Private Sub bersih()
        tbNM.Clear()
        tbNO.Clear()
        tbALMT.Clear()
        tbUSN.Clear()
        tbPW.Clear()
        RadioButton1.Checked = False
        loadData()
    End Sub

    Private Sub loadData()
        sql()
        Dim cmd As New MySqlCommand("SELECT u.id, u.name, u.phone_number, u.password, u.address, u.username, u.code, r.name AS name_role, u.role_id FROM users u LEFT JOIN roles r ON u.role_id = r.id", conn)
        Dim reader As MySqlDataReader

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("id", "id")
        DataGridView1.Columns.Add("name", "Nama")
        DataGridView1.Columns.Add("phone_number", "No Telepon")
        DataGridView1.Columns.Add("address", "Alamat")
        DataGridView1.Columns.Add("username", "Username")
        DataGridView1.Columns.Add("r.name", "Role")
        DataGridView1.Columns.Add("password", "password")
        DataGridView1.Columns.Add("role_id", "Role")
        DataGridView1.Columns.Add("code", "code")

        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("code").Visible = False
        DataGridView1.Columns("password").Visible = False
        DataGridView1.Columns("role_id").Visible = False

        reader = cmd.ExecuteReader()

        While reader.Read()
            DataGridView1.Rows.Add(reader("id"), reader("name"), reader("phone_number"), reader("address"), reader("username"), reader("name_role"), reader("password"), reader("role_id"), reader("code"))
        End While

        reader.Close()
        conn.Close()
    End Sub

    Private Sub btnSV_Click(sender As Object, e As EventArgs) Handles btnSV.Click
        sql()
        Try
            Dim role_id As Integer
            If RadioButton1.Checked Then
                role_id = 1
            Else
                role_id = 2
            End If

            Dim cmd As New MySqlCommand("INSERT INTO users (name, code, phone_number, address, username, password, role_id) VALUES (@name, @code, @phone_number, @address, @username, @password, @role_id) ON DUPLICATE KEY UPDATE name = VALUES(name), phone_number = VALUES(phone_number), address= VALUES(address), username = VALUES(username), password = VALUES(password), role_id = VALUES(role_id)", conn)
            cmd.Parameters.AddWithValue("@name", tbNM.Text)
            cmd.Parameters.AddWithValue("@code", TextBox2.Text)
            cmd.Parameters.AddWithValue("@phone_number", tbNO.Text)
            cmd.Parameters.AddWithValue("@address", tbALMT.Text)
            cmd.Parameters.AddWithValue("@username", tbUSN.Text)
            cmd.Parameters.AddWithValue("@password", tbPW.Text)
            cmd.Parameters.AddWithValue("@role_id", role_id)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data berhasil disimpan!")
                bersih()
            Else
                MessageBox.Show("Gagal menyimpan data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Masukkan data ke TextBox
            TextBox1.Text = row.Cells("id").Value.ToString()
            tbNM.Text = row.Cells("name").Value.ToString()
            tbNO.Text = row.Cells("phone_number").Value.ToString()
            tbALMT.Text = row.Cells("address").Value.ToString()
            tbUSN.Text = row.Cells("username").Value.ToString()
            tbPW.Text = row.Cells("password").Value.ToString()
            TextBox2.Text = row.Cells("code").Value.ToString()

            ' Set RadioButton sesuai role_id
            Dim roleValue = row.Cells("role_id").Value
            Dim roleId As Integer = 0

            If roleValue IsNot Nothing AndAlso Not IsDBNull(roleValue) Then
                If Integer.TryParse(roleValue.ToString(), roleId) Then
                    ' roleId berhasil di-parse
                Else
                    roleId = 0 ' atau default nilai lain
                End If
            Else
                roleId = 0 ' default nilai jika null atau DBNull
            End If

            ' Set radio button berdasarkan roleId
            If roleId = 1 Then
                RadioButton1.Checked = True
            Else
                RadioButton1.Checked = False
            End If

        End If
    End Sub

    Private Sub btnHPS_Click(sender As Object, e As EventArgs) Handles btnHPS.Click
        sql()
        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim cmd As New MySqlCommand("delete from users where id = @id", conn)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Data User berhasil di hapus")
                    bersih()
                Else
                    MessageBox.Show("Data tidak ditemukan atau gagal dihapus.")
                End If

                conn.Close()
            Catch ex As Exception
                MessageBox.Show("error mbut" & ex.Message)
                conn.Close()
            End Try
        End If

    End Sub

    Private Function GenerateKode() As String
        sql()
        Dim existing_kodes As New List(Of Integer)
        Dim query As String = "SELECT code FROM users WHERE code LIKE 'USR____' ORDER BY code ASC"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim kode As String = reader("code").ToString()
            Dim angka As Integer = 0
            If Integer.TryParse(kode.Substring(kode.Length - 4), angka) Then
                existing_kodes.Add(angka)
            End If
        End While
        reader.Close()

        existing_kodes.Sort()

        ' Cari angka terkecil yang belum dipakai
        Dim new_kode As Integer = 1
        For Each kode In existing_kodes
            If kode <> new_kode Then
                Exit For
            End If
            new_kode += 1
        Next

        Return "USR" & new_kode.ToString("D4")
    End Function

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Dim rb As RadioButton = CType(sender, RadioButton)

        If lastChecked Is rb Then
            rb.Checked = False
            lastChecked = Nothing
        Else
            lastChecked = rb
        End If
    End Sub
End Class