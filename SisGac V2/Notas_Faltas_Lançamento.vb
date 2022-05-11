Public Class Notas_Faltas_Lançamento
    Dim banco As New ClBanco
    Dim cd_prof, cd_lanc As String

    Private Sub txtra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtra.Leave
        Dim sql As String
        Dim aa As String = "Pesquisa"
        sql = "Select Cd_Aluno, Nome, CPF , Matricula ,Curso From Cadas_Aluno a Where Matricula = " + txtra.Text

        If txtra.Text = "" Then

        Else
            banco.Comandos(sql, aa)
            If banco.Listagem.Tables(0).Rows.Count > 0 Then
                Try
                    cd_aluno.Text = banco.Listagem.Tables(0).Rows(0).Item("Cd_Aluno").ToString()
                    txtnome.Text = banco.Listagem.Tables(0).Rows(0).Item("Nome").ToString()
                    txtcpf.Text = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
                    txtra.Text = banco.Listagem.Tables(0).Rows(0).Item("Matricula").ToString()
                    curso.Text = banco.Listagem.Tables(0).Rows(0).Item("Curso").ToString()
                    txtnome.ForeColor = Color.Blue
                    curso.ForeColor = Color.Blue
                    prof()
                Catch
                End Try
            Else
                MessageBox.Show("Aluno não encontrado, Verifique sua matricula ou pesquise pelo CPF ")
            End If
        End If
    End Sub

    Private Sub txtcpf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcpf.Leave
        Dim sql As String
        Dim bb As String = "Pesquisa"
        sql = "Select Cd_Aluno, Nome, CPF , Matricula , Curso  From Cadas_Aluno Where CPF = " + txtcpf.Text

        If txtcpf.Text = "" Then
            Exit Sub
        Else
            banco.Comandos(sql, bb)
            If banco.Listagem.Tables(0).Rows.Count > 0 Then
                Try
                    cd_aluno.Text = banco.Listagem.Tables(0).Rows(0).Item("Cd_Aluno").ToString()
                    txtnome.Text = banco.Listagem.Tables(0).Rows(0).Item("Nome").ToString()
                    txtcpf.Text = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
                    txtra.Text = banco.Listagem.Tables(0).Rows(0).Item("Matricula").ToString()
                    curso.Text = banco.Listagem.Tables(0).Rows(0).Item("Curso").ToString()
                    txtnome.ForeColor = Color.Blue
                    curso.ForeColor = Color.Blue

                    prof()

                Catch
                End Try
            Else
                MessageBox.Show("Aluno não encontrado, Verifique seu CPF ou pesquise pela sua matricula")
            End If
        End If
    End Sub


    Private Sub btlancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlancar.Click
        Dim sql As String


        txtmedia.Text = Replace(txtmedia.Text, ",", ".")
        If cd_lanc = "" Then
            Dim dd As String = "Insert"
            sql = "Insert into Lancamento_Notas VALUES ("
            sql = sql + cd_aluno.Text + ","
            sql = sql + cd_prof + ","
            sql = sql + "'" + txtnome.Text + "',"
            sql = sql + "'" + txtnomeprof.Text + "',"
            sql = sql + "'" + txtmateria.Text + "',"
            sql = sql + "'" + curso.Text + "',"
            sql = sql + txtsemestre.Text + ","
            sql = sql + txtmedia.Text + ","
            sql = sql + txtfalta.Text + ")"
            banco.Comandos(sql, dd)
        Else
            Dim u As String = "Update tabela"
            sql = "Update Lancamento_Notas set "
            sql = sql + " Materia=" + "'" + txtmateria.Text + "',"
            sql = sql + " Semestre=" + txtsemestre.Text + ","
            sql = sql + " Media_Final=" + txtmedia.Text + ","
            sql = sql + " Faltas=" + txtfalta.Text
            sql = sql + " WHERE Cd_Lancamento = " + cd_lanc
            banco.Comandos(sql, u)
        End If
        MessageBox.Show("Notas lançadas com sucesso")
        limpar()
    End Sub

    Private Sub prof()
        Dim sql2 As String
        Dim pesquisaprof As String = "pesquisaprof"
        txtcpfprof.Text = Login.txtlogin.Text
        txtcpfprof.ForeColor = Color.Blue

        sql2 = "Select Cd_Prof , Nome From Cadas_Prof where CPF = " + txtcpfprof.Text
        banco.Comandos(sql2, pesquisaprof)
        cd_prof = banco.Listagem.Tables(pesquisaprof).Rows(0).Item("Cd_Prof").ToString()
        nomeprofessor.Text = banco.Listagem.Tables(pesquisaprof).Rows(0).Item("Nome").ToString()
                nomeprofessor.ForeColor = Color.Blue
    End Sub
    



    Private Sub btnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovo.Click
        btcancelar.Enabled = True
        txtsemestre.Enabled = True
        txtmedia.Enabled = True
        txtmateria.Enabled = True
        txtfalta.Enabled = True
        btexcluir.Enabled = True
        btlancar.Enabled = True
        bteditar.Enabled = False

    End Sub


    Private Sub Notas_Faltas_Lançamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtsemestre.Enabled = False
        txtmedia.Enabled = False
        txtmateria.Enabled = False
        txtfalta.Enabled = False
        btexcluir.Enabled = False
        btlancar.Enabled = False
        btcancelar.Enabled = False
    End Sub
    Private Sub limpar()
        btnovo.Enabled = True
        bteditar.Enabled = True
        txtsemestre.Enabled = False
        txtsemestre.Clear()
        txtmedia.Enabled = False
        txtmedia.Clear()
        txtmateria.Enabled = False
        txtmateria.Clear()
        txtfalta.Enabled = False
        txtfalta.Clear()
        nomecurso.Text = ""
        txtnome.Text = ""
        curso.Text = ""
        cd_aluno.Text = ""
        txtra.Clear()
        txtcpf.Clear()
        btexcluir.Enabled = False
        btlancar.Enabled = False
        btcancelar.Enabled = False
        cd_lanc = ""


    End Sub


    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If cd_aluno.Text = "" Then

        Else
            Dim tt As String = "pesqaluno"
            Dim sql As String = "Select Cd_Lancamento , Materia, Semestre ,  Media_Final , Faltas  From Lancamento_Notas where Cd_Aluno = " + cd_aluno.Text
                banco.Comandos(sql, tt)
                dtgnotas.DataSource = banco.Listagem.Tables(tt)
            btnovo.Enabled = False
            btexcluir.Enabled = True
            btcancelar.Enabled = True
            bteditar.Enabled = False
            btlancar.Enabled = True
            txtmateria.Enabled = True
            txtmedia.Enabled = True
            txtsemestre.Enabled = True
            txtmedia.Enabled = True
            txtfalta.Enabled = True
        End If
    End Sub
    Private Sub AtualizaInf()

        Try
            cd_lanc = banco.Listagem.Tables(0).Rows(dtgnotas.CurrentRow.Index)("Cd_Lancamento").ToString()
            txtmateria.Text = banco.Listagem.Tables(0).Rows(dtgnotas.CurrentRow.Index)("Materia").ToString()
            txtsemestre.Text = banco.Listagem.Tables(0).Rows(dtgnotas.CurrentRow.Index)("Semestre").ToString()
            txtmedia.Text = banco.Listagem.Tables(0).Rows(dtgnotas.CurrentRow.Index)("Media_Final").ToString()
            txtfalta.Text = banco.Listagem.Tables(0).Rows(dtgnotas.CurrentRow.Index)("Faltas").ToString()
            dtgnotas.Columns(0).Visible = False
            dtgnotas.Columns(3).HeaderText = "Média Final"
            dtgnotas.Columns(1).Width = 110
            dtgnotas.Columns(2).Width = 50
            dtgnotas.Columns(3).Width = 50
            dtgnotas.Columns(4).Width = 50
        Catch
        End Try
    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgnotas.SelectionChanged
        AtualizaInf()
    End Sub
   
    Private Sub btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelar.Click
        limpar()
    End Sub

    Private Sub btexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluir.Click
        Dim sql As String
        Dim t As String = "Excluir notas"
        sql = "DELETE FROM Lancamento_Notas WHERE Cd_Lancamento =" + cd_lanc
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        limpar()
    End Sub
End Class
