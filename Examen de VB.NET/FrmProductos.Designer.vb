<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.txtFiltroAvanzado = New System.Windows.Forms.TextBox()
        Me.cbCampoBusqueda = New System.Windows.Forms.ComboBox()
        Me.btnActualizarLista = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtFiltroRapido = New System.Windows.Forms.TextBox()
        Me.lblListaProducto = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroAvanzado
        '
        Me.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAvanzado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAvanzado.Location = New System.Drawing.Point(22, 150)
        Me.txtFiltroAvanzado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroAvanzado.Name = "txtFiltroAvanzado"
        Me.txtFiltroAvanzado.Size = New System.Drawing.Size(129, 24)
        Me.txtFiltroAvanzado.TabIndex = 27
        Me.txtFiltroAvanzado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCampoBusqueda
        '
        Me.cbCampoBusqueda.FormattingEnabled = True
        Me.cbCampoBusqueda.Location = New System.Drawing.Point(22, 119)
        Me.cbCampoBusqueda.Name = "cbCampoBusqueda"
        Me.cbCampoBusqueda.Size = New System.Drawing.Size(129, 24)
        Me.cbCampoBusqueda.TabIndex = 26
        '
        'btnActualizarLista
        '
        Me.btnActualizarLista.Location = New System.Drawing.Point(562, 286)
        Me.btnActualizarLista.Name = "btnActualizarLista"
        Me.btnActualizarLista.Size = New System.Drawing.Size(129, 52)
        Me.btnActualizarLista.TabIndex = 25
        Me.btnActualizarLista.Text = "Actualizar Lista"
        Me.btnActualizarLista.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(697, 286)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(129, 52)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(22, 181)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(129, 52)
        Me.btnBuscarProducto.TabIndex = 23
        Me.btnBuscarProducto.Text = "Buscar Producto"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtFiltroRapido
        '
        Me.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroRapido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroRapido.Location = New System.Drawing.Point(641, 47)
        Me.txtFiltroRapido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroRapido.Name = "txtFiltroRapido"
        Me.txtFiltroRapido.Size = New System.Drawing.Size(183, 24)
        Me.txtFiltroRapido.TabIndex = 22
        Me.txtFiltroRapido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblListaProducto
        '
        Me.lblListaProducto.AutoSize = True
        Me.lblListaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaProducto.Location = New System.Drawing.Point(322, 39)
        Me.lblListaProducto.Name = "lblListaProducto"
        Me.lblListaProducto.Size = New System.Drawing.Size(263, 36)
        Me.lblListaProducto.TabIndex = 21
        Me.lblListaProducto.Text = "Lista de Productos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(427, 286)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(129, 52)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(292, 286)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(129, 52)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(157, 286)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(129, 52)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(157, 78)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(667, 202)
        Me.dgvProductos.TabIndex = 17
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(892, 403)
        Me.Controls.Add(Me.txtFiltroAvanzado)
        Me.Controls.Add(Me.cbCampoBusqueda)
        Me.Controls.Add(Me.btnActualizarLista)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.txtFiltroRapido)
        Me.Controls.Add(Me.lblListaProducto)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "FrmProductos"
        Me.Text = "Gestión de Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtFiltroAvanzado As TextBox
    Friend WithEvents cbCampoBusqueda As ComboBox
    Friend WithEvents btnActualizarLista As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscarProducto As Button
    Private WithEvents txtFiltroRapido As TextBox
    Friend WithEvents lblListaProducto As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvProductos As DataGridView
End Class
