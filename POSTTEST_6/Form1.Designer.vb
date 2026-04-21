<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        btnSelanjutnya = New Button()
        btnKeluar = New Button()
        lblJudul = New Label()
        Panel1 = New Panel()
        btnRefresh = New Button()
        btnSimpan = New Button()
        btnUbah = New Button()
        Label6 = New Label()
        txtMatkul = New TextBox()
        btnHapus = New Button()
        txtDosen = New TextBox()
        txtKodeMatkul = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        pnlSearch = New Panel()
        txtSearch = New TextBox()
        dgvMatkul = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
        pnlSearch.SuspendLayout()
        CType(dgvMatkul, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Olive
        pnlHeader.Controls.Add(btnSelanjutnya)
        pnlHeader.Controls.Add(btnKeluar)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(864, 60)
        pnlHeader.TabIndex = 1
        ' 
        ' btnSelanjutnya
        ' 
        btnSelanjutnya.BackColor = Color.White
        btnSelanjutnya.Cursor = Cursors.Hand
        btnSelanjutnya.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnSelanjutnya.FlatStyle = FlatStyle.Flat
        btnSelanjutnya.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelanjutnya.ForeColor = Color.Black
        btnSelanjutnya.Location = New Point(662, 12)
        btnSelanjutnya.Name = "btnSelanjutnya"
        btnSelanjutnya.Size = New Size(93, 34)
        btnSelanjutnya.TabIndex = 29
        btnSelanjutnya.Text = "Selanjutnya"
        btnSelanjutnya.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.Olive
        btnKeluar.Location = New Point(761, 12)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(72, 34)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(29, 18)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(236, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sistem Manajemen Tugas"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(btnUbah)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtMatkul)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(txtDosen)
        Panel1.Controls.Add(txtKodeMatkul)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(864, 134)
        Panel1.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DarkKhaki
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Location = New Point(761, 81)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(72, 32)
        btnRefresh.TabIndex = 29
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Olive
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(523, 81)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(72, 32)
        btnSimpan.TabIndex = 28
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.White
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.ForeColor = Color.Black
        btnUbah.Location = New Point(601, 81)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(72, 32)
        btnUbah.TabIndex = 27
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(29, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 15)
        Label6.TabIndex = 17
        Label6.Text = "MATA KULIAH *"
        ' 
        ' txtMatkul
        ' 
        txtMatkul.Location = New Point(53, 90)
        txtMatkul.Name = "txtMatkul"
        txtMatkul.PlaceholderText = "Masukkan nama mata kuliah..."
        txtMatkul.Size = New Size(360, 23)
        txtMatkul.TabIndex = 18
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Maroon
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(681, 81)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(72, 32)
        btnHapus.TabIndex = 26
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtDosen
        ' 
        txtDosen.Location = New Point(473, 34)
        txtDosen.Name = "txtDosen"
        txtDosen.PlaceholderText = "Masukkan dosen pengampu..."
        txtDosen.Size = New Size(360, 23)
        txtDosen.TabIndex = 20
        ' 
        ' txtKodeMatkul
        ' 
        txtKodeMatkul.Location = New Point(53, 34)
        txtKodeMatkul.Name = "txtKodeMatkul"
        txtKodeMatkul.PlaceholderText = "Masukkan kode mata kuliah..."
        txtKodeMatkul.Size = New Size(360, 23)
        txtKodeMatkul.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(449, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 15)
        Label3.TabIndex = 15
        Label3.Text = "DOSEN PENGAMPU *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(29, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 15)
        Label4.TabIndex = 16
        Label4.Text = "KODE MATA KULIAH *"
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 194)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(864, 46)
        pnlSearch.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(29, 10)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari mata kuliah..."
        txtSearch.Size = New Size(804, 25)
        txtSearch.TabIndex = 4
        ' 
        ' dgvMatkul
        ' 
        dgvMatkul.AllowUserToAddRows = False
        dgvMatkul.AllowUserToDeleteRows = False
        dgvMatkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMatkul.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvMatkul.BorderStyle = BorderStyle.None
        dgvMatkul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMatkul.Location = New Point(29, 263)
        dgvMatkul.MultiSelect = False
        dgvMatkul.Name = "dgvMatkul"
        dgvMatkul.ReadOnly = True
        dgvMatkul.RowHeadersVisible = False
        dgvMatkul.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMatkul.Size = New Size(804, 236)
        dgvMatkul.TabIndex = 1
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        ClientSize = New Size(864, 511)
        Controls.Add(dgvMatkul)
        Controls.Add(pnlSearch)
        Controls.Add(Panel1)
        Controls.Add(pnlHeader)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        CType(dgvMatkul, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDosen As TextBox
    Friend WithEvents txtKodeMatkul As TextBox
    Friend WithEvents txtMatkul As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlTabel As Panel
    Friend WithEvents dgvMatkul As DataGridView
    Friend WithEvents btnSelanjutnya As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnRefresh As Button
End Class
