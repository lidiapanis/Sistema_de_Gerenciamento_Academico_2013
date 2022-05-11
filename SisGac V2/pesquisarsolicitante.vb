Public Class pesquisarsolicitante
    Dim banco As New ClBanco

    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        Dim Sql As String
        Dim pesquisa As String = "Solicitante"
        Sql = "(SELECT Cd_Aluno, NOME FROM Cadas_Aluno Where Nome Like '%" + txtpesquisasolicitante.Text + "%') UNION (SELECT Cd_Prof, NOME FROM Cadas_Prof Where Nome like '%" + txtpesquisasolicitante.Text + "%') UNION (SELECT Cd_Func ,NOME FROM Cadas_Func Where Nome like '%" + txtpesquisasolicitante.Text + "%')"
        banco.Comandos(Sql, pesquisa)
        dtgsolicitante.DataSource = banco.Listagem.Tables(pesquisa)

    End Sub
    Private Sub dtglivrosemprestimopesquisa_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgsolicitante.SelectionChanged
        AtualizaInform()
    End Sub
    Public Sub AtualizaInform()
        Try
            Biblioteca.txtcod_solicitante.Text = banco.Listagem.Tables(0).Rows(dtgsolicitante.CurrentRow.Index).Item("Cd_Aluno").ToString()
            Biblioteca.txtsolicitante.Text = banco.Listagem.Tables(0).Rows(dtgsolicitante.CurrentRow.Index)("NOME").ToString()
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