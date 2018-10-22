Imports System.Data.SqlClient
Public Class frmMenu
    'Variável que salva o Tipo de Login
    Dim TipoLogin As String
    Dim cnBanco As New SqlConnection(conexao)

    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")
    Dim dtCarregaGrid As New DataTable
    Dim daPesquisaGrid As New SqlDataAdapter
    Dim cmdSelectPesquisa As New SqlCommand
    Dim SqlEmail, SqlTelefone, SqlEspecies, SqlAnimais As String
    Dim SqlSelect, SqlInsert, SqlUpdate, SqlDelete As String
    Dim VarCodigo As Integer

    Dim ExecuteInsert
    Dim ExecuteUpdate
    Dim ExecuteDelete As New SqlCommand(SqlDelete, cnBanco)
    Private Sub LimpaGrid()
        dsCarregaGrid.Tables.Clear()
        dtCarregaGrid.EndLoadData()
        VarCodigo = vbNull
    End Sub
    Private Sub CarregaGrid(SqlSelect)
        Try
            cmdSelectPesquisa.CommandText = SqlSelect
            cmdSelectPesquisa.Connection = cnBanco
            daPesquisaGrid.SelectCommand = cmdSelectPesquisa
            dtCarregaGrid.Clear()
        Catch ex As Exception
            MessageBox.Show("não foi possível carregar o grid")
        End Try

        Try
            cnBanco.Open()
            dsCarregaGrid.Tables(0).BeginLoadData()
            daPesquisaGrid.Fill(dtCarregaGrid)
            dsCarregaGrid.Tables(0).EndLoadData()
        Catch ErroSql As SqlException
            MessageBox.Show(ErroSql.ToString)
        Finally
            cnBanco.Close()
            cmdSelectPesquisa.Parameters.Clear()
        End Try
        dgvFuncionario.Focus()
    End Sub
    Private Sub TabelaInsert(ExecuteInsert)
        Try
            cnBanco.Open()
            ExecuteInsert.ExecuteNonQuery()
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro:")
        Finally
            cnBanco.Close()
            CarregaGrid(SqlSelect)
            ExecuteInsert.Parameters.Clear()
        End Try
        txtNomeFuncionario.Focus()
    End Sub
    Private Sub TabelaUpdate(ExecuteUpdate)
        Try
            cnBanco.Open()
            ExecuteUpdate.ExecuteNonQuery()
            MessageBox.Show("Dados Alterados com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro:")
        Finally
            cnBanco.Close()
            ExecuteUpdate.Parameters.Clear()
            CarregaGrid(SqlSelect)
        End Try
        dgvFuncionario.Focus()
    End Sub
    Private Sub TabelaDelete(ExecuteDelete)

        Dim ConfirmarExclusao As Integer = MessageBox.Show("Confirmar Exclusão", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ConfirmarExclusao = vbYes Then

            Try
                cnBanco.Open()
                ExecuteDelete.ExecuteNonQuery()
                MessageBox.Show("Dados Excluidos")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro:")
            Finally
                cnBanco.Close()
                ExecuteDelete.Parameters.Clear()
                CarregaGrid(SqlSelect)
            End Try
            dgvFuncionario.Focus()

        End If
    End Sub
    Private Sub AtivarControles()
        btnAdicionarFuncionario.Visible = True
        btnAlterarFuncionario.Visible = True
        btnExcluirFuncionario.Visible = True

        btnAdicionarAnimal.Visible = True
        btnAlterarAnimal.Visible = True
        btnExcluirAnimal.Visible = True

        btnAdicionarEstoque.Visible = True
        btnAlterarEstoque.Visible = True
        btnExcluirEstoque.Visible = True

        btnAdicionarMedicamento.Visible = True
        btnAlterarMedicamento.Visible = True
        btnExcluirMedicamento.Visible = True
    End Sub
    Private Sub DesativaControles()
        btnAdicionarFuncionario.Visible = False
        btnAlterarFuncionario.Visible = False
        btnExcluirFuncionario.Visible = False

        btnAdicionarAnimal.Visible = False
        btnAlterarAnimal.Visible = False
        btnExcluirAnimal.Visible = False

        btnAdicionarEstoque.Visible = False
        btnAlterarEstoque.Visible = False
        btnExcluirEstoque.Visible = False

        btnAdicionarMedicamento.Visible = False
        btnAlterarMedicamento.Visible = False
        btnExcluirMedicamento.Visible = False
    End Sub
    Private Sub EsconderPaineis()
        pnlInicio.Visible = False
        pnlEstoque.Visible = False
        pnlAnimais.Visible = False
        pnlFuncionarios.Visible = False
        pnlEmailTelefoneFuncionario.Visible = False
        pnlMedicamentos.Visible = False
    End Sub
    Private Sub EscurecerBotoes()
        btnEstoque.BackColor = VEscuro
        btnAnimais.BackColor = VEscuro
        btnInicio.BackColor = VEscuro
        btnFuncionarios.BackColor = VEscuro
        btnEmailTelefone.BackColor = VEscuro
        btnMedicamentos.BackColor = VEscuro
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Especies'. Você pode movê-la ou removê-la conforme necessário.
        Me.EspeciesTableAdapter.Fill(Me.ZOOTECDataSet.Especies)
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Animal'. Você pode movê-la ou removê-la conforme necessário.
        Me.AnimalTableAdapter.Fill(Me.ZOOTECDataSet.Animal)
        'Verificação do Login
        'Configurar banco de dados para verificar o tipo de usuário
        TipoLogin = "Administrador"
        'Modificar Nome de Usuário para aparecer o nome do funcionario e veterinário
        If TipoLogin = "Administrador" Then
            'Definindo os controles do usuário
            AtivarControles()

            'Editando Credenciais
            lblUsuario.Text = "Administrador"

        ElseIf TipoLogin = "Veterinário" Then
            'Definindo os controles do usuário
            DesativaControles()
            btnAdicionarAnimal.Visible = True
            btnAlterarAnimal.Visible = True
            btnExcluirAnimal.Visible = True
            btnAdicionarMedicamento.Visible = True
            btnAlterarMedicamento.Visible = True
            btnExcluirMedicamento.Visible = True

            'Editando Credenciais
            lblUsuario.Text = "Veterinário"

        ElseIf TipoLogin = "Funcionário" Then
            'Definindo os controles do usuário
            AtivarControles()
            btnFuncionarios.Visible = False

            'Editando Credenciais
            lblUsuario.Text = "Funcionário"
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlInicio.Visible = True
        btnInicio.BackColor = VClaro
        lblAtual.Text = "Ínicio"
    End Sub

    Private Sub btnCadastroDeAnimais_Click(sender As Object, e As EventArgs)
        EsconderPaineis()
        EscurecerBotoes()
    End Sub

    Private Sub btnTabelaDeAnimais_Click(sender As Object, e As EventArgs) Handles btnAnimais.Click
        LimpaGrid()
        EsconderPaineis()
        EscurecerBotoes()
        pnlAnimais.Visible = True
        btnAnimais.BackColor = VClaro
        lblAtual.Text = "Animais/Especies"




        ' Carregar as conexões e o grid 

        Dim colCodigoEspecies As DataColumn
        Dim colDescricao As DataColumn

        ' Carregando os  Grid 
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Especies")

        colCodigoEspecies = dtCarregaGrid.Columns.Add("CodigoEspecies", GetType(Integer))
        colDescricao = dtCarregaGrid.Columns.Add("Descrição", GetType(String))

        DgvEspecie.DataSource = dtCarregaGrid

        DgvEspecie.Columns("CodigoEspecies").ReadOnly = True
        DgvEspecie.Columns("Descrição").ReadOnly = True

        SqlEspecies = "SELECT E.CodigoEspecies, E.Descricao as 'Descrição' 
                    FROM Especies E
                    ORDER BY CodigoEspecies"
        CarregaGrid(SqlEspecies)

        '-----------------------------------------------------------------------------------------------------------------------
        CbbEspeciesAnimal.SelectedIndex = -1



        dtCarregaGrid = dsCarregaGrid.Tables.Add("CadastroAnimais")
        Dim colCodigoCadastroAnimal As DataColumn
        Dim colNomeAnimal As DataColumn
        Dim colDescricaoAnimal As DataColumn
        Dim colDataDeNascimentoAnimal As DataColumn
        Dim colPesoAnimal As DataColumn
        Dim colAlturaAnimal As DataColumn
        Dim colGeneroAnimal As DataColumn
        Dim colPorteAnimal As DataColumn
        Dim colEspeciesAnimal As DataColumn
        Dim colCodigoEspecie As DataColumn



        colCodigoCadastroAnimal = dtCarregaGrid.Columns.Add("Codigo de Cadastro", GetType(Integer))
        colNomeAnimal = dtCarregaGrid.Columns.Add("Nome", GetType(String))
        colDescricaoAnimal = dtCarregaGrid.Columns.Add("Descrição", GetType(String))
        colDataDeNascimentoAnimal = dtCarregaGrid.Columns.Add("Data De Nascimento", GetType(String))
        colPesoAnimal = dtCarregaGrid.Columns.Add("Peso", GetType(String))
        colAlturaAnimal = dtCarregaGrid.Columns.Add("Altura", GetType(String))
        colGeneroAnimal = dtCarregaGrid.Columns.Add("Gênero", GetType(String))
        colPorteAnimal = dtCarregaGrid.Columns.Add("Porte", GetType(String))
        colEspeciesAnimal = dtCarregaGrid.Columns.Add("Espécie", GetType(String))
        colCodigoEspecie = dtCarregaGrid.Columns.Add("Código", GetType(Integer))

        DgvCadastroAnimal.DataSource = dtCarregaGrid

        DgvCadastroAnimal.Columns("Codigo de Cadastro").ReadOnly = True
        DgvCadastroAnimal.Columns("Nome").ReadOnly = True
        DgvCadastroAnimal.Columns("Descrição").ReadOnly = True
        DgvCadastroAnimal.Columns("Data De Nascimento").ReadOnly = True
        DgvCadastroAnimal.Columns("Peso").ReadOnly = True
        DgvCadastroAnimal.Columns("Altura").ReadOnly = True
        DgvCadastroAnimal.Columns("Gênero").ReadOnly = True
        DgvCadastroAnimal.Columns("Porte").ReadOnly = True
        DgvCadastroAnimal.Columns("Espécie").ReadOnly = True
        DgvCadastroAnimal.Columns("Código").Visible = False

        SqlAnimais = "SELECT A.CodigoCadastroAnimal as 'Codigo de Cadastro', " &
        "A.NomeAnimal as 'Nome', " &
        "A.DescricaoAnimal as 'Descrição', " &
        "A.DataDeNascimentoAnimal as 'Data De Nascimento', " &
        "A.PesoAnimal as 'Peso', " &
        "A.AlturaAnimal as 'Altura', " &
        "A.GeneroAnimal as 'Gênero', " &
        "A.PorteAnimal as 'Porte', " &
        "A.CodigoEspecies as 'Espécie' " &
        "From Animal A 
         ORDER BY CodigoCadastroAnimal"

        CarregaGrid(SqlAnimais)

    End Sub

    Private Sub btnEstoqueDeAlimentos_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlEstoque.Visible = True
        btnEstoque.BackColor = VClaro
        lblAtual.Text = "Estoque"

        ' Carregar o Grid Estoque

    End Sub

    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Private Sub frmMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Close()
    End Sub

    Private Sub pcbMinimize_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMedicamentosEVacinas_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        LimpaGrid()
        EsconderPaineis()
        EscurecerBotoes()
        pnlMedicamentos.Visible = True
        btnMedicamentos.BackColor = VClaro
        lblAtual.Text = "Medicamentos"

        ' Carregar o grid Medicamentos
        Dim colCodigoMedicamento As DataColumn
        Dim colNomeMedicamento, colQuantidade, colEstoqueMinimo, colEstoqueMaximo, colCategoria As DataColumn

        ' Carregando Grid
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Medicamento")

        colCodigoMedicamento = dtCarregaGrid.Columns.Add("CodigoMedicamento", GetType(Integer))

        colNomeMedicamento = dtCarregaGrid.Columns.Add("Nome", GetType(String))
        colQuantidade = dtCarregaGrid.Columns.Add("Quantidade", GetType(String))
        colEstoqueMinimo = dtCarregaGrid.Columns.Add("Estoque Minímo", GetType(String))
        colEstoqueMaximo = dtCarregaGrid.Columns.Add("Estoque Máximo", GetType(String))
        colCategoria = dtCarregaGrid.Columns.Add("Categoria", GetType(String))

        dgvMedicamentos.DataSource = dtCarregaGrid

        dgvMedicamentos.Columns("CodigoMedicamento").Visible = False

        dgvMedicamentos.Columns("Nome").ReadOnly = True
        dgvMedicamentos.Columns("Quantidade").ReadOnly = True
        dgvMedicamentos.Columns("Estoque Minímo").ReadOnly = True
        dgvMedicamentos.Columns("Estoque Máximo").ReadOnly = True
        dgvMedicamentos.Columns("Categoria").ReadOnly = True

        SqlInsert = "INSERT INTO Medicamento(NomeMedicamento, Quantidade, EstoqueMinimo, EstoqueMaximo, Categoria) 
                    VALUES (@prmNomeMedicamento, @prmQuantidade, @prmEstoqueMinimo, @prmEstoqueMaximo, @prmCategoria)"

        SqlUpdate = "UPDATE Medicamento SET NomeMedicamento = @prmNomeMedicamento, Quantidade = @prmQuantidade, EstoqueMinimo = @prmEstoqueMinimo, EstoqueMaximo = @prmEstoqueMaximo, Categoria = @prmCategoria WHERE CodigoMedicamento = @prmCodigo"

        SqlDelete = "DELETE FROM Medicamento WHERE CodigoMedicamento = @prmCodigo"

        SqlSelect = " SELECT CodigoMedicamento, NomeMedicamento as 'Nome', Quantidade, EstoqueMinimo as 'Estoque Minímo', EstoqueMaximo as 'Estoque Máximo', Categoria  
                    FROM Medicamento 
                    ORDER BY CodigoMedicamento "

        CarregaGrid(SqlSelect)
    End Sub

    Private Sub btnFuncionarios_Click(sender As Object, e As EventArgs) Handles btnFuncionarios.Click
        LimpaGrid()
        EsconderPaineis()
        EscurecerBotoes()
        pnlFuncionarios.Visible = True
        btnFuncionarios.BackColor = VClaro
        lblAtual.Text = "Funcionários"

        cbbFuncao.SelectedIndex = -1
        cbbCEP.SelectedIndex = -1
        ' Carregar as conexões e o grid do funcionario

        Dim colCodigoFuncionario, colCodigoFuncao, colCodigoLogradouro As DataColumn
        Dim colNomeFuncionario, colRG, colCPF, colEndereco, colBairro, colCEP, colSalario, colFuncao, colUsuario, colSenha As DataColumn

        ' Carregando Grid
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Funcionario")

        colCodigoFuncionario = dtCarregaGrid.Columns.Add("CodigoFuncionario", GetType(Integer))
        colCodigoFuncao = dtCarregaGrid.Columns.Add("CodigoFuncao", GetType(Integer))
        colCodigoLogradouro = dtCarregaGrid.Columns.Add("CodigoLogradouro", GetType(Integer))

        colNomeFuncionario = dtCarregaGrid.Columns.Add("Nome", GetType(String))
        colRG = dtCarregaGrid.Columns.Add("RG", GetType(String))
        colCPF = dtCarregaGrid.Columns.Add("CPF", GetType(String))
        colEndereco = dtCarregaGrid.Columns.Add("Endereço", GetType(String))
        colBairro = dtCarregaGrid.Columns.Add("Bairro", GetType(String))
        colCEP = dtCarregaGrid.Columns.Add("CEP", GetType(String))
        colFuncao = dtCarregaGrid.Columns.Add("Função", GetType(String))
        colSalario = dtCarregaGrid.Columns.Add("Salário", GetType(String))
        colUsuario = dtCarregaGrid.Columns.Add("Usuário", GetType(String))
        colSenha = dtCarregaGrid.Columns.Add("Senha", GetType(String))

        dgvFuncionario.DataSource = dtCarregaGrid

        dgvFuncionario.Columns("CodigoFuncionario").Visible = False
        dgvFuncionario.Columns("CodigoFuncao").Visible = False
        dgvFuncionario.Columns("CodigoLogradouro").Visible = False


        dgvFuncionario.Columns("Nome").ReadOnly = True
        dgvFuncionario.Columns("RG").ReadOnly = True
        dgvFuncionario.Columns("CPF").ReadOnly = True
        dgvFuncionario.Columns("Endereço").ReadOnly = True
        dgvFuncionario.Columns("Bairro").ReadOnly = True
        dgvFuncionario.Columns("CEP").ReadOnly = True
        dgvFuncionario.Columns("Função").ReadOnly = True
        dgvFuncionario.Columns("Salário").ReadOnly = True
        dgvFuncionario.Columns("Usuário").ReadOnly = True
        dgvFuncionario.Columns("Senha").ReadOnly = True

        SqlInsert = "INSERT INTO Funcionario (NomeFuncionario , RG ,CPF ,Endereco ,Bairro ,CodigoLogradouro , Salario, CodigoFuncao , Usuario , Senha) VALUES (@prmFuncionario,@prmRG,@prmCPF,@prmEndereco,@prmBairro,@prmCodigoLogradouro,@prmSalario,@prmCodigoFuncao,@prmUsuario,@prmSenha)"

        SqlUpdate = "UPDATE Funcionario SET NomeFuncionario = @prmFuncionario ,RG = @prmRG ,CPF = @prmCPF,Endereco = @prmEndereco, Bairro = @prmBairro ,CodigoLogradouro = @prmCodigoLogradouro ,CodigoFuncao = @prmCodigoFuncao,Salario = @prmSalario,Usuario =@prmUsuario ,Senha = @prmSenha WHERE CodigoFuncionario = @prmCodigo"

        SqlDelete = "DELETE FROM Funcionario WHERE CodigoFuncionario = @prmCodigo"

        SqlSelect = "SELECT A.CodigoFuncionario, A.NomeFuncionario as 'Nome', A.RG, A.CPF, A.Endereco as 'Endereço', A.Bairro, A.CodigoLogradouro, B.CEP, A.CodigoFuncao, C.NomeFuncao as 'Função', A.Salario as 'Salário', A.Usuario as 'Usuário', A.Senha " &
                    "FROM Funcionario A, Logradouro B, Funcao C " &
                    "WHERE A.CodigoLogradouro = B.CodigoLogradouro and A.CodigoFuncao = C.CodigoFuncao " &
                    "ORDER BY CodigoFuncionario"

        CarregaGrid(SqlSelect)

    End Sub



    Private Sub dgvFuncionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionario.CellContentClick
        btnExcluirFuncionario.Enabled = True
        btnAlterarFuncionario.Enabled = True
    End Sub

    Private Sub btnNovoRecado_Click(sender As Object, e As EventArgs) Handles btnNovoRecado.Click
        frmRecado.Show()
    End Sub

    Private Sub frmMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Colorindo objetos em RGB
        pnlTop.BackColor = VEscuro
        pnlBottom.BackColor = VEscuro
        pnlMenu.BackColor = VEscuro

        pnlInicio.BackColor = VClaro
        pnlInicio.BackColor = VClaro
        pnlEstoque.BackColor = VClaro
        pnlAnimais.BackColor = VClaro
        pnlFuncionarios.BackColor = VClaro
        pnlEmailTelefoneFuncionario.BackColor = VClaro
        pnlMedicamentos.BackColor = VClaro

        EscurecerBotoes()
        btnInicio.BackColor = VClaro

        'visibilidade dos painéis
        EsconderPaineis()
        pnlInicio.Visible = True
        pnlMenu.Visible = True

        'Remover Escurecimento do botão
        btnEstoque.FlatAppearance.MouseOverBackColor = VClaro
        btnAnimais.FlatAppearance.MouseOverBackColor = VClaro
        btnInicio.FlatAppearance.MouseOverBackColor = VClaro
        btnMedicamentos.FlatAppearance.MouseOverBackColor = VClaro
        btnFuncionarios.FlatAppearance.MouseOverBackColor = VClaro
        btnEmailTelefone.FlatAppearance.MouseOverBackColor = VClaro

        btnEstoque.FlatAppearance.MouseDownBackColor = VClaro
        btnAnimais.FlatAppearance.MouseDownBackColor = VClaro
        btnInicio.FlatAppearance.MouseDownBackColor = VClaro
        btnMedicamentos.FlatAppearance.MouseDownBackColor = VClaro
        btnFuncionarios.FlatAppearance.MouseDownBackColor = VClaro
        btnEmailTelefone.FlatAppearance.MouseDownBackColor = VClaro
    End Sub

    Private Sub btnExcluirFuncionario_Click(sender As Object, e As EventArgs) Handles btnExcluirFuncionario.Click
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)
        ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigo", VarCodigo))

        TabelaDelete(ExecuteDelete)
        LimpaFuncionario()
        btnExcluirFuncionario.Enabled = False
        btnAlterarFuncionario.Enabled = False
    End Sub

    Private Sub btnAddCEP_Click(sender As Object, e As EventArgs) Handles btnAddCEP.Click
        frmCadastroLogradouro.Show()
    End Sub

    Private Sub btnLimparFuncionario_Click(sender As Object, e As EventArgs) Handles btnLimparFuncionario.Click
        LimpaFuncionario()
    End Sub

    Private Sub LimpaFuncionario()
        txtNomeFuncionario.Text = ""
        txtRG.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        cbbCEP.SelectedIndex = -1
        cbbFuncao.SelectedIndex = -1
        txtSalario.Text = ""
        txtUsuario.Text = ""
        txtSenha.Text = ""
    End Sub

    Private Sub btnEmailTelefone_Click(sender As Object, e As EventArgs) Handles btnEmailTelefone.Click
        LimpaGrid()
        EsconderPaineis()
        EscurecerBotoes()
        pnlEmailTelefoneFuncionario.Visible = True
        btnEmailTelefone.BackColor = VClaro
        lblAtual.Text = "Email/Telefone"

        cbbFuncionario.SelectedIndex = -1
        ' Carregar as conexões e o grid do Email do funcionario

        Dim colCodigoFuncionario, colCodigoTelefone, colCodigoEmail As DataColumn
        Dim colEmail, colTelefone, colNomeEmail, colNomeTelefone As DataColumn

        ' Carregando Grid Email
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Email")

        colCodigoFuncionario = dtCarregaGrid.Columns.Add("CodigoFuncionario", GetType(Integer))
        colCodigoEmail = dtCarregaGrid.Columns.Add("CodigoEmailFuncionario", GetType(Integer))

        colNomeEmail = dtCarregaGrid.Columns.Add("Nome", GetType(String))
        colEmail = dtCarregaGrid.Columns.Add("Email", GetType(String))

        dgvEmail.DataSource = dtCarregaGrid

        dgvEmail.Columns("CodigoFuncionario").Visible = False
        dgvEmail.Columns("CodigoEmailFuncionario").Visible = False

        dgvEmail.Columns("Nome").ReadOnly = True
        dgvEmail.Columns("Email").ReadOnly = True

        SqlEmail = "SELECT A.CodigoFuncionario, A.NomeFuncionario as 'Nome', B.CodigoEmailFuncionario, B.Email as 'Email' 
                    FROM Funcionario A, EmailFuncionario  B 
                    WHERE A.CodigoFuncionario = B.CodigoFuncionario 
                    ORDER BY CodigoFuncionario"
        CarregaGrid(SqlEmail)

        dtCarregaGrid = dsCarregaGrid.Tables.Add("Telefone")

        colCodigoFuncionario = dtCarregaGrid.Columns.Add("CodigoFuncionario", GetType(Integer))
        colCodigoTelefone = dtCarregaGrid.Columns.Add("CodigoTelefoneFuncionario", GetType(Integer))

        colNomeTelefone = dtCarregaGrid.Columns.Add("Nome", GetType(String))
        colTelefone = dtCarregaGrid.Columns.Add("Telefone", GetType(String))

        dgvTelefone.DataSource = dtCarregaGrid

        dgvTelefone.Columns("CodigoFuncionario").Visible = False
        dgvTelefone.Columns("CodigoTelefoneFuncionario").Visible = False

        dgvTelefone.Columns("Nome").ReadOnly = True
        dgvTelefone.Columns("Telefone").ReadOnly = True

        SqlTelefone = "SELECT A.CodigoFuncionario, A.NomeFuncionario as 'Nome', B.CodigoTelefoneFuncionario, B.Telefone as 'Telefone' 
                    FROM Funcionario A, TelefoneFuncionario  B 
                    WHERE A.CodigoFuncionario = B.CodigoFuncionario 
                    ORDER BY CodigoFuncionario"
        CarregaGrid(SqlTelefone)

    End Sub

    Private Sub btnAdicionarEmail_Click(sender As Object, e As EventArgs) Handles btnAdicionarEmail.Click
        SqlSelect = SqlEmail
        SqlInsert = "INSERT INTO EmailFuncionario (Email,CodigoFuncionario) VALUES (@prmEmail,@prmCodigoFuncionario)"
        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.add("@prmEmail", txtEmailFuncionario.Text)
        ExecuteInsert.parameters.add("@prmCodigoFuncionario", cbbFuncionario.SelectedValue)

        TabelaInsert(ExecuteInsert)
    End Sub

    Private Sub btnAlterarEmail_Click(sender As Object, e As EventArgs) Handles btnAlterarEmail.Click
        SqlSelect = SqlEmail
        SqlUpdate = "UPDATE EmailFuncionario  SET Email = @prmEmail, CodigoFuncionario = @prmCodigoFuncionario WHERE CodigoEmailFuncionario = @prmCodigo"
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)

        ExecuteUpdate.Parameters.add("@prmCodigo", VarCodigo)
        ExecuteUpdate.parameters.add("@prmEmail", txtEmailFuncionario.Text)
        ExecuteUpdate.parameters.add("@prmCodigoFuncionario", cbbFuncionario.SelectedValue)

        TabelaUpdate(ExecuteUpdate)
        btnAlterarEmail.Enabled = False
        btnExcluirEmail.Enabled = False
    End Sub

    Private Sub btnExcluirEmail_Click(sender As Object, e As EventArgs) Handles btnExcluirEmail.Click
        SqlSelect = SqlEmail
        SqlDelete = "DELETE FROM EmailFuncionario WHERE CodigoEmailFuncionario = @prmCodigo"
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)

        ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigo", VarCodigo))

        TabelaDelete(ExecuteDelete)
        LimpaEmail()
        btnAlterarEmail.Enabled = False
        btnExcluirEmail.Enabled = False
    End Sub

    Private Sub LimpaEmail()
        cbbFuncionario.SelectedIndex = -1
        txtEmailFuncionario.Text = ""
    End Sub

    Private Sub btnAdicionarTelefone_Click(sender As Object, e As EventArgs) Handles btnAdicionarTelefone.Click
        SqlSelect = SqlTelefone
        SqlInsert = "INSERT INTO TelefoneFuncionario (Telefone,CodigoFuncionario) VALUES (@prmTelefone,@prmCodigoFuncionario)"
        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.add("@prmTelefone", txtTelefoneFuncionario.Text)
        ExecuteInsert.Parameters.add("@prmCodigoFuncionario", cbbFuncionario.SelectedValue)

        TabelaInsert(ExecuteInsert)
    End Sub

    Private Sub btnAlterarTelefone_Click(sender As Object, e As EventArgs) Handles btnAlterarTelefone.Click
        SqlSelect = SqlTelefone
        SqlUpdate = "UPDATE TelefoneFuncionario SET Telefone = @prmTelefone, CodigoFuncionario = @prmCodigoFuncionario WHERE CodigoTelefoneFuncionario = @prmCodigo"
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)

        ExecuteUpdate.Parameters.add("@prmCodigo", VarCodigo)
        ExecuteUpdate.Parameters.add("@prmTelefone", txtTelefoneFuncionario.Text)
        ExecuteUpdate.Parameters.add("@prmCodigoFuncionario", cbbFuncionario.SelectedValue)

        TabelaUpdate(ExecuteUpdate)
        LimpaTelefone()
    End Sub

    Private Sub LimpaTelefone()
        cbbFuncionario.SelectedIndex = -1
        txtTelefoneFuncionario.Text = ""
    End Sub

    Private Sub dgvEmail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmail.CellContentClick
        btnAlterarEmail.Enabled = True
        btnExcluirEmail.Enabled = True
    End Sub

    Private Sub dgvTelefone_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefone.CellContentClick
        btnExcluirTelefone.Enabled = True
        btnAlterarTelefone.Enabled = True
    End Sub

    Private Sub dgvEmail_Click(sender As Object, e As EventArgs) Handles dgvEmail.Click
        VarCodigo = dgvEmail.CurrentRow.Cells("CodigoEmailFuncionario").Value
        txtEmailFuncionario.Text = dgvEmail.CurrentRow.Cells("Email").Value
        cbbFuncionario.SelectedValue = dgvEmail.CurrentRow.Cells("CodigoFuncionario").Value
    End Sub

    Private Sub dgvTelefone_Click(sender As Object, e As EventArgs) Handles dgvTelefone.Click
        VarCodigo = dgvTelefone.CurrentRow.Cells("CodigoTelefoneFuncionario").Value
        txtTelefoneFuncionario.Text = dgvTelefone.CurrentRow.Cells("Telefone").Value
        cbbFuncionario.SelectedValue = dgvTelefone.CurrentRow.Cells("CodigoFuncionario").Value
    End Sub

    Private Sub btnAdicionarMedicamento_Click(sender As Object, e As EventArgs) Handles btnAdicionarMedicamento.Click
        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.Add(New SqlParameter("@prmNomeMedicamento", txtNomeMedicamento.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmQuantidade", txtQuantidadeMedicamento.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmEstoqueMinimo", txtEstoqueMinimoMedicamento.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmEstoqueMaximo", txtEstoqueMaximoMedicamento.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCategoria", txtCategoriaMedicamento.Text))

        TabelaInsert(ExecuteInsert)
        LimpaMedicamento()
    End Sub

    Private Sub btnAlterarMedicamento_Click(sender As Object, e As EventArgs) Handles btnAlterarMedicamento.Click
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)

        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigo", VarCodigo))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmNomeMedicamento", txtNomeMedicamento.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmQuantidade", txtQuantidadeMedicamento.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmEstoqueMinimo", txtEstoqueMinimoMedicamento.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmEstoqueMaximo", txtEstoqueMaximoMedicamento.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCategoria", txtCategoriaMedicamento.Text))

        TabelaUpdate(ExecuteUpdate)
        LimpaMedicamento()
        btnAlterarMedicamento.Enabled = False
        btnExcluirMedicamento.Enabled = False
    End Sub

    Private Sub btnExcluirMedicamento_Click(sender As Object, e As EventArgs) Handles btnExcluirMedicamento.Click
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)

