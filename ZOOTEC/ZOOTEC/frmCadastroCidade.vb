Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCadastroCidade
    'declarando variavel sqlconnection  
    Dim cnControleEstoque As New SqlConnection(conexao)

    'declarando string para inserir dados
    Dim InserirDados As String = "INSERT INTO Cidade(NomeCidade) VALUES (@prmNomeCidade)"

    'declarando a string para alterar dados
    Dim AlterarDados As String = "UPDATE Cidade set NomeCidade = @prmNomeCidade where CodigoCidade = @prmCodigoCidade"

    'declarando a variavel do tipo command
    Dim ExecutarInsert As New SqlCommand(InserirDados, cnControleEstoque)
    Dim ExecutarUpdate As New SqlCommand(AlterarDados, cnControleEstoque)

    'criando dataset para manipulação do grid
    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")

    'criando a variavel q vai conter a tabela cidade
    Dim dtCarregaGridCidade As New DataTable

    'criando o objeto adapter da tabela cidade
    Dim daPesquisaCidadeGrid As New SqlDataAdapter

    'criando as colunas da tabela
    Dim colCodigoCidade, colNomeCidade As DataColumn

    'criando variavel com instrução sql
    Dim cmdCidadeSelectPesquisaGrid As New SqlCommand

    'variavel para controles dos botões
    Dim intBtnIncluirAlterar As Integer
    Dim ExcluirDados As String = "DELETE FROM Cidade WHERE CodigoCidade = @prmCodigoCidade"

    Private Sub HabilitarControles()
        btnnovo.Enabled = False
        btncancelar.Enabled = True
        btnsalvar.Enabled = True

        txtnomecidade.ReadOnly = False
        txtcodigocidade.ReadOnly = True
        txtnomecidade.Focus()

    End Sub
    Private Sub DesabilitaControles()
        txtcodigocidade.Focus()
        txtcodigocidade.ReadOnly = False
        txtnomecidade.ReadOnly = True

        btnalterar.Enabled = False
        btnsalvar.Enabled = False
        btndelete.Enabled = False
        btncancelar.Enabled = False
        btnnovo.Enabled = True
    End Sub

    Private Sub frmCadastroCidade_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DesabilitaControles()
    End Sub

    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        HabilitarControles()
        intBtnIncluirAlterar = 0
        txtnomecidade.Text = ""
    End Sub

    Private Sub frmCadastroCidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datatable Cidade
        dtCarregaGridCidade = dsCarregaGrid.Tables.Add("Cidades")

        'Carregando as colunas da tabela de cidade 
        colCodigoCidade = dtCarregaGridCidade.Columns.Add("Código", GetType(Integer))
        colNomeCidade = dtCarregaGridCidade.Columns.Add("Nome", GetType(String))

        'Carregando o Grid com dttable de cidade 
        dgvCidade.DataSource = dtCarregaGridCidade

        'Criando e configurando as counas do GridView
        dgvCidade.Columns("Código").ReadOnly = True
        dgvCidade.Columns("Nome").ReadOnly = True

        'Definindo o tamanho das colunas
        dgvCidade.Columns("Código").Width = 70
        dgvCidade.Columns("Nome").Width = 240

        'definido o alinhamento das colunas 
        dgvCidade.Columns("Código").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCidade.Columns("Nome").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        CarregaGridPesquisaCidade()
    End Sub

    Private Sub CarregaGridPesquisaCidade()
        Try
            'comando sql para variavel command
            cmdCidadeSelectPesquisaGrid.CommandText = "SELECT CodigoCidade as 'Código', NomeCidade as 'Nome' FROM Cidade ORDER BY CodigoCidade"

            'instanciando a variavel de comando com conexão
            cmdCidadeSelectPesquisaGrid.Connection = cnControleEstoque

            'adaptando o conteúdo
            daPesquisaCidadeGrid.SelectCommand = cmdCidadeSelectPesquisaGrid

            'zera data table
            dtCarregaGridCidade.Clear()
        Catch ex As Exception
            MessageBox.Show("Não foi possivel efetuar o carregamento do grid")
        End Try

        Try
            'abrindo conexão
            cnControleEstoque.Open()
            'inciando a leitura da tabela
            dsCarregaGrid.Tables(0).BeginLoadData()
            'escrevendo dentro do datatable
            daPesquisaCidadeGrid.Fill(dtCarregaGridCidade)
            'termina leitura da tabela
            dsCarregaGrid.Tables(0).EndLoadData()
            'fechando a conexão com o banco de dados
            cnControleEstoque.Close()

        Catch ErroSql As SqlException
            'mensagem de erro sql
            MessageBox.Show(ErroSql.ToString)
            'fechando conexão
            cnControleEstoque.Close()
        Catch ex As Exception
            'fechando conexão
            cnControleEstoque.Close()
        Finally
            'zerando os parametros da variavel command
            cmdCidadeSelectPesquisaGrid.Parameters.Clear()
        End Try
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        HabilitarControles()
        intBtnIncluirAlterar = 1
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        DesabilitaControles()
        txtcodigocidade.Text = ""
        txtnomecidade.Text = ""
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click

        If intBtnIncluirAlterar = 0 Then

            'passar os parametros
            ExecutarInsert.Parameters.Add(New SqlParameter("@prmNomeCidade", txtnomecidade.Text))
            Try
                'abre conexão
                cnControleEstoque.Open()
                'executar insert
                ExecutarInsert.ExecuteNonQuery()
                'inseriu com sucesso
                MessageBox.Show("Dados inseridos com sucesso!")
            Catch ex As Exception
                'ERRO
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                'fechando a conexão
                cnControleEstoque.Close()
                CarregaGridPesquisaCidade()
                DesabilitaControles()
                ExecutarInsert.Parameters.Clear()
            End Try
        End If

        If intBtnIncluirAlterar = 1 Then
            'instanciando a variavel do tipo cmd com a string command
            'sql e a sua conexão
            ExecutarUpdate.Parameters.Add(New SqlParameter("@prmCodigoCidade", txtcodigocidade.Text))
            ExecutarUpdate.Parameters.Add(New SqlParameter("@prmNomeCidade", txtnomecidade.Text))

            Try
                'abre conexão
                cnControleEstoque.Open()

                'executar insert
                ExecutarUpdate.ExecuteNonQuery()

                'sucesso
                MessageBox.Show("Dados Alterados com sucesso!")

            Catch ex As Exception
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                cnControleEstoque.Close()
            End Try
            DesabilitaControles()
            CarregaGridPesquisaCidade()
            ExecutarUpdate.Parameters.Clear()
        End If


    End Sub


    Private Sub dgvCidade_Click(sender As Object, e As EventArgs) Handles dgvCidade.Click
        'habilita o botão alterar
        btnalterar.Enabled = True
        'habilita o botão excluir
        btndelete.Enabled = True
        'pega o valorda coluna do grid e passa para o text box
        txtcodigocidade.Text = dgvCidade.CurrentRow.Cells("Código").Value
        txtnomecidade.Text = dgvCidade.CurrentRow.Cells("Nome").Value
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'receber resultado do click do messagebox
        'saber o q o usuário quer fazer0
        Dim intConfExlusao As Integer = MessageBox.Show("Confirmar exclusão do registro corrente", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If intConfExlusao = vbYes Then
            'instanciando a variavel do tipo cmd com a string com o comando sql e sua conexão
            Dim ExecutarComando As New SqlCommand(ExcluirDados, cnControleEstoque)
            'passando parametros
            ExecutarComando.Parameters.Add(New SqlParameter("@prmCodigoCidade", txtcodigocidade.Text))

            Try
                cnControleEstoque.Open()
                'executar insert
                ExecutarComando.ExecuteNonQuery()

                MessageBox.Show("Dados excluidos com sucesso!")
            Catch ex As Exception
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                cnControleEstoque.Close()
            End Try
            CarregaGridPesquisaCidade()
        Else
            dgvCidade.Focus()
        End If
    End Sub
End Class