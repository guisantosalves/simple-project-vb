<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSobre
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
        Dim optCorDeFundoPadrao As System.Windows.Forms.RadioButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSobre))
        Me.lblNameUsuario = New System.Windows.Forms.Label()
        Me.txtNomeUsuario = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkMessageAoSair = New System.Windows.Forms.CheckBox()
        Me.grpCorDeFundoPadrao = New System.Windows.Forms.GroupBox()
        Me.optCorDeFundoBranca = New System.Windows.Forms.RadioButton()
        Me.lstExemple = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnMostraSelecionado = New System.Windows.Forms.Button()
        Me.cboCores = New System.Windows.Forms.ComboBox()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrirImagem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmarAoSairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicImage = New System.Windows.Forms.PictureBox()
        optCorDeFundoPadrao = New System.Windows.Forms.RadioButton()
        Me.grpCorDeFundoPadrao.SuspendLayout()
        Me.mnuPrincipal.SuspendLayout()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optCorDeFundoPadrao
        '
        optCorDeFundoPadrao.AutoSize = True
        optCorDeFundoPadrao.Checked = True
        optCorDeFundoPadrao.Location = New System.Drawing.Point(6, 26)
        optCorDeFundoPadrao.Name = "optCorDeFundoPadrao"
        optCorDeFundoPadrao.Size = New System.Drawing.Size(143, 24)
        optCorDeFundoPadrao.TabIndex = 0
        optCorDeFundoPadrao.TabStop = True
        optCorDeFundoPadrao.Text = "Cor cinza padrao"
        optCorDeFundoPadrao.UseVisualStyleBackColor = True
        '
        'lblNameUsuario
        '
        Me.lblNameUsuario.AutoSize = True
        Me.lblNameUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblNameUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNameUsuario.Location = New System.Drawing.Point(89, 72)
        Me.lblNameUsuario.Name = "lblNameUsuario"
        Me.lblNameUsuario.Size = New System.Drawing.Size(178, 24)
        Me.lblNameUsuario.TabIndex = 0
        Me.lblNameUsuario.Text = "Nome do usuario:"
        '
        'txtNomeUsuario
        '
        Me.txtNomeUsuario.Location = New System.Drawing.Point(89, 99)
        Me.txtNomeUsuario.Multiline = True
        Me.txtNomeUsuario.Name = "txtNomeUsuario"
        Me.txtNomeUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNomeUsuario.Size = New System.Drawing.Size(256, 38)
        Me.txtNomeUsuario.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(89, 143)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(116, 38)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(229, 143)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkMessageAoSair
        '
        Me.chkMessageAoSair.AutoSize = True
        Me.chkMessageAoSair.Location = New System.Drawing.Point(89, 197)
        Me.chkMessageAoSair.Name = "chkMessageAoSair"
        Me.chkMessageAoSair.Size = New System.Drawing.Size(207, 24)
        Me.chkMessageAoSair.TabIndex = 4
        Me.chkMessageAoSair.Text = "Mostrar mensagem ao sair"
        Me.chkMessageAoSair.UseVisualStyleBackColor = True
        '
        'grpCorDeFundoPadrao
        '
        Me.grpCorDeFundoPadrao.Controls.Add(Me.optCorDeFundoBranca)
        Me.grpCorDeFundoPadrao.Controls.Add(optCorDeFundoPadrao)
        Me.grpCorDeFundoPadrao.Location = New System.Drawing.Point(89, 227)
        Me.grpCorDeFundoPadrao.Name = "grpCorDeFundoPadrao"
        Me.grpCorDeFundoPadrao.Size = New System.Drawing.Size(246, 190)
        Me.grpCorDeFundoPadrao.TabIndex = 5
        Me.grpCorDeFundoPadrao.TabStop = False
        Me.grpCorDeFundoPadrao.Text = "cor de fundo padrao"
        '
        'optCorDeFundoBranca
        '
        Me.optCorDeFundoBranca.AutoSize = True
        Me.optCorDeFundoBranca.Location = New System.Drawing.Point(6, 66)
        Me.optCorDeFundoBranca.Name = "optCorDeFundoBranca"
        Me.optCorDeFundoBranca.Size = New System.Drawing.Size(102, 24)
        Me.optCorDeFundoBranca.TabIndex = 1
        Me.optCorDeFundoBranca.Text = "Cor branca"
        Me.optCorDeFundoBranca.UseVisualStyleBackColor = True
        '
        'lstExemple
        '
        Me.lstExemple.FormattingEnabled = True
        Me.lstExemple.ItemHeight = 20
        Me.lstExemple.Items.AddRange(New Object() {"guizaodozap", "eaeae", "dungeons", "and", "dragons"})
        Me.lstExemple.Location = New System.Drawing.Point(404, 99)
        Me.lstExemple.Name = "lstExemple"
        Me.lstExemple.Size = New System.Drawing.Size(266, 204)
        Me.lstExemple.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(404, 318)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(146, 29)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Adiciona estilo"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(556, 318)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(114, 29)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove estilo"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Location = New System.Drawing.Point(404, 353)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(266, 29)
        Me.btnLimpa.TabIndex = 9
        Me.btnLimpa.Text = "limpa"
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnMostraSelecionado
        '
        Me.btnMostraSelecionado.Location = New System.Drawing.Point(404, 388)
        Me.btnMostraSelecionado.Name = "btnMostraSelecionado"
        Me.btnMostraSelecionado.Size = New System.Drawing.Size(266, 29)
        Me.btnMostraSelecionado.TabIndex = 10
        Me.btnMostraSelecionado.Text = "mostrar selecionado"
        Me.btnMostraSelecionado.UseVisualStyleBackColor = True
        '
        'cboCores
        '
        Me.cboCores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCores.FormattingEnabled = True
        Me.cboCores.Items.AddRange(New Object() {"azul", "rosa", "vermelho", "roxo"})
        Me.cboCores.Location = New System.Drawing.Point(718, 99)
        Me.cboCores.Name = "cboCores"
        Me.cboCores.Size = New System.Drawing.Size(165, 28)
        Me.cboCores.TabIndex = 11
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(777, 28)
        Me.mnuPrincipal.TabIndex = 12
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrirImagem, Me.ToolStripSeparator1, Me.mnuSair, Me.mnuConfirmarAoSairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'mnuAbrirImagem
        '
        Me.mnuAbrirImagem.Name = "mnuAbrirImagem"
        Me.mnuAbrirImagem.Size = New System.Drawing.Size(224, 26)
        Me.mnuAbrirImagem.Text = "&Abrir Imagem"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(224, 26)
        Me.mnuSair.Text = "&Sair"
        '
        'mnuConfirmarAoSairToolStripMenuItem
        '
        Me.mnuConfirmarAoSairToolStripMenuItem.Checked = True
        Me.mnuConfirmarAoSairToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuConfirmarAoSairToolStripMenuItem.Name = "mnuConfirmarAoSairToolStripMenuItem"
        Me.mnuConfirmarAoSairToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.mnuConfirmarAoSairToolStripMenuItem.Text = "&Confirmar ao sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSobre})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AjudaToolStripMenuItem.Text = "A&juda"
        '
        'mnuSobre
        '
        Me.mnuSobre.Name = "mnuSobre"
        Me.mnuSobre.Size = New System.Drawing.Size(131, 26)
        Me.mnuSobre.Text = "&Sobre"
        '
        'PicImage
        '
        Me.PicImage.Location = New System.Drawing.Point(89, 470)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(581, 334)
        Me.PicImage.TabIndex = 13
        Me.PicImage.TabStop = False
        '
        'FrmSobre
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(777, 827)
        Me.Controls.Add(Me.PicImage)
        Me.Controls.Add(Me.cboCores)
        Me.Controls.Add(Me.btnMostraSelecionado)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstExemple)
        Me.Controls.Add(Me.chkMessageAoSair)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtNomeUsuario)
        Me.Controls.Add(Me.lblNameUsuario)
        Me.Controls.Add(Me.grpCorDeFundoPadrao)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "FrmSobre"
        Me.Text = "Sobre"
        Me.grpCorDeFundoPadrao.ResumeLayout(False)
        Me.grpCorDeFundoPadrao.PerformLayout()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameUsuario As Label
    Friend WithEvents txtNomeUsuario As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkMessageAoSair As CheckBox
    Friend WithEvents grpCorDeFundoPadrao As GroupBox
    Friend WithEvents optCorDeFundoBranca As RadioButton
    Friend WithEvents optCorDeFundoPadrao As RadioButton
    Friend WithEvents lstExemple As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnLimpa As Button
    Friend WithEvents btnMostraSelecionado As Button
    Friend WithEvents cboCores As ComboBox
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbrirImagem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuSair As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSobre As ToolStripMenuItem
    Friend WithEvents mnuConfirmarAoSairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PicImage As PictureBox
End Class
