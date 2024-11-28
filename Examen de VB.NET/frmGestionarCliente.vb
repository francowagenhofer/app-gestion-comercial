Public Class FrmGestionarCliente
    Private clienteNegocio As New ClienteNegocio()
    Private clienteActual As Cliente
    Private modoOperacion As String

    Public Sub New(modo As String, Optional cliente As Cliente = Nothing)
        InitializeComponent()
        modoOperacion = modo
        clienteActual = cliente
    End Sub

    Private Sub FrmGestionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case modoOperacion
                Case "Agregar"
                    Text = "Agregar Cliente"
                    btnAceptar.Text = "Agregar"
                    HabilitarCampos(True)

                Case "Modificar"
                    Text = "Modificar Cliente"
                    btnAceptar.Text = "Guardar"
                    CargarDatosCliente()
                    HabilitarCampos(True)

                Case "Eliminar"
                    Text = "Eliminar Cliente"
                    btnAceptar.Text = "Eliminar"
                    CargarDatosCliente()
                    HabilitarCampos(False)
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosCliente()
        If clienteActual IsNot Nothing Then
            txtNombre.Text = clienteActual.Nombre
            txtTelefono.Text = clienteActual.Telefono
            txtCorreo.Text = clienteActual.Correo
        End If
    End Sub

    Private Sub HabilitarCampos(habilitar As Boolean)
        txtNombre.ReadOnly = Not habilitar
        txtTelefono.ReadOnly = Not habilitar
        txtCorreo.ReadOnly = Not habilitar
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Select Case modoOperacion
                Case "Agregar"
                    If ValidarCampos() Then
                        Dim nuevoCliente As New Cliente With {
                            .Nombre = txtNombre.Text,
                            .Telefono = txtTelefono.Text,
                            .Correo = txtCorreo.Text
                        }
                        clienteNegocio.AgregarCliente(nuevoCliente)
                        MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Modificar"
                    If ValidarCampos() Then
                        clienteActual.Nombre = txtNombre.Text
                        clienteActual.Telefono = txtTelefono.Text
                        clienteActual.Correo = txtCorreo.Text
                        clienteNegocio.ModificarCliente(clienteActual)
                        MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Eliminar"
                    Dim respuesta = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If respuesta = DialogResult.Yes Then
                        clienteNegocio.EliminarCliente(clienteActual.ID)
                        MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al realizar la operación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrEmpty(txtTelefono.Text) OrElse String.IsNullOrEmpty(txtCorreo.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
