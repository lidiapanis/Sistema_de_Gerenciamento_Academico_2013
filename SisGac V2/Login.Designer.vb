<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.Senha = New System.Windows.Forms.Label()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.cbtipoconexao = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(87, 23)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(100, 20)
        Me.txtlogin.TabIndex = 0
        '
        'Senha
        '
        Me.Senha.AutoSize = True
        Me.Senha.Location = New System.Drawing.Point(42, 52)
        Me.Senha.Name = "Senha"
        Me.Senha.Size = New System.Drawing.Size(38, 13)
        Me.Senha.TabIndex = 2
        Me.Senha.Text = "Senha"
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(171, 115)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(96, 23)
        Me.btlogin.TabIndex = 3
        Me.btlogin.Text = "Entrar"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(87, 49)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(100, 20)
        Me.txtsenha.TabIndex = 1
        '
        'cbtipoconexao
        '
        Me.cbtipoconexao.FormattingEnabled = True
        Me.cbtipoconexao.Items.AddRange(New Object() {"Aluno", "Funcionário", "Professor"})
        Me.cbtipoconexao.Location = New System.Drawing.Point(87, 75)
        Me.cbtipoconexao.Name = "cbtipoconexao"
        Me.cbtipoconexao.Size = New System.Drawing.Size(100, 21)
        Me.cbtipoconexao.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 179)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbtipoconexao)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.Senha)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bem vindo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents Senha As System.Windows.Forms.Label
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents cbtipoconexao As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
