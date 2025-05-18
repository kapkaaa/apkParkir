Public Class Laporan
    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Hide()
    End Sub
End Class