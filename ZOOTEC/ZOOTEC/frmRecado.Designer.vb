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
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbbNivel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        CType(Me.pcbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConteudo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbFechar
        '
        Me.pcbFechar.Image = CType(resources.GetObject("pcbFechar.Image"), System.Drawing.Image)
        Me.pcbFechar.Location = New System.Drawing.Point(480, 3)
        Me.pcbFechar.Name = "pcbFechar"
        Me.pcbFechar.Size = New System.Drawing.Size(15, 15)
        Me.pcbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFechar.TabIndex = 0
        Me.pcbFechar.TabStop = False
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Controls.Add(Me.btnEnviar)
        Me.pnlConteudo.Controls.Add(Me.ComboBox2)
        Me.pnlConteudo.Controls.Add(Me.Label3)
        Me.pnlConteudo.Controls.Add(Me.Label2)
        Me.pnlConteudo.Controls.Add(Me.cbbNivel)
        Me.pnlConteudo.Controls.Add(Me.TextBox1)
        Me.pnlConteudo.Controls.Add(Me.Label1)
        Me.pnlConteudo.Controls.Add(Me.pcbFechar)
        Me.pnlConteudo.Location = New System.Drawing.Point(1, 1)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(498, 198)
        Me.pnlConteudo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mensagem"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 105)
        Me.TextBox1.TabIndex = 2
        '
        'cbbNivel
        '
        Me.cbbNivel.FormattingEnabled = True
        Me.cbbNivel.Items.AddRange(New Object() {"Mensagem", "Importante", "Urgente"})
        Me.cbbNivel.Location = New System.Drawing.Point(285, 41)
        Me.cbbNivel.Name = "cbbNivel"
        Me.cbbNivel.Size = New System.Drawing.Size(121, 21)
        Me.cbbNivel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destinatário"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Funcionário", "Veterinário", "Administrador"})
        Me.ComboBox2.Location = New System.Drawing.Point(285, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(209, 155)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'frmRecado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 200)
        Me.Controls.Add(Me.pnlConteudo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecado"
        CType(Me.pcbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConteudo.ResumeLayout(False)
        Me.pnlConteudo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbFechar As PictureBox
    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbNivel As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
End Class
