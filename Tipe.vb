Public Class Tipe
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Hide()
    End Sub
End Class