Public Class CustomerPanel

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()
        LoginForm.LogOut()
    End Sub

    Private Sub CustomerPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoggedInStr.Text = "Logged in as: " + LoginForm.UserName
        LoggedInStr.Refresh()
    End Sub

    Private Sub AccountInfoButton_Click(sender As Object, e As EventArgs) Handles AccountInfoButton.Click
        AccountInfo.Show()
    End Sub

    Private Sub ActorSearch_Click(sender As Object, e As EventArgs) Handles ActorSearch.Click
        'ActorLookup.Show()
    End Sub
End Class