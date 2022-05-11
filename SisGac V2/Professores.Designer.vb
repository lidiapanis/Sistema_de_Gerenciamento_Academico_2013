<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professores
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
        Me.Professor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtcodigoprof = New System.Windows.Forms.TextBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.txtcaminhofotoprof = New System.Windows.Forms.TextBox()
        Me.txtformacaoprof = New System.Windows.Forms.TextBox()
        Me.txtemailprof = New System.Windows.Forms.TextBox()
        Me.txttelefoneprof = New System.Windows.Forms.TextBox()
        Me.txtcidadeprof = New System.Windows.Forms.TextBox()
        Me.txtbairroprof = New System.Windows.Forms.TextBox()
        Me.txtenderecoprof = New System.Windows.Forms.TextBox()
        Me.txtnomeprof = New System.Windows.Forms.TextBox()
        Me.txtcpfprof = New System.Windows.Forms.TextBox()
        Me.btfoto = New System.Windows.Forms.Button()
        Me.pbfotoprof = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbestado = New System.Windows.Forms.ComboBox()
        Me.dtpnascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btpesquisar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialogprof = New System.Windows.Forms.OpenFileDialog()
        Me.Professor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbfotoprof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Professor
        '
        Me.Professor.Controls.Add(Me.TabPage1)
        Me.Professor.Location = New System.Drawing.Point(3, 12)
        Me.Professor.Name = "Professor"
        Me.Professor.SelectedIndex = 0
        Me.Professor.Size = New System.Drawing.Size(636, 344)
        Me.Professor.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtcodigoprof)
        Me.TabPage1.Controls.Add(Me.txtsenha)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.btcancelar)
        Me.TabPage1.Controls.Add(Me.btexcluir)
        Me.TabPage1.Controls.Add(Me.btsalvar)
        Me.TabPage1.Controls.Add(Me.btnovo)
        Me.TabPage1.Controls.Add(Me.txtcaminhofotoprof)
        Me.TabPage1.Controls.Add(Me.txtformacaoprof)
        Me.TabPage1.Controls.Add(Me.txtemailprof)
        Me.TabPage1.Controls.Add(Me.txttelefoneprof)
        Me.TabPage1.Controls.Add(Me.txtcidadeprof)
        Me.TabPage1.Controls.Add(Me.txtbairroprof)
        Me.TabPage1.Controls.Add(Me.txtenderecoprof)
        Me.TabPage1.Controls.Add(Me.txtnomeprof)
        Me.TabPage1.Controls.Add(Me.txtcpfprof)
        Me.TabPage1.Controls.Add(Me.btfoto)
        Me.TabPage1.Controls.Add(Me.pbfotoprof)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbestado)
        Me.TabPage1.Controls.Add(Me.dtpnascimento)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btpesquisar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(628, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Professor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtcodigoprof
        '
        Me.txtcodigoprof.Location = New System.Drawing.Point(129, 8)
        Me.txtcodigoprof.Name = "txtcodigoprof"
        Me.txtcodigoprof.Size = New System.Drawing.Size(43, 20)
        Me.txtcodigoprof.TabIndex = 32
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(65, 269)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(126, 20)
        Me.txtsenha.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Senha"
        '
        'btcancelar
        '
        Me.btcancelar.Location = New System.Drawing.Point(465, 277)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 29
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'btexcluir
        '
        Me.btexcluir.Location = New System.Drawing.Point(465, 248)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 23)
        Me.btexcluir.TabIndex = 28
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Location = New System.Drawing.Point(465, 219)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 23)
        Me.btsalvar.TabIndex = 27
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Location = New System.Drawing.Point(465, 190)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 23)
        Me.btnovo.TabIndex = 26
        Me.btnovo.Text = "Novo"
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'txtcaminhofotoprof
        '
        Me.txtcaminhofotoprof.Location = New System.Drawing.Point(434, 5)
        Me.txtcaminhofotoprof.Name = "txtcaminhofotoprof"
        Me.txtcaminhofotoprof.Size = New System.Drawing.Size(126, 20)
        Me.txtcaminhofotoprof.TabIndex = 25
        '
        'txtformacaoprof
        '
        Me.txtformacaoprof.Location = New System.Drawing.Point(65, 236)
        Me.txtformacaoprof.Name = "txtformacaoprof"
        Me.txtformacaoprof.Size = New System.Drawing.Size(305, 20)
        Me.txtformacaoprof.TabIndex = 18
        '
        'txtemailprof
        '
        Me.txtemailprof.Location = New System.Drawing.Point(65, 204)
        Me.txtemailprof.Name = "txtemailprof"
        Me.txtemailprof.Size = New System.Drawing.Size(305, 20)
        Me.txtemailprof.TabIndex = 17
        '
        'txttelefoneprof
        '
        Me.txttelefoneprof.Location = New System.Drawing.Point(244, 173)
        Me.txttelefoneprof.Name = "txttelefoneprof"
        Me.txttelefoneprof.Size = New System.Drawing.Size(126, 20)
        Me.txttelefoneprof.TabIndex = 16
        '
        'txtcidadeprof
        '
        Me.txtcidadeprof.Location = New System.Drawing.Point(243, 139)
        Me.txtcidadeprof.Name = "txtcidadeprof"
        Me.txtcidadeprof.Size = New System.Drawing.Size(127, 20)
        Me.txtcidadeprof.TabIndex = 15
        '
        'txtbairroprof
        '
        Me.txtbairroprof.Location = New System.Drawing.Point(65, 139)
        Me.txtbairroprof.Name = "txtbairroprof"
        Me.txtbairroprof.Size = New System.Drawing.Size(126, 20)
        Me.txtbairroprof.TabIndex = 13
        '
        'txtenderecoprof
        '
        Me.txtenderecoprof.Location = New System.Drawing.Point(65, 109)
        Me.txtenderecoprof.Name = "txtenderecoprof"
        Me.txtenderecoprof.Size = New System.Drawing.Size(305, 20)
        Me.txtenderecoprof.TabIndex = 12
        '
        'txtnomeprof
        '
        Me.txtnomeprof.Location = New System.Drawing.Point(65, 78)
        Me.txtnomeprof.Name = "txtnomeprof"
        Me.txtnomeprof.Size = New System.Drawing.Size(305, 20)
        Me.txtnomeprof.TabIndex = 11
        '
        'txtcpfprof
        '
        Me.txtcpfprof.Location = New System.Drawing.Point(65, 43)
        Me.txtcpfprof.Name = "txtcpfprof"
        Me.txtcpfprof.Size = New System.Drawing.Size(126, 20)
        Me.txtcpfprof.TabIndex = 1
        '
        'btfoto
        '
        Me.btfoto.Location = New System.Drawing.Point(465, 161)
        Me.btfoto.Name = "btfoto"
        Me.btfoto.Size = New System.Drawing.Size(75, 23)
        Me.btfoto.TabIndex = 24
        Me.btfoto.Text = "Foto"
        Me.btfoto.UseVisualStyleBackColor = True
        '
        'pbfotoprof
        '
        Me.pbfotoprof.Location = New System.Drawing.Point(420, 31)
        Me.pbfotoprof.Name = "pbfotoprof"
        Me.pbfotoprof.Size = New System.Drawing.Size(163, 124)
        Me.pbfotoprof.TabIndex = 22
        Me.pbfotoprof.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(197, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Data de Nascimento"
        '
        'cbestado
        '
        Me.cbestado.FormattingEnabled = True
        Me.cbestado.Items.AddRange(New Object() {"SP"})
        Me.cbestado.Location = New System.Drawing.Point(65, 173)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(126, 21)
        Me.cbestado.TabIndex = 20
        '
        'dtpnascimento
        '
        Me.dtpnascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpnascimento.Location = New System.Drawing.Point(307, 40)
        Me.dtpnascimento.Name = "dtpnascimento"
        Me.dtpnascimento.Size = New System.Drawing.Size(83, 20)
        Me.dtpnascimento.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Cidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Formação "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bairro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'btpesquisar
        '
        Me.btpesquisar.Location = New System.Drawing.Point(25, 6)
        Me.btpesquisar.Name = "btpesquisar"
        Me.btpesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisar.TabIndex = 2
        Me.btpesquisar.Text = "Procurar"
        Me.btpesquisar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'OpenFileDialogprof
        '
        Me.OpenFileDialogprof.FileName = "OpenFileDialogprof"
        '
        'Professores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 354)
        Me.Controls.Add(Me.Professor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Professores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Professores"
        Me.Professor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbfotoprof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Professor As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btcancelar As System.Windows.Forms.Button
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents txtcaminhofotoprof As System.Windows.Forms.TextBox
    Friend WithEvents txtformacaoprof As System.Windows.Forms.TextBox
    Friend WithEvents txtemailprof As System.Windows.Forms.TextBox
    Friend WithEvents txttelefoneprof As System.Windows.Forms.TextBox
    Friend WithEvents txtcidadeprof As System.Windows.Forms.TextBox
    Friend WithEvents txtbairroprof As System.Windows.Forms.TextBox
    Friend WithEvents txtenderecoprof As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeprof As System.Windows.Forms.TextBox
    Friend WithEvents txtcpfprof As System.Windows.Forms.TextBox
    Friend WithEvents btfoto As System.Windows.Forms.Button
    Friend WithEvents pbfotoprof As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbestado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpnascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btpesquisar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogprof As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoprof As System.Windows.Forms.TextBox
End Class