#Disable Warning BC40000 ' Type or member is obsolete
        ExecuteDelete.Parameters.Add("@prmCodigo", VarCodigo)
#Enable Warning BC40000 ' Type or member is obsolete

        TabelaDelete(ExecuteDelete)
        LimpaMedicamento()
        btnAlterarMedicamento.Enabled = False
        btnExcluirMedicamento.Enabled = False
    End Sub

    Private Sub dgvMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellContentClick
        btnExcluirMedicamento.Enabled = True
        btnAlterarMedicamento.Enabled = True
    End Sub

    Private Sub dgvMedicamentos_Click(sender As Object, e As EventArgs) Handles dgvMedicamentos.Click
        VarCodigo = dgvMedicamentos.CurrentRow.Cells("CodigoMedicamento").Value
        txtNomeMedicamento.Text = dgvMedicamentos.CurrentRow.Cells("Nome").Value
        txtQuantidadeMedicamento.Text = dgvMedicamentos.CurrentRow.Cells("Quantidade").Value
        txtEstoqueMinimoMedicamento.Text = dgvMedicamentos.CurrentRow.Cells("Estoque Minímo").Value
        txtEstoqueMaximoMedicamento.Text = dgvMedicamentos.CurrentRow.Cells("Estoque Máximo").Value
        txtCategoriaMedicamento.Text = dgvMedicamentos.CurrentRow.Cells("Categoria").Value
        btnExcluirMedicamento.Enabled = True
        btnAlterarMedicamento.Enabled = True
    End Sub

    Private Sub btnExcluirTelefone_Click(sender As Object, e As EventArgs) Handles btnExcluirTelefone.Click
        SqlSelect = SqlTelefone
        SqlDelete = "DELETE FROM TelefoneFuncionario WHERE CodigoTelefoneFuncionario = @prmCodigo"
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)
#Disable Warning BC40000 ' Type or member is obsolete
        ExecuteDelete.Parameters.Add("@prmCodigo", VarCodigo)
