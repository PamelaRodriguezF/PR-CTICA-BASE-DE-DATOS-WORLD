Imports MySql.Data.MySqlClient

Public Class ConexionBD
    Private Sub New()

    End Sub

    Public Sub cargarDatos(gridDeDatos As DataGridView, query As String)

        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As New MySqlDataAdapter
        Dim ds As New DataSet
        Try
            conexion.ConnectionString = "server=localhost;database=world;Uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = query

            reader.SelectCommand = cmd

            reader.Fill(ds)

            conexion.Close()

            gridDeDatos.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CargarString(query As String)

        Return query
    End Function

    Public Shared ReadOnly Property Instance As ConexionBD
        Get
            Static ConexionGlobal As New ConexionBD
            Return ConexionGlobal
        End Get
    End Property

End Class
