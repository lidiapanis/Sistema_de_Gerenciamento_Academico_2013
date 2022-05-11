<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisarcurso
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
        Me.dtgcursoscadastrados = New System.Windows.Forms.DataGridView()
        Me.btpesquisarcurso = New System.Windows.Forms.Button()
        CType(Me.dtgcursoscadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgcursoscadastrados
        '
        Me.dtgcursoscadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcursoscadastrados.Location = New System.Drawing.Point(12, 70)
        Me.dtgcursoscadastrados.Name = "dtgcursoscadastrados"
        Me.dtgcursoscadastrados.Size = New System.Drawing.Size(357, 173)
        Me.dtgcursoscadastrados.TabIndex = 0
        '
        'btpesquisarcurso
        '
        Me.btpesquisarcurso.Location = New System.Drawing.Point(294, 12)
        Me.btpesquisarcurso.Name = "btpesquisarcurso"
        Me.btpesquisarcurso.Size = New System.Drawing.Size(75, 23)
        Me.btpesquisarcurso.TabIndex = 1
        Me.btpesquisarcurso.Text = "Pesquisar"
        Me.btpesquisarcurso.UseVisualStyleBackColor = True
        '
        'Pesquisarcurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 283)
        Me.Controls.Add(Me.btpesquisarcurso)
        Me.Controls.Add(Me.dtgcursoscadastrados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pesquisarcurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisar cursos"
        CType(Me.dtgcursoscadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgcursoscadastrados As System.Windows.Forms.DataGridView
    Friend WithEvents btpesquisarcurso As System.Windows.Forms.Button
End Class
