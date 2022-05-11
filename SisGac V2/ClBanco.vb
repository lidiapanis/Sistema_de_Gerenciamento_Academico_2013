Imports System.Data.OleDb
Public Class ClBanco

    Public comando As New OleDbDataAdapter
    'Cria um Objeto do tipo OleDbAdapter para
    'executar o comando Sql
    Public Listagem As New DataSet
    'Cria um objeto do tipo DataSet para
    'armazenar os dados da consulta Sql


    Private Function strconexao() As String
        'Dim strconexao As String = "Provider=SQLOLEDB;Data Source=MODELO\MSSQLSERVER1;Integrated Security=SSPI;Initial Catalog=DbVenda;"
        Return "server=LIDIA-PC\SQLEXPRESS;Provider=SQLOLEDB.1;database=Sisgacv2;Trusted_Connection=Yes"
    End Function
    'É o comando responsável pelo acesso ao banco de dados onde é
    'descrito o servidor, o objeto que ele usa (as classes), 
    'a base de dados e o tipo de conexão
    'Lembrar do site Connection Strings


    Private Function oleCon() As OleDbConnection
        Return New OleDbConnection(strconexao)
    End Function
    'RESPONSÁVEL POR INSTACIAR A CONEXAO COM O BANCO DE DADOS
    'NO OBJETO OLE


    Public Sub Comandos(ByVal sql As String, ByVal tabela As String)
        Try

            Try
                Listagem.Tables.Clear()

            Catch ex As Exception

            End Try

            comando = New OleDbDataAdapter(New OleDbCommand(sql, oleCon))
            'Carrego uma nova instância de OleDbAdapter
            'Dentro do OleDbAdapter carrego a instrução
            'e em qual conexão vou executar este comando

            comando.Fill(Listagem, tabela)
            'Na classe OleDbAdapter é executado o método Fill(execute) 
            'O qual retorna os dados no DataSet "Listagem"
        Catch ex As Exception
            MessageBox.Show("Erro ao realizar consulta, verifique a instrução SQL")
            MessageBox.Show("ou se há conexão com o servidor")
        End Try

    End Sub

    'EXECUTA UM COMANDO SQL OU PARA PARA O METODO CONSULTA UM DETERMINADO
    'COMANDO OU RETORNA ERRO EM CASO DE SERVIDOR NAO ENCONTRADO


End Class



