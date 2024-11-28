<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscarVenta = New System.Windows.Forms.Button()
        Me.txtFiltroRapido = New System.Windows.Forms.TextBox()
        Me.lblListaVentas = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.btnActualizarLista = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroAvanzado
        '
        Me.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAvanzado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAvanzado.Location = New System.Drawing.Point(22, 161)
        Me.txtFiltroAvanzado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroAvanzado.Name = "txtFiltroAvanzado"
        Me.txtFiltroAvanzado.Size = New System.Drawing.Size(129, 24)
        Me.txtFiltroAvanzado.TabIndex = 27
        Me.txtFiltroAvanzado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCampoBusqueda
        '
        Me.cbCampoBusqueda.FormattingEnabled = True
        Me.cbCampoBusqueda.Location = New System.Drawing.Point(22, 130)
        Me.cbCampoBusqueda.Name = "cbCampoBusqueda"
        Me.cbCampoBusqueda.Size = New System.Drawing.Size(129, 24)
        Me.cbCampoBusqueda.TabIndex = 26
        '
        'btnVerDetalle
        '
        Me.btnVerDetalle.Location = New System.Drawing.Point(502, 297)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(109, 44)
        Me.btnVerDetalle.TabIndex = 25
        Me.btnVerDetalle.Text = "Ver Detalle"
        Me.btnVerDetalle.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(754, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 44)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarVenta.Location = New System.Drawing.Point(22, 192)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Size = New System.Drawing.Size(129, 52)
        Me.btnBuscarVenta.TabIndex = 23
        Me.btnBuscarVenta.Text = "Buscar Venta"
        Me.btnBuscarVenta.UseVisualStyleBackColor = True
        '
        'txtFiltroRapido
        '
        Me.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroRapido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroRapido.Location = New System.Drawing.Point(680, 58)
        Me.txtFiltroRapido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroRapido.Name = "txtFiltroRapido"
        Me.txtFiltroRapido.Size = New System.Drawing.Size(183, 24)
        Me.txtFiltroRapido.TabIndex = 22
        Me.txtFiltroRapido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblListaVentas
        '
        Me.lblListaVentas.AutoSize = True
        Me.lblListaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaVentas.Location = New System.Drawing.Point(322, 50)
        Me.lblListaVentas.Name = "lblListaVentas"
        Me.lblListaVentas.Size = New System.Drawing.Size(220, 36)
        Me.lblListaVentas.TabIndex = 21
        Me.lblListaVentas.Text = "Lista de Ventas"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(387, 297)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 44)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(272, 297)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 44)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(157, 297)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(109, 44)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(157, 89)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(706, 202)
        Me.dgvVentas.TabIndex = 17
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(885, 50)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Size = New System.Drawing.Size(407, 291)
        Me.txtError.TabIndex = 28
        '
        'btnActualizarLista
        '
        Me.btnActualizarLista.Location = New System.Drawing.Point(617, 297)
        Me.btnActualizarLista.Name = "btnActualizarLista"
        Me.btnActualizarLista.Size = New System.Drawing.Size(131, 44)
        Me.btnActualizarLista.TabIndex = 29
        Me.btnActualizarLista.Text = "Actualizar Lista"
        Me.btnActualizarLista.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1320, 425)
        Me.Controls.Add(Me.btnActualizarLista)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.txtFiltroAvanzado)
        Me.Controls.Add(Me.cbCampoBusqueda)
        Me.Controls.Add(Me.btnVerDetalle)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscarVenta)
        Me.Controls.Add(Me.txtFiltroRapido)
        Me.Controls.Add(Me.lblListaVentas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvVentas)
        Me.Name = "FrmVentas"
        Me.Text = "Gestión de Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtFiltroAvanzado As TextBox
    Friend WithEvents cbCampoBusqueda As ComboBox
    Friend WithEvents btnVerDetalle As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscarVenta As Button
    Private WithEvents txtFiltroRapido As TextBox
    Friend WithEvents lblListaVentas As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents txtError As TextBox
    Friend WithEvents btnActualizarLista As Button
End Class
