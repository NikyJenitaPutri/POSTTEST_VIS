Module ValidationModule
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiTanggal(ep As ErrorProvider, dipilih As Boolean, dtp As DateTimePicker, pesan As String) As Boolean
        If Not dipilih Then
            ep.SetError(dtp, pesan)
            Return False
        Else
            ep.SetError(dtp, "")
            Return True
        End If
    End Function

    Public Function ValidasiDeadline(ep As ErrorProvider, dipilih As Boolean, dtpDeadline As DateTimePicker, mode As String) As Boolean
        If Not dipilih Then
            ep.SetError(dtpDeadline, "Deadline wajib dipilih!")
            Return False
        ElseIf mode = "TAMBAH" AndAlso dtpDeadline.Value.Date < Date.Today Then
            ep.SetError(dtpDeadline, "Deadline tidak boleh lewat!")
            Return False
        Else
            ep.SetError(dtpDeadline, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As ComboBox, pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadio(ep As ErrorProvider, grp As GroupBox, rbR As RadioButton, rbS As RadioButton, rbT As RadioButton) As Boolean
        If Not rbR.Checked AndAlso Not rbS.Checked AndAlso Not rbT.Checked Then
            ep.SetError(grp, "Pilih salah satu prioritas!")
            Return False
        Else
            ep.SetError(grp, "")
            Return True
        End If
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiTugas(ep As ErrorProvider,
                                 txtJudul As TextBox,
                                 txtDesk As TextBox,
                                 tglDipilih As Boolean,
                                 deadlineDipilih As Boolean,
                                 dtpTanggal As DateTimePicker,
                                 dtpDeadline As DateTimePicker,
                                 cmbStatus As ComboBox,
                                 grpPrioritas As GroupBox,
                                 rbR As RadioButton,
                                 rbS As RadioButton,
                                 rbT As RadioButton,
                                 mode As String) As Boolean

        ep.Clear()

        Dim judulValid As Boolean = ValidasiTextBox(ep, txtJudul, "Judul wajib diisi!")
        Dim deskValid As Boolean = ValidasiTextBox(ep, txtDesk, "Deskripsi wajib diisi!")
        Dim tglValid As Boolean = ValidasiTanggal(ep, tglDipilih, dtpTanggal, "Tanggal dibuat wajib dipilih!")
        Dim deadlineValid As Boolean = ValidasiDeadline(ep, deadlineDipilih, dtpDeadline, mode)
        Dim statusValid As Boolean = ValidasiComboBox(ep, cmbStatus, "Pilih status!")
        Dim prioritasValid As Boolean = ValidasiRadio(ep, grpPrioritas, rbR, rbS, rbT)

        Return judulValid AndAlso deskValid AndAlso tglValid AndAlso deadlineValid AndAlso statusValid AndAlso prioritasValid

    End Function

End Module