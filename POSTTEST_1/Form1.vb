Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Dim ipk As Double = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        'cek apakah input kosong
        If txtIPSemester.Text = "" Then
            MessageBox.Show("IP Semester tidak boleh kosong!")
            txtIPSemester.Focus()
            Exit Sub
        End If

        'cek apakah angka 
        Dim ipSemester As Double
        If Not Double.TryParse(txtIPSemester.Text, ipSemester) Then
            MessageBox.Show("Input harus berupa angka")
            txtIPSemester.Clear()
            txtIPSemester.Focus()
            Exit Sub
        End If

        'cek apakah angka valid (0-4)
        If ipSemester < 0 Or ipSemester > 4 Then
            MessageBox.Show("Angka harus antara 0 sampai 4")
            txtIPSemester.Clear()
            txtIPSemester.Focus()
            Exit Sub
        End If

        'tambahkan IP semester ke total
        totalIP += ipSemester
        jumlahSemester += 1

        'hitung IPK
        ipk = totalIP / jumlahSemester

        'tampilkan hasil IPK
        txtIPKumulatif.Text = Format(ipk, "0.00")

        'menemukan predikat
        If ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        Else
            lblPredikat.Text = "-"
        End If

        'kosongkan input 
        txtIPSemester.Clear()
        txtIPSemester.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        ipk = 0

        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblPredikat.Text = "-"

        txtIPSemester.Focus()
    End Sub
End Class
