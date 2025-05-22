Imports MySql.Data.MySqlClient

Public Class Laporan
    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql()
        Dim cmd As New MySqlCommand("SELECT s.name, r.date, r.total_car, r.car_earnings, r.total_bike, r.bike_earnings, r.total_vehicle, r.total_earnings FROM reports r LEFT JOIN users s ON r.security_id= s.id", conn)
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

        While reader.Read()
            DataGridView1.Rows.Add(reader("date"), reader("name"), reader("total_car"), reader("car_earnings"), reader("total_bike"), reader("bike_earnings"), reader("total_vehicle"), reader("total_earnings"))
        End While

        reader.Close()
        conn.Close()

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
End Class