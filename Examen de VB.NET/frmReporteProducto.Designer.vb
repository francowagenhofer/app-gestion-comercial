<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.lblReporteProducto = New System.Windows.Forms.Label()
        Me.lblListaProductos = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvReporteProducto = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReporteProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(670, 396)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 58)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir "
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(670, 127)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(167, 58)
        Me.btnGenerarReporte.TabIndex = 11
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'lblReporteProducto
        '
        Me.lblReporteProducto.AutoSize = True
        Me.lblReporteProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporteProducto.Location = New System.Drawing.Point(13, 287)
        Me.lblReporteProducto.Name = "lblReporteProducto"
        Me.lblReporteProducto.Size = New System.Drawing.Size(413, 44)
        Me.lblReporteProducto.TabIndex = 10
        Me.lblReporteProducto.Text = "Reporte Producto - Cantidad de ventas mensuales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblReporteProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblListaProductos
        '
        Me.lblListaProductos.AutoSize = True
        Me.lblListaProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaProductos.Location = New System.Drawing.Point(12, 34)
        Me.lblListaProductos.Name = "lblListaProductos"
        Me.lblListaProductos.Size = New System.Drawing.Size(146, 25)
        Me.lblListaProductos.TabIndex = 9
        Me.lblListaProductos.Text = "Lista Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(17, 73)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(647, 174)
        Me.dgvProductos.TabIndex = 8
        '
        'dgvReporteProducto
        '
        Me.dgvReporteProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteProducto.Location = New System.Drawing.Point(17, 334)
        Me.dgvReporteProducto.Name = "dgvReporteProducto"
        Me.dgvReporteProducto.ReadOnly = True
        Me.dgvReporteProducto.RowHeadersWidth = 51
        Me.dgvReporteProducto.RowTemplate.Height = 24
        Me.dgvReporteProducto.Size = New System.Drawing.Size(647, 186)
        Me.dgvReporteProducto.TabIndex = 7
        '
        'frmReporteProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 560)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.lblReporteProducto)
        Me.Controls.Add(Me.lblListaProductos)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.dgvReporteProducto)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmReporteProducto"
        Me.Text = "Reporte de productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReporteProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents lblReporteProducto As Label
    Friend WithEvents lblListaProductos As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvReporteProducto As DataGridView
End Class
