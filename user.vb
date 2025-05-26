Imports MySql.Data.MySqlClient

Public Class Motor
    Private Sub btnSV_Click(sender As Object, e As EventArgs) Handles btnSV.Click
        Dim code As String = GenerateKode()
        Dim tanggal As String = dtpDay.Value.ToString("yyyy:MM:dd")
        Dim jam As String = dtpTime.Value.ToString("yyyy:MM:dd HH:mm:ss")
        sql()
        Dim cmd As New MySqlCommand("INSERT INTO parkings (transaction_id, plate_number, type_id, has_paid, time_in, date) " & "VALUES (@transaction_id, @plate, 1, 0, @time_in, @date_in); SELECT LAST_INSERT_ID();", conn)
        cmd.Parameters.AddWithValue("@transaction_id", code)
        cmd.Parameters.AddWithValue("@plate", tbNO.Text)
        cmd.Parameters.AddWithValue("@time_in", jam)
        cmd.Parameters.AddWithValue("@date_in", tanggal)

        Dim lastInsertId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        Dim cmdcd As New MySqlCommand("select counter from daily_counters where day = @day", conn)
        cmdcd.Parameters.AddWithValue("@day", tanggal)
        Dim cdr As Object = cmdcd.ExecuteScalar()

        If cdr IsNot Nothing Then
            ' Update jika sudah ada
            Dim updateCounterQuery As String = "UPDATE daily_counters SET counter = counter + 1 WHERE day = @date"
            Dim cmdUpdateCounter As New MySqlCommand(updateCounterQuery, conn)
            cmdUpdateCounter.Parameters.AddWithValue("@date", tanggal)
            cmdUpdateCounter.ExecuteNonQuery()
        Else
            ' Insert jika belum ada
            Dim insertCounterQuery As String = "INSERT INTO daily_counters (day, counter) VALUES (@date, 1)"
            Dim cmdInsertCounter As New MySqlCommand(insertCounterQuery, conn)
            cmdInsertCounter.Parameters.AddWithValue("@date", tanggal)
            cmdInsertCounter.ExecuteNonQuery()
        End If

        MessageBox.Show("Data Motor Tersimpan")
        Dim formKarcis As New karcis
        formKarcis.parkingId = lastInsertId
        formKarcis.jenisKendaraan = "motor"
        formKarcis.Show()
        tbNO.Clear()
        Me.ParentForm.Close()

        conn.Close()
    End Sub

    Private Sub btnBTL_Click(sender As Object, e As EventArgs) Handles btnBTL.Click
        tbNO.Clear()
    End Sub

    Private Function GenerateKode() As String
        sql()
        Dim existing_kodes As New List(Of Integer)
        Dim query As String = "SELECT transaction_id FROM parkings WHERE transaction_id LIKE 'MTR____' ORDER BY transaction_id ASC"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim kode As String = reader("transaction_id").ToString()
            Dim angka As Integer = 0
            If Integer.TryParse(kode.Substring(kode.Length - 4), angka) Then
                existing_kodes.Add(angka)
            End If
        End While
        reader.Close()
        conn.Close()

        existing_kodes.Sort()

        ' Cari angka terkecil yang belum dipakai
        Dim new_kode As Integer = 1
        For Each kode In existing_kodes
            If kode <> new_kode Then
                Exit For
            End If
            new_kode += 1
        Next

        Return "MTR" & new_kode.ToString("D4")
    End Function

End Class