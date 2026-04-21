Imports System.Windows.Forms

Public Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)
    End Function

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadioButton(ep As ErrorProvider, grp As GroupBox, pesan As String) As Boolean
        For Each ctrl As Control In grp.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = DirectCast(ctrl, RadioButton)
                If rb.Checked Then
                    ep.SetError(grp, "")
                    Return True
                End If
            End If
        Next
        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiTanggal(ep As ErrorProvider, dtpTanggal As DateTimePicker, dtpDeadline As DateTimePicker) As Boolean
        ep.SetError(dtpTanggal, "")
        ep.SetError(dtpDeadline, "")

        If dtpDeadline.Value.Date < dtpTanggal.Value.Date Then
            ep.SetError(dtpDeadline, "Deadline tidak boleh sebelum Tanggal Dibuat!")
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiMataKuliah(ep As ErrorProvider, txtMatkul As TextBox, txtKodeMatkul As TextBox, txtDosen As TextBox) As Boolean
        Dim ok As Boolean = True
        If Not ValidasiTextBox(ep, txtMatkul, "Nama Mata Kuliah wajib diisi!") Then ok = False
        If Not ValidasiTextBox(ep, txtKodeMatkul, "Kode Mata Kuliah wajib diisi!") Then ok = False
        If Not ValidasiTextBox(ep, txtDosen, "Nama Dosen wajib diisi!") Then ok = False
        Return ok
    End Function

    Public Function ValidasiDataTugas(ep As ErrorProvider,
                                      txtJudul As TextBox,
                                      txtDeskripsi As TextBox,
                                      cmbMatkul As ComboBox,
                                      cmbStatus As ComboBox,
                                      grpPrioritas As GroupBox,
                                      dtpTanggal As DateTimePicker,
                                      dtpDeadline As DateTimePicker) As Boolean
        Dim ok As Boolean = True
        If Not ValidasiTextBox(ep, txtJudul, "Judul wajib diisi!") Then ok = False
        If Not ValidasiTextBox(ep, txtDeskripsi, "Deskripsi wajib diisi!") Then ok = False
        If Not ValidasiComboBox(ep, cmbMatkul, "Pilih Matkul!") Then ok = False
        If Not ValidasiComboBox(ep, cmbStatus, "Pilih Status!") Then ok = False
        If Not ValidasiRadioButton(ep, grpPrioritas, "Pilih Prioritas!") Then ok = False
        If Not ValidasiTanggal(ep, dtpTanggal, dtpDeadline) Then ok = False
        Return ok
    End Function
End Module