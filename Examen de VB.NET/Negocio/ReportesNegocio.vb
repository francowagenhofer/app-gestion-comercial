Imports Examen_de_VB.NET.Negocio

Public Class ReporteNegocio

    Public Function ReporteVentaPorID(idVenta As Integer) As DataTable
        Dim accesoDatos As New AccesoADatos()
        Dim dt As New DataTable()
        Try
            Dim consulta As String = "
            SELECT 
                v.ID AS IDVenta,
                c.Cliente AS NombreCliente,
                c.Telefono,
                c.Correo,
                p.Nombre AS NombreProducto,
                p.Categoria AS CategoriaProducto,
                vi.PrecioUnitario,
                vi.Cantidad,
                vi.PrecioTotal,
                v.Fecha AS FechaVenta 
            FROM ventas v
            INNER JOIN clientes c ON v.IDCliente = c.ID
            INNER JOIN ventasitems vi ON v.ID = vi.IDVenta
            INNER JOIN productos p ON vi.IDProducto = p.ID
            WHERE v.ID = @IDVenta"
            'v.Total AS TotalVenta
            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@IDVenta", idVenta)
            accesoDatos.EjecutarLectura()

            If accesoDatos.LectorReader IsNot Nothing AndAlso Not accesoDatos.LectorReader.IsClosed Then
                dt.Load(accesoDatos.LectorReader)
            Else
                Throw New Exception("No se encontraron datos para la venta solicitada.")
            End If

        Catch ex As Exception
            Throw New Exception("Error al obtener el reporte de venta por ID: " & ex.Message, ex)
        Finally
            accesoDatos.CerrarConexion()
        End Try
        Return dt
    End Function

    Public Function ReporteProductosVendidosMensualmente(idProducto As Integer) As DataTable
        Dim accesoDatos As New AccesoADatos()
        Dim dt As New DataTable()

        Try
            Dim consulta As String = "
            WITH Meses AS (
                SELECT 1 AS Mes UNION ALL
                SELECT 2 UNION ALL
                SELECT 3 UNION ALL
                SELECT 4 UNION ALL
                SELECT 5 UNION ALL
                SELECT 6 UNION ALL
                SELECT 7 UNION ALL
                SELECT 8 UNION ALL
                SELECT 9 UNION ALL
                SELECT 10 UNION ALL
                SELECT 11 UNION ALL
                SELECT 12
            )
            SELECT 
                Meses.Mes,
                YEAR(GETDATE()) AS Año,
                ISNULL(SUM(CASE WHEN MONTH(v.Fecha) = Meses.Mes THEN vi.Cantidad ELSE 0 END), 0) AS CantidadTotal,
                p.Nombre AS NombreProducto
            FROM Meses
            LEFT JOIN productos p ON p.ID = @IDProducto
            LEFT JOIN ventasitems vi ON vi.IDProducto = p.ID
            LEFT JOIN ventas v ON vi.IDVenta = v.ID AND YEAR(v.Fecha) = YEAR(GETDATE())
            WHERE p.ID = @IDProducto
            GROUP BY Meses.Mes, p.Nombre
            ORDER BY Meses.Mes"

            accesoDatos.SetearConsulta(consulta)
            accesoDatos.SetearParametro("@IDProducto", idProducto)
            accesoDatos.EjecutarLectura()

            If accesoDatos.LectorReader IsNot Nothing AndAlso Not accesoDatos.LectorReader.IsClosed Then
                dt.Load(accesoDatos.LectorReader)
            Else
                Throw New Exception("No se encontraron datos para el producto solicitado.")
            End If
        Catch ex As Exception
            Throw New Exception("Error al generar el reporte de productos vendidos mensualmente: " & ex.Message, ex)
        Finally
            accesoDatos.CerrarConexion()
        End Try

        Return dt
    End Function

    'Public Function ReporteProductosVendidosMensualmente(idProducto As Integer, fechaInicio As DateTime, fechaFin As DateTime) As DataTable
    '    Dim accesoDatos As New AccesoADatos()
    '    Dim dt As New DataTable()

    '    Try
    '        Dim consulta As String = "
    '        SELECT 
    '            p.Nombre AS NombreProducto,
    '            MONTH(v.Fecha) AS Mes,
    '            YEAR(v.Fecha) AS Año,
    '            SUM(vi.Cantidad) AS CantidadTotal
    '        FROM ventasitems vi
    '        INNER JOIN productos p ON vi.IDProducto = p.ID
    '        INNER JOIN ventas v ON vi.IDVenta = v.ID
    '        WHERE vi.IDProducto = @IDProducto AND v.Fecha BETWEEN @FechaInicio AND @FechaFin
    '        GROUP BY p.Nombre, MONTH(v.Fecha), YEAR(v.Fecha)
    '        ORDER BY Año, Mes, NombreProducto"

    '        accesoDatos.SetearConsulta(consulta)
    '        accesoDatos.SetearParametro("@IDProducto", idProducto)
    '        accesoDatos.SetearParametro("@FechaInicio", fechaInicio)
    '        accesoDatos.SetearParametro("@FechaFin", fechaFin)
    '        accesoDatos.EjecutarLectura()

    '        If accesoDatos.LectorReader IsNot Nothing AndAlso Not accesoDatos.LectorReader.IsClosed Then
    '            dt.Load(accesoDatos.LectorReader)
    '        Else
    '            Throw New Exception("No se encontraron datos para el producto solicitado.")
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception("Error al generar el reporte de productos vendidos mensualmente: " & ex.Message, ex)
    '    Finally
    '        accesoDatos.CerrarConexion()
    '    End Try

    '    Return dt
    'End Function
End Class
