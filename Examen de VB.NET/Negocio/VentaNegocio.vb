Imports Examen_de_VB.NET.Negocio

Public Class VentaNegocio

    Public Function ListarVentas() As List(Of Venta)
        Dim accesoDatos As New AccesoADatos()
        Dim consulta As String = "SELECT v.ID, v.IDCliente, c.Cliente AS NombreCliente, v.Fecha, v.Total " &
                             "FROM ventas v " &
                             "JOIN clientes c ON v.IDCliente = c.ID"
        Dim ventas As New List(Of Venta)()

        Try
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.EjecutarLectura()

            While accesoDatos.LectorReader.Read()
                ventas.Add(New Venta With {
                .ID = Convert.ToInt32(accesoDatos.LectorReader("ID")),
                .IDCliente = Convert.ToInt32(accesoDatos.LectorReader("IDCliente")),
                .ClienteNombre = accesoDatos.LectorReader("NombreCliente").ToString(),
                .Fecha = Convert.ToDateTime(accesoDatos.LectorReader("Fecha")),
                .Total = Convert.ToDouble(accesoDatos.LectorReader("Total"))
            })
            End While
        Catch ex As Exception
            Throw New Exception("Error al listar ventas: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try

        Return ventas
    End Function

    Public Function ListarItemsPorVenta(idVenta As Integer) As List(Of VentaItem)
        Dim accesoDatos As New AccesoADatos()

        Dim consulta As String = "SELECT * FROM ventasitems WHERE IDVenta = @IDVenta"
        accesoDatos.SetearConsulta(consulta)
        accesoDatos.SetearParametro("@IDVenta", idVenta)
        accesoDatos.EjecutarLectura()

        Dim items As New List(Of VentaItem)()

        While accesoDatos.LectorReader.Read()
            items.Add(New VentaItem With {
                .ID = Convert.ToInt32(accesoDatos.LectorReader("ID")),
                .IDVenta = Convert.ToInt32(accesoDatos.LectorReader("IDVenta")),
                .IDProducto = Convert.ToInt32(accesoDatos.LectorReader("IDProducto")),
                .PrecioUnitario = Convert.ToDouble(accesoDatos.LectorReader("PrecioUnitario")),
                .Cantidad = Convert.ToDouble(accesoDatos.LectorReader("Cantidad")),
                .PrecioTotal = Convert.ToDouble(accesoDatos.LectorReader("PrecioTotal"))
            })
        End While

        accesoDatos.CerrarConexion()
        Return items
    End Function

    Public Function GuardarVenta(venta As Venta) As Integer
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consultaVenta As String = "INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDCliente, @Fecha, @Total)"
            accesoDatos.SetearConsulta(consultaVenta)
            accesoDatos.SetearParametro("@IDCliente", venta.IDCliente)
            accesoDatos.SetearParametro("@Fecha", venta.Fecha)
            accesoDatos.SetearParametro("@Total", venta.Total)
            accesoDatos.EjecutarLectura()

            If accesoDatos.LectorReader.Read() Then
                Return Convert.ToInt32(accesoDatos.LectorReader("ID"))
            End If

            Return -1
        Catch ex As Exception
            Throw New Exception("Error al guardar la venta: " & ex.Message)
        End Try
    End Function

    Public Sub GuardarItemsVenta(idVenta As Integer, items As List(Of VentaItem))
        Dim accesoDatos As New AccesoADatos()
        Try
            For Each item As VentaItem In items
                Dim consultaItem As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) " &
                                         "VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
                accesoDatos.SetearConsulta(consultaItem)
                accesoDatos.SetearParametro("@IDVenta", idVenta)
                accesoDatos.SetearParametro("@IDProducto", item.IDProducto)
                accesoDatos.SetearParametro("@PrecioUnitario", item.PrecioUnitario)
                accesoDatos.SetearParametro("@Cantidad", item.Cantidad)
                accesoDatos.SetearParametro("@PrecioTotal", item.PrecioTotal)
                accesoDatos.EjecutarAccion()
            Next
        Catch ex As Exception
            Throw New Exception("Error al guardar los ítems de la venta: " & ex.Message)
        End Try

    End Sub

    Public Sub ModificarVenta(venta As Venta)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consultaVenta As String = "UPDATE ventas SET IDCliente = @IDCliente, Fecha = @Fecha, Total = @Total WHERE ID = @ID"
            accesoDatos.SetearConsulta(consultaVenta)
            accesoDatos.SetearParametro("@IDCliente", venta.IDCliente)
            accesoDatos.SetearParametro("@Fecha", venta.Fecha)
            accesoDatos.SetearParametro("@Total", venta.Total)
            accesoDatos.SetearParametro("@ID", venta.ID)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al modificar la venta: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Sub


    Public Sub ModificarItemsDeVenta(idVenta As Integer, items As List(Of VentaItem))
        Dim accesoDatos As New AccesoADatos()
        Try
            For Each item As VentaItem In items
                Dim consultaUpdate As String = "UPDATE ventasitems SET " &
                                           "PrecioUnitario = @PrecioUnitario, " &
                                           "Cantidad = @Cantidad, " &
                                           "PrecioTotal = @PrecioTotal, " &
                                           "IDProducto = @IDProducto " &
                                           "WHERE IDVenta = @IDVenta AND IDProducto = @IDProducto"

                accesoDatos.SetearConsulta(consultaUpdate)
                accesoDatos.SetearParametro("@IDVenta", idVenta)
                accesoDatos.SetearParametro("@IDProducto", item.IDProducto)
                accesoDatos.SetearParametro("@PrecioUnitario", item.PrecioUnitario)
                accesoDatos.SetearParametro("@Cantidad", item.Cantidad)
                accesoDatos.SetearParametro("@PrecioTotal", item.PrecioTotal)

                accesoDatos.EjecutarAccion()
            Next
        Catch ex As Exception
            Throw New Exception("Error al modificar los ítems de la venta: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Sub

    Public Sub EliminarItemsDeVenta(idVenta As Integer)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consultaEliminarItems As String = "DELETE FROM ventasitems WHERE IDVenta = @IDVenta"
            accesoDatos.SetearConsulta(consultaEliminarItems)
            accesoDatos.SetearParametro("@IDVenta", idVenta)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al eliminar los ítems de la venta: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Sub

    Public Sub EliminarVenta(idVenta As Integer)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim consultaEliminarVenta As String = "DELETE FROM ventas WHERE ID = @ID"
            accesoDatos.SetearConsulta(consultaEliminarVenta)
            accesoDatos.SetearParametro("@ID", idVenta)
            accesoDatos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al eliminar la venta: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Sub

    Public Function FiltrarVentasPorCampo(campo As String, filtro As String) As List(Of Venta)
        Dim accesoDatos As New AccesoADatos()
        Try
            Dim camposValidos As List(Of String) = New List(Of String) From {"ID", "IDCliente", "Fecha", "Total", "Cliente"}
            If Not camposValidos.Contains(campo) Then
                Throw New Exception("El campo especificado no es válido.")
            End If

            Dim consulta As String = "
            SELECT 
                v.ID,
                v.IDCliente,
                c.Cliente AS Nombre,
                v.Fecha,
                v.Total
            FROM ventas v
            INNER JOIN clientes c ON v.IDCliente = c.ID"

            If campo = "Cliente" Then
                consulta &= " WHERE c.Cliente LIKE @Filtro"
            Else
                consulta &= $" WHERE v.{campo} LIKE @Filtro"
            End If

            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@Filtro", "%" & filtro & "%")
            accesoDatos.EjecutarLectura()

            Dim ventas As New List(Of Venta)()
            While accesoDatos.LectorReader.Read()
                ventas.Add(New Venta With {
                .ID = Convert.ToInt32(accesoDatos.LectorReader("ID")),
                .IDCliente = Convert.ToInt32(accesoDatos.LectorReader("IDCliente")),
                .ClienteNombre = accesoDatos.LectorReader("Nombre").ToString(),
                .Fecha = Convert.ToDateTime(accesoDatos.LectorReader("Fecha")),
                .Total = Convert.ToDouble(accesoDatos.LectorReader("Total"))
            })
            End While

            Return ventas
        Catch ex As Exception
            Throw New Exception("Error al filtrar ventas: " & ex.Message)
        Finally
            accesoDatos.CerrarConexion()
        End Try
    End Function


End Class