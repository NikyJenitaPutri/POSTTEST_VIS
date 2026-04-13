Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub RefreshData()
        dgvSemua.DataSource = GetAllTugas()
        dgvBelum.DataSource = GetTugasByStatus("Belum Selesai")
        dgvProses.DataSource = GetTugasByStatus("Proses")
        dgvSelesai.DataSource = GetTugasByStatus("Selesai")
        dgvPrioritas.DataSource = GetTugasByPrioritas("Tinggi")
        UpdateStatistik()
    End Sub

    Private Sub UpdateStatistik()
        Dim s As Dictionary(Of String, Integer) = GetStatistik()
        lblTotalVal.Text = s("Total").ToString()
        lblBelumVal.Text = s("Belum").ToString()
        lblProsesVal.Text = s("Proses").ToString()
        lblSelesaiVal.Text = s("Selesai").ToString()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim f As New Form2()
        f.SetMode("TAMBAH")
        f.SetId(0)
        If f.ShowDialog() = DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub AnyDgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvSemua.CellDoubleClick,
                dgvBelum.CellDoubleClick,
                dgvProses.CellDoubleClick,
                dgvSelesai.CellDoubleClick,
                dgvPrioritas.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Dim dgv As DataGridView = CType(sender, DataGridView)

        Dim idObj As Object = dgv.Rows(e.RowIndex).Cells("idTugas").Value
        If idObj Is Nothing OrElse IsDBNull(idObj) Then Exit Sub
        Dim id As Integer = Convert.ToInt32(idObj)

        Dim f As New Form2()
        f.SetMode("EDIT")
        f.SetId(id)

        If f.ShowDialog() = DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()

        If keyword = "" Then
            RefreshData()
            Exit Sub
        End If

        Dim dt As DataTable = SearchTugas(keyword)

        dgvSemua.DataSource = dt

        Dim dvBelum As New DataView(dt)
        dvBelum.RowFilter = "status = 'Belum Selesai'"
        dgvBelum.DataSource = dvBelum

        Dim dvProses As New DataView(dt)
        dvProses.RowFilter = "status = 'Proses'"
        dgvProses.DataSource = dvProses

        Dim dvSelesai As New DataView(dt)
        dvSelesai.RowFilter = "status = 'Selesai'"
        dgvSelesai.DataSource = dvSelesai

        Dim dvPrior As New DataView(dt)
        dvPrior.RowFilter = "prioritas = 'Tinggi'"
        dgvPrioritas.DataSource = dvPrior

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim konfirm As DialogResult = MessageBox.Show(
        "Yakin ingin keluar? Perubahan yang belum disimpan akan hilang",
        "Konfirmasi Keluar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If konfirm = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class