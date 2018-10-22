<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecado
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecado))
        Me.pcbFechar = New System.Windows.Forms.PictureBox()
        Me.pnlFundo = New System.Windows.Forms.Panel()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.cbbDestinatario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        CType(Me.pcbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFundo.SuspendLayout()
        Me.pnlConteudo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbFechar
        '
        Me.pcbFechar.Image = CType(resources.GetObject("pcbFechar.Image"), System.Drawing.Image)
        Me.pcbFechar.Location = New System.Drawing.Point(403, 3)
        Me.pcbFechar.Name = "pcbFechar"
        Me.pcbFechar.Size = New System.Drawing.Size(15, 15)
        Me.pcbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFechar.TabIndex = 0
        Me.pcbFechar.TabStop = False
        '
        'pnlFundo
        '
        Me.pnlFundo.Controls.Add(Me.pnlConteudo)
        Me.pnlFundo.Controls.Add(Me.pcbFechar)
        Me.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFundo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFundo.Name = "pnlFundo"
        Me.pnlFundo.Size = New System.Drawing.Size(421, 200)
        Me.pnlFundo.TabIndex = 1
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(293, 82)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'cbbDestinatario
        '
        Me.cbbDestinatario.FormattingEnabled = True
        Me.cbbDestinatario.Items.AddRange(New Object() {"Funcionário", "Veterinário", "Administrador"})
        Me.cbbDestinatario.Location = New System.Drawing.Point(268, 16)
        Me.cbbDestinatario.Name = "cbbDestinatario"
        Me.cbbDestinatario.Size = New System.Drawing.Size(121, 21)
        Me.cbbDestinatario.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destinatário"
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(6, 17)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(256, 103)
        Me.txtMensagem.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mensagem"
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Controls.Add(Me.btnEnviar)
        Me.pnlConteudo.Controls.Add(Me.cbbDestinatario)
        Me.pnlConteudo.Controls.Add(Me.Label3)
        Me.pnlConteudo.Controls.Add(Me.txtMensagem)
        Me.pnlConteudo.Controls.Add(Me.Label1)
        Me.pnlConteudo.Location = New System.Drawing.Point(3, 24)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(415, 164)
        Me.pnlConteudo.TabIndex = 8
        '
        'frmRecado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 200)
        Me.Controls.Add(Me.pnlFundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecado"
        CType(Me.pcbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFundo.ResumeLayout(False)
        Me.pnlConteudo.ResumeLayout(False)
        Me.pnlConteudo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbFechar As PictureBox
    Friend WithEvents pnlFundo As Panel
    Friend WithEvents cbbDestinatario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMensagem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents pnlConteudo As Panel
End Class
