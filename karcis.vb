Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class karcis
    Public jenisKendaraan As String
    Public parkingId As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblno_Click(sender As Object, e As EventArgs) Handles lblno.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub karcis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("id " & parkingId)
        If jenisKendaraan.ToLower() = "mobil" Then
            PictureBox1.Image = My.Resources.image_removebg_preview 'pastikan gambar mobil sudah ada di Resources
            LabelJen.Text = "Pembayaran Parkir Mobil"
        ElseIf jenisKendaraan.ToLower() = "motor" Then
            PictureBox1.Image = My.Resources.download_removebg_preview 'pastikan gambar motor juga ada di Resources
            LabelJen.Text = "Pembayaran Parkir Motor"
        End If

        tampil()

    End Sub

    Private Sub tampil()
        sql()
        Dim cmd As New MySqlCommand("select plate_number, time_in, date from parkings where id = @id", conn)
        cmd.Parameters.AddWithValue("@id", parkingId)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblno.Text = reader("plate_number").ToString()
                Dim waktuMasuk As DateTime = DateTime.Parse(reader("time_in").ToString())
                Dim tanggal As DateTime = DateTime.Parse(reader("date").ToString())
                Dim culture As New CultureInfo("id-ID")
                lbltgl.Text = tanggal.ToString("dddd dd-MM-yyyy", culture)
                lbljam.Text = waktuMasuk.ToString("HH:mm:ss")
            Else
                MessageBox.Show("Data tidak ditemukan!")
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class