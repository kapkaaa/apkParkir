Public Class transaksi
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadFormToPanel(New Masuk())
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        LoadFormToPanel(New Keluar())
    End Sub

    Private Sub LoadFormToPanel(childForm As Form)
        panelContainer.Controls.Clear()
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        panelContainer.Controls.Add(childForm)
        childForm.Show()
    End Sub
End Class