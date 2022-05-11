Public Class Inicio

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcadastroalunos.Click
        Alunos.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcadastroprofessores.Click
        Professores.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcadastrofuncionarios.Click
        Funcionarios.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbiblioteca.Click
        Biblioteca.ShowDialog()
    End Sub


    Private Sub btcadascursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcadascursos.Click
        Cursos.ShowDialog()
    End Sub

    Private Sub btnotafalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnotafalta.Click
        If Login.cbtipoconexao.SelectedIndex = 2 Then
            Notas_Faltas_Lançamento.ShowDialog()
        Else
            Notas_Faltas_Consulta_aluno.ShowDialog()
        End If
    End Sub
End Class