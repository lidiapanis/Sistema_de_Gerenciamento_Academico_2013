<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas_Faltas_Lançamento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtra = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtmateria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmedia = New System.Windows.Forms.TextBox()
        Me.txtfalta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nomecurso = New System.Windows.Forms.Label()
        Me.curso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsemestre = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.Label()
        Me.btlancar = New System.Windows.Forms.Button()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnomeprof = New System.Windows.Forms.Label()
        Me.txtcpfprof = New System.Windows.Forms.Label()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.nomeprofessor = New System.Windows.Forms.Label()
        Me.bteditar = New System.Windows.Forms.Button()
        Me.cd_aluno = New System.Windows.Forms.Label()
        Me.dtgnotas = New System.Windows.Forms.DataGridView()
        CType(Me.dtgnotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "R.A do Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF do Aluno"
        '
        'txtra
        '
        Me.txtra.Location = New System.Drawing.Point(98, 27)
        Me.txtra.Name = "txtra"
        Me.txtra.Size = New System.Drawing.Size(117, 20)
        Me.txtra.TabIndex = 3
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(299, 27)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(117, 20)
        Me.txtcpf.TabIndex = 5
        '
        'txtmateria
        '
        Me.txtmateria.Location = New System.Drawing.Point(98, 79)
        Me.txtmateria.Name = "txtmateria"
        Me.txtmateria.Size = New System.Drawing.Size(318, 20)
        Me.txtmateria.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Matéria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Professor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Média Final"
        '
        'txtmedia
        '
        Me.txtmedia.Location = New System.Drawing.Point(98, 131)
        Me.txtmedia.Name = "txtmedia"
        Me.txtmedia.Size = New System.Drawing.Size(117, 20)
        Me.txtmedia.TabIndex = 11
        '
        'txtfalta
        '
        Me.txtfalta.Location = New System.Drawing.Point(299, 131)
        Me.txtfalta.Name = "txtfalta"
        Me.txtfalta.Size = New System.Drawing.Size(117, 20)
        Me.txtfalta.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total de Faltas"
        '
        'nomecurso
        '
        Me.nomecurso.AutoSize = True
        Me.nomecurso.Location = New System.Drawing.Point(12, 158)
        Me.nomecurso.Name = "nomecurso"
        Me.nomecurso.Size = New System.Drawing.Size(34, 13)
        Me.nomecurso.TabIndex = 15
        Me.nomecurso.Text = "Curso"
        '
        'curso
        '
        Me.curso.AutoSize = True
        Me.curso.Location = New System.Drawing.Point(98, 158)
        Me.curso.Name = "curso"
        Me.curso.Size = New System.Drawing.Size(0, 13)
        Me.curso.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Semestre"
        '
        'txtsemestre
        '
        Me.txtsemestre.Location = New System.Drawing.Point(299, 155)
        Me.txtsemestre.Name = "txtsemestre"
        Me.txtsemestre.Size = New System.Drawing.Size(117, 20)
        Me.txtsemestre.TabIndex = 18
        '
        'txtnome
        '
        Me.txtnome.AutoSize = True
        Me.txtnome.Location = New System.Drawing.Point(98, 54)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(0, 13)
        Me.txtnome.TabIndex = 19
        '
        'btlancar
        '
        Me.btlancar.Location = New System.Drawing.Point(23, 219)
        Me.btlancar.Name = "btlancar"
        Me.btlancar.Size = New System.Drawing.Size(75, 23)
        Me.btlancar.TabIndex = 20
        Me.btlancar.Text = "Lançar"
        Me.btlancar.UseVisualStyleBackColor = True
        '
        'btexcluir
        '
        Me.btexcluir.Location = New System.Drawing.Point(23, 248)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 23)
        Me.btexcluir.TabIndex = 21
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btcancelar
        '
        Me.btcancelar.Location = New System.Drawing.Point(23, 277)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 22
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "CPF do Prof"
        '
        'txtnomeprof
        '
        Me.txtnomeprof.AutoSize = True
        Me.txtnomeprof.Location = New System.Drawing.Point(279, 108)
        Me.txtnomeprof.Name = "txtnomeprof"
        Me.txtnomeprof.Size = New System.Drawing.Size(0, 13)
        Me.txtnomeprof.TabIndex = 3
        '
        'txtcpfprof
        '
        Me.txtcpfprof.AutoSize = True
        Me.txtcpfprof.Location = New System.Drawing.Point(98, 108)
        Me.txtcpfprof.Name = "txtcpfprof"
        Me.txtcpfprof.Size = New System.Drawing.Size(0, 13)
        Me.txtcpfprof.TabIndex = 25
        '
        'btnovo
        '
        Me.btnovo.Location = New System.Drawing.Point(23, 190)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 23)
        Me.btnovo.TabIndex = 26
        Me.btnovo.Text = "Novo"
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'nomeprofessor
        '
        Me.nomeprofessor.AutoSize = True
        Me.nomeprofessor.Location = New System.Drawing.Point(303, 108)
        Me.nomeprofessor.Name = "nomeprofessor"
        Me.nomeprofessor.Size = New System.Drawing.Size(0, 13)
        Me.nomeprofessor.TabIndex = 2
        '
        'bteditar
        '
        Me.bteditar.Location = New System.Drawing.Point(23, 306)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(75, 23)
        Me.bteditar.TabIndex = 27
        Me.bteditar.Text = "Procurar"
        Me.bteditar.UseVisualStyleBackColor = True
        '
        'cd_aluno
        '
        Me.cd_aluno.AutoSize = True
        Me.cd_aluno.Location = New System.Drawing.Point(445, 10)
        Me.cd_aluno.Name = "cd_aluno"
        Me.cd_aluno.Size = New System.Drawing.Size(0, 13)
        Me.cd_aluno.TabIndex = 28
        '
        'dtgnotas
        '
        Me.dtgnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgnotas.Location = New System.Drawing.Point(132, 202)
        Me.dtgnotas.Name = "dtgnotas"
        Me.dtgnotas.Size = New System.Drawing.Size(284, 127)
        Me.dtgnotas.TabIndex = 29
        '
        'Notas_Faltas_Lançamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 347)
        Me.Controls.Add(Me.dtgnotas)
        Me.Controls.Add(Me.cd_aluno)
        Me.Controls.Add(Me.bteditar)
        Me.Controls.Add(Me.nomeprofessor)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.txtcpfprof)
        Me.Controls.Add(Me.txtnomeprof)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btcancelar)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btlancar)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtsemestre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.curso)
        Me.Controls.Add(Me.nomecurso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfalta)
        Me.Controls.Add(Me.txtmedia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmateria)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.txtra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notas_Faltas_Lançamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamento de Notas e Faltas"
        CType(Me.dtgnotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtra As System.Windows.Forms.TextBox
    Friend WithEvents txtcpf As System.Windows.Forms.TextBox
    Friend WithEvents txtmateria As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmedia As System.Windows.Forms.TextBox
    Friend WithEvents txtfalta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomecurso As System.Windows.Forms.Label
    Friend WithEvents curso As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsemestre As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.Label
    Friend WithEvents btlancar As System.Windows.Forms.Button
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btcancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnomeprof As System.Windows.Forms.Label
    Friend WithEvents txtcpfprof As System.Windows.Forms.Label
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents nomeprofessor As System.Windows.Forms.Label
    Friend WithEvents bteditar As System.Windows.Forms.Button
    Friend WithEvents cd_aluno As System.Windows.Forms.Label
    Friend WithEvents dtgnotas As System.Windows.Forms.DataGridView
End Class
