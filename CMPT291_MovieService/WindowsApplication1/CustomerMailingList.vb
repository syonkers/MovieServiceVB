Imports System.Data.OleDb

Public Class CustomerMailingList
    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    'Generate a list of all employees
    Private Function CollectEmails() As List(Of String)
        Dim emailList = New List(Of String)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select Distinct Email From Customer"
            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                Dim tempStr As String = dataReader(0).ToString
                If tempStr <> Nothing Then
                    emailList.Add(tempStr)
                End If
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dataReader.Close()
        connection.Close()
        Return emailList
    End Function

    Private Sub CustomerMailingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emails As List(Of String) = CollectEmails()
        If emails.Count = 0 Then
            MsgBox("No employees found")
            Me.Close()
        Else
            EmailListBox.DataSource = emails
            EmailListBox.DisplayMember = "Display"
            EmailListBox.ValueMember = "ID"
            EmailListBox.SelectedIndex = 0
        End If
    End Sub

End Class