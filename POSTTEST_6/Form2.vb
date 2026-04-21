Public Class Form2
    Private idTugas As Integer = 0

    Private Sub Kosong()
        idTugas = 0
        txtJudul.Clear()
        txtDeskripsi.Clear()
        cmbMatkul.SelectedIndex = -1
        cmbMatkul.Text = ""
        cmbStatus.SelectedIndex = -1
        cmbStatus.Text = ""
        rbRendah.Checked = False
        rbSedang.Checked = False
        rbTinggi.Checked = False
        ErrorProvider1.Clear()
        txtJudul.Focus()
    End Sub

    Private Sub TampilData()
        dgvTugas.DataSource = DataModule.GetAllTugas()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtMatkul As DataTable = DataModule.GetAllMatkul()
        cmbMatkul.DataSource = dtMatkul
        cmbMatkul.DisplayMember = "Mata_Kuliah"
        cmbMatkul.ValueMember = "ID_Matkul"
        TampilData()
        Kosong()
        LoadStatistik()
    End Sub

    Private Sub LoadStatistik()
        lblTotalVal.Text = DataModule.CountAllTugas()
        lblBelumVal.Text = DataModule.CountTugasByStatus("Belum Selesai")
        lblProsesVal.Text = DataModule.CountTugasByStatus("Proses")
        lblSelesaiVal.Text = DataModule.CountTugasByStatus("Selesai")
    End Sub

    Private Function GetPrioritas() As String
        If rbTinggi.Checked Then Return "Tinggi"
        If rbSedang.Checked Then Return "Sedang"
        If rbRendah.Checked Then Return "Rendah"
        Return ""
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiDataTugas(
                ErrorProvider1,
                txtJudul,
                txtDeskripsi,
                cmbMatkul,
                cmbStatus,
                grpPrioritas,
                dtpTanggal,
                dtpDeadline) Then Exit Sub

        Dim idMatkul As Integer = Convert.ToInt32(cmbMatkul.SelectedValue)
        Dim judul As String = txtJudul.Text.Trim()
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        Dim tanggal As Date = dtpTanggal.Value
        Dim deadline As Date = dtpDeadline.Value
        Dim status As String = cmbStatus.Text
        Dim prioritas As String = GetPrioritas()

        If DataModule.JudulTugasSudahAda(judul) Then
            MessageBox.Show("Judul Tugas sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJudul.Focus()
            Exit Sub
        End If

        If DataModule.SimpanTugas(idMatkul, judul, deskripsi, tanggal, deadline, status, prioritas) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            LoadStatistik()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If idTugas = 0 Then
            MessageBox.Show("Pilih data yang akan diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidationModule.ValidasiDataTugas(
                ErrorProvider1,
                txtJudul,
                txtDeskripsi,
                cmbMatkul,
                cmbStatus,
                grpPrioritas,
                dtpTanggal,
                dtpDeadline) Then Exit Sub

        Dim idMatkul As Integer = Convert.ToInt32(cmbMatkul.SelectedValue)
        Dim judul As String = txtJudul.Text.Trim()
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        Dim tanggal As Date = dtpTanggal.Value
        Dim deadline As Date = dtpDeadline.Value
        Dim status As String = cmbStatus.Text
        Dim prioritas As String = GetPrioritas()

        If DataModule.UbahTugas(idTugas, idMatkul, judul, deskripsi, tanggal, deadline, status, prioritas) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            LoadStatistik()
            Kosong()
            idTugas = 0
        Else
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTugas = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus melalui tabel", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If DataModule.HapusTugas(idTugas) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                LoadStatistik()
                Kosong()
            Else
                MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvTugas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTugas.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id As Integer = dgvTugas.Rows(e.RowIndex).Cells(0).Value
        Dim dt As DataTable = DataModule.GetTugasById(id)

        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)
            idTugas = Convert.ToInt32(row("ID_Tugas"))
            txtJudul.Text = row("Judul").ToString()
            txtDeskripsi.Text = row("Deskripsi").ToString()
            cmbMatkul.SelectedValue = row("ID_Matkul")
            cmbStatus.Text = row("Status").ToString()
            dtpTanggal.Value = row("Tanggal_Dibuat")
            dtpDeadline.Value = row("Deadline")

            Select Case row("Prioritas").ToString()
                Case "Tinggi" : rbTinggi.Checked = True
                Case "Sedang" : rbSedang.Checked = True
                Case "Rendah" : rbRendah.Checked = True
            End Select
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvTugas.DataSource = DataModule.SearchTugas(txtSearch.Text.Trim())
        End If
    End Sub


    Private Sub dgvTugas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTugas.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvTugas.Rows(e.RowIndex)
        Dim frm As New Form3()

        frm.IsiDetail(
            row.Cells("Mata_Kuliah").Value.ToString(),
            row.Cells("Judul").Value.ToString(),
            row.Cells("Deskripsi").Value.ToString(),
            Convert.ToDateTime(row.Cells("Tanggal_Dibuat").Value).ToString("dd-MM-yyyy"),
            Convert.ToDateTime(row.Cells("Deadline").Value).ToString("dd-MM-yyyy"),
            row.Cells("Status").Value.ToString(),
            row.Cells("Prioritas").Value.ToString()
        )

        frm.ShowDialog()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class