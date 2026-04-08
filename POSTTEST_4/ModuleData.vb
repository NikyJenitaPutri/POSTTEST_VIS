Imports System.IO
Imports System.Text

Module ModuleData

    Public nama As String = ""
    Public id As String = ""
    Public tglLahir As String = ""
    Public jk As String = ""
    Public komunitas As String = ""
    Public telepon As String = ""
    Public email As String = ""
    Public alamat As String = ""
    Public peran As String = ""
    Public aktivitas As String = ""
    Public fotoPath As String = ""
    Public dtpSudahDipilih As Boolean = False

    'BUAT ISI FILE
    Public Function BuatIsiFile(
        _id As String,
        _nama As String,
        _tanggal As String,
        _jk As String,
        _telepon As String,
        _email As String,
        _alamat As String,
        _komunitas As String,
        _peran As String,
        _aktivitas As String,
        _fotoPath As String
    ) As String
        Dim sb As New StringBuilder()
        sb.AppendLine("===== DATA KARTU KOMUNITAS =====")
        sb.AppendLine("ID         : " & _id)
        sb.AppendLine("Nama       : " & _nama)
        sb.AppendLine("Tanggal    : " & _tanggal)
        sb.AppendLine("Jenis Kel  : " & _jk)
        sb.AppendLine("Telepon    : " & _telepon)
        sb.AppendLine("Email      : " & _email)
        sb.AppendLine("Alamat     : " & _alamat)
        sb.AppendLine("Komunitas  : " & _komunitas)
        sb.AppendLine("Peran      : " & _peran)
        sb.AppendLine("Aktivitas  : " & _aktivitas)
        sb.AppendLine("Foto       : " & _fotoPath)
        Return sb.ToString()
    End Function

    'SIMPAN FILE
    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String
    ) As Boolean
        sfd.Filter = "Text File|*.txt"
        sfd.Title = "Simpan Data"
        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If
        Return False
    End Function

    'BUKA FILE
    Public Function BukaDataDariFile(ofd As OpenFileDialog) As String()
        ofd.Filter = "Text File|*.txt"
        ofd.Title = "Buka Data"
        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If
        Return File.ReadAllLines(ofd.FileName)
    End Function

    'AMBIL VALUE DARI BARIS
    Public Function AmbilNilai(line As String) As String
        Dim idx As Integer = line.IndexOf(": ")
        If idx < 0 Then Return ""
        Return line.Substring(idx + 2).Trim()
    End Function

End Module