Public Class acesso

    Public pass As String
    Public email As String
    Private Sub BTSair_Click(sender As Object, e As EventArgs) Handles BTSair.Click
        Close()
    End Sub

    Private Sub BTLogin_Click(sender As Object, e As EventArgs) Handles BTLogin.Click

        pass = TBPass.Text
        email = TBEmail.Text

        Me.Hide()
        emailBox.ShowDialog()

        Close()

    End Sub
End Class