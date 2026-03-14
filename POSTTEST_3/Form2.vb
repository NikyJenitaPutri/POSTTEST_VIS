Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = ModuleData.NamaUser
		lblUmur.Text = ModuleData.UmurUser
		lblTelepon.Text = ModuleData.TeleponUser
		lblTanggal.Text = ModuleData.TanggalLahir
		lblAlamat.Text = ModuleData.AlamatUser
		lblJK.Text = ModuleData.JenisKelamin
		lblHobby.Text = ModuleData.HobbyUser

		If ModuleData.FotoUser <> "" Then
			picKartu.Image = Image.FromFile(ModuleData.FotoUser)
		End If
	End Sub
End Class