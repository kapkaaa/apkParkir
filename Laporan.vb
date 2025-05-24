Imports MySql.Data.MySqlClient

Public Class Laporan
    Private lastRunDate As Date = Date.MinValue

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 60000 ' 1 menit
        Timer1.Start()

        loadTable()
        total()

    End Sub

    Private Sub total()
        Dim bulan As Integer = Date.Now.Month
        Dim taun As Integer = Date.Now.Year
        Label2.Text = "Pendapatan Bulan " & MonthName(bulan) & " : "

        Try
            sql()
            Dim cmd2 As New MySqlCommand("SELECT SUM(total_earnings) AS total_bulanan FROM reports where MONTH(date) = @bulan AND YEAR(date) = @taun", conn)
            cmd2.Parameters.AddWithValue("@bulan", bulan)
            cmd2.Parameters.AddWithValue("@taun", taun)
            Dim reader2 As MySqlDataReader

            reader2 = cmd2.ExecuteReader

            If reader2.Read() Then
                Dim totalBulanan As Decimal = If(IsDBNull(reader2("total_bulanan")), 0, Convert.ToDecimal(reader2("total_bulanan")))
                Label3.Text = "Rp " & totalBulanan.ToString("N0")
            Else
                Label3.Text = "Rp 0"
            End If

            reader2.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub loadTable()
        sql()
        Dim cmd As New MySqlCommand("SELECT s.name, r.date, r.total_car, r.car_earnings, r.total_bike, r.bike_earnings, r.total_vehicle, r.total_earnings FROM reports r LEFT JOIN users s ON r.security_id= s.id ORDER BY r.id DESC", conn)
        Dim reader As MySqlDataReader

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("date", "Tanggal")
        DataGridView1.Columns.Add("name", "Nama")
        DataGridView1.Columns.Add("total_car", "Total Mobil")
        DataGridView1.Columns.Add("car_earnings", "Pendapatan Mobil")
        DataGridView1.Columns.Add("total_bike", "Total Motor")
        DataGridView1.Columns.Add("bike_earnings", "Pendapatan Motor")
        DataGridView1.Columns.Add("total_vehicle", "Total Kendaraan")
        DataGridView1.Columns.Add("total_earnings", "Total Pendapatan")

        reader = cmd.ExecuteReader()

        Dim culture As New Globalization.CultureInfo("id-ID")
        DataGridView1.DefaultCellStyle.FormatProvider = culture
        DataGridView1.Columns("date").DefaultCellStyle.Format = "dddd dd MMMM yyyy"

        While reader.Read()
            Dim rawDate As DateTime = Convert.ToDateTime(reader("date"))
            DataGridView1.Rows.Add(rawDate, reader("name"), reader("total_car"), reader("car_earnings"), reader("total_bike"), reader("bike_earnings"), reader("total_vehicle"), reader("total_earnings"))

        End While

        reader.Close()
        conn.Close()
    End Sub

    Private Sub btnLPR_Click(sender As Object, e As EventArgs) Handles btnLPR.Click
        Try
            GenerateReportManual()
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Sub GenerateReportManual()
        sql()

        Dim userCmd As New MySqlCommand("SELECT id, name FROM users", conn)
        Dim userReader As MySqlDataReader = userCmd.ExecuteReader()

        Dim users As New Dictionary(Of Integer, String)
        While userReader.Read()
            users.Add(Convert.ToInt32(userReader("id")), Convert.ToString(userReader("name")))
        End While
        userReader.Close()

        For Each userId As Integer In users.Keys
            Dim namaU As String = users(userId)
            ' Total Mobil
            Dim totalCar As Integer = 0
            Dim carPrice As Integer = 0
            Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM parkings WHERE type_id = 2 AND date = CURDATE() AND security_id = @userId AND has_paid = 1", conn)
            cmd1.Parameters.AddWithValue("@userId", userId)
            totalCar = Convert.ToInt32(cmd1.ExecuteScalar())

            ' Harga Mobil
            Dim cmd2 As New MySqlCommand("SELECT price FROM types WHERE id = 2", conn)
            carPrice = Convert.ToInt32(cmd2.ExecuteScalar())

            ' Pendapatan Mobil
            Dim carEarnings As Integer = totalCar * carPrice

            ' Total Motor
            Dim totalBike As Integer = 0
            Dim bikePrice As Integer = 0
            Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM parkings WHERE type_id = 1 AND date = CURDATE() AND security_id = @userId AND has_paid = 1", conn)
            cmd3.Parameters.AddWithValue("@userId", userId)
            totalBike = Convert.ToInt32(cmd3.ExecuteScalar())

            ' Harga Motor
            Dim cmd4 As New MySqlCommand("SELECT price FROM types WHERE id = 1", conn)
            bikePrice = Convert.ToInt32(cmd4.ExecuteScalar())

            ' Pendapatan Motor
            Dim bikeEarnings As Integer = totalBike * bikePrice

            If totalCar = 0 AndAlso totalBike = 0 Then
                Continue For
            End If

            ' Total Kendaraan
            Dim totalVehicle As Integer = 0
            Dim cmd5 As New MySqlCommand("SELECT counter FROM daily_counters WHERE day = CURDATE()", conn)
            cmd5.Parameters.AddWithValue("@userId", userId)
            Dim obj = cmd5.ExecuteScalar()
            If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
                totalVehicle = Convert.ToInt32(obj)
            End If

            ' Total Pendapatan
            Dim totalEarnings As Integer = carEarnings + bikeEarnings


            ' Cek apakah laporan sudah pernah dibuat dengan data yang sama
            Dim checkCmd As New MySqlCommand("
            SELECT COUNT(*) FROM reports 
            WHERE date = CURDATE() AND security_id = @userId 
            AND total_car = @totalCar 
            AND car_earnings = @carEarnings 
            AND total_bike = @totalBike 
            AND bike_earnings = @bikeEarnings  
            AND total_earnings = @totalEarnings
        ", conn)

            checkCmd.Parameters.AddWithValue("@userId", userId)
            checkCmd.Parameters.AddWithValue("@totalCar", totalCar)
            checkCmd.Parameters.AddWithValue("@carEarnings", carEarnings)
            checkCmd.Parameters.AddWithValue("@totalBike", totalBike)
            checkCmd.Parameters.AddWithValue("@bikeEarnings", bikeEarnings)
            checkCmd.Parameters.AddWithValue("@totalEarnings", totalEarnings)

            Dim reportExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If reportExists > 0 Then
                MessageBox.Show("Laporan sudah pernah di buat untuk operator " & namaU)
            Else

                ' Insert ke tabel reports
                Dim insertCmd As New MySqlCommand("INSERT INTO reports(total_car, car_earnings, total_bike, bike_earnings, total_vehicle, total_earnings, date, security_id) VALUES (@totalCar, @carEarnings, @totalBike, @bikeEarnings, @totalVehicle, @totalEarnings, CURDATE(), @userId) ON DUPLICATE KEY UPDATE total_car = VALUES(total_car), car_earnings = VALUES(car_earnings), total_bike = VALUES(total_bike), bike_earnings = VALUES(bike_earnings), total_vehicle = VALUES(total_vehicle), total_earnings = VALUES(total_earnings)", conn)

                insertCmd.Parameters.AddWithValue("@totalCar", totalCar)
                insertCmd.Parameters.AddWithValue("@carEarnings", carEarnings)
                insertCmd.Parameters.AddWithValue("@totalBike", totalBike)
                insertCmd.Parameters.AddWithValue("@bikeEarnings", bikeEarnings)
                insertCmd.Parameters.AddWithValue("@totalVehicle", totalVehicle)
                insertCmd.Parameters.AddWithValue("@totalEarnings", totalEarnings)
                insertCmd.Parameters.AddWithValue("@userId", userId)

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Laporan berhasil dibuat.")
            End If
        Next

        loadTable()
        total()
        conn.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim now As DateTime = DateTime.Now

        If now.Hour = 0 AndAlso now.Minute = 0 Then
            If lastRunDate <> Date.Today Then
                GenerateReportManual()
                lastRunDate = Date.Today
            End If
        End If
    End Sub
End Class