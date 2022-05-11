<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionarios
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
        Me.Funcionário = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcodigofunc = New System.Windows.Forms.TextBox()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.txtcaminhofotofunc = New System.Windows.Forms.TextBox()
        Me.txtfuncao = New System.Windows.Forms.TextBox()
        Me.txtemailfunc = New System.Windows.Forms.TextBox()
        Me.txttelefonefunc = New System.Windows.Forms.TextBox()
        Me.txtcidadefunc = New System.Windows.Forms.TextBox()
        Me.txtbairrofunc = New System.Windows.Forms.TextBox()
        Me.txtenderecofunc = New System.Windows.Forms.TextBox()
        Me.txtnomefunc = New System.Windows.Forms.TextBox()
        Me.txtcpffunc = New System.Windows.Forms.TextBox()
        Me.btfoto = New System.Windows.Forms.Button()
        Me.pbfotofunc = New System.Windows.Forms.PictureBox()
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
        Me.OpenFileDialogfunc = New System.Windows.Forms.OpenFileDialog()
        Me.Funcionário.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbfotofunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Funcionário
        '
        Me.Funcionário.Controls.Add(Me.TabPage1)
        Me.Funcionário.Location = New System.Drawing.Point(12, 12)
        Me.Funcionário.Name = "Funcionário"
        Me.Funcionário.SelectedIndex = 0
        Me.Funcionário.Size = New System.Drawing.Size(636, 344)
        Me.Funcionário.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtsenha)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtcodigofunc)
        Me.TabPage1.Controls.Add(Me.btcancelar)
        Me.TabPage1.Controls.Add(Me.btexcluir)
        Me.TabPage1.Controls.Add(Me.btsalvar)
        Me.TabPage1.Controls.Add(Me.btnovo)
        Me.TabPage1.Controls.Add(Me.txtcaminhofotofunc)
        Me.TabPage1.Controls.Add(Me.txtfuncao)
        Me.TabPage1.Controls.Add(Me.txtemailfunc)
        Me.TabPage1.Controls.Add(Me.txttelefonefunc)
        Me.TabPage1.Controls.Add(Me.txtcidadefunc)
        Me.TabPage1.Controls.Add(Me.txtbairrofunc)
        Me.TabPage1.Controls.Add(Me.txtenderecofunc)
        Me.TabPage1.Controls.Add(Me.txtnomefunc)
        Me.TabPage1.Controls.Add(Me.txtcpffunc)
        Me.TabPage1.Controls.Add(Me.btfoto)
        Me.TabPage1.Controls.Add(Me.pbfotofunc)
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
        Me.TabPage1.Text = "Funcionário"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(65, 264)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(127, 20)
        Me.txtsenha.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Senha"
        '
        'txtcodigofunc
        '
        Me.txtcodigofunc.Location = New System.Drawing.Point(160, 8)
        Me.txtcodigofunc.Name = "txtcodigofunc"
        Me.txtcodigofunc.Size = New System.Drawing.Size(44, 20)
        Me.txtcodigofunc.TabIndex = 30
        '
        'btcancelar
        '
        Me.btcancelar.Location = New System.Drawing.Point(465, 277)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 12
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
        Me.btsalvar.TabIndex = 11
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
        'txtcaminhofotofunc
        '
        Me.txtcaminhofotofunc.Location = New System.Drawing.Point(434, 5)
        Me.txtcaminhofotofunc.Name = "txtcaminhofotofunc"
        Me.txtcaminhofotofunc.Size = New System.Drawing.Size(126, 20)
        Me.txtcaminhofotofunc.TabIndex = 25
        '
        'txtfuncao
        '
        Me.txtfuncao.Location = New System.Drawing.Point(65, 236)
        Me.txtfuncao.Name = "txtfuncao"
        Me.txtfuncao.Size = New System.Drawing.Size(305, 20)
        Me.txtfuncao.TabIndex = 8
        '
        'txtemailfunc
        '
        Me.txtemailfunc.Location = New System.Drawing.Point(65, 204)
        Me.txtemailfunc.Name = "txtemailfunc"
        Me.txtemailfunc.Size = New System.Drawing.Size(305, 20)
        Me.txtemailfunc.TabIndex = 7
        '
        'txttelefonefunc
        '
        Me.txttelefonefunc.Location = New System.Drawing.Point(244, 173)
        Me.txttelefonefunc.Name = "txttelefonefunc"
        Me.txttelefonefunc.Size = New System.Drawing.Size(126, 20)
        Me.txttelefonefunc.TabIndex = 6
        '
        'txtcidadefunc
        '
        Me.txtcidadefunc.Location = New System.Drawing.Point(243, 139)
        Me.txtcidadefunc.Name = "txtcidadefunc"
        Me.txtcidadefunc.Size = New System.Drawing.Size(127, 20)
        Me.txtcidadefunc.TabIndex = 4
        '
        'txtbairrofunc
        '
        Me.txtbairrofunc.Location = New System.Drawing.Point(65, 139)
        Me.txtbairrofunc.Name = "txtbairrofunc"
        Me.txtbairrofunc.Size = New System.Drawing.Size(126, 20)
        Me.txtbairrofunc.TabIndex = 3
        '
        'txtenderecofunc
        '
        Me.txtenderecofunc.Location = New System.Drawing.Point(65, 109)
        Me.txtenderecofunc.Name = "txtenderecofunc"
        Me.txtenderecofunc.Size = New System.Drawing.Size(305, 20)
        Me.txtenderecofunc.TabIndex = 2
        '
        'txtnomefunc
        '
        Me.txtnomefunc.Location = New System.Drawing.Point(65, 78)
        Me.txtnomefunc.Name = "txtnomefunc"
        Me.txtnomefunc.Size = New System.Drawing.Size(305, 20)
        Me.txtnomefunc.TabIndex = 1
        '
        'txtcpffunc
        '
        Me.txtcpffunc.Location = New System.Drawing.Point(65, 43)
        Me.txtcpffunc.Name = "txtcpffunc"
        Me.txtcpffunc.Size = New System.Drawing.Size(126, 20)
        Me.txtcpffunc.TabIndex = 0
        '
        'btfoto
        '
        Me.btfoto.Location = New System.Drawing.Point(465, 161)
        Me.btfoto.Name = "btfoto"
        Me.btfoto.Size = New System.Drawing.Size(75, 23)
        Me.btfoto.TabIndex = 10
        Me.btfoto.Text = "Foto"
        Me.btfoto.UseVisualStyleBackColor = True
        '
        'pbfotofunc
        '
        Me.pbfotofunc.Location = New System.Drawing.Point(420, 31)
        Me.pbfotofunc.Name = "pbfotofunc"
        Me.pbfotofunc.Size = New System.Drawing.Size(163, 124)
        Me.pbfotofunc.TabIndex = 22
        Me.pbfotofunc.TabStop = False
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
        Me.cbestado.TabIndex = 5
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
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Função"
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
        'OpenFileDialogfunc
        '
        Me.OpenFileDialogfunc.FileName = "OpenFileDialogfunc"
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 357)
        Me.Controls.Add(Me.Funcionário)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        Me.Funcionário.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbfotofunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Funcionário As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btcancelar As System.Windows.Forms.Button
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents txtcaminhofotofunc As System.Windows.Forms.TextBox
    Friend WithEvents txtfuncao As System.Windows.Forms.TextBox
    Friend WithEvents txtemailfunc As System.Windows.Forms.TextBox
    Friend WithEvents txttelefonefunc As System.Windows.Forms.TextBox
    Friend WithEvents txtcidadefunc As System.Windows.Forms.TextBox
    Friend WithEvents txtbairrofunc As System.Windows.Forms.TextBox
    Friend WithEvents txtenderecofunc As System.Windows.Forms.TextBox
    Friend WithEvents txtnomefunc As System.Windows.Forms.TextBox
    Friend WithEvents txtcpffunc As System.Windows.Forms.TextBox
    Friend WithEvents btfoto As System.Windows.Forms.Button
    Friend WithEvents pbfotofunc As System.Windows.Forms.PictureBox
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
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcodigofunc As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialogfunc As System.Windows.Forms.OpenFileDialog
End Class
