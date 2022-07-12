Public Class FrmSobre
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Icon = FrmPrincipal.Icon

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim intIndex As Integer
        intIndex = lstExemple.Items.Add("dungeons")

        MessageBox.Show(intIndex)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'já o RemoveAt aceita um inteiro como parâmetro entao podemos acessar os indices
        lstExemple.Items.Remove("dragons")


    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click

        lstExemple.Items.Clear()

    End Sub

    Private Sub btnMostraSelecionado_Click(sender As Object, e As EventArgs) Handles btnMostraSelecionado.Click

        'selectedItem pega o item que o usuário selecionou
        'selectedIndex pega o index da string selecionada, caso n tenha selecionado vem -1
        MessageBox.Show("você selecionou " & lstExemple.SelectedItem & ", que tem o 
        seguinte index: " & lstExemple.SelectedIndex)

    End Sub

    Private Sub mnuAbrirImagem_Click(sender As Object, e As EventArgs) Handles mnuAbrirImagem.Click
        'define local da imagem
        'Application.StartupPath -> trás o endereço onde essa aplicação está sendo executada
        Dim strNomeArquivo As String = Application.StartupPath & "\imagemExemplo.jpg"

        'carrega no picture box
        PicImage.Image = Image.FromFile(strNomeArquivo)

        Me.Text = "vizualizador de imagens (" & strNomeArquivo & ")"

    End Sub

    Private Sub mnuConfirmarAoSairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConfirmarAoSairToolStripMenuItem.Click
        'ta recebendo ele mesmo, mas ao contrário
        mnuConfirmarAoSairToolStripMenuItem.Checked = Not mnuConfirmarAoSairToolStripMenuItem.Checked
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub
End Class