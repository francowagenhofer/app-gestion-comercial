Imports Examen_de_VB.NET.Negocio

Public Class ClienteNegocio

    Public Function ListarClientes() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)()
        Dim accesoDatos As New AccesoADatos()

        Try
            Dim consulta As String = "SELECT * FROM clientes"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.EjecutarLectura()

            While accesoDatos.LectorReader.Read()
                Dim aux As New Cliente()

                aux.ID = Convert.ToInt32(accesoDatos.LectorReader("ID"))
                aux.Nombre = accesoDatos.LectorReader("Cliente").ToString()

                If Not IsDBNull(accesoDatos.LectorReader("Telefono")) Then
                    aux.Telefono = accesoDatos.LectorReader("Telefono").ToString()
                End If

                If Not IsDBNull(accesoDatos.LectorReader("Correo")) Then
                    aux.Correo = accesoDatos.LectorReader("Correo").ToString()
                End If

                clientes.Add(aux)
            End While

            Return clientes
        Catch ex As Exception
            Throw New Exception("Error al listar clientes: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Function

    Public Function FiltrarClientesPorCampo(campo As String, filtro As String) As List(Of Cliente)
        Dim clientes As New List(Of Cliente)()
        Dim accesoDatos As New AccesoADatos()

        Try
            Dim camposValidos As List(Of String) = New List(Of String) From {"ID", "Cliente", "Telefono", "Correo"}
            If Not camposValidos.Contains(campo) Then
                Throw New Exception("El campo especificado no es válido.")
            End If

            Dim consulta As String = $"SELECT * FROM clientes WHERE {campo} LIKE @Filtro"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Filtro", "%" & filtro & "%")
            accesoDatos.EjecutarLectura()

            While accesoDatos.LectorReader.Read()
                Dim aux As New Cliente() With {
                .ID = Convert.ToInt32(accesoDatos.LectorReader("ID")),
                .Nombre = accesoDatos.LectorReader("Cliente").ToString(),
                .Telefono = If(Not IsDBNull(accesoDatos.LectorReader("Telefono")), accesoDatos.LectorReader("Telefono").ToString(), ""),
                .Correo = If(Not IsDBNull(accesoDatos.LectorReader("Correo")), accesoDatos.LectorReader("Correo").ToString(), "")
            }
                clientes.Add(aux)
            End While

            Return clientes
        Catch ex As Exception
            Throw New Exception("Error al filtrar clientes: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Function

    Public Sub AgregarCliente(cliente As Cliente)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Cliente", cliente.Nombre)
            accesoDatos.SetearParametro("@Telefono", cliente.Telefono)
            accesoDatos.SetearParametro("@Correo", cliente.Correo)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al agregar cliente: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarCliente(cliente As Cliente)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Cliente", cliente.Nombre)
            accesoDatos.SetearParametro("@Telefono", cliente.Telefono)
            accesoDatos.SetearParametro("@Correo", cliente.Correo)
            accesoDatos.SetearParametro("@ID", cliente.ID)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al modificar cliente: " & ex.Message)
        End Try
    End Sub

    Public Sub EliminarCliente(id As Integer)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consulta As String = "DELETE FROM clientes WHERE ID = @ID"
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@ID", id)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al eliminar cliente: " & ex.Message)
        End Try
    End Sub
End Class
