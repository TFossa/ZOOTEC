<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroCidade
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroCidade))
        Me.pnlFundo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbMinimize = New System.Windows.Forms.PictureBox()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.btnAdicionarEstado = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.dgvCidade = New System.Windows.Forms.DataGridView()
        Me.cbbEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZOOTECDataSet = New ZOOTEC.ZOOTECDataSet()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstadoTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.EstadoTableAdapter()
        Me.pnlFundo.SuspendLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConteudo.SuspendLayout()
        CType(Me.dgvCidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlFundo.Size = New System.Drawing.Size(350, 300)
        Me.pnlFundo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cadastro de Cidade"
        '
        'pcbMinimize
        '
        Me.pcbMinimize.Image = CType(resources.GetObject("pcbMinimize.Image"), System.Drawing.Image)
        Me.pcbMinimize.Location = New System.Drawing.Point(311, 3)
        Me.pcbMinimize.Name = "pcbMinimize"
        Me.pcbMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMinimize.TabIndex = 8
        Me.pcbMinimize.TabStop = False
        '
        'pcbExit
        '
        Me.pcbExit.Image = CType(resources.GetObject("pcbExit.Image"), System.Drawing.Image)
        Me.pcbExit.Location = New System.Drawing.Point(332, 3)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(15, 15)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 7
        Me.pcbExit.TabStop = False
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Controls.Add(Me.btnAdicionarEstado)
        Me.pnlConteudo.Controls.Add(Me.btnAdicionar)
        Me.pnlConteudo.Controls.Add(Me.btnExcluir)
        Me.pnlConteudo.Controls.Add(Me.btnAlterar)
        Me.pnlConteudo.Controls.Add(Me.dgvCidade)
        Me.pnlConteudo.Controls.Add(Me.cbbEstado)
        Me.pnlConteudo.Controls.Add(Me.txtCidade)
        Me.pnlConteudo.Controls.Add(Me.Label3)
        Me.pnlConteudo.Controls.Add(Me.Label2)
        Me.pnlConteudo.Location = New System.Drawing.Point(3, 22)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(344, 266)
        Me.pnlConteudo.TabIndex = 0
        '
        'btnAdicionarEstado
        '
        Me.btnAdicionarEstado.Location = New System.Drawing.Point(288, 19)
        Me.btnAdicionarEstado.Name = "btnAdicionarEstado"
        Me.btnAdicionarEstado.Size = New System.Drawing.Size(47, 23)
        Me.btnAdicionarEstado.TabIndex = 8
        Me.btnAdicionarEstado.Text = "Add"
        Me.btnAdicionarEstado.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(219, 47)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 7
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(138, 47)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(57, 47)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'dgvCidade
        '
        Me.dgvCidade.AllowUserToAddRows = False
        Me.dgvCidade.AllowUserToDeleteRows = False
        Me.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCidade.Location = New System.Drawing.Point(3, 76)
        Me.dgvCidade.Name = "dgvCidade"
        Me.dgvCidade.ReadOnly = True
        Me.dgvCidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCidade.Size = New System.Drawing.Size(338, 187)
        Me.dgvCidade.TabIndex = 4
        '
        'cbbEstado
        '
        Me.cbbEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EstadoBindingSource, "CodigoEstado", True))
        Me.cbbEstado.DataSource = Me.EstadoBindingSource
        Me.cbbEstado.DisplayMember = "NomeEstado"
        Me.cbbEstado.FormattingEnabled = True
        Me.cbbEstado.Location = New System.Drawing.Point(173, 21)
        Me.cbbEstado.Name = "cbbEstado"
        Me.cbbEstado.Size = New System.Drawing.Size(109, 21)
        Me.cbbEstado.TabIndex = 3
        Me.cbbEstado.ValueMember = "CodigoEstado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.ZOOTECDataSet
        '
        'ZOOTECDataSet
        '
        Me.ZOOTECDataSet.DataSetName = "ZOOTECDataSet"
        Me.ZOOTECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(7, 21)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(156, 20)
        Me.txtCidade.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cidade"
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'frmCadastroCidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 300)
        Me.Controls.Add(Me.pnlFundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastroCidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastroCidade"
        Me.pnlFundo.ResumeLayout(False)
        Me.pnlFundo.PerformLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConteudo.ResumeLayout(False)
        Me.pnlConteudo.PerformLayout()
        CType(Me.dgvCidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFundo As Panel
    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbMinimize As PictureBox
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents dgvCidade As DataGridView
    Friend WithEvents cbbEstado As ComboBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ZOOTECDataSet As ZOOTECDataSet
    Friend WithEvents EstadoBindingSource As BindingSource
    Friend WithEvents EstadoTableAdapter As ZOOTECDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents btnAdicionarEstado As Button
End Class
