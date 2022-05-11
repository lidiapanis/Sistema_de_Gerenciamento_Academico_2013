Public Class pesquisarlivroemprestimo
    Dim banco As New ClBanco

    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        Dim Sql As String
        Dim pesquisa As String = "Livros"
        Sql = "Select Cd_Livro , Titulo from Cadas_Livros where Titulo like '%"
        Sql = Sql + txtpesquisalivroemprestimo.Text + "%' "
        banco.Comandos(Sql, pesquisa)
        dtglivrosemprestimopesquisa.DataSource = banco.Listagem.Tables(pesquisa)

    End Sub
    Private Sub dtglivrosemprestimopesquisa_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglivrosemprestimopesquisa.SelectionChanged
        AtualizaInform()
    End Sub
    Public Sub AtualizaInform()
        Try
            Biblioteca.txtcod_exemplar.Text = banco.Listagem.Tables(0).Rows(dtglivrosemprestimopesquisa.CurrentRow.Index).Item("Cd_Livro").ToString()
            Biblioteca.txtexemplar.Text = banco.Listagem.Tables(0).Rows(dtglivrosemprestimopesquisa.CurrentRow.Index)("Titulo").ToString()
            Biblioteca.txtsolicitante.Enabled = False
            Biblioteca.txtexemplar.Enabled = False
            Biblioteca.dtpprevisaoentrega.Enabled = True
            Biblioteca.dtpretirada.Enabled = True
            Biblioteca.btpesquisasolicitanteemprestimo.Enabled = True
            Biblioteca.btpesquisalivroemprestimo.Enabled = True
            Biblioteca.btsalvaremprestimos.Enabled = True
            Biblioteca.btnovoempréstimo.Enabled = False
            Biblioteca.btcancelaremprestimo.Enabled = True
        Catch
        End Try

    End Sub


End Class