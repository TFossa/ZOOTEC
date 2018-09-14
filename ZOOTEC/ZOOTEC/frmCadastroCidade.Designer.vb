<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroCidade
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.txtnomecidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigocidade = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvCidade = New System.Windows.Forms.DataGridView()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvCidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(418, 270)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnsalvar)
        Me.TabPage1.Controls.Add(Me.btndelete)
        Me.TabPage1.Controls.Add(Me.btncancelar)
        Me.TabPage1.Controls.Add(Me.btnalterar)
        Me.TabPage1.Controls.Add(Me.btnnovo)
        Me.TabPage1.Controls.Add(Me.txtnomecidade)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtcodigocidade)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(410, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalvar.Location = New System.Drawing.Point(259, 129)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(75, 36)
        Me.btnsalvar.TabIndex = 8
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(301, 87)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 36)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "Excluir"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(220, 87)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 36)
        Me.btncancelar.TabIndex = 6
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnalterar
        '
        Me.btnalterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnalterar.Location = New System.Drawing.Point(301, 49)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(75, 36)
        Me.btnalterar.TabIndex = 5
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'btnnovo
        '
        Me.btnnovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnovo.Location = New System.Drawing.Point(220, 49)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(75, 36)
        Me.btnnovo.TabIndex = 4
        Me.btnnovo.Text = "Novo"
        Me.btnnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'txtnomecidade
        '
        Me.txtnomecidade.Location = New System.Drawing.Point(10, 103)
        Me.txtnomecidade.Multiline = True
        Me.txtnomecidade.Name = "txtnomecidade"
        Me.txtnomecidade.Size = New System.Drawing.Size(170, 90)
        Me.txtnomecidade.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Cidade"
        '
        'txtcodigocidade
        '
        Me.txtcodigocidade.Location = New System.Drawing.Point(10, 30)
        Me.txtcodigocidade.Name = "txtcodigocidade"
        Me.txtcodigocidade.Size = New System.Drawing.Size(170, 20)
        Me.txtcodigocidade.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Cidade"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvCidade)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(410, 244)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesquisa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvCidade
        '
        Me.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCidade.Location = New System.Drawing.Point(6, 6)
        Me.dgvCidade.Name = "dgvCidade"
        Me.dgvCidade.Size = New System.Drawing.Size(398, 230)
        Me.dgvCidade.TabIndex = 0
        '
        'CadastroCidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 290)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "CadastroCidade"
        Me.Text = "CadastroCidade"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvCidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnnovo As Button
    Friend WithEvents txtnomecidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigocidade As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvCidade As DataGridView
End Class
