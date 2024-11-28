Public Class FrmGestionarProducto
    Private productoNegocio As New ProductoNegocio()
    Private productoActual As Producto
    Private modoOperacion As String

    Public Sub New(modo As String, Optional producto As Producto = Nothing)
        InitializeComponent()
        modoOperacion = modo
        productoActual = producto
    End Sub

    Private Sub FrmGestionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case modoOperacion
                Case "Agregar"
                    Text = "Agregar Producto"
                    btnAceptar.Text = "Agregar"
                    HabilitarCampos(True)

                Case "Modificar"
                    Text = "Modificar Producto"
                    btnAceptar.Text = "Guardar"
                    CargarDatosProducto()
                    HabilitarCampos(True)

                Case "Eliminar"
                    Text = "Eliminar Producto"
                    btnAceptar.Text = "Eliminar"
                    CargarDatosProducto()
                    HabilitarCampos(False)
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosProducto()
        If productoActual IsNot Nothing Then
            txtNombre.Text = productoActual.Nombre
            txtPrecio.Text = productoActual.Precio.ToString()
            txtCategoria.Text = productoActual.Categoria
        End If
    End Sub

    Private Sub HabilitarCampos(habilitar As Boolean)
        txtNombre.ReadOnly = Not habilitar
        txtPrecio.ReadOnly = Not habilitar
        txtCategoria.ReadOnly = Not habilitar
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Select Case modoOperacion
                Case "Agregar"
                    If ValidarCampos() Then
                        Dim nuevoProducto As New Producto With {
                            .Nombre = txtNombre.Text,
                            .Precio = Convert.ToDouble(txtPrecio.Text),
                            .Categoria = txtCategoria.Text
                        }
                        productoNegocio.AgregarProducto(nuevoProducto)
                        MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Modificar"
                    If ValidarCampos() Then
                        productoActual.Nombre = txtNombre.Text
                        productoActual.Precio = Convert.ToDouble(txtPrecio.Text)
                        productoActual.Categoria = txtCategoria.Text
                        productoNegocio.ModificarProducto(productoActual)
                        MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Eliminar"
                    Dim respuesta = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If respuesta = DialogResult.Yes Then
                        productoNegocio.EliminarProducto(productoActual.ID)
                        MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al realizar la operación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrEmpty(txtPrecio.Text) OrElse String.IsNullOrEmpty(txtCategoria.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim precio As Double
        If Not Double.TryParse(txtPrecio.Text, precio) Then
            MessageBox.Show("El precio debe ser un valor numérico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
