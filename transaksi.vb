Public Class transaksi
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim role_id As Integer = Session.currentRole
        Dim dashboard As New Dashboard(role_id)
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
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

    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormToPanel(New Keluar)
    End Sub
End Class