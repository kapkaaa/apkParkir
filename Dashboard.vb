Public Class Dashboard

    Private userRole As Integer

    ' Constructor FormDashboard menerima role_id
    Public Sub New(role As Integer)
        InitializeComponent()
        userRole = role
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = DateTime.Now.ToString("HH:mm:ss")
        day.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userRole = 1 Then
            LoadFormToPanel(New Admin())
        ElseIf userRole = 2 Then
            LoadFormToPanel(New Security())
        End If

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        transaksi.Show()
        Me.Hide()
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

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Session.currentRole = 0
        Session.CurrentUserID = 0
        Session.CurrentUserName = ""
        Session.IsLoggedIn = False
        Login.Show()
        Me.Hide()
    End Sub
End Class