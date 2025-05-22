<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mobil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mobil))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRUD = New System.Windows.Forms.GroupBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDay = New System.Windows.Forms.DateTimePicker()
        Me.btnBTL = New System.Windows.Forms.Button()
        Me.btnSV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHRG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.CRUD.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(100, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaksi Parkir Mobil"
        '
        'CRUD
        '
        Me.CRUD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRUD.Controls.Add(Me.tbHRG)
        Me.CRUD.Controls.Add(Me.Label2)
        Me.CRUD.Controls.Add(Me.dtpTime)
        Me.CRUD.Controls.Add(Me.dtpDay)
        Me.CRUD.Controls.Add(Me.btnBTL)
        Me.CRUD.Controls.Add(Me.btnSV)
        Me.CRUD.Controls.Add(Me.Label6)
        Me.CRUD.Controls.Add(Me.Label5)
        Me.CRUD.Controls.Add(Me.tbNO)
        Me.CRUD.Controls.Add(Me.Label3)
        Me.CRUD.Location = New System.Drawing.Point(245, 121)
        Me.CRUD.Name = "CRUD"
        Me.CRUD.Size = New System.Drawing.Size(543, 439)
        Me.CRUD.TabIndex = 23
        Me.CRUD.TabStop = False
        Me.CRUD.Text = "Form"
        '
        'dtpTime
        '
        Me.dtpTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTime.Enabled = False
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(139, 31)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(382, 20)
        Me.dtpTime.TabIndex = 19
        '
        'dtpDay
        '
        Me.dtpDay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDay.CustomFormat = "dddd MMMM yyyy"
        Me.dtpDay.Enabled = False
        Me.dtpDay.Location = New System.Drawing.Point(139, 105)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Size = New System.Drawing.Size(382, 20)
        Me.dtpDay.TabIndex = 15
        '
        'btnBTL
        '
        Me.btnBTL.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnBTL.FlatAppearance.BorderSize = 0
        Me.btnBTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBTL.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBTL.Location = New System.Drawing.Point(56, 346)
        Me.btnBTL.Name = "btnBTL"
        Me.btnBTL.Size = New System.Drawing.Size(75, 23)
        Me.btnBTL.TabIndex = 12
        Me.btnBTL.Text = "Batal"
        Me.btnBTL.UseVisualStyleBackColor = False
        '
        'btnSV
        '
        Me.btnSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSV.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSV.FlatAppearance.BorderSize = 0
        Me.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSV.Location = New System.Drawing.Point(446, 346)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSV.TabIndex = 11
        Me.btnSV.Text = "Simpan"
        Me.btnSV.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jam Masuk"
        '
        'tbNO
        '
        Me.tbNO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNO.Location = New System.Drawing.Point(139, 242)
        Me.tbNO.MaxLength = 19
        Me.tbNO.Name = "tbNO"
        Me.tbNO.Size = New System.Drawing.Size(382, 20)
        Me.tbNO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOPOL"
        '
        'tbHRG
        '
        Me.tbHRG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHRG.Location = New System.Drawing.Point(139, 168)
        Me.tbHRG.MaxLength = 19
        Me.tbHRG.Name = "tbHRG"
        Me.tbHRG.ReadOnly = True
        Me.tbHRG.Size = New System.Drawing.Size(382, 20)
        Me.tbHRG.TabIndex = 21
        Me.tbHRG.Text = "Rp. 5000"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Harga"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox4.Image = Global.AplikasiParkir.My.Resources.Resources.image_removebg_preview1
        Me.PictureBox4.Location = New System.Drawing.Point(41, 334)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(133, 112)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(41, 133)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(133, 113)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'Mobil
        '
        Me.AcceptButton = Me.btnSV
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 572)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CRUD)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Mobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CRUD.ResumeLayout(False)
        Me.CRUD.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CRUD As GroupBox
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpDay As DateTimePicker
    Friend WithEvents btnBTL As Button
    Friend WithEvents btnSV As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tbHRG As TextBox
    Friend WithEvents Label2 As Label
End Class
