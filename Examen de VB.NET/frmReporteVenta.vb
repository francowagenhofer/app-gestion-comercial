Public Class frmReporteVenta
    Private ventaNegocio As New VentaNegocio()
    Private reporteNegocio As New ReporteNegocio()

    Private Sub frmReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim listaVentas As List(Of Venta) = ventaNegocio.ListarVentas()
            dgvVentas.DataSource = listaVentas

            ConfigurarDgvVentas()
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarDgvVentas()
        dgvVentas.Columns("IDCliente").Visible = False
        dgvVentas.Columns("ID").HeaderText = "ID Venta"
        dgvVentas.Columns("ClienteNombre").HeaderText = "Cliente"
        dgvVentas.Columns("Fecha").HeaderText = "Fecha de Venta"
        dgvVentas.Columns("Total").HeaderText = "Total de Venta"
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub ConfigurarDgvDetalleVenta()
        dgvReporteVenta.Columns("IDVenta").Visible = False
        dgvReporteVenta.Columns("NombreCliente").HeaderText = "Cliente"
        dgvReporteVenta.Columns("Telefono").HeaderText = "Teléfono"
        dgvReporteVenta.Columns("Correo").HeaderText = "Correo"
        dgvReporteVenta.Columns("NombreProducto").HeaderText = "Producto"
        dgvReporteVenta.Columns("CategoriaProducto").HeaderText = "Categoría"
        dgvReporteVenta.Columns("PrecioUnitario").HeaderText = "Precio Unitario"
        dgvReporteVenta.Columns("Cantidad").HeaderText = "Cantidad"
        dgvReporteVenta.Columns("PrecioTotal").HeaderText = "Total Producto"
        'dgvReporteVenta.Columns("Total").HeaderText = "Total de Venta"
        dgvReporteVenta.Columns("FechaVenta").HeaderText = "Fecha de Venta"
        dgvReporteVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReporteVenta.ReadOnly = True
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Try
            If dgvVentas.SelectedRows.Count = 0 Then
                MessageBox.Show("Debe seleccionar una venta para generar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idVenta As Integer = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("ID").Value)

            Dim detalleVenta As DataTable = reporteNegocio.ReporteVentaPorID(idVenta)

            If detalleVenta Is Nothing OrElse detalleVenta.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron detalles para esta venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            dgvReporteVenta.DataSource = detalleVenta
            ConfigurarDgvDetalleVenta()
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message & vbNewLine & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
