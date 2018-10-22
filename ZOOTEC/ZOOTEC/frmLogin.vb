Imports System.Data.SqlClient
Public Class frmLogin
    Dim cnBanco As SqlConnection

    Public Cargo As String = "Administrador"
    Private Sub Login()
        'Cargo = Select na funcao do usuario
    End Sub
    Private Sub ckbMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMostrarSenha.CheckedChanged
        If ckbMostrarSenha.Checked = True Then
            txtSenha.PasswordChar = ""
        Else
            txtSenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

    End Sub
End Class
