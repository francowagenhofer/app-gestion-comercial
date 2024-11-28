Public Class frmReporteProducto
    Private productoNegocio As New ProductoNegocio()
    Private reporteNegocio As New ReporteNegocio()

    Private Sub frmReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim listaProductos As List(Of Producto) = ProductoNegocio.ListarProductos()
            dgvProductos.DataSource = listaProductos

            ConfigurarDgvProductos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarDgvProductos()
        dgvProductos.Columns("ID").Visible = False
        dgvProductos.Columns("Nombre").HeaderText = "Producto"
        dgvProductos.Columns("Precio").HeaderText = "Precio"
        dgvProductos.Columns("Categoria").HeaderText = "Categoría"
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub ConfigurarDgvDetalleProducto()
        dgvReporteProducto.Columns("Mes").HeaderText = "Mes"
        dgvReporteProducto.Columns("Año").HeaderText = "Año"
        dgvReporteProducto.Columns("CantidadTotal").HeaderText = "Cantidad Total Vendida"
        dgvReporteProducto.Columns("NombreProducto").HeaderText = "Producto"
        dgvReporteProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReporteProducto.ReadOnly = True
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Try
            If dgvProductos.SelectedRows.Count = 0 Then
                MessageBox.Show("Debe seleccionar un producto para generar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idProducto As Integer = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("ID").Value)

            Dim detalleProducto As DataTable = reporteNegocio.ReporteProductosVendidosMensualmente(idProducto)

            If detalleProducto Is Nothing OrElse detalleProducto.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron datos para este producto en el año actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            dgvReporteProducto.DataSource = detalleProducto
            ConfigurarDgvDetalleProducto()
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
