Imports System.Data.SqlClient

Public Class frmCadastroCidade

    Dim cnBanco As New SqlConnection(conexao)

    Dim SqlInsert As String = "INSERT INTO Cidade (NomeCidade,CodigoEstado) VALUES (@prmNomeCidade,@prmCodigoEstado)"
    Dim SqlUpdate As String = "UPDATE Cidade SET NomeCidade = @prmNomeCidade , CodigoEstado = @prmCodigoEstado WHERE CodigoCidade = @prmCodigoCidade"
    Dim SqlDelete As String = "DELETE FROM Cidade WHERE CodigoCidade = @prmCodigoCidade"

    Dim ExecuteInsert As New SqlCommand(SqlInsert, cnBanco)
    Dim ExecuteDelete As New SqlCommand(SqlDelete, cnBanco)
    Dim ExecuteUpdate As New SqlCommand(SqlUpdate, cnBanco)

    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")
    Dim dtCarregaGrid As New DataTable
    Dim daPesquisaGrid As New SqlDataAdapter
    Dim cmdCidadeSelectPesquisa As New SqlCommand

    Dim colCodigoCidade, colNomeCidade, colNomeEstado, colCodigoEstado As DataColumn

    Dim Alterar As Integer
    Dim VarCodigoEstado, VarCodigoCidade As Integer

    Private Sub frmCadastroCidade_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        pnlFundo.BackColor = VEscuro
        pnlConteudo.BackColor = VClaro

    End Sub

    Private Sub frmCadastroCidade_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbbEstado.SelectedIndex = -1

        ' Organizando Grid
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Cidade")

        colCodigoCidade = dtCarregaGrid.Columns.Add("Código", GetType(Integer))
        colNomeCidade = dtCarregaGrid.Columns.Add("Cidade", GetType(String))
        colNomeEstado = dtCarregaGrid.Columns.Add("Estado", GetType(String))
        colCodigoEstado = dtCarregaGrid.Columns.Add("CodigoEstado", GetType(Integer))

        dgvCidade.DataSource = dtCarregaGrid

        dgvCidade.Columns("Código").Visible = False
        dgvCidade.Columns("Cidade").ReadOnly = True
        dgvCidade.Columns("Estado").ReadOnly = True
        dgvCidade.Columns("CodigoEstado").Visible = False

        dgvCidade.Columns("Cidade").Width = 169
        dgvCidade.Columns("Estado").Width = 169

        CarregaGrid()
    End Sub

    Private Sub HabilitarAlteracao()
        btnAlterar.Enabled = True
        btnExcluir.Enabled = True
        btnAdicionar.Enabled = False
    End Sub
    Private Sub DesabilitarAlteracao()
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnAdicionar.Enabled = True
        txtCidade.Text = ""
        cbbEstado.SelectedIndex = -1
    End Sub

    Private Sub CarregaGrid()

        Try
            cmdCidadeSelectPesquisa.CommandText = "SELECT " &
                "A.CodigoCidade AS 'Código', " &
                "A.NomeCidade AS 'Cidade', " &
                "B.NomeEstado AS 'Estado', " &
                "B.CodigoEstado AS 'CodigoEstado' " &
                "From Cidade A, Estado B " &
                "Where A.CodigoEstado = B.CodigoEstado " &
                "Order By CodigoCidade"
            cmdCidadeSelectPesquisa.Connection = cnBanco
            daPesquisaGrid.SelectCommand = cmdCidadeSelectPesquisa
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
            cmdCidadeSelectPesquisa.Parameters.Clear()
        End Try
    End Sub

    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Private Sub pcbMinimize_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dgvCidade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCidade.CellContentClick
        DesabilitarAlteracao()
    End Sub

    Private Sub cbbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEstado.SelectedIndexChanged
        VarCodigoEstado = cbbEstado.SelectedValue
    End Sub

    Private Sub btnAdicionarEstado_Click(sender As Object, e As EventArgs) Handles btnAdicionarEstado.Click
        frmCadastroEstado.Show()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoCidade", VarCodigoCidade))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmNomeCidade", txtCidade.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoEstado", VarCodigoEstado))

        Try
            cnBanco.Open()
            ExecuteUpdate.ExecuteNonQuery()
            MessageBox.Show("Dados Alterados com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro:" + ex.Message)
        Finally
            cnBanco.Close()
        End Try
        DesabilitarAlteracao()
        CarregaGrid()
        ExecuteUpdate.Parameters.Clear()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim ConfirmarExclusao As Integer = MessageBox.Show("Confirmar Exclusão", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ConfirmarExclusao = vbYes Then

            ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigoCidade", VarCodigoCidade))

            Try
                cnBanco.Open()
                ExecuteDelete.ExecuteNonQuery()
                MessageBox.Show("Dados Excluidos")
            Catch ex As Exception
                MessageBox.Show("Erro:" + ex.Message)
            Finally
                cnBanco.Close()
                ExecuteDelete.Parameters.Clear()
                CarregaGrid()
            End Try
        Else
            txtCidade.Focus()
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmNomeCidade", txtCidade.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCodigoEstado", VarCodigoEstado))
        Try
            cnBanco.Open()
            ExecuteInsert.ExecuteNonQuery()
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro:" + ex.Message, "Atenção")
        Finally
            cnBanco.Close()
            CarregaGrid()
            DesabilitarAlteracao()
            ExecuteInsert.Parameters.Clear()
        End Try
    End Sub

    Private Sub dgvCidade_Click(sender As Object, e As EventArgs) Handles dgvCidade.Click
        HabilitarAlteracao()

        VarCodigoCidade = dgvCidade.CurrentRow.Cells("Código").Value
        txtCidade.Text = dgvCidade.CurrentRow.Cells("Cidade").Value
        cbbEstado.Text = dgvCidade.CurrentRow.Cells("Estado").Value
        VarCodigoEstado = dgvCidade.CurrentRow.Cells("CodigoEstado").Value
    End Sub

    Private Sub cbbEstado_Click(sender As Object, e As EventArgs) Handles cbbEstado.Click
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Estado'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstadoTableAdapter.Fill(Me.ZOOTECDataSet.Estado)
    End Sub
End Class