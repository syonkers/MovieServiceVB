Imports System.Data.OleDb

Public Class MovieLookup
    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    Sub FixBoxValues()
        For Each txtBox As Control In Me.Controls
            If txtBox.GetType() Is GetType(TextBox) Then
                txtBox.Text = Nothing
            End If
        Next
    End Sub


    Private Sub PersonLookUp_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        FixBoxValues()
        'initialize connection
    End Sub

    Private Function SearchForMovie() As List(Of MovieType)
        Dim MovieItems = New List(Of MovieType)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select distinct MovieID, MovieName, Rating from Movie Where" _
                                + " MovieName Like '%" + TitleBox.Text + "%'"


            'MsgBox(command.CommandText)
            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                MovieItems.Add(New MovieType(dataReader(0),
                                               dataReader(1).ToString, dataReader(2)
                                              ))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dataReader.Close()
        connection.Close()

        Return MovieItems
    End Function


    Private Sub SearchButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchButton.Click

        Dim entries As List(Of MovieType) = SearchForMovie()
        If entries.Count = 0 Then
            MsgBox("No results found")
        Else
            Dim str As String = entries.Count.ToString + " movies found."
            MsgBox(str)
            ResultBox.DataSource = entries
            ResultBox.DisplayMember = "Display"
            ResultBox.ValueMember = "ID"
        End If
    End Sub

    Private Sub ResultBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ResultBox.SelectedIndexChanged
        MovieIDBox.Text = ResultBox.SelectedValue.ToString
    End Sub

    Private Sub CloseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class