#Enable Warning BC40000 ' Type or member is obsolete

        TabelaDelete(ExecuteDelete)
        LimpaTelefone()
    End Sub

    Private Sub dgvFuncionario_Click(sender As Object, e As EventArgs) Handles dgvFuncionario.Click
        VarCodigo = dgvFuncionario.CurrentRow.Cells("CodigoFuncionario").Value
        cbbCEP.SelectedValue = dgvFuncionario.CurrentRow.Cells("CodigoLogradouro").Value
        cbbFuncao.SelectedValue = dgvFuncionario.CurrentRow.Cells("CodigoFuncao").Value
        txtNomeFuncionario.Text = dgvFuncionario.CurrentRow.Cells("Nome").Value
        txtRG.Text = dgvFuncionario.CurrentRow.Cells("RG").Value
        txtCPF.Text = dgvFuncionario.CurrentRow.Cells("CPF").Value
        txtEndereco.Text = dgvFuncionario.CurrentRow.Cells("Endereço").Value
        txtBairro.Text = dgvFuncionario.CurrentRow.Cells("Bairro").Value
        txtSalario.Text = dgvFuncionario.CurrentRow.Cells("Salário").Value
        txtUsuario.Text = dgvFuncionario.CurrentRow.Cells("Usuário").Value
        txtSenha.Text = dgvFuncionario.CurrentRow.Cells("Senha").Value
        btnExcluirFuncionario.Enabled = True
        btnAlterarFuncionario.Enabled = True
    End Sub
    Private Sub LimpaMedicamento()
        txtNomeMedicamento.Text = ""
        txtQuantidadeMedicamento.Text = ""
        txtEstoqueMaximoMedicamento.Text = ""
        txtEstoqueMinimoMedicamento.Text = ""
        txtCategoriaMedicamento.Text = ""
    End Sub



    Private Sub BtnAdicionarEspecies_Click(sender As Object, e As EventArgs) Handles BtnAdicionarEspecies.Click
        SqlSelect = SqlEspecies
        SqlInsert = "INSERT INTO Especies (Descricao) VALUES (@prmDescricao)"
        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.add("@prmDescricao", TxtDescricaoEspecie.Text)

        TabelaInsert(ExecuteInsert)

        TxtDescricaoEspecie.Text = ""
    End Sub

    Private Sub BtnAlterarEspecies_Click(sender As Object, e As EventArgs) Handles BtnAlterarEspecies.Click
        SqlSelect = SqlEspecies
        SqlUpdate = "UPDATE Especies  SET Descricao = @prmDescricao WHERE CodigoEspecies = @prmCodigoEspecies"
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)

        ExecuteUpdate.Parameters.add("@prmCodigoEspecies", VarCodigo)
        ExecuteUpdate.parameters.add("@prmDescricao", TxtDescricaoEspecie.Text)


        TabelaUpdate(ExecuteUpdate)
        btnAlterarEmail.Enabled = False
        btnExcluirEmail.Enabled = False
        TxtDescricaoEspecie.Text = ""
    End Sub

    Private Sub BtnExcluirEspecies_Click(sender As Object, e As EventArgs) Handles BtnExcluirEspecies.Click
        SqlSelect = SqlEspecies
        SqlDelete = "DELETE FROM Especies WHERE CodigoEspecies = @prmCodigoEspecies"
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)

        ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigoEspecies", VarCodigo))

        TabelaDelete(ExecuteDelete)
        TxtCodigoEspecie.Text = ""
        btnAlterarEmail.Enabled = False
        btnExcluirEmail.Enabled = False
        TxtDescricaoEspecie.Text = ""
    End Sub

    Private Sub DgvEspecie_Click(sender As Object, e As EventArgs) Handles DgvEspecie.Click
        VarCodigo = DgvEspecie.CurrentRow.Cells("CodigoEspecies").Value
        TxtDescricaoEspecie.Text = DgvEspecie.CurrentRow.Cells("Descrição").Value

    End Sub

    Private Sub DgvEspecie_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEspecie.CellContentClick
        BtnAlterarEspecies.Enabled = True
        BtnExcluirEspecies.Enabled = True
    End Sub





    Private Sub btnAdicionarAnimal_Click(sender As Object, e As EventArgs) Handles btnAdicionarAnimal.Click
        SqlSelect = SqlAnimais
        SqlInsert = "INSERT INTO Animal (NomeAnimal, DescricaoAnimal, DataDeNascimentoAnimal, PesoAnimal, AlturaAnimal, GeneroAnimal, PorteAnimal, CodigoEspecies) VALUES (@prmNomeAnimal, @prmDescricaoAnimal, @prmDataDeNascimentoAnimal, @prmPesoAnimal, @prmAlturaAnimal, @prmGeneroAnimal, @prmPorteAnimal, @prmEspecieAnimal)"

        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.add("@prmNomeAnimal", TxtNomeAnimal.Text)
        ExecuteInsert.Parameters.add("@prmDescricaoAnimal", TxtDescricaoAnimal.Text)
        ExecuteInsert.Parameters.add("@prmDataDeNascimentoAnimal", DtpDataNascimentoAnimal.Text)
        ExecuteInsert.Parameters.add("@prmPesoAnimal", TxtPesoAnimal.Text)
        ExecuteInsert.Parameters.add("@prmAlturaAnimal", TxtAlturaAnimal.Text)
        ExecuteInsert.Parameters.add("@prmGeneroAnimal", CbbGeneroAnimal.Text)
        ExecuteInsert.Parameters.add("@prmPorteAnimal", CbbPorteAnimal.Text)
        ExecuteInsert.Parameters.add("@prmEspecieAnimal", CbbEspeciesAnimal.SelectedValue)

        TabelaInsert(ExecuteInsert)

        TxtCodigoCadastroAnimal.Text = ""
        TxtNomeAnimal.Text = ""
        TxtDescricaoAnimal.Text = ""
        DtpDataNascimentoAnimal.Text = ""
        TxtPesoAnimal.Text = ""
        TxtAlturaAnimal.Text = ""
        CbbGeneroAnimal.Text = ""
        CbbPorteAnimal.Text = ""
        CbbEspeciesAnimal.SelectedIndex = -1

    End Sub

    Private Sub btnAlterarAnimal_Click(sender As Object, e As EventArgs) Handles btnAlterarAnimal.Click
        SqlSelect = SqlAnimais


        SqlUpdate = "UPDATE Animal  SET NomeAnimal = @prmNomeAnimal, DescricaoAnimal = @prmDescricaoAnimal, DataDeNascimentoAnimal = @prmDataDeNascimentoAnimal, PesoAnimal = @prmPesoAnimal, AlturaAnimal = @prmAlturaAnimal, GeneroAnimal = @prmGeneroAnimal, PorteAnimal = @prmPorteAnimal, CodigoEspecies = @prmEspecieAnimal WHERE CodigoCadastroAnimal = @prmCodigoCadastroAnimal"
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)
        ExecuteUpdate.Parameters.add("@prmCodigoCadastroAnimal", TxtCodigoCadastroAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmNomeAnimal", TxtNomeAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmDescricaoAnimal", TxtDescricaoAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmDataDeNascimentoAnimal", DtpDataNascimentoAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmPesoAnimal", TxtPesoAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmAlturaAnimal", TxtAlturaAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmGeneroAnimal", CbbGeneroAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmPorteAnimal", CbbPorteAnimal.Text)
        ExecuteUpdate.Parameters.add("@prmEspecieAnimal", CbbEspeciesAnimal.SelectedValue)


        TabelaUpdate(ExecuteUpdate)

        btnAlterarAnimal.Enabled = False
        btnExcluirAnimal.Enabled = False

        TxtCodigoCadastroAnimal.Text = ""
        TxtNomeAnimal.Text = ""
        TxtDescricaoAnimal.Text = ""
        DtpDataNascimentoAnimal.Text = ""
        TxtPesoAnimal.Text = ""
        TxtAlturaAnimal.Text = ""
        CbbGeneroAnimal.Text = ""
        CbbPorteAnimal.Text = ""
        CbbEspeciesAnimal.SelectedIndex = -1
    End Sub

    Private Sub btnExcluirAnimal_Click(sender As Object, e As EventArgs) Handles btnExcluirAnimal.Click
        SqlSelect = SqlAnimais
        SqlDelete = "DELETE FROM Animal WHERE CodigoCadastroAnimal = @prmCodigoCadastroAnimal"
        ExecuteDelete = New SqlCommand(SqlDelete, cnBanco)

        ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigoCadastroAnimal", VarCodigo))

        TabelaDelete(ExecuteDelete)

        'btnAlterarAnimal.Enabled = False
        ' btnExcluirAnimal.Enabled = False

        TxtCodigoCadastroAnimal.Text = ""
        TxtNomeAnimal.Text = ""
        TxtDescricaoAnimal.Text = ""
        DtpDataNascimentoAnimal.Text = ""
        TxtPesoAnimal.Text = ""
        TxtAlturaAnimal.Text = ""
        CbbGeneroAnimal.Text = ""
        CbbPorteAnimal.Text = ""
        CbbEspeciesAnimal.SelectedIndex = -1
    End Sub

    Private Sub DgvCadastroAnimal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCadastroAnimal.CellContentClick
        btnAlterarAnimal.Enabled = True
        btnExcluirAnimal.Enabled = True
    End Sub



    Private Sub DgvCadastroAnimal_Click(sender As Object, e As EventArgs) Handles DgvCadastroAnimal.Click
        VarCodigo = DgvCadastroAnimal.CurrentRow.Cells("Codigo de Cadastro").Value

        TxtNomeAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Nome").Value
        TxtDescricaoAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Descrição").Value
        DtpDataNascimentoAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Data De Nascimento").Value
        TxtPesoAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Peso").Value
        TxtAlturaAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Altura").Value
        CbbGeneroAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Gênero").Value
        CbbPorteAnimal.Text = DgvCadastroAnimal.CurrentRow.Cells("Porte").Value
        CbbEspeciesAnimal.SelectedValue = DgvCadastroAnimal.CurrentRow.Cells("Espécie").Value
    End Sub




    Public Sub btnAdicionarFuncionario_Click(sender As Object, e As EventArgs) Handles btnAdicionarFuncionario.Click
        ExecuteInsert = New SqlCommand(SqlInsert, cnBanco)

        ExecuteInsert.Parameters.Add(New SqlParameter("@prmFuncionario", txtNomeFuncionario.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmRG", txtRG.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCPF", txtCPF.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmEndereco", txtEndereco.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmBairro", txtBairro.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCodigoLogradouro", cbbCEP.SelectedValue))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCodigoFuncao", cbbFuncao.SelectedValue))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmSalario", txtSalario.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmUsuario", txtUsuario.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmSenha", txtSenha.Text))

        TabelaInsert(ExecuteInsert)
        LimpaFuncionario()
    End Sub
    Private Sub btnAlterarFuncionario_Click(sender As Object, e As EventArgs) Handles btnAlterarFuncionario.Click
        ' Bug do Milênio encontrado nesse local
        ExecuteUpdate = New SqlCommand(SqlUpdate, cnBanco)

        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigo", VarCodigo))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmFuncionario", txtNomeFuncionario.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmRG", txtRG.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCPF", txtCPF.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmEndereco", txtEndereco.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmBairro", txtBairro.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoLogradouro", cbbCEP.SelectedValue))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmFuncao", cbbFuncao.SelectedValue))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmSalario", txtSalario.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmUsuario", txtUsuario.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmSenha", txtSenha.Text))

        TabelaUpdate(SqlUpdate)
        btnAlterarFuncionario.Enabled = False
        btnExcluirFuncionario.Enabled = False
        LimpaFuncionario()
    End Sub

    Private Sub cbbFuncionario_Click(sender As Object, e As EventArgs) Handles cbbFuncionario.Click
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionarioTableAdapter.Fill(Me.ZOOTECDataSet.Funcionario)
    End Sub

    Private Sub cbbCEP_Click(sender As Object, e As EventArgs) Handles cbbCEP.Click
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Logradouro'. Você pode movê-la ou removê-la conforme necessário.
        Me.LogradouroTableAdapter.Fill(Me.ZOOTECDataSet.Logradouro)
    End Sub

    Private Sub cbbFuncao_Click(sender As Object, e As EventArgs) Handles cbbFuncao.Click
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Funcao'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncaoTableAdapter.Fill(Me.ZOOTECDataSet.Funcao)
    End Sub
End Class