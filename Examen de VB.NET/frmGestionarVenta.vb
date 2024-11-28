Public Class FrmGestionarVenta
    Private ventaNegocio As New VentaNegocio()
    Private clienteNegocio As New ClienteNegocio()
    Private productoNegocio As New ProductoNegocio()

    Private listaProductos As List(Of Producto)
    Private listaClientes As List(Of Cliente)
    Private itemsVenta As New List(Of VentaItem)
    Private ventaActual As Venta
    Private modoOperacion As String

    Public Sub New(modo As String, Optional venta As Venta = Nothing)
        InitializeComponent()
        modoOperacion = modo
        ventaActual = venta
    End Sub

    Private Sub FrmGestionarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarProductos()
            CargarClientes()
            ConfigurarDataGridView()

            Select Case modoOperacion
                Case "Agregar"
                    Text = "Agregar Venta"
                    btnAceptar.Text = "Agregar"
                    dtpFecha.Value = DateTime.Now

                Case "Modificar"
                    Text = "Modificar Venta"
                    btnAceptar.Text = "Guardar"
                    If ventaActual IsNot Nothing Then
                        CargarDatosVenta()
                        CalcularTotal()
                    End If

                Case "Eliminar"
                    Text = "Eliminar Venta"
                    btnAceptar.Text = "Eliminar"
                    If ventaActual IsNot Nothing Then
                        CargarDatosVenta()
                        BloquearControles()
                    End If

                Case "Ver Detalle"
                    Text = "Ver Detalle de Venta"
                    btnAceptar.Text = "Cerrar"
                    If ventaActual IsNot Nothing Then
                        CargarDatosVenta()
                        BloquearControles()
                        btnCancelar.Enabled = False
                    End If
            End Select
        Catch ex As Exception
            MostrarError("Error al cargar el formulario: " & ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub CargarProductos()
        listaProductos = productoNegocio.ListarProductos()
        cbProducto.DataSource = listaProductos
        cbProducto.DisplayMember = "Nombre"
        cbProducto.ValueMember = "ID"
    End Sub

    Private Sub CargarClientes()
        listaClientes = clienteNegocio.ListarClientes()
        cbCliente.DataSource = listaClientes
        cbCliente.DisplayMember = "Nombre"
        cbCliente.ValueMember = "ID"
    End Sub

    Private Sub ConfigurarDataGridView()
        dgvItems.Columns.Clear()
        dgvItems.Columns.Add("IDProducto", "ID Producto")
        dgvItems.Columns.Add("Cantidad", "Cantidad")
        dgvItems.Columns.Add("PrecioUnitario", "Precio Unitario")
        dgvItems.Columns.Add("PrecioTotal", "Precio Total")
    End Sub

    Private Sub CargarDatosVenta()
        If ventaActual IsNot Nothing Then
            cbCliente.SelectedValue = ventaActual.IDCliente
            dtpFecha.Value = ventaActual.Fecha
            txtTotal.SelectedText = ventaActual.Total

            dgvItems.Rows.Clear()
            itemsVenta = ventaNegocio.ListarItemsPorVenta(ventaActual.ID)
            For Each item In itemsVenta
                dgvItems.Rows.Add(item.IDProducto, item.Cantidad, item.PrecioUnitario, item.PrecioTotal)

                If modoOperacion = "Modificar" Or modoOperacion = "Ver Detalle" Or modoOperacion = "Eliminar" Then
                    cbProducto.SelectedValue = item.IDProducto
                    nudCantidad.Value = Convert.ToDecimal(item.Cantidad)
                End If
            Next
        End If
    End Sub

    Private Sub BloquearControles()
        cbCliente.Enabled = False
        dtpFecha.Enabled = False
        dgvItems.ReadOnly = True
        cbProducto.Enabled = False
        nudCantidad.Enabled = False
        btnAgregarProducto.Enabled = False
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Try
            If cbProducto.SelectedItem Is Nothing OrElse nudCantidad.Value <= 0 Then
                MessageBox.Show("Seleccione un producto válido y una cantidad mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim productoSeleccionado As Producto = CType(cbProducto.SelectedItem, Producto)
            Dim cantidad As Double = Convert.ToDouble(nudCantidad.Value)
            Dim precioTotal As Double = productoSeleccionado.Precio * cantidad

            Dim item As New VentaItem With {
            .IDProducto = productoSeleccionado.ID,
            .Cantidad = cantidad,
            .PrecioUnitario = productoSeleccionado.Precio,
            .PrecioTotal = precioTotal
        }

            itemsVenta.Add(item)
            dgvItems.Rows.Add(item.IDProducto, item.Cantidad, item.PrecioUnitario, item.PrecioTotal)

            CalcularTotal()

            cbProducto.SelectedIndex = -1
            nudCantidad.Value = 0
        Catch ex As Exception
            MostrarError("Error al agregar el producto: " & ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub CalcularTotal()
        Dim total As Double = itemsVenta.Sum(Function(item) item.PrecioTotal)
        txtTotal.Text = total.ToString("F2")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If modoOperacion = "Agregar" OrElse modoOperacion = "Modificar" Then
                If cbCliente.SelectedItem Is Nothing OrElse itemsVenta.Count = 0 Then
                    MessageBox.Show("Debe seleccionar un cliente y agregar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim venta = If(ventaActual, New Venta())
                venta.IDCliente = CType(cbCliente.SelectedValue, Integer)
                venta.Fecha = dtpFecha.Value
                venta.Total = itemsVenta.Sum(Function(item) item.PrecioTotal)

                If modoOperacion = "Agregar" Then
                    Dim idVenta As Integer = ventaNegocio.GuardarVenta(venta)
                    ventaNegocio.GuardarItemsVenta(idVenta, itemsVenta)
                    MessageBox.Show("Venta agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf modoOperacion = "Modificar" Then
                    If itemsVenta.Count = 0 Then
                        MessageBox.Show("Debe agregar al menos un producto a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ventaNegocio.ModificarVenta(venta)
                    ventaNegocio.ModificarItemsDeVenta(venta.ID, itemsVenta)
                    MessageBox.Show("Venta modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf modoOperacion = "Eliminar" Then
                If ventaActual IsNot Nothing Then
                    ventaNegocio.EliminarVenta(ventaActual.ID)
                    MessageBox.Show("Venta eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No hay ninguna venta seleccionada para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MostrarError("Error al procesar la venta: " & ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub




    Private Sub MostrarError(mensaje As String)
        txtError.AppendText(mensaje & Environment.NewLine)
    End Sub

End Class
