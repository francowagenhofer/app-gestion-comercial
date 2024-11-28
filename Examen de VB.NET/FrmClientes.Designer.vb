<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblListaClientes = New System.Windows.Forms.Label()
        Me.txtFiltroRapido = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnActualizarLista = New System.Windows.Forms.Button()
        Me.cbCampoBusqueda = New System.Windows.Forms.ComboBox()
        Me.txtFiltroAvanzado = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(162, 81)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(667, 202)
        Me.dgvClientes.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(162, 289)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(129, 52)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(297, 289)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(129, 52)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(432, 289)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(129, 52)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblListaClientes
        '
        Me.lblListaClientes.AutoSize = True
        Me.lblListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaClientes.Location = New System.Drawing.Point(327, 42)
        Me.lblListaClientes.Name = "lblListaClientes"
        Me.lblListaClientes.Size = New System.Drawing.Size(234, 36)
        Me.lblListaClientes.TabIndex = 8
        Me.lblListaClientes.Text = "Lista de Clientes"
        '
        'txtFiltroRapido
        '
        Me.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroRapido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroRapido.Location = New System.Drawing.Point(646, 50)
        Me.txtFiltroRapido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroRapido.Name = "txtFiltroRapido"
        Me.txtFiltroRapido.Size = New System.Drawing.Size(183, 24)
        Me.txtFiltroRapido.TabIndex = 9
        Me.txtFiltroRapido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Location = New System.Drawing.Point(27, 184)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(129, 52)
        Me.btnBuscarCliente.TabIndex = 10
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(702, 289)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(129, 52)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnActualizarLista
        '
        Me.btnActualizarLista.Location = New System.Drawing.Point(567, 289)
        Me.btnActualizarLista.Name = "btnActualizarLista"
        Me.btnActualizarLista.Size = New System.Drawing.Size(129, 52)
        Me.btnActualizarLista.TabIndex = 13
        Me.btnActualizarLista.Text = "Actualizar Lista"
        Me.btnActualizarLista.UseVisualStyleBackColor = True
        '
        'cbCampoBusqueda
        '
        Me.cbCampoBusqueda.FormattingEnabled = True
        Me.cbCampoBusqueda.Location = New System.Drawing.Point(27, 122)
        Me.cbCampoBusqueda.Name = "cbCampoBusqueda"
        Me.cbCampoBusqueda.Size = New System.Drawing.Size(129, 24)
        Me.cbCampoBusqueda.TabIndex = 15
        '
        'txtFiltroAvanzado
        '
        Me.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAvanzado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAvanzado.Location = New System.Drawing.Point(27, 153)
        Me.txtFiltroAvanzado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroAvanzado.Name = "txtFiltroAvanzado"
        Me.txtFiltroAvanzado.Size = New System.Drawing.Size(129, 24)
        Me.txtFiltroAvanzado.TabIndex = 16
        Me.txtFiltroAvanzado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(892, 403)
        Me.Controls.Add(Me.txtFiltroAvanzado)
        Me.Controls.Add(Me.cbCampoBusqueda)
        Me.Controls.Add(Me.btnActualizarLista)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtFiltroRapido)
        Me.Controls.Add(Me.lblListaClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "FrmClientes"
        Me.Text = "Gestión de Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblListaClientes As Label
    Private WithEvents txtFiltroRapido As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnActualizarLista As Button
    Friend WithEvents cbCampoBusqueda As ComboBox
    Private WithEvents txtFiltroAvanzado As TextBox
End Class
