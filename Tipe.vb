Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class Tipe
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub Tipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            sql()
            Dim query As String = "SELECT p.transaction_id AS id_transaksi, t.name AS nama_kendaraan, p.plate_number AS nomor_plat, t.price AS biaya_parkir, p.time_in, p.date, p.time_out, u.name AS operator FROM parkings p " & "LEFT JOIN types t ON t.id = p.type_id " & "LEFT JOIN users u ON p.security_id = u.id " & "WHERE p.time_out IS NOT NULL AND p.security_id IS NOT NULL " & "ORDER BY p.time_out DESC"

            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
            With DataGridView1
                .Columns("id_transaksi").HeaderText = "ID Transaksi"
                .Columns("nama_kendaraan").HeaderText = "Nama Kendaraan"
                .Columns("nomor_plat").HeaderText = "Nomor Plat"
                .Columns("biaya_parkir").HeaderText = "Biaya Parkir"
                .Columns("time_in").HeaderText = "Jam Masuk"
                .Columns("date").HeaderText = "Tanggal Masuk"
                .Columns("time_out").HeaderText = "Jam Keluar"
                .Columns("operator").HeaderText = "Operator"
            End With


            Dim culture As New Globalization.CultureInfo("id-ID")
            DataGridView1.DefaultCellStyle.FormatProvider = culture

            If DataGridView1.Columns.Contains("time_in") Then
                DataGridView1.Columns("time_in").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
            End If
            If DataGridView1.Columns.Contains("date") Then
                DataGridView1.Columns("date").DefaultCellStyle.Format = "dddd dd MMMM yyyy"
            End If
            If DataGridView1.Columns.Contains("time_out") Then
                DataGridView1.Columns("time_out").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message)
        End Try

    End Sub

    Private Sub FilterByDate()
        sql()
        Dim tanggalAwal As String = dtp1.Value.ToString("yyyy-MM-dd")
        Dim tanggalAkhir As String = dtp2.Value.ToString("yyyy-MM-dd")

        If dtp1.Value > dtp2.Value Then
            MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dtp2.Value < dtp1.Value Then
            MessageBox.Show("Tanggal akhir tidak boleh lebih kecil dari tanggal awal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        DataGridView1.DataSource = Nothing

        Dim cmd As New MySqlCommand("SELECT transaction_id AS 'Id Transaksi', (CASE WHEN type_id = 1 THEN 'Motor' ELSE 'Mobil' END) AS 'Nama Kendaraan', plate_number AS 'Nomor Plat', (CASE WHEN type_id = 1 THEN 2000 ELSE 5000 END) AS 'Biaya Parkir', TIME_FORMAT(time_in, '%H:%i:%s') AS 'Jam Masuk', DATE_FORMAT(date, '%d %b %Y') AS 'Tanggal Masuk', TIME_FORMAT(time_out, '%H:%i:%s') AS 'Jam Keluar', (SELECT username FROM users WHERE id = parkings.security_id) AS 'Operator' FROM parkings WHERE date BETWEEN @awal AND @akhir", conn)
        cmd.Parameters.AddWithValue("@awal", tanggalAwal)
        cmd.Parameters.AddWithValue("@akhir", tanggalAkhir)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        SearchAndFilter()

    End Sub

    Private Sub dtp2_ValueChanged(sender As Object, e As EventArgs) Handles dtp2.ValueChanged
        SearchAndFilter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCR.Click
        SearchByKeyword()
    End Sub

    Private Sub SearchAndFilter()
        Dim keyword As String = tbCR.Text.Trim()
        Dim tanggalAwal As String = dtp1.Value.ToString("yyyy-MM-dd")
        Dim tanggalAkhir As String = dtp2.Value.ToString("yyyy-MM-dd")

        If dtp1.Value > dtp2.Value Then
            MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim useKeyword As Boolean = keyword <> ""

        Dim query As String = "SELECT p.transaction_id AS id_transaksi, t.name AS nama_kendaraan, p.plate_number AS nomor_plat, " &
                          "t.price AS biaya_parkir, p.time_in, p.date, p.time_out, u.name AS operator " &
                          "FROM parkings p " &
                          "LEFT JOIN types t ON t.id = p.type_id " &
                          "LEFT JOIN users u ON p.security_id = u.id " &
                          "WHERE p.time_out IS NOT NULL AND p.security_id IS NOT NULL " &
                          "AND p.date BETWEEN @awal AND @akhir "

        If useKeyword Then
            query &= "AND (p.transaction_id LIKE @keyword OR " &
                 "p.plate_number LIKE @keyword OR " &
                 "t.name LIKE @keyword OR " &
                 "t.price LIKE @keyword OR " &
                 "p.time_in LIKE @keyword OR " &
                 "p.date LIKE @keyword OR " &
                 "p.time_out LIKE @keyword OR " &
                 "u.name LIKE @keyword) "
        End If

        query &= "ORDER BY p.time_out DESC"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@awal", tanggalAwal)
        cmd.Parameters.AddWithValue("@akhir", tanggalAkhir)
        If useKeyword Then
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        End If

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        With DataGridView1
            If .Columns.Contains("id_transaksi") Then .Columns("id_transaksi").HeaderText = "ID Transaksi"
            If .Columns.Contains("nama_kendaraan") Then .Columns("nama_kendaraan").HeaderText = "Nama Kendaraan"
            If .Columns.Contains("nomor_plat") Then .Columns("nomor_plat").HeaderText = "Nomor Plat"
            If .Columns.Contains("biaya_parkir") Then .Columns("biaya_parkir").HeaderText = "Biaya Parkir"
            If .Columns.Contains("time_in") Then .Columns("time_in").HeaderText = "Jam Masuk"
            If .Columns.Contains("date") Then .Columns("date").HeaderText = "Tanggal Masuk"
            If .Columns.Contains("time_out") Then .Columns("time_out").HeaderText = "Jam Keluar"
            If .Columns.Contains("operator") Then .Columns("operator").HeaderText = "Operator"
        End With

        Dim culture As New Globalization.CultureInfo("id-ID")
        DataGridView1.DefaultCellStyle.FormatProvider = culture

        If DataGridView1.Columns.Contains("time_in") Then
            DataGridView1.Columns("time_in").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
        End If
        If DataGridView1.Columns.Contains("date") Then
            DataGridView1.Columns("date").DefaultCellStyle.Format = "dddd dd MMMM yyyy"
        End If
        If DataGridView1.Columns.Contains("time_out") Then
            DataGridView1.Columns("time_out").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
        End If
    End Sub


    Private Sub SearchByKeyword()
        Dim keyword As String = tbCR.Text.Trim()

        If keyword = "" Then
            MessageBox.Show("Masukkan kata kunci pencarian terlebih dahulu.")
            Exit Sub
        End If

        Dim query As String = "SELECT p.transaction_id AS id_transaksi, t.name AS nama_kendaraan, p.plate_number AS nomor_plat, t.price AS biaya_parkir, p.time_in, p.date, p.time_out, u.name AS operator " & "FROM parkings p " & "LEFT JOIN types t ON t.id = p.type_id " & "LEFT JOIN users u ON p.security_id = u.id " & "WHERE p.time_out IS NOT NULL AND p.security_id IS NOT NULL " & "AND (" & "p.transaction_id LIKE @keyword OR " & "p.plate_number LIKE @keyword OR " & "t.name LIKE @keyword OR " & "t.price LIKE @keyword OR " & "p.time_in LIKE @keyword OR " & "p.date LIKE @keyword OR " & "p.time_out LIKE @keyword OR " & "u.name LIKE @keyword" & ") " & "ORDER BY p.time_out DESC"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        adapter.Fill(dt)
        DataGridView1.DataSource = dt
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan.")
        End If

        With DataGridView1
            .Columns("id_transaksi").HeaderText = "ID Transaksi"
            .Columns("nama_kendaraan").HeaderText = "Nama Kendaraan"
            .Columns("nomor_plat").HeaderText = "Nomor Plat"
            .Columns("biaya_parkir").HeaderText = "Biaya Parkir"
            .Columns("time_in").HeaderText = "Jam Masuk"
            .Columns("date").HeaderText = "Tanggal Masuk"
            .Columns("time_out").HeaderText = "Jam Keluar"
            .Columns("operator").HeaderText = "Operator"
        End With


        Dim culture As New Globalization.CultureInfo("id-ID")
        DataGridView1.DefaultCellStyle.FormatProvider = culture

        If DataGridView1.Columns.Contains("time_in") Then
            DataGridView1.Columns("time_in").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
        End If
        If DataGridView1.Columns.Contains("date") Then
            DataGridView1.Columns("date").DefaultCellStyle.Format = "dddd dd MMMM yyyy"
        End If
        If DataGridView1.Columns.Contains("time_out") Then
            DataGridView1.Columns("time_out").DefaultCellStyle.Format = "dddd dd-MMMM-yyyy HH:mm:ss"
        End If

    End Sub

    Private Sub tbCR_TextChanged(sender As Object, e As EventArgs) Handles tbCR.TextChanged
        SearchAndFilter()
    End Sub
End Class