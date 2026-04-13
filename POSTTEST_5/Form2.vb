Public Class Form2

    Private _mode As String = "TAMBAH"
    Private _idTugasEdit As Integer = 0
    Private tglDipilih As Boolean = False
    Private deadlineDipilih As Boolean = False

    Public Sub SetMode(mode As String)
        _mode = mode
    End Sub

    Public Sub SetId(id As Integer)
        _idTugasEdit = id
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tglDipilih = False
        deadlineDipilih = False

        If _mode = "EDIT" Then
            lblTitle.Text = "Edit Tugas"
            lblSub.Text = "Ubah data tugas di bawah ini"
            btnHapus.Visible = True
            LoadDataEdit()

            tglDipilih = True
            deadlineDipilih = True
        Else
            lblTitle.Text = "Tambah Tugas Baru"
            lblSub.Text = "Lengkapi semua data di bawah ini"
            btnHapus.Visible = False
        End If

    End Sub

    Private Sub LoadDataEdit()
        Dim dt As DataTable = GetTaskById(_idTugasEdit)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim r As DataRow = dt.Rows(0)

        txtJudul.Text = r("judul").ToString()
        txtDeskripsi.Text = r("deskripsi").ToString()

        If Not IsDBNull(r("tglDibuat")) Then
            dtpTanggal.Value = Convert.ToDateTime(r("tglDibuat"))
        End If

        If Not IsDBNull(r("deadline")) Then
            dtpDeadline.Value = Convert.ToDateTime(r("deadline"))
        End If

        Dim idxStatus As Integer = cmbStatus.Items.IndexOf(r("status").ToString())
        If idxStatus >= 0 Then
            cmbStatus.SelectedIndex = idxStatus
        End If

        Select Case r("prioritas").ToString()
            Case "Rendah" : rbRendah.Checked = True
            Case "Sedang" : rbSedang.Checked = True
            Case "Tinggi" : rbTinggi.Checked = True
        End Select
    End Sub

    Private Function GetPrioritas() As String
        If rbRendah.Checked Then Return "Rendah"
        If rbSedang.Checked Then Return "Sedang"
        If rbTinggi.Checked Then Return "Tinggi"
        Return ""
    End Function

    Private Sub dtpTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged
        tglDipilih = True
    End Sub

    Private Sub dtpDeadline_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeadline.ValueChanged
        deadlineDipilih = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiTugas(ErrorProvider1,
                     txtJudul,
                     txtDeskripsi,
                     tglDipilih,
                     deadlineDipilih,
                     dtpTanggal,
                     dtpDeadline,
                     cmbStatus,
                     grpPrioritas,
                     rbRendah,
                     rbSedang,
                     rbTinggi,
                     _mode) Then
            Exit Sub
        End If

        Dim judul As String = txtJudul.Text.Trim()
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        Dim status As String = cmbStatus.Text
        Dim prioritas As String = GetPrioritas()

        If _mode = "TAMBAH" Then
            Dim ok As Boolean = SimpanTugas(judul, deskripsi, dtpTanggal.Value, dtpDeadline.Value, status, prioritas)

            If ok Then
                MessageBox.Show("Tugas berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            End If
        Else
            Dim ok As Boolean = UbahTugas(_idTugasEdit, judul, deskripsi, dtpDeadline.Value, status, prioritas)

            If ok Then
                MessageBox.Show("Tugas berhasil diupdate!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            End If
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus tugas ini?" & vbNewLine &
            "Tindakan tidak dapat dibatalkan.",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If konfirm = DialogResult.Yes Then
            If HapusTugas(_idTugasEdit) Then
                MessageBox.Show("Tugas berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirm As DialogResult = MessageBox.Show(
            "Perubahan akan hilang, lanjut?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If konfirm = DialogResult.Yes Then
            DialogResult = DialogResult.Cancel
            Close()
        End If
    End Sub


End Class