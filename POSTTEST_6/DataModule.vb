Imports MySqlConnector

Public Module DataModule
    ' MATA KULIAH
    Public Function GetAllMatkul() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT ID_Matkul, Kode_Matkul, Mata_Kuliah, Dosen_Pengampu FROM tbmatakuliah ORDER BY ID_Matkul ASC"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data mata kuliah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchMatkul(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT ID_Matkul, Kode_Matkul, Mata_Kuliah, Dosen_Pengampu FROM tbmatakuliah " &
            "WHERE Kode_Matkul LIKE @keyword OR Mata_Kuliah LIKE @keyword " &
            "ORDER BY ID_Matkul ASC"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetMatkulByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbmatakuliah WHERE Kode_Matkul = @kode"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeMatkulSudahAda(kode As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbmatakuliah WHERE Kode_Matkul = @kode"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal validasi kode: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanMatkul(kodeMatkul As String, mataKuliah As String, dosenPengampu As String) As Boolean
        Dim query As String = "INSERT INTO tbmatakuliah (Kode_Matkul, Mata_Kuliah, Dosen_Pengampu) VALUES (@kode, @matkul, @dosen)"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kodeMatkul)
                    cmd.Parameters.AddWithValue("@matkul", mataKuliah)
                    cmd.Parameters.AddWithValue("@dosen", dosenPengampu)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahMatkul(idMatkul As Integer, kodeMatkul As String, mataKuliah As String, dosenPengampu As String) As Boolean
        Dim query As String = "UPDATE tbmatakuliah SET Kode_Matkul = @kode, Mata_Kuliah = @matkul, Dosen_Pengampu = @dosen WHERE ID_Matkul = @id"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idMatkul)
                    cmd.Parameters.AddWithValue("@kode", kodeMatkul)
                    cmd.Parameters.AddWithValue("@matkul", mataKuliah)
                    cmd.Parameters.AddWithValue("@dosen", dosenPengampu)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusMatkul(idMatkul As Integer) As Boolean
        Dim query As String = "DELETE FROM tbmatakuliah WHERE ID_Matkul = @id"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idMatkul)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' TUGAS
    Public Function GetAllTugas() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT tbtugas.ID_Tugas, tbmatakuliah.Kode_Matkul, tbmatakuliah.Mata_Kuliah, " &
            "tbtugas.Judul, tbtugas.Deskripsi, tbtugas.Tanggal_Dibuat, tbtugas.Deadline, " &
            "tbtugas.Status, tbtugas.Prioritas " &
            "FROM tbtugas " &
            "INNER JOIN tbmatakuliah ON tbtugas.ID_Matkul = tbmatakuliah.ID_Matkul " &
            "ORDER BY tbtugas.ID_Tugas ASC"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data tugas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTugas(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT tbtugas.ID_Tugas, tbmatakuliah.Kode_Matkul, tbmatakuliah.Mata_Kuliah, " &
            "tbtugas.Judul, tbtugas.Deskripsi, tbtugas.Tanggal_Dibuat, tbtugas.Deadline, " &
            "tbtugas.Status, tbtugas.Prioritas " &
            "FROM tbtugas " &
            "INNER JOIN tbmatakuliah ON tbtugas.ID_Matkul = tbmatakuliah.ID_Matkul " &
            "WHERE tbtugas.Judul LIKE @keyword OR tbtugas.Deskripsi LIKE @keyword OR tbmatakuliah.Kode_Matkul LIKE @keyword OR tbmatakuliah.Mata_Kuliah LIKE @keyword " &
            "ORDER BY tbtugas.ID_Tugas ASC"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data tugas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function JudulTugasSudahAda(judul As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbtugas WHERE Judul = @judul"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal validasi judul: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function GetTugasById(idTugas As Integer) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbtugas WHERE ID_Tugas = @id"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idTugas)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil detail data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanTugas(idMatkul As Integer, judul As String, deskripsi As String, tanggal As Date, deadline As Date, status As String, prioritas As String) As Boolean
        Dim query As String = "INSERT INTO tbtugas (ID_Matkul, Judul, Deskripsi, Tanggal_Dibuat, Deadline, Status, Prioritas) " &
            "VALUES (@idMatkul, @judul, @deskripsi, @tanggal, @deadline, @status, @prioritas)"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idMatkul", idMatkul)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@deadline", deadline.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@prioritas", prioritas)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTugas(id As Integer, idMatkul As Integer, judul As String, deskripsi As String, tanggal As Date, deadline As Date, status As String, prioritas As String) As Boolean
        Dim query As String = "UPDATE tbtugas SET ID_Matkul = @idMatkul, Judul = @judul, Deskripsi = @deskripsi, " &
            "Tanggal_Dibuat = @tanggal, Deadline = @deadline, Status = @status, Prioritas = @prioritas " &
            "WHERE ID_Tugas = @id"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idMatkul", idMatkul)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@deadline", deadline.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@prioritas", prioritas)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data tugas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTugas(idTugas As Integer) As Boolean
        Dim query As String = "DELETE FROM tbtugas WHERE ID_Tugas = @id"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idTugas)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function CountTugasByStatus(status As String) As Integer
        Dim query As String = "SELECT COUNT(*) FROM tbtugas WHERE Status = @s"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@s", status)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Function CountAllTugas() As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbtugas", conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function
End Module