<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtJudul = New TextBox()
        txtDeskripsi = New TextBox()
        pnlFooter = New Panel()
        btnTutup = New Button()
        Label7 = New Label()
        txtMatkul = New TextBox()
        txtStatus = New TextBox()
        txtPrioritas = New TextBox()
        txtTanggal = New TextBox()
        txtDeadline = New TextBox()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Olive
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(484, 72)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(18, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(154, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Detail Tugas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(18, 145)
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
        Label2.Location = New Point(18, 205)
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
        Label3.Location = New Point(18, 329)
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
        Label4.Location = New Point(247, 329)
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
        Label5.Location = New Point(18, 397)
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
        Label6.Location = New Point(247, 397)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 6
        Label6.Text = "PRIORITAS *"
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(34, 163)
        txtJudul.Name = "txtJudul"
        txtJudul.ReadOnly = True
        txtJudul.Size = New Size(430, 23)
        txtJudul.TabIndex = 7
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.Location = New Point(34, 223)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ReadOnly = True
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(430, 91)
        txtDeskripsi.TabIndex = 8
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(247))
        pnlFooter.Controls.Add(btnTutup)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 453)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(484, 58)
        pnlFooter.TabIndex = 14
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Maroon
        btnTutup.Cursor = Cursors.Hand
        btnTutup.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(392, 14)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(72, 32)
        btnTutup.TabIndex = 27
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(18, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 15)
        Label7.TabIndex = 15
        Label7.Text = "MATA KULIAH *"
        ' 
        ' txtMatkul
        ' 
        txtMatkul.Location = New Point(35, 103)
        txtMatkul.Name = "txtMatkul"
        txtMatkul.ReadOnly = True
        txtMatkul.Size = New Size(429, 23)
        txtMatkul.TabIndex = 16
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(35, 415)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(199, 23)
        txtStatus.TabIndex = 17
        ' 
        ' txtPrioritas
        ' 
        txtPrioritas.Location = New Point(264, 415)
        txtPrioritas.Name = "txtPrioritas"
        txtPrioritas.ReadOnly = True
        txtPrioritas.Size = New Size(200, 23)
        txtPrioritas.TabIndex = 18
        ' 
        ' txtTanggal
        ' 
        txtTanggal.Location = New Point(34, 347)
        txtTanggal.Name = "txtTanggal"
        txtTanggal.ReadOnly = True
        txtTanggal.Size = New Size(199, 23)
        txtTanggal.TabIndex = 19
        ' 
        ' txtDeadline
        ' 
        txtDeadline.Location = New Point(265, 347)
        txtDeadline.Name = "txtDeadline"
        txtDeadline.ReadOnly = True
        txtDeadline.Size = New Size(199, 23)
        txtDeadline.TabIndex = 20
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(244))
        ClientSize = New Size(484, 511)
        Controls.Add(txtDeadline)
        Controls.Add(txtTanggal)
        Controls.Add(txtPrioritas)
        Controls.Add(txtStatus)
        Controls.Add(txtMatkul)
        Controls.Add(Label7)
        Controls.Add(pnlFooter)
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
        MaximumSize = New Size(500, 550)
        MinimizeBox = False
        MinimumSize = New Size(500, 550)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form CRUD"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMatkul As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtPrioritas As TextBox
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents txtDeadline As TextBox
End Class