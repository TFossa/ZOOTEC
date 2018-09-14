Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        pnlInicio.Visible = False
        pnlLogin.Visible = True
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlInicio.Visible = True
        pnlLogin.Visible = False

        If tmrFechar.GetLifetimeService = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
            tmrFechar.Stop()
        Else
            lblErro.Text = "*Login ou senha incorreto"
        End If
    End Sub

    Private Sub pcbVoltar_Click(sender As Object, e As EventArgs) Handles pcbVoltar.Click
        pnlInicio.Visible = True
        pnlLogin.Visible = False
    End Sub

End Class
