Public Class PesquisaFunc
    Dim banco As New ClBanco

    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        Dim sql As String = ""
        Dim pesquisa As String = "Pesquisar"
        If cbpesquisa.SelectedIndex = 0 Then
            sql = "Select * from Cadas_Func where Nome like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgfunc.DataSource = banco.Listagem.Tables(pesquisa)
        ElseIf cbpesquisa.SelectedIndex = 1 Then
            sql = "Select * from Cadas_Func where CPF like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgfunc.DataSource = banco.Listagem.Tables(pesquisa)
        Else
            sql = "SELECT * FROM Cadas_Func ORDER BY Nome"
            banco.Comandos(sql, pesquisa)
            dtgfunc.DataSource = banco.Listagem.Tables(pesquisa)

        End If



    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgfunc.SelectionChanged
        AtualizaInf()
    End Sub

    Private Sub AtualizaInf()
        Try
            Funcionarios.txtcodigofunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Cd_Func").ToString()
            Funcionarios.txtcpffunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("CPF").ToString()
            Funcionarios.dtpnascimento.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Data_Nas").ToString()
            Funcionarios.txtnomefunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Nome").ToString()
            Funcionarios.txtenderecofunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Endereco").ToString()
            Funcionarios.txtbairrofunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Bairro").ToString()
            Funcionarios.txtcidadefunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Cidade").ToString()
            Funcionarios.cbestado.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Estado").ToString()
            Funcionarios.txttelefonefunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Telefone").ToString()
            Funcionarios.txtemailfunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Email").ToString()
            Funcionarios.txtfuncao.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Funcao").ToString()
            Funcionarios.txtcaminhofotofunc.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Caminho").ToString()
            Funcionarios.txtsenha.Text = banco.Listagem.Tables(0).Rows(dtgfunc.CurrentRow.Index)("Senha").ToString()
            Funcionarios.carregaImagemfunc()
            Funcionarios.btsalvar.Enabled = True
            Funcionarios.btfoto.Enabled = True
            Funcionarios.btcancelar.Enabled = True
            Funcionarios.btexcluir.Enabled = True
            Funcionarios.txtcpffunc.Enabled = True
            Funcionarios.txtbairrofunc.Enabled = True
            Funcionarios.txtcidadefunc.Enabled = True
            Funcionarios.txtemailfunc.Enabled = True
            Funcionarios.dtpnascimento.Enabled = True
            Funcionarios.txtenderecofunc.Enabled = True
            Funcionarios.txttelefonefunc.Enabled = True
            Funcionarios.txtnomefunc.Enabled = True
            Funcionarios.txtfuncao.Enabled = True
            Funcionarios.cbestado.Enabled = True
            Funcionarios.btnovo.Enabled = False
            Funcionarios.txtsenha.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class