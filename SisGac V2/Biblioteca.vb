Public Class Biblioteca
    Dim banco As New ClBanco

    Private Sub Biblioteca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodlivrocadastro.Enabled = False
        dtgemprestimo.Visible = False
        txtnomelivro.Enabled = False
        txtcategoria.Enabled = False
        txteditora.Enabled = False
        txtestoque.Enabled = False
        txtmultadiaria.Enabled = False
        txtprecocusto.Enabled = False
        txttotaldemulta.Enabled = False
        dtpaquisicao.Enabled = False
        dtpdatarealdeentrega.Enabled = False
        dtplancamento.Enabled = False
        dtpprevisaoentrega.Enabled = False
        dtpretirada.Enabled = False
        dtpretiradadevolucao.Enabled = False
        btsalvarlivro.Enabled = False
        btsalvaremprestimos.Enabled = False
        btdevolver.Enabled = False

        btexcluirlivro.Enabled = False
        btcancelardevolucao.Enabled = False
        btcancelaremprestimo.Enabled = False
        btcancelarlivro.Enabled = False



        txtexemplar.Enabled = False
        txtsolicitante.Enabled = False
        txtcod_exemplar.Enabled = False
        txtcod_solicitante.Enabled = False
        btpesquisalivroemprestimo.Enabled = False
        btpesquisasolicitanteemprestimo.Enabled = False


    End Sub
    Private Sub limpar()
        txtnomelivro.Enabled = False
        txtcategoria.Enabled = False
        txteditora.Enabled = False
        txtestoque.Enabled = False
        txtmultadiaria.Enabled = False
        txtprecocusto.Enabled = False
        txttotaldemulta.Enabled = False
        dtpaquisicao.Enabled = False
        dtpdatarealdeentrega.Enabled = False
        dtplancamento.Enabled = False
        dtpprevisaoentrega.Enabled = False
        dtpretirada.Enabled = False
        btpesquisasolicitanteemprestimo.Enabled = False
        btpesquisalivroemprestimo.Enabled = False
        dtpretiradadevolucao.Enabled = False
        btsalvarlivro.Enabled = False
        btsalvaremprestimos.Enabled = False
        btdevolver.Enabled = False
        btnovoempréstimo.Enabled = True
        btcancelaremprestimo.Enabled = True
        btexcluirlivro.Enabled = False
        btcancelardevolucao.Enabled = False
        btcancelaremprestimo.Enabled = False
        btcancelarlivro.Enabled = False
        txtnomedequememprestou.Enabled = False
        txtcodemprestimo.Enabled = False
        txtlivroaserentregue.Enabled = False
        txtexemplar.Enabled = False
        txtsolicitante.Enabled = False
        btnovolivro.Enabled = True
        txtcodlivrocadastro.Clear()
        txtnomelivro.Clear()
        txtcategoria.Clear()
        txteditora.Clear()
        txtestoque.Clear()
        txtmultadiaria.Clear()
        txtprecocusto.Clear()
        txttotaldemulta.Clear()
        txtnomedequememprestou.Text = ""
        txtcodemprestimo.Text = ""
        txtlivroaserentregue.Text = ""
        txtexemplar.Clear()
        txtsolicitante.Clear()
        txtcod_exemplar.Clear()
        txtcod_solicitante.Clear()


    End Sub

    

    Private Sub btnovolivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovolivro.Click
        btnovolivro.Enabled = False
        txtnomelivro.Enabled = True
        txtcategoria.Enabled = True
        txteditora.Enabled = True
        txtestoque.Enabled = True
        txtmultadiaria.Enabled = True
        txtprecocusto.Enabled = True
        dtpaquisicao.Enabled = True
        dtplancamento.Enabled = True
        btsalvarlivro.Enabled = True
        btcancelarlivro.Enabled = True

    End Sub

    Private Sub btsalvarlivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvarlivro.Click
        Dim t As String = "CadastrarLivros"
        Dim Sql As String
        Dim dia, mes, ano, data As String
        data = dtplancamento.Text
        dia = data.Substring(0, 2)
        mes = data.Substring(3, 2)
        ano = data.Substring(6, 4)
        data = mes + "." + dia + "." + ano

        Dim dia1, mes1, ano1, data1 As String
        data1 = dtpaquisicao.Text
        dia1 = data1.Substring(0, 2)
        mes1 = data1.Substring(3, 2)
        ano1 = data1.Substring(6, 4)
        data1 = mes1 + "." + dia1 + "." + ano1

        txtprecocusto.Text = Replace(txtprecocusto.Text, ",", ".")
        txtmultadiaria.Text = Replace(txtmultadiaria.Text, ",", ".")

        If (txtcodlivrocadastro.Text = "") Then
            Sql = "Insert into Cadas_Livros VALUES ("
            Sql = Sql + "'" + txtnomelivro.Text + "',"
            Sql = Sql + "'" + txteditora.Text + "',"
            Sql = Sql + "'" + txtcategoria.Text + "',"
            Sql = Sql + "'" + data + "',"
            Sql = Sql + "'" + data1 + "',"
            Sql = Sql + txtprecocusto.Text + ","
            Sql = Sql + txtestoque.Text + ","
            Sql = Sql + txtmultadiaria.Text + ")"
            banco.Comandos(Sql, t)
            MessageBox.Show("Cadastro realizado com Sucesso")
            limpar()
        Else
            Dim sql2 As String
            Dim u As String = "Update tabela"
            sql2 = "Update Cadas_Livros set "
            sql2 = sql2 + " Titulo=" + "'" + txtnomelivro.Text + "',"
            sql2 = sql2 + " Editora=" + "'" + txteditora.Text + "',"
            sql2 = sql2 + " Categoria=" + "'" + txtcategoria.Text + "',"
            sql2 = sql2 + " Data_lancamento=" + "'" + data + "',"
            sql2 = sql2 + " Data_aquisicao=" + "'" + data1 + "',"
            sql2 = sql2 + " preco_custo=" + txtprecocusto.Text + ","
            sql2 = sql2 + " estoque=" + txtestoque.Text + ","
            sql2 = sql2 + " valor_multa=" + txtmultadiaria.Text
            sql2 = sql2 + " WHERE Cd_Livro = " + txtcodlivrocadastro.Text
            banco.Comandos(sql2, u)
            MessageBox.Show("Alterações realizadas com Sucesso")
        End If
    End Sub

    Private Sub btpesquisarlivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisarlivro.Click
        Pesquisarlivros.ShowDialog()
    End Sub

    Private Sub btcancelarlivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelarlivro.Click
        limpar()
    End Sub

    Private Sub btexcluirlivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluirlivro.Click
        Dim sql As String
        Dim t As String = "Excluir Livro"
        sql = "DELETE FROM Cadas_Livros WHERE Cd_Livro =" + txtcodlivrocadastro.Text
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        limpar()
    End Sub

    Private Sub btpesquisalivroemprestimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisalivroemprestimo.Click
        pesquisarlivroemprestimo.ShowDialog()
    End Sub

    Private Sub btnovoempréstimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovoempréstimo.Click
        dtpprevisaoentrega.Enabled = True
        dtpretirada.Enabled = True
        btpesquisasolicitanteemprestimo.Enabled = True
        btpesquisalivroemprestimo.Enabled = True
        btsalvaremprestimos.Enabled = True
        btnovoempréstimo.Enabled = False
        btcancelaremprestimo.Enabled = True
        btpesquisalivroemprestimo.Enabled = True
        btpesquisasolicitanteemprestimo.Enabled = True


    End Sub

    Private Sub btcancelaremprestimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelaremprestimo.Click
        limpar()
    End Sub

    Private Sub btsalvaremprestimos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvaremprestimos.Click
        Dim t As String = "Cadastraremprestimos"
        Dim Sql As String
        Dim dia, mes, ano, data As String
        data = dtpretirada.Text
        dia = data.Substring(0, 2)
        mes = data.Substring(3, 2)
        ano = data.Substring(6, 4)
        data = mes + "." + dia + "." + ano

        Dim dia1, mes1, ano1, data1 As String
        data1 = dtpprevisaoentrega.Text
        dia1 = data1.Substring(0, 2)
        mes1 = data1.Substring(3, 2)
        ano1 = data1.Substring(6, 4)
        data1 = mes1 + "." + dia1 + "." + ano1

        If txtcod_exemplar.Text = "" Then
            MessageBox.Show("O Campo Exemplar deve ser preenchido com dados válidos")
        ElseIf txtcod_solicitante.Text = "" Then
            MessageBox.Show("O Campo Solicitante deve ser preenchido com dados válidos")
        Else

            Sql = "Insert into Cadas_Emprestimos VALUES ("
            Sql = Sql + txtcod_exemplar.Text + ","
            Sql = Sql + "'" + txtexemplar.Text + "',"
            Sql = Sql + txtcod_solicitante.Text + ","
            Sql = Sql + "'" + txtsolicitante.Text + "',"
            Sql = Sql + "'" + data + "',"
            Sql = Sql + "'" + data1 + "',"
            Sql = Sql + "'Emprestado', 0 )"
            banco.Comandos(Sql, t)
            MessageBox.Show("Cadastro realizado com Sucesso")
            dtgemprestimo.Visible = False
            limpar()
        End If

    End Sub

    Private Sub btpesquisasolicitanteemprestimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisasolicitanteemprestimo.Click
        pesquisarsolicitante.ShowDialog()
    End Sub

   
    Public Sub btpesquisasolicitanteemprestimo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisasolicitanteemprestimo.Leave
        Dim sql As String
        Dim solicitantelivros As String = "Solicitantelivros"
        dtgemprestimo.Visible = True
        sql = "Select Nome_Livro,Data_Retirada,Data_previsao,Status From Cadas_Emprestimos where Codigo_solicitante =" + txtcod_solicitante.Text + " and Nome_Solicitante = '" + txtsolicitante.Text + "'"
        banco.Comandos(sql, solicitantelivros)
        dtgemprestimo.DataSource = banco.Listagem.Tables(solicitantelivros)
        dtgemprestimo.Columns(1).Visible = False
        dtgemprestimo.Columns(2).Visible = False
        dtgemprestimo.Columns(0).HeaderText = "Livro Emprestado"
        dtgemprestimo.Columns(0).Width = 230
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pesquisar_Emprestimo_Devolução.ShowDialog()
    End Sub


    Private Sub btdevolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdevolver.Click
        

        Dim dia1, mes1, ano1, data1 As String
        data1 = dtpdatarealdeentrega.Text
        dia1 = data1.Substring(0, 2)
        mes1 = data1.Substring(3, 2)
        ano1 = data1.Substring(6, 4)
        data1 = mes1 + "." + dia1 + "." + ano1

        txttotaldemulta.Text = Replace(txttotaldemulta.Text, ",", ".")

        Dim sql2 As String
        Dim u As String = "Update tabela"
        sql2 = "Update Cadas_Emprestimos set "
        sql2 = sql2 + "Data_previsao ='" + data1 + "',"
        sql2 = sql2 + "Status = 'Devolvido' ,"
        sql2 = sql2 + " Multa = " + txttotaldemulta.Text
        sql2 = sql2 + " WHERE Cd_Emprestimo = " + txtcodemprestimo.Text
        banco.Comandos(sql2, u)
        MessageBox.Show("Devolução realizada com Sucesso")
        limpar()


    End Sub

    Private Sub btcancelardevolucao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelardevolucao.Click
        limpar()
    End Sub
End Class