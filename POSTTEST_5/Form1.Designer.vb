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
        pnlHeader = New Panel()
        btnKeluar = New Button()
        btnTambah = New Button()
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
        pnlSearch = New Panel()
        tabMain = New TabControl()
        tabSemua = New TabPage()
        dgvSemua = New DataGridView()
        tabBelum = New TabPage()
        dgvBelum = New DataGridView()
        tabProses = New TabPage()
        dgvProses = New DataGridView()
        tabSelesai = New TabPage()
        dgvSelesai = New DataGridView()
        tabPrioritas = New TabPage()
        dgvPrioritas = New DataGridView()
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
        pnlSearch.SuspendLayout()
        tabMain.SuspendLayout()
        tabSemua.SuspendLayout()
        CType(dgvSemua, ComponentModel.ISupportInitialize).BeginInit()
        tabBelum.SuspendLayout()
        CType(dgvBelum, ComponentModel.ISupportInitialize).BeginInit()
        tabProses.SuspendLayout()
        CType(dgvProses, ComponentModel.ISupportInitialize).BeginInit()
        tabSelesai.SuspendLayout()
        CType(dgvSelesai, ComponentModel.ISupportInitialize).BeginInit()
        tabPrioritas.SuspendLayout()
        CType(dgvPrioritas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Olive
        pnlHeader.Controls.Add(btnKeluar)
        pnlHeader.Controls.Add(btnTambah)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(864, 60)
        pnlHeader.TabIndex = 0
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
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.White
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnTambah.Location = New Point(644, 13)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(110, 34)
        btnTambah.TabIndex = 1
        btnTambah.Text = "+ Tugas Baru"
        btnTambah.UseVisualStyleBackColor = False
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
        txtSearch.Location = New Point(29, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari judul atau deskripsi..."
        txtSearch.Size = New Size(804, 25)
        txtSearch.TabIndex = 1
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 140)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Padding = New Padding(14, 8, 14, 0)
        pnlSearch.Size = New Size(864, 46)
        pnlSearch.TabIndex = 3
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(tabSemua)
        tabMain.Controls.Add(tabBelum)
        tabMain.Controls.Add(tabProses)
        tabMain.Controls.Add(tabSelesai)
        tabMain.Controls.Add(tabPrioritas)
        tabMain.Dock = DockStyle.Fill
        tabMain.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabMain.ItemSize = New Size(120, 32)
        tabMain.Location = New Point(0, 186)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(864, 264)
        tabMain.SizeMode = TabSizeMode.Fixed
        tabMain.TabIndex = 4
        ' 
        ' tabSemua
        ' 
        tabSemua.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        tabSemua.Controls.Add(dgvSemua)
        tabSemua.Location = New Point(4, 36)
        tabSemua.Name = "tabSemua"
        tabSemua.Padding = New Padding(3)
        tabSemua.Size = New Size(856, 224)
        tabSemua.TabIndex = 0
        tabSemua.Text = "Semua"
        ' 
        ' dgvSemua
        ' 
        dgvSemua.AllowUserToAddRows = False
        dgvSemua.AllowUserToDeleteRows = False
        dgvSemua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSemua.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvSemua.BorderStyle = BorderStyle.None
        dgvSemua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSemua.Location = New Point(25, 3)
        dgvSemua.MultiSelect = False
        dgvSemua.Name = "dgvSemua"
        dgvSemua.ReadOnly = True
        dgvSemua.RowHeadersVisible = False
        dgvSemua.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSemua.Size = New Size(804, 218)
        dgvSemua.TabIndex = 0
        ' 
        ' tabBelum
        ' 
        tabBelum.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        tabBelum.Controls.Add(dgvBelum)
        tabBelum.Location = New Point(4, 36)
        tabBelum.Name = "tabBelum"
        tabBelum.Padding = New Padding(3)
        tabBelum.Size = New Size(856, 224)
        tabBelum.TabIndex = 1
        tabBelum.Text = "Belum Selesai"
        ' 
        ' dgvBelum
        ' 
        dgvBelum.AllowUserToAddRows = False
        dgvBelum.AllowUserToDeleteRows = False
        dgvBelum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBelum.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvBelum.BorderStyle = BorderStyle.None
        dgvBelum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBelum.Location = New Point(25, 3)
        dgvBelum.MultiSelect = False
        dgvBelum.Name = "dgvBelum"
        dgvBelum.ReadOnly = True
        dgvBelum.RowHeadersVisible = False
        dgvBelum.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBelum.Size = New Size(804, 218)
        dgvBelum.TabIndex = 0
        ' 
        ' tabProses
        ' 
        tabProses.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        tabProses.Controls.Add(dgvProses)
        tabProses.Location = New Point(4, 36)
        tabProses.Name = "tabProses"
        tabProses.Padding = New Padding(3)
        tabProses.Size = New Size(856, 224)
        tabProses.TabIndex = 2
        tabProses.Text = "Proses"
        ' 
        ' dgvProses
        ' 
        dgvProses.AllowUserToAddRows = False
        dgvProses.AllowUserToDeleteRows = False
        dgvProses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProses.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvProses.BorderStyle = BorderStyle.None
        dgvProses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProses.Location = New Point(25, 3)
        dgvProses.MultiSelect = False
        dgvProses.Name = "dgvProses"
        dgvProses.ReadOnly = True
        dgvProses.RowHeadersVisible = False
        dgvProses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProses.Size = New Size(804, 218)
        dgvProses.TabIndex = 0
        ' 
        ' tabSelesai
        ' 
        tabSelesai.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        tabSelesai.Controls.Add(dgvSelesai)
        tabSelesai.Location = New Point(4, 36)
        tabSelesai.Name = "tabSelesai"
        tabSelesai.Padding = New Padding(3)
        tabSelesai.Size = New Size(856, 224)
        tabSelesai.TabIndex = 3
        tabSelesai.Text = "Selesai"
        ' 
        ' dgvSelesai
        ' 
        dgvSelesai.AllowUserToAddRows = False
        dgvSelesai.AllowUserToDeleteRows = False
        dgvSelesai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSelesai.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvSelesai.BorderStyle = BorderStyle.None
        dgvSelesai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSelesai.Location = New Point(25, 3)
        dgvSelesai.MultiSelect = False
        dgvSelesai.Name = "dgvSelesai"
        dgvSelesai.ReadOnly = True
        dgvSelesai.RowHeadersVisible = False
        dgvSelesai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSelesai.Size = New Size(804, 218)
        dgvSelesai.TabIndex = 0
        ' 
        ' tabPrioritas
        ' 
        tabPrioritas.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        tabPrioritas.Controls.Add(dgvPrioritas)
        tabPrioritas.Location = New Point(4, 36)
        tabPrioritas.Name = "tabPrioritas"
        tabPrioritas.Padding = New Padding(3)
        tabPrioritas.Size = New Size(856, 224)
        tabPrioritas.TabIndex = 4
        tabPrioritas.Text = "Prioritas"
        ' 
        ' dgvPrioritas
        ' 
        dgvPrioritas.AllowUserToAddRows = False
        dgvPrioritas.AllowUserToDeleteRows = False
        dgvPrioritas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPrioritas.BackgroundColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        dgvPrioritas.BorderStyle = BorderStyle.None
        dgvPrioritas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrioritas.Location = New Point(25, 3)
        dgvPrioritas.MultiSelect = False
        dgvPrioritas.Name = "dgvPrioritas"
        dgvPrioritas.ReadOnly = True
        dgvPrioritas.RowHeadersVisible = False
        dgvPrioritas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrioritas.Size = New Size(804, 218)
        dgvPrioritas.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        ClientSize = New Size(864, 450)
        Controls.Add(tabMain)
        Controls.Add(pnlSearch)
        Controls.Add(pnlStats)
        Controls.Add(pnlHeader)
        Name = "Form1"
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
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        tabMain.ResumeLayout(False)
        tabSemua.ResumeLayout(False)
        CType(dgvSemua, ComponentModel.ISupportInitialize).EndInit()
        tabBelum.ResumeLayout(False)
        CType(dgvBelum, ComponentModel.ISupportInitialize).EndInit()
        tabProses.ResumeLayout(False)
        CType(dgvProses, ComponentModel.ISupportInitialize).EndInit()
        tabSelesai.ResumeLayout(False)
        CType(dgvSelesai, ComponentModel.ISupportInitialize).EndInit()
        tabPrioritas.ResumeLayout(False)
        CType(dgvPrioritas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents btnTambah As Button
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
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabSemua As TabPage
    Friend WithEvents tabBelum As TabPage
    Friend WithEvents tabProses As TabPage
    Friend WithEvents tabSelesai As TabPage
    Friend WithEvents tabPrioritas As TabPage
    Friend WithEvents dgvSemua As DataGridView
    Friend WithEvents dgvBelum As DataGridView
    Friend WithEvents dgvProses As DataGridView
    Friend WithEvents dgvSelesai As DataGridView
    Friend WithEvents dgvPrioritas As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
