Public Class Login_SignUP_Guest
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ContinueAsGuestButton.Click
        Flight_Search.Show()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        UserNamePass.Show()
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Customer_data.Show()
    End Sub
End Class