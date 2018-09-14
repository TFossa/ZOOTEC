Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCadastroEstado


    'conectar ao banco de dados
    Dim cnControleEstado As New SqlConnection(conexao)

    'alterações da tabela
    Dim InserirDados As String = "INSERT INTO Estado(NomeEstado,Sigla) VALUES (@prmNomeEstado,@prmSigla)"
    Dim AlterarDados As String = "UPDATE Estado set NomeEstado = @prmNomeEstado , Sigla = @prmSigla where CodigoEstado = @prmCodigoEstado"
    Dim ExcluirDados As String = "DELETE FROM Estado WHERE CodigoEstado = @prmCodigoEstado"

    'executar Comandos Sql
    Dim execInsert As New SqlCommand(InserirDados, cnControleEstado)
    Dim execUpdate As New SqlCommand(AlterarDados, cnControleEstado)

    'Configurações do Grid
    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")
    Dim dtCarregaGrid As New DataTable
    Dim daPesquisaGrid As New SqlDataAdapter
    Dim colCodigoEstado, colNomeEstado, colSigla As DataColumn
    Dim cmdCidadeSelectPesquisaGrid As New SqlCommand

    Dim Alterar As Integer

    Private Sub HabilitarControles()
        btnnovo.Enabled = False
        btncancelar.Enabled = True
        btnsalvar.Enabled = True

        txtcodigoestado.ReadOnly = True
        txtsiglaestado.ReadOnly = False
        txtnomeestado.ReadOnly = False
        txtnomeestado.Focus()
    End Sub

    Private Sub DesabilitarControles()
        btnnovo.Enabled = True
        btncancelar.Enabled = False
        btnsalvar.Enabled = False

        txtcodigoestado.ReadOnly = False
        txtsiglaestado.ReadOnly = True
        txtnomeestado.ReadOnly = True
        txtcodigoestado.Focus()
    End Sub

    Private Sub CarregaGridPesquisaEstado()
        Try
            'comando sql para variavel command
            cmdCidadeSelectPesquisaGrid.CommandText = "SELECT CodigoEstado as 'Código', NomeEstado as 'Estado', Sigla as 'Sigla' FROM Estado ORDER BY CodigoEstado"

            'instanciando a variavel de comando com conexão
            cmdCidadeSelectPesquisaGrid.Connection = cnControleEstado

            'adaptando o conteúdo
            daPesquisaGrid.SelectCommand = cmdCidadeSelectPesquisaGrid

            'zera data table
            dtCarregaGrid.Clear()
        Catch ex As Exception
            MessageBox.Show("Não foi possivel efetuar o carregamento do grid")
        End Try

        Try
            'abrindo conexão
            cnControleEstado.Open()
            'inciando a leitura da tabela
            dsCarregaGrid.Tables(0).BeginLoadData()
            'escrevendo dentro do datatable
            daPesquisaGrid.Fill(dtCarregaGrid)
            'termina leitura da tabela
            dsCarregaGrid.Tables(0).EndLoadData()
            'fechando a conexão com o banco de dados
            cnControleEstado.Close()

        Catch ErroSql As SqlException
            'mensagem de erro sql
            MessageBox.Show(ErroSql.ToString)
            'fechando conexão
            cnControleEstado.Close()
        Catch ex As Exception
            'fechando conexão
            cnControleEstado.Close()
        Finally
            'zerando os parametros da variavel command
            cmdCidadeSelectPesquisaGrid.Parameters.Clear()
        End Try
    End Sub

    Private Sub frmCadastroEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datatable Cidade
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Estado")

        'Carregando as colunas da tabela de cidade 
        colCodigoEstado = dtCarregaGrid.Columns.Add("Código", GetType(Integer))
        colNomeEstado = dtCarregaGrid.Columns.Add("Estado", GetType(String))
        colSigla = dtCarregaGrid.Columns.Add("Sigla", GetType(String))

        'Carregando o Grid com dttable de cidade 
        dgvEstado.DataSource = dtCarregaGrid

        'Criando e configurando as counas do GridView
        dgvEstado.Columns("Código").ReadOnly = True
        dgvEstado.Columns("Estado").ReadOnly = True
        dgvEstado.Columns("Sigla").ReadOnly = True

        'Definindo o tamanho das colunas
        dgvEstado.Columns("Código").Width = 70
        dgvEstado.Columns("Estado").Width = 240
        dgvEstado.Columns("Sigla").Width = 70

        'definido o alinhamento das colunas 
        dgvEstado.Columns("Código").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvEstado.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvEstado.Columns("Sigla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        CarregaGridPesquisaEstado()
    End Sub

    Private Sub frmCadastroEstado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DesabilitarControles()
    End Sub

    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        HabilitarControles()
        Alterar = 0
        txtcodigoestado.Text = ""
        txtnomeestado.Text = ""
        txtsiglaestado.Text = ""
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        HabilitarControles()
        Alterar = 1
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        DesabilitarControles()
        txtcodigoestado.Text = ""
        txtnomeestado.Text = ""
        txtsiglaestado.Text = ""
    End Sub

    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        'receber resultado do click do messagebox
        'saber o q o usuário quer fazer0
        Dim intConfExlusao As Integer = MessageBox.Show("Confirmar exclusão do registro corrente", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If intConfExlusao = vbYes Then
            'instanciando a variavel do tipo cmd com a string com o comando sql e sua conexão
            Dim ExecutarComando As New SqlCommand(ExcluirDados, cnControleEstado)
            'passando parametros
            ExecutarComando.Parameters.Add(New SqlParameter("@prmCodigoEstado", txtcodigoestado.Text))

            Try
                cnControleEstado.Open()
                'executar insert
                ExecutarComando.ExecuteNonQuery()

                MessageBox.Show("Dados excluidos com sucesso!")
            Catch ex As Exception
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                cnControleEstado.Close()
            End Try
            CarregaGridPesquisaEstado()
        Else
            dgvEstado.Focus()
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click

        If Alterar = 0 Then

            'passar os parametros
            execInsert.Parameters.Add(New SqlParameter("@prmNomeEstado", txtnomeestado.Text))
            execInsert.Parameters.Add(New SqlParameter("@prmSigla", txtsiglaestado.Text))
            Try
                'abre conexão
                cnControleEstado.Open()
                'executar insert
                execInsert.ExecuteNonQuery()
                'inseriu com sucesso
                MessageBox.Show("Dados inseridos com sucesso!")
            Catch ex As Exception
                'ERRO
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                'fechando a conexão
                cnControleEstado.Close()
                CarregaGridPesquisaEstado()
                DesabilitarControles()
                execInsert.Parameters.Clear()
            End Try
        End If

        If Alterar = 1 Then
            'instanciando a variavel do tipo cmd com a string command
            'sql e a sua conexão
            execUpdate.Parameters.Add(New SqlParameter("@prmCodigoEstado", txtcodigoestado.Text))
            execUpdate.Parameters.Add(New SqlParameter("@prmNomeEstado", txtnomeestado.Text))
            execUpdate.Parameters.Add(New SqlParameter("@prmSigla", txtsiglaestado.Text))

            Try
                'abre conexão
                cnControleEstado.Open()

                'executar insert
                execUpdate.ExecuteNonQuery()

                'sucesso
                MessageBox.Show("Dados Alterados com sucesso!")

            Catch ex As Exception
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                cnControleEstado.Close()
            End Try
            DesabilitarControles()
            CarregaGridPesquisaEstado()
            execUpdate.Parameters.Clear()
        End If
    End Sub

    Private Sub dgvEstado_Click(sender As Object, e As EventArgs) Handles dgvEstado.Click
        'habilita o botão alterar
        btnalterar.Enabled = True
        'habilita o botão excluir
        btnexcluir.Enabled = True
        'pega o valorda coluna do grid e passa para o text box
        txtcodigoestado.Text = dgvEstado.CurrentRow.Cells("Código").Value
        txtnomeestado.Text = dgvEstado.CurrentRow.Cells("Estado").Value
        txtsiglaestado.Text = dgvEstado.CurrentRow.Cells("Sigla").Value
    End Sub

End Class