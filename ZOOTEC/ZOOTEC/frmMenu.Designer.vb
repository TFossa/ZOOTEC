<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnMedicamentos = New System.Windows.Forms.Button()
        Me.btnAnimais = New System.Windows.Forms.Button()
        Me.btnEmailTelefone = New System.Windows.Forms.Button()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnEstoque = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.btnNovoRecado = New System.Windows.Forms.Button()
        Me.btnExcluirRecado = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvRecado = New System.Windows.Forms.DataGridView()
        Me.ZOOTEC = New System.Windows.Forms.Label()
        Me.pnlAnimais = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvCadastroAnimal = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CbbEspeciesAnimal = New System.Windows.Forms.ComboBox()
        Me.EspeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZOOTECDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZOOTECDataSet = New ZOOTEC.ZOOTECDataSet()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CM = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CbbPorteAnimal = New System.Windows.Forms.ComboBox()
        Me.CbbGeneroAnimal = New System.Windows.Forms.ComboBox()
        Me.TxtPesoAnimal = New System.Windows.Forms.TextBox()
        Me.TxtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.TxtAlturaAnimal = New System.Windows.Forms.TextBox()
        Me.TxtDescricaoAnimal = New System.Windows.Forms.TextBox()
        Me.TxtCodigoCadastroAnimal = New System.Windows.Forms.TextBox()
        Me.btnAdicionarAnimal = New System.Windows.Forms.Button()
        Me.btnAlterarAnimal = New System.Windows.Forms.Button()
        Me.btnExcluirAnimal = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnAdicionarEspecies = New System.Windows.Forms.Button()
        Me.BtnAlterarEspecies = New System.Windows.Forms.Button()
        Me.BtnExcluirEspecies = New System.Windows.Forms.Button()
        Me.DgvEspecie = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtDescricaoEspecie = New System.Windows.Forms.TextBox()
        Me.TxtCodigoEspecie = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvAnimais = New System.Windows.Forms.DataGridView()
        Me.AnimalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlEstoque = New System.Windows.Forms.Panel()
        Me.btnAlterarEstoque = New System.Windows.Forms.Button()
        Me.btnExcluirEstoque = New System.Windows.Forms.Button()
        Me.btnAdicionarEstoque = New System.Windows.Forms.Button()
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.pnlMedicamentos = New System.Windows.Forms.Panel()
        Me.txtCategoriaMedicamento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEstoqueMinimoMedicamento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEstoqueMaximoMedicamento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtQuantidadeMedicamento = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNomeMedicamento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAlterarMedicamento = New System.Windows.Forms.Button()
        Me.btnExcluirMedicamento = New System.Windows.Forms.Button()
        Me.btnAdicionarMedicamento = New System.Windows.Forms.Button()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblAtual = New System.Windows.Forms.Label()
        Me.pcbMinimize = New System.Windows.Forms.PictureBox()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlFuncionarios = New System.Windows.Forms.Panel()
        Me.tbcFuncionario = New System.Windows.Forms.TabControl()
        Me.tbpPesquisaFuncionario = New System.Windows.Forms.TabPage()
        Me.btnExcluirFuncionario = New System.Windows.Forms.Button()
        Me.dgvFuncionario = New System.Windows.Forms.DataGridView()
        Me.tbpCadastroFuncionario = New System.Windows.Forms.TabPage()
        Me.btnAlterarFuncionario = New System.Windows.Forms.Button()
        Me.btnLimparFuncionario = New System.Windows.Forms.Button()
        Me.btnAdicionarFuncionario = New System.Windows.Forms.Button()
        Me.btnAddCEP = New System.Windows.Forms.Button()
        Me.cbbCEP = New System.Windows.Forms.ComboBox()
        Me.LogradouroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSalario = New System.Windows.Forms.MaskedTextBox()
        Me.cbbFuncao = New System.Windows.Forms.ComboBox()
        Me.FuncaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeFuncionario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FuncaoTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.FuncaoTableAdapter()
        Me.LogradouroTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.LogradouroTableAdapter()
        Me.pnlEmailTelefoneFuncionario = New System.Windows.Forms.Panel()
        Me.btnExcluirTelefone = New System.Windows.Forms.Button()
        Me.btnAlterarTelefone = New System.Windows.Forms.Button()
        Me.btnAdicionarTelefone = New System.Windows.Forms.Button()
        Me.btnExcluirEmail = New System.Windows.Forms.Button()
        Me.btnAlterarEmail = New System.Windows.Forms.Button()
        Me.btnAdicionarEmail = New System.Windows.Forms.Button()
        Me.dgvTelefone = New System.Windows.Forms.DataGridView()
        Me.cbbFuncionario = New System.Windows.Forms.ComboBox()
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvEmail = New System.Windows.Forms.DataGridView()
        Me.txtTelefoneFuncionario = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmailFuncionario = New System.Windows.Forms.TextBox()
        Me.FuncionarioTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.FuncionarioTableAdapter()
        Me.AnimalTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.AnimalTableAdapter()
        Me.EspeciesTableAdapter = New ZOOTEC.ZOOTECDataSetTableAdapters.EspeciesTableAdapter()
        Me.DtpDataNascimentoAnimal = New System.Windows.Forms.DateTimePicker()
        Me.pnlMenu.SuspendLayout()
        Me.pnlInicio.SuspendLayout()
        CType(Me.dgvRecado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnimais.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvCadastroAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZOOTECDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvEspecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnimais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstoque.SuspendLayout()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMedicamentos.SuspendLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.pnlFuncionarios.SuspendLayout()
        Me.tbcFuncionario.SuspendLayout()
        Me.tbpPesquisaFuncionario.SuspendLayout()
        CType(Me.dgvFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCadastroFuncionario.SuspendLayout()
        CType(Me.LogradouroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmailTelefoneFuncionario.SuspendLayout()
        CType(Me.dgvTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnMedicamentos)
        Me.pnlMenu.Controls.Add(Me.btnAnimais)
        Me.pnlMenu.Controls.Add(Me.btnEmailTelefone)
        Me.pnlMenu.Controls.Add(Me.btnFuncionarios)
        Me.pnlMenu.Controls.Add(Me.btnEstoque)
        Me.pnlMenu.Controls.Add(Me.lblUsuario)
        Me.pnlMenu.Controls.Add(Me.btnInicio)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 650)
        Me.pnlMenu.TabIndex = 0
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicamentos.Location = New System.Drawing.Point(0, 198)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(200, 48)
        Me.btnMedicamentos.TabIndex = 10
        Me.btnMedicamentos.Text = "Medicamentos"
        Me.btnMedicamentos.UseVisualStyleBackColor = True
        '
        'btnAnimais
        '
        Me.btnAnimais.FlatAppearance.BorderSize = 0
        Me.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnimais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnimais.Location = New System.Drawing.Point(3, 90)
        Me.btnAnimais.Name = "btnAnimais"
        Me.btnAnimais.Size = New System.Drawing.Size(200, 48)
        Me.btnAnimais.TabIndex = 3
        Me.btnAnimais.Text = "Animais"
        Me.btnAnimais.UseVisualStyleBackColor = True
        '
        'btnEmailTelefone
        '
        Me.btnEmailTelefone.FlatAppearance.BorderSize = 0
        Me.btnEmailTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmailTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmailTelefone.Location = New System.Drawing.Point(0, 252)
        Me.btnEmailTelefone.Name = "btnEmailTelefone"
        Me.btnEmailTelefone.Size = New System.Drawing.Size(200, 48)
        Me.btnEmailTelefone.TabIndex = 12
        Me.btnEmailTelefone.Text = "Email/Telefone Funcionário"
        Me.btnEmailTelefone.UseVisualStyleBackColor = True
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.FlatAppearance.BorderSize = 0
        Me.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFuncionarios.Location = New System.Drawing.Point(0, 306)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Size = New System.Drawing.Size(200, 48)
        Me.btnFuncionarios.TabIndex = 6
        Me.btnFuncionarios.Text = "Funcionários"
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnEstoque
        '
        Me.btnEstoque.FlatAppearance.BorderSize = 0
        Me.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstoque.Location = New System.Drawing.Point(0, 144)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(200, 48)
        Me.btnEstoque.TabIndex = 1
        Me.btnEstoque.Text = "Estoque"
        Me.btnEstoque.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(12, 11)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(107, 20)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Administrador"
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInicio.Location = New System.Drawing.Point(0, 36)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(200, 48)
        Me.btnInicio.TabIndex = 4
        Me.btnInicio.Text = "Ínicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'pnlInicio
        '
        Me.pnlInicio.Controls.Add(Me.btnNovoRecado)
        Me.pnlInicio.Controls.Add(Me.btnExcluirRecado)
        Me.pnlInicio.Controls.Add(Me.TextBox1)
        Me.pnlInicio.Controls.Add(Me.Label3)
        Me.pnlInicio.Controls.Add(Me.dgvRecado)
        Me.pnlInicio.Location = New System.Drawing.Point(200, 24)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(800, 604)
        Me.pnlInicio.TabIndex = 1
        '
        'btnNovoRecado
        '
        Me.btnNovoRecado.Location = New System.Drawing.Point(142, 541)
        Me.btnNovoRecado.Name = "btnNovoRecado"
        Me.btnNovoRecado.Size = New System.Drawing.Size(75, 23)
        Me.btnNovoRecado.TabIndex = 4
        Me.btnNovoRecado.Text = "Novo"
        Me.btnNovoRecado.UseVisualStyleBackColor = True
        '
        'btnExcluirRecado
        '
        Me.btnExcluirRecado.Location = New System.Drawing.Point(61, 541)
        Me.btnExcluirRecado.Name = "btnExcluirRecado"
        Me.btnExcluirRecado.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirRecado.TabIndex = 3
        Me.btnExcluirRecado.Text = "Excluir"
        Me.btnExcluirRecado.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(348, 42)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(353, 478)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Lista de Recados"
        '
        'dgvRecado
        '
        Me.dgvRecado.AllowUserToAddRows = False
        Me.dgvRecado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecado.Location = New System.Drawing.Point(15, 42)
        Me.dgvRecado.Name = "dgvRecado"
        Me.dgvRecado.ReadOnly = True
        Me.dgvRecado.Size = New System.Drawing.Size(240, 478)
        Me.dgvRecado.TabIndex = 0
        '
        'ZOOTEC
        '
        Me.ZOOTEC.AutoSize = True
        Me.ZOOTEC.Location = New System.Drawing.Point(376, 4)
        Me.ZOOTEC.Name = "ZOOTEC"
        Me.ZOOTEC.Size = New System.Drawing.Size(51, 13)
        Me.ZOOTEC.TabIndex = 2
        Me.ZOOTEC.Text = "ZOOTEC"
        '
        'pnlAnimais
        '
        Me.pnlAnimais.Controls.Add(Me.TabControl1)
        Me.pnlAnimais.Controls.Add(Me.dgvAnimais)
        Me.pnlAnimais.Location = New System.Drawing.Point(200, 24)
        Me.pnlAnimais.Name = "pnlAnimais"
        Me.pnlAnimais.Size = New System.Drawing.Size(800, 604)
        Me.pnlAnimais.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 14)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 506)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DtpDataNascimentoAnimal)
        Me.TabPage1.Controls.Add(Me.DgvCadastroAnimal)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.CbbEspeciesAnimal)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.CM)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.CbbPorteAnimal)
        Me.TabPage1.Controls.Add(Me.CbbGeneroAnimal)
        Me.TabPage1.Controls.Add(Me.TxtPesoAnimal)
        Me.TabPage1.Controls.Add(Me.TxtNomeAnimal)
        Me.TabPage1.Controls.Add(Me.TxtAlturaAnimal)
        Me.TabPage1.Controls.Add(Me.TxtDescricaoAnimal)
        Me.TabPage1.Controls.Add(Me.TxtCodigoCadastroAnimal)
        Me.TabPage1.Controls.Add(Me.btnAdicionarAnimal)
        Me.TabPage1.Controls.Add(Me.btnAlterarAnimal)
        Me.TabPage1.Controls.Add(Me.btnExcluirAnimal)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de Animais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DgvCadastroAnimal
        '
        Me.DgvCadastroAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCadastroAnimal.Location = New System.Drawing.Point(22, 246)
        Me.DgvCadastroAnimal.Name = "DgvCadastroAnimal"
        Me.DgvCadastroAnimal.Size = New System.Drawing.Size(721, 213)
        Me.DgvCadastroAnimal.TabIndex = 30
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(619, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Espécie"
        '
        'CbbEspeciesAnimal
        '
        Me.CbbEspeciesAnimal.DataSource = Me.EspeciesBindingSource
        Me.CbbEspeciesAnimal.DisplayMember = "Descricao"
        Me.CbbEspeciesAnimal.FormattingEnabled = True
        Me.CbbEspeciesAnimal.Location = New System.Drawing.Point(622, 135)
        Me.CbbEspeciesAnimal.Name = "CbbEspeciesAnimal"
        Me.CbbEspeciesAnimal.Size = New System.Drawing.Size(121, 21)
        Me.CbbEspeciesAnimal.TabIndex = 28
        Me.CbbEspeciesAnimal.ValueMember = "CodigoEspecies"
        '
        'EspeciesBindingSource
        '
        Me.EspeciesBindingSource.DataMember = "Especies"
        Me.EspeciesBindingSource.DataSource = Me.ZOOTECDataSetBindingSource
        '
        'ZOOTECDataSetBindingSource
        '
        Me.ZOOTECDataSetBindingSource.DataSource = Me.ZOOTECDataSet
        Me.ZOOTECDataSetBindingSource.Position = 0
        '
        'ZOOTECDataSet
        '
        Me.ZOOTECDataSet.DataSetName = "ZOOTECDataSet"
        Me.ZOOTECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(43, 63)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 13)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Nome"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(421, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(31, 13)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Peso"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(421, 119)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(34, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Altura"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(43, 119)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Descrição"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(421, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Data de Nascimento"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(622, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Gênero"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(619, 63)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Porte"
        '
        'CM
        '
        Me.CM.AutoSize = True
        Me.CM.Location = New System.Drawing.Point(583, 137)
        Me.CM.Name = "CM"
        Me.CM.Size = New System.Drawing.Size(21, 13)
        Me.CM.TabIndex = 20
        Me.CM.Text = "cm"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(583, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(22, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "KG"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(43, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Código de Cadastro"
        '
        'CbbPorteAnimal
        '
        Me.CbbPorteAnimal.FormattingEnabled = True
        Me.CbbPorteAnimal.Items.AddRange(New Object() {"Pequeno", "Médio", "Grande"})
        Me.CbbPorteAnimal.Location = New System.Drawing.Point(622, 81)
        Me.CbbPorteAnimal.Name = "CbbPorteAnimal"
        Me.CbbPorteAnimal.Size = New System.Drawing.Size(121, 21)
        Me.CbbPorteAnimal.TabIndex = 17
        '
        'CbbGeneroAnimal
        '
        Me.CbbGeneroAnimal.FormattingEnabled = True
        Me.CbbGeneroAnimal.Items.AddRange(New Object() {"Macho", "Fêmea"})
        Me.CbbGeneroAnimal.Location = New System.Drawing.Point(622, 29)
        Me.CbbGeneroAnimal.Name = "CbbGeneroAnimal"
        Me.CbbGeneroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.CbbGeneroAnimal.TabIndex = 16
        '
        'TxtPesoAnimal
        '
        Me.TxtPesoAnimal.Location = New System.Drawing.Point(424, 82)
        Me.TxtPesoAnimal.Name = "TxtPesoAnimal"
        Me.TxtPesoAnimal.Size = New System.Drawing.Size(153, 20)
        Me.TxtPesoAnimal.TabIndex = 14
        Me.TxtPesoAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNomeAnimal
        '
        Me.TxtNomeAnimal.Location = New System.Drawing.Point(43, 82)
        Me.TxtNomeAnimal.Name = "TxtNomeAnimal"
        Me.TxtNomeAnimal.Size = New System.Drawing.Size(281, 20)
        Me.TxtNomeAnimal.TabIndex = 13
        Me.TxtNomeAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAlturaAnimal
        '
        Me.TxtAlturaAnimal.Location = New System.Drawing.Point(424, 136)
        Me.TxtAlturaAnimal.Name = "TxtAlturaAnimal"
        Me.TxtAlturaAnimal.Size = New System.Drawing.Size(153, 20)
        Me.TxtAlturaAnimal.TabIndex = 12
        Me.TxtAlturaAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDescricaoAnimal
        '
        Me.TxtDescricaoAnimal.Location = New System.Drawing.Point(43, 138)
        Me.TxtDescricaoAnimal.Multiline = True
        Me.TxtDescricaoAnimal.Name = "TxtDescricaoAnimal"
        Me.TxtDescricaoAnimal.Size = New System.Drawing.Size(281, 92)
        Me.TxtDescricaoAnimal.TabIndex = 11
        Me.TxtDescricaoAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCodigoCadastroAnimal
        '
        Me.TxtCodigoCadastroAnimal.Location = New System.Drawing.Point(43, 29)
        Me.TxtCodigoCadastroAnimal.Name = "TxtCodigoCadastroAnimal"
        Me.TxtCodigoCadastroAnimal.Size = New System.Drawing.Size(281, 20)
        Me.TxtCodigoCadastroAnimal.TabIndex = 10
        Me.TxtCodigoCadastroAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdicionarAnimal
        '
        Me.btnAdicionarAnimal.Location = New System.Drawing.Point(444, 192)
        Me.btnAdicionarAnimal.Name = "btnAdicionarAnimal"
        Me.btnAdicionarAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarAnimal.TabIndex = 7
        Me.btnAdicionarAnimal.Text = "Adicionar"
        Me.btnAdicionarAnimal.UseVisualStyleBackColor = True
        '
        'btnAlterarAnimal
        '
        Me.btnAlterarAnimal.Location = New System.Drawing.Point(606, 192)
        Me.btnAlterarAnimal.Name = "btnAlterarAnimal"
        Me.btnAlterarAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarAnimal.TabIndex = 9
        Me.btnAlterarAnimal.Text = "Alterar"
        Me.btnAlterarAnimal.UseVisualStyleBackColor = True
        '
        'btnExcluirAnimal
        '
        Me.btnExcluirAnimal.Location = New System.Drawing.Point(525, 192)
        Me.btnExcluirAnimal.Name = "btnExcluirAnimal"
        Me.btnExcluirAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirAnimal.TabIndex = 8
        Me.btnExcluirAnimal.Text = "Excluir"
        Me.btnExcluirAnimal.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(10, 7)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(744, 467)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnAdicionarEspecies)
        Me.TabPage2.Controls.Add(Me.BtnAlterarEspecies)
        Me.TabPage2.Controls.Add(Me.BtnExcluirEspecies)
        Me.TabPage2.Controls.Add(Me.DgvEspecie)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.TxtDescricaoEspecie)
        Me.TabPage2.Controls.Add(Me.TxtCodigoEspecie)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro de Espécie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnAdicionarEspecies
        '
        Me.BtnAdicionarEspecies.Location = New System.Drawing.Point(48, 353)
        Me.BtnAdicionarEspecies.Name = "BtnAdicionarEspecies"
        Me.BtnAdicionarEspecies.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdicionarEspecies.TabIndex = 7
        Me.BtnAdicionarEspecies.Text = "Adicionar"
        Me.BtnAdicionarEspecies.UseVisualStyleBackColor = True
        '
        'BtnAlterarEspecies
        '
        Me.BtnAlterarEspecies.Location = New System.Drawing.Point(210, 353)
        Me.BtnAlterarEspecies.Name = "BtnAlterarEspecies"
        Me.BtnAlterarEspecies.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlterarEspecies.TabIndex = 9
        Me.BtnAlterarEspecies.Text = "Alterar"
        Me.BtnAlterarEspecies.UseVisualStyleBackColor = True
        '
        'BtnExcluirEspecies
        '
        Me.BtnExcluirEspecies.Location = New System.Drawing.Point(129, 353)
        Me.BtnExcluirEspecies.Name = "BtnExcluirEspecies"
        Me.BtnExcluirEspecies.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluirEspecies.TabIndex = 8
        Me.BtnExcluirEspecies.Text = "Excluir"
        Me.BtnExcluirEspecies.UseVisualStyleBackColor = True
        '
        'DgvEspecie
        '
        Me.DgvEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEspecie.Location = New System.Drawing.Point(395, 69)
        Me.DgvEspecie.Name = "DgvEspecie"
        Me.DgvEspecie.Size = New System.Drawing.Size(315, 363)
        Me.DgvEspecie.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(29, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(293, 25)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "CADASTRO DE ESPÉCIES"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(63, 246)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Descrição"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(63, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Código"
        '
        'TxtDescricaoEspecie
        '
        Me.TxtDescricaoEspecie.Location = New System.Drawing.Point(66, 262)
        Me.TxtDescricaoEspecie.Name = "TxtDescricaoEspecie"
        Me.TxtDescricaoEspecie.Size = New System.Drawing.Size(190, 20)
        Me.TxtDescricaoEspecie.TabIndex = 2
        '
        'TxtCodigoEspecie
        '
        Me.TxtCodigoEspecie.Location = New System.Drawing.Point(66, 166)
        Me.TxtCodigoEspecie.Name = "TxtCodigoEspecie"
        Me.TxtCodigoEspecie.Size = New System.Drawing.Size(190, 20)
        Me.TxtCodigoEspecie.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 468)
        Me.DataGridView1.TabIndex = 0
        '
        'dgvAnimais
        '
        Me.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimais.Location = New System.Drawing.Point(15, 12)
        Me.dgvAnimais.Name = "dgvAnimais"
        Me.dgvAnimais.Size = New System.Drawing.Size(773, 523)
        Me.dgvAnimais.TabIndex = 2
        '
        'AnimalBindingSource
        '
        Me.AnimalBindingSource.DataMember = "Animal"
        Me.AnimalBindingSource.DataSource = Me.ZOOTECDataSetBindingSource
        '
        'pnlEstoque
        '
        Me.pnlEstoque.Controls.Add(Me.btnAlterarEstoque)
        Me.pnlEstoque.Controls.Add(Me.btnExcluirEstoque)
        Me.pnlEstoque.Controls.Add(Me.btnAdicionarEstoque)
        Me.pnlEstoque.Controls.Add(Me.dgvEstoque)
        Me.pnlEstoque.Location = New System.Drawing.Point(200, 24)
        Me.pnlEstoque.Name = "pnlEstoque"
        Me.pnlEstoque.Size = New System.Drawing.Size(800, 604)
        Me.pnlEstoque.TabIndex = 3
        '
        'btnAlterarEstoque
        '
        Me.btnAlterarEstoque.Location = New System.Drawing.Point(177, 526)
        Me.btnAlterarEstoque.Name = "btnAlterarEstoque"
        Me.btnAlterarEstoque.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarEstoque.TabIndex = 7
        Me.btnAlterarEstoque.Text = "Alterar"
        Me.btnAlterarEstoque.UseVisualStyleBackColor = True
        '
        'btnExcluirEstoque
        '
        Me.btnExcluirEstoque.Location = New System.Drawing.Point(96, 526)
        Me.btnExcluirEstoque.Name = "btnExcluirEstoque"
        Me.btnExcluirEstoque.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirEstoque.TabIndex = 6
        Me.btnExcluirEstoque.Text = "Excluir"
        Me.btnExcluirEstoque.UseVisualStyleBackColor = True
        '
        'btnAdicionarEstoque
        '
        Me.btnAdicionarEstoque.Location = New System.Drawing.Point(15, 526)
        Me.btnAdicionarEstoque.Name = "btnAdicionarEstoque"
        Me.btnAdicionarEstoque.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarEstoque.TabIndex = 5
        Me.btnAdicionarEstoque.Text = "Adicionar"
        Me.btnAdicionarEstoque.UseVisualStyleBackColor = True
        '
        'dgvEstoque
        '
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(15, 12)
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.Size = New System.Drawing.Size(773, 508)
        Me.dgvEstoque.TabIndex = 2
        '
        'pnlMedicamentos
        '
        Me.pnlMedicamentos.Controls.Add(Me.txtCategoriaMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.Label19)
        Me.pnlMedicamentos.Controls.Add(Me.txtEstoqueMinimoMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.Label18)
        Me.pnlMedicamentos.Controls.Add(Me.txtEstoqueMaximoMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.Label17)
        Me.pnlMedicamentos.Controls.Add(Me.txtQuantidadeMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.Label16)
        Me.pnlMedicamentos.Controls.Add(Me.txtNomeMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.Label15)
        Me.pnlMedicamentos.Controls.Add(Me.btnAlterarMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.btnExcluirMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.btnAdicionarMedicamento)
        Me.pnlMedicamentos.Controls.Add(Me.dgvMedicamentos)
        Me.pnlMedicamentos.Location = New System.Drawing.Point(200, 24)
        Me.pnlMedicamentos.Name = "pnlMedicamentos"
        Me.pnlMedicamentos.Size = New System.Drawing.Size(800, 604)
        Me.pnlMedicamentos.TabIndex = 8
        '
        'txtCategoriaMedicamento
        '
        Me.txtCategoriaMedicamento.Location = New System.Drawing.Point(582, 40)
        Me.txtCategoriaMedicamento.Name = "txtCategoriaMedicamento"
        Me.txtCategoriaMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoriaMedicamento.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(579, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Categoria"
        '
        'txtEstoqueMinimoMedicamento
        '
        Me.txtEstoqueMinimoMedicamento.Location = New System.Drawing.Point(476, 40)
        Me.txtEstoqueMinimoMedicamento.Name = "txtEstoqueMinimoMedicamento"
        Me.txtEstoqueMinimoMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.txtEstoqueMinimoMedicamento.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(473, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Estoque Mínimo"
        '
        'txtEstoqueMaximoMedicamento
        '
        Me.txtEstoqueMaximoMedicamento.Location = New System.Drawing.Point(370, 40)
        Me.txtEstoqueMaximoMedicamento.Name = "txtEstoqueMaximoMedicamento"
        Me.txtEstoqueMaximoMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.txtEstoqueMaximoMedicamento.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(367, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Estoque Máximo"
        '
        'txtQuantidadeMedicamento
        '
        Me.txtQuantidadeMedicamento.Location = New System.Drawing.Point(264, 40)
        Me.txtQuantidadeMedicamento.Name = "txtQuantidadeMedicamento"
        Me.txtQuantidadeMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMedicamento.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(261, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Quantidade"
        '
        'txtNomeMedicamento
        '
        Me.txtNomeMedicamento.Location = New System.Drawing.Point(102, 40)
        Me.txtNomeMedicamento.Name = "txtNomeMedicamento"
        Me.txtNomeMedicamento.Size = New System.Drawing.Size(156, 20)
        Me.txtNomeMedicamento.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(99, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Nome Medicamento"
        '
        'btnAlterarMedicamento
        '
        Me.btnAlterarMedicamento.Enabled = False
        Me.btnAlterarMedicamento.Location = New System.Drawing.Point(348, 91)
        Me.btnAlterarMedicamento.Name = "btnAlterarMedicamento"
        Me.btnAlterarMedicamento.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarMedicamento.TabIndex = 7
        Me.btnAlterarMedicamento.Text = "Alterar"
        Me.btnAlterarMedicamento.UseVisualStyleBackColor = True
        '
        'btnExcluirMedicamento
        '
        Me.btnExcluirMedicamento.Enabled = False
        Me.btnExcluirMedicamento.Location = New System.Drawing.Point(429, 91)
        Me.btnExcluirMedicamento.Name = "btnExcluirMedicamento"
        Me.btnExcluirMedicamento.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirMedicamento.TabIndex = 6
        Me.btnExcluirMedicamento.Text = "Excluir"
        Me.btnExcluirMedicamento.UseVisualStyleBackColor = True
        '
        'btnAdicionarMedicamento
        '
        Me.btnAdicionarMedicamento.Location = New System.Drawing.Point(267, 91)
        Me.btnAdicionarMedicamento.Name = "btnAdicionarMedicamento"
        Me.btnAdicionarMedicamento.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarMedicamento.TabIndex = 5
        Me.btnAdicionarMedicamento.Text = "Adicionar"
        Me.btnAdicionarMedicamento.UseVisualStyleBackColor = True
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AllowUserToDeleteRows = False
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.Location = New System.Drawing.Point(15, 199)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.ReadOnly = True
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(773, 394)
        Me.dgvMedicamentos.TabIndex = 2
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblAtual)
        Me.pnlTop.Controls.Add(Me.pcbMinimize)
        Me.pnlTop.Controls.Add(Me.pcbExit)
        Me.pnlTop.Location = New System.Drawing.Point(200, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(800, 24)
        Me.pnlTop.TabIndex = 4
        '
        'lblAtual
        '
        Me.lblAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtual.AutoSize = True
        Me.lblAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtual.Location = New System.Drawing.Point(395, 5)
        Me.lblAtual.Name = "lblAtual"
        Me.lblAtual.Size = New System.Drawing.Size(0, 18)
        Me.lblAtual.TabIndex = 2
        Me.lblAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbMinimize
        '
        Me.pcbMinimize.Image = CType(resources.GetObject("pcbMinimize.Image"), System.Drawing.Image)
        Me.pcbMinimize.Location = New System.Drawing.Point(761, 3)
        Me.pcbMinimize.Name = "pcbMinimize"
        Me.pcbMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMinimize.TabIndex = 1
        Me.pcbMinimize.TabStop = False
        '
        'pcbExit
        '
        Me.pcbExit.Image = CType(resources.GetObject("pcbExit.Image"), System.Drawing.Image)
        Me.pcbExit.Location = New System.Drawing.Point(782, 3)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(15, 15)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 0
        Me.pcbExit.TabStop = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.ZOOTEC)
        Me.pnlBottom.Location = New System.Drawing.Point(200, 627)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(800, 23)
        Me.pnlBottom.TabIndex = 5
        '
        'pnlFuncionarios
        '
        Me.pnlFuncionarios.Controls.Add(Me.tbcFuncionario)
        Me.pnlFuncionarios.Location = New System.Drawing.Point(200, 24)
        Me.pnlFuncionarios.Name = "pnlFuncionarios"
        Me.pnlFuncionarios.Size = New System.Drawing.Size(800, 604)
        Me.pnlFuncionarios.TabIndex = 3
        '
        'tbcFuncionario
        '
        Me.tbcFuncionario.Controls.Add(Me.tbpPesquisaFuncionario)
        Me.tbcFuncionario.Controls.Add(Me.tbpCadastroFuncionario)
        Me.tbcFuncionario.Location = New System.Drawing.Point(9, 10)
        Me.tbcFuncionario.Name = "tbcFuncionario"
        Me.tbcFuncionario.SelectedIndex = 0
        Me.tbcFuncionario.Size = New System.Drawing.Size(782, 587)
        Me.tbcFuncionario.TabIndex = 8
        '
        'tbpPesquisaFuncionario
        '
        Me.tbpPesquisaFuncionario.Controls.Add(Me.btnExcluirFuncionario)
        Me.tbpPesquisaFuncionario.Controls.Add(Me.dgvFuncionario)
        Me.tbpPesquisaFuncionario.Location = New System.Drawing.Point(4, 22)
        Me.tbpPesquisaFuncionario.Name = "tbpPesquisaFuncionario"
        Me.tbpPesquisaFuncionario.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPesquisaFuncionario.Size = New System.Drawing.Size(774, 561)
        Me.tbpPesquisaFuncionario.TabIndex = 0
        Me.tbpPesquisaFuncionario.Text = "Pesquisa"
        Me.tbpPesquisaFuncionario.UseVisualStyleBackColor = True
        '
        'btnExcluirFuncionario
        '
        Me.btnExcluirFuncionario.Enabled = False
        Me.btnExcluirFuncionario.Location = New System.Drawing.Point(17, 509)
        Me.btnExcluirFuncionario.Name = "btnExcluirFuncionario"
        Me.btnExcluirFuncionario.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirFuncionario.TabIndex = 3
        Me.btnExcluirFuncionario.Text = "Excluir"
        Me.btnExcluirFuncionario.UseVisualStyleBackColor = True
        '
        'dgvFuncionario
        '
        Me.dgvFuncionario.AllowUserToAddRows = False
        Me.dgvFuncionario.AllowUserToDeleteRows = False
        Me.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionario.Location = New System.Drawing.Point(6, 6)
        Me.dgvFuncionario.Name = "dgvFuncionario"
        Me.dgvFuncionario.ReadOnly = True
        Me.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionario.Size = New System.Drawing.Size(762, 497)
        Me.dgvFuncionario.TabIndex = 1
        '
        'tbpCadastroFuncionario
        '
        Me.tbpCadastroFuncionario.Controls.Add(Me.btnAlterarFuncionario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.btnLimparFuncionario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.btnAdicionarFuncionario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.btnAddCEP)
        Me.tbpCadastroFuncionario.Controls.Add(Me.cbbCEP)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtSalario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.cbbFuncao)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtCPF)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtRG)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label11)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtSenha)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label10)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtUsuario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label9)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label8)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label7)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtBairro)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label6)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtEndereco)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label5)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label4)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label2)
        Me.tbpCadastroFuncionario.Controls.Add(Me.txtNomeFuncionario)
        Me.tbpCadastroFuncionario.Controls.Add(Me.Label1)
        Me.tbpCadastroFuncionario.Location = New System.Drawing.Point(4, 22)
        Me.tbpCadastroFuncionario.Name = "tbpCadastroFuncionario"
        Me.tbpCadastroFuncionario.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCadastroFuncionario.Size = New System.Drawing.Size(774, 561)
        Me.tbpCadastroFuncionario.TabIndex = 1
        Me.tbpCadastroFuncionario.Text = "Cadastro"
        Me.tbpCadastroFuncionario.UseVisualStyleBackColor = True
        '
        'btnAlterarFuncionario
        '
        Me.btnAlterarFuncionario.Enabled = False
        Me.btnAlterarFuncionario.Location = New System.Drawing.Point(129, 196)
        Me.btnAlterarFuncionario.Name = "btnAlterarFuncionario"
        Me.btnAlterarFuncionario.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarFuncionario.TabIndex = 13
        Me.btnAlterarFuncionario.Text = "Alterar"
        Me.btnAlterarFuncionario.UseVisualStyleBackColor = True
        '
        'btnLimparFuncionario
        '
        Me.btnLimparFuncionario.Location = New System.Drawing.Point(225, 196)
        Me.btnLimparFuncionario.Name = "btnLimparFuncionario"
        Me.btnLimparFuncionario.Size = New System.Drawing.Size(75, 23)
        Me.btnLimparFuncionario.TabIndex = 14
        Me.btnLimparFuncionario.Text = "Limpar"
        Me.btnLimparFuncionario.UseVisualStyleBackColor = True
        '
        'btnAdicionarFuncionario
        '
        Me.btnAdicionarFuncionario.Location = New System.Drawing.Point(35, 196)
        Me.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario"
        Me.btnAdicionarFuncionario.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarFuncionario.TabIndex = 12
        Me.btnAdicionarFuncionario.Text = "Adicionar"
        Me.btnAdicionarFuncionario.UseVisualStyleBackColor = True
        '
        'btnAddCEP
        '
        Me.btnAddCEP.Location = New System.Drawing.Point(349, 109)
        Me.btnAddCEP.Name = "btnAddCEP"
        Me.btnAddCEP.Size = New System.Drawing.Size(43, 23)
        Me.btnAddCEP.TabIndex = 7
        Me.btnAddCEP.Text = "Add"
        Me.btnAddCEP.UseVisualStyleBackColor = True
        '
        'cbbCEP
        '
        Me.cbbCEP.DataSource = Me.LogradouroBindingSource
        Me.cbbCEP.DisplayMember = "CEP"
        Me.cbbCEP.FormattingEnabled = True
        Me.cbbCEP.Location = New System.Drawing.Point(222, 111)
        Me.cbbCEP.Name = "cbbCEP"
        Me.cbbCEP.Size = New System.Drawing.Size(121, 21)
        Me.cbbCEP.TabIndex = 6
        Me.cbbCEP.ValueMember = "CodigoLogradouro"
        '
        'LogradouroBindingSource
        '
        Me.LogradouroBindingSource.DataMember = "Logradouro"
        Me.LogradouroBindingSource.DataSource = Me.ZOOTECDataSetBindingSource
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(137, 152)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(82, 20)
        Me.txtSalario.TabIndex = 9
        '
        'cbbFuncao
        '
        Me.cbbFuncao.DataSource = Me.FuncaoBindingSource
        Me.cbbFuncao.DisplayMember = "NomeFuncao"
        Me.cbbFuncao.FormattingEnabled = True
        Me.cbbFuncao.Location = New System.Drawing.Point(10, 151)
        Me.cbbFuncao.Name = "cbbFuncao"
        Me.cbbFuncao.Size = New System.Drawing.Size(121, 21)
        Me.cbbFuncao.TabIndex = 8
        Me.cbbFuncao.ValueMember = "CodigoFuncao"
        '
        'FuncaoBindingSource
        '
        Me.FuncaoBindingSource.DataMember = "Funcao"
        Me.FuncaoBindingSource.DataSource = Me.ZOOTECDataSetBindingSource
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(104, 71)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(82, 20)
        Me.txtCPF.TabIndex = 3
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(10, 71)
        Me.txtRG.Mask = "99.999.999-9"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(82, 20)
        Me.txtRG.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Função"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(331, 152)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(328, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Senha"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(225, 152)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Usuário"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Salário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "CEP"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(116, 111)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(100, 20)
        Me.txtBairro.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Bairro"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(10, 111)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(100, 20)
        Me.txtEndereco.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RG"
        '
        'txtNomeFuncionario
        '
        Me.txtNomeFuncionario.Location = New System.Drawing.Point(10, 31)
        Me.txtNomeFuncionario.Name = "txtNomeFuncionario"
        Me.txtNomeFuncionario.Size = New System.Drawing.Size(753, 20)
        Me.txtNomeFuncionario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'FuncaoTableAdapter
        '
        Me.FuncaoTableAdapter.ClearBeforeFill = True
        '
        'LogradouroTableAdapter
        '
        Me.LogradouroTableAdapter.ClearBeforeFill = True
        '
        'pnlEmailTelefoneFuncionario
        '
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnExcluirTelefone)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnAlterarTelefone)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnAdicionarTelefone)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnExcluirEmail)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnAlterarEmail)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.btnAdicionarEmail)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.dgvTelefone)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.cbbFuncionario)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.Label14)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.dgvEmail)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.txtTelefoneFuncionario)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.Label13)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.Label12)
        Me.pnlEmailTelefoneFuncionario.Controls.Add(Me.txtEmailFuncionario)
        Me.pnlEmailTelefoneFuncionario.Location = New System.Drawing.Point(200, 24)
        Me.pnlEmailTelefoneFuncionario.Name = "pnlEmailTelefoneFuncionario"
        Me.pnlEmailTelefoneFuncionario.Size = New System.Drawing.Size(800, 604)
        Me.pnlEmailTelefoneFuncionario.TabIndex = 13
        '
        'btnExcluirTelefone
        '
        Me.btnExcluirTelefone.Enabled = False
        Me.btnExcluirTelefone.Location = New System.Drawing.Point(630, 199)
        Me.btnExcluirTelefone.Name = "btnExcluirTelefone"
        Me.btnExcluirTelefone.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirTelefone.TabIndex = 14
        Me.btnExcluirTelefone.Text = "Excluir"
        Me.btnExcluirTelefone.UseVisualStyleBackColor = True
        '
        'btnAlterarTelefone
        '
        Me.btnAlterarTelefone.Enabled = False
        Me.btnAlterarTelefone.Location = New System.Drawing.Point(549, 199)
        Me.btnAlterarTelefone.Name = "btnAlterarTelefone"
        Me.btnAlterarTelefone.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarTelefone.TabIndex = 13
        Me.btnAlterarTelefone.Text = "Alterar"
        Me.btnAlterarTelefone.UseVisualStyleBackColor = True
        '
        'btnAdicionarTelefone
        '
        Me.btnAdicionarTelefone.Location = New System.Drawing.Point(468, 199)
        Me.btnAdicionarTelefone.Name = "btnAdicionarTelefone"
        Me.btnAdicionarTelefone.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarTelefone.TabIndex = 12
        Me.btnAdicionarTelefone.Text = "Adicionar"
        Me.btnAdicionarTelefone.UseVisualStyleBackColor = True
        '
        'btnExcluirEmail
        '
        Me.btnExcluirEmail.Enabled = False
        Me.btnExcluirEmail.Location = New System.Drawing.Point(258, 199)
        Me.btnExcluirEmail.Name = "btnExcluirEmail"
        Me.btnExcluirEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirEmail.TabIndex = 11
        Me.btnExcluirEmail.Text = "Excluir"
        Me.btnExcluirEmail.UseVisualStyleBackColor = True
        '
        'btnAlterarEmail
        '
        Me.btnAlterarEmail.Enabled = False
        Me.btnAlterarEmail.Location = New System.Drawing.Point(177, 199)
        Me.btnAlterarEmail.Name = "btnAlterarEmail"
        Me.btnAlterarEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarEmail.TabIndex = 10
        Me.btnAlterarEmail.Text = "Alterar"
        Me.btnAlterarEmail.UseVisualStyleBackColor = True
        '
        'btnAdicionarEmail
        '
        Me.btnAdicionarEmail.Location = New System.Drawing.Point(96, 199)
        Me.btnAdicionarEmail.Name = "btnAdicionarEmail"
        Me.btnAdicionarEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarEmail.TabIndex = 9
        Me.btnAdicionarEmail.Text = "Adicionar"
        Me.btnAdicionarEmail.UseVisualStyleBackColor = True
        '
        'dgvTelefone
        '
        Me.dgvTelefone.AllowUserToAddRows = False
        Me.dgvTelefone.AllowUserToDeleteRows = False
        Me.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefone.Location = New System.Drawing.Point(415, 228)
        Me.dgvTelefone.Name = "dgvTelefone"
        Me.dgvTelefone.ReadOnly = True
        Me.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefone.Size = New System.Drawing.Size(361, 357)
        Me.dgvTelefone.TabIndex = 8
        '
        'cbbFuncionario
        '
        Me.cbbFuncionario.DataSource = Me.FuncionarioBindingSource
        Me.cbbFuncionario.DisplayMember = "NomeFuncionario"
        Me.cbbFuncionario.FormattingEnabled = True
        Me.cbbFuncionario.Location = New System.Drawing.Point(42, 93)
        Me.cbbFuncionario.Name = "cbbFuncionario"
        Me.cbbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbbFuncionario.TabIndex = 7
        Me.cbbFuncionario.ValueMember = "CodigoFuncionario"
        '
        'FuncionarioBindingSource
        '
        Me.FuncionarioBindingSource.DataMember = "Funcionario"
        Me.FuncionarioBindingSource.DataSource = Me.ZOOTECDataSetBindingSource
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Funcionario"
        '
        'dgvEmail
        '
        Me.dgvEmail.AllowUserToAddRows = False
        Me.dgvEmail.AllowUserToDeleteRows = False
        Me.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmail.Location = New System.Drawing.Point(22, 228)
        Me.dgvEmail.Name = "dgvEmail"
        Me.dgvEmail.ReadOnly = True
        Me.dgvEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmail.Size = New System.Drawing.Size(373, 357)
        Me.dgvEmail.TabIndex = 5
        '
        'txtTelefoneFuncionario
        '
        Me.txtTelefoneFuncionario.Location = New System.Drawing.Point(549, 173)
        Me.txtTelefoneFuncionario.Mask = "(99)99999-9999"
        Me.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario"
        Me.txtTelefoneFuncionario.Size = New System.Drawing.Size(86, 20)
        Me.txtTelefoneFuncionario.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(546, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Telefone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Email"
        '
        'txtEmailFuncionario
        '
        Me.txtEmailFuncionario.Location = New System.Drawing.Point(42, 173)
        Me.txtEmailFuncionario.Name = "txtEmailFuncionario"
        Me.txtEmailFuncionario.Size = New System.Drawing.Size(323, 20)
        Me.txtEmailFuncionario.TabIndex = 0
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'AnimalTableAdapter
        '
        Me.AnimalTableAdapter.ClearBeforeFill = True
        '
        'EspeciesTableAdapter
        '
        Me.EspeciesTableAdapter.ClearBeforeFill = True
        '
        'DtpDataNascimentoAnimal
        '
        Me.DtpDataNascimentoAnimal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDataNascimentoAnimal.Location = New System.Drawing.Point(424, 35)
        Me.DtpDataNascimentoAnimal.Name = "DtpDataNascimentoAnimal"
        Me.DtpDataNascimentoAnimal.Size = New System.Drawing.Size(153, 20)
        Me.DtpDataNascimentoAnimal.TabIndex = 31
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.pnlAnimais)
        Me.Controls.Add(Me.pnlFuncionarios)
        Me.Controls.Add(Me.pnlEmailTelefoneFuncionario)
        Me.Controls.Add(Me.pnlMedicamentos)
        Me.Controls.Add(Me.pnlEstoque)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlBottom)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu - ZOOTEC"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlInicio.ResumeLayout(False)
        Me.pnlInicio.PerformLayout()
        CType(Me.dgvRecado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnimais.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvCadastroAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspeciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZOOTECDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZOOTECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvEspecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnimais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstoque.ResumeLayout(False)
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMedicamentos.ResumeLayout(False)
        Me.pnlMedicamentos.PerformLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlFuncionarios.ResumeLayout(False)
        Me.tbcFuncionario.ResumeLayout(False)
        Me.tbpPesquisaFuncionario.ResumeLayout(False)
        CType(Me.dgvFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCadastroFuncionario.ResumeLayout(False)
        Me.tbpCadastroFuncionario.PerformLayout()
        CType(Me.LogradouroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmailTelefoneFuncionario.ResumeLayout(False)
        Me.pnlEmailTelefoneFuncionario.PerformLayout()
        CType(Me.dgvTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlInicio As Panel
    Friend WithEvents ZOOTEC As Label
    Friend WithEvents btnAnimais As Button
    Friend WithEvents btnEstoque As Button
    Friend WithEvents pnlAnimais As Panel
    Friend WithEvents pnlEstoque As Panel
    Friend WithEvents btnInicio As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents pcbMinimize As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnFuncionarios As Button
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents pnlFuncionarios As Panel
    Friend WithEvents dgvAnimais As DataGridView
    Friend WithEvents dgvEstoque As DataGridView
    Friend WithEvents dgvFuncionario As DataGridView
    Friend WithEvents btnNovoRecado As Button
    Friend WithEvents btnExcluirRecado As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvRecado As DataGridView
    Friend WithEvents btnExcluirEstoque As Button
    Friend WithEvents btnAdicionarEstoque As Button
    Friend WithEvents btnAlterarEstoque As Button
    Friend WithEvents pnlMedicamentos As Panel
    Friend WithEvents btnAlterarMedicamento As Button
    Friend WithEvents btnExcluirMedicamento As Button
    Friend WithEvents btnAdicionarMedicamento As Button
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents lblAtual As Label
    Friend WithEvents btnEmailTelefone As Button
    Friend WithEvents tbcFuncionario As TabControl
    Friend WithEvents tbpPesquisaFuncionario As TabPage
    Friend WithEvents tbpCadastroFuncionario As TabPage
    Friend WithEvents cbbFuncao As ComboBox
    Friend WithEvents ZOOTECDataSetBindingSource As BindingSource
    Friend WithEvents ZOOTECDataSet As ZOOTECDataSet
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeFuncionario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FuncaoBindingSource As BindingSource
    Friend WithEvents FuncaoTableAdapter As ZOOTECDataSetTableAdapters.FuncaoTableAdapter
    Friend WithEvents txtSalario As MaskedTextBox
    Friend WithEvents cbbCEP As ComboBox
    Friend WithEvents LogradouroBindingSource As BindingSource
    Friend WithEvents LogradouroTableAdapter As ZOOTECDataSetTableAdapters.LogradouroTableAdapter
    Friend WithEvents btnAddCEP As Button
    Friend WithEvents btnExcluirFuncionario As Button
    Friend WithEvents btnLimparFuncionario As Button
    Friend WithEvents btnAdicionarFuncionario As Button
    Friend WithEvents btnAlterarFuncionario As Button
    Friend WithEvents pnlEmailTelefoneFuncionario As Panel
    Friend WithEvents txtTelefoneFuncionario As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmailFuncionario As TextBox
    Friend WithEvents cbbFuncionario As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvEmail As DataGridView
    Friend WithEvents FuncionarioBindingSource As BindingSource
    Friend WithEvents FuncionarioTableAdapter As ZOOTECDataSetTableAdapters.FuncionarioTableAdapter
    Friend WithEvents dgvTelefone As DataGridView
    Friend WithEvents btnExcluirTelefone As Button
    Friend WithEvents btnAlterarTelefone As Button
    Friend WithEvents btnAdicionarTelefone As Button
    Friend WithEvents btnExcluirEmail As Button
    Friend WithEvents btnAlterarEmail As Button
    Friend WithEvents btnAdicionarEmail As Button
    Friend WithEvents txtCategoriaMedicamento As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtEstoqueMinimoMedicamento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEstoqueMaximoMedicamento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtQuantidadeMedicamento As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNomeMedicamento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtDescricaoEspecie As TextBox
    Friend WithEvents TxtCodigoEspecie As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgvEspecie As DataGridView
    Friend WithEvents BtnAdicionarEspecies As Button
    Friend WithEvents BtnAlterarEspecies As Button
    Friend WithEvents BtnExcluirEspecies As Button
    Friend WithEvents DgvCadastroAnimal As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents CbbEspeciesAnimal As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CM As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents CbbPorteAnimal As ComboBox
    Friend WithEvents CbbGeneroAnimal As ComboBox
    Friend WithEvents TxtPesoAnimal As TextBox
    Friend WithEvents TxtNomeAnimal As TextBox
    Friend WithEvents TxtAlturaAnimal As TextBox
    Friend WithEvents TxtDescricaoAnimal As TextBox
    Friend WithEvents TxtCodigoCadastroAnimal As TextBox
    Friend WithEvents btnAdicionarAnimal As Button
    Friend WithEvents btnAlterarAnimal As Button
    Friend WithEvents btnExcluirAnimal As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AnimalBindingSource As BindingSource
    Friend WithEvents AnimalTableAdapter As ZOOTECDataSetTableAdapters.AnimalTableAdapter
    Friend WithEvents EspeciesBindingSource As BindingSource
    Friend WithEvents EspeciesTableAdapter As ZOOTECDataSetTableAdapters.EspeciesTableAdapter
    Friend WithEvents DtpDataNascimentoAnimal As DateTimePicker
End Class
