<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.pcbVoltar = New System.Windows.Forms.PictureBox()
        Me.lblErro = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrFechar = New System.Windows.Forms.Timer(Me.components)
        Me.pnlInicio.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        CType(Me.pcbVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Prototype", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(192, 156)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'pnlInicio
        '
        Me.pnlInicio.Controls.Add(Me.btnLogin)
        Me.pnlInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInicio.Location = New System.Drawing.Point(0, 0)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(458, 239)
        Me.pnlInicio.TabIndex = 1
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.pcbVoltar)
        Me.pnlLogin.Controls.Add(Me.lblErro)
        Me.pnlLogin.Controls.Add(Me.btnEntrar)
        Me.pnlLogin.Controls.Add(Me.txtSenha)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.txtUsuario)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(458, 239)
        Me.pnlLogin.TabIndex = 1
        '
        'pcbVoltar
        '
        Me.pcbVoltar.Image = CType(resources.GetObject("pcbVoltar.Image"), System.Drawing.Image)
        Me.pcbVoltar.Location = New System.Drawing.Point(3, 3)
        Me.pcbVoltar.Name = "pcbVoltar"
        Me.pcbVoltar.Size = New System.Drawing.Size(37, 36)
        Me.pcbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbVoltar.TabIndex = 6
        Me.pcbVoltar.TabStop = False
        '
        'lblErro
        '
        Me.lblErro.AutoSize = True
        Me.lblErro.ForeColor = System.Drawing.Color.Red
        Me.lblErro.Location = New System.Drawing.Point(133, 133)
        Me.lblErro.Name = "lblErro"
        Me.lblErro.Size = New System.Drawing.Size(0, 13)
        Me.lblErro.TabIndex = 5
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(192, 156)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(133, 106)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(193, 20)
        Me.txtSenha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(133, 51)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(193, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'tmrFechar
        '
        Me.tmrFechar.Enabled = True
        Me.tmrFechar.Interval = 200
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlInicio.ResumeLayout(False)
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.pcbVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlInicio As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnEntrar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblErro As Label
    Friend WithEvents pcbVoltar As PictureBox
    Friend WithEvents tmrFechar As Timer
End Class
