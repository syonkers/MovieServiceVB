﻿Imports System.Data.OleDb



Public Class LoginForm
    Private dataReader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(GetConnectionString())
    Private command As OleDbCommand

    Public LoggedInID As Integer
    'Set default access level to customer
    Public AccessLevel As Integer = 0
    Public UserName As String


    Public Shared Function GetConnectionString() As String
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" _
            & "C:\Users\Shaun\Documents\291 Stuff\Repos\291Database.mdb"
        '& "C:\Users\Robert\Desktop\Project\291Database.mdb"
        '   & "G:\CMPT291Project\291Database.mdb"
        '& "G:\CMPT291Project\291Database.mdb"

    End Function

    'Get access level of currently logged in account
    Public Function getAccessLevel() As Integer
        Return AccessLevel
    End Function

    Public Function getLoggedInPersonID() As Integer
        Return LoggedInID
    End Function


    Private Function getEmployeePosition(personID As String, employeeID As String) As Integer
        Dim tempLevel As String = "Customer"

        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select PositionID from Employee Where PersonID = " + personID + " and" _
                                 + " EmployeeID = " + employeeID

            tempLevel = command.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return tempLevel
    End Function


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim loginSuccess As Boolean = False

        If UserNameBox.Text.Length = 0 Then
            MsgBox("Please enter a username")
            Return
        End If

        If PassWdBox.Text.Length = 0 Then
            MsgBox("Please enter your password")
            Return
        End If

        'Search for user name in table
        'Try log in attemp
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "SELECT PersonID, Password, EmployeeID From Login Where Username = '" + UserNameBox.Text + "'"
            dataReader = command.ExecuteReader()

            dataReader.Read() 'initial read for data
            If PassWdBox.Text = dataReader(1).ToString Then
                'MsgBox("Logged in successfully!")
                UserName = UserNameBox.Text
                loginSuccess = True
            Else
                MsgBox("Incorrect Username or Password")
            End If

            If loginSuccess Then
                'Get user id for login
                LoggedInID = dataReader(0)
                Dim pid As String = dataReader(0).ToString
                Dim eid As String = dataReader(2).ToString
                dataReader.Close()
                connection.Close()
                AccessLevel = getEmployeePosition(pid, eid)
            End If
        Catch ex As Exception
            MsgBox("Account does not exist")
            'MsgBox(ex.ToString)

        End Try

        'Close all database stuff
        If loginSuccess Then
            dataReader.Close()
            connection.Close()
        End If


        'If login successful, open next window based on access level
        'The lower the value, the higher the Access Level
        If loginSuccess Then
            If AccessLevel = 1 Then
                ManagerCP.Show()
            ElseIf AccessLevel > 1 Then
                EmployeeCP.Show()
            Else
                CustomerPanel.Show()
            End If

            Me.Hide()
        End If
    End Sub

    'Log out function clears all fields and returns back to login screen
    Public Sub LogOut()
        'clear all logged in fields
        UserNameBox.Text = Nothing
        PassWdBox.Text = Nothing
        LoggedInID = -1
        AccessLevel = Nothing
        UserName = Nothing
        Me.Show()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
