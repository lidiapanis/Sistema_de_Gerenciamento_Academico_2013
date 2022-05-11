Public Class Pesquisar
    Dim banco As New ClBanco
    Public Codigo As String


    Private Sub btprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprocurar.Click

        Dim sql As String = ""
        Dim pesquisa As String = "Pesquisar"

        If cbpesquisa.SelectedIndex = 0 Then
            sql = "Select * from Cadas_Aluno where Nome like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgalunos.DataSource = banco.Listagem.Tables(pesquisa)
        ElseIf cbpesquisa.SelectedIndex = 1 Then
            sql = "Select * from Cadas_Aluno where CPF like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgalunos.DataSource = banco.Listagem.Tables(pesquisa)
        ElseIf cbpesquisa.SelectedIndex = 2 Then
            sql = "Select * from Cadas_Aluno where Matricula like'%"
            sql = sql + txtpesquisa.Text + "%' "
            banco.Comandos(sql, pesquisa)
            dtgalunos.DataSource = banco.Listagem.Tables(pesquisa)
        Else
            sql = "SELECT * FROM Cadas_Aluno ORDER BY Nome"
            banco.Comandos(sql, pesquisa)
            dtgalunos.DataSource = banco.Listagem.Tables(pesquisa)

        End If

        
        
    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgalunos.SelectionChanged
        AtualizaInf()
    End Sub
    
    Private Sub AtualizaInf()
        Try
            Alunos.txtcodigoaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Cd_Aluno").ToString()
            Alunos.txtcpfaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("CPF").ToString()
            Alunos.dtpnascimento.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Data_Nasc").ToString()
            Alunos.txtnomealuno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Nome").ToString()
            Alunos.txtenderecoaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Endereco").ToString()
            Alunos.txtbairroaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Bairro").ToString()
            Alunos.txtcidadealuno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Cidade").ToString()
            Alunos.cbestado.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Estado").ToString()
            Alunos.txttelefonealuno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Telefone").ToString()
            Alunos.txtemailaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Email").ToString()
            Alunos.txtmatriculaaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Matricula").ToString()
            Alunos.cbcurso.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Curso").ToString()
            Alunos.txtcaminhofotoaluno.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Caminho").ToString()
            Alunos.txtsenha1.Text = banco.Listagem.Tables(0).Rows(dtgalunos.CurrentRow.Index)("Senha").ToString()
            Alunos.carregaImagemaluno()
            Alunos.btsalvar.Enabled = True
            Alunos.btfoto.Enabled = True
            Alunos.btcancelar.Enabled = True
            Alunos.btexcluir.Enabled = True
            Alunos.txtcpfaluno.Enabled = True
            Alunos.txtbairroaluno.Enabled = True
            Alunos.txtcidadealuno.Enabled = True
            Alunos.txtemailaluno.Enabled = True
            Alunos.dtpnascimento.Enabled = True
            Alunos.txtenderecoaluno.Enabled = True
            Alunos.txttelefonealuno.Enabled = True
            Alunos.txtnomealuno.Enabled = True
            Alunos.cbcurso.Enabled = True
            Alunos.cbestado.Enabled = True
            Alunos.txtmatriculaaluno.Enabled = True
            Alunos.btnovo.Enabled = False
            Alunos.txtsenha1.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    
End Class