Imports System.Text

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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TabControl1 = New TabControl()
        tabDataUtama = New TabPage()
        btnKeTab2 = New Button()
        Label2 = New Label()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        cmbKomunitas = New ComboBox()
        GroupBox1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        Label4 = New Label()
        Label3 = New Label()
        lblNama = New Label()
        tabKontak = New TabPage()
        btnKeTab3 = New Button()
        btnKembaliKeTab1 = New Button()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        tabProfil = New TabPage()
        btnCetakKartu = New Button()
        btnKembaliKeTab2 = New Button()
        btnSimpan = New Button()
        grpAktivitas = New GroupBox()
        cbNetworking = New CheckBox()
        cbPublicSpeaking = New CheckBox()
        cbMenulis = New CheckBox()
        cbFotografi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbGaming = New CheckBox()
        cbEditingVideo = New CheckBox()
        cbDesainGrafis = New CheckBox()
        cbCoding = New CheckBox()
        grpPeran = New GroupBox()
        rbLainnya = New RadioButton()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbBendahara = New RadioButton()
        rbSekretaris = New RadioButton()
        rbWakilKetua = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowser = New Button()
        picFoto = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tabDataUtama.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        grpAktivitas.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(584, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(76, 20)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimToolStripMenuItem
        ' 
        SimToolStripMenuItem.Name = "SimToolStripMenuItem"
        SimToolStripMenuItem.Size = New Size(86, 20)
        SimToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(72, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(584, 60)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo_Komunitas1
        PictureBox1.Location = New Point(167, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(213, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kartu Komunitas Digital"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabDataUtama)
        TabControl1.Controls.Add(tabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.ItemSize = New Size(120, 36)
        TabControl1.Location = New Point(0, 84)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(584, 377)
        TabControl1.TabIndex = 2
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = SystemColors.InactiveCaption
        tabDataUtama.Controls.Add(btnKeTab2)
        tabDataUtama.Controls.Add(Label2)
        tabDataUtama.Controls.Add(dtpLahir)
        tabDataUtama.Controls.Add(txtID)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(cmbKomunitas)
        tabDataUtama.Controls.Add(GroupBox1)
        tabDataUtama.Controls.Add(Label4)
        tabDataUtama.Controls.Add(Label3)
        tabDataUtama.Controls.Add(lblNama)
        tabDataUtama.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabDataUtama.Location = New Point(4, 40)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(576, 333)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        ' 
        ' btnKeTab2
        ' 
        btnKeTab2.BackColor = Color.Gold
        btnKeTab2.Location = New Point(448, 280)
        btnKeTab2.Name = "btnKeTab2"
        btnKeTab2.Size = New Size(90, 27)
        btnKeTab2.TabIndex = 9
        btnKeTab2.Text = "Selanjutnya"
        btnKeTab2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 8
        Label2.Text = "Komunitas"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(43, 96)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(495, 23)
        dtpLahir.TabIndex = 7
        ' 
        ' txtID
        ' 
        txtID.BackColor = SystemColors.Window
        txtID.Location = New Point(308, 45)
        txtID.MaxLength = 10
        txtID.Name = "txtID"
        txtID.PlaceholderText = "2409106019"
        txtID.Size = New Size(230, 23)
        txtID.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.Window
        txtNama.Location = New Point(43, 45)
        txtNama.MaxLength = 35
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan nama lengkap...."
        txtNama.Size = New Size(230, 23)
        txtNama.TabIndex = 5
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.BackColor = SystemColors.Window
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Seni & Budaya", "Olahraga", "Literasi & Menulis", "Musik", "Fotografi", "Game", "Sosial & Lingkungan", "Teknologi", "Desain Grafis", "Komunitas Coding"})
        cmbKomunitas.Location = New Point(43, 235)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(495, 23)
        cmbKomunitas.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Window
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLakiLaki)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(43, 132)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(495, 72)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 9F)
        rbPerempuan.Location = New Point(11, 44)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Font = New Font("Segoe UI", 9F)
        rbLakiLaki.Location = New Point(11, 19)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(78, 19)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki - Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(299, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 2
        Label4.Text = "ID Anggota"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 1
        Label3.Text = "Tanggal Lahir"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(38, 27)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(87, 15)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' tabKontak
        ' 
        tabKontak.BackColor = SystemColors.InactiveCaption
        tabKontak.Controls.Add(btnKeTab3)
        tabKontak.Controls.Add(btnKembaliKeTab1)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(mtbTelepon)
        tabKontak.Controls.Add(Label7)
        tabKontak.Controls.Add(Label6)
        tabKontak.Controls.Add(Label5)
        tabKontak.Location = New Point(4, 40)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(576, 333)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        ' 
        ' btnKeTab3
        ' 
        btnKeTab3.BackColor = Color.Gold
        btnKeTab3.Location = New Point(445, 232)
        btnKeTab3.Name = "btnKeTab3"
        btnKeTab3.Size = New Size(90, 27)
        btnKeTab3.TabIndex = 7
        btnKeTab3.Text = "Selanjutnya"
        btnKeTab3.UseVisualStyleBackColor = False
        ' 
        ' btnKembaliKeTab1
        ' 
        btnKembaliKeTab1.BackColor = Color.WhiteSmoke
        btnKembaliKeTab1.Location = New Point(364, 232)
        btnKembaliKeTab1.Name = "btnKembaliKeTab1"
        btnKembaliKeTab1.Size = New Size(75, 27)
        btnKembaliKeTab1.TabIndex = 6
        btnKembaliKeTab1.Text = "Kembali"
        btnKembaliKeTab1.UseVisualStyleBackColor = False
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = SystemColors.Window
        txtAlamat.Location = New Point(43, 149)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Masukkan alamat lengkap..."
        txtAlamat.ScrollBars = ScrollBars.Vertical
        txtAlamat.Size = New Size(492, 60)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Window
        txtEmail.Location = New Point(43, 96)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Contoh@gmail.com"
        txtEmail.Size = New Size(492, 23)
        txtEmail.TabIndex = 4
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.BackColor = SystemColors.Window
        mtbTelepon.Location = New Point(43, 45)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(492, 23)
        mtbTelepon.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(38, 131)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 15)
        Label7.TabIndex = 2
        Label7.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(38, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 1
        Label6.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 0
        Label5.Text = "Nomor Telepon"
        ' 
        ' tabProfil
        ' 
        tabProfil.BackColor = SystemColors.InactiveCaption
        tabProfil.Controls.Add(btnCetakKartu)
        tabProfil.Controls.Add(btnKembaliKeTab2)
        tabProfil.Controls.Add(btnSimpan)
        tabProfil.Controls.Add(grpAktivitas)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(btnBrowser)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(4, 40)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(576, 333)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.BackColor = Color.CornflowerBlue
        btnCetakKartu.Location = New Point(458, 279)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(81, 27)
        btnCetakKartu.TabIndex = 10
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = False
        ' 
        ' btnKembaliKeTab2
        ' 
        btnKembaliKeTab2.BackColor = Color.WhiteSmoke
        btnKembaliKeTab2.Location = New Point(309, 279)
        btnKembaliKeTab2.Name = "btnKembaliKeTab2"
        btnKembaliKeTab2.Size = New Size(75, 27)
        btnKembaliKeTab2.TabIndex = 9
        btnKembaliKeTab2.Text = "Kembali"
        btnKembaliKeTab2.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Gold
        btnSimpan.Location = New Point(384, 279)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(74, 27)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' grpAktivitas
        ' 
        grpAktivitas.BackColor = SystemColors.Window
        grpAktivitas.Controls.Add(cbNetworking)
        grpAktivitas.Controls.Add(cbPublicSpeaking)
        grpAktivitas.Controls.Add(cbMenulis)
        grpAktivitas.Controls.Add(cbFotografi)
        grpAktivitas.Controls.Add(cbOlahraga)
        grpAktivitas.Controls.Add(cbMusik)
        grpAktivitas.Controls.Add(cbGaming)
        grpAktivitas.Controls.Add(cbEditingVideo)
        grpAktivitas.Controls.Add(cbDesainGrafis)
        grpAktivitas.Controls.Add(cbCoding)
        grpAktivitas.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpAktivitas.Location = New Point(164, 137)
        grpAktivitas.Name = "grpAktivitas"
        grpAktivitas.Size = New Size(375, 127)
        grpAktivitas.TabIndex = 3
        grpAktivitas.TabStop = False
        grpAktivitas.Text = "Aktivitas / Hobi"
        ' 
        ' cbNetworking
        ' 
        cbNetworking.AutoSize = True
        cbNetworking.Font = New Font("Segoe UI", 9F)
        cbNetworking.Location = New Point(254, 72)
        cbNetworking.Name = "cbNetworking"
        cbNetworking.Size = New Size(88, 19)
        cbNetworking.TabIndex = 9
        cbNetworking.Text = "Networking"
        cbNetworking.UseVisualStyleBackColor = True
        ' 
        ' cbPublicSpeaking
        ' 
        cbPublicSpeaking.AutoSize = True
        cbPublicSpeaking.Font = New Font("Segoe UI", 9F)
        cbPublicSpeaking.Location = New Point(254, 47)
        cbPublicSpeaking.Name = "cbPublicSpeaking"
        cbPublicSpeaking.Size = New Size(110, 19)
        cbPublicSpeaking.TabIndex = 8
        cbPublicSpeaking.Text = "Public Speaking"
        cbPublicSpeaking.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Segoe UI", 9F)
        cbMenulis.Location = New Point(254, 22)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(68, 19)
        cbMenulis.TabIndex = 7
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Font = New Font("Segoe UI", 9F)
        cbFotografi.Location = New Point(139, 47)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(74, 19)
        cbFotografi.TabIndex = 6
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Segoe UI", 9F)
        cbOlahraga.Location = New Point(139, 22)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(74, 19)
        cbOlahraga.TabIndex = 5
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Font = New Font("Segoe UI", 9F)
        cbMusik.Location = New Point(139, 72)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(58, 19)
        cbMusik.TabIndex = 4
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Segoe UI", 9F)
        cbGaming.Location = New Point(16, 97)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(68, 19)
        cbGaming.TabIndex = 3
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbEditingVideo
        ' 
        cbEditingVideo.AutoSize = True
        cbEditingVideo.Font = New Font("Segoe UI", 9F)
        cbEditingVideo.Location = New Point(16, 72)
        cbEditingVideo.Name = "cbEditingVideo"
        cbEditingVideo.Size = New Size(96, 19)
        cbEditingVideo.TabIndex = 2
        cbEditingVideo.Text = "Editing Video"
        cbEditingVideo.UseVisualStyleBackColor = True
        ' 
        ' cbDesainGrafis
        ' 
        cbDesainGrafis.AutoSize = True
        cbDesainGrafis.Font = New Font("Segoe UI", 9F)
        cbDesainGrafis.Location = New Point(16, 47)
        cbDesainGrafis.Name = "cbDesainGrafis"
        cbDesainGrafis.Size = New Size(94, 19)
        cbDesainGrafis.TabIndex = 1
        cbDesainGrafis.Text = "Desain Grafis"
        cbDesainGrafis.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Segoe UI", 9F)
        cbCoding.Location = New Point(16, 22)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(65, 19)
        cbCoding.TabIndex = 0
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.BackColor = SystemColors.Window
        grpPeran.Controls.Add(rbLainnya)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbBendahara)
        grpPeran.Controls.Add(rbSekretaris)
        grpPeran.Controls.Add(rbWakilKetua)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPeran.Location = New Point(164, 27)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(375, 100)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran dalam Komunitas"
        ' 
        ' rbLainnya
        ' 
        rbLainnya.AutoSize = True
        rbLainnya.Font = New Font("Segoe UI", 9F)
        rbLainnya.Location = New Point(254, 19)
        rbLainnya.Name = "rbLainnya"
        rbLainnya.Size = New Size(66, 19)
        rbLainnya.TabIndex = 6
        rbLainnya.TabStop = True
        rbLainnya.Text = "Lainnya"
        rbLainnya.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Font = New Font("Segoe UI", 9F)
        rbAdmin.Location = New Point(139, 44)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(61, 19)
        rbAdmin.TabIndex = 5
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Font = New Font("Segoe UI", 9F)
        rbAnggota.Location = New Point(139, 69)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(71, 19)
        rbAnggota.TabIndex = 4
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbBendahara
        ' 
        rbBendahara.AutoSize = True
        rbBendahara.Font = New Font("Segoe UI", 9F)
        rbBendahara.Location = New Point(139, 19)
        rbBendahara.Name = "rbBendahara"
        rbBendahara.Size = New Size(81, 19)
        rbBendahara.TabIndex = 3
        rbBendahara.TabStop = True
        rbBendahara.Text = "Bendahara"
        rbBendahara.UseVisualStyleBackColor = True
        ' 
        ' rbSekretaris
        ' 
        rbSekretaris.AutoSize = True
        rbSekretaris.Font = New Font("Segoe UI", 9F)
        rbSekretaris.Location = New Point(16, 69)
        rbSekretaris.Name = "rbSekretaris"
        rbSekretaris.Size = New Size(75, 19)
        rbSekretaris.TabIndex = 2
        rbSekretaris.TabStop = True
        rbSekretaris.Text = "Sekretaris"
        rbSekretaris.UseVisualStyleBackColor = True
        ' 
        ' rbWakilKetua
        ' 
        rbWakilKetua.AutoSize = True
        rbWakilKetua.Font = New Font("Segoe UI", 9F)
        rbWakilKetua.Location = New Point(16, 44)
        rbWakilKetua.Name = "rbWakilKetua"
        rbWakilKetua.Size = New Size(87, 19)
        rbWakilKetua.TabIndex = 1
        rbWakilKetua.TabStop = True
        rbWakilKetua.Text = "Wakil Ketua"
        rbWakilKetua.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Font = New Font("Segoe UI", 9F)
        rbKetua.Location = New Point(16, 19)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(55, 19)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowser
        ' 
        btnBrowser.Location = New Point(51, 137)
        btnBrowser.Name = "btnBrowser"
        btnBrowser.Size = New Size(75, 23)
        btnBrowser.TabIndex = 1
        btnBrowser.Text = "Pilih Foto"
        btnBrowser.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = SystemColors.Window
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(38, 27)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(100, 100)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(584, 461)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        grpAktivitas.ResumeLayout(False)
        grpAktivitas.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKeTab3 As Button
    Friend WithEvents btnKembaliKeTab1 As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeTab2 As Button
    Friend WithEvents grpAktivitas As GroupBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rbWakilKetua As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowser As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbBendahara As RadioButton
    Friend WithEvents rbSekretaris As RadioButton
    Friend WithEvents cbNetworking As CheckBox
    Friend WithEvents cbPublicSpeaking As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbEditingVideo As CheckBox
    Friend WithEvents cbDesainGrafis As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents rbLainnya As RadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnKembaliKeTab2 As Button
    Friend WithEvents btnCetakKartu As Button

End Class
