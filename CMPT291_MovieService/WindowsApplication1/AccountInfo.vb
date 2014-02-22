Imports System.Data.OleDb

Public Class AccountInfo
    Private dataReader As OleDbDataReader
    'Open connection to database globally
    Private connection As OleDbConnection = New OleDbConnection(LoginForm.GetConnectionString())
    Private command As OleDbCommand

    'True if updating, false if adding
    Private addMode As Boolean
    Private missingNextPlan As Boolean = False
    Private existingPerson As Boolean = False
    Private existingPersonID As Integer

    Private Function PersonExists() As Boolean
        Return existingPerson
    End Function

    Private Sub SetPersonExists(value As Boolean)
        existingPerson = value
    End Sub

    Private Function PersonExistID() As Integer
        Return existingPersonID
    End Function

    Private Sub SetPersonExistID(value As Integer)
        existingPersonID = value
    End Sub

    'Enables and disables various control based on log in access level
    Private Sub setAccessControl()
        'Only employees can edit account information
        If LoginForm.getAccessLevel() > 1 Then
            'Make User fields editable
            For Each txtBox As Control In Me.Controls
                If txtBox.GetType() Is GetType(TextBox) Then
                    txtBox.Enabled = True
                End If
                'make everything visible
                txtBox.Visible = True
            Next
        Else
            'If its a customer looking at info, just look up own info
            getAccountInfo(LoginForm.UserName)
        End If
    End Sub


    'Return whether or not we are adding a new employee
    Private Function isAddEnabled() As Boolean
        Return addMode
    End Function

    Private Sub EnableAddCustomer(enabled As Boolean)
        If LoginForm.getAccessLevel() = 0 Then
            setAccessControl()
            Return
        End If

        addMode = enabled

        'If we are adding a new employee, clear all text boxes and enable them 
        If addMode Then
            For Each txtBox As Control In Me.Controls
                If txtBox.GetType() Is GetType(TextBox) And txtBox IsNot UserNameBox Then
                    txtBox.Enabled = True
                    txtBox.Text = Nothing
                Else
                    'enable everything else
                    txtBox.Enabled = True
                End If
            Next

            EditAccountButton.Text = "Add Customer"
            'Switch cancel/close button text
            CancelButton.Text = "Cancel"
            'Somethings do need to be disabled
            DeleteUserButton.Enabled = False
            NextPlanComboBox.Enabled = False
        Else
            'Otherwise, set the default permissions
            setAccessControl()
            EditAccountButton.Text = "Update Customer"
            CancelButton.Text = "Close"
            DeleteUserButton.Enabled = True
            NextPlanComboBox.Enabled = True
            PlanComboBox.Enabled = False
            EditAccountButton.Enabled = True
        End If

        'This is always disabled
        AccountNoBox.Enabled = False
    End Sub

    'If an employee user name is detected, lock down everything
    Private Sub DisableForInvalidUserName()
        For Each thing As Control In Me.Controls
            If thing.GetType() IsNot GetType(Label) Then
                thing.Enabled = False
                If thing.GetType() Is GetType(TextBox) Then
                    thing.Text = Nothing
                End If
            End If
        Next
        'Enable username box so one can search for a new username
        UserNameBox.Enabled = True
        CancelButton.Enabled = True
        SearchUserNameButton.Enabled = True
    End Sub


    'Return a list of plans for use in a  combobox
    Public Function GetPlanTypes() As List(Of PlanType)
        Dim planItems = New List(Of PlanType)
        Dim queryString As String = "SELECT PlanID, Type FROM Plan"
        'Search for user name in table
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = queryString
            dataReader = command.ExecuteReader()

            Do While dataReader.Read()
                planItems.Add(New PlanType(dataReader(0), dataReader(1).ToString))
            Loop

        Catch ex As Exception
            MsgBox("Error finding plan types")
        End Try

        dataReader.Close()
        connection.Close()
        Return planItems
    End Function

    Private Sub populatePlanComboBox()
        'I have checked, you do need to call GetPlanTypes twice, or the boxes copy each other
        'Current plan box
        PlanComboBox.DataSource = GetPlanTypes()
        PlanComboBox.DisplayMember = "Name"
        PlanComboBox.ValueMember = "ID"
        PlanComboBox.SelectedValue = 1

        'Next months plan box
        NextPlanComboBox.DataSource = GetPlanTypes()
        NextPlanComboBox.DisplayMember = "Name"
        NextPlanComboBox.ValueMember = "ID"
        NextPlanComboBox.SelectedValue = 1
    End Sub

    'Returns true or false if a username belongs to an employee account
    Private Function isEmployee(userName As String) As Boolean
        Dim isEmp As Boolean = False

        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "Select Login.Username From Login, Employee where Login.PersonID = Employee.PersonID and" _
                                    + " Employee.EmployeeID = Login.EmployeeID"
            dataReader = command.ExecuteReader()

            Do While dataReader.Read() 'initial read for data
                If dataReader(0).ToString = userName Then
                    isEmp = True
                    Exit Do
                End If
            Loop
        Catch ex As Exception
            'MsgBox("not employee")
        End Try

        dataReader.Close()
        connection.Close()
        Return isEmp
    End Function

    Private Sub getCustomerPlans()
        Try
            connection.Open()
            command = connection.CreateCommand()

            'Get subscription type information, check between current month and next month
            Dim curMonth = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            command.CommandText = "SELECT PlanID" _
                                 + " FROM Subscribe" _
                                 + " Where AccountNo = " + AccountNoBox.Text + " and" _
                                 + " theDate >= #" + curMonth + "# and theDate < #" + curMonth.AddMonths(1) + "#"
            PlanComboBox.SelectedValue = command.ExecuteScalar()
            PlanComboBox.Refresh()

            'Get next months subscription setup so that it can be changed ahead of time
            curMonth = curMonth.AddMonths(1)
            command.CommandText = "SELECT PlanID" _
                             + " FROM Subscribe" _
                            + " Where AccountNo = " + AccountNoBox.Text + " and" _
                           + " theDate >= #" + curMonth + "# and theDate < #" + curMonth.AddMonths(1) + "#"

            Dim type As Object = command.ExecuteScalar()
            If type = Nothing Then
                missingNextPlan = True
                NextPlanComboBox.SelectedValue = PlanComboBox.SelectedValue
            Else
                missingNextPlan = False
                NextPlanComboBox.SelectedValue = type
            End If
            NextPlanComboBox.Refresh()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

        connection.Close()
    End Sub


    Public Sub importPersonData(idNo As Integer)
        Dim queryString As String = "SELECT *" _
                                     + " FROM Person" _
                                     + " Where PersonID = " + idNo.ToString
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = queryString
            dataReader = command.ExecuteReader()

            dataReader.Read() 'initial read for data
            FnameBox.Text = dataReader(1).ToString
            LnameBox.Text = dataReader(2).ToString
            CityBox.Text = dataReader(3).ToString
            AddressBox.Text = dataReader(4).ToString
            StateBox.Text = dataReader(5).ToString
            ZipBox.Text = dataReader(6).ToString
            PhoneBox.Text = dataReader(7).ToString

            SetPersonExists(True)
            SetPersonExistID(idNo)
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

        dataReader.Close()
        connection.Close()
    End Sub

    Private Function getAccountInfo(userName As String) As Boolean
        Dim result As Boolean = False
        'Search for user name in table
        Dim queryString As String = "SELECT Username, Password, FamilyName, GivenName, CIty, Address, State, Zip, Phone, AccountNo, Email, CreditCard" _
                                     + " FROM Login, Person, Customer" _
                                     + " where Login.PersonID = Person.PersonID and " _
                                     + "Customer.PersonID = Login.PersonID and " _
                                     + "Login.Username = '" + userName + "' "

        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = queryString
            dataReader = command.ExecuteReader()

            dataReader.Read() 'initial read for data
            'Login Table data
            UserNameBox.Text = dataReader(0).ToString
            PassWordBox.Text = dataReader(1).ToString
            'Person Table Info
            FnameBox.Text = dataReader(2).ToString
            LnameBox.Text = dataReader(3).ToString
            CityBox.Text = dataReader(4).ToString
            AddressBox.Text = dataReader(5).ToString
            StateBox.Text = dataReader(6).ToString
            ZipBox.Text = dataReader(7).ToString
            PhoneBox.Text = dataReader(8).ToString
            'Customer table info
            AccountNoBox.Text = dataReader(9).ToString
            EmailBox.Text = dataReader(10).ToString
            CreditCardBox.Text = dataReader(11).ToString
            dataReader.Close()
            connection.Close()

            getCustomerPlans()
            result = True
        Catch ex As Exception
            'MsgBox(ex.ToString)
            result = False
        End Try

        'close and exit
        dataReader.Close()
        connection.Close()
        Return result
    End Function

    'Creates a new customer account and person, or links an existing person to a new customer account
    Private Sub AddAccount()
        Dim personID As Integer
        Try
            connection.Open()
            command = connection.CreateCommand()

            'First, Insert person
            If Not PersonExists() Then
                command.CommandText = "insert into Person (FamilyName, GivenName, City, Address, State, Zip, Phone) Values (?,?,?,?,?,?,?)"
                command.Parameters.AddWithValue("FamilyName", FnameBox.Text)
                command.Parameters.AddWithValue("GivenName", LnameBox.Text)
                command.Parameters.AddWithValue("City", CityBox.Text)
                command.Parameters.AddWithValue("Address", AddressBox.Text)
                command.Parameters.AddWithValue("State", StateBox.Text)
                command.Parameters.AddWithValue("Zip", ZipBox.Text)
                command.Parameters.AddWithValue("Phone", PhoneBox.Text)
                'insert person into table
                command.ExecuteNonQuery()
                'Get the PersonID of the last inserted person record
                command.CommandText = "SELECT @@IDENTITY"
                personID = CInt(command.ExecuteScalar())
            Else
                personID = PersonExistID()
            End If


            'Insert Users Login Info
            command.CommandText = "insert into Login values ('" + personID.ToString + "', '" _
                                 + UserNameBox.Text + "','" _
                                 + PassWordBox.Text + "', 0)" 'Users have employee id of 0
            command.ExecuteNonQuery()

            'Insert User as a customer
            Dim curDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            command.CommandText = "insert into Customer (PersonID, CreationDate, Email, CreditCard) " _
                                  + " values ('" + personID.ToString + "', '" _
                                 + curDate + "','" _
                                 + EmailBox.Text + "','" _
                                 + CreditCardBox.Text + "')"
            command.ExecuteNonQuery()

            'hopefully grab the newly inserted account id
            command.CommandText = "SELECT @@IDENTITY From Customer"
            Dim AccountID As Long = CLng(command.ExecuteScalar())

            'Insert subscription info. By default, next months subscription takes on the current months subscription
            'unless updated afterwards. 
            'TODO: Next months subscription won't be added to the database unless a customer is updated
            'within the current month.
            Dim curMonth = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            command.CommandText = "insert into Subscribe values ('" + AccountID.ToString + "','" + PlanComboBox.SelectedValue.ToString + "','" _
                                                                + curMonth + "') "
            command.ExecuteNonQuery()

            'Inform of successful addition
            If personExists Then
                MsgBox("Successfully added existing person as customer")
            Else
                MsgBox("Successfully added customer")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
    End Sub

    'Returns the number of logins associated with a PersonID
    Private Function countIdentities(personID As Integer) As Integer
        Dim loginCount As Integer = 0

        Try
            connection.Open()
            command = connection.CreateCommand()
            'First get PersonID since that's the only user data so far not stored in the text fields
            command.CommandText = "select count(*) from Login where PersonID = " + personID.ToString
            loginCount = command.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
        Return loginCount
    End Function

    'Removes a customer and person from database. If person has an employee account, person data is saved
    'TODO: Need to add code for removing movie queue data for a customer account
    Private Sub DeleteCustomer()
        Try
            connection.Open()
            command = connection.CreateCommand()
            'First get PersonID since that's the only user data so far not stored in the text fields
            command.CommandText = "select PersonID from Login where Username = '" + UserNameBox.Text + "'"
            dataReader = command.ExecuteReader()
            dataReader.Read() 'initial read for data
            Dim PersonID As Long = dataReader(0)
            dataReader.Close()

            'All data necessary to delete should be loaded into the text boxes
            'First delete subscription
            command.CommandText = "delete from Subscribe where AccountNo = " + AccountNoBox.Text
            command.ExecuteNonQuery()

            'Next we need to delete all the actor ratings a customer gave
            command.CommandText = "delete from ActorRating where PersonID = " + PersonID.ToString
            command.ExecuteNonQuery()

            'Then delete customer account
            command.CommandText = "delete from Customer where AccountNo = " + AccountNoBox.Text
            command.ExecuteNonQuery()

            'Then delete login information
            command.CommandText = "delete from Login where PersonID = " + PersonID.ToString
            command.ExecuteNonQuery()

            'Then delete Person Information only if there is one login account associated with it
            'A person can have multiple login identities if they are an employee and a customer
            connection.Close()
            If countIdentities(PersonID) = 0 Then
                connection.Open()
                command.CommandText = "delete from Person where PersonID = " + PersonID.ToString
                command.ExecuteNonQuery()
            End If

            MsgBox("Customer Deleted")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
    End Sub

    Private Sub UpdateCustomer()
        Try
            connection.Open()
            command = connection.CreateCommand()
            'We don't want to update username or account number, so skip them
            'Since we haven't made a way to update only the changed fields, lets just update them all

            'Update the editabble password field (so we can change account passwords)
            command.CommandText = "Update Login set [Password] = '" + PassWordBox.Text + "' where [Username] = '" + UserNameBox.Text + "'"
            command.ExecuteNonQuery()

            'Update relevent Customer data (Email and Credit card number)
            command.CommandText = "Update Customer set Email = '" + EmailBox.Text + "', CreditCard = '" + CreditCardBox.Text + "'" _
                                + " where AccountNo = " + AccountNoBox.Text
            command.ExecuteNonQuery()

            'Now to update Person information
            'First get PersonID since that's the only user data so far not stored in the text fields
            command.CommandText = "select PersonID from Login where Username = '" + UserNameBox.Text + "'"
            dataReader = command.ExecuteReader()
            dataReader.Read() 'initial read for data
            Dim PersonID As Long = dataReader(0)
            dataReader.Close()

            'Now to update changes to Person fields
            command.CommandText = "Update Person set FamilyName = '" + FnameBox.Text + "', " _
                                + "GivenName = '" + LnameBox.Text + "', " _
                                + "City = '" + CityBox.Text + "', " _
                                + "Address = '" + AddressBox.Text + "', " _
                                + "State = '" + StateBox.Text + "', " _
                                + "Zip = '" + ZipBox.Text + "', " _
                                + "Phone = '" + PhoneBox.Text + "'" _
                                + " where PersonID = " + PersonID.ToString
            command.ExecuteNonQuery()

            'Update customers next month subscriptions field
            Dim curMonth = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            'If user was added before the addition of keeping track of next months plan, insert their plan on update
            If missingNextPlan Then
                command.CommandText = "insert into Subscribe values (" + AccountNoBox.Text + ",'" + NextPlanComboBox.SelectedValue.ToString _
                                    + "',#" + curMonth.AddMonths(1) + "#) "
                missingNextPlan = False
            Else
                command.CommandText = "Update Subscribe set PlanID = '" + NextPlanComboBox.SelectedValue.ToString + "' " _
                                        + "where AccountNo = " + AccountNoBox.Text + " and" _
                                        + " theDate >= #" + curMonth + "# and theDate < #" + curMonth.AddMonths(1) + "#"
            End If

            command.ExecuteNonQuery()
            MsgBox("Updated User")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connection.Close()
    End Sub


    Private Sub refreshFields()
        'Otherwise, depending if tehre is an account with the name, change the update button
        If UserNameBox.Text <> Nothing Then
            'Check if employee
            If isEmployee(UserNameBox.Text) = False Then
                If getAccountInfo(UserNameBox.Text) = False Then
                    'No User account tied to username
                    SetPersonExists(False)
                    MsgBox("User name is available for new account")
                    EnableAddCustomer(True)
                Else
                    'Otherwise, account belongs to an employee
                    EnableAddCustomer(False)
                End If
            Else
                'Is Employee
                MsgBox("Account belongs to an Employee")
                EnableAddCustomer(False)
                DisableForInvalidUserName()
            End If
        Else
            'Clear all forms if username is nothing
            For Each txtBox In Me.Controls
                If txtBox.GetType() Is GetType(TextBox) Then
                    txtBox.Text = Nothing
                End If
                PlanComboBox.SelectedIndex = 0
                NextPlanComboBox.SelectedIndex = 0
            Next
            DisableForInvalidUserName()
        End If
    End Sub

    'Returns true if all the required data to add / edit a user has been filled in
    Private Function safeToAdd() As Boolean
        Return UserNameBox.Text <> Nothing And PassWordBox.Text <> Nothing And FnameBox.Text <> Nothing And
            LnameBox.Text <> Nothing And CreditCardBox.Text <> Nothing And PhoneBox.Text <> Nothing And ZipBox.Text <> Nothing
    End Function

    Private Sub AccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This method initially opens the connection with the database here to populate
        populatePlanComboBox()
        EnableAddCustomer(False)
        refreshFields()
    End Sub

    'Update or add information on this click
    Private Sub EditAccountButton_Click(sender As Object, e As EventArgs) Handles EditAccountButton.Click
        If safeToAdd() Then
            If isAddEnabled() = False Then
                AddAccount()
            Else
                UpdateCustomer()
            End If
            refreshFields()
        Else
            MsgBox("Missing required data!")
        End If


    End Sub

    'Go back to previous window
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'if in the midst of adding a customer, we can cancel doing so
        If isAddEnabled() Then
            EnableAddCustomer(False)
            UserNameBox.Text = Nothing
            refreshFields()
        Else
            'Otherwise, just close the form
            Me.Close()
        End If
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        DeleteCustomer()
        refreshFields()
    End Sub

    Private Sub FindIDButton_Click(sender As Object, e As EventArgs) Handles FindIDButton.Click
        PersonLookUp.OpenFrom(Me)

    End Sub

    Private Sub SearchUserNameButton_Click(sender As Object, e As EventArgs) Handles SearchUserNameButton.Click
        refreshFields()
    End Sub
End Class 'end of AccountInfo




'Plan Type for combobox usage
Public Class PlanType
    Public Sub New(ByVal id As Integer, ByVal name As String)
        planID = id
        planName = name
    End Sub

    Private planID As Integer
    Public Property ID() As Integer
        Get
            Return planID
        End Get
        Set(ByVal value As Integer)
            planID = value
        End Set
    End Property

    Private planName As String
    Public Property Name() As String
        Get
            Return planName
        End Get
        Set(ByVal value As String)
            planName = value
        End Set
    End Property
End Class

