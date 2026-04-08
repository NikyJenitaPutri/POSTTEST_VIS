Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNamaVal.Text = nama
        lblIDVal.Text = id
        lblKomunitasVal.Text = komunitas.Replace("&", "&&")
        lblPeranVal.Text = "(" & peran & ")"
        lblNoHpVal.Text = telepon

        Dim aktivitasList As String() = aktivitas.Split(","c)

        Dim kiri As New System.Text.StringBuilder
        Dim kanan As New System.Text.StringBuilder

        For i As Integer = 0 To aktivitasList.Length - 1
            Dim t As String = aktivitasList(i).Trim()

            If t <> "" Then
                If i Mod 2 = 0 Then
                    kiri.AppendLine("• " & t)
                Else
                    kanan.AppendLine("• " & t)
                End If
            End If
        Next

        lblAktivitasKiriVal.Text = If(kiri.Length > 0, kiri.ToString(), "-")
        lblAktivitasKananVal.Text = If(kanan.Length > 0, kanan.ToString(), "")

        Try
            If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then
                Using fs As New IO.FileStream(fotoPath, IO.FileMode.Open, IO.FileAccess.Read)
                    picFotoKartu.Image = Image.FromStream(fs)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat foto: " & ex.Message, "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Me.PerformLayout()

    End Sub
End Class