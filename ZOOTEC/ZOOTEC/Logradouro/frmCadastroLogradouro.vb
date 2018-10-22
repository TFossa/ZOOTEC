Imports System.Data.SqlClient
Public Class frmCadastroLogradouro
    Dim cnBanco As New SqlConnection(conexao)

    Dim SqlInsert As String = "INSERT INTO Logradouro (CEP,CodigoCidade) VALUES (@prmCEP,@prmCodigoCidade)"
    Dim SqlUpdate As String = "UPDATE Logradouro SET CEP = @prmCEP, CodigoCidade = @prmCodigoCidade WHERE CodigoLogradouro = @prmCodigoLogradouro"
    Dim SqlDelete As String = "DELETE FROM Logradouro WHERE CodigoLogradouro = @prmCodigoLogradouro"

    Dim ExecuteInsert As New SqlCommand(SqlInsert, cnBanco)
    Dim ExecuteDelete As New SqlCommand(SqlDelete, cnBanco)
    Dim ExecuteUpdate As New SqlCommand(SqlUpdate, cnBanco)

    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")
    Dim dtCarregaGrid As New DataTable
    Dim daPesquisaGrid As New SqlDataAdapter
    Dim cmdLogradouroPesquisaGrid As New SqlCommand

    Dim colCodigoLogradouro, colCodigoCidade, colCodigoEstado As DataColumn
    Dim colCEP, colCidade, colEstado As DataColumn

    Dim Alterar As Integer
    Dim VarCodigoLogradouro, VarCodigoCidade As Integer
    Private Sub frmCadastroLogradouro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbCidade.SelectedIndex = -1

        ' Organizando Grid
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Logradouro")

        colCodigoCidade = dtCarregaGrid.Columns.Add("Código", GetType(Integer))
        colCEP = dtCarregaGrid.Columns.Add("CEP", GetType(String))
        colCidade = dtCarregaGrid.Columns.Add("Cidade", GetType(String))
        colEstado = dtCarregaGrid.Columns.Add("Estado", GetType(String))
        colCodigoCidade = dtCarregaGrid.Columns.Add("CodigoCidade", GetType(Integer))
        colCodigoEstado = dtCarregaGrid.Columns.Add("CodigoEstado", GetType(Integer))

        dgvLogradouro.DataSource = dtCarregaGrid

        dgvLogradouro.Columns("Código").Visible = False
        dgvLogradouro.Columns("CEP").ReadOnly = True
        dgvLogradouro.Columns("Cidade").ReadOnly = True
        dgvLogradouro.Columns("Estado").ReadOnly = True
        dgvLogradouro.Columns("CodigoEstado").Visible = False
        dgvLogradouro.Columns("CodigoCidade").Visible = False

        dgvLogradouro.Columns("CEP").Width = 131
        dgvLogradouro.Columns("Cidade").Width = 131
        dgvLogradouro.Columns("Estado").Width = 132

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
        mskCEP.Clear()
        cbbCidade.SelectedIndex = -1
    End Sub

    Private Sub CarregaGrid()

        Try
            cmdLogradouroPesquisaGrid.CommandText = "SELECT CodigoLogradouro AS 'Código', " &
                "A.CEP AS 'CEP', " &
                "B.CodigoCidade AS 'CodigoCidade', " &
                "B.NomeCidade AS 'Cidade', " &
                "C.NomeEstado 'Estado' " &
                "FROM Logradouro A, Cidade B, Estado C " &
                "WHERE A.CodigoCidade = B.CodigoCidade AND B.CodigoEstado = C.CodigoEstado " &
                "ORDER BY CodigoLogradouro"
            cmdLogradouroPesquisaGrid.Connection = cnBanco
            daPesquisaGrid.SelectCommand = cmdLogradouroPesquisaGrid
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
            cmdLogradouroPesquisaGrid.Parameters.Clear()
        End Try
    End Sub

    Private Sub cbbCidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCidade.SelectedIndexChanged
        VarCodigoCidade = cbbCidade.SelectedValue
    End Sub

    Private Sub frmCadastroLogradouro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        pnlFundo.BackColor = VEscuro
        pnlConteudo.BackColor = VClaro
    End Sub

    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Private Sub pcbMinimize_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAdicionarCidade_Click(sender As Object, e As EventArgs) Handles btnAdicionarCidade.Click
        frmCadastroCidade.Show()
    End Sub

    Private Sub dgvLogradouro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogradouro.CellContentClick
        DesabilitarAlteracao()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoLogradouro", VarCodigoLogradouro))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCEP", mskCEP.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoCidade", VarCodigoCidade))

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

            ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigoLogradouro", VarCodigoLogradouro))

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
        End If
        mskCEP.Focus()
        DesabilitarAlteracao()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCEP", mskCEP.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmCodigoCidade", VarCodigoCidade))
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

    Private Sub dgvLogradouro_Click(sender As Object, e As EventArgs) Handles dgvLogradouro.Click
        HabilitarAlteracao()

        VarCodigoLogradouro = dgvLogradouro.CurrentRow.Cells("Código").Value
        mskCEP.Text = dgvLogradouro.CurrentRow.Cells("CEP").Value
        cbbCidade.Text = dgvLogradouro.CurrentRow.Cells("Cidade").Value
        VarCodigoCidade = dgvLogradouro.CurrentRow.Cells("CodigoCidade").Value
    End Sub

    Private Sub cbbCidade_Click(sender As Object, e As EventArgs) Handles cbbCidade.Click
        'TODO: esta linha de código carrega dados na tabela 'ZOOTECDataSet.Cidade'. Você pode movê-la ou removê-la conforme necessário.
        Me.CidadeTableAdapter.Fill(Me.ZOOTECDataSet.Cidade)
    End Sub
End Class