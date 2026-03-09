<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        Label2 = New Label()
        txtJudul = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        dgvBuku = New DataGridView()
        colJudul = New DataGridViewTextBoxColumn()
        colGenre = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtJudul)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(98, 126)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 152)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(212, 113)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(61, 21)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(118, 73)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(155, 25)
        txtGenre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 2
        Label2.Text = "Genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(118, 32)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(155, 25)
        txtJudul.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(98, 297)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(294, 109)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.LightCoral
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(212, 71)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(61, 22)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(118, 30)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(155, 25)
        txtHapus.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(201, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(421, 37)
        Label4.TabIndex = 3
        Label4.Text = "DAFTAR BUKU PERPUSTAKAAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(449, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 17)
        Label5.TabIndex = 4
        Label5.Text = "Daftar Buku"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-4, -19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(814, 109)
        Panel1.TabIndex = 5
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {colJudul, colGenre})
        dgvBuku.Location = New Point(459, 158)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(240, 248)
        dgvBuku.TabIndex = 6
        ' 
        ' colJudul
        ' 
        colJudul.HeaderText = "Judul Buku"
        colJudul.Name = "colJudul"
        ' 
        ' colGenre
        ' 
        colGenre.HeaderText = "Genre"
        colGenre.Name = "colGenre"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 450)
        Controls.Add(dgvBuku)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents colJudul As DataGridViewTextBoxColumn
    Friend WithEvents colGenre As DataGridViewTextBoxColumn

End Class
