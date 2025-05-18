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
        Me.btnHPS = New System.Windows.Forms.Button()
        Me.btnBTL = New System.Windows.Forms.Button()
        Me.btnSV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CRUD.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCR
        '
        Me.tbCR.Location = New System.Drawing.Point(12, 89)
        Me.tbCR.Name = "tbCR"
        Me.tbCR.Size = New System.Drawing.Size(315, 20)
        Me.tbCR.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(333, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(392, 52)
        Me.DataGridView1.TabIndex = 2
        '
        'CRUD
        '
        Me.CRUD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRUD.Controls.Add(Me.Label8)
        Me.CRUD.Controls.Add(Me.TextBox1)
        Me.CRUD.Controls.Add(Me.Label1)
        Me.CRUD.Controls.Add(Me.TextBox2)
        Me.CRUD.Controls.Add(Me.Label7)
        Me.CRUD.Controls.Add(Me.DateTimePicker1)
        Me.CRUD.Controls.Add(Me.ComboBox1)
        Me.CRUD.Controls.Add(Me.btnHPS)
        Me.CRUD.Controls.Add(Me.btnBTL)
        Me.CRUD.Controls.Add(Me.btnSV)
        Me.CRUD.Controls.Add(Me.Label6)
        Me.CRUD.Controls.Add(Me.Label5)
        Me.CRUD.Controls.Add(Me.Label4)
        Me.CRUD.Controls.Add(Me.tbNO)
        Me.CRUD.Controls.Add(Me.Label3)
        Me.CRUD.Controls.Add(Me.tbNM)
        Me.CRUD.Controls.Add(Me.Label2)
        Me.CRUD.Location = New System.Drawing.Point(470, 87)
        Me.CRUD.Name = "CRUD"
        Me.CRUD.Size = New System.Drawing.Size(539, 510)
        Me.CRUD.TabIndex = 17
        Me.CRUD.TabStop = False
        Me.CRUD.Text = "Form"
        '
        'btnHPS
        '
        Me.btnHPS.BackColor = System.Drawing.Color.Red
        Me.btnHPS.FlatAppearance.BorderSize = 0
        Me.btnHPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHPS.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHPS.Location = New System.Drawing.Point(412, 401)
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
        Me.btnBTL.Location = New System.Drawing.Point(324, 401)
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
        Me.btnSV.Location = New System.Drawing.Point(234, 401)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSV.TabIndex = 11
        Me.btnSV.Text = "Simpan"
        Me.btnSV.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jam Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipe Kendaraan"
        '
        'tbNO
        '
        Me.tbNO.Location = New System.Drawing.Point(115, 86)
        Me.tbNO.MaxLength = 19
        Me.tbNO.Name = "tbNO"
        Me.tbNO.ReadOnly = True
        Me.tbNO.Size = New System.Drawing.Size(372, 20)
        Me.tbNO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOPOL"
        '
        'tbNM
        '
        Me.tbNM.Location = New System.Drawing.Point(115, 25)
        Me.tbNM.Name = "tbNM"
        Me.tbNM.ReadOnly = True
        Me.tbNM.Size = New System.Drawing.Size(372, 20)
        Me.tbNM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Transaksi ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 149)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(372, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 278)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(372, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Harga di Bayar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(115, 209)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(372, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Satpam"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 338)
        Me.TextBox1.MaxLength = 19
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(372, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Rp. 5000"
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
        'Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 737)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnHPS As Button
    Friend WithEvents btnBTL As Button
    Friend WithEvents btnSV As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
