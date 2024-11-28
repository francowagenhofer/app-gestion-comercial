Public Class FrmReportes

    Private Sub btnReporteVenta_Click(sender As Object, e As EventArgs) Handles btnReporteVenta.Click
        Try
            Dim frmReporteVenta As New frmReporteVenta()
            frmReporteVenta.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReporteProducto_Click(sender As Object, e As EventArgs) Handles btnReporteProducto.Click
        Try
            Dim frmReporteProducto As New frmReporteProducto()
            frmReporteProducto.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class