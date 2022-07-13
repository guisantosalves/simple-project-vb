Public Class FrmPrincipal
    Private Sub btnVisualizaImage_Click(sender As Object, e As EventArgs) Handles btnVisualizaImage.Click
        'forms nao modais é quando ele pode ser sobreposto pelo form anterior
        'forms modais é quando ele tem o foco totalmente pra ele n podendo mudar o foco

        'form nao modal -> n tem foco
        'FrmSobre.Show()

        'form modal -> tem foco
        FrmSobre.ShowDialog()


    End Sub
End Class
