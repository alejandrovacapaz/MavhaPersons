<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PersonsGridView = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_De_Nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddPerson = New System.Windows.Forms.Button()
        Me.Last = New System.Windows.Forms.Button()
        Me.NextB = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.Button()
        CType(Me.PersonsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonsGridView
        '
        Me.PersonsGridView.AllowUserToAddRows = False
        Me.PersonsGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonsGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre_Completo, Me.Fecha_De_Nacimiento, Me.Edad, Me.Sexo})
        Me.PersonsGridView.EnableHeadersVisualStyles = False
        Me.PersonsGridView.Location = New System.Drawing.Point(44, 53)
        Me.PersonsGridView.Name = "PersonsGridView"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonsGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.PersonsGridView.RowTemplate.Height = 25
        Me.PersonsGridView.Size = New System.Drawing.Size(809, 353)
        Me.PersonsGridView.TabIndex = 0
        '
        'Id
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Id.DefaultCellStyle = DataGridViewCellStyle2
        Me.Id.HeaderText = ""
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Nombre_Completo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nombre_Completo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre_Completo.HeaderText = "Nombre Completo"
        Me.Nombre_Completo.Name = "Nombre_Completo"
        Me.Nombre_Completo.Width = 250
        '
        'Fecha_De_Nacimiento
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fecha_De_Nacimiento.DefaultCellStyle = DataGridViewCellStyle4
        Me.Fecha_De_Nacimiento.HeaderText = "Fecha de Nacimiento"
        Me.Fecha_De_Nacimiento.Name = "Fecha_De_Nacimiento"
        Me.Fecha_De_Nacimiento.Width = 150
        '
        'Edad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Edad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        '
        'Sexo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sexo.DefaultCellStyle = DataGridViewCellStyle6
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 50
        '
        'AddPerson
        '
        Me.AddPerson.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.AddPerson.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddPerson.Location = New System.Drawing.Point(420, 12)
        Me.AddPerson.Name = "AddPerson"
        Me.AddPerson.Size = New System.Drawing.Size(131, 35)
        Me.AddPerson.TabIndex = 1
        Me.AddPerson.Text = "Adicionar Persona"
        Me.AddPerson.UseVisualStyleBackColor = False
        '
        'Last
        '
        Me.Last.Location = New System.Drawing.Point(778, 412)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(75, 23)
        Me.Last.TabIndex = 2
        Me.Last.Text = "Ultima"
        Me.Last.UseVisualStyleBackColor = True
        '
        'NextB
        '
        Me.NextB.Location = New System.Drawing.Point(697, 412)
        Me.NextB.Name = "NextB"
        Me.NextB.Size = New System.Drawing.Size(75, 23)
        Me.NextB.TabIndex = 3
        Me.NextB.Text = "Siguiente ->"
        Me.NextB.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(616, 412)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(75, 23)
        Me.Previous.TabIndex = 4
        Me.Previous.Text = "<- Anterior "
        Me.Previous.UseVisualStyleBackColor = True
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(535, 412)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(75, 23)
        Me.First.TabIndex = 5
        Me.First.Text = "Primera"
        Me.First.UseVisualStyleBackColor = True
        '
        'PersonsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.NextB)
        Me.Controls.Add(Me.Last)
        Me.Controls.Add(Me.AddPerson)
        Me.Controls.Add(Me.PersonsGridView)
        Me.Name = "PersonsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mavha Personas"
        CType(Me.PersonsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PersonsGridView As DataGridView
    Friend WithEvents AddPerson As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Completo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_De_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Last As Button
    Friend WithEvents NextB As Button
    Friend WithEvents Previous As Button
    Friend WithEvents First As Button
End Class
