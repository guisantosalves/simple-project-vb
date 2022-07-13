Imports System.ComponentModel

Public Class FrmSobre
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = FrmPrincipal.Icon

        txtNomeUsuario.Text = g_strNomeUsuario
        chkMessageAoSair.Checked = g_boolConfirma

        If g_colorFundoPadrao = Color.White Then
            optCorDeFundoBranca.Checked = True
        Else
            optCorDeFundoPadrao.Checked = True
        End If

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
        'mostra a caixa de diálogo -> na verificação acontece que
        'ele abre a caixa de diálogo antes de fazer a verificação, caso dê certo e o usuário abra a imagem
        'entra como true, caso de algo errado ele entra no else
        If ofdSelecionaImg.ShowDialog = DialogResult.OK Then
            'define local da imagem
            'Application.StartupPath -> trás o endereço onde essa aplicação está sendo executada
            'Dim strNomeArquivo As String = Application.StartupPath & "\imagemExemplo.jpg"

            'carrega no picture box
            PicImage.Image = Image.FromFile(ofdSelecionaImg.FileName)

            Me.Text = "vizualizador de imagens (" & ofdSelecionaImg.FileName & ")"
        Else
            MessageBox.Show("pls pick any image")
        End If

    End Sub

    Private Sub mnuConfirmarAoSairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConfirmarAoSairToolStripMenuItem.Click
        'ta recebendo ele mesmo, mas ao contrário
        mnuConfirmarAoSairToolStripMenuItem.Checked = Not mnuConfirmarAoSairToolStripMenuItem.Checked
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub

    Private Sub FrmSobre_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'atualizando variáveis globais quando fechar o form
        g_strNomeUsuario = txtNomeUsuario.Text
        g_boolConfirma = chkMessageAoSair.Checked

        If optCorDeFundoBranca.Checked Then

            g_colorFundoPadrao = Color.White
        Else
            g_colorFundoPadrao = System.Drawing.SystemColors.Control
        End If

    End Sub
End Class