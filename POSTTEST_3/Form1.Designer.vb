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
        picFoto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggal = New DateTimePicker()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbMenari = New CheckBox()
        cbFotografi = New CheckBox()
        cbMenulis = New CheckBox()
        cbMemancing = New CheckBox()
        cbCoding = New CheckBox()
        cbMusik = New CheckBox()
        cbTraveling = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbGaming = New CheckBox()
        btnBrowser = New Button()
        btnCetak = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobby.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.White
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(77, 75)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(175, 181)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(293, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(293, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(293, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(293, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 4
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(293, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 5
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(442, 79)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(279, 23)
        txtNama.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(442, 119)
        txtUmur.MaxLength = 3
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(279, 23)
        txtUmur.TabIndex = 7
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(442, 157)
        txtTelepon.MaxLength = 15
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(279, 23)
        txtTelepon.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(442, 233)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(279, 23)
        txtAlamat.TabIndex = 9
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(442, 195)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(279, 23)
        dtpTanggal.TabIndex = 10
        ' 
        ' gbGender
        ' 
        gbGender.BackColor = Color.Transparent
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbGender.Location = New Point(77, 303)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(175, 73)
        gbGender.TabIndex = 11
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPerempuan.Location = New Point(21, 47)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLaki.Location = New Point(21, 22)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(78, 19)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = Color.Transparent
        gbHobby.Controls.Add(cbMenari)
        gbHobby.Controls.Add(cbFotografi)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbMemancing)
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbMusik)
        gbHobby.Controls.Add(cbTraveling)
        gbHobby.Controls.Add(cbOlahraga)
        gbHobby.Controls.Add(cbMembaca)
        gbHobby.Controls.Add(cbGaming)
        gbHobby.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobby.Location = New Point(293, 277)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(428, 148)
        gbHobby.TabIndex = 12
        gbHobby.TabStop = False
        gbHobby.Text = "Hobi"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMenari.Location = New Point(315, 80)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(63, 19)
        cbMenari.TabIndex = 16
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbFotografi.Location = New Point(315, 49)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(74, 19)
        cbFotografi.TabIndex = 15
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMenulis.Location = New Point(315, 22)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(68, 19)
        cbMenulis.TabIndex = 14
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMemancing.Location = New Point(167, 80)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(90, 19)
        cbMemancing.TabIndex = 13
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCoding.Location = New Point(167, 49)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(65, 19)
        cbCoding.TabIndex = 5
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMusik.Location = New Point(167, 22)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(58, 19)
        cbMusik.TabIndex = 4
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTraveling.Location = New Point(19, 109)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(73, 19)
        cbTraveling.TabIndex = 3
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbOlahraga.Location = New Point(19, 80)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(74, 19)
        cbOlahraga.TabIndex = 2
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMembaca.Location = New Point(19, 49)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(79, 19)
        cbMembaca.TabIndex = 1
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGaming.Location = New Point(19, 22)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(68, 19)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' btnBrowser
        ' 
        btnBrowser.Location = New Point(112, 262)
        btnBrowser.Name = "btnBrowser"
        btnBrowser.Size = New Size(107, 23)
        btnBrowser.TabIndex = 13
        btnBrowser.Text = "Tambah Foto"
        btnBrowser.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnCetak.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(77, 389)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(175, 36)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-6, -29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(814, 83)
        Panel1.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(252, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(329, 30)
        Label6.TabIndex = 0
        Label6.Text = "FORMULIR KARTU KOMUNITAS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(gbHobby)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowser)
        Controls.Add(gbGender)
        Controls.Add(dtpTanggal)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picFoto)
        Name = "Form1"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents btnBrowser As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label


End Class
