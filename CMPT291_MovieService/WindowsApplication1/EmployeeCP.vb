Public Class EmployeeCP

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()
        LoginForm.LogOut()
    End Sub

    Private Sub UserAccountButton_Click(sender As Object, e As EventArgs) Handles UserAccountButton.Click
        Me.Show()
        AccountInfo.Show()
    End Sub

    Private Sub ViewEmployeeButton_Click(sender As Object, e As EventArgs) Handles ViewEmployeeButton.Click
        EmployeeInfo.Show()
    End Sub

    Private Sub MailingListButton_Click(sender As Object, e As EventArgs) Handles MailingListButton.Click
        CustomerMailingList.Show()
    End Sub
End Class