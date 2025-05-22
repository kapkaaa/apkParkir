<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masuk
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
        Me.CRUD = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnBTL = New System.Windows.Forms.Button()
        Me.btnSV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRUD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRUD
        '
        Me.CRUD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRUD.Controls.Add(Me.DateTimePicker2)
        Me.CRUD.Controls.Add(Me.TextBox2)
        Me.CRUD.Controls.Add(Me.Label7)
        Me.CRUD.Controls.Add(Me.DateTimePicker1)
        Me.CRUD.Controls.Add(Me.ComboBox1)
        Me.CRUD.Controls.Add(Me.btnBTL)
        Me.CRUD.Controls.Add(Me.btnSV)
        Me.CRUD.Controls.Add(Me.Label6)
        Me.CRUD.Controls.Add(Me.Label5)
        Me.CRUD.Controls.Add(Me.Label4)
        Me.CRUD.Controls.Add(Me.tbNO)
        Me.CRUD.Controls.Add(Me.Label3)
        Me.CRUD.Controls.Add(Me.tbNM)
        Me.CRUD.Controls.Add(Me.Label2)
        Me.CRUD.Location = New System.Drawing.Point(421, 74)
        Me.CRUD.Name = "CRUD"
        Me.CRUD.Size = New System.Drawing.Size(543, 432)
        Me.CRUD.TabIndex = 18
        Me.CRUD.TabStop = False
        Me.CRUD.Text = "Form"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(115, 89)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(386, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(115, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(386, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Satpam"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd MMMM yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 268)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(386, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(386, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'btnBTL
        '
        Me.btnBTL.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnBTL.FlatAppearance.BorderSize = 0
        Me.btnBTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBTL.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBTL.Location = New System.Drawing.Point(25, 382)
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
        Me.btnSV.Location = New System.Drawing.Point(426, 392)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSV.TabIndex = 11
        Me.btnSV.Text = "Simpan"
        Me.btnSV.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jam Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipe Kendaraan"
        '
        'tbNO
        '
        Me.tbNO.Location = New System.Drawing.Point(115, 332)
        Me.tbNO.MaxLength = 19
        Me.tbNO.Name = "tbNO"
        Me.tbNO.Size = New System.Drawing.Size(386, 20)
        Me.tbNO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 335)
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
        Me.tbNM.Size = New System.Drawing.Size(386, 20)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kendaraan Masuk"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(397, 91)
        Me.DataGridView1.TabIndex = 20
        '
        'Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 569)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CRUD)
        Me.Name = "Masuk"
        Me.Text = "Masuk"
        Me.CRUD.ResumeLayout(False)
        Me.CRUD.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRUD As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnBTL As Button
    Friend WithEvents btnSV As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
