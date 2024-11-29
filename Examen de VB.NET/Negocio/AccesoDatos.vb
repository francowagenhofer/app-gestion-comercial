Imports System.Data.SqlClient
Imports System.Configuration

Namespace Negocio
    Public Class AccesoADatos
        Private conexion As SqlConnection
        Private comando As SqlCommand
        Private lector As SqlDataReader

        Public ReadOnly Property LectorReader As SqlDataReader
            Get
                Return lector
            End Get
        End Property

        Public Sub New()
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            conexion = New SqlConnection(connectionString)
            'conexion = New SqlConnection("Server=localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;")
            comando = New SqlCommand()
        End Sub

        Public Sub SetearConsulta(consulta As String)
            comando.CommandType = CommandType.Text
            comando.CommandText = consulta
        End Sub

        Public Sub EjecutarLectura()
            comando.Connection = conexion
            Try
                conexion.Open()
                lector = comando.ExecuteReader()
            Catch ex As Exception
                Throw New Exception("Error al ejecutar lectura", ex)
            End Try
        End Sub

        Public Sub EjecutarAccion()
            comando.Connection = conexion
            Try
                conexion.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al ejecutar acción", ex)
            End Try
        End Sub

        Public Sub SetearParametro(nombre As String, valor As Object)
            comando.Parameters.AddWithValue(nombre, valor)
        End Sub

        Public Sub CerrarConexion()
            If lector IsNot Nothing Then
                lector.Close()
            End If
            conexion.Close()
        End Sub
    End Class
End Namespace

