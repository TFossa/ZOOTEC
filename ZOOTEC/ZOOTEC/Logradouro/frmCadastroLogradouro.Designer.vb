<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroLogradouro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroLogradouro))
        Me.pnlFundo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbMinimize = New System.Windows.Forms.PictureBox()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.btnAdicionarCidade = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.dgvLogradouro = New System.Windows.Forms.DataGridView()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.cbbCidade = New System.Windows.Forms.ComboBox()
        Me.CidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZOOTECDataSet = New ZOOTEC.ZOOTECDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.EstadoTableAdapter()
        Me.CidadeTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.CidadeTableAdapter()
        Me.pnlFundo.SuspendLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConteudo.SuspendLayout()
        CType(Me.dgvLogradouro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFundo
        '
        Me.pnlFundo.Controls.Add(Me.Label1)
        Me.pnlFundo.Controls.Add(Me.pcbMinimize)
        Me.pnlFundo.Controls.Add(Me.pcbExit)
        Me.pnlFundo.Controls.Add(Me.pnlConteudo)
        Me.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFundo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFundo.Name = "pnlFundo"
        Me.pnlFundo.Size = New System.Drawing.Size(400, 300)
        Me.pnlFundo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Logradouro"
        '
        'pcbMinimize
        '
        Me.pcbMinimize.Image = CType(resources.GetObject("pcbMinimize.Image"), System.Drawing.Image)
        Me.pcbMinimize.Location = New System.Drawing.Point(361, 3)
        Me.pcbMinimize.Name = "pcbMinimize"
        Me.pcbMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMinimize.TabIndex = 10
        Me.pcbMinimize.TabStop = False
        '
        'pcbExit
        '
        Me.pcbExit.Image = CType(resources.GetObject("pcbExit.Image"), System.Drawing.Image)
        Me.pcbExit.Location = New System.Drawing.Point(382, 3)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(15, 15)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 9
        Me.pcbExit.TabStop = False
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Controls.Add(Me.btnAdicionarCidade)
        Me.pnlConteudo.Controls.Add(Me.btnExcluir)
        Me.pnlConteudo.Controls.Add(Me.btnAlterar)
        Me.pnlConteudo.Controls.Add(Me.btnAdicionar)
        Me.pnlConteudo.Controls.Add(Me.dgvLogradouro)
        Me.pnlConteudo.Controls.Add(Me.mskCEP)
        Me.pnlConteudo.Controls.Add(Me.cbbCidade)
        Me.pnlConteudo.Controls.Add(Me.Label4)
        Me.pnlConteudo.Controls.Add(Me.Label2)
        Me.pnlConteudo.Location = New System.Drawing.Point(0, 26)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(400, 262)
        Me.pnlConteudo.TabIndex = 0
        '
        'btnAdicionarCidade
        '
        Me.btnAdicionarCidade.Location = New System.Drawing.Point(183, 29)
        Me.btnAdicionarCidade.Name = "btnAdicionarCidade"
        Me.btnAdicionarCidade.Size = New System.Drawing.Size(37, 23)
        Me.btnAdicionarCidade.TabIndex = 10
        Me.btnAdicionarCidade.Text = "Add"
        Me.btnAdicionarCidade.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(322, 58)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(322, 29)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(322, 3)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 7
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'dgvLogradouro
        '
        Me.dgvLogradouro.AllowUserToAddRows = False
        Me.dgvLogradouro.AllowUserToDeleteRows = False
        Me.dgvLogradouro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogradouro.Location = New System.Drawing.Point(3, 87)
        Me.dgvLogradouro.Name = "dgvLogradouro"
        Me.dgvLogradouro.ReadOnly = True
        Me.dgvLogradouro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogradouro.Size = New System.Drawing.Size(394, 172)
        Me.dgvLogradouro.TabIndex = 6
        '
        'mskCEP
        '
        Me.mskCEP.Location = New System.Drawing.Point(3, 29)
        Me.mskCEP.Mask = "99999-999"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(59, 20)
        Me.mskCEP.TabIndex = 1
        '
        'cbbCidade
        '
        Me.cbbCidade.DataSource = Me.CidadeBindingSource
        Me.cbbCidade.DisplayMember = "NomeCidade"
        Me.cbbCidade.FormattingEnabled = True
        Me.cbbCidade.Location = New System.Drawing.Point(68, 29)
        Me.cbbCidade.Name = "cbbCidade"
        Me.cbbCidade.Size = New System.Drawing.Size(109, 21)
        Me.cbbCidade.TabIndex = 3
        Me.cbbCidade.ValueMember = "CodigoCidade"
        '
        'CidadeBindingSource
        '
        Me.CidadeBindingSource.DataMember = "Cidade"
        Me.CidadeBindingSource.DataSource = Me.ZOOTECDataSet
        '
        'ZOOTECDataSet
        '
        Me.ZOOTECDataSet.DataSetName = "ZOOTECDataSet"
        Me.ZOOTECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CEP"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.ZOOTECDataSet
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'CidadeTableAdapter
        '
        Me.CidadeTableAdapter.ClearBeforeFill = True
        '
        'frmCadastroLogradouro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.pnlFundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastroLogradouro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastroLogradouro"
        Me.pnlFundo.ResumeLayout(False)
        Me.pnlFundo.PerformLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConteudo.ResumeLayout(False)
        Me.pnlConteudo.PerformLayout()
        CType(Me.dgvLogradouro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFundo As Panel
    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbMinimize As PictureBox
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents mskCEP As MaskedTextBox
    Friend WithEvents cbbCidade As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvLogradouro As DataGridView
    Friend WithEvents ZOOTECDataSet As ZOOTECDataSet
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As ZOOTECDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents CidadeBindingSource As BindingSource
    Friend WithEvents CidadeTableAdapter As ZOOTECDataSetTableAdapters.CidadeTableAdapter
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnAdicionarCidade As Button
End Class
