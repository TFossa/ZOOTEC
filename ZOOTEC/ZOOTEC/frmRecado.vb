Imports System.Data.SqlClient
Public Class frmRecado
    Dim cnBanco As SqlConnection

    Private Sub frmRecado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
        pnlFundo.BackColor = VClaro
    End Sub

    Private Sub pcbFechar_Click(sender As Object, e As EventArgs) Handles pcbFechar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'Insert na tabela recado com agregação do nome e função do funcionário atual mais as informações atribuídas ao form

    End Sub
End Class