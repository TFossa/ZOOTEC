<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroEstado
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroEstado))
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.dgvEstado = New System.Windows.Forms.DataGridView()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtNomeEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlFundo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbMinimize = New System.Windows.Forms.PictureBox()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.pnlConteudo.SuspendLayout()
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFundo.SuspendLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Controls.Add(Me.dgvEstado)
        Me.pnlConteudo.Controls.Add(Me.btnAdicionar)
        Me.pnlConteudo.Controls.Add(Me.btnExcluir)
        Me.pnlConteudo.Controls.Add(Me.btnAlterar)
        Me.pnlConteudo.Controls.Add(Me.txtSigla)
        Me.pnlConteudo.Controls.Add(Me.txtNomeEstado)
        Me.pnlConteudo.Controls.Add(Me.Label4)
        Me.pnlConteudo.Controls.Add(Me.Label3)
        Me.pnlConteudo.Location = New System.Drawing.Point(1, 20)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(348, 270)
        Me.pnlConteudo.TabIndex = 4
        '
        'dgvEstado
        '
        Me.dgvEstado.AllowUserToAddRows = False
        Me.dgvEstado.AllowUserToDeleteRows = False
        Me.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstado.Location = New System.Drawing.Point(2, 72)
        Me.dgvEstado.Name = "dgvEstado"
        Me.dgvEstado.ReadOnly = True
        Me.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstado.Size = New System.Drawing.Size(343, 195)
        Me.dgvEstado.TabIndex = 9
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(221, 43)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 8
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(140, 43)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(59, 43)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'txtSigla
        '
        Me.txtSigla.Location = New System.Drawing.Point(267, 17)
        Me.txtSigla.MaxLength = 2
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(60, 20)
        Me.txtSigla.TabIndex = 5
        '
        'txtNomeEstado
        '
        Me.txtNomeEstado.Location = New System.Drawing.Point(14, 17)
        Me.txtNomeEstado.Name = "txtNomeEstado"
        Me.txtNomeEstado.Size = New System.Drawing.Size(246, 20)
        Me.txtNomeEstado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sigla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome Estado"
        '
        'pnlFundo
        '
        Me.pnlFundo.Controls.Add(Me.Label1)
        Me.pnlFundo.Controls.Add(Me.pcbMinimize)
        Me.pnlFundo.Controls.Add(Me.pcbExit)
        Me.pnlFundo.Controls.Add(Me.pnlConteudo)
        Me.pnlFundo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFundo.Name = "pnlFundo"
        Me.pnlFundo.Size = New System.Drawing.Size(350, 300)
        Me.pnlFundo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cadastro de Estado"
        '
        'pcbMinimize
        '
        Me.pcbMinimize.Image = CType(resources.GetObject("pcbMinimize.Image"), System.Drawing.Image)
        Me.pcbMinimize.Location = New System.Drawing.Point(311, 2)
        Me.pcbMinimize.Name = "pcbMinimize"
        Me.pcbMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMinimize.TabIndex = 6
        Me.pcbMinimize.TabStop = False
        '
        'pcbExit
        '
        Me.pcbExit.Image = CType(resources.GetObject("pcbExit.Image"), System.Drawing.Image)
        Me.pcbExit.Location = New System.Drawing.Point(332, 2)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(15, 15)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 5
        Me.pcbExit.TabStop = False
        '
        'frmCadastroEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 300)
        Me.Controls.Add(Me.pnlFundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastroEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastroEstado"
        Me.pnlConteudo.ResumeLayout(False)
        Me.pnlConteudo.PerformLayout()
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFundo.ResumeLayout(False)
        Me.pnlFundo.PerformLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents pnlFundo As Panel
    Friend WithEvents pcbMinimize As PictureBox
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents txtNomeEstado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEstado As DataGridView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
End Class
