<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewPerson
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
        Me.AddPerson = New System.Windows.Forms.Button()
        Me.Sex = New System.Windows.Forms.ComboBox()
        Me.SexoLbl = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.YearBirthDate = New System.Windows.Forms.ComboBox()
        Me.MonthBirthDate = New System.Windows.Forms.ComboBox()
        Me.DayBirthDate = New System.Windows.Forms.ComboBox()
        Me.FechaNacFromatLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaNacLbl = New System.Windows.Forms.Label()
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddPersonLbl = New System.Windows.Forms.Label()
        Me.EdadLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddPerson
        '
        Me.AddPerson.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.AddPerson.Location = New System.Drawing.Point(272, 279)
        Me.AddPerson.Name = "AddPerson"
        Me.AddPerson.Size = New System.Drawing.Size(99, 38)
        Me.AddPerson.TabIndex = 26
        Me.AddPerson.Text = "Adicionar"
        Me.AddPerson.UseVisualStyleBackColor = False
        Me.AddPerson.UseWaitCursor = True
        '
        'Sex
        '
        Me.Sex.FormattingEnabled = True
        Me.Sex.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Sex.Location = New System.Drawing.Point(113, 196)
        Me.Sex.Name = "Sex"
        Me.Sex.Size = New System.Drawing.Size(158, 21)
        Me.Sex.TabIndex = 25
        Me.Sex.UseWaitCursor = True
        '
        'SexoLbl
        '
        Me.SexoLbl.AutoSize = True
        Me.SexoLbl.Location = New System.Drawing.Point(46, 204)
        Me.SexoLbl.Name = "SexoLbl"
        Me.SexoLbl.Size = New System.Drawing.Size(31, 13)
        Me.SexoLbl.TabIndex = 24
        Me.SexoLbl.Text = "Sexo"
        Me.SexoLbl.UseWaitCursor = True
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(113, 153)
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Size = New System.Drawing.Size(75, 20)
        Me.Age.TabIndex = 23
        Me.Age.UseWaitCursor = True
        '
        'YearBirthDate
        '
        Me.YearBirthDate.FormattingEnabled = True
        Me.YearBirthDate.Location = New System.Drawing.Point(411, 102)
        Me.YearBirthDate.Name = "YearBirthDate"
        Me.YearBirthDate.Size = New System.Drawing.Size(86, 21)
        Me.YearBirthDate.TabIndex = 22
        Me.YearBirthDate.UseWaitCursor = True
        '
        'MonthBirthDate
        '
        Me.MonthBirthDate.FormattingEnabled = True
        Me.MonthBirthDate.Location = New System.Drawing.Point(332, 102)
        Me.MonthBirthDate.Name = "MonthBirthDate"
        Me.MonthBirthDate.Size = New System.Drawing.Size(59, 21)
        Me.MonthBirthDate.TabIndex = 21
        Me.MonthBirthDate.UseWaitCursor = True
        '
        'DayBirthDate
        '
        Me.DayBirthDate.FormattingEnabled = True
        Me.DayBirthDate.Location = New System.Drawing.Point(252, 102)
        Me.DayBirthDate.Name = "DayBirthDate"
        Me.DayBirthDate.Size = New System.Drawing.Size(59, 21)
        Me.DayBirthDate.TabIndex = 20
        Me.DayBirthDate.UseWaitCursor = True
        '
        'FechaNacFromatLbl
        '
        Me.FechaNacFromatLbl.AutoSize = True
        Me.FechaNacFromatLbl.ForeColor = System.Drawing.Color.Blue
        Me.FechaNacFromatLbl.Location = New System.Drawing.Point(157, 105)
        Me.FechaNacFromatLbl.Name = "FechaNacFromatLbl"
        Me.FechaNacFromatLbl.Size = New System.Drawing.Size(79, 13)
        Me.FechaNacFromatLbl.TabIndex = 19
        Me.FechaNacFromatLbl.Text = "DD/MM/YYYY"
        Me.FechaNacFromatLbl.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(140, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "*"
        Me.Label3.UseWaitCursor = True
        '
        'FechaNacLbl
        '
        Me.FechaNacLbl.AutoSize = True
        Me.FechaNacLbl.Location = New System.Drawing.Point(43, 105)
        Me.FechaNacLbl.Name = "FechaNacLbl"
        Me.FechaNacLbl.Size = New System.Drawing.Size(108, 13)
        Me.FechaNacLbl.TabIndex = 17
        Me.FechaNacLbl.Text = "Fecha de Nacimiento"
        Me.FechaNacLbl.UseWaitCursor = True
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(168, 57)
        Me.FullName.Name = "FullName"
        Me.FullName.ShortcutsEnabled = False
        Me.FullName.Size = New System.Drawing.Size(430, 20)
        Me.FullName.TabIndex = 16
        Me.FullName.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre Completo"
        Me.Label1.UseWaitCursor = True
        '
        'AddPersonLbl
        '
        Me.AddPersonLbl.AutoSize = True
        Me.AddPersonLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPersonLbl.Location = New System.Drawing.Point(41, 17)
        Me.AddPersonLbl.Name = "AddPersonLbl"
        Me.AddPersonLbl.Size = New System.Drawing.Size(207, 26)
        Me.AddPersonLbl.TabIndex = 14
        Me.AddPersonLbl.Text = "Adicionar Persona"
        Me.AddPersonLbl.UseWaitCursor = True
        '
        'EdadLbl
        '
        Me.EdadLbl.AutoSize = True
        Me.EdadLbl.Location = New System.Drawing.Point(45, 160)
        Me.EdadLbl.Name = "EdadLbl"
        Me.EdadLbl.Size = New System.Drawing.Size(32, 13)
        Me.EdadLbl.TabIndex = 27
        Me.EdadLbl.Text = "Edad"
        Me.EdadLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.EdadLbl.UseWaitCursor = True
        '
        'AddNewPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 329)
        Me.Controls.Add(Me.EdadLbl)
        Me.Controls.Add(Me.AddPerson)
        Me.Controls.Add(Me.Sex)
        Me.Controls.Add(Me.SexoLbl)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.YearBirthDate)
        Me.Controls.Add(Me.MonthBirthDate)
        Me.Controls.Add(Me.DayBirthDate)
        Me.Controls.Add(Me.FechaNacFromatLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaNacLbl)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddPersonLbl)
        Me.Name = "AddNewPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Persona"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddPerson As Button
    Friend WithEvents Sex As ComboBox
    Friend WithEvents SexoLbl As Label
    Friend WithEvents Age As TextBox
    Friend WithEvents YearBirthDate As ComboBox
    Friend WithEvents MonthBirthDate As ComboBox
    Friend WithEvents DayBirthDate As ComboBox
    Friend WithEvents FechaNacFromatLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FechaNacLbl As Label
    Friend WithEvents FullName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddPersonLbl As Label
    Friend WithEvents EdadLbl As Label
End Class
