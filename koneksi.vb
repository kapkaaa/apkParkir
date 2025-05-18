Imports MySql.Data.MySqlClient

Module koneksi
    Public conn As New MySqlConnection("server=localhost;user id=root;password=;database=parkir")

    Public Sub sql()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
