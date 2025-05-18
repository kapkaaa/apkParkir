Public Class Admin
    Private Sub btnTRS_Click(sender As Object, e As EventArgs) Handles btnTRS.Click
        transaksi.Show()
        'Me.Hide()
    End Sub

    Private Sub btnSTF_Click(sender As Object, e As EventArgs) Handles btnSTF.Click
        Staff.Show()
        'Me.Hide()
    End Sub

    Private Sub btnTP_Click(sender As Object, e As EventArgs) Handles btnTP.Click
        Tipe.Show()
        'Me.Hide()
    End Sub

    Private Sub btnLPRN_Click(sender As Object, e As EventArgs) Handles btnLPRN.Click
        Laporan.Show()
        'Me.Hide()
    End Sub
End Class