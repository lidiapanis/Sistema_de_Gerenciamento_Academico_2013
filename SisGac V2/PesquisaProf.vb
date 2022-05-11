Public Class PesquisaProf
    Dim banco As New ClBanco

    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click
        Dim sql As String = ""
        Dim pesquisa As String = "Pesquisar"
        If cbpesquisa.SelectedIndex = 0 Then
            sql = "Select * from Cadas_Prof where Nome like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgprof.DataSource = banco.Listagem.Tables(pesquisa)
        ElseIf cbpesquisa.SelectedIndex = 1 Then
            sql = "Select * from Cadas_Prof where CPF like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgprof.DataSource = banco.Listagem.Tables(pesquisa)
        Else
            sql = "SELECT * FROM Cadas_Prof ORDER BY Nome"
            banco.Comandos(sql, pesquisa)
            dtgprof.DataSource = banco.Listagem.Tables(pesquisa)

        End If



    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgprof.SelectionChanged
        AtualizaInf()
    End Sub

    Private Sub AtualizaInf()
        Try
            Professores.txtcodigoprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Cd_Prof").ToString()
            Professores.txtcpfprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("CPF").ToString()
            Professores.dtpnascimento.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Data_Nasc").ToString()
            Professores.txtnomeprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Nome").ToString()
            Professores.txtenderecoprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Endereco").ToString()
            Professores.txtbairroprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Bairro").ToString()
            Professores.txtcidadeprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Cidade").ToString()
            Professores.cbestado.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Estado").ToString()
            Professores.txttelefoneprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Telefone").ToString()
            Professores.txtemailprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Email").ToString()
            Professores.txtformacaoprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Formacao").ToString()
            Professores.txtcaminhofotoprof.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Caminho").ToString()
            Professores.txtsenha.Text = banco.Listagem.Tables(0).Rows(dtgprof.CurrentRow.Index)("Senha").ToString()
            Professores.carregaImagemprof()
            Professores.btsalvar.Enabled = True
            Professores.btfoto.Enabled = True
            Professores.btcancelar.Enabled = True
            Professores.btexcluir.Enabled = True
            Professores.txtcpfprof.Enabled = True
            Professores.txtbairroprof.Enabled = True
            Professores.txtcidadeprof.Enabled = True
            Professores.txtemailprof.Enabled = True
            Professores.dtpnascimento.Enabled = True
            Professores.txtenderecoprof.Enabled = True
            Professores.txttelefoneprof.Enabled = True
            Professores.txtnomeprof.Enabled = True
            Professores.txtformacaoprof.Enabled = True
            Professores.cbestado.Enabled = True
            Professores.btnovo.Enabled = False
            Professores.txtsenha.Enabled = True
            dtgprof.Columns(0).Visible = False
            dtgprof.Columns(2).Visible = False
            

           
        Catch ex As Exception

        End Try
    End Sub
End Class