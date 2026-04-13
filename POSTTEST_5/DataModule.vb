Imports MySqlConnector

Module DataModule
    Public Function GetAllTugas() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query = "SELECT * FROM tbtugas ORDER BY idTugas ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetStatistik() As Dictionary(Of String, Integer)
        Dim d As New Dictionary(Of String, Integer)
        Try
            Dim query = "SELECT COUNT(*) total,
                     SUM(status='Belum Selesai') belum,
                     SUM(status='Proses') proses,
                     SUM(status='Selesai') selesai FROM tbtugas"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using r = cmd.ExecuteReader()
                        If r.Read() Then
                            d("Total") = r("total")
                            d("Belum") = r("belum")
                            d("Proses") = r("proses")
                            d("Selesai") = r("selesai")
                        End If
                    End Using
                End Using
            End Using
        Catch
            d("Total") = 0 : d("Belum") = 0 : d("Proses") = 0 : d("Selesai") = 0
        End Try
        Return d
    End Function

    Public Function GetTaskById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query = "SELECT * FROM tbtugas WHERE idTugas = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetTugasByStatus(status As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query = "SELECT * FROM tbtugas WHERE status = @status " &
                    "ORDER BY FIELD(prioritas,'Tinggi','Sedang','Rendah')," &
                    " deadline ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@status", status)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal filter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetTugasByPrioritas(prioritas As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query = "SELECT * FROM tbtugas WHERE prioritas = @prioritas " &
            "ORDER BY deadline ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@prioritas", prioritas)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal filter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTugas(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query = "SELECT * FROM tbtugas WHERE judul LIKE @keyword OR deskripsi LIKE @keyword"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SimpanTugas(judul As String, deskripsi As String, tanggal As Date, deadline As Date, status As String, prioritas As String) As Boolean
        Try
            Dim query = "INSERT INTO tbtugas(judul,deskripsi,tglDibuat,deadline,status,prioritas) VALUES(@judul,@deskripsi,@tanggal,@deadline,@status,@prioritas)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@deadline", deadline)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@prioritas", prioritas)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTugas(id As Integer, judul As String, deskripsi As String, deadline As Date, status As String, prioritas As String) As Boolean
        Try
            Dim query = "UPDATE tbtugas SET " &
                    "judul=@judul, " &
                    "deskripsi=@deskripsi, " &
                    "deadline=@deadline, " &
                    "status=@status, " &
                    "prioritas=@prioritas " &
                    "WHERE idTugas=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@deadline", deadline)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@prioritas", prioritas)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTugas(id As Integer) As Boolean
        Try
            Dim query = "DELETE FROM tbtugas WHERE idTugas=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try
    End Function
End Module