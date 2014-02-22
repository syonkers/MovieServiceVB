Imports System.Data.OleDb

Public Class MovieInfo

    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    Private addMode As Boolean = False
    Private editMode As Boolean = False
    Private existingMovie As Boolean = False
    Private existingMovieID As Integer

    Private Function MovieExists() As Boolean
        Return existingMovie
    End Function

    Private Sub SetMovieExists(value As Boolean)
        existingMovie = value
    End Sub
    Private Function MovieExistID() As Integer
        Return existingMovieID
    End Function

    Private Sub SetMovieExistID(value As Integer)
        existingMovieID = value
    End Sub


    'Enables and disables various control based on login access level
    Private Sub setAccessControl()
        'Access Level 1 = Manager, 2 = Employee, 0 = customer
        If LoginForm.getAccessLevel() = 1 Then
            For Each item As Control In Me.Controls
                item.Visible = True
                item.Enabled = True
            Next
            addedActorsBox.Enabled = False
            allActorBox.Enabled = False
            allGenreBox.Enabled = False
            addedGenreBox.Enabled = False
            addedActorsBox.Visible = False
            allActorBox.Visible = False
            allGenreBox.Visible = False
            addedGenreBox.Visible = False
            addGenreBtn.Visible = False
            removeGenreBtn.Visible = False
            deleteActorBtn.Visible = False
            addActorBtn.Visible = False
            actorMovieBox.Enabled = True
            movieGenreBox.Enabled = True
            movieListBox.Enabled = True
            warningLbl.Visible = False
        End If
    End Sub

    Private Function isEditEnabled() As Boolean
        Return editMode
    End Function

    Private Function isAddEnabled() As Boolean
        Return addMode
    End Function

    Private Function searchMovies() As List(Of MovieType)
        Dim movieItems = New List(Of MovieType)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select MovieID, MovieName, Rating " _
                                + " from Movie"

            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                movieItems.Add(New MovieType(dataReader(0),
                                               dataReader(1).ToString, dataReader(2).ToString))

            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return movieItems
    End Function

    Private Sub GetMovieData(selectID As Integer)

        Try
            movieGenreBox.Items.Clear()
            actorMovieBox.Items.Clear()
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select MovieName, Cost, Copies, Rating " _
                                + " from Movie" _
                                + " where (Movie.MovieID = " + selectID.ToString + ")"

            dataReader = command.ExecuteReader()
            dataReader.Read()
            movieNameBox.Text = dataReader(0).ToString
            movieCostBox.Text = dataReader(1).ToString
            movieCopiesBox.Text = dataReader(2).ToString
            movieRatingBox.Text = dataReader(3).ToString
            dataReader.Close()
            connection.Close()

            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select GenreType" _
                                + " from Genre, ContainsGenre, Movie" _
                                + " where (Movie.MovieID = ContainsGenre.MovieID) and (ContainsGenre.GenreID = Genre.GenreID) and (Movie.MovieID = " + selectID.ToString + ")"
            dataReader = command.ExecuteReader()
            Do While dataReader.Read()
                movieGenreBox.Items.Add(dataReader(0))
            Loop
            dataReader.Close()
            connection.Close()

            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select Actor.GivenName, Actor.FamilyName" _
                                + " from Actor, ActsIn, Movie" _
                                + " where (Movie.MovieID = ActsIn.MovieID) and (ActsIn.ActorID = Actor.ActorID) and (Movie.MovieID = " + selectID.ToString + ")"
            dataReader = command.ExecuteReader()
            Do While dataReader.Read()
                actorMovieBox.Items.Add(dataReader(0) & dataReader(1))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dataReader.Close()
        connection.Close()
        If movieGenreBox.Items.Count > 0 Then
            movieGenreBox.SelectedIndex = 0
        End If
        If actorMovieBox.Items.Count > 0 Then
            actorMovieBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub UpdateMovie(selectedMovie)
        Try
            Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Select Movie.MovieID from Movie where Movie.MovieID = " & selectedMovie.ToString
            cmd.Connection = connection
            connection.Open()
            dataReader = cmd.ExecuteReader()
            dataReader.Read()
            Dim theID As Integer = CInt(dataReader(0).ToString)
            dataReader.Close()
            connection.Close()

            connection.Open()
            command.CommandText = "Update Movie set Movie.MovieName = '" + movieNameBox.Text + "', " _
                                + "Movie.Cost = '" + movieCostBox.Text + "', " _
                                + "Movie.Copies = '" + movieCopiesBox.Text + "' " _
                                + " where MovieID = " + theID.ToString
            command.ExecuteNonQuery()
            connection.Close()


            'delete all records of genres related to the movie
            command.CommandText = "delete from ContainsGenre where ContainsGenre.MovieID = " & theID.ToString
            command.Connection = connection
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            'delete all records of actor relations to the movie
            command.CommandText = "delete from ActsIn where ActsIn.MovieID = " & theID.ToString
            command.Connection = connection
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            connection.Open()
            For Each movieGenre In addedGenreBox.Items
                Dim currentGenre As GenreType = movieGenre
                command.CommandText = "insert into ContainsGenre(MovieID, GenreID) values (" + theID.ToString + ", " + currentGenre.ID.ToString + ")"
                command.ExecuteNonQuery()
            Next
            connection.Close()

            connection.Open()
            'Insert Actor/Movie information
            For Each movieActor In addedActorsBox.Items
                Dim currentActor As ActorType = movieActor
                command.CommandText = "insert into ActsIn(ActorID, MovieID) values (" + currentActor.ID.ToString + ", " + theID.ToString + ")"
                command.ExecuteNonQuery()
            Next
            MsgBox("Updated Movie")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Dim entries As List(Of MovieType) = searchMovies()
        movieListBox.DataSource = entries
        movieListBox.DisplayMember = "Display"
        movieListBox.ValueMember = "ID"
        movieListBox.SelectedIndex = 0
    End Sub

    Private Sub MovieInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim entries As List(Of MovieType) = searchMovies()
        If entries.Count = 0 Then
            MsgBox("No movies found")
        Else
            Dim str As String = entries.Count.ToString + " movie(s) found."
            MsgBox(str)
            movieListBox.DataSource = entries
            movieListBox.DisplayMember = "Display"
            movieListBox.ValueMember = "ID"
            movieListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub deleteMovie(selectedMovie)
        Dim response
        response = MsgBox("Are you sure you wish to delete this movie?", vbYesNo)
        If response = vbYes Then
            Try
                Dim cmd As New System.Data.OleDb.OleDbCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "Select Movie.MovieID from Movie where Movie.MovieID = " & selectedMovie
                cmd.Connection = connection
                connection.Open()
                dataReader = cmd.ExecuteReader()
                dataReader.Read()
                Dim theID As Integer = CInt(dataReader(0).ToString)
                dataReader.Close()
                connection.Close()

                'delete all records of genres related to the movie
                cmd.CommandText = "delete from ContainsGenre where ContainsGenre.MovieID = " & theID.ToString
                cmd.Connection = connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()

                'delete all records of actor relations to the movie
                cmd.CommandText = "delete from ActsIn where ActsIn.MovieID = " & theID.ToString
                cmd.Connection = connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()

                'finally deletes the movie record
                cmd.CommandText = "delete from Movie where Movie.MovieID = " & theID.ToString
                cmd.Connection = connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()

                MsgBox(movieNameBox.Text + " Deleted")
                Dim entries As List(Of MovieType) = searchMovies()
                If entries.Count = 0 Then
                    MsgBox("No movies found")
                Else
                    movieListBox.DataSource = entries
                    movieListBox.DisplayMember = "Display"
                    movieListBox.ValueMember = "ID"
                    movieListBox.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            connection.Close()
        End If
    End Sub

    Private Sub addMovie()
        Dim MovieID As Integer
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "insert into Movie (MovieName, Cost, Copies) Values (?,?,?)"
            command.Parameters.AddWithValue("MovieName", movieNameBox.Text)
            command.Parameters.AddWithValue("Cost", movieCostBox.Text)
            command.Parameters.AddWithValue("Copies", movieCopiesBox.Text)
            'insert person into table
            command.ExecuteNonQuery()
            'Get the MovieID of the last inserted movie record
            command.CommandText = "SELECT @@IDENTITY"
            MovieID = CInt(command.ExecuteScalar())

            'Insert Genre/Movie information

            For Each movieGenre In addedGenreBox.Items
                Dim currentGenre As GenreType = movieGenre
                command.CommandText = "insert into ContainsGenre(MovieID, GenreID) values (" + MovieID.ToString + ", " + currentGenre.ID.ToString + ")"
                command.ExecuteNonQuery()
            Next

            'Insert Actor/Movie information
            For Each movieActor In addedActorsBox.Items
                Dim currentActor As ActorType = movieActor
                command.CommandText = "insert into ActsIn(ActorID, MovieID) values (" + currentActor.ID.ToString + ", " + MovieID.ToString + ")"
                command.ExecuteNonQuery()
            Next


            'Inform of successful addition
            If MovieExists() Then
                MsgBox("Successfully added " + movieListBox.SelectedItem)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Dim entries As List(Of MovieType) = searchMovies()
        movieListBox.DataSource = entries
        movieListBox.DisplayMember = "Display"
        movieListBox.ValueMember = "ID"
        movieListBox.SelectedIndex = 0
    End Sub

    Private Sub enabledAddMovie(enabled As Boolean)
        addMode = enabled

        If addMode Then

            For Each txtBox As Control In Me.Controls
                If txtBox.GetType() Is GetType(TextBox) Then
                    txtBox.Enabled = True
                    txtBox.Text = Nothing
                End If
            Next
            addedActorsBox.Enabled = True
            allActorBox.Enabled = True
            allGenreBox.Enabled = True
            addedGenreBox.Enabled = True
            addedActorsBox.Visible = True
            allActorBox.Visible = True
            allGenreBox.Visible = True
            addedGenreBox.Visible = True
            addGenreBtn.Enabled = True
            addGenreBtn.Visible = True
            removeGenreBtn.Enabled = True
            removeGenreBtn.Visible = True
            addActorBtn.Visible = True
            deleteActorBtn.Visible = True
            movieRatingBox.Enabled = False
            cancelBtn.Text = "Cancel"
            deleteMovieBtn.Enabled = False
            addMovieBtn.Enabled = False
            addMovieBtn.Visible = False
            confirmBtn.Enabled = True
            confirmBtn.Visible = True
            actorMovieBox.Enabled = False
            movieGenreBox.Enabled = False
            movieListBox.Enabled = False
            fillActorBox()
            Dim genreEntries As List(Of GenreType) = fillGenreBox()
            allGenreBox.DataSource = genreEntries
            allGenreBox.DisplayMember = "Display"
            allGenreBox.ValueMember = "ID"
            allGenreBox.SelectedIndex = 0
            Dim actorEntries As List(Of ActorType) = fillActorBox()
            allActorBox.DataSource = actorEntries
            allActorBox.DisplayMember = "Display"
            allActorBox.ValueMember = "ID"
            allActorBox.SelectedIndex = 0


        Else
            'Otherwise, set the default permissions
            setAccessControl()
            cancelBtn.Text = "Close"
            confirmBtn.Visible = False
            confirmBtn.Enabled = False
        End If
    End Sub

    Private Sub enabledEditMovie(enabled As Boolean)
        editMode = enabled

        If editMode Then

            For Each txtBox As Control In Me.Controls
                If txtBox.GetType() Is GetType(TextBox) Then
                    txtBox.Enabled = True
                End If
            Next
            addedActorsBox.Enabled = True
            allActorBox.Enabled = True
            allGenreBox.Enabled = True
            addedGenreBox.Enabled = True
            addedActorsBox.Visible = True
            allActorBox.Visible = True
            allGenreBox.Visible = True
            addedGenreBox.Visible = True
            addGenreBtn.Enabled = True
            addGenreBtn.Visible = True
            removeGenreBtn.Enabled = True
            removeGenreBtn.Visible = True
            addActorBtn.Visible = True
            deleteActorBtn.Visible = True
            movieRatingBox.Enabled = False
            cancelBtn.Text = "Cancel"
            deleteMovieBtn.Enabled = False
            addMovieBtn.Enabled = False
            addMovieBtn.Visible = False
            confirmBtn.Enabled = True
            confirmBtn.Visible = True
            actorMovieBox.Enabled = False
            movieGenreBox.Enabled = False
            Dim genreEntries As List(Of GenreType) = fillGenreBox()
            allGenreBox.DataSource = genreEntries
            allGenreBox.DisplayMember = "Display"
            allGenreBox.ValueMember = "ID"
            allGenreBox.SelectedIndex = 0
            Dim actorEntries As List(Of ActorType) = fillActorBox()
            allActorBox.DataSource = actorEntries
            allActorBox.DisplayMember = "Display"
            allActorBox.ValueMember = "ID"
            allActorBox.SelectedIndex = 0
            'Dim addedActorEntries As List(Of ActorType) = fillAddedActorBox(movieListBox.SelectedValue)
            'addedActorsBox.DataSource = addedActorEntries
            'addedActorsBox.DisplayMember = "Display"
            'addedActorsBox.ValueMember = "ID"
            'Dim addedGenreEntries As List(Of GenreType) = fillAddedGenreBox(movieListBox.SelectedValue)
            'addedGenreBox.DataSource = addedGenreEntries
            'addedGenreBox.DisplayMember = "Display"
            'addedGenreBox.ValueMember = "ID"
            movieListBox.Enabled = False
            warningLbl.Visible = True
        Else
            'Otherwise, set the default permissions
            setAccessControl()
            cancelBtn.Text = "Close"
            confirmBtn.Visible = False
            confirmBtn.Enabled = False
        End If
    End Sub

    Private Function fillGenreBox()
        Dim genreItems = New List(Of GenreType)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select GenreID, GenreType" _
                                + " from Genre"

            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                genreItems.Add(New GenreType(dataReader(0).ToString,
                                               dataReader(1)))

            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return genreItems
    End Function

    Private Function fillActorBox()
        Dim actorItems = New List(Of ActorType)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select ActorID, FamilyName, GivenName, Gender, Age from Actor"

            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                actorItems.Add(New ActorType(dataReader(0),
                                               dataReader(1).ToString, dataReader(2).ToString,
                                               dataReader(3), dataReader(4).ToString))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return actorItems
    End Function

    Private Function fillAddedActorBox(selectedMovie)
        Dim actorItems = New List(Of ActorType)
        Try
            Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Select Movie.MovieID from Movie where Movie.MovieID = " & selectedMovie
            cmd.Connection = connection
            connection.Open()
            dataReader = cmd.ExecuteReader()
            dataReader.Read()
            Dim theID As Integer = CInt(dataReader(0).ToString)
            dataReader.Close()
            connection.Close()


            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select Actor.ActorID, FamilyName, GivenName, Gender, Age from Actor, ActsIn, Movie where (Movie.MovieID = ActsIn.MovieID) and (ActsIn.ActorID = Actor.ActorID) and (Movie.MovieID = " + theID.ToString + ")"

            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                actorItems.Add(New ActorType(dataReader(0),
                                               dataReader(1).ToString, dataReader(2).ToString,
                                               dataReader(3), dataReader(4).ToString))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return actorItems
    End Function

    Private Function fillAddedGenreBox(selectedMovie)
        Dim genreItems = New List(Of GenreType)
        Try
            Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Select Movie.MovieID from Movie where Movie.MovieID = " & selectedMovie
            cmd.Connection = connection
            connection.Open()
            dataReader = cmd.ExecuteReader()
            dataReader.Read()
            Dim theID As Integer = CInt(dataReader(0).ToString)
            dataReader.Close()
            connection.Close()


            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select Genre.GenreID, GenreType from Genre, ContainsGenre, Movie where (Movie.MovieID = ContainsGenre.MovieID) and (ContainsGenre.GenreID = Genre.GenreID) and (Movie.MovieID = " + theID.ToString + ")"

            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                genreItems.Add(New GenreType(dataReader(0),
                                               dataReader(1).ToString))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return genreItems
    End Function

    Private Sub movieListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles movieListBox.SelectedValueChanged
        If movieListBox.SelectedValue.GetType() Is GetType(MovieType) Then
        Else
            GetMovieData(movieListBox.SelectedValue)
        End If

    End Sub

    Private Sub editMovieBtn_Click(sender As Object, e As EventArgs) Handles editMovieBtn.Click
        enabledEditMovie(True)
    End Sub

    Private Sub addMovieBtn_Click(sender As Object, e As EventArgs) Handles addMovieBtn.Click
        enabledAddMovie(True)
    End Sub

    Private Sub deleteMovieBtn_Click(sender As Object, e As EventArgs) Handles deleteMovieBtn.Click
        deleteMovie(movieListBox.SelectedValue)
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        If isAddEnabled() Then
            'Cancel adding a new employee
            enabledAddMovie(False)
            movieListBox_SelectedValueChanged(movieListBox, Nothing)
        ElseIf isEditEnabled() Then
            enabledEditMovie(False)
            movieListBox_SelectedValueChanged(movieListBox, Nothing)
        Else
            'Otherwise, just close the menu
            Me.Close()
        End If
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        If isAddEnabled() Then
            addMovie()
            movieListBox_SelectedValueChanged(movieListBox, Nothing)
            SetMovieExists(False)
            enabledAddMovie(False)
        ElseIf isEditEnabled() Then
            UpdateMovie(movieListBox.SelectedValue)
            movieListBox_SelectedValueChanged(movieListBox, Nothing)
            enabledEditMovie(False)
        End If
    End Sub

    Private Sub addActorBtn_Click(sender As Object, e As EventArgs) Handles addActorBtn.Click
            addedActorsBox.Items.Add(allActorBox.SelectedItem)
            addedActorsBox.DisplayMember = "Display"
            addedActorsBox.ValueMember = "ID"
    End Sub

    Private Sub deleteActorBtn_Click(sender As Object, e As EventArgs) Handles deleteActorBtn.Click
        addedActorsBox.Items.Remove(addedActorsBox.SelectedItem)
    End Sub

    Private Sub addGenreBtn_Click(sender As Object, e As EventArgs) Handles addGenreBtn.Click
        addedGenreBox.Items.Add(allGenreBox.SelectedItem)
        addedGenreBox.DisplayMember = "Display"
        addedGenreBox.ValueMember = "ID"
    End Sub

    Private Sub removeGenreBtn_Click(sender As Object, e As EventArgs) Handles removeGenreBtn.Click
        addedGenreBox.Items.Remove(addedGenreBox.SelectedItem)
    End Sub
