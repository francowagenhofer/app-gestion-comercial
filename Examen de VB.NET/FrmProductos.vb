Public Class FrmProductos
    Private productoNegocio As New ProductoNegocio()
    Private listaProductos As List(Of Producto)

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCampoBusqueda.Items.Add("ID")
            cbCampoBusqueda.Items.Add("Nombre")
            cbCampoBusqueda.Items.Add("Precio")
            cbCampoBusqueda.Items.Add("Categoria")
            cbCampoBusqueda.Text = "Campo"

            CargarProductos()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar los productos: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarProductos()
        Try
            listaProductos = productoNegocio.ListarProductos()
            ActualizarDataGridView(listaProductos)
        Catch ex As Exception
            MessageBox.Show($"Error al listar los productos: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDataGridView(productos As List(Of Producto))
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = productos
        dgvProductos.Refresh()
    End Sub

    Private Sub btnBuscarAvanzado_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Try
            Dim campo As String = cbCampoBusqueda.SelectedItem?.ToString()
            Dim filtro As String = txtFiltroAvanzado.Text.Trim()

            If String.IsNullOrEmpty(campo) Then
                MessageBox.Show("Por favor, seleccione un campo de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(filtro) Then
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim productosFiltrados As List(Of Producto) = productoNegocio.FiltrarProductosPorCampo(campo, filtro)

            ActualizarDataGridView(productosFiltrados)
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la búsqueda avanzada: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbCampoBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCampoBusqueda.SelectedIndexChanged
        If cbCampoBusqueda.SelectedIndex >= 0 Then
            txtFiltroAvanzado.Enabled = True
        End If
    End Sub

    Private Sub txtFiltroRapido_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroRapido.TextChanged
        Try
            Dim filtro As String = txtFiltroRapido.Text.Trim().ToUpper()

            Dim listaFiltrada As List(Of Producto)
            If filtro.Length >= 2 Then
                listaFiltrada = listaProductos.FindAll(Function(p)
                                                           Return p.Nombre.ToUpper().Contains(filtro) OrElse
                                                              p.Precio.ToString().Contains(filtro) OrElse
                                                              p.Categoria.ToUpper().Contains(filtro) OrElse
                                                              p.ID.ToString().Contains(filtro)
                                                       End Function)
            Else
                listaFiltrada = listaProductos
            End If

            ActualizarDataGridView(listaFiltrada)
        Catch ex As Exception
            MessageBox.Show($"Error al filtrar productos: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmGestionarProducto("Agregar")
            If frm.ShowDialog() = DialogResult.OK Then
                CargarProductos()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnAgregar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvProductos.SelectedRows.Count > 0 Then
                Dim productoSeleccionado As New Producto With {
                    .ID = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("ID").Value),
                    .Nombre = dgvProductos.SelectedRows(0).Cells("Nombre").Value.ToString(),
                    .Precio = Convert.ToDouble(dgvProductos.SelectedRows(0).Cells("Precio").Value),
                    .Categoria = dgvProductos.SelectedRows(0).Cells("Categoria").Value.ToString()
                }
                Dim frm As New frmGestionarProducto("Modificar", productoSeleccionado)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarProductos()
                End If
            Else
                MessageBox.Show("Debe seleccionar un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnModificar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvProductos.SelectedRows.Count > 0 Then
                Dim productoSeleccionado As New Producto With {
                    .ID = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("ID").Value),
                    .Nombre = dgvProductos.SelectedRows(0).Cells("Nombre").Value.ToString(),
                    .Precio = Convert.ToDouble(dgvProductos.SelectedRows(0).Cells("Precio").Value),
                    .Categoria = dgvProductos.SelectedRows(0).Cells("Categoria").Value.ToString()
                }
                Dim frm As New frmGestionarProducto("Eliminar", productoSeleccionado)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarProductos()
                End If
            Else
                MessageBox.Show("Debe seleccionar un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnEliminar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizarLista_Click(sender As Object, e As EventArgs) Handles btnActualizarLista.Click
        Try
            txtFiltroRapido.Clear()
            CargarProductos()
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnActualizarLista_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
