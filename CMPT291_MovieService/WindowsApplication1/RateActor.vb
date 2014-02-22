Imports System.Data.OleDb

Public Class RateActor
    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    Private actor As ActorType
    Private hasRated As Boolean = False

    Private Function GetActorRating(actor As ActorType) As Integer
        Dim rating As Integer = 0
        Try
            connection.Open()
            command = connection.CreateCommand()
            'Average all ratings for current actor
            command.CommandText = "Select AVG(Rating) From ActorRating Where ActorID = " + actor.ID.ToString
            Dim avgRating As Object = command.ExecuteScalar()

            'Make sure a rating exists
            If avgRating.GetType() IsNot GetType(DBNull) Then
                rating = CInt(avgRating)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
        Return rating
    End Function

    Private Function GetUsersActorRating(actor As ActorType) As Integer
        Dim rating As Integer = 0
        Try
            connection.Open()
            command = connection.CreateCommand()
            'Average all ratings for current actor
            command.CommandText = "Select Rating From ActorRating Where ActorID = " + actor.ID.ToString + " and PersonID = " _
                                + LoginForm.getLoggedInPersonID().ToString
            Dim avgRating As Integer = command.ExecuteScalar()

            'Make sure a rating exists
            If avgRating <> Nothing Then
                rating = CInt(avgRating)
                hasRated = True
            Else
                hasRated = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
        Return rating
    End Function

    Private Function AddActorRating(actor As ActorType) As Integer
        Dim rating As Integer = 0
        Try
            connection.Open()
            command = connection.CreateCommand()

            If Not hasRated Then
                command.CommandText = "insert into ActorRating(PersonID, ActorID, Rating) values (" _
                                    + LoginForm.getLoggedInPersonID().ToString + ", " + actor.ID.ToString + ", " _
                                    + RadioButtonRating().ToString + ")"
                hasRated = True
            Else

                command.CommandText = "Update ActorRating Set Rating = " + RadioButtonRating().ToString + " where" _
                                     + " PersonID = " + LoginForm.getLoggedInPersonID().ToString + " and" _
                                     + " ActorID = " + actor.ID.ToString

            End If

            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
        Return rating
    End Function



    'Returns the current rating selected via radio buttons
    Private Function RadioButtonRating() As Integer
        Dim rButton As RadioButton
        rButton = RadioBox.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return CInt(rButton.Text)
    End Function

    Private Sub SetRadioButtonRating(rating As Integer)
        Dim rButton As RadioButton
        rButton = RadioBox.Controls.OfType(Of RadioButton).Where(Function(r) CInt(r.Text) = rating).FirstOrDefault()
        rButton.Checked = True
    End Sub

    Private Sub refreshDetails()
        NameBox.Text = actor.Name + " " + actor.LName
        ActorIDStr.Text = "ActorID: " + actor.ID.ToString
        AvgRateBox.Text = GetActorRating(actor).ToString

        Dim myRate As Integer = GetUsersActorRating(actor)
        If myRate = 0 Then
            RadioButton3.Checked = True
        Else
            SetRadioButtonRating(myRate)
        End If

        If hasRated Then
            RateStatusStr.Text = "What you rated:"
        Else
            RateStatusStr.Text = "Please Rate Below:"
        End If

    End Sub

    'Need to pass actor data to show this form
    Public Sub ShowFor(actor As ActorType)
        Me.actor = actor
        Me.Show()
    End Sub

    Private Sub RateActor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDetails()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        AddActorRating(actor)
        refreshDetails()
    End Sub
End Class