End Class



    Public Class MovieType
    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal rating As String)
        movieID = id
        movieName = name
        movieRating = Rating

        displayStr = movieID & ", " & movieName & ", " & movieRating
    End Sub

        Private movieID As Integer
        Public Property ID() As Integer
            Get
                Return movieID
            End Get
            Set(ByVal value As Integer)
                movieID = value
            End Set
        End Property

        Private movieName As String
        Public Property Name() As String
            Get
                Return movieName
            End Get
            Set(ByVal value As String)
                movieName = value
            End Set
        End Property

    Private movieRating As String
    Public Property Rating() As String
        Get
            Return movieRating
        End Get
        Set(ByVal value As String)
            movieRating = value
        End Set
    End Property

        Private displayStr As String
        Public Property Display() As String
            Get
                Return displayStr
            End Get
            Set(ByVal value As String)
                displayStr = value
            End Set
        End Property
End Class

Public Class GenreType
    Public Sub New(ByVal id As Integer, ByVal name As String)
        GenreID = id
        GenreName = name

        displayStr = GenreID & ", " & GenreName
    End Sub

    Private GenreID As Integer
    Public Property ID() As Integer
        Get
            Return GenreID
        End Get
        Set(ByVal value As Integer)
            GenreID = value
        End Set
    End Property
    Private GenreName As String
    Public Property Name() As String
        Get
            Return GenreName
        End Get
        Set(value As String)
            GenreName = value
        End Set
    End Property
    Private displayStr As String
    Public Property Display() As String
        Get
            Return displayStr
        End Get
        Set(ByVal value As String)
            displayStr = value
        End Set
    End Property
End Class