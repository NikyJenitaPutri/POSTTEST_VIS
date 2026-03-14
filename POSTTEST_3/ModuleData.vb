Module ModuleData

	Public NamaUser As String
	Public UmurUser As String
	Public TeleponUser As String
	Public AlamatUser As String
	Public JenisKelamin As String
	Public HobbyUser As String
	Public FotoUser As String
	Public TanggalLahir As Date


	Public Function AmbilRadioButton(grupRadio() As RadioButton) As String

		For Each rb As RadioButton In grupRadio
			If rb.Checked Then
				Return rb.Text
			End If
		Next

		Return ""

	End Function


	Public Function AmbilCheckBox(grupChecbox() As CheckBox) As String

		Dim listHobi As New List(Of String)

		For Each cb As CheckBox In grupChecbox
			If cb.Checked Then
				listHobi.Add(cb.Text)
			End If
		Next

		Return String.Join(", ", listHobi)

	End Function

End Module