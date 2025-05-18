Public Class Security
    Private Sub btnTRS_Click(sender As Object, e As EventArgs) Handles btnTRS.Click
        transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnLPRN_Click(sender As Object, e As EventArgs) Handles btnLPRN.Click
        Laporan.Show()
        Me.Hide()
    End Sub
End Class