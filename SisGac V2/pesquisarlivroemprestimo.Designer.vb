<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisarlivroemprestimo
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
        Me.txtpesquisalivroemprestimo = New System.Windows.Forms.TextBox()
        Me.dtglivrosemprestimopesquisa = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dtglivrosemprestimopesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btprocurar)
        Me.Panel1.Controls.Add(Me.txtpesquisalivroemprestimo)
        Me.Panel1.Controls.Add(Me.dtglivrosemprestimopesquisa)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 271)
        Me.Panel1.TabIndex = 7
        '
        'btprocurar
        '
        Me.btprocurar.Location = New System.Drawing.Point(267, 23)
        Me.btprocurar.Name = "btprocurar"
        Me.btprocurar.Size = New System.Drawing.Size(75, 23)
        Me.btprocurar.TabIndex = 1
        Me.btprocurar.Text = "Procurar"
        Me.btprocurar.UseVisualStyleBackColor = True
        '
        'txtpesquisalivroemprestimo
        '
        Me.txtpesquisalivroemprestimo.Location = New System.Drawing.Point(30, 25)
        Me.txtpesquisalivroemprestimo.Name = "txtpesquisalivroemprestimo"
        Me.txtpesquisalivroemprestimo.Size = New System.Drawing.Size(231, 20)
        Me.txtpesquisalivroemprestimo.TabIndex = 3
        '
        'dtglivrosemprestimopesquisa
        '
        Me.dtglivrosemprestimopesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglivrosemprestimopesquisa.Location = New System.Drawing.Point(10, 71)
        Me.dtglivrosemprestimopesquisa.Name = "dtglivrosemprestimopesquisa"
        Me.dtglivrosemprestimopesquisa.Size = New System.Drawing.Size(381, 188)
        Me.dtglivrosemprestimopesquisa.TabIndex = 0
        '
        'pesquisarlivroemprestimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 288)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pesquisarlivroemprestimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisar Livros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtglivrosemprestimopesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btprocurar As System.Windows.Forms.Button
    Friend WithEvents txtpesquisalivroemprestimo As System.Windows.Forms.TextBox
    Friend WithEvents dtglivrosemprestimopesquisa As System.Windows.Forms.DataGridView
End Class
