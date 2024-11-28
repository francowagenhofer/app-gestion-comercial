Imports System.Data.SqlClient


Namespace Negocio
    Public Class AccesoADatos
        Private conexion As SqlConnection
        Private comando As SqlCommand
        Private lector As SqlDataReader

        ' Propiedad para obtener el lector
        Public ReadOnly Property LectorReader As SqlDataReader
            Get
                Return lector
            End Get
        End Property

        ' Constructor que inicializa la conexión y el comando
        Public Sub New()
            'conexion = New SqlConnection("Server=localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;")

            conexion = New SqlConnection("Server=WX1\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;")

            comando = New SqlCommand()
        End Sub

        ' Método para setear las consultas SQL
        Public Sub SetearConsulta(consulta As String)
            comando.CommandType = CommandType.Text
            comando.CommandText = consulta
        End Sub

        ' Método para ejecutar una consulta de lectura (Select)
        Public Sub EjecutarLectura()
            comando.Connection = conexion
            Try
                conexion.Open()
                lector = comando.ExecuteReader()
            Catch ex As Exception
                Throw New Exception("Error al ejecutar lectura", ex)
            End Try
        End Sub

        ' Método para ejecutar acciones (Insert, Update, Delete)
        Public Sub EjecutarAccion()
            comando.Connection = conexion
            Try
                conexion.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al ejecutar acción", ex)
            End Try
        End Sub

        ' Método para agregar parámetros a la consulta
        Public Sub SetearParametro(nombre As String, valor As Object)
            comando.Parameters.AddWithValue(nombre, valor)
        End Sub

        ' Método para cerrar la conexión
        Public Sub CerrarConexion()
            If lector IsNot Nothing Then
                lector.Close()
            End If
            conexion.Close()
        End Sub
    End Class
End Namespace

