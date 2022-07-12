<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.btnVisualizaImage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVisualizaImage
        '
        Me.btnVisualizaImage.Location = New System.Drawing.Point(299, 87)
        Me.btnVisualizaImage.Name = "btnVisualizaImage"
        Me.btnVisualizaImage.Size = New System.Drawing.Size(176, 29)
        Me.btnVisualizaImage.TabIndex = 0
        Me.btnVisualizaImage.Text = "Visualizar Imagem 1"
        Me.btnVisualizaImage.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVisualizaImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.Text = "Visualizador de imagem"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVisualizaImage As Button
End Class
