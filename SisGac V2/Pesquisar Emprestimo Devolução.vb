Public Class Pesquisar_Emprestimo_Devolução

    Dim banco As New ClBanco
    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        Dim sql As String = ""
        Dim pesquisa As String = "Pesquisar"

        If cbpesquisa.SelectedIndex = 0 Then
            sql = "Select * from Cadas_Emprestimos where Nome_Livro like '%"
            sql = sql + txtpesquisa.Text + "%' and Status ='Emprestado'"
            banco.Comandos(sql, pesquisa)
            dtgemprestimos.DataSource = banco.Listagem.Tables(pesquisa)
        ElseIf cbpesquisa.SelectedIndex = 1 Then
            sql = "Select * from Cadas_Emprestimos where Nome_solicitante like'%"
            sql = sql + txtpesquisa.Text + "%' and Status ='Emprestado'"
            banco.Comandos(sql, pesquisa)
            dtgemprestimos.DataSource = banco.Listagem.Tables(pesquisa)
        Else
            sql = "SELECT * FROM Cadas_Emprestimos where Status ='Emprestado' ORDER BY Nome_Livro"
            banco.Comandos(sql, pesquisa)
            dtgemprestimos.DataSource = banco.Listagem.Tables(pesquisa)

        End If



    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgemprestimos.SelectionChanged
        AtualizaInf()
    End Sub

    Private Sub AtualizaInf()
        Try

            Biblioteca.txtcodemprestimo.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Cd_Emprestimo").ToString()
            Biblioteca.txtnomedequememprestou.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Nome_Solicitante").ToString()
            Biblioteca.txtlivroaserentregue.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Nome_Livro").ToString()
            Biblioteca.dtpretiradadevolucao.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Data_retirada").ToString()
            Biblioteca.dtpdatarealdeentrega.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Data_previsao").ToString()
            Biblioteca.txttotaldemulta.Text = banco.Listagem.Tables(0).Rows(dtgemprestimos.CurrentRow.Index)("Multa").ToString()
            Biblioteca.dtpdatarealdeentrega.Enabled = True
            Biblioteca.txttotaldemulta.Enabled = True
            Biblioteca.btdevolver.Enabled = True
            Biblioteca.btcancelardevolucao.Enabled = True
            dtgemprestimos.Columns(1).Visible = False
            dtgemprestimos.Columns(0).Visible = False
            dtgemprestimos.Columns(3).Visible = False
            dtgemprestimos.Columns(2).HeaderText = " Exemplar Emprestado"
            dtgemprestimos.Columns(4).HeaderText = " Nome Solicitante"
            dtgemprestimos.Columns(5).HeaderText = " Data retirada"
            dtgemprestimos.Columns(6).HeaderText = " Data devolução"

        Catch
        End Try

    End Sub
End Class