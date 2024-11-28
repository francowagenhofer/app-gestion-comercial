Public Class FrmClientes
    Private clienteNegocio As New ClienteNegocio()
    Private listaClientes As List(Of Cliente)

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCampoBusqueda.Items.Add("ID")
            cbCampoBusqueda.Items.Add("Cliente")
            cbCampoBusqueda.Items.Add("Telefono")
            cbCampoBusqueda.Items.Add("Correo")
            cbCampoBusqueda.Text = "Campo"

            CargarClientes()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar los clientes: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarClientes()
        Try
            listaClientes = clienteNegocio.ListarClientes()
            ActualizarDataGridView(listaClientes)
        Catch ex As Exception
            MessageBox.Show($"Error al listar los clientes: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDataGridView(clientes As List(Of Cliente))
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = clientes
        dgvClientes.Refresh()
    End Sub

    Private Sub btnBuscarAvanzado_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
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

            Dim clientesFiltrados As List(Of Cliente) = clienteNegocio.FiltrarClientesPorCampo(campo, filtro)

            ActualizarDataGridView(clientesFiltrados)
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

            Dim listaFiltrada As List(Of Cliente)
            If filtro.Length >= 2 Then
                listaFiltrada = listaClientes.FindAll(Function(c)
                                                          Return c.Nombre.ToUpper().Contains(filtro) OrElse
                                                             c.Telefono.ToUpper().Contains(filtro) OrElse
                                                             c.Correo.ToUpper().Contains(filtro) OrElse
                                                             c.ID.ToString().Contains(filtro)
                                                      End Function)
            Else
                listaFiltrada = listaClientes
            End If

            ActualizarDataGridView(listaFiltrada)
        Catch ex As Exception
            MessageBox.Show($"Error al filtrar clientes: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New FrmGestionarCliente("Agregar")
            If frm.ShowDialog() = DialogResult.OK Then
                CargarClientes()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnAgregar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvClientes.SelectedRows.Count > 0 Then
                Dim clienteSeleccionado As New Cliente With {
                    .ID = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("ID").Value),
                    .Nombre = dgvClientes.SelectedRows(0).Cells("Nombre").Value.ToString(),
                    .Telefono = dgvClientes.SelectedRows(0).Cells("Telefono").Value.ToString(),
                    .Correo = dgvClientes.SelectedRows(0).Cells("Correo").Value.ToString()
                }
                Dim frm As New FrmGestionarCliente("Modificar", clienteSeleccionado)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarClientes()
                End If
            Else
                MessageBox.Show("Debe seleccionar un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnModificar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvClientes.SelectedRows.Count > 0 Then
                Dim clienteSeleccionado As New Cliente With {
                    .ID = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("ID").Value),
                    .Nombre = dgvClientes.SelectedRows(0).Cells("Nombre").Value.ToString(),
                    .Telefono = dgvClientes.SelectedRows(0).Cells("Telefono").Value.ToString(),
                    .Correo = dgvClientes.SelectedRows(0).Cells("Correo").Value.ToString()
                }
                Dim frm As New FrmGestionarCliente("Eliminar", clienteSeleccionado)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarClientes()
                End If
            Else
                MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnEliminar_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizarLista_Click(sender As Object, e As EventArgs) Handles btnActualizarLista.Click
        Try
            txtFiltroRapido.Clear()
            CargarClientes()
        Catch ex As Exception
            MessageBox.Show($"Error en el método btnActualizarLista_Click: {ex.Message}{vbNewLine}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
