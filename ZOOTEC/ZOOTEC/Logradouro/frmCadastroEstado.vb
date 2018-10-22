Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCadastroEstado

    Dim cnBanco As New SqlConnection(conexao)

    Dim SqlInsert As String = "INSERT INTO Estado (NomeEstado,SiglaEstado) VALUES (@prmNomeEstado,@prmSigla)"
    Dim SqlUpdate As String = "UPDATE Estado SET NomeEstado = @prmNomeEstado , SiglaEstado = @prmSigla WHERE CodigoEstado = @prmCodigoEstado"
    Dim SqlDelete As String = "DELETE FROM Estado WHERE CodigoEstado = @prmCodigoEstado"

    Dim ExecuteInsert As New SqlCommand(SqlInsert, cnBanco)
    Dim ExecuteDelete As New SqlCommand(SqlDelete, cnBanco)
    Dim ExecuteUpdate As New SqlCommand(SqlUpdate, cnBanco)

    Dim dsCarregaGrid As New DataSet("dsCarregaGrid")
    Dim dtCarregaGrid As New DataTable
    Dim daPesquisaGrid As New SqlDataAdapter
    Dim cmdEstadoSelectPesquisa As New SqlCommand

    Dim colCodigoEstado, colNomeEstado, colSigla As DataColumn

    Dim Alterar As Integer
    Dim VarCodigoEstado As Integer
    Private Sub frmCadastroEstado_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Organizando Grid
        dtCarregaGrid = dsCarregaGrid.Tables.Add("Estado")

        colCodigoEstado = dtCarregaGrid.Columns.Add("Código", GetType(Integer))
        colNomeEstado = dtCarregaGrid.Columns.Add("Estado", GetType(String))
        colSigla = dtCarregaGrid.Columns.Add("Sigla", GetType(String))

        dgvEstado.DataSource = dtCarregaGrid

        dgvEstado.Columns("Código").Visible = True
        dgvEstado.Columns("Estado").ReadOnly = True
        dgvEstado.Columns("Sigla").ReadOnly = True

        dgvEstado.Columns("Estado").Width = 172
        dgvEstado.Columns("Sigla").Width = 171

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
    End Sub

    Private Sub CarregaGrid()

        Try
            cmdEstadoSelectPesquisa.CommandText = "SELECT CodigoEstado AS 'Código', NomeEstado AS 'Estado', SiglaEstado AS 'Sigla' FROM Estado"
            cmdEstadoSelectPesquisa.Connection = cnBanco
            daPesquisaGrid.SelectCommand = cmdEstadoSelectPesquisa
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
            cmdEstadoSelectPesquisa.Parameters.Clear()
        End Try
    End Sub
    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Private Sub pcbMinimize_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dgvEstado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstado.CellContentClick
        DesabilitarAlteracao()
    End Sub

    Private Sub frmCadastroEstado_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ' Configuração padrão
        pnlFundo.BackColor = VClaro
        pnlConteudo.BackColor = VEscuro
        DesabilitarAlteracao()

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmCodigoEstado", VarCodigoEstado))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmNomeEstado", txtNomeEstado.Text))
        ExecuteUpdate.Parameters.Add(New SqlParameter("@prmSigla", txtSigla.Text))

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

            ExecuteDelete.Parameters.Add(New SqlParameter("@prmCodigoEstado", VarCodigoEstado))

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
            dgvEstado.Focus()
        End If

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        ExecuteInsert.Parameters.Add(New SqlParameter("@prmNomeEstado", txtNomeEstado.Text))
        ExecuteInsert.Parameters.Add(New SqlParameter("@prmSigla", txtSigla.Text))
        Try
            cnBanco.Open()
            ExecuteInsert.ExecuteNonQuery()
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro:", "" + ex.Message)
        Finally
            cnBanco.Close()
            CarregaGrid()
            DesabilitarAlteracao()
            ExecuteInsert.Parameters.Clear()
        End Try

    End Sub

    Private Sub dgvEstado_Click(sender As Object, e As EventArgs) Handles dgvEstado.Click

        HabilitarAlteracao()

        VarCodigoEstado = dgvEstado.CurrentRow.Cells("Código").Value
        txtNomeEstado.Text = dgvEstado.CurrentRow.Cells("Estado").Value
        txtSigla.Text = dgvEstado.CurrentRow.Cells("Sigla").Value
    End Sub
End Class