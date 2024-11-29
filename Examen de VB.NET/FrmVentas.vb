Public Class FrmVentas
    Private ventaNegocio As New VentaNegocio()
    Private listaVentas As List(Of Venta)

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCampoBusqueda.Items.Add("ID")
            cbCampoBusqueda.Items.Add("IDCliente")
            cbCampoBusqueda.Items.Add("Cliente")
            cbCampoBusqueda.Items.Add("Fecha")
            cbCampoBusqueda.Items.Add("Total")
            cbCampoBusqueda.Text = "Campo"

            CargarVentas()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar las ventas: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarVentas()
        Try
            listaVentas = ventaNegocio.ListarVentas()
            ActualizarDataGridView(listaVentas)
        Catch ex As Exception
            MessageBox.Show($"Error al listar las ventas: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDataGridView(ventas As List(Of Venta))
        dgvVentas.DataSource = Nothing
        dgvVentas.DataSource = ventas
        dgvVentas.Refresh()
    End Sub

    Private Sub btnBuscarAvanzado_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
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

            Dim ventasFiltradas As List(Of Venta) = ventaNegocio.FiltrarVentasPorCampo(campo, filtro)
            ActualizarDataGridView(ventasFiltradas)
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

            Dim listaFiltrada As List(Of Venta)
            If filtro.Length >= 2 Then
                listaFiltrada = listaVentas.FindAll(Function(v)
                                                        Return v.IDCliente.ToString().Contains(filtro) OrElse
                                                               v.ClienteNombre.ToUpper().Contains(filtro) OrElse
                                                               v.Fecha.ToString("yyyy-MM-dd").Contains(filtro) OrElse
                                                               v.Total.ToString().Contains(filtro)
                                                    End Function)
            Else
                listaFiltrada = listaVentas
            End If

            ActualizarDataGridView(listaFiltrada)
        Catch ex As Exception
            MessageBox.Show($"Error al filtrar las ventas: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmGestionarVenta("Agregar")
            If frm.ShowDialog() = DialogResult.OK Then
                CargarVentas()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al agregar la venta: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvVentas.SelectedRows.Count > 0 Then
                Dim ventaSeleccionada As New Venta With {
                .ID = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("ID").Value),
                .IDCliente = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("IDCliente").Value),
                .Fecha = Convert.ToDateTime(dgvVentas.SelectedRows(0).Cells("Fecha").Value),
                .Total = Convert.ToDouble(dgvVentas.SelectedRows(0).Cells("Total").Value)
            }

                Dim frm As New FrmGestionarVenta("Modificar", ventaSeleccionada)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarVentas()
                End If
            Else
                MessageBox.Show("Debe seleccionar una venta para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al modificar la venta: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvVentas.SelectedRows.Count > 0 Then
                Dim ventaSeleccionada As New Venta With {
                .ID = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("ID").Value),
                .IDCliente = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("IDCliente").Value),
                .Fecha = Convert.ToDateTime(dgvVentas.SelectedRows(0).Cells("Fecha").Value),
                .Total = Convert.ToDouble(dgvVentas.SelectedRows(0).Cells("Total").Value)
            }

                Dim frm As New FrmGestionarVenta("Eliminar", ventaSeleccionada)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarVentas()
                End If
            Else
                MessageBox.Show("Debe seleccionar una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al eliminar la venta: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click
        Try
            If dgvVentas.SelectedRows.Count > 0 Then
                Dim ventaSeleccionada As New Venta With {
                .ID = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("ID").Value),
                .IDCliente = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("IDCliente").Value),
                .Fecha = Convert.ToDateTime(dgvVentas.SelectedRows(0).Cells("Fecha").Value),
                .Total = Convert.ToDouble(dgvVentas.SelectedRows(0).Cells("Total").Value)
            }

                Dim frm As New FrmGestionarVenta("Ver Detalle", ventaSeleccionada)
                frm.ShowDialog()
            Else
                MessageBox.Show("Debe seleccionar una venta para ver el detalle.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al ver detalle de la venta: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizarLista_Click(sender As Object, e As EventArgs) Handles btnActualizarLista.Click
        Try
            txtFiltroRapido.Clear()
            CargarVentas()
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnActualizarLista_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
