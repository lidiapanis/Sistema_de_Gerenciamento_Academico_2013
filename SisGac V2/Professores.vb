Public Class Professores
    Dim banco As ClBanco = New ClBanco()


    Private Sub btfoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btfoto.Click
        OpenFileDialogprof.ShowDialog()
        txtcaminhofotoprof.Text = OpenFileDialogprof.FileName.ToString()
        carregaImagemprof()
    End Sub
    Public Sub carregaImagemprof()
        If txtcaminhofotoprof.Text <> "" Then
            pbfotoprof.Image = Nothing
            pbfotoprof.Load(txtcaminhofotoprof.Text)
            pbfotoprof.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pbfotoprof.Image = Nothing
        End If

    End Sub

    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click
        Dim sql As String
        Dim t As String
        t = "Cadas_Prof"
        Dim dia, mes, ano, data As String
        data = dtpnascimento.Text
        dia = data.Substring(0, 2)
        mes = data.Substring(3, 2)
        ano = data.Substring(6, 4)
        data = mes + "." + dia + "." + ano

        If (txtcodigoprof.Text = "") Then
            sql = "Insert into Cadas_Prof VALUES ("
            sql = sql + txtcpfprof.Text + ","
            sql = sql + "'" + data + "',"
            sql = sql + "'" + txtnomeprof.Text + "',"
            sql = sql + "'" + txtenderecoprof.Text + "',"
            sql = sql + "'" + txtbairroprof.Text + "',"
            sql = sql + "'" + txtcidadeprof.Text + "',"
            sql = sql + "'" + CStr(cbestado.SelectedValue) + "',"
            sql = sql + "'" + txttelefoneprof.Text + "',"
            sql = sql + "'" + txtemailprof.Text + "',"
            sql = sql + "'" + txtformacaoprof.Text + "',"
            sql = sql + "'" + txtcaminhofotoprof.Text + "',"
            sql = sql + "'" + txtsenha.Text + "')"
            banco.Comandos(sql, t)
            MessageBox.Show("Cadastro realizado com Sucesso")
            Limpar()
        Else
            Dim sql2 As String
            Dim u As String = "Update tabela"
            sql2 = "Update Cadas_Prof set "
            sql2 = sql2 + " CPF=" + txtcpfprof.Text + ","
            sql2 = sql2 + " Data_Nasc=" + "'" + data + "',"
            sql2 = sql2 + " Nome=" + "'" + txtnomeprof.Text + "',"
            sql2 = sql2 + " Endereco=" + "'" + txtenderecoprof.Text + "',"
            sql2 = sql2 + " Bairro=" + "'" + txtbairroprof.Text + "',"
            sql2 = sql2 + " Cidade=" + "'" + txtcidadeprof.Text + "',"
            sql2 = sql2 + " Estado=" + "'" + CStr(cbestado.Text) + "',"
            sql2 = sql2 + " Telefone=" + "'" + txttelefoneprof.Text + "',"
            sql2 = sql2 + " Email=" + "'" + txtemailprof.Text + "',"
            sql2 = sql2 + " Formacao=" + "'" + txtformacaoprof.Text + "',"
            sql2 = sql2 + " Caminho=" + "'" + txtcaminhofotoprof.Text + "',"
            sql2 = sql2 + " Senha=" + "'" + txtsenha.Text + "'"
            sql2 = sql2 + " WHERE Cd_Prof = " + txtcodigoprof.Text
            banco.Comandos(sql2, u)
            MessageBox.Show("Alterações realizadas com Sucesso")
        End If

    End Sub
    Private Sub Limpar()
        txtcpfprof.Clear()
        txtnomeprof.Clear()
        txtenderecoprof.Clear()
        txtbairroprof.Clear()
        txtcidadeprof.Clear()
        cbestado.SelectedIndex = 0
        txttelefoneprof.Clear()
        txtemailprof.Clear()
        txtformacaoprof.Clear()
        txtcaminhofotoprof.Clear()
        txtcpfprof.Enabled = False
        txtnomeprof.Enabled = False
        txtenderecoprof.Enabled = False
        txtbairroprof.Enabled = False
        txtcidadeprof.Enabled = False
        cbestado.Enabled = False
        txttelefoneprof.Enabled = False
        txtemailprof.Enabled = False
        txtformacaoprof.Enabled = False
        txtcaminhofotoprof.Enabled = False
        pbfotoprof = Nothing
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtsenha.Clear()
        txtsenha.Enabled = False
        txtcodigoprof.Clear()
    End Sub

    Private Sub btnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnovo.Click
        txtcpfprof.Enabled = True
        txtnomeprof.Enabled = True
        txtenderecoprof.Enabled = True
        txtbairroprof.Enabled = True
        txtcidadeprof.Enabled = True
        cbestado.Enabled = True
        txttelefoneprof.Enabled = True
        txtemailprof.Enabled = True
        txtformacaoprof.Enabled = True
        txtcaminhofotoprof.Enabled = True
        btnovo.Enabled = False
        btsalvar.Enabled = True
        btfoto.Enabled = True
        btexcluir.Enabled = True
        btcancelar.Enabled = True
        txtsenha.Enabled = True

    End Sub

    Private Sub Professores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcpfprof.Enabled = False
        txtnomeprof.Enabled = False
        txtenderecoprof.Enabled = False
        txtbairroprof.Enabled = False
        txtcidadeprof.Enabled = False
        cbestado.Enabled = False
        txttelefoneprof.Enabled = False
        txtemailprof.Enabled = False
        txtformacaoprof.Enabled = False
        txtcaminhofotoprof.Enabled = False
        btnovo.Enabled = True
        btsalvar.Enabled = False
        btfoto.Enabled = False
        btexcluir.Enabled = False
        btcancelar.Enabled = False
        txtcodigoprof.Enabled = False
        txtsenha.Enabled = False
        txtcaminhofotoprof.Visible = False
    End Sub

    Private Sub btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelar.Click
        Limpar()
    End Sub

    Private Sub btpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpesquisar.Click
        PesquisaProf.Show()
    End Sub

    Private Sub btexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexcluir.Click
        Dim sql As String
        Dim t As String = "Excluir prof"
        sql = "DELETE FROM Cadas_Prof WHERE Cd_Prof =" + txtcodigoprof.Text
        banco.Comandos(sql, t)
        MessageBox.Show("Exclusão Feita com Sucesso")
        Limpar()
    End Sub
End Class