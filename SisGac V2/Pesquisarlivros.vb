Public Class Pesquisarlivros
    Dim banco As New ClBanco

    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        pesquisaremprestimo()
    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglivrospesquisa.SelectionChanged
        AtualizaInf()
    End Sub
    Private Sub AtualizaInf()
        Try
            Biblioteca.txtcodlivrocadastro.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Cd_Livro").ToString()
            Biblioteca.txtnomelivro.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Titulo").ToString()
            Biblioteca.txteditora.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Editora").ToString()
            Biblioteca.txtcategoria.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Categoria").ToString()
            Biblioteca.dtplancamento.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Data_lancamento").ToString()
            Biblioteca.dtpaquisicao.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("Data_Aquisicao").ToString()
            Biblioteca.txtprecocusto.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("preco_custo").ToString()
            Biblioteca.txtestoque.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("estoque").ToString()
            Biblioteca.txtmultadiaria.Text = banco.Listagem.Tables(0).Rows(dtglivrospesquisa.CurrentRow.Index)("valor_multa").ToString()

            Biblioteca.btnovolivro.Enabled = False
            Biblioteca.txtnomelivro.Enabled = True
            Biblioteca.txtcategoria.Enabled = True
            Biblioteca.txteditora.Enabled = True
            Biblioteca.txtestoque.Enabled = True
            Biblioteca.txtmultadiaria.Enabled = True
            Biblioteca.txtprecocusto.Enabled = True
            Biblioteca.dtpaquisicao.Enabled = True
            Biblioteca.dtplancamento.Enabled = True
            Biblioteca.btsalvarlivro.Enabled = True
            Biblioteca.btcancelarlivro.Enabled = True
            Biblioteca.btexcluirlivro.Enabled = True

        Catch
        End Try

    End Sub
    Public Sub pesquisaremprestimo()
        Dim Sql As String
        Dim pesquisa As String = "Livros"
        Sql = "Select * from Cadas_Livros where Titulo like'%"
        Sql = Sql + txtpesquisalivros.Text + "%' order by Titulo "
        banco.Comandos(Sql, pesquisa)
        dtglivrospesquisa.DataSource = banco.Listagem.Tables(pesquisa)
    End Sub

End Class