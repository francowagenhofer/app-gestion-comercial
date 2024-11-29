<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteVenta
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
        Me.dgvReporteVenta = New System.Windows.Forms.DataGridView()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvReporteVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReporteVenta
        '
        Me.dgvReporteVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteVenta.Location = New System.Drawing.Point(42, 307)
        Me.dgvReporteVenta.Name = "dgvReporteVenta"
        Me.dgvReporteVenta.ReadOnly = True
        Me.dgvReporteVenta.RowHeadersWidth = 51
        Me.dgvReporteVenta.RowTemplate.Height = 24
        Me.dgvReporteVenta.Size = New System.Drawing.Size(922, 129)
        Me.dgvReporteVenta.TabIndex = 0
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(42, 64)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(714, 174)
        Me.dgvVentas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reporte Venta"
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(797, 123)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(167, 58)
        Me.btnGenerarReporte.TabIndex = 4
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(426, 466)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(158, 58)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir "
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 567)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.dgvReporteVenta)
        Me.Name = "frmReporteVenta"
        Me.Text = "Reporte de ventas"
        CType(Me.dgvReporteVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReporteVenta As DataGridView
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents btnSalir As Button
End Class
