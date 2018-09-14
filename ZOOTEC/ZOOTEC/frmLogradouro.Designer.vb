<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogradouro
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCadastroDeEstado = New System.Windows.Forms.Button()
        Me.BtnCadastroDeCidade = New System.Windows.Forms.Button()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.cbbEstado = New System.Windows.Forms.ComboBox()
        Me.cbbCidade = New System.Windows.Forms.ComboBox()
        Me.txtCodigoCEP = New System.Windows.Forms.TextBox()
        Me.lblCodigoCEP = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvLogradouro = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvLogradouro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(501, 208)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnSalvar)
        Me.TabPage1.Controls.Add(Me.BtnCadastroDeEstado)
        Me.TabPage1.Controls.Add(Me.BtnCadastroDeCidade)
        Me.TabPage1.Controls.Add(Me.mskCEP)
        Me.TabPage1.Controls.Add(Me.cbbEstado)
        Me.TabPage1.Controls.Add(Me.cbbCidade)
        Me.TabPage1.Controls.Add(Me.txtCodigoCEP)
        Me.TabPage1.Controls.Add(Me.lblCodigoCEP)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.lblCEP)
        Me.TabPage1.Controls.Add(Me.lblEstado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(493, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(357, 13)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(102, 41)
        Me.BtnSalvar.TabIndex = 12
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCadastroDeEstado
        '
        Me.BtnCadastroDeEstado.Location = New System.Drawing.Point(357, 118)
        Me.BtnCadastroDeEstado.Name = "BtnCadastroDeEstado"
        Me.BtnCadastroDeEstado.Size = New System.Drawing.Size(102, 41)
        Me.BtnCadastroDeEstado.TabIndex = 11
        Me.BtnCadastroDeEstado.Text = "Cadastro De Estado"
        Me.BtnCadastroDeEstado.UseVisualStyleBackColor = True
        '
        'BtnCadastroDeCidade
        '
        Me.BtnCadastroDeCidade.Location = New System.Drawing.Point(357, 64)
        Me.BtnCadastroDeCidade.Name = "BtnCadastroDeCidade"
        Me.BtnCadastroDeCidade.Size = New System.Drawing.Size(102, 41)
        Me.BtnCadastroDeCidade.TabIndex = 10
        Me.BtnCadastroDeCidade.Text = "Cadastro de Cidade"
        Me.BtnCadastroDeCidade.UseVisualStyleBackColor = True
        '
        'mskCEP
        '
        Me.mskCEP.Location = New System.Drawing.Point(170, 80)
        Me.mskCEP.Mask = "99999-999"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(133, 20)
        Me.mskCEP.TabIndex = 9
        '
        'cbbEstado
        '
        Me.cbbEstado.FormattingEnabled = True
        Me.cbbEstado.Location = New System.Drawing.Point(170, 134)
        Me.cbbEstado.Name = "cbbEstado"
        Me.cbbEstado.Size = New System.Drawing.Size(133, 21)
        Me.cbbEstado.TabIndex = 8
        '
        'cbbCidade
        '
        Me.cbbCidade.FormattingEnabled = True
        Me.cbbCidade.Location = New System.Drawing.Point(31, 134)
        Me.cbbCidade.Name = "cbbCidade"
        Me.cbbCidade.Size = New System.Drawing.Size(121, 21)
        Me.cbbCidade.TabIndex = 7
        '
        'txtCodigoCEP
        '
        Me.txtCodigoCEP.Location = New System.Drawing.Point(31, 81)
        Me.txtCodigoCEP.Name = "txtCodigoCEP"
        Me.txtCodigoCEP.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigoCEP.TabIndex = 5
        '
        'lblCodigoCEP
        '
        Me.lblCodigoCEP.AutoSize = True
        Me.lblCodigoCEP.Location = New System.Drawing.Point(28, 64)
        Me.lblCodigoCEP.Name = "lblCodigoCEP"
        Me.lblCodigoCEP.Size = New System.Drawing.Size(64, 13)
        Me.lblCodigoCEP.TabIndex = 3
        Me.lblCodigoCEP.Text = "Código CEP"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(32, 118)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 2
        Me.lblCidade.Text = "Cidade"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(167, 64)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(28, 13)
        Me.lblCEP.TabIndex = 1
        Me.lblCEP.Text = "CEP"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(167, 118)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 0
        Me.lblEstado.Text = "Estado"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvLogradouro)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(493, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesquisa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvLogradouro
        '
        Me.dgvLogradouro.AllowUserToAddRows = False
        Me.dgvLogradouro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogradouro.Location = New System.Drawing.Point(7, 4)
        Me.dgvLogradouro.Name = "dgvLogradouro"
        Me.dgvLogradouro.ReadOnly = True
        Me.dgvLogradouro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogradouro.Size = New System.Drawing.Size(433, 258)
        Me.dgvLogradouro.TabIndex = 0
        '
        'Logradouro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 224)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Logradouro"
        Me.Text = "Logradouro"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvLogradouro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCadastroDeEstado As Button
    Friend WithEvents BtnCadastroDeCidade As Button
    Friend WithEvents mskCEP As MaskedTextBox
    Friend WithEvents cbbEstado As ComboBox
    Friend WithEvents cbbCidade As ComboBox
    Friend WithEvents txtCodigoCEP As TextBox
    Friend WithEvents lblCodigoCEP As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblCEP As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvLogradouro As DataGridView
End Class
