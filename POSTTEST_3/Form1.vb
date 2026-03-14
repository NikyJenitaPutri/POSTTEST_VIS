Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Dim sudahPilihTanggal As Boolean = False

    Private Function ValidasiInput() As Boolean
        grupHobi = {cbGaming, cbMembaca, cbOlahraga, cbTraveling, cbMusik, cbCoding, cbMemancing, cbMenulis, cbFotografi, cbMenari}
        grupJK = {rbLaki, rbPerempuan}

        If Not ModuleValidation.CekTextbox(txtNama, "Nama tidak boleh kosong") Then Return False
        If Not ModuleValidation.CekTextbox(txtUmur, "Umur tidak boleh kosong") Then Return False
        If Not ModuleValidation.CekTextbox(txtTelepon, "Nomor telepon tidak boleh kosong") Then Return False
        If Not ModuleValidation.CekDateTimePicker(sudahPilihTanggal, dtpTanggal, "Pilih tanggal lahir") Then Return False
        If Not ModuleValidation.CekTextbox(txtAlamat, "Alamat tidak boleh kosong") Then Return False
        If Not ModuleValidation.CekRadio(grupJK, "Silakan pilih jenis kelamin") Then Return False
        If Not ModuleValidation.CekCheckBox(grupHobi, "Pilih minimal satu hobi") Then Return False
        If Not ModuleValidation.CekFoto(picFoto, "Foto profil harus diupload") Then Return False

        Return True

    End Function

    Private Sub dtpTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged
        sudahPilihTanggal = True
    End Sub

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        Dim OpenFileDialog As New OpenFileDialog()

        OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog.Title = "Pilih Foto"

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then

            Dim folderFoto As String = Path.Combine(Application.StartupPath, "FotoMember")

            Dim namaFile As String = txtNama.Text.Trim() & Path.GetExtension(OpenFileDialog.FileName)

            Dim lokasiBaru As String = Path.Combine(folderFoto, namaFile)

            If Not Directory.Exists(folderFoto) Then
                Directory.CreateDirectory(folderFoto)
            End If

            File.Copy(OpenFileDialog.FileName, lokasiBaru, True)

            ModuleData.FotoUser = lokasiBaru

            picFoto.Image = Image.FromFile(lokasiBaru)

            MessageBox.Show("Foto berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If ValidasiInput() Then

            grupHobi = {cbGaming, cbMembaca, cbOlahraga, cbTraveling, cbMusik, cbCoding, cbMemancing, cbMenulis, cbFotografi, cbMenari}
            grupJK = {rbLaki, rbPerempuan}

            Dim hobiDipilih As String = ModuleData.AmbilCheckBox(grupHobi)
            Dim jkDipilih As String = ModuleData.AmbilRadioButton(grupJK)

            ModuleData.NamaUser = txtNama.Text
            ModuleData.UmurUser = txtUmur.Text
            ModuleData.TeleponUser = txtTelepon.Text
            ModuleData.AlamatUser = txtAlamat.Text
            ModuleData.JenisKelamin = jkDipilih
            ModuleData.HobbyUser = hobiDipilih
            ModuleData.TanggalLahir = dtpTanggal.Value.ToShortDateString()

            Form2.Show()

        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ModuleValidation.InputHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ModuleValidation.InputAngka(sender, e)
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        ModuleValidation.InputAngka(sender, e)
    End Sub
End Class