Public Class Alunos
    Dim banco As New ClBanco



    Private Sub Alunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btcancelar.Enabled = False
        btexcluir.Enabled = False
        txtcaminhofotoaluno.Visible = False
        txtcpfaluno.Enabled = False
        txtbairroaluno.Enabled = False
        txtcidadealuno.Enabled = False
        txtemailaluno.Enabled = False
        dtpnascimento.Enabled = False
        txtenderecoaluno.Enabled = False
        txttelefonealuno.Enabled = False
        txtnomealuno.Enabled = False
        cbcurso.Enabled = False
        cbestado.Enabled = False
        txtmatriculaaluno.Enabled = False
        txtcodigoaluno.Enabled = False
        txtsenha1.Enabled = False
        CarregaCombo()



    End Sub

    Private Sub btnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovo.Click
        btsalvar.Enabled = True
        btfoto.Enabled = True
        btcancelar.Enabled = True
        btexcluir.Enabled = True
        txtcpfaluno.Enabled = True
        txtbairroaluno.Enabled = True
        txtcidadealuno.Enabled = True
        txtemailaluno.Enabled = True
        dtpnascimento.Enabled = True
        txtenderecoaluno.Enabled = True
        txttelefonealuno.Enabled = True
        txtnomealuno.Enabled = True
        cbcurso.Enabled = True
        cbestado.Enabled = True
        txtmatriculaaluno.Enabled = True
        btnovo.Enabled = False
        txtsenha1.Enabled = True
        txtcodigoaluno.Clear()
    End Sub

    Public Sub carregaImagemaluno()
        If txtcaminhofotoaluno.Text <> "" Then
            pbfotoaluno.Image = Nothing
            pbfotoaluno.Load(txtcaminhofotoaluno.Text)
            pbfotoaluno.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pbfotoaluno.Image = Nothing
        End If

    End Sub
    Private Sub btbuscarfotoaluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btfoto.Click
        OpenFileDialogaluno.ShowDialog()
        txtcaminhofotoaluno.Text = OpenFileDialogaluno.FileName.ToString()
        carregaImagemaluno()
    End Sub

    Private Sub CarregaCombo()
        Dim t As String
        t = "ComboCli"
        Dim sql As String = "SELECT Cd_Curso, Nome FROM Cadas_Cursos order by Nome"
        'Seleciona o campo que será exibido e o código
        banco.Comandos(sql, t)
        cbcurso.DataSource = banco.Listagem.Tables(t)
        cbcurso.DisplayMember = "Nome"
        'Diz ao combo que o campo nome do cliente será exibido
        cbcurso.ValueMember = "Cd_Curso"
        'Diz ao combo que a referência do cliente será o codigo
    End Sub

  
    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click
        Dim sql As String
        Dim dia, mes, ano, data As String
        data = dtpnascimento.Text
        dia = data.Substring(0, 2)
        mes = data.Substring(3, 2)
        ano = data.Substring(6, 4)
        data = mes + "." + dia + "." + ano


        Dim t As String = "tbaluno"

        If (txtcodigoaluno.Text = "") Then
            sql = "Insert into Cadas_Aluno VALUES ("
            sql = sql + txtcpfaluno.Text + ","
            sql = sql + "'" + data + "',"
            sql = sql + "'" + txtnomealuno.Text + "',"
            sql = sql + "'" + txtenderecoaluno.Text + "',"
            sql = sql + "'" + txtbairroaluno.Text + "',"
            sql = sql + "'" + txtcidadealuno.Text + "',"
            sql = sql + "'" + CStr(cbestado.Text) + "',"
            sql = sql + "'" + txttelefonealuno.Text + "',"
            sql = sql + "'" + txtemailaluno.Text + "',"
            sql = sql + txtmatriculaaluno.Text + ","
            sql = sql + "'" + CStr(cbcurso.Text) + "',"
            sql = sql + "'" + txtcaminhofotoaluno.Text + "',"
            sql = sql + "'" + txtsenha1.Text + "')"
            banco.Comandos(sql, t)
            MessageBox.Show("Cadastro realizado com Sucesso")
            Limpar()
        Else
            Dim sql2 As String
            Dim u As String = "Update tabela"
            sql2 = "Update Cadas_Aluno set "
            sql2 = sql2 + " CPF=" + txtcpfaluno.Text + ","
            sql2 = sql2 + " Data_Nasc=" + "'" + data + "',"
            sql2 = sql2 + " Nome=" + "'" + txtnomealuno.Text + "',"
            sql2 = sql2 + " Endereco=" + "'" + txtenderecoaluno.Text + "',"
            sql2 = sql2 + " Bairro=" + "'" + txtbairroaluno.Text + "',"
            sql2 = sql2 + " Cidade=" + "'" + txtcidadealuno.Text + "',"
            sql2 = sql2 + " Estado=" + "'" + CStr(cbestado.Text) + "',"
            sql2 = sql2 + " Telefone=" + "'" + txttelefonealuno.Text + "',"
            sql2 = sql2 + " Email=" + "'" + txtemailaluno.Text + "',"
            sql2 = sql2 + " Matricula=" + txtmatriculaaluno.Text + ","
            sql2 = sql2 + " Curso=" + "'" + CStr(cbcurso.Text) + "',"
            sql2 = sql2 + " Caminho=" + "'" + txtcaminhofotoaluno.Text + "',"
            sql2 = sql2 + " Senha=" + "'" + txtsenha1.Text + "'"
            sql2 = sql2 + " WHERE Cd_Aluno = " + txtcodigoaluno.Text
            banco.Comandos(sql2, u)
            MessageBox.Show("Alterações realizadas com Sucesso")
        End If


    End Sub

    
    Private Sub btpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisar.Click
        Pesquisar.ShowDialog()
    End Sub
    

    
    Private Sub txtcpfaluno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcpfaluno.Leave
        ' Dim sql, cpf As String
        'Dim t As String = "Pesquisar CPF"
        'sql = "Select CPF From Cadas_Aluno where CPF = " + txtcpfaluno.Text
        'banco.Comandos(sql, t)
        'If banco.Listagem.Tables(0).Rows.Count > 0 Then
        '    MessageBox.Show("CPF já cadastrado")
        'Limpar()
        'E'nd If

    End Sub

    Private Sub Limpar()
        txtcodigoaluno.Clear()
        txtcpfaluno.Clear()
        txtbairroaluno.Clear()
        txtcidadealuno.Clear()
        txtemailaluno.Clear()
        txtenderecoaluno.Clear()
        txttelefonealuno.Clear()
        txtnomealuno.Clear()
        cbcurso.SelectedIndex = 0
        cbestado.SelectedIndex = 0
        txtmatriculaaluno.Clear()
        txtcaminhofotoaluno.Clear()
        pbfotoaluno.Image = Nothing
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtcaminhofotoaluno.Visible = False
        txtcpfaluno.Enabled = False
        txtbairroaluno.Enabled = False
        txtcidadealuno.Enabled = False
        txtemailaluno.Enabled = False
        dtpnascimento.Enabled = False
        txtenderecoaluno.Enabled = False
        txttelefonealuno.Enabled = False
        txtnomealuno.Enabled = False
        cbcurso.Enabled = False
        cbestado.Enabled = False
        txtmatriculaaluno.Enabled = False
        txtsenha1.Enabled = False
        txtsenha1.Clear()

    End Sub
    Private Sub btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelar.Click
        Limpar()
    End Sub

    Private Sub btexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluir.Click
        Dim sql As String
        Dim t As String = "Excluir Aluno"
        sql = "DELETE FROM Cadas_Aluno WHERE Cd_Aluno =" + txtcodigoaluno.Text
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        Limpar()
    End Sub

    
End Class