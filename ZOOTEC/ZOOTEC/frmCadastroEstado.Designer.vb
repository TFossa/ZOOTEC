<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroEstado
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
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.txtsiglaestado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomeestado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoestado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvEstado = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(435, 200)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnsalvar)
        Me.TabPage1.Controls.Add(Me.btnexcluir)
        Me.TabPage1.Controls.Add(Me.btncancelar)
        Me.TabPage1.Controls.Add(Me.btnalterar)
        Me.TabPage1.Controls.Add(Me.btnnovo)
        Me.TabPage1.Controls.Add(Me.txtsiglaestado)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtnomeestado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtcodigoestado)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(427, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(243, 116)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(111, 47)
        Me.btnsalvar.TabIndex = 10
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Location = New System.Drawing.Point(299, 63)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(111, 47)
        Me.btnexcluir.TabIndex = 9
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(182, 63)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(111, 47)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnalterar
        '
        Me.btnalterar.Location = New System.Drawing.Point(299, 10)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(111, 47)
        Me.btnalterar.TabIndex = 7
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'btnnovo
        '
        Me.btnnovo.Location = New System.Drawing.Point(182, 10)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(111, 47)
        Me.btnnovo.TabIndex = 6
        Me.btnnovo.Text = "Novo"
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'txtsiglaestado
        '
        Me.txtsiglaestado.Location = New System.Drawing.Point(10, 133)
        Me.txtsiglaestado.Name = "txtsiglaestado"
        Me.txtsiglaestado.Size = New System.Drawing.Size(135, 20)
        Me.txtsiglaestado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sigla"
        '
        'txtnomeestado
        '
        Me.txtnomeestado.Location = New System.Drawing.Point(10, 80)
        Me.txtnomeestado.Name = "txtnomeestado"
        Me.txtnomeestado.Size = New System.Drawing.Size(135, 20)
        Me.txtnomeestado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Estado"
        '
        'txtcodigoestado
        '
        Me.txtcodigoestado.Location = New System.Drawing.Point(9, 27)
        Me.txtcodigoestado.Name = "txtcodigoestado"
        Me.txtcodigoestado.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigoestado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Estado"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvEstado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(610, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesquisa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvEstado
        '
        Me.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstado.Location = New System.Drawing.Point(7, 7)
        Me.dgvEstado.Name = "dgvEstado"
        Me.dgvEstado.ReadOnly = True
        Me.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstado.Size = New System.Drawing.Size(597, 333)
        Me.dgvEstado.TabIndex = 0
        '
        'CadastroEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 219)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CadastroEstado"
        Me.Text = "CadastroEstado"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnnovo As Button
    Friend WithEvents txtsiglaestado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomeestado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigoestado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvEstado As DataGridView
End Class
