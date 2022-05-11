<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btcadastroalunos = New System.Windows.Forms.Button()
        Me.btcadastroprofessores = New System.Windows.Forms.Button()
        Me.btcadastrofuncionarios = New System.Windows.Forms.Button()
        Me.btbiblioteca = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnotafalta = New System.Windows.Forms.Button()
        Me.btcadascursos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btcadastroalunos
        '
        Me.btcadastroalunos.Location = New System.Drawing.Point(67, 44)
        Me.btcadastroalunos.Name = "btcadastroalunos"
        Me.btcadastroalunos.Size = New System.Drawing.Size(109, 23)
        Me.btcadastroalunos.TabIndex = 0
        Me.btcadastroalunos.Text = "Alunos"
        Me.btcadastroalunos.UseVisualStyleBackColor = True
        '
        'btcadastroprofessores
        '
        Me.btcadastroprofessores.Location = New System.Drawing.Point(67, 73)
        Me.btcadastroprofessores.Name = "btcadastroprofessores"
        Me.btcadastroprofessores.Size = New System.Drawing.Size(109, 23)
        Me.btcadastroprofessores.TabIndex = 1
        Me.btcadastroprofessores.Text = "Professores"
        Me.btcadastroprofessores.UseVisualStyleBackColor = True
        '
        'btcadastrofuncionarios
        '
        Me.btcadastrofuncionarios.Location = New System.Drawing.Point(67, 102)
        Me.btcadastrofuncionarios.Name = "btcadastrofuncionarios"
        Me.btcadastrofuncionarios.Size = New System.Drawing.Size(109, 23)
        Me.btcadastrofuncionarios.TabIndex = 2
        Me.btcadastrofuncionarios.Text = "Funcionários"
        Me.btcadastrofuncionarios.UseVisualStyleBackColor = True
        '
        'btbiblioteca
        '
        Me.btbiblioteca.Location = New System.Drawing.Point(67, 197)
        Me.btbiblioteca.Name = "btbiblioteca"
        Me.btbiblioteca.Size = New System.Drawing.Size(109, 23)
        Me.btbiblioteca.TabIndex = 3
        Me.btbiblioteca.Text = "Biblioteca"
        Me.btbiblioteca.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cadastros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Gerenciamentos"
        '
        'btnotafalta
        '
        Me.btnotafalta.Location = New System.Drawing.Point(67, 226)
        Me.btnotafalta.Name = "btnotafalta"
        Me.btnotafalta.Size = New System.Drawing.Size(109, 23)
        Me.btnotafalta.TabIndex = 6
        Me.btnotafalta.Text = "Notas / Faltas"
        Me.btnotafalta.UseVisualStyleBackColor = True
        '
        'btcadascursos
        '
        Me.btcadascursos.Location = New System.Drawing.Point(67, 131)
        Me.btcadascursos.Name = "btcadascursos"
        Me.btcadascursos.Size = New System.Drawing.Size(109, 23)
        Me.btcadascursos.TabIndex = 7
        Me.btcadascursos.Text = "Cursos"
        Me.btcadascursos.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 261)
        Me.Controls.Add(Me.btcadascursos)
        Me.Controls.Add(Me.btnotafalta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbiblioteca)
        Me.Controls.Add(Me.btcadastrofuncionarios)
        Me.Controls.Add(Me.btcadastroprofessores)
        Me.Controls.Add(Me.btcadastroalunos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btcadastroalunos As System.Windows.Forms.Button
    Friend WithEvents btcadastroprofessores As System.Windows.Forms.Button
    Friend WithEvents btcadastrofuncionarios As System.Windows.Forms.Button
    Friend WithEvents btbiblioteca As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnotafalta As System.Windows.Forms.Button
    Friend WithEvents btcadascursos As System.Windows.Forms.Button
End Class
