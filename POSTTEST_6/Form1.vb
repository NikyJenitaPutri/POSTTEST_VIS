Imports System.Data

Public Class Form1
    Private idMatkul As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        KosongkanForm()
    End Sub

    Private Sub KosongkanForm()
        idMatkul = 0
        txtKodeMatkul.Clear()
        txtMatkul.Clear()
        txtDosen.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeMatkul.Focus()
    End Sub

    Private Sub TampilData()
        Try
            dgvMatkul.DataSource = DataModule.GetAllMatkul()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiMataKuliah(ErrorProvider1, txtMatkul, txtKodeMatkul, txtDosen) Then Exit Sub

        Dim kode As String = txtKodeMatkul.Text.Trim()
        Dim matkul As String = txtMatkul.Text.Trim()
        Dim dosen As String = txtDosen.Text.Trim()

        If DataModule.KodeMatkulSudahAda(kode) Then
            MessageBox.Show("Kode Mata Kuliah sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeMatkul.Focus()
            Exit Sub
        End If

        If DataModule.SimpanMatkul(kode, matkul, dosen) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If idMatkul = 0 Then
            MessageBox.Show("Pilih data yang akan diubah melalui tabel", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidationModule.ValidasiMataKuliah(ErrorProvider1, txtMatkul, txtKodeMatkul, txtDosen) Then Exit Sub

        Dim kode As String = txtKodeMatkul.Text.Trim()
        Dim matkul As String = txtMatkul.Text.Trim()
        Dim dosen As String = txtDosen.Text.Trim()

        If DataModule.UbahMatkul(idMatkul, kode, matkul, dosen) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        Else
            MessageBox.Show("Data tidak ditemukan atau gagal diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idMatkul = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus melalui tabel", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusMatkul(idMatkul) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub dgvMatkul_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatkul.CellClick
        If e.RowIndex >= 0 Then
            Try
                idMatkul = Convert.ToInt32(dgvMatkul.Rows(e.RowIndex).Cells(0).Value)
                txtKodeMatkul.Text = dgvMatkul.Rows(e.RowIndex).Cells("Kode_Matkul").Value.ToString()
                txtMatkul.Text = dgvMatkul.Rows(e.RowIndex).Cells("Mata_Kuliah").Value.ToString()
                txtDosen.Text = dgvMatkul.Rows(e.RowIndex).Cells("Dosen_Pengampu").Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data baris", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtKodeMatkul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeMatkul.KeyPress
        ValidationModule.HanyaAngka(e)

        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = DataModule.GetMatkulByKode(txtKodeMatkul.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtMatkul.Text = dt.Rows(0)("Mata_Kuliah").ToString()
                txtDosen.Text = dt.Rows(0)("Dosen_Pengampu").ToString()
            Else
                txtMatkul.Clear()
                txtDosen.Clear()
            End If

            txtMatkul.Focus()
        End If
    End Sub

    Private Sub txtMatkul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatkul.KeyPress
        ValidationModule.HanyaHuruf(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtKodeMatkul.Focus()
        End If
    End Sub

    Private Sub txtDosen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDosen.KeyPress
        ValidationModule.HanyaHuruf(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()
        If keyword = "" Then
            TampilData()
        Else
            dgvMatkul.DataSource = DataModule.SearchMatkul(keyword)
        End If
    End Sub

    Private Sub btnSelanjutnya_Click(sender As Object, e As EventArgs) Handles btnSelanjutnya.Click
        Form2.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class