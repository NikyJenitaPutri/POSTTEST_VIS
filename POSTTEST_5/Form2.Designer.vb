<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblSub = New Label()
        lblTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtJudul = New TextBox()
        txtDeskripsi = New TextBox()
        dtpTanggal = New DateTimePicker()
        dtpDeadline = New DateTimePicker()
        cmbStatus = New ComboBox()
        grpPrioritas = New GroupBox()
        rbTinggi = New RadioButton()
        rbSedang = New RadioButton()
        rbRendah = New RadioButton()
        pnlFooter = New Panel()
        btnSimpan = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        grpPrioritas.SuspendLayout()
        pnlFooter.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Olive
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(484, 72)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.BackColor = Color.Transparent
        lblSub.ForeColor = Color.FromArgb(CByte(255), CByte(201), CByte(160))
        lblSub.Location = New Point(25, 42)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(186, 15)
        lblSub.TabIndex = 1
        lblSub.Text = "Lengkapi semua data di bawah ini"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(18, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(236, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Tambah Tugas Baru"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(18, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 1
        Label1.Text = "JUDUL TUGAS *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(18, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 2
        Label2.Text = "DESKRIPSI *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(18, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 15)
        Label3.TabIndex = 3
        Label3.Text = "TANGGAL DIBUAT *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(247, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 4
        Label4.Text = "DEADLINE *"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(18, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 5
        Label5.Text = "STATUS *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(18, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 6
        Label6.Text = "PRIORITAS *"
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(34, 106)
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "Masukkan judul tugas..."
        txtJudul.Size = New Size(430, 23)
        txtJudul.TabIndex = 7
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.Location = New Point(34, 172)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Deskripsi singkat tugas..."
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(430, 58)
        txtDeskripsi.TabIndex = 8
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CustomFormat = ""
        dtpTanggal.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(34, 258)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 25)
        dtpTanggal.TabIndex = 9
        ' 
        ' dtpDeadline
        ' 
        dtpDeadline.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDeadline.Format = DateTimePickerFormat.Short
        dtpDeadline.Location = New Point(264, 258)
        dtpDeadline.Name = "dtpDeadline"
        dtpDeadline.Size = New Size(200, 25)
        dtpDeadline.TabIndex = 10
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FlatStyle = FlatStyle.Flat
        cmbStatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Belum Selesai", "Proses", "Selesai"})
        cmbStatus.Location = New Point(34, 326)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(430, 23)
        cmbStatus.TabIndex = 11
        ' 
        ' grpPrioritas
        ' 
        grpPrioritas.BackColor = Color.White
        grpPrioritas.Controls.Add(rbTinggi)
        grpPrioritas.Controls.Add(rbSedang)
        grpPrioritas.Controls.Add(rbRendah)
        grpPrioritas.FlatStyle = FlatStyle.Flat
        grpPrioritas.Location = New Point(34, 392)
        grpPrioritas.Name = "grpPrioritas"
        grpPrioritas.Size = New Size(430, 52)
        grpPrioritas.TabIndex = 12
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
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(247))
        pnlFooter.Controls.Add(btnSimpan)
        pnlFooter.Controls.Add(btnBatal)
        pnlFooter.Controls.Add(btnHapus)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 523)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(484, 58)
        pnlFooter.TabIndex = 14
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Olive
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(296, 14)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(90, 32)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan Tugas"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.Black
        btnBatal.Location = New Point(392, 14)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(72, 32)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.Olive
        btnHapus.Location = New Point(170, 14)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 32)
        btnHapus.TabIndex = 0
        btnHapus.Text = "Hapus Tugas"
        btnHapus.UseVisualStyleBackColor = False
        btnHapus.Visible = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        ClientSize = New Size(484, 581)
        Controls.Add(pnlFooter)
        Controls.Add(grpPrioritas)
        Controls.Add(cmbStatus)
        Controls.Add(dtpDeadline)
        Controls.Add(dtpTanggal)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtJudul)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MaximumSize = New Size(500, 620)
        MinimizeBox = False
        MinimumSize = New Size(500, 620)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form CRUD"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        grpPrioritas.ResumeLayout(False)
        grpPrioritas.PerformLayout()
        pnlFooter.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSub As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents dtpDeadline As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents grpPrioritas As GroupBox
    Friend WithEvents rbTinggi As RadioButton
    Friend WithEvents rbSedang As RadioButton
    Friend WithEvents rbRendah As RadioButton
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
