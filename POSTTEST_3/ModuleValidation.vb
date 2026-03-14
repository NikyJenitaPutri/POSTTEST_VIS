Module ModuleValidation

	Public Sub InputAngka(sender As Object, e As KeyPressEventArgs)

		If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If

	End Sub


	Public Sub InputHuruf(sender As Object, e As KeyPressEventArgs)

		If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If

	End Sub


	Public Function CekTextbox(txt As TextBox, pesan As String) As Boolean

		If String.IsNullOrWhiteSpace(txt.Text) Then
			MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txt.Focus()
			Return False
		End If

		Return True
	End Function

	Public Function CekDateTimePicker(sudahDipilih As Boolean, dtp As DateTimePicker, pesan As String) As Boolean
		If Not sudahDipilih Then
			MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			dtp.Focus()
			Return False
		End If
		Return True
	End Function


	Public Function CekFoto(pic As PictureBox, pesan As String) As Boolean

		If pic.Image Is Nothing Then
			MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If

		Return True

	End Function


	Public Function CekCheckBox(grup() As CheckBox, pesan As String) As Boolean

		For Each cb As CheckBox In grup
			If cb.Checked Then
				Return True
			End If
		Next

		MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return False

	End Function


	Public Function CekRadio(grup() As RadioButton, pesan As String) As Boolean

		For Each rb As RadioButton In grup
			If rb.Checked Then
				Return True
			End If
		Next

		MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return False

	End Function

End Module