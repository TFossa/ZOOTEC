Public Class frmMenu
    'Variável que salva o Tipo de Login
    Dim TipoLogin As String

    Private Sub AtivarControles()
        btnCadastroDeAlimentos.Visible = True
        btnCadastroDeAnimais.Visible = True
        btnEstoque.Visible = True
        btnAnimais.Visible = True
        btnInicio.Visible = True
        btnCadastroDeFarmacos.Visible = True
        btnCadastroDeFuncionarios.Visible = True
        btnCadastroDeVeterinários.Visible = True
        btnMedicamentosEVacinas.Visible = True
        btnVeterinários.Visible = True
        btnFuncionarios.Visible = True
    End Sub

    Private Sub EsconderPaineis()
        pnlInicio.Visible = False
        pnlCadastroDeAlimentos.Visible = False
        pnlCadastroDeAnimais.Visible = False
        pnlEstoque.Visible = False
        pnlAnimais.Visible = False
        pnlCadastroDeFarmacos.Visible = False
        pnlCadastroDeFuncionarios.Visible = False
        pnlCadastroDeVeterinarios.Visible = False
        pnlFuncionarios.Visible = False
        pnlMedicamentosEVacinas.Visible = False
        pnlVeterinários.Visible = False
    End Sub

    Private Sub EscurecerBotoes()
        btnCadastroDeAlimentos.BackColor = VEscuro
        btnCadastroDeAnimais.BackColor = VEscuro
        btnEstoque.BackColor = VEscuro
        btnAnimais.BackColor = VEscuro
        btnInicio.BackColor = VEscuro
        btnCadastroDeFarmacos.BackColor = VEscuro
        btnCadastroDeFuncionarios.BackColor = VEscuro
        btnCadastroDeVeterinários.BackColor = VEscuro
        btnMedicamentosEVacinas.BackColor = VEscuro
        btnVeterinários.BackColor = VEscuro
        btnFuncionarios.BackColor = VEscuro
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Colorindo objetos em RGB
        pnlTop.BackColor = VEscuro
        pnlBottom.BackColor = VEscuro
        pnlMenu.BackColor = VEscuro

        pnlInicio.BackColor = VClaro
        pnlInicio.BackColor = VClaro
        pnlCadastroDeAlimentos.BackColor = VClaro
        pnlCadastroDeAnimais.BackColor = VClaro
        pnlEstoque.BackColor = VClaro
        pnlAnimais.BackColor = VClaro
        pnlCadastroDeFarmacos.BackColor = VClaro
        pnlCadastroDeFuncionarios.BackColor = VClaro
        pnlCadastroDeVeterinarios.BackColor = VClaro
        pnlFuncionarios.BackColor = VClaro
        pnlMedicamentosEVacinas.BackColor = VClaro
        pnlVeterinários.BackColor = VClaro

        EscurecerBotoes()
        btnInicio.BackColor = VClaro

        'visibilidade dos painéis
        EsconderPaineis()
        pnlInicio.Visible = True
        pnlMenu.Visible = True

        'Remover Escurecimento do botão
        btnCadastroDeAlimentos.FlatAppearance.MouseOverBackColor = VClaro
        btnCadastroDeAnimais.FlatAppearance.MouseOverBackColor = VClaro
        btnEstoque.FlatAppearance.MouseOverBackColor = VClaro
        btnAnimais.FlatAppearance.MouseOverBackColor = VClaro
        btnInicio.FlatAppearance.MouseOverBackColor = VClaro
        btnCadastroDeFarmacos.FlatAppearance.MouseOverBackColor = VClaro
        btnCadastroDeFuncionarios.FlatAppearance.MouseOverBackColor = VClaro
        btnCadastroDeVeterinários.FlatAppearance.MouseOverBackColor = VClaro
        btnMedicamentosEVacinas.FlatAppearance.MouseOverBackColor = VClaro
        btnVeterinários.FlatAppearance.MouseOverBackColor = VClaro
        btnFuncionarios.FlatAppearance.MouseOverBackColor = VClaro

        btnCadastroDeAlimentos.FlatAppearance.MouseDownBackColor = VClaro
        btnCadastroDeAnimais.FlatAppearance.MouseDownBackColor = VClaro
        btnEstoque.FlatAppearance.MouseDownBackColor = VClaro
        btnAnimais.FlatAppearance.MouseDownBackColor = VClaro
        btnInicio.FlatAppearance.MouseDownBackColor = VClaro
        btnCadastroDeFarmacos.FlatAppearance.MouseDownBackColor = VClaro
        btnCadastroDeFuncionarios.FlatAppearance.MouseDownBackColor = VClaro
        btnCadastroDeVeterinários.FlatAppearance.MouseDownBackColor = VClaro
        btnMedicamentosEVacinas.FlatAppearance.MouseDownBackColor = VClaro
        btnVeterinários.FlatAppearance.MouseDownBackColor = VClaro
        btnFuncionarios.FlatAppearance.MouseDownBackColor = VClaro

        'Verificação do Login
        'Configurar banco de dados para verificar o tipo de usuário
        TipoLogin = "Administrador"
        'Modificar Nome de Usuário para aparecer o nome do funcionario e veterinário
        If TipoLogin = "Administrador" Then
            'Definindo os controles do usuário
            AtivarControles()

            'Editando Credenciais
            pcbUsuário.Image = My.Resources.Admin
            lblUsuario.Text = "Administrador"
        ElseIf TipoLogin = "Veterinário" Then
            'Definindo os controles do usuário
            AtivarControles()
            btnCadastroDeFuncionarios.Visible = False
            btnCadastroDeVeterinários.Visible = False
            btnVeterinários.Visible = False
            btnFuncionarios.Visible = False

            'Editando Credenciais
            pcbUsuário.Image = My.Resources.Female
            lblUsuario.Text = "Veterinário"
        ElseIf TipoLogin = "Funcionário" Then
            'Definindo os controles do usuário
            AtivarControles()
            btnCadastroDeAlimentos.Visible = False
            btnCadastroDeAnimais.Visible = False
            btnCadastroDeFarmacos.Visible = False
            btnCadastroDeFuncionarios.Visible = False
            btnCadastroDeVeterinários.Visible = False
            btnVeterinários.Visible = False
            btnFuncionarios.Visible = False

            'Editando Credenciais
            pcbUsuário.Image = My.Resources.Male
            lblUsuario.Text = "Funcionário"
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlInicio.Visible = True
        btnInicio.BackColor = VClaro

    End Sub

    Private Sub btnCadastroDeAnimais_Click(sender As Object, e As EventArgs) Handles btnCadastroDeAnimais.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlCadastroDeAnimais.Visible = True
        btnCadastroDeAnimais.BackColor = VClaro
    End Sub

    Private Sub btnTabelaDeAnimais_Click(sender As Object, e As EventArgs) Handles btnAnimais.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlAnimais.Visible = True
        btnAnimais.BackColor = VClaro
    End Sub

    Private Sub btnCadastroDeAlimentos_Click(sender As Object, e As EventArgs) Handles btnCadastroDeAlimentos.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlCadastroDeAlimentos.Visible = True
        btnCadastroDeAlimentos.BackColor = VClaro
    End Sub

    Private Sub btnEstoqueDeAlimentos_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlEstoque.Visible = True
        btnEstoque.BackColor = VClaro
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Private Sub frmMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMedicamentosEVacinas_Click(sender As Object, e As EventArgs) Handles btnMedicamentosEVacinas.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlMedicamentosEVacinas.Visible = True
        btnMedicamentosEVacinas.BackColor = VClaro
    End Sub

    Private Sub btnFuncionarios_Click(sender As Object, e As EventArgs) Handles btnFuncionarios.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlFuncionarios.Visible = True
        btnFuncionarios.BackColor = VClaro
    End Sub

    Private Sub btnVeterinários_Click(sender As Object, e As EventArgs) Handles btnVeterinários.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlVeterinários.Visible = True
        btnVeterinários.BackColor = VClaro
    End Sub

    Private Sub btnCadastroDeFuncionarios_Click(sender As Object, e As EventArgs) Handles btnCadastroDeFuncionarios.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlCadastroDeFuncionarios.Visible = True
        btnCadastroDeFuncionarios.BackColor = VClaro
    End Sub

    Private Sub btnCadastroDeVeterinários_Click(sender As Object, e As EventArgs) Handles btnCadastroDeVeterinários.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlCadastroDeVeterinarios.Visible = True
        btnCadastroDeVeterinários.BackColor = VClaro
    End Sub

    Private Sub btnCadastroDeFarmacos_Click(sender As Object, e As EventArgs) Handles btnCadastroDeFarmacos.Click
        EsconderPaineis()
        EscurecerBotoes()
        pnlCadastroDeFarmacos.Visible = True
        btnCadastroDeFarmacos.BackColor = VClaro
    End Sub

    Private Sub btnNovoRecado_Click(sender As Object, e As EventArgs) Handles btnNovoRecado.Click
        frmRecado.Show()
    End Sub

    Private Sub pnlCadastroDeFuncionarios_Paint(sender As Object, e As PaintEventArgs) Handles pnlCadastroDeFuncionarios.Paint

    End Sub
End Class
