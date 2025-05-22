Public Class Parkir

    Private formtujuan As String

    Public Sub New(tujuan As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        formtujuan = tujuan

    End Sub
    Private Sub Parkir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formtujuan = "motor" Then
            LoadFormToPanel(New Motor())
        ElseIf formtujuan = "mobil" Then
            LoadFormToPanel(New Mobil())
        End If

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