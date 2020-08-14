Public Class VerPaises

    Public Sub New()
        InitializeComponent()

        Dim query As String = "SELECT P.COUNTRYNAME AS Pais, C.NAME AS Capital, P.POPULATION AS Poblacion, P.INDEPYEAR FROM COUNTRY P INNER JOIN CITY C ON P.CAPITAL = C.ID;"
        Dim query2 As String = "SELECT * FROM CITY"
        Dim query3 As String = "SELECT * FROM COUNTRYLANGUAGE"
        Dim query4 As String = "SELECT * FROM COUNTRY"

        Dim conectar As ConexionBD = ConexionBD.Instance

        conectar.cargarDatos(GridCargarPaises, query)
        conectar.cargarDatos(GridCiudades, query2)
        conectar.cargarDatos(GridLenguajes, query3)
        conectar.cargarDatos(GridPaises, query4)

        Calculos()
    End Sub

    Private Sub TextoBuscarCiudad_TextChanged(sender As Object, e As EventArgs) Handles TextoBuscarCiudad.TextChanged
        For index As Integer = 0 To GridCargarPaises.RowCount - 1
            If sender.Text = "" Then
                GridCargarPaises.Rows(index).Visible = True
            Else
                If Not sender.Text = GridCargarPaises.Rows(index).Cells(1).Value Then
                    Me.GridCargarPaises.CurrentCell = Nothing
                    GridCargarPaises.Rows(index).Visible = False
                Else
                    GridCargarPaises.Rows(index).Visible = True
                End If
            End If
        Next
    End Sub

    Private Sub Calculos()
        LabelValorCantPaises.Text = GridPaises.RowCount()
        LabelValorCantCiudades.Text = GridCiudades.RowCount()
        LabelValorCantIdiomas.Text = GridLenguajes.RowCount()
    End Sub
End Class
