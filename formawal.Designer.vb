<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formawal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLGN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnmotor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLGN
        '
        Me.btnLGN.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLGN.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLGN.Location = New System.Drawing.Point(699, 435)
        Me.btnLGN.Name = "btnLGN"
        Me.btnLGN.Size = New System.Drawing.Size(80, 27)
        Me.btnLGN.TabIndex = 3
        Me.btnLGN.Text = "Login"
        Me.btnLGN.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.AplikasiParkir.My.Resources.Resources.image_removebg_preview
        Me.Button1.Location = New System.Drawing.Point(417, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 279)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnmotor
        '
        Me.btnmotor.BackColor = System.Drawing.Color.Transparent
        Me.btnmotor.Image = Global.AplikasiParkir.My.Resources.Resources.download_removebg_preview
        Me.btnmotor.Location = New System.Drawing.Point(88, 85)
        Me.btnmotor.Name = "btnmotor"
        Me.btnmotor.Size = New System.Drawing.Size(279, 279)
        Me.btnmotor.TabIndex = 4
        Me.btnmotor.UseVisualStyleBackColor = False
        '
        'formawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnmotor)
        Me.Controls.Add(Me.btnLGN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formawal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLGN As Button
    Friend WithEvents btnmotor As Button
    Friend WithEvents Button1 As Button
End Class
