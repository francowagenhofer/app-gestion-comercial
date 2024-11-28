<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionarVenta
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
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCliente
        '
        Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(96, 39)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(140, 24)
        Me.cbCliente.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(327, 41)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(273, 22)
        Me.dtpFecha.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(376, 339)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(109, 52)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(491, 339)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 52)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(26, 44)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(51, 16)
        Me.lblCliente.TabIndex = 17
        Me.lblCliente.Text = "Cliente:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(273, 44)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "Fecha:"
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(634, 43)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Size = New System.Drawing.Size(320, 348)
        Me.txtError.TabIndex = 29
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(26, 101)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(64, 16)
        Me.lblProducto.TabIndex = 35
        Me.lblProducto.Text = "Producto:"
        '
        'cbProducto
        '
        Me.cbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(96, 98)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(140, 24)
        Me.cbProducto.TabIndex = 34
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(327, 95)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(70, 22)
        Me.nudCantidad.TabIndex = 36
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(257, 98)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 16)
        Me.lblCantidad.TabIndex = 37
        Me.lblCantidad.Text = "Cantidad:"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(441, 82)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(159, 52)
        Me.btnAgregarProducto.TabIndex = 38
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'dgvItems
        '
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(29, 161)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(571, 161)
        Me.dgvItems.TabIndex = 39
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Location = New System.Drawing.Point(26, 357)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(81, 16)
        Me.lblMontoTotal.TabIndex = 41
        Me.lblMontoTotal.Text = "Monto Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(113, 354)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(140, 22)
        Me.txtTotal.TabIndex = 40
        '
        'FrmGestionarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 454)
        Me.Controls.Add(Me.lblMontoTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cbCliente)
        Me.Name = "FrmGestionarVenta"
        Me.Text = "Gestión de Venta"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtError As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblMontoTotal As Label
    Friend WithEvents txtTotal As TextBox
End Class
