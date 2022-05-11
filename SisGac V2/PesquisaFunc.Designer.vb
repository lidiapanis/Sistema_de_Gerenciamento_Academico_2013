<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaFunc
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btprocurar = New System.Windows.Forms.Button()
        Me.txtpesquisa = New System.Windows.Forms.TextBox()
        Me.dtgfunc = New System.Windows.Forms.DataGridView()
        Me.cbpesquisa = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgfunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btprocurar)
        Me.Panel1.Controls.Add(Me.txtpesquisa)
        Me.Panel1.Controls.Add(Me.dtgfunc)
        Me.Panel1.Controls.Add(Me.cbpesquisa)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 271)
        Me.Panel1.TabIndex = 6
        '
        'btprocurar
        '
        Me.btprocurar.Location = New System.Drawing.Point(289, 42)
        Me.btprocurar.Name = "btprocurar"
        Me.btprocurar.Size = New System.Drawing.Size(75, 23)
        Me.btprocurar.TabIndex = 1
        Me.btprocurar.Text = "Procurar"
        Me.btprocurar.UseVisualStyleBackColor = True
        '
        'txtpesquisa
        '
        Me.txtpesquisa.Location = New System.Drawing.Point(40, 44)
        Me.txtpesquisa.Name = "txtpesquisa"
        Me.txtpesquisa.Size = New System.Drawing.Size(231, 20)
        Me.txtpesquisa.TabIndex = 3
        '
        'dtgfunc
        '
        Me.dtgfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgfunc.Location = New System.Drawing.Point(10, 71)
        Me.dtgfunc.Name = "dtgfunc"
        Me.dtgfunc.Size = New System.Drawing.Size(381, 188)
        Me.dtgfunc.TabIndex = 0
        '
        'cbpesquisa
        '
        Me.cbpesquisa.FormattingEnabled = True
        Me.cbpesquisa.Items.AddRange(New Object() {"Nome", "CPF"})
        Me.cbpesquisa.Location = New System.Drawing.Point(64, 17)
        Me.cbpesquisa.Name = "cbpesquisa"
        Me.cbpesquisa.Size = New System.Drawing.Size(188, 21)
        Me.cbpesquisa.TabIndex = 2
        '
        'PesquisaFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 288)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PesquisaFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa Funcionário"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgfunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btprocurar As System.Windows.Forms.Button
    Friend WithEvents txtpesquisa As System.Windows.Forms.TextBox
    Friend WithEvents dtgfunc As System.Windows.Forms.DataGridView
    Friend WithEvents cbpesquisa As System.Windows.Forms.ComboBox
End Class
