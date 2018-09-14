Imports System.DateTime
Public Class frmRecado
    Dim datahoraAtual As DateTime = Now
    Private Sub frmRecado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
        pnlConteudo.BackColor = VClaro
    End Sub

    Private Sub pcbFechar_Click(sender As Object, e As EventArgs) Handles pcbFechar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'Insert na tabela recado com agregação do nome e função do funcionário atual mais as informações atribuídas ao form

        MessageBox.Show("o neto é gay")
    End Sub
End Class