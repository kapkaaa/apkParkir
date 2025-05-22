Imports MySql.Data.MySqlClient

Public Class Keluar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchByPlate()
    End Sub

    Private Sub Keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        Dim OpName As String = CurrentUserName
        tbOP.Text = OpName
    End Sub

    Private Sub btnBTL_Click(sender As Object, e As EventArgs) Handles btnBTL.Click
        bersih()
    End Sub

    Private Sub bersih()
        tbTID.Clear()
        tbNO.Clear()
        lblHRG.Hide()
        dtpDay.Value = DateTime.Now
        dtpTime.Value = DateTime.Now
        cmbTK.SelectedIndex = -1
        tbCR.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SearchByPlate()
        Dim plateNumber As String = tbCR.Text.Trim()

        If plateNumber = "" Then
            MessageBox.Show("Masukkan plat nomor terlebih dahulu.")
            Exit Sub
        End If

        Dim query As String = "SELECT p.id, p.transaction_id, p.plate_number, p.type_id, p.time_in, p.date, " &
                          "t.name AS type_name, t.price " &
                          "FROM parkings p " &
                          "JOIN types t ON p.type_id = t.id " &
                          "WHERE p.plate_number = @plate " &
                          "AND p.has_paid = 0 " &
                          "AND p.time_out IS NULL"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@plate", plateNumber)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        DataGridView1.DataSource = dt
        FormDTG()

        If dt.Rows.Count > 0 Then
            ' Tampilkan ke form (baris pertama)
            Dim row As DataRow = dt.Rows(0)
            lblHRG.Show()

            tbID.Text = row("id").ToString()
            tbTID.Text = row("transaction_id").ToString()
            tbNO.Text = row("plate_number").ToString()
            cmbTK.Text = row("type_name").ToString()
            lblHRG.Text = row("price").ToString()
            dtpDay.Value = Convert.ToDateTime(row("date"))
            dtpTime.Value = Convert.ToDateTime(row("time_in"))
        Else
            MessageBox.Show("Data tidak ditemukan.")
        End If
    End Sub

    Private Sub FormDTG()
        ' Sembunyikan kolom type_id
        If DataGridView1.Columns.Contains("type_id") Then
            DataGridView1.Columns("type_id").Visible = False
        End If
        If DataGridView1.Columns.Contains("id") Then
            DataGridView1.Columns("id").Visible = False
        End If

        ' Ubah header text
        With DataGridView1
            .Columns("transaction_id").HeaderText = "ID Transaksi"
            .Columns("plate_number").HeaderText = "Nomor Plat"
            .Columns("time_in").HeaderText = "Jam Masuk"
            .Columns("date").HeaderText = "Tanggal Masuk"
            .Columns("type_name").HeaderText = "Nama Kendaraan"
            .Columns("price").HeaderText = "Harga"

            ' Format tampilannya saja, nilai tetap DateTime
            .Columns("time_in").DefaultCellStyle.Format = "dddd, MMMM yyyy HH:mm:ss"
            .Columns("date").DefaultCellStyle.Format = "dddd, MMMM yyyy"
        End With

        ' Pakai culture Indonesia
        DataGridView1.DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("id-ID")
    End Sub

    Private Sub btnHPS_Click(sender As Object, e As EventArgs) Handles btnHPS.Click
        If tbID.Text = "" Then
            MessageBox.Show("Silakan pilih data yang akan dihapus.")
            Return
        End If

        If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sql()
            Dim cmd As New MySqlCommand("DELETE FROM parkings WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", tbID.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus.")
            bersih()
        End If
    End Sub

    Private Sub btnSV_Click(sender As Object, e As EventArgs) Handles btnSV.Click
        If tbID.Text = "" Then
            MessageBox.Show("Silakan pilih data yang akan disimpan.")
            Return
        End If

        sql()
        Dim cmd As New MySqlCommand("
        UPDATE parkings 
        SET has_paid = 1, 
            time_out = @time_out, 
            security_id = @security_id 
        WHERE id = @id
    ", conn)

        cmd.Parameters.AddWithValue("@time_out", DateTime.Now)
        cmd.Parameters.AddWithValue("@security_id", CurrentUserID)
        cmd.Parameters.AddWithValue("@id", tbID.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data parkir berhasil disimpan sebagai 'sudah keluar'.")
        bersih()
    End Sub
End Class