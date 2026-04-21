Public Class Form3
    Public Sub IsiDetail(matkul As String,
                         judul As String,
                         deskripsi As String,
                         tanggal As String,
                         deadline As String,
                         status As String,
                         prioritas As String)

        txtMatkul.Text = matkul
        txtJudul.Text = judul
        txtDeskripsi.Text = deskripsi
        txtTanggal.Text = tanggal
        txtDeadline.Text = deadline
        txtStatus.Text = status
        txtPrioritas.Text = prioritas

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class