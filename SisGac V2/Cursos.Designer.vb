<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cursos
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
        Me.btpesquisarcurso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomecurso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nupqtdsemestres = New System.Windows.Forms.NumericUpDown()
        Me.btsalvarcurso = New System.Windows.Forms.Button()
        Me.btexcluircurso = New System.Windows.Forms.Button()
        Me.btcancelarcurso = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.cd_curso = New System.Windows.Forms.Label()
        CType(Me.nupqtdsemestres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btpesquisarcurso
        '
        Me.btpesquisarcurso.Location = New System.Drawing.Point(177, 12)
        Me.btpesquisarcurso.Name = "btpesquisarcurso"
        Me.btpesquisarcurso.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisarcurso.TabIndex = 0
        Me.btpesquisarcurso.Text = "Pesquisar"
        Me.btpesquisarcurso.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Curso"
        '
        'txtnomecurso
        '
        Me.txtnomecurso.Location = New System.Drawing.Point(57, 63)
        Me.txtnomecurso.Name = "txtnomecurso"
        Me.txtnomecurso.Size = New System.Drawing.Size(195, 20)
        Me.txtnomecurso.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quantidade de Semestres"
        '
        'nupqtdsemestres
        '
        Me.nupqtdsemestres.Location = New System.Drawing.Point(152, 98)
        Me.nupqtdsemestres.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupqtdsemestres.Name = "nupqtdsemestres"
        Me.nupqtdsemestres.Size = New System.Drawing.Size(42, 20)
        Me.nupqtdsemestres.TabIndex = 4
        '
        'btsalvarcurso
        '
        Me.btsalvarcurso.Location = New System.Drawing.Point(152, 163)
        Me.btsalvarcurso.Name = "btsalvarcurso"
        Me.btsalvarcurso.Size = New System.Drawing.Size(75, 23)
        Me.btsalvarcurso.TabIndex = 5
        Me.btsalvarcurso.Text = "Salvar"
        Me.btsalvarcurso.UseVisualStyleBackColor = True
        '
        'btexcluircurso
        '
        Me.btexcluircurso.Location = New System.Drawing.Point(29, 207)
        Me.btexcluircurso.Name = "btexcluircurso"
        Me.btexcluircurso.Size = New System.Drawing.Size(75, 23)
        Me.btexcluircurso.TabIndex = 6
        Me.btexcluircurso.Text = "Excluir"
        Me.btexcluircurso.UseVisualStyleBackColor = True
        '
        'btcancelarcurso
        '
        Me.btcancelarcurso.Location = New System.Drawing.Point(152, 207)
        Me.btcancelarcurso.Name = "btcancelarcurso"
        Me.btcancelarcurso.Size = New System.Drawing.Size(75, 23)
        Me.btcancelarcurso.TabIndex = 7
        Me.btcancelarcurso.Text = "Cancelar"
        Me.btcancelarcurso.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Location = New System.Drawing.Point(29, 163)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 23)
        Me.btnovo.TabIndex = 8
        Me.btnovo.Text = "Novo"
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'cd_curso
        '
        Me.cd_curso.AutoSize = True
        Me.cd_curso.Location = New System.Drawing.Point(26, 17)
        Me.cd_curso.Name = "cd_curso"
        Me.cd_curso.Size = New System.Drawing.Size(0, 13)
        Me.cd_curso.TabIndex = 9
        '
        'Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cd_curso)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.btcancelarcurso)
        Me.Controls.Add(Me.btexcluircurso)
        Me.Controls.Add(Me.btsalvarcurso)
        Me.Controls.Add(Me.nupqtdsemestres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnomecurso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btpesquisarcurso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cursos"
        CType(Me.nupqtdsemestres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btpesquisarcurso As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnomecurso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nupqtdsemestres As System.Windows.Forms.NumericUpDown
    Friend WithEvents btsalvarcurso As System.Windows.Forms.Button
    Friend WithEvents btexcluircurso As System.Windows.Forms.Button
    Friend WithEvents btcancelarcurso As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents cd_curso As System.Windows.Forms.Label
End Class
