Public Class Form1

    Public judul As String
    Public genre As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtJudul.Text
        genre = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TambahBuku(judul, genre)
            TampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()
        End If

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        judul = txtHapus.Text

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            index = CariBuku(judul)
            If index <> -1 Then
                HapusBuku(index)
                TampilkanData()
                txtHapus.Clear()
            Else
                MessageBox.Show("Buku tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

    End Sub


    Private Sub TampilkanData()
        dgvBuku.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            dgvBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next

    End Sub

End Class