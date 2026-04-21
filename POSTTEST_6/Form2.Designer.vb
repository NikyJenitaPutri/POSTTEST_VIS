<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        btnTutup = New Button()
        btnKeluar = New Button()
        lblJudul = New Label()
        pnlStats = New Panel()
        pnlStatBelum = New Panel()
        PictureBox2 = New PictureBox()
        lblBelumVal = New Label()
        Label7 = New Label()
        pnlStatProses = New Panel()
        PictureBox4 = New PictureBox()
        lblProsesVal = New Label()
        Label9 = New Label()
        pnlStatSelesai = New Panel()
        PictureBox3 = New PictureBox()
        lblSelesaiVal = New Label()
        Label11 = New Label()
        pnlStatTotal = New Panel()
        PictureBox1 = New PictureBox()
        lblTotalVal = New Label()
        Label1 = New Label()
        txtSearch = New TextBox()
        pnlForm = New Panel()
        btnRefresh = New Button()
        cmbMatkul = New ComboBox()
        Label10 = New Label()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        grpPrioritas = New GroupBox()
        rbTinggi = New RadioButton()
        rbSedang = New RadioButton()
        rbRendah = New RadioButton()
        cmbStatus = New ComboBox()
        Label6 = New Label()
        Label8 = New Label()
        dtpDeadline = New DateTimePicker()
        dtpTanggal = New DateTimePicker()
        txtDeskripsi = New TextBox()
        txtJudul = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        dgvTugas = New DataGridView()
        pnlSearch = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        pnlStats.SuspendLayout()
        pnlStatBelum.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatProses.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatSelesai.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatTotal.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlForm.SuspendLayout()
        grpPrioritas.SuspendLayout()
        CType(dgvTugas, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearch.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Olive
        pnlHeader.Controls.Add(btnTutup)
        pnlHeader.Controls.Add(btnKeluar)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(864, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Maroon
        btnTutup.Cursor = Cursors.Hand
        btnTutup.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(683, 14)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(72, 32)
        btnTutup.TabIndex = 29
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.Olive
        btnKeluar.Location = New Point(761, 13)
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
        ' pnlStats
        ' 
        pnlStats.Controls.Add(pnlStatBelum)
        pnlStats.Controls.Add(pnlStatProses)
        pnlStats.Controls.Add(pnlStatSelesai)
        pnlStats.Controls.Add(pnlStatTotal)
        pnlStats.Dock = DockStyle.Top
        pnlStats.Location = New Point(0, 60)
        pnlStats.Name = "pnlStats"
        pnlStats.Padding = New Padding(14, 10, 14, 10)
        pnlStats.Size = New Size(864, 80)
        pnlStats.TabIndex = 1
        ' 
        ' pnlStatBelum
        ' 
        pnlStatBelum.BackColor = Color.White
        pnlStatBelum.Controls.Add(PictureBox2)
        pnlStatBelum.Controls.Add(lblBelumVal)
        pnlStatBelum.Controls.Add(Label7)
        pnlStatBelum.Location = New Point(238, 13)
        pnlStatBelum.Name = "pnlStatBelum"
        pnlStatBelum.Size = New Size(175, 56)
        pnlStatBelum.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.belum
        PictureBox2.Location = New Point(23, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' lblBelumVal
        ' 
        lblBelumVal.AutoSize = True
        lblBelumVal.BackColor = Color.Transparent
        lblBelumVal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBelumVal.Location = New Point(75, 5)
        lblBelumVal.Name = "lblBelumVal"
        lblBelumVal.Size = New Size(21, 30)
        lblBelumVal.TabIndex = 1
        lblBelumVal.Text = "-"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(75, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 17)
        Label7.TabIndex = 0
        Label7.Text = "Belum Selesai"
        ' 
        ' pnlStatProses
        ' 
        pnlStatProses.BackColor = Color.White
        pnlStatProses.Controls.Add(PictureBox4)
        pnlStatProses.Controls.Add(lblProsesVal)
        pnlStatProses.Controls.Add(Label9)
        pnlStatProses.Location = New Point(448, 13)
        pnlStatProses.Name = "pnlStatProses"
        pnlStatProses.Size = New Size(175, 56)
        pnlStatProses.TabIndex = 3
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.proses
        PictureBox4.Location = New Point(23, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' lblProsesVal
        ' 
        lblProsesVal.AutoSize = True
        lblProsesVal.BackColor = Color.Transparent
        lblProsesVal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProsesVal.Location = New Point(75, 5)
        lblProsesVal.Name = "lblProsesVal"
        lblProsesVal.Size = New Size(21, 30)
        lblProsesVal.TabIndex = 1
        lblProsesVal.Text = "-"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlDarkDark
        Label9.Location = New Point(79, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 17)
        Label9.TabIndex = 0
        Label9.Text = "Proses"
        ' 
        ' pnlStatSelesai
        ' 
        pnlStatSelesai.BackColor = Color.White
        pnlStatSelesai.Controls.Add(PictureBox3)
        pnlStatSelesai.Controls.Add(lblSelesaiVal)
        pnlStatSelesai.Controls.Add(Label11)
        pnlStatSelesai.Location = New Point(658, 13)
        pnlStatSelesai.Name = "pnlStatSelesai"
        pnlStatSelesai.Size = New Size(175, 56)
        pnlStatSelesai.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.selesai
        PictureBox3.Location = New Point(23, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' lblSelesaiVal
        ' 
        lblSelesaiVal.AutoSize = True
        lblSelesaiVal.BackColor = Color.Transparent
        lblSelesaiVal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelesaiVal.Location = New Point(79, 5)
        lblSelesaiVal.Name = "lblSelesaiVal"
        lblSelesaiVal.Size = New Size(21, 30)
        lblSelesaiVal.TabIndex = 1
        lblSelesaiVal.Text = "-"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlDarkDark
        Label11.Location = New Point(79, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 17)
        Label11.TabIndex = 0
        Label11.Text = "Selesai"
        ' 
        ' pnlStatTotal
        ' 
        pnlStatTotal.BackColor = Color.White
        pnlStatTotal.Controls.Add(PictureBox1)
        pnlStatTotal.Controls.Add(lblTotalVal)
        pnlStatTotal.Controls.Add(Label1)
        pnlStatTotal.Location = New Point(29, 13)
        pnlStatTotal.Name = "pnlStatTotal"
        pnlStatTotal.Size = New Size(175, 56)
        pnlStatTotal.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.total
        PictureBox1.Location = New Point(23, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblTotalVal
        ' 
        lblTotalVal.AutoSize = True
        lblTotalVal.BackColor = Color.Transparent
        lblTotalVal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalVal.Location = New Point(79, 5)
        lblTotalVal.Name = "lblTotalVal"
        lblTotalVal.Size = New Size(21, 30)
        lblTotalVal.TabIndex = 1
        lblTotalVal.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(79, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 17)
        Label1.TabIndex = 0
        Label1.Text = "Semua"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(29, 10)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari tugas..."
        txtSearch.Size = New Size(804, 25)
        txtSearch.TabIndex = 1
        ' 
        ' pnlForm
        ' 
        pnlForm.Controls.Add(btnRefresh)
        pnlForm.Controls.Add(cmbMatkul)
        pnlForm.Controls.Add(Label10)
        pnlForm.Controls.Add(btnSimpan)
        pnlForm.Controls.Add(btnUbah)
        pnlForm.Controls.Add(btnHapus)
        pnlForm.Controls.Add(grpPrioritas)
        pnlForm.Controls.Add(cmbStatus)
        pnlForm.Controls.Add(Label6)
        pnlForm.Controls.Add(Label8)
        pnlForm.Controls.Add(dtpDeadline)
        pnlForm.Controls.Add(dtpTanggal)
        pnlForm.Controls.Add(txtDeskripsi)
        pnlForm.Controls.Add(txtJudul)
        pnlForm.Controls.Add(Label4)
        pnlForm.Controls.Add(Label3)
        pnlForm.Controls.Add(Label2)
        pnlForm.Controls.Add(Label5)
        pnlForm.Dock = DockStyle.Top
        pnlForm.Location = New Point(0, 140)
        pnlForm.Name = "pnlForm"
        pnlForm.Padding = New Padding(14, 8, 14, 0)
        pnlForm.Size = New Size(864, 197)
        pnlForm.TabIndex = 3
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DarkKhaki
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Location = New Point(758, 147)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(72, 32)
        btnRefresh.TabIndex = 28
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' cmbMatkul
        ' 
        cmbMatkul.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMatkul.FlatStyle = FlatStyle.Flat
        cmbMatkul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbMatkul.FormattingEnabled = True
        cmbMatkul.Location = New Point(464, 24)
        cmbMatkul.Name = "cmbMatkul"
        cmbMatkul.Size = New Size(170, 23)
        cmbMatkul.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label10.Location = New Point(448, 7)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 15)
        Label10.TabIndex = 26
        Label10.Text = "MATA KULIAH  *"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Olive
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(522, 147)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(72, 32)
        btnSimpan.TabIndex = 25
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
        btnUbah.Location = New Point(600, 147)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(72, 32)
        btnUbah.TabIndex = 24
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Maroon
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(680, 147)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(72, 32)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' grpPrioritas
        ' 
        grpPrioritas.BackColor = Color.White
        grpPrioritas.Controls.Add(rbTinggi)
        grpPrioritas.Controls.Add(rbSedang)
        grpPrioritas.Controls.Add(rbRendah)
        grpPrioritas.FlatStyle = FlatStyle.Flat
        grpPrioritas.Location = New Point(464, 79)
        grpPrioritas.Name = "grpPrioritas"
        grpPrioritas.Size = New Size(368, 45)
        grpPrioritas.TabIndex = 22
        grpPrioritas.TabStop = False
        ' 
        ' rbTinggi
        ' 
        rbTinggi.AutoSize = True
        rbTinggi.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbTinggi.ForeColor = Color.FromArgb(CByte(153), CByte(27), CByte(27))
        rbTinggi.Location = New Point(304, 16)
        rbTinggi.Name = "rbTinggi"
        rbTinggi.Size = New Size(62, 21)
        rbTinggi.TabIndex = 2
        rbTinggi.TabStop = True
        rbTinggi.Text = "Tinggi"
        rbTinggi.UseVisualStyleBackColor = True
        ' 
        ' rbSedang
        ' 
        rbSedang.AutoSize = True
        rbSedang.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSedang.ForeColor = Color.FromArgb(CByte(146), CByte(64), CByte(14))
        rbSedang.Location = New Point(160, 16)
        rbSedang.Name = "rbSedang"
        rbSedang.Size = New Size(70, 21)
        rbSedang.TabIndex = 1
        rbSedang.TabStop = True
        rbSedang.Text = "Sedang"
        rbSedang.UseVisualStyleBackColor = True
        ' 
        ' rbRendah
        ' 
        rbRendah.AutoSize = True
        rbRendah.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbRendah.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        rbRendah.Location = New Point(16, 16)
        rbRendah.Name = "rbRendah"
        rbRendah.Size = New Size(70, 21)
        rbRendah.TabIndex = 0
        rbRendah.TabStop = True
        rbRendah.Text = "Rendah"
        rbRendah.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FlatStyle = FlatStyle.Flat
        cmbStatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Belum Selesai", "Proses", "Selesai"})
        cmbStatus.Location = New Point(663, 25)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(170, 23)
        cmbStatus.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(448, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 20
        Label6.Text = "PRIORITAS *"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(646, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 19
        Label8.Text = "STATUS *"
        ' 
        ' dtpDeadline
        ' 
        dtpDeadline.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDeadline.Format = DateTimePickerFormat.Short
        dtpDeadline.Location = New Point(243, 165)
        dtpDeadline.Name = "dtpDeadline"
        dtpDeadline.Size = New Size(170, 25)
        dtpDeadline.TabIndex = 18
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CustomFormat = ""
        dtpTanggal.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(45, 165)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(170, 25)
        dtpTanggal.TabIndex = 17
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.Location = New Point(45, 79)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Deskripsi singkat tugas..."
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(368, 58)
        txtDeskripsi.TabIndex = 16
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(44, 26)
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "Masukkan judul tugas..."
        txtJudul.Size = New Size(369, 23)
        txtJudul.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(228, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 14
        Label4.Text = "DEADLINE *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(29, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 15)
        Label3.TabIndex = 13
        Label3.Text = "TANGGAL DIBUAT *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(29, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 12
        Label2.Text = "DESKRIPSI *"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(29, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 11
        Label5.Text = "JUDUL TUGAS *"
        ' 
        ' dgvTugas
        ' 
        dgvTugas.AllowUserToAddRows = False
        dgvTugas.AllowUserToDeleteRows = False
        dgvTugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTugas.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvTugas.BorderStyle = BorderStyle.None
        dgvTugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTugas.Location = New Point(29, 389)
        dgvTugas.MultiSelect = False
        dgvTugas.Name = "dgvTugas"
        dgvTugas.ReadOnly = True
        dgvTugas.RowHeadersVisible = False
        dgvTugas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTugas.Size = New Size(804, 100)
        dgvTugas.TabIndex = 0
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 337)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(864, 46)
        pnlSearch.TabIndex = 4
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        ClientSize = New Size(864, 511)
        Controls.Add(dgvTugas)
        Controls.Add(pnlSearch)
        Controls.Add(pnlForm)
        Controls.Add(pnlStats)
        Controls.Add(pnlHeader)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DaftarTugas"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlStats.ResumeLayout(False)
        pnlStatBelum.ResumeLayout(False)
        pnlStatBelum.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlStatProses.ResumeLayout(False)
        pnlStatProses.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlStatSelesai.ResumeLayout(False)
        pnlStatSelesai.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlStatTotal.ResumeLayout(False)
        pnlStatTotal.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        grpPrioritas.ResumeLayout(False)
        grpPrioritas.PerformLayout()
        CType(dgvTugas, ComponentModel.ISupportInitialize).EndInit()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlStatTotal As Panel
    Friend WithEvents lblTotalVal As Label
    Friend WithEvents pnlStatSelesai As Panel
    Friend WithEvents lblSelesaiVal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlStatBelum As Panel
    Friend WithEvents pnlStatProses As Panel
    Friend WithEvents lblProsesVal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBelumVal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents dgvTugas As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlForm As Panel
    Friend WithEvents dtpDeadline As DateTimePicker
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grpPrioritas As GroupBox
    Friend WithEvents rbTinggi As RadioButton
    Friend WithEvents rbSedang As RadioButton
    Friend WithEvents rbRendah As RadioButton
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbMatkul As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnTutup As Button

End Class