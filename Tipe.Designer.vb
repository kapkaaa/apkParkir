<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipe))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRUD = New System.Windows.Forms.GroupBox()
        Me.btnHPS = New System.Windows.Forms.Button()
        Me.btnBTL = New System.Windows.Forms.Button()
        Me.btnSV = New System.Windows.Forms.Button()
        Me.tbNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CRUD.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 100)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(100, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Master Kendaraan"
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(620, 255)
        Me.DataGridView1.TabIndex = 21
        '
        'CRUD
        '
        Me.CRUD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRUD.Controls.Add(Me.btnHPS)
        Me.CRUD.Controls.Add(Me.btnBTL)
        Me.CRUD.Controls.Add(Me.btnSV)
        Me.CRUD.Controls.Add(Me.tbNO)
        Me.CRUD.Controls.Add(Me.Label3)
        Me.CRUD.Controls.Add(Me.tbNM)
        Me.CRUD.Controls.Add(Me.Label2)
        Me.CRUD.Location = New System.Drawing.Point(638, 205)
        Me.CRUD.Name = "CRUD"
        Me.CRUD.Size = New System.Drawing.Size(284, 255)
        Me.CRUD.TabIndex = 20
        Me.CRUD.TabStop = False
        Me.CRUD.Text = "Form"
        '
        'btnHPS
        '
        Me.btnHPS.BackColor = System.Drawing.Color.Red
        Me.btnHPS.FlatAppearance.BorderSize = 0
        Me.btnHPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHPS.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHPS.Location = New System.Drawing.Point(193, 197)
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
        Me.btnBTL.Location = New System.Drawing.Point(105, 197)
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
        Me.btnSV.Location = New System.Drawing.Point(15, 197)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSV.TabIndex = 11
        Me.btnSV.Text = "Simpan"
        Me.btnSV.UseVisualStyleBackColor = False
        '
        'tbNO
        '
        Me.tbNO.Location = New System.Drawing.Point(91, 105)
        Me.tbNO.MaxLength = 19
        Me.tbNO.Name = "tbNO"
        Me.tbNO.Size = New System.Drawing.Size(147, 20)
        Me.tbNO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'tbNM
        '
        Me.tbNM.Location = New System.Drawing.Point(91, 68)
        Me.tbNM.Name = "tbNM"
        Me.tbNM.Size = New System.Drawing.Size(147, 20)
        Me.tbNM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Tipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 537)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CRUD)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tipe"
        Me.Text = "Tipe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CRUD.ResumeLayout(False)
        Me.CRUD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CRUD As GroupBox
    Friend WithEvents btnHPS As Button
    Friend WithEvents btnBTL As Button
    Friend WithEvents btnSV As Button
    Friend WithEvents tbNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNM As TextBox
    Friend WithEvents Label2 As Label
End Class
