<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerPaises
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelCantPaises = New System.Windows.Forms.Label()
        Me.LabelValorCantCiudades = New System.Windows.Forms.Label()
        Me.LabelValorCantPaises = New System.Windows.Forms.Label()
        Me.LabelCantCiudades = New System.Windows.Forms.Label()
        Me.LabelCantIdiomas = New System.Windows.Forms.Label()
        Me.LabelValorCantIdiomas = New System.Windows.Forms.Label()
        Me.GridCargarPaises = New System.Windows.Forms.DataGridView()
        Me.LabelBuscarCiudad = New System.Windows.Forms.Label()
        Me.TextoBuscarCiudad = New System.Windows.Forms.TextBox()
        Me.GridCiudades = New System.Windows.Forms.DataGridView()
        Me.GridLenguajes = New System.Windows.Forms.DataGridView()
        Me.GridPaises = New System.Windows.Forms.DataGridView()
        CType(Me.GridCargarPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLenguajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCantPaises
        '
        Me.LabelCantPaises.AutoSize = True
        Me.LabelCantPaises.Location = New System.Drawing.Point(687, 26)
        Me.LabelCantPaises.Name = "LabelCantPaises"
        Me.LabelCantPaises.Size = New System.Drawing.Size(130, 17)
        Me.LabelCantPaises.TabIndex = 0
        Me.LabelCantPaises.Text = "Cantidad de Paises"
        '
        'LabelValorCantCiudades
        '
        Me.LabelValorCantCiudades.AutoSize = True
        Me.LabelValorCantCiudades.Location = New System.Drawing.Point(851, 58)
        Me.LabelValorCantCiudades.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.LabelValorCantCiudades.Name = "LabelValorCantCiudades"
        Me.LabelValorCantCiudades.Size = New System.Drawing.Size(16, 17)
        Me.LabelValorCantCiudades.TabIndex = 1
        Me.LabelValorCantCiudades.Text = "0"
        '
        'LabelValorCantPaises
        '
        Me.LabelValorCantPaises.AutoSize = True
        Me.LabelValorCantPaises.Location = New System.Drawing.Point(851, 26)
        Me.LabelValorCantPaises.Name = "LabelValorCantPaises"
        Me.LabelValorCantPaises.Size = New System.Drawing.Size(16, 17)
        Me.LabelValorCantPaises.TabIndex = 2
        Me.LabelValorCantPaises.Text = "0"
        '
        'LabelCantCiudades
        '
        Me.LabelCantCiudades.AutoSize = True
        Me.LabelCantCiudades.Location = New System.Drawing.Point(687, 58)
        Me.LabelCantCiudades.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.LabelCantCiudades.Name = "LabelCantCiudades"
        Me.LabelCantCiudades.Size = New System.Drawing.Size(147, 17)
        Me.LabelCantCiudades.TabIndex = 3
        Me.LabelCantCiudades.Text = "Cantidad de Ciudades"
        '
        'LabelCantIdiomas
        '
        Me.LabelCantIdiomas.AutoSize = True
        Me.LabelCantIdiomas.Location = New System.Drawing.Point(687, 90)
        Me.LabelCantIdiomas.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.LabelCantIdiomas.Name = "LabelCantIdiomas"
        Me.LabelCantIdiomas.Size = New System.Drawing.Size(136, 17)
        Me.LabelCantIdiomas.TabIndex = 4
        Me.LabelCantIdiomas.Text = "Cantidad de Idiomas"
        '
        'LabelValorCantIdiomas
        '
        Me.LabelValorCantIdiomas.AutoSize = True
        Me.LabelValorCantIdiomas.Location = New System.Drawing.Point(851, 90)
        Me.LabelValorCantIdiomas.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.LabelValorCantIdiomas.Name = "LabelValorCantIdiomas"
        Me.LabelValorCantIdiomas.Size = New System.Drawing.Size(16, 17)
        Me.LabelValorCantIdiomas.TabIndex = 5
        Me.LabelValorCantIdiomas.Text = "0"
        '
        'GridCargarPaises
        '
        Me.GridCargarPaises.AllowUserToAddRows = False
        Me.GridCargarPaises.AllowUserToDeleteRows = False
        Me.GridCargarPaises.AllowUserToResizeColumns = False
        Me.GridCargarPaises.AllowUserToResizeRows = False
        Me.GridCargarPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridCargarPaises.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridCargarPaises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCargarPaises.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridCargarPaises.ColumnHeadersHeight = 29
        Me.GridCargarPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridCargarPaises.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridCargarPaises.Location = New System.Drawing.Point(15, 15)
        Me.GridCargarPaises.Margin = New System.Windows.Forms.Padding(15)
        Me.GridCargarPaises.MultiSelect = False
        Me.GridCargarPaises.Name = "GridCargarPaises"
        Me.GridCargarPaises.ReadOnly = True
        Me.GridCargarPaises.RowHeadersWidth = 51
        Me.GridCargarPaises.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridCargarPaises.RowTemplate.Height = 24
        Me.GridCargarPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCargarPaises.Size = New System.Drawing.Size(657, 420)
        Me.GridCargarPaises.TabIndex = 6
        '
        'LabelBuscarCiudad
        '
        Me.LabelBuscarCiudad.AutoSize = True
        Me.LabelBuscarCiudad.Location = New System.Drawing.Point(687, 177)
        Me.LabelBuscarCiudad.Name = "LabelBuscarCiudad"
        Me.LabelBuscarCiudad.Size = New System.Drawing.Size(100, 17)
        Me.LabelBuscarCiudad.TabIndex = 7
        Me.LabelBuscarCiudad.Text = "Buscar Ciudad"
        '
        'TextoBuscarCiudad
        '
        Me.TextoBuscarCiudad.Location = New System.Drawing.Point(691, 198)
        Me.TextoBuscarCiudad.Name = "TextoBuscarCiudad"
        Me.TextoBuscarCiudad.Size = New System.Drawing.Size(176, 22)
        Me.TextoBuscarCiudad.TabIndex = 8
        '
        'GridCiudades
        '
        Me.GridCiudades.AllowUserToAddRows = False
        Me.GridCiudades.AllowUserToDeleteRows = False
        Me.GridCiudades.AllowUserToResizeColumns = False
        Me.GridCiudades.AllowUserToResizeRows = False
        Me.GridCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCiudades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridCiudades.ColumnHeadersHeight = 29
        Me.GridCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridCiudades.Location = New System.Drawing.Point(690, 388)
        Me.GridCiudades.Margin = New System.Windows.Forms.Padding(15)
        Me.GridCiudades.MultiSelect = False
        Me.GridCiudades.Name = "GridCiudades"
        Me.GridCiudades.ReadOnly = True
        Me.GridCiudades.RowHeadersWidth = 51
        Me.GridCiudades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridCiudades.RowTemplate.Height = 24
        Me.GridCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCiudades.Size = New System.Drawing.Size(210, 47)
        Me.GridCiudades.TabIndex = 9
        Me.GridCiudades.Visible = False
        '
        'GridLenguajes
        '
        Me.GridLenguajes.AllowUserToAddRows = False
        Me.GridLenguajes.AllowUserToDeleteRows = False
        Me.GridLenguajes.AllowUserToResizeColumns = False
        Me.GridLenguajes.AllowUserToResizeRows = False
        Me.GridLenguajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridLenguajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridLenguajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridLenguajes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridLenguajes.ColumnHeadersHeight = 29
        Me.GridLenguajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridLenguajes.Location = New System.Drawing.Point(690, 336)
        Me.GridLenguajes.Margin = New System.Windows.Forms.Padding(15)
        Me.GridLenguajes.MultiSelect = False
        Me.GridLenguajes.Name = "GridLenguajes"
        Me.GridLenguajes.ReadOnly = True
        Me.GridLenguajes.RowHeadersWidth = 51
        Me.GridLenguajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridLenguajes.RowTemplate.Height = 24
        Me.GridLenguajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLenguajes.Size = New System.Drawing.Size(210, 47)
        Me.GridLenguajes.TabIndex = 10
        Me.GridLenguajes.Visible = False
        '
        'GridPaises
        '
        Me.GridPaises.AllowUserToAddRows = False
        Me.GridPaises.AllowUserToDeleteRows = False
        Me.GridPaises.AllowUserToResizeColumns = False
        Me.GridPaises.AllowUserToResizeRows = False
        Me.GridPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridPaises.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridPaises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPaises.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridPaises.ColumnHeadersHeight = 29
        Me.GridPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridPaises.Location = New System.Drawing.Point(690, 282)
        Me.GridPaises.Margin = New System.Windows.Forms.Padding(15)
        Me.GridPaises.MultiSelect = False
        Me.GridPaises.Name = "GridPaises"
        Me.GridPaises.ReadOnly = True
        Me.GridPaises.RowHeadersWidth = 51
        Me.GridPaises.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridPaises.RowTemplate.Height = 24
        Me.GridPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPaises.Size = New System.Drawing.Size(210, 47)
        Me.GridPaises.TabIndex = 11
        Me.GridPaises.Visible = False
        '
        'VerPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 450)
        Me.Controls.Add(Me.GridPaises)
        Me.Controls.Add(Me.GridLenguajes)
        Me.Controls.Add(Me.GridCiudades)
        Me.Controls.Add(Me.TextoBuscarCiudad)
        Me.Controls.Add(Me.LabelBuscarCiudad)
        Me.Controls.Add(Me.GridCargarPaises)
        Me.Controls.Add(Me.LabelValorCantIdiomas)
        Me.Controls.Add(Me.LabelCantIdiomas)
        Me.Controls.Add(Me.LabelCantCiudades)
        Me.Controls.Add(Me.LabelValorCantPaises)
        Me.Controls.Add(Me.LabelValorCantCiudades)
        Me.Controls.Add(Me.LabelCantPaises)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "VerPaises"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "ProyectoWorld - Pamela Rodriguez"
        CType(Me.GridCargarPaises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLenguajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCantPaises As Label
    Friend WithEvents LabelValorCantCiudades As Label
    Friend WithEvents LabelValorCantPaises As Label
    Friend WithEvents LabelCantCiudades As Label
    Friend WithEvents LabelCantIdiomas As Label
    Friend WithEvents LabelValorCantIdiomas As Label
    Friend WithEvents GridCargarPaises As DataGridView
    Friend WithEvents LabelBuscarCiudad As Label
    Friend WithEvents TextoBuscarCiudad As TextBox
    Friend WithEvents GridCiudades As DataGridView
    Friend WithEvents GridLenguajes As DataGridView
    Friend WithEvents GridPaises As DataGridView
End Class
