<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        pnlHeader = New Panel()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        pnlBody = New Panel()
        pnlFooter = New Panel()
        Label5 = New Label()
        lblAktivitasKananVal = New Label()
        lblPeranVal = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        lblIDVal = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblAktivitasKiriVal = New Label()
        lblNoHpVal = New Label()
        lblKomunitasVal = New Label()
        lblNamaVal = New Label()
        picFotoKartu = New PictureBox()
        pnlHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        pnlHeader.Controls.Add(PictureBox1)
        pnlHeader.Controls.Add(Label3)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(484, 55)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo_Komunitas
        PictureBox1.Location = New Point(109, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(155, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 25)
        Label3.TabIndex = 1
        Label3.Text = "Kartu Komunitas Digital"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.WhiteSmoke
        pnlBody.Controls.Add(pnlFooter)
        pnlBody.Controls.Add(lblAktivitasKananVal)
        pnlBody.Controls.Add(lblPeranVal)
        pnlBody.Controls.Add(Label2)
        pnlBody.Controls.Add(Panel1)
        pnlBody.Controls.Add(Label1)
        pnlBody.Controls.Add(Label7)
        pnlBody.Controls.Add(Label6)
        pnlBody.Controls.Add(lblAktivitasKiriVal)
        pnlBody.Controls.Add(lblNoHpVal)
        pnlBody.Controls.Add(lblKomunitasVal)
        pnlBody.Controls.Add(lblNamaVal)
        pnlBody.Controls.Add(picFotoKartu)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 55)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(484, 226)
        pnlBody.TabIndex = 1
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        pnlFooter.Controls.Add(Label5)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 194)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(484, 32)
        pnlFooter.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(180), CByte(210), CByte(255))
        Label5.Location = New Point(16, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(247, 13)
        Label5.TabIndex = 11
        Label5.Text = "Kartu Komunitas Digital . Diterbitkan secara resmi"
        ' 
        ' lblAktivitasKananVal
        ' 
        lblAktivitasKananVal.AutoSize = True
        lblAktivitasKananVal.BackColor = Color.Transparent
        lblAktivitasKananVal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAktivitasKananVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblAktivitasKananVal.Location = New Point(367, 93)
        lblAktivitasKananVal.MaximumSize = New Size(200, 0)
        lblAktivitasKananVal.Name = "lblAktivitasKananVal"
        lblAktivitasKananVal.Size = New Size(13, 17)
        lblAktivitasKananVal.TabIndex = 13
        lblAktivitasKananVal.Text = "-"
        ' 
        ' lblPeranVal
        ' 
        lblPeranVal.AutoSize = True
        lblPeranVal.BackColor = Color.Transparent
        lblPeranVal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeranVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblPeranVal.Location = New Point(110, 116)
        lblPeranVal.MaximumSize = New Size(200, 0)
        lblPeranVal.Name = "lblPeranVal"
        lblPeranVal.Size = New Size(13, 17)
        lblPeranVal.TabIndex = 12
        lblPeranVal.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(247, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 10
        Label2.Text = "Aktivitas/Hobi"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblIDVal)
        Panel1.Location = New Point(110, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(112, 25)
        Panel1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        Label4.Location = New Point(4, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 15)
        Label4.TabIndex = 3
        Label4.Text = "ID :"
        ' 
        ' lblIDVal
        ' 
        lblIDVal.AutoSize = True
        lblIDVal.BackColor = Color.Transparent
        lblIDVal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblIDVal.Location = New Point(30, 4)
        lblIDVal.Name = "lblIDVal"
        lblIDVal.Size = New Size(12, 15)
        lblIDVal.TabIndex = 2
        lblIDVal.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(25, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 8
        Label1.Text = "Foto Profil"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(105, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 15)
        Label7.TabIndex = 7
        Label7.Text = "Kontak"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(105, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 15)
        Label6.TabIndex = 6
        Label6.Text = "Komunitas - Peran"
        ' 
        ' lblAktivitasKiriVal
        ' 
        lblAktivitasKiriVal.AutoSize = True
        lblAktivitasKiriVal.BackColor = Color.Transparent
        lblAktivitasKiriVal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAktivitasKiriVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblAktivitasKiriVal.Location = New Point(254, 93)
        lblAktivitasKiriVal.MaximumSize = New Size(300, 0)
        lblAktivitasKiriVal.Name = "lblAktivitasKiriVal"
        lblAktivitasKiriVal.Size = New Size(13, 17)
        lblAktivitasKiriVal.TabIndex = 5
        lblAktivitasKiriVal.Text = "-"
        ' 
        ' lblNoHpVal
        ' 
        lblNoHpVal.AutoSize = True
        lblNoHpVal.BackColor = Color.Transparent
        lblNoHpVal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoHpVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblNoHpVal.Location = New Point(110, 161)
        lblNoHpVal.MaximumSize = New Size(168, 0)
        lblNoHpVal.Name = "lblNoHpVal"
        lblNoHpVal.Size = New Size(13, 17)
        lblNoHpVal.TabIndex = 4
        lblNoHpVal.Text = "-"
        ' 
        ' lblKomunitasVal
        ' 
        lblKomunitasVal.AutoSize = True
        lblKomunitasVal.BackColor = Color.Transparent
        lblKomunitasVal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKomunitasVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblKomunitasVal.Location = New Point(110, 93)
        lblKomunitasVal.MaximumSize = New Size(200, 0)
        lblKomunitasVal.Name = "lblKomunitasVal"
        lblKomunitasVal.Size = New Size(13, 17)
        lblKomunitasVal.TabIndex = 3
        lblKomunitasVal.Text = "-"
        ' 
        ' lblNamaVal
        ' 
        lblNamaVal.AutoSize = True
        lblNamaVal.BackColor = Color.Transparent
        lblNamaVal.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaVal.ForeColor = Color.FromArgb(CByte(29), CByte(53), CByte(87))
        lblNamaVal.Location = New Point(110, 43)
        lblNamaVal.Name = "lblNamaVal"
        lblNamaVal.Size = New Size(17, 23)
        lblNamaVal.TabIndex = 1
        lblNamaVal.Text = "-"
        ' 
        ' picFotoKartu
        ' 
        picFotoKartu.BackColor = Color.Transparent
        picFotoKartu.BorderStyle = BorderStyle.FixedSingle
        picFotoKartu.Location = New Point(15, 15)
        picFotoKartu.Name = "picFotoKartu"
        picFotoKartu.Size = New Size(80, 100)
        picFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        picFotoKartu.TabIndex = 0
        picFotoKartu.TabStop = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 281)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "FormKartu"
        Text = "FormKartu"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlFooter.ResumeLayout(False)
        pnlFooter.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAktivitasKiriVal As Label
    Friend WithEvents lblNoHpVal As Label
    Friend WithEvents lblKomunitasVal As Label
    Friend WithEvents lblIDVal As Label
    Friend WithEvents lblNamaVal As Label
    Friend WithEvents picFotoKartu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPeranVal As Label
    Friend WithEvents lblAktivitasKananVal As Label
End Class
