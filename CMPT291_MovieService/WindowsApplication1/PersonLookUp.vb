Imports System.Data.OleDb

Public Class PersonLookUp
    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    Private prevForm As Object

    Sub FixBoxValues()
        For Each txtBox As Control In Me.Controls
            If txtBox.GetType() Is GetType(TextBox) Then
                txtBox.Text = Nothing
            End If
        Next
    End Sub

    Public Sub OpenFrom(form As Object)
        prevForm = form
        Me.Show()
    End Sub

    Private Sub PersonLookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FixBoxValues()
        'initialize connection
    End Sub

    Private Function SearchForPeople() As List(Of PersonType)
        Dim peopleItems = New List(Of PersonType)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select distinct PersonID, FamilyName, GivenName, Zip, Phone from Person Where" _
                                + " FamilyName Like '%" + FnameBox.Text + "%' and" _
                                + " GivenName Like '%" + LnameBox.Text + "%' and" _
                                + " Zip Like '%" + ZipBox.Text + "%' and" _
                                + " Phone Like '%" + PhoneBox.Text + "%'"

            'MsgBox(command.CommandText)
            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                peopleItems.Add(New PersonType(dataReader(0),
                                               dataReader(1).ToString + " " + dataReader(2).ToString,
                                               dataReader(3).ToString, dataReader(4).ToString))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dataReader.Close()
        connection.Close()

        Return peopleItems
    End Function


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim entries As List(Of PersonType) = SearchForPeople()
        If entries.Count = 0 Then
            MsgBox("No results found")
        Else
            Dim str As String = entries.Count.ToString + " people found."
            MsgBox(str)
            ResultBox.DataSource = entries
            ResultBox.DisplayMember = "Display"
            ResultBox.ValueMember = "ID"
        End If
    End Sub

    Private Sub ResultBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResultBox.SelectedIndexChanged
        PersonIDBox.Text = ResultBox.SelectedValue.ToString
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prevForm.importPersonData(CInt(PersonIDBox.Text))
        Me.Close()
    End Sub
End Class