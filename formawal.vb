Public Class formawal
    Private Sub btnLGN_Click(sender As Object, e As EventArgs) Handles btnLGN.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnmotor_Click(sender As Object, e As EventArgs) Handles btnmotor.Click
        Dim parkir As New Parkir("motor")
        parkir.Show()
        'Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parkir As New Parkir("mobil")
        parkir.Show()
        'Me.Hide()
    End Sub
End Class