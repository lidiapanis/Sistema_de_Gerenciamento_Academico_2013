Public Class Login
    Dim banco As New ClBanco

    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        Dim pesquisa As String = "Pesquisa Login"
        Dim login As String
        Dim senha As String

        If txtlogin.Text = "Administrador" And txtsenha.Text = "Administrador" Then
            Inicio.btnotafalta.Enabled = False
            Inicio.ShowDialog()
        Else
            If cbtipoconexao.SelectedIndex = 0 Then
                login = "Select CPF , Senha From Cadas_Aluno where CPF ='"
                login = login + txtlogin.Text + "'"
                banco.Comandos(login, pesquisa)
                If banco.Listagem.Tables(0).Rows.Count > 0 Then
                    login = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
                    senha = banco.Listagem.Tables(0).Rows(0).Item("Senha").ToString()
                    If (login = txtlogin.Text) And (senha = txtsenha.Text) Then
                        Notas_Faltas_Consulta_aluno.Show()
                        Inicio.btcadastroalunos.Enabled = False
                        Inicio.btcadastrofuncionarios.Enabled = False
                        Inicio.btcadastroprofessores.Enabled = False
                        Inicio.btbiblioteca.Enabled = False
                        Inicio.btcadascursos.Enabled = False
                    Else
                        MessageBox.Show("Login ou senha incorretos")
                        txtlogin.Clear()
                        txtsenha.Clear()
                    End If
                Else
                    MessageBox.Show("Login ou senha incorretos")
                    txtlogin.Clear()
                    txtsenha.Clear()
                End If

            ElseIf cbtipoconexao.SelectedIndex = 1 Then
                login = "Select CPF , Senha From Cadas_Func where CPF ='"
                login = login + txtlogin.Text + "'"
                banco.Comandos(login, pesquisa)
                If banco.Listagem.Tables(0).Rows.Count > 0 Then
                    login = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
                    senha = banco.Listagem.Tables(0).Rows(0).Item("Senha").ToString()

                    If (login = txtlogin.Text) And (senha = txtsenha.Text) Then
                        Inicio.btbiblioteca.Enabled = True
                        Inicio.btcadastroalunos.Enabled = True
                        Inicio.btcadastrofuncionarios.Enabled = True
                        Inicio.btcadastroprofessores.Enabled = True
                        Inicio.btcadascursos.Enabled = True
                        Inicio.btnotafalta.Enabled = False
                        Inicio.ShowDialog()
                    Else
                        MessageBox.Show("Login ou senha incorretos")
                        txtlogin.Clear()
                        txtsenha.Clear()
                    End If
                Else
                    MessageBox.Show("Login ou senha incorretos")
                    txtlogin.Clear()
                    txtsenha.Clear()
                End If

            ElseIf cbtipoconexao.SelectedIndex = 2 Then
                login = "Select CPF , Senha From Cadas_Prof where CPF ='"
                login = login + txtlogin.Text + "'"
                banco.Comandos(login, pesquisa)

                If banco.Listagem.Tables(0).Rows.Count > 0 Then
                    login = banco.Listagem.Tables(0).Rows(0).Item("CPF").ToString()
                    senha = banco.Listagem.Tables(0).Rows(0).Item("Senha").ToString()

                    If (login = txtlogin.Text) And (senha = txtsenha.Text) Then
                        Inicio.btbiblioteca.Enabled = False
                        Inicio.ShowDialog()
                    Else
                        MessageBox.Show("Login ou senha incorretos")
                        txtlogin.Clear()
                        txtsenha.Clear()
                    End If


                Else
                    MessageBox.Show("Login ou senha incorretos")
                    txtlogin.Clear()
                    txtsenha.Clear()
                End If
            End If
        End If



    End Sub
End Class
