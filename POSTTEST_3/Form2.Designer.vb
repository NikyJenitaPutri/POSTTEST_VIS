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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        picKartu = New PictureBox()
        Panel3 = New Panel()
        lblHobby = New Label()
        lblJK = New Label()
        lblAlamat = New Label()
        lblTanggal = New Label()
        lblTelepon = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-7, -30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(599, 92)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(178, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 40)
        Label1.TabIndex = 0
        Label1.Text = "Kartu Komunitas"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orange
        Panel2.Location = New Point(-7, 288)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(599, 31)
        Panel2.TabIndex = 1
        ' 
        ' picKartu
        ' 
        picKartu.BackColor = Color.White
        picKartu.Location = New Point(56, 117)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(108, 116)
        picKartu.SizeMode = PictureBoxSizeMode.StretchImage
        picKartu.TabIndex = 2
        picKartu.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblHobby)
        Panel3.Controls.Add(lblJK)
        Panel3.Controls.Add(lblAlamat)
        Panel3.Controls.Add(lblTanggal)
        Panel3.Controls.Add(lblTelepon)
        Panel3.Controls.Add(lblUmur)
        Panel3.Controls.Add(lblNama)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(201, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(327, 189)
        Panel3.TabIndex = 3
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(117, 162)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(10, 15)
        lblHobby.TabIndex = 13
        lblHobby.Text = ":"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(117, 138)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(10, 15)
        lblJK.TabIndex = 12
        lblJK.Text = ":"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(117, 114)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(10, 15)
        lblAlamat.TabIndex = 11
        lblAlamat.Text = ":"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(117, 90)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(10, 15)
        lblTanggal.TabIndex = 10
        lblTanggal.Text = ":"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(117, 66)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(10, 15)
        lblTelepon.TabIndex = 9
        lblTelepon.Text = ":"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(117, 41)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(10, 15)
        lblUmur.TabIndex = 8
        lblUmur.Text = ":"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(117, 16)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(10, 15)
        lblNama.TabIndex = 7
        lblNama.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(18, 162)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 6
        Label8.Text = "Hobi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(18, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 15)
        Label7.TabIndex = 5
        Label7.Text = "Jenis Kelamin"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(18, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 4
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(18, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 3
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(18, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 2
        Label4.Text = "Telepon"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 1
        Label3.Text = "Umur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(584, 311)
        Controls.Add(Panel3)
        Controls.Add(picKartu)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents picKartu As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
End Class
