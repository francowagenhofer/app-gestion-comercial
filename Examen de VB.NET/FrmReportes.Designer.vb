<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnReporteVenta = New System.Windows.Forms.Button()
        Me.btnReporteProducto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReporteVenta
        '
        Me.btnReporteVenta.Location = New System.Drawing.Point(132, 78)
        Me.btnReporteVenta.Name = "btnReporteVenta"
        Me.btnReporteVenta.Size = New System.Drawing.Size(191, 68)
        Me.btnReporteVenta.TabIndex = 0
        Me.btnReporteVenta.Text = "Reporte de ventas"
        Me.btnReporteVenta.UseVisualStyleBackColor = True
        '
        'btnReporteProducto
        '
        Me.btnReporteProducto.Location = New System.Drawing.Point(132, 171)
        Me.btnReporteProducto.Name = "btnReporteProducto"
        Me.btnReporteProducto.Size = New System.Drawing.Size(191, 68)
        Me.btnReporteProducto.TabIndex = 1
        Me.btnReporteProducto.Text = "Reporte de productos"
        Me.btnReporteProducto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(132, 304)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 68)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 449)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReporteProducto)
        Me.Controls.Add(Me.btnReporteVenta)
        Me.Name = "FrmReportes"
        Me.Text = "Menu de reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReporteVenta As Button
    Friend WithEvents btnReporteProducto As Button
    Friend WithEvents btnSalir As Button
End Class
