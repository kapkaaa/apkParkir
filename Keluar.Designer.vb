<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keluar
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
        Me.tbCR = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRUD = New System.Windows.Forms.GroupBox()
        Me.lblHRG = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpDay = New System.Windows.Forms.DateTimePicker()
        Me.cmbTK = New System.Windows.Forms.ComboBox()
        Me.btnHPS = New System.Windows.Forms.Button()
        Me.btnBTL = New System.Windows.Forms.Button()
        Me.btnSV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CRUD.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCR
        '
        Me.tbCR.Location = New System.Drawing.Point(673, 22)
        Me.tbCR.Name = "tbCR"
        Me.tbCR.Size = New System.Drawing.Size(267, 20)
        Me.tbCR.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(946, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(997, 79)
        Me.DataGridView1.TabIndex = 2
        '
        'CRUD
        '
        Me.CRUD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRUD.Controls.Add(Me.tbID)
        Me.CRUD.Controls.Add(Me.dtpTime)
        Me.CRUD.Controls.Add(Me.lblHRG)
        Me.CRUD.Controls.Add(Me.Label1)
        Me.CRUD.Controls.Add(Me.tbOP)
        Me.CRUD.Controls.Add(Me.Label7)
        Me.CRUD.Controls.Add(Me.dtpDay)
        Me.CRUD.Controls.Add(Me.cmbTK)
        Me.CRUD.Controls.Add(Me.btnHPS)
        Me.CRUD.Controls.Add(Me.btnBTL)
        Me.CRUD.Controls.Add(Me.btnSV)
        Me.CRUD.Controls.Add(Me.Label6)
        Me.CRUD.Controls.Add(Me.Label5)
        Me.CRUD.Controls.Add(Me.Label4)
        Me.CRUD.Controls.Add(Me.tbNO)
        Me.CRUD.Controls.Add(Me.Label3)
        Me.CRUD.Controls.Add(Me.tbTID)
        Me.CRUD.Controls.Add(Me.Label2)
        Me.CRUD.Location = New System.Drawing.Point(20, 173)
        Me.CRUD.Name = "CRUD"
        Me.CRUD.Size = New System.Drawing.Size(997, 357)
        Me.CRUD.TabIndex = 17
        Me.CRUD.TabStop = False
        Me.CRUD.Text = "Form"
        '
        'lblHRG
        '
        Me.lblHRG.AutoSize = True
        Me.lblHRG.Location = New System.Drawing.Point(899, 201)
        Me.lblHRG.Name = "lblHRG"
        Me.lblHRG.Size = New System.Drawing.Size(51, 13)
        Me.lblHRG.TabIndex = 22
        Me.lblHRG.Text = "Rp. 5000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(809, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Harga di Bayar"
        '
        'tbOP
        '
        Me.tbOP.Location = New System.Drawing.Point(609, 93)
        Me.tbOP.Name = "tbOP"
        Me.tbOP.ReadOnly = True
        Me.tbOP.Size = New System.Drawing.Size(332, 20)
        Me.tbOP.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(540, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Operator"
        '
        'dtpDay
        '
        Me.dtpDay.CustomFormat = "dd MMMM yyyy"
        Me.dtpDay.Enabled = False
        Me.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDay.Location = New System.Drawing.Point(134, 150)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Size = New System.Drawing.Size(332, 20)
        Me.dtpDay.TabIndex = 15
        '
        'cmbTK
        '
        Me.cmbTK.Enabled = False
        Me.cmbTK.FormattingEnabled = True
        Me.cmbTK.Location = New System.Drawing.Point(134, 93)
        Me.cmbTK.Name = "cmbTK"
        Me.cmbTK.Size = New System.Drawing.Size(333, 21)
        Me.cmbTK.TabIndex = 14
        '
        'btnHPS
        '
        Me.btnHPS.BackColor = System.Drawing.Color.Red
        Me.btnHPS.FlatAppearance.BorderSize = 0
        Me.btnHPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHPS.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHPS.Location = New System.Drawing.Point(618, 240)
        Me.btnHPS.Name = "btnHPS"
        Me.btnHPS.Size = New System.Drawing.Size(75, 23)
        Me.btnHPS.TabIndex = 13
        Me.btnHPS.Text = "Hapus"
        Me.btnHPS.UseVisualStyleBackColor = False
        '
        'btnBTL
        '
        Me.btnBTL.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnBTL.FlatAppearance.BorderSize = 0
        Me.btnBTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBTL.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBTL.Location = New System.Drawing.Point(745, 240)
        Me.btnBTL.Name = "btnBTL"
        Me.btnBTL.Size = New System.Drawing.Size(75, 23)
        Me.btnBTL.TabIndex = 12
        Me.btnBTL.Text = "Batal"
        Me.btnBTL.UseVisualStyleBackColor = False
        '
        'btnSV
        '
        Me.btnSV.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSV.FlatAppearance.BorderSize = 0
        Me.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSV.Location = New System.Drawing.Point(875, 240)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSV.TabIndex = 11
        Me.btnSV.Text = "Simpan"
        Me.btnSV.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jam Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipe Kendaraan"
        '
        'tbNO
        '
        Me.tbNO.Location = New System.Drawing.Point(609, 40)
        Me.tbNO.MaxLength = 19
        Me.tbNO.Name = "tbNO"
        Me.tbNO.ReadOnly = True
        Me.tbNO.Size = New System.Drawing.Size(332, 20)
        Me.tbNO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(540, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOPOL"
        '
        'tbTID
        '
        Me.tbTID.Location = New System.Drawing.Point(134, 40)
        Me.tbTID.Name = "tbTID"
        Me.tbTID.ReadOnly = True
        Me.tbTID.Size = New System.Drawing.Size(333, 20)
        Me.tbTID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Transaksi ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 33)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Kendaraan Keluar"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "dd MMMM yyyy"
        Me.dtpTime.Enabled = False
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(618, 150)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(332, 20)
        Me.dtpTime.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(557, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Masukkan NOPOL :"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(321, 240)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 24
        Me.tbID.Visible = False
        '
        'Keluar
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 737)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CRUD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCR)
        Me.Name = "Keluar"
        Me.Text = "Keluar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CRUD.ResumeLayout(False)
        Me.CRUD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCR As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CRUD As GroupBox
    Friend WithEvents cmbTK As ComboBox
    Friend WithEvents btnHPS As Button
    Friend WithEvents btnBTL As Button
    Friend WithEvents btnSV As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDay As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbOP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHRG As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tbID As TextBox
End Class
