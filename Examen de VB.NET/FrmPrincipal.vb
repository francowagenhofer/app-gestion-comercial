Public Class Form1
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Try
            Dim frmClientes As New FrmClientes()
            frmClientes.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario de clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        Try
            Dim frmProductos As New FrmProductos()
            frmProductos.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario de productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Try
            Dim frmVentas As New FrmVentas()
            frmVentas.Show()  '
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario de ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        Try
            Dim frmReportes As New FrmReportes()
            frmReportes.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario de reportes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
