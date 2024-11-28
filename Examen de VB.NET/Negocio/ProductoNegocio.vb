Imports Examen_de_VB.NET.Negocio

Public Class ProductoNegocio

    Public Function ListarProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)()
        Dim accesoDatos As New AccesoADatos()

        Try
            Dim consulta As String = "SELECT * FROM productos"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.EjecutarLectura()

            While accesoDatos.LectorReader.Read()
                Dim aux As New Producto()

                aux.ID = Convert.ToInt32(accesoDatos.LectorReader("ID"))
                aux.Nombre = accesoDatos.LectorReader("Nombre").ToString()
                aux.Precio = Convert.ToDouble(accesoDatos.LectorReader("Precio"))
                aux.Categoria = accesoDatos.LectorReader("Categoria").ToString()

                productos.Add(aux)
            End While

            Return productos
        Catch ex As Exception
            Throw New Exception("Error al listar productos: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Function

    Public Function FiltrarProductosPorCampo(campo As String, filtro As String) As List(Of Producto)
        Dim productos As New List(Of Producto)()
        Dim accesoDatos As New AccesoADatos()

        Try
            Dim camposValidos As List(Of String) = New List(Of String) From {"ID", "Nombre", "Precio", "Categoria"}
            If Not camposValidos.Contains(campo) Then
                Throw New Exception("El campo especificado no es válido.")
            End If

            Dim consulta As String = $"SELECT * FROM productos WHERE {campo} LIKE @Filtro"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Filtro", "%" & filtro & "%")
            accesoDatos.EjecutarLectura()

            While accesoDatos.LectorReader.Read()
                Dim aux As New Producto()

                aux.ID = Convert.ToInt32(accesoDatos.LectorReader("ID"))
                aux.Nombre = accesoDatos.LectorReader("Nombre").ToString()
                aux.Precio = Convert.ToDouble(accesoDatos.LectorReader("Precio"))
                aux.Categoria = accesoDatos.LectorReader("Categoria").ToString()

                productos.Add(aux)
            End While

            Return productos
        Catch ex As Exception
            Throw New Exception("Error al filtrar productos: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Function

    Public Sub AgregarProducto(producto As Producto)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Nombre", producto.Nombre)
            accesoDatos.SetearParametro("@Precio", producto.Precio)
            accesoDatos.SetearParametro("@Categoria", producto.Categoria)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al agregar producto: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarProducto(producto As Producto)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Nombre", producto.Nombre)
            accesoDatos.SetearParametro("@Precio", producto.Precio)
            accesoDatos.SetearParametro("@Categoria", producto.Categoria)
            accesoDatos.SetearParametro("@ID", producto.ID)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al modificar producto: " & ex.Message)
        End Try
    End Sub

    Public Sub EliminarProducto(id As Integer)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "DELETE FROM productos WHERE ID = @ID"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@ID", id)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al eliminar producto: " & ex.Message)
        End Try
    End Sub
End Class
