Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Staff
    Private Sub tbNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNO.KeyPress
        If tbNO.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class