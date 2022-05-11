<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas_Faltas_Consulta_aluno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nomedoaluno = New System.Windows.Forms.Label()
        Me.Curso = New System.Windows.Forms.Label()
        Me.matricula = New System.Windows.Forms.Label()
        Me.CPF = New System.Windows.Forms.Label()
        Me.dtgvisualizacao = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgvisualizacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomedoaluno
        '
        Me.nomedoaluno.AutoSize = True
        Me.nomedoaluno.Location = New System.Drawing.Point(74, 22)
        Me.nomedoaluno.Name = "nomedoaluno"
        Me.nomedoaluno.Size = New System.Drawing.Size(39, 13)
        Me.nomedoaluno.TabIndex = 0
        Me.nomedoaluno.Text = "Label1"
        '
        'Curso
        '
        Me.Curso.AutoSize = True
        Me.Curso.Location = New System.Drawing.Point(74, 45)
        Me.Curso.Name = "Curso"
        Me.Curso.Size = New System.Drawing.Size(39, 13)
        Me.Curso.TabIndex = 1
        Me.Curso.Text = "Label2"
        '
        'matricula
        '
        Me.matricula.AutoSize = True
        Me.matricula.Location = New System.Drawing.Point(74, 71)
        Me.matricula.Name = "matricula"
        Me.matricula.Size = New System.Drawing.Size(39, 13)
        Me.matricula.TabIndex = 2
        Me.matricula.Text = "Label3"
        '
        'CPF
        '
        Me.CPF.AutoSize = True
        Me.CPF.Location = New System.Drawing.Point(74, 93)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(39, 13)
        Me.CPF.TabIndex = 3
        Me.CPF.Text = "Label4"
        '
        'dtgvisualizacao
        '
        Me.dtgvisualizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvisualizacao.Location = New System.Drawing.Point(12, 119)
        Me.dtgvisualizacao.Name = "dtgvisualizacao"
        Me.dtgvisualizacao.Size = New System.Drawing.Size(429, 198)
        Me.dtgvisualizacao.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Matricula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CPF"
        '
        'Notas_Faltas_Consulta_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(453, 329)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgvisualizacao)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.matricula)
        Me.Controls.Add(Me.Curso)
        Me.Controls.Add(Me.nomedoaluno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notas_Faltas_Consulta_aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Notas e Faltas"
        CType(Me.dtgvisualizacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomedoaluno As System.Windows.Forms.Label
    Friend WithEvents Curso As System.Windows.Forms.Label
    Friend WithEvents matricula As System.Windows.Forms.Label
    Friend WithEvents CPF As System.Windows.Forms.Label
    Friend WithEvents dtgvisualizacao As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
