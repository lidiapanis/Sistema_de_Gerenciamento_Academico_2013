Public Class Notas_Faltas_Consulta_aluno
    Dim banco As New ClBanco

    Private Sub Notas_Faltas_Consulta_aluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim notas, aluno, cdaluno As String
        Dim visualizanotas As String = "visualizanotas"
        Dim visualizanotasaluno As String = "visualizanotasaluno"
        Try
            aluno = "Select Cd_Aluno ,CPF ,Nome, Curso , Matricula  From Cadas_Aluno where CPF = " + Login.txtlogin.Text
            banco.Comandos(aluno, visualizanotas)
            cdaluno = banco.Listagem.Tables(0).Rows(0).Item("Cd_Aluno").ToString()
            CPF.Text = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
            nomedoaluno.Text = banco.Listagem.Tables(0).Rows(0).Item("Nome").ToString()
            Curso.Text = banco.Listagem.Tables(0).Rows(0).Item("Curso").ToString()
            matricula.Text = banco.Listagem.Tables(0).Rows(0).Item("Matricula").ToString()
            CPF.ForeColor = Color.Blue
            nomedoaluno.ForeColor = Color.Blue
            Curso.ForeColor = Color.Blue
            matricula.ForeColor = Color.Blue

            notas = "Select Nome_Prof , Materia , Semestre , Media_Final, Faltas From Lancamento_Notas where Cd_Aluno = " + cdaluno
            banco.Comandos(notas, visualizanotasaluno)
            dtgvisualizacao.DataSource = banco.Listagem.Tables(visualizanotasaluno)
            dtgvisualizacao.Columns(3).HeaderText = "Média Final"
            dtgvisualizacao.Columns(0).Width = 110
            dtgvisualizacao.Columns(1).Width = 110
            dtgvisualizacao.Columns(2).Width = 55
            dtgvisualizacao.Columns(3).Width = 50
            dtgvisualizacao.Columns(4).Width = 40
        Catch
        End Try
    End Sub

   
End Class