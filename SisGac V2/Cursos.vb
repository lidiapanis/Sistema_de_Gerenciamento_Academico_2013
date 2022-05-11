Public Class Cursos
    Dim banco As New ClBanco


    Private Sub btsalvarcurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvarcurso.Click
        Dim Sql As String

        If cd_curso.Text = "" Then
            Dim t As String = "Cursos"
            Sql = "Insert into Cadas_Cursos VALUES ("
            Sql = Sql + "'" + txtnomecurso.Text + "',"
            Sql = Sql + nupqtdsemestres.Text + ")"
            banco.Comandos(Sql, t)

        Else
            Dim u As String = "Update tabela"
            Sql = "Update Cadas_Cursos set "
            Sql = Sql + " Nome=" + "'" + txtnomecurso.Text + "',"
            Sql = Sql + " Qtd_Semestres=" + nupqtdsemestres.Text
            Sql = Sql + " WHERE Cd_Curso = " + cd_curso.Text
            banco.Comandos(Sql, u)
        End If
        MessageBox.Show("Cadastro realizado com Sucesso")
        Limpar()
    End Sub

    Private Sub Limpar()
        txtnomecurso.Clear()
        nupqtdsemestres.Value = 0
        btnovo.Enabled = True
        txtnomecurso.Enabled = False
        nupqtdsemestres.Enabled = False
        btsalvarcurso.Enabled = False
        btcancelarcurso.Enabled = False
        btexcluircurso.Enabled = False
        cd_curso.Text = ""
    End Sub

    Private Sub btnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovo.Click
        txtnomecurso.Enabled = True
        nupqtdsemestres.Enabled = True
        btsalvarcurso.Enabled = True
        btcancelarcurso.Enabled = True
        btexcluircurso.Enabled = True
        btnovo.Enabled = False
    End Sub

    Private Sub Cursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnomecurso.Enabled = False
        nupqtdsemestres.Enabled = False
        btsalvarcurso.Enabled = False
        btcancelarcurso.Enabled = False
        btexcluircurso.Enabled = False
        cd_curso.Text = Visible = False
    End Sub

    Private Sub btpesquisarcurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisarcurso.Click
        Pesquisarcurso.Show()
    End Sub

    Private Sub btexcluircurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluircurso.Click
        Dim sql As String
        Dim t As String = "Excluir curso"
        sql = "DELETE FROM Cadas_Cursos WHERE Cd_curso =" + cd_curso.Text
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        Limpar()
    End Sub
End Class