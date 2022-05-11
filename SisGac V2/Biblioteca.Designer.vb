<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biblioteca
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.txtcodlivrocadastro = New System.Windows.Forms.TextBox()
        Me.btsalvarlivro = New System.Windows.Forms.Button()
        Me.dtpaquisicao = New System.Windows.Forms.DateTimePicker()
        Me.dtplancamento = New System.Windows.Forms.DateTimePicker()
        Me.btcancelarlivro = New System.Windows.Forms.Button()
        Me.btexcluirlivro = New System.Windows.Forms.Button()
        Me.btnovolivro = New System.Windows.Forms.Button()
        Me.btpesquisarlivro = New System.Windows.Forms.Button()
        Me.txtmultadiaria = New System.Windows.Forms.TextBox()
        Me.txtestoque = New System.Windows.Forms.TextBox()
        Me.txtprecocusto = New System.Windows.Forms.TextBox()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.txteditora = New System.Windows.Forms.TextBox()
        Me.txtnomelivro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtcod_solicitante = New System.Windows.Forms.TextBox()
        Me.txtcod_exemplar = New System.Windows.Forms.TextBox()
        Me.dtgemprestimo = New System.Windows.Forms.DataGridView()
        Me.btcancelaremprestimo = New System.Windows.Forms.Button()
        Me.btsalvaremprestimos = New System.Windows.Forms.Button()
        Me.btnovoempréstimo = New System.Windows.Forms.Button()
        Me.btpesquisasolicitanteemprestimo = New System.Windows.Forms.Button()
        Me.btpesquisalivroemprestimo = New System.Windows.Forms.Button()
        Me.dtpprevisaoentrega = New System.Windows.Forms.DateTimePicker()
        Me.dtpretirada = New System.Windows.Forms.DateTimePicker()
        Me.txtsolicitante = New System.Windows.Forms.TextBox()
        Me.txtexemplar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtlivroaserentregue = New System.Windows.Forms.Label()
        Me.txtcodemprestimo = New System.Windows.Forms.Label()
        Me.txtnomedequememprestou = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btcancelardevolucao = New System.Windows.Forms.Button()
        Me.btdevolver = New System.Windows.Forms.Button()
        Me.txttotaldemulta = New System.Windows.Forms.TextBox()
        Me.dtpdatarealdeentrega = New System.Windows.Forms.DateTimePicker()
        Me.dtpretiradadevolucao = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgemprestimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(512, 295)
        Me.TabControl1.TabIndex = 0
        '
        'Cadastro
        '
        Me.Cadastro.Controls.Add(Me.txtcodlivrocadastro)
        Me.Cadastro.Controls.Add(Me.btsalvarlivro)
        Me.Cadastro.Controls.Add(Me.dtpaquisicao)
        Me.Cadastro.Controls.Add(Me.dtplancamento)
        Me.Cadastro.Controls.Add(Me.btcancelarlivro)
        Me.Cadastro.Controls.Add(Me.btexcluirlivro)
        Me.Cadastro.Controls.Add(Me.btnovolivro)
        Me.Cadastro.Controls.Add(Me.btpesquisarlivro)
        Me.Cadastro.Controls.Add(Me.txtmultadiaria)
        Me.Cadastro.Controls.Add(Me.txtestoque)
        Me.Cadastro.Controls.Add(Me.txtprecocusto)
        Me.Cadastro.Controls.Add(Me.txtcategoria)
        Me.Cadastro.Controls.Add(Me.txteditora)
        Me.Cadastro.Controls.Add(Me.txtnomelivro)
        Me.Cadastro.Controls.Add(Me.Label10)
        Me.Cadastro.Controls.Add(Me.Label9)
        Me.Cadastro.Controls.Add(Me.Label8)
        Me.Cadastro.Controls.Add(Me.Label7)
        Me.Cadastro.Controls.Add(Me.Label6)
        Me.Cadastro.Controls.Add(Me.Label5)
        Me.Cadastro.Controls.Add(Me.Label4)
        Me.Cadastro.Controls.Add(Me.Label3)
        Me.Cadastro.Controls.Add(Me.Label2)
        Me.Cadastro.Location = New System.Drawing.Point(4, 22)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.Cadastro.Size = New System.Drawing.Size(504, 269)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        Me.Cadastro.UseVisualStyleBackColor = True
        '
        'txtcodlivrocadastro
        '
        Me.txtcodlivrocadastro.Location = New System.Drawing.Point(425, 18)
        Me.txtcodlivrocadastro.Name = "txtcodlivrocadastro"
        Me.txtcodlivrocadastro.Size = New System.Drawing.Size(40, 20)
        Me.txtcodlivrocadastro.TabIndex = 25
        '
        'btsalvarlivro
        '
        Me.btsalvarlivro.Location = New System.Drawing.Point(116, 222)
        Me.btsalvarlivro.Name = "btsalvarlivro"
        Me.btsalvarlivro.Size = New System.Drawing.Size(75, 23)
        Me.btsalvarlivro.TabIndex = 24
        Me.btsalvarlivro.Text = "Salvar"
        Me.btsalvarlivro.UseVisualStyleBackColor = True
        '
        'dtpaquisicao
        '
        Me.dtpaquisicao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpaquisicao.Location = New System.Drawing.Point(393, 106)
        Me.dtpaquisicao.Name = "dtpaquisicao"
        Me.dtpaquisicao.Size = New System.Drawing.Size(89, 20)
        Me.dtpaquisicao.TabIndex = 23
        '
        'dtplancamento
        '
        Me.dtplancamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtplancamento.Location = New System.Drawing.Point(393, 80)
        Me.dtplancamento.Name = "dtplancamento"
        Me.dtplancamento.Size = New System.Drawing.Size(89, 20)
        Me.dtplancamento.TabIndex = 22
        '
        'btcancelarlivro
        '
        Me.btcancelarlivro.Location = New System.Drawing.Point(278, 222)
        Me.btcancelarlivro.Name = "btcancelarlivro"
        Me.btcancelarlivro.Size = New System.Drawing.Size(75, 23)
        Me.btcancelarlivro.TabIndex = 21
        Me.btcancelarlivro.Text = "Cancelar"
        Me.btcancelarlivro.UseVisualStyleBackColor = True
        '
        'btexcluirlivro
        '
        Me.btexcluirlivro.Location = New System.Drawing.Point(197, 222)
        Me.btexcluirlivro.Name = "btexcluirlivro"
        Me.btexcluirlivro.Size = New System.Drawing.Size(75, 23)
        Me.btexcluirlivro.TabIndex = 20
        Me.btexcluirlivro.Text = "Excluir"
        Me.btexcluirlivro.UseVisualStyleBackColor = True
        '
        'btnovolivro
        '
        Me.btnovolivro.Location = New System.Drawing.Point(35, 222)
        Me.btnovolivro.Name = "btnovolivro"
        Me.btnovolivro.Size = New System.Drawing.Size(75, 23)
        Me.btnovolivro.TabIndex = 19
        Me.btnovolivro.Text = "Novo"
        Me.btnovolivro.UseVisualStyleBackColor = True
        '
        'btpesquisarlivro
        '
        Me.btpesquisarlivro.Location = New System.Drawing.Point(47, 6)
        Me.btpesquisarlivro.Name = "btpesquisarlivro"
        Me.btpesquisarlivro.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisarlivro.TabIndex = 18
        Me.btpesquisarlivro.Text = "Pesquisar"
        Me.btpesquisarlivro.UseVisualStyleBackColor = True
        '
        'txtmultadiaria
        '
        Me.txtmultadiaria.Location = New System.Drawing.Point(269, 178)
        Me.txtmultadiaria.Name = "txtmultadiaria"
        Me.txtmultadiaria.Size = New System.Drawing.Size(61, 20)
        Me.txtmultadiaria.TabIndex = 17
        '
        'txtestoque
        '
        Me.txtestoque.Location = New System.Drawing.Point(333, 144)
        Me.txtestoque.Name = "txtestoque"
        Me.txtestoque.Size = New System.Drawing.Size(100, 20)
        Me.txtestoque.TabIndex = 16
        '
        'txtprecocusto
        '
        Me.txtprecocusto.Location = New System.Drawing.Point(93, 144)
        Me.txtprecocusto.Name = "txtprecocusto"
        Me.txtprecocusto.Size = New System.Drawing.Size(100, 20)
        Me.txtprecocusto.TabIndex = 15
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(64, 109)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(214, 20)
        Me.txtcategoria.TabIndex = 14
        '
        'txteditora
        '
        Me.txteditora.Location = New System.Drawing.Point(47, 80)
        Me.txteditora.Name = "txteditora"
        Me.txteditora.Size = New System.Drawing.Size(231, 20)
        Me.txteditora.TabIndex = 13
        '
        'txtnomelivro
        '
        Me.txtnomelivro.Location = New System.Drawing.Point(47, 53)
        Me.txtnomelivro.Name = "txtnomelivro"
        Me.txtnomelivro.Size = New System.Drawing.Size(340, 20)
        Me.txtnomelivro.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "/ Por dia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(257, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Valor de multa a ser cobrada no atraso da devolução"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Data de Aquisição"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Data de lançamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Estoque"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Preço de Custo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Editora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtcod_solicitante)
        Me.TabPage2.Controls.Add(Me.txtcod_exemplar)
        Me.TabPage2.Controls.Add(Me.dtgemprestimo)
        Me.TabPage2.Controls.Add(Me.btcancelaremprestimo)
        Me.TabPage2.Controls.Add(Me.btsalvaremprestimos)
        Me.TabPage2.Controls.Add(Me.btnovoempréstimo)
        Me.TabPage2.Controls.Add(Me.btpesquisasolicitanteemprestimo)
        Me.TabPage2.Controls.Add(Me.btpesquisalivroemprestimo)
        Me.TabPage2.Controls.Add(Me.dtpprevisaoentrega)
        Me.TabPage2.Controls.Add(Me.dtpretirada)
        Me.TabPage2.Controls.Add(Me.txtsolicitante)
        Me.TabPage2.Controls.Add(Me.txtexemplar)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(504, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Empréstimo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtcod_solicitante
        '
        Me.txtcod_solicitante.Location = New System.Drawing.Point(79, 52)
        Me.txtcod_solicitante.Name = "txtcod_solicitante"
        Me.txtcod_solicitante.Size = New System.Drawing.Size(47, 20)
        Me.txtcod_solicitante.TabIndex = 34
        '
        'txtcod_exemplar
        '
        Me.txtcod_exemplar.Location = New System.Drawing.Point(79, 26)
        Me.txtcod_exemplar.Name = "txtcod_exemplar"
        Me.txtcod_exemplar.Size = New System.Drawing.Size(47, 20)
        Me.txtcod_exemplar.TabIndex = 0
        '
        'dtgemprestimo
        '
        Me.dtgemprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemprestimo.Location = New System.Drawing.Point(6, 153)
        Me.dtgemprestimo.Name = "dtgemprestimo"
        Me.dtgemprestimo.Size = New System.Drawing.Size(393, 110)
        Me.dtgemprestimo.TabIndex = 31
        '
        'btcancelaremprestimo
        '
        Me.btcancelaremprestimo.Location = New System.Drawing.Point(414, 211)
        Me.btcancelaremprestimo.Name = "btcancelaremprestimo"
        Me.btcancelaremprestimo.Size = New System.Drawing.Size(75, 23)
        Me.btcancelaremprestimo.TabIndex = 6
        Me.btcancelaremprestimo.Text = "Cancelar"
        Me.btcancelaremprestimo.UseVisualStyleBackColor = True
        '
        'btsalvaremprestimos
        '
        Me.btsalvaremprestimos.Location = New System.Drawing.Point(414, 182)
        Me.btsalvaremprestimos.Name = "btsalvaremprestimos"
        Me.btsalvaremprestimos.Size = New System.Drawing.Size(75, 23)
        Me.btsalvaremprestimos.TabIndex = 5
        Me.btsalvaremprestimos.Text = "Salvar"
        Me.btsalvaremprestimos.UseVisualStyleBackColor = True
        '
        'btnovoempréstimo
        '
        Me.btnovoempréstimo.Location = New System.Drawing.Point(414, 153)
        Me.btnovoempréstimo.Name = "btnovoempréstimo"
        Me.btnovoempréstimo.Size = New System.Drawing.Size(75, 23)
        Me.btnovoempréstimo.TabIndex = 4
        Me.btnovoempréstimo.Text = "Novo"
        Me.btnovoempréstimo.UseVisualStyleBackColor = True
        '
        'btpesquisasolicitanteemprestimo
        '
        Me.btpesquisasolicitanteemprestimo.Location = New System.Drawing.Point(414, 51)
        Me.btpesquisasolicitanteemprestimo.Name = "btpesquisasolicitanteemprestimo"
        Me.btpesquisasolicitanteemprestimo.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisasolicitanteemprestimo.TabIndex = 1
        Me.btpesquisasolicitanteemprestimo.Text = "Pesquisar"
        Me.btpesquisasolicitanteemprestimo.UseVisualStyleBackColor = True
        '
        'btpesquisalivroemprestimo
        '
        Me.btpesquisalivroemprestimo.Location = New System.Drawing.Point(414, 24)
        Me.btpesquisalivroemprestimo.Name = "btpesquisalivroemprestimo"
        Me.btpesquisalivroemprestimo.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisalivroemprestimo.TabIndex = 0
        Me.btpesquisalivroemprestimo.Text = "Pesquisar"
        Me.btpesquisalivroemprestimo.UseVisualStyleBackColor = True
        '
        'dtpprevisaoentrega
        '
        Me.dtpprevisaoentrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprevisaoentrega.Location = New System.Drawing.Point(168, 109)
        Me.dtpprevisaoentrega.Name = "dtpprevisaoentrega"
        Me.dtpprevisaoentrega.Size = New System.Drawing.Size(89, 20)
        Me.dtpprevisaoentrega.TabIndex = 3
        '
        'dtpretirada
        '
        Me.dtpretirada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpretirada.Location = New System.Drawing.Point(168, 82)
        Me.dtpretirada.Name = "dtpretirada"
        Me.dtpretirada.Size = New System.Drawing.Size(89, 20)
        Me.dtpretirada.TabIndex = 2
        '
        'txtsolicitante
        '
        Me.txtsolicitante.Location = New System.Drawing.Point(132, 53)
        Me.txtsolicitante.Name = "txtsolicitante"
        Me.txtsolicitante.Size = New System.Drawing.Size(233, 20)
        Me.txtsolicitante.TabIndex = 14
        '
        'txtexemplar
        '
        Me.txtexemplar.Location = New System.Drawing.Point(132, 26)
        Me.txtexemplar.Name = "txtexemplar"
        Me.txtexemplar.Size = New System.Drawing.Size(233, 20)
        Me.txtexemplar.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Data Prevista para entrega"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Data de retirada"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Solicitante"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Exemplar"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtlivroaserentregue)
        Me.TabPage1.Controls.Add(Me.txtcodemprestimo)
        Me.TabPage1.Controls.Add(Me.txtnomedequememprestou)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btcancelardevolucao)
        Me.TabPage1.Controls.Add(Me.btdevolver)
        Me.TabPage1.Controls.Add(Me.txttotaldemulta)
        Me.TabPage1.Controls.Add(Me.dtpdatarealdeentrega)
        Me.TabPage1.Controls.Add(Me.dtpretiradadevolucao)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(504, 269)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Devolução"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtlivroaserentregue
        '
        Me.txtlivroaserentregue.AutoSize = True
        Me.txtlivroaserentregue.Location = New System.Drawing.Point(139, 67)
        Me.txtlivroaserentregue.Name = "txtlivroaserentregue"
        Me.txtlivroaserentregue.Size = New System.Drawing.Size(0, 13)
        Me.txtlivroaserentregue.TabIndex = 18
        '
        'txtcodemprestimo
        '
        Me.txtcodemprestimo.AutoSize = True
        Me.txtcodemprestimo.Location = New System.Drawing.Point(136, 17)
        Me.txtcodemprestimo.Name = "txtcodemprestimo"
        Me.txtcodemprestimo.Size = New System.Drawing.Size(0, 13)
        Me.txtcodemprestimo.TabIndex = 17
        '
        'txtnomedequememprestou
        '
        Me.txtnomedequememprestou.AutoSize = True
        Me.txtnomedequememprestou.Location = New System.Drawing.Point(142, 42)
        Me.txtnomedequememprestou.Name = "txtnomedequememprestou"
        Me.txtnomedequememprestou.Size = New System.Drawing.Size(0, 13)
        Me.txtnomedequememprestou.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Exemplar a ser entregue"
        '
        'btcancelardevolucao
        '
        Me.btcancelardevolucao.Location = New System.Drawing.Point(405, 173)
        Me.btcancelardevolucao.Name = "btcancelardevolucao"
        Me.btcancelardevolucao.Size = New System.Drawing.Size(75, 23)
        Me.btcancelardevolucao.TabIndex = 13
        Me.btcancelardevolucao.Text = "Cancelar"
        Me.btcancelardevolucao.UseVisualStyleBackColor = True
        '
        'btdevolver
        '
        Me.btdevolver.Location = New System.Drawing.Point(405, 144)
        Me.btdevolver.Name = "btdevolver"
        Me.btdevolver.Size = New System.Drawing.Size(75, 23)
        Me.btdevolver.TabIndex = 12
        Me.btdevolver.Text = "Devolver"
        Me.btdevolver.UseVisualStyleBackColor = True
        '
        'txttotaldemulta
        '
        Me.txttotaldemulta.Location = New System.Drawing.Point(139, 128)
        Me.txttotaldemulta.Name = "txttotaldemulta"
        Me.txttotaldemulta.Size = New System.Drawing.Size(63, 20)
        Me.txttotaldemulta.TabIndex = 11
        '
        'dtpdatarealdeentrega
        '
        Me.dtpdatarealdeentrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatarealdeentrega.Location = New System.Drawing.Point(286, 101)
        Me.dtpdatarealdeentrega.Name = "dtpdatarealdeentrega"
        Me.dtpdatarealdeentrega.Size = New System.Drawing.Size(92, 20)
        Me.dtpdatarealdeentrega.TabIndex = 10
        '
        'dtpretiradadevolucao
        '
        Me.dtpretiradadevolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpretiradadevolucao.Location = New System.Drawing.Point(97, 102)
        Me.dtpretiradadevolucao.Name = "dtpretiradadevolucao"
        Me.dtpretiradadevolucao.Size = New System.Drawing.Size(92, 20)
        Me.dtpretiradadevolucao.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Valor da multa a ser paga"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(195, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Data de Entrega"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Data de Retirada"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Nome do Solicitante"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Empréstimo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Biblioteca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 328)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Biblioteca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca"
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgemprestimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Cadastro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btcancelarlivro As System.Windows.Forms.Button
    Friend WithEvents btexcluirlivro As System.Windows.Forms.Button
    Friend WithEvents btnovolivro As System.Windows.Forms.Button
    Friend WithEvents btpesquisarlivro As System.Windows.Forms.Button
    Friend WithEvents txtmultadiaria As System.Windows.Forms.TextBox
    Friend WithEvents txtestoque As System.Windows.Forms.TextBox
    Friend WithEvents txtprecocusto As System.Windows.Forms.TextBox
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents txteditora As System.Windows.Forms.TextBox
    Friend WithEvents txtnomelivro As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsolicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtexemplar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpaquisicao As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtplancamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btcancelaremprestimo As System.Windows.Forms.Button
    Friend WithEvents btsalvaremprestimos As System.Windows.Forms.Button
    Friend WithEvents btnovoempréstimo As System.Windows.Forms.Button
    Friend WithEvents btpesquisasolicitanteemprestimo As System.Windows.Forms.Button
    Friend WithEvents btpesquisalivroemprestimo As System.Windows.Forms.Button
    Friend WithEvents dtpprevisaoentrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpretirada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgemprestimo As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btcancelardevolucao As System.Windows.Forms.Button
    Friend WithEvents btdevolver As System.Windows.Forms.Button
    Friend WithEvents txttotaldemulta As System.Windows.Forms.TextBox
    Friend WithEvents dtpdatarealdeentrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpretiradadevolucao As System.Windows.Forms.DateTimePicker
    Friend WithEvents btsalvarlivro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodlivrocadastro As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_solicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_exemplar As System.Windows.Forms.TextBox
    Friend WithEvents txtnomedequememprestou As System.Windows.Forms.Label
    Friend WithEvents txtlivroaserentregue As System.Windows.Forms.Label
    Friend WithEvents txtcodemprestimo As System.Windows.Forms.Label
End Class
