Public Class Funcionarios
    Dim banco As New ClBanco


    Public Sub carregaImagemfunc()
        If txtcaminhofotofunc.Text <> "" Then
            pbfotofunc.Image = Nothing
            pbfotofunc.Load(txtcaminhofotofunc.Text)
            pbfotofunc.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pbfotofunc.Image = Nothing
        End If

    End Sub
    Private Sub btbuscarfotofunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btfoto.Click
        OpenFileDialogfunc.ShowDialog()
        txtcaminhofotofunc.Text = OpenFileDialogfunc.FileName.ToString()
        carregaImagemfunc()
    End Sub

    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click
        Dim sql As String
        Dim dia, mes, ano, data As String
        data = dtpnascimento.Text
        dia = data.Substring(0, 2)
        mes = data.Substring(3, 2)
        ano = data.Substring(6, 4)
        data = mes + "." + dia + "." + ano

        Dim CadasFunc As String = "Cadas_Func"

        If (txtcodigofunc.Text = "") Then
            sql = "Insert into Cadas_Func VALUES ("
            sql = sql + txtcpffunc.Text + ","
            sql = sql + "'" + data + "',"
            sql = sql + "'" + txtnomefunc.Text + "',"
            sql = sql + "'" + txtenderecofunc.Text + "',"
            sql = sql + "'" + txtbairrofunc.Text + "',"
            sql = sql + "'" + txtcidadefunc.Text + "',"
            sql = sql + "'" + CStr(cbestado.Text) + "',"
            sql = sql + "'" + txttelefonefunc.Text + "',"
            sql = sql + "'" + txtemailfunc.Text + "',"
            sql = sql + "'" + txtfuncao.Text + "',"
            sql = sql + "'" + txtcaminhofotofunc.Text + "',"
            sql = sql + "'" + txtsenha.Text + "')"
            banco.Comandos(sql, CadasFunc)
            MessageBox.Show("Cadastro realizado com Sucesso")
            Limpar()
        Else
            Dim sql2 As String
            Dim u As String = "Update tabela"
            sql2 = "Update Cadas_Func set "
            sql2 = sql2 + " CPF=" + txtcpffunc.Text + ","
            sql2 = sql2 + " Data_Nas=" + "'" + data + "',"
            sql2 = sql2 + " Nome=" + "'" + txtnomefunc.Text + "',"
            sql2 = sql2 + " Endereco=" + "'" + txtenderecofunc.Text + "',"
            sql2 = sql2 + " Bairro=" + "'" + txtbairrofunc.Text + "',"
            sql2 = sql2 + " Cidade=" + "'" + txtcidadefunc.Text + "',"
            sql2 = sql2 + " Estado=" + "'" + CStr(cbestado.Text) + "',"
            sql2 = sql2 + " Telefone=" + "'" + txttelefonefunc.Text + "',"
            sql2 = sql2 + " Email=" + "'" + txtemailfunc.Text + "',"
            sql2 = sql2 + " Funcao=" + "'" + txtfuncao.Text + "',"
            sql2 = sql2 + " Caminho=" + "'" + txtcaminhofotofunc.Text + "',"
            sql2 = sql2 + " Senha=" + "'" + txtsenha.Text + "'"
            sql2 = sql2 + " WHERE Cd_Func = " + txtcodigofunc.Text
            banco.Comandos(sql2, u)
            MessageBox.Show("Alterações realizadas com Sucesso")
        End If

    End Sub
    Private Sub Limpar()
        txtcpffunc.Clear()
        txtbairrofunc.Clear()
        txtcidadefunc.Clear()
        txtemailfunc.Clear()
        txtenderecofunc.Clear()
        txttelefonefunc.Clear()
        txtnomefunc.Clear()
        cbestado.SelectedIndex = 0
        txtfuncao.Clear()
        txtcaminhofotofunc.Clear()
        pbfotofunc.Image = Nothing
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtsenha.Clear()
        txtcodigofunc.Clear()
        txtcpffunc.Enabled = False
        txtbairrofunc.Enabled = False
        txtcidadefunc.Enabled = False
        txtemailfunc.Enabled = False
        txtenderecofunc.Enabled = False
        txttelefonefunc.Enabled = False
        txtnomefunc.Enabled = False
        cbestado.Enabled = False
        txtfuncao.Enabled = False
        txtcaminhofotofunc.Enabled = False
        pbfotofunc.Image = Nothing
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtsenha.Enabled = False
        txtcodigofunc.Enabled = False
        txtcaminhofotofunc.Visible = False

    End Sub

    Private Sub btpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisar.Click
        PesquisaFunc.ShowDialog()
    End Sub

    Private Sub Funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcpffunc.Enabled = False
        txtbairrofunc.Enabled = False
        txtcidadefunc.Enabled = False
        txtemailfunc.Enabled = False
        txtenderecofunc.Enabled = False
        txttelefonefunc.Enabled = False
        txtnomefunc.Enabled = False
        cbestado.Enabled = False
        txtfuncao.Enabled = False
        txtcaminhofotofunc.Enabled = False
        pbfotofunc.Image = Nothing
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtsenha.Enabled = False
        txtcodigofunc.Enabled = False
        txtcaminhofotofunc.Visible = False

    End Sub

    Private Sub btnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovo.Click
        txtcpffunc.Enabled = True
        txtbairrofunc.Enabled = True
        txtcidadefunc.Enabled = True
        txtemailfunc.Enabled = True
        txtenderecofunc.Enabled = True
        txttelefonefunc.Enabled = True
        txtnomefunc.Enabled = True
        cbestado.Enabled = True
        txtfuncao.Enabled = True
        txtcaminhofotofunc.Enabled = True
        btnovo.Enabled = True
        btsalvar.Enabled = True
        btfoto.Enabled = True
        btexcluir.Enabled = True
        btcancelar.Enabled = True
        txtsenha.Enabled = True
    End Sub

    Private Sub btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelar.Click
        Limpar()
    End Sub

    
    Private Sub btexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluir.Click
        Dim sql As String
        Dim t As String = "Excluir Func"
        sql = "DELETE FROM Cadas_Func WHERE Cd_Func =" + txtcodigofunc.Text
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        Limpar()
    End Sub
End Class