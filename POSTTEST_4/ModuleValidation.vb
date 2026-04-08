Module ModuleValidation

    'FILTER KARAKTER INPUT
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
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

    'VALIDASI 
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiDatePicker(ep As ErrorProvider, dtp As DateTimePicker) As Boolean
        If dtp.CustomFormat = " " Then
            ep.SetError(dtp, "Tanggal wajib dipilih")
            Return False
        ElseIf dtp.Value > DateTime.Now Then
            ep.SetError(dtp, "Tanggal tidak valid")
            Return False
        ElseIf DateTime.Now.Year - dtp.Value.Year < 5 Then
            ep.SetError(dtp, "Umur minimal 5 tahun")
            Return False
        Else
            ep.SetError(dtp, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadioGroup(ep As ErrorProvider, grp As GroupBox, pesan As String) As Boolean
        For Each rb As RadioButton In grp.Controls
            If rb.Checked Then
                ep.SetError(grp, "")
                Return True
            End If
        Next
        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiCheckboxGroup(
        ep As ErrorProvider,
        grp As GroupBox,
        minPilih As Integer
    ) As Boolean
        Dim jumlah As Integer = 0

        For Each cb As CheckBox In grp.Controls
            If cb.Checked Then jumlah += 1
        Next

        If jumlah < minPilih Then
            ep.SetError(grp, "Pilih minimal " & minPilih & " aktivitas")
            Return False
        Else
            ep.SetError(grp, "")
            Return True
        End If
    End Function

    Public Function ValidasiFoto(ep As ErrorProvider, pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            ep.SetError(pic, pesan)
            Return False
        Else
            ep.SetError(pic, "")
            Return True
        End If
    End Function

    ' VALIDASI PER TAB 
    Public Function ValidasiTab1(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        cmbKomunitas As ComboBox,
        dtpLahir As DateTimePicker,
        grpJK As GroupBox
    ) As Boolean
        Dim namaOK As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim idOK As Boolean = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim komunitasOK As Boolean = ValidasiComboBox(ep, cmbKomunitas, "Pilih jenis komunitas")
        Dim tglOK As Boolean = ValidasiDatePicker(ep, dtpLahir)
        Dim jkOK As Boolean = ValidasiRadioGroup(ep, grpJK, "Pilih jenis kelamin")
        Return namaOK And idOK And komunitasOK And tglOK And jkOK
    End Function

    Public Function ValidasiTab2(
        ep As ErrorProvider,
        mtbTelepon As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox
    ) As Boolean

        Dim telOK As Boolean = ValidasiMaskedTextBox(ep, mtbTelepon, "Nomor telepon harus lengkap")

        Dim emailOK As Boolean = True
        If txtEmail.Text.Trim = "" Then
            ep.SetError(txtEmail, "Email tidak boleh kosong")
            emailOK = False
        ElseIf Not txtEmail.Text.Contains("@") Then
            ep.SetError(txtEmail, "Format email tidak valid")
            emailOK = False
        Else
            ep.SetError(txtEmail, "")
        End If

        Dim alamatOK As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Return telOK And emailOK And alamatOK
    End Function

    Public Function ValidasiTab3(
        ep As ErrorProvider,
        grpPeran As GroupBox,
        grpAktivitas As GroupBox,
        picFoto As PictureBox
    ) As Boolean

        Dim peranOK As Boolean = ValidasiRadioGroup(ep, grpPeran, "Pilih peran dalam komunitas")
        Dim aktivitasOK As Boolean = ValidasiCheckboxGroup(ep, grpAktivitas, 1)
        Dim fotoOK As Boolean = ValidasiFoto(ep, picFoto, "Unggah foto")
        Return peranOK And aktivitasOK And fotoOK
    End Function

End Module