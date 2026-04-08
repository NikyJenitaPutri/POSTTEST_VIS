Imports System.IO

Public Class Form1

    'VALIDASI PER TAB
    Function ValidasiTab1Form() As Boolean
        ErrorProvider1.Clear()
        Return ModuleValidation.ValidasiTab1(ErrorProvider1, txtNama, txtID, cmbKomunitas, dtpLahir, GroupBox1)
    End Function

    Function ValidasiTab2Form() As Boolean
        ErrorProvider1.Clear()
        Return ModuleValidation.ValidasiTab2(ErrorProvider1, mtbTelepon, txtEmail, txtAlamat)
    End Function

    Function ValidasiTab3Form() As Boolean
        ErrorProvider1.Clear()
        Return ModuleValidation.ValidasiTab3(ErrorProvider1, grpPeran, grpAktivitas, picFoto)
    End Function

    Function SemuaDataTerisi() As Boolean
        Return ValidasiTab1Form() AndAlso ValidasiTab2Form() AndAlso ValidasiTab3Form()
    End Function

    'PINDAH TAB
    Private Sub btnKeTab2_Click(sender As Object, e As EventArgs) Handles btnKeTab2.Click
        If ValidasiTab1Form() Then
            TabControl1.SelectedTab = tabKontak
        Else
            MessageBox.Show("Lengkapi Data Utama!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKeTab3_Click(sender As Object, e As EventArgs) Handles btnKeTab3.Click
        If ValidasiTab2Form() Then
            TabControl1.SelectedTab = tabProfil
        Else
            MessageBox.Show("Lengkapi Data Kontak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKembaliKeTab2_Click(sender As Object, e As EventArgs) Handles btnKembaliKeTab2.Click
        TabControl1.SelectedTab = tabKontak
    End Sub

    Private Sub btnKembaliKeTab1_Click(sender As Object, e As EventArgs) Handles btnKembaliKeTab1.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    'FOTO
    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        OpenFileDialog1.Filter = "Image|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            fotoPath = OpenFileDialog1.FileName
        End If
    End Sub

    'AMBIL DATA
    Sub AmbilData()
        nama = txtNama.Text
        id = txtID.Text
        komunitas = cmbKomunitas.Text
        jk = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")
        telepon = mtbTelepon.Text
        email = txtEmail.Text
        alamat = txtAlamat.Text

        For Each rb As RadioButton In grpPeran.Controls
            If rb.Checked Then peran = rb.Text
        Next

        Dim list As New List(Of String)
        For Each cb As CheckBox In grpAktivitas.Controls
            If cb.Checked Then list.Add(cb.Text)
        Next
        aktivitas = String.Join(", ", list)
    End Sub

    'SIMPAN
    Function SimpanFile() As Boolean
        Dim isi As String = BuatIsiFile(
        id, nama,
        dtpLahir.Value.ToString("dd/MM/yyyy"),
        jk, telepon, email, alamat,
        komunitas, peran, aktivitas, fotoPath
    )

        If SimpanDataKeFile(SaveFileDialog1, isi) Then
            Return True
        Else
            Return False
        End If
    End Function

    'BUKA FILE
    Sub BukaFile()
        Dim lines() As String = BukaDataDariFile(OpenFileDialog1)
        If lines Is Nothing Then Exit Sub

        ResetForm()

        Try
            txtID.Text = AmbilNilai(lines(1))
            txtNama.Text = AmbilNilai(lines(2))

            Dim tgl As Date = Date.ParseExact(AmbilNilai(lines(3)), "dd/MM/yyyy", Nothing)
            dtpLahir.Value = tgl
            dtpSudahDipilih = True
            dtpLahir.Format = DateTimePickerFormat.Short
            dtpLahir.CustomFormat = Nothing

            Dim jkVal = AmbilNilai(lines(4))
            rbLakiLaki.Checked = (jkVal = "Laki-laki")
            rbPerempuan.Checked = (jkVal = "Perempuan")

            mtbTelepon.Text = AmbilNilai(lines(5))
            txtEmail.Text = AmbilNilai(lines(6))
            txtAlamat.Text = AmbilNilai(lines(7))
            cmbKomunitas.Text = AmbilNilai(lines(8))

            Dim peranVal = AmbilNilai(lines(9))
            For Each rb As RadioButton In grpPeran.Controls
                rb.Checked = (rb.Text = peranVal)
            Next

            Dim aktivitasArr = AmbilNilai(lines(10)).Split(","c)
            For i As Integer = 0 To aktivitasArr.Length - 1
                aktivitasArr(i) = aktivitasArr(i).Trim()
            Next
            For Each cb As CheckBox In grpAktivitas.Controls
                cb.Checked = aktivitasArr.Contains(cb.Text)
            Next

            fotoPath = AmbilNilai(lines(11))
            If File.Exists(fotoPath) Then
                Using fs As New FileStream(fotoPath, FileMode.Open, FileAccess.Read)
                    picFoto.Image = Image.FromStream(fs)
                End Using
            End If

            MessageBox.Show("Data berhasil dibuka!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Format file salah! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'BUTTON SIMPAN & CETAK
    Dim dataSudahDisimpan As Boolean = False
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not SemuaDataTerisi() Then
            MessageBox.Show("Semua data wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        AmbilData()

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
        "Apakah data ingin disimpan?",
        "Konfirmasi",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            If SimpanFile() Then
                dataSudahDisimpan = True
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dataSudahDisimpan = False
                MessageBox.Show("Data gagal disimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If Not SemuaDataTerisi() Then
            MessageBox.Show("Data belum lengkap!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not dataSudahDisimpan Then
            MessageBox.Show("Data harus disimpan terlebih dahulu sebelum cetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        AmbilData()

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
        "Apakah ingin mencetak kartu?",
        "Konfirmasi",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Dim f As New FormKartu
            f.Show()

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Cetak dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'MENU STRIP
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
        "Apakah ingin reset form?",
        "Konfirmasi",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            ResetForm()
            MessageBox.Show("Form berhasil direset", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Form tidak direset", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If Not SemuaDataTerisi() Then
            MessageBox.Show("Isi data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not dataSudahDisimpan Then
            MessageBox.Show("Data harus disimpan terlebih dahulu sebelum melihat kartu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        AmbilData()

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
        "Apakah ingin melihat kartu?",
        "Konfirmasi",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
    )

        If hasil = DialogResult.Yes Then
            Dim f As New FormKartu
            f.Show()

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Batal melihat kartu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub SimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimToolStripMenuItem.Click
        If Not SemuaDataTerisi() Then
            MessageBox.Show("Data belum lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        AmbilData()
        Dim berhasil As Boolean = SimpanFile()
        If berhasil Then
            dataSudahDisimpan = True
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        BukaFile()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
        "Apakah yakin ingin keluar?",
        "Konfirmasi",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Application.Exit()

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Batal keluar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub dtpLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpLahir.ValueChanged
        If dtpSudahDipilih Then
            dtpLahir.Format = DateTimePickerFormat.Short
            dtpLahir.CustomFormat = Nothing
        End If
    End Sub

    Private Sub dtpLahir_CloseUp(sender As Object, e As EventArgs) Handles dtpLahir.CloseUp
        dtpSudahDipilih = True
        dtpLahir.Format = DateTimePickerFormat.Short
        dtpLahir.CustomFormat = Nothing
        ErrorProvider1.SetError(dtpLahir, "")
    End Sub

    'RESET FORM
    Sub ResetForm()
        ' Tab 1
        txtNama.Clear()
        txtID.Clear()
        cmbKomunitas.SelectedIndex = -1

        dtpSudahDipilih = False
        dtpLahir.Value = DateTime.Now
        dtpLahir.CustomFormat = " "
        dtpLahir.Format = DateTimePickerFormat.Custom

        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False

        ' Tab 2
        mtbTelepon.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()

        ' Tab 3
        For Each rb As RadioButton In grpPeran.Controls
            rb.Checked = False
        Next
        For Each cb As CheckBox In grpAktivitas.Controls
            cb.Checked = False
        Next
        picFoto.Image = Nothing
        fotoPath = ""

        nama = "" : id = "" : komunitas = "" : jk = ""
        telepon = "" : email = "" : alamat = ""
        peran = "" : aktivitas = ""

        dataSudahDisimpan = False

        TabControl1.SelectedTab = tabDataUtama
        ErrorProvider1.Clear()
    End Sub

End Class