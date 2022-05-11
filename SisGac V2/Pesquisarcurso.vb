Public Class Pesquisarcurso
    Dim banco As New ClBanco

    Private Sub btpesquisarcurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisarcurso.Click
        Dim sql As String = "SELECT * FROM Cadas_Cursos ORDER BY Nome"
        Dim t As String = "pesquisacurso"
        banco.Comandos(sql, t)
        dtgcursoscadastrados.DataSource = banco.Listagem.Tables(t)
    End Sub
    Private Sub dtgDados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgcursoscadastrados.SelectionChanged
        AtualizaInf()
        Cursos.txtnomecurso.Enabled = True
        Cursos.nupqtdsemestres.Enabled = True
        Cursos.btnovo.Enabled = True
        Cursos.btsalvarcurso.Enabled = True
        Cursos.btexcluircurso.Enabled = True
        Cursos.btcancelarcurso.Enabled = True
    End Sub
    Private Sub AtualizaInf()
        Cursos.cd_curso.Text = banco.Listagem.Tables(0).Rows(dtgcursoscadastrados.CurrentRow.Index)("Cd_Curso").ToString()
        Cursos.txtnomecurso.Text = banco.Listagem.Tables(0).Rows(dtgcursoscadastrados.CurrentRow.Index)("Nome").ToString()
        Cursos.nupqtdsemestres.Value = banco.Listagem.Tables(0).Rows(dtgcursoscadastrados.CurrentRow.Index)("Qtd_Semestres").ToString()
        
    End Sub

   
End Class