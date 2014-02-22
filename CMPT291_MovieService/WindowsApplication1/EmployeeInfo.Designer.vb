<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.ZipBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.LnameBox = New System.Windows.Forms.TextBox()
        Me.FnameBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserNameBox = New System.Windows.Forms.TextBox()
        Me.PassWordBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginDetailsStr = New System.Windows.Forms.Label()
        Me.PasswordStr = New System.Windows.Forms.Label()
        Me.UsernameStr = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDateBox = New System.Windows.Forms.TextBox()
        Me.HourlyRateBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HourlyRateStr = New System.Windows.Forms.Label()
        Me.PositionBox = New System.Windows.Forms.ComboBox()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.NewEmployeeButton = New System.Windows.Forms.Button()
        Me.FindIDButton = New System.Windows.Forms.Button()
        Me.LinkCustStr = New System.Windows.Forms.Label()
        Me.DeleteEmployeeButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SSNumbBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(160, 272)
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(240, 20)
        Me.PhoneBox.TabIndex = 41
        '
        'ZipBox
        '
        Me.ZipBox.Location = New System.Drawing.Point(160, 234)
        Me.ZipBox.Name = "ZipBox"
        Me.ZipBox.Size = New System.Drawing.Size(240, 20)
        Me.ZipBox.TabIndex = 40
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(160, 190)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(240, 20)
        Me.StateBox.TabIndex = 39
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(160, 148)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(240, 20)
        Me.AddressBox.TabIndex = 38
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(160, 108)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(240, 20)
        Me.CityBox.TabIndex = 37
        '
        'LnameBox
        '
        Me.LnameBox.Location = New System.Drawing.Point(160, 82)
        Me.LnameBox.Name = "LnameBox"
        Me.LnameBox.Size = New System.Drawing.Size(240, 20)
        Me.LnameBox.TabIndex = 36
        '
        'FnameBox
        '
        Me.FnameBox.Location = New System.Drawing.Point(160, 51)
        Me.FnameBox.Name = "FnameBox"
        Me.FnameBox.Size = New System.Drawing.Size(240, 20)
        Me.FnameBox.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(96, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "* Phone No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "* Postal/Zip Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "* State/Province:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "* Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "* City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "* Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "* First Name:"
        '
        'UserNameBox
        '
        Me.UserNameBox.Enabled = False
        Me.UserNameBox.Location = New System.Drawing.Point(161, 466)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.Size = New System.Drawing.Size(240, 20)
        Me.UserNameBox.TabIndex = 27
        Me.UserNameBox.Visible = False
        '
        'PassWordBox
        '
        Me.PassWordBox.AcceptsReturn = True
        Me.PassWordBox.Enabled = False
        Me.PassWordBox.Location = New System.Drawing.Point(161, 498)
        Me.PassWordBox.Name = "PassWordBox"
        Me.PassWordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassWordBox.Size = New System.Drawing.Size(240, 20)
        Me.PassWordBox.TabIndex = 26
        Me.PassWordBox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Personal Data:"
        '
        'LoginDetailsStr
        '
        Me.LoginDetailsStr.AutoSize = True
        Me.LoginDetailsStr.Location = New System.Drawing.Point(59, 445)
        Me.LoginDetailsStr.Name = "LoginDetailsStr"
        Me.LoginDetailsStr.Size = New System.Drawing.Size(71, 13)
        Me.LoginDetailsStr.TabIndex = 24
        Me.LoginDetailsStr.Text = "Login Details:"
        Me.LoginDetailsStr.Visible = False
        '
        'PasswordStr
        '
        Me.PasswordStr.AutoSize = True
        Me.PasswordStr.Location = New System.Drawing.Point(93, 498)
        Me.PasswordStr.Name = "PasswordStr"
        Me.PasswordStr.Size = New System.Drawing.Size(63, 13)
        Me.PasswordStr.TabIndex = 23
        Me.PasswordStr.Text = "* Password:"
        Me.PasswordStr.Visible = False
        '
        'UsernameStr
        '
        Me.UsernameStr.AutoSize = True
        Me.UsernameStr.Location = New System.Drawing.Point(85, 469)
        Me.UsernameStr.Name = "UsernameStr"
        Me.UsernameStr.Size = New System.Drawing.Size(70, 13)
        Me.UsernameStr.TabIndex = 22
        Me.UsernameStr.Text = "* User Name:"
        Me.UsernameStr.Visible = False
        '
        'ResultBox
        '
        Me.ResultBox.FormattingEnabled = True
        Me.ResultBox.Location = New System.Drawing.Point(505, 49)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(337, 355)
        Me.ResultBox.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(502, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Employees:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Employee Info:"
        '
        'StartDateBox
        '
        Me.StartDateBox.Enabled = False
        Me.StartDateBox.Location = New System.Drawing.Point(160, 360)
        Me.StartDateBox.Name = "StartDateBox"
        Me.StartDateBox.Size = New System.Drawing.Size(240, 20)
        Me.StartDateBox.TabIndex = 46
        '
        'HourlyRateBox
        '
        Me.HourlyRateBox.Location = New System.Drawing.Point(160, 386)
        Me.HourlyRateBox.Name = "HourlyRateBox"
        Me.HourlyRateBox.Size = New System.Drawing.Size(240, 20)
        Me.HourlyRateBox.TabIndex = 47
        Me.HourlyRateBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "* Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Start Date:"
        '
        'HourlyRateStr
        '
        Me.HourlyRateStr.AutoSize = True
        Me.HourlyRateStr.Location = New System.Drawing.Point(87, 389)
        Me.HourlyRateStr.Name = "HourlyRateStr"
        Me.HourlyRateStr.Size = New System.Drawing.Size(73, 13)
        Me.HourlyRateStr.TabIndex = 50
        Me.HourlyRateStr.Text = "* Hourly Rate:"
        Me.HourlyRateStr.Visible = False
        '
        'PositionBox
        '
        Me.PositionBox.FormattingEnabled = True
        Me.PositionBox.Location = New System.Drawing.Point(160, 334)
        Me.PositionBox.Name = "PositionBox"
        Me.PositionBox.Size = New System.Drawing.Size(240, 21)
        Me.PositionBox.TabIndex = 51
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Location = New System.Drawing.Point(553, 545)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(93, 42)
        Me.AddUpdateButton.TabIndex = 52
        Me.AddUpdateButton.Text = "Update Employee"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        Me.AddUpdateButton.Visible = False
        '
        'NewEmployeeButton
        '
        Me.NewEmployeeButton.Location = New System.Drawing.Point(427, 545)
        Me.NewEmployeeButton.Name = "NewEmployeeButton"
        Me.NewEmployeeButton.Size = New System.Drawing.Size(93, 42)
        Me.NewEmployeeButton.TabIndex = 53
        Me.NewEmployeeButton.Text = "New Employee"
        Me.NewEmployeeButton.UseVisualStyleBackColor = True
        Me.NewEmployeeButton.Visible = False
        '
        'FindIDButton
        '
        Me.FindIDButton.Location = New System.Drawing.Point(680, 458)
        Me.FindIDButton.Name = "FindIDButton"
        Me.FindIDButton.Size = New System.Drawing.Size(162, 24)
        Me.FindIDButton.TabIndex = 58
        Me.FindIDButton.Text = "Find Person"
        Me.FindIDButton.UseVisualStyleBackColor = True
        Me.FindIDButton.Visible = False
        '
        'LinkCustStr
        '
        Me.LinkCustStr.AutoSize = True
        Me.LinkCustStr.Location = New System.Drawing.Point(677, 434)
        Me.LinkCustStr.Name = "LinkCustStr"
        Me.LinkCustStr.Size = New System.Drawing.Size(167, 13)
        Me.LinkCustStr.TabIndex = 54
        Me.LinkCustStr.Text = "Link Employee To Existing Person"
        Me.LinkCustStr.Visible = False
        '
        'DeleteEmployeeButton
        '
        Me.DeleteEmployeeButton.Location = New System.Drawing.Point(308, 545)
        Me.DeleteEmployeeButton.Name = "DeleteEmployeeButton"
        Me.DeleteEmployeeButton.Size = New System.Drawing.Size(93, 42)
        Me.DeleteEmployeeButton.TabIndex = 59
        Me.DeleteEmployeeButton.Text = "Remove Employee"
        Me.DeleteEmployeeButton.UseVisualStyleBackColor = True
        Me.DeleteEmployeeButton.Visible = False
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(188, 545)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(93, 42)
        Me.CancelButton.TabIndex = 60
        Me.CancelButton.Text = "Close"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "* Social Security Number:"
        Me.Label13.Visible = False
        '
        'SSNumbBox
        '
        Me.SSNumbBox.Location = New System.Drawing.Point(160, 412)
        Me.SSNumbBox.Name = "SSNumbBox"
        Me.SSNumbBox.Size = New System.Drawing.Size(240, 20)
        Me.SSNumbBox.TabIndex = 61
        Me.SSNumbBox.Visible = False
        '
        'EmployeeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 616)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SSNumbBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DeleteEmployeeButton)
        Me.Controls.Add(Me.FindIDButton)
        Me.Controls.Add(Me.LinkCustStr)
        Me.Controls.Add(Me.NewEmployeeButton)
        Me.Controls.Add(Me.AddUpdateButton)
        Me.Controls.Add(Me.PositionBox)
        Me.Controls.Add(Me.HourlyRateStr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HourlyRateBox)
        Me.Controls.Add(Me.StartDateBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.ZipBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.LnameBox)
        Me.Controls.Add(Me.FnameBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UserNameBox)
        Me.Controls.Add(Me.PassWordBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LoginDetailsStr)
        Me.Controls.Add(Me.PasswordStr)
        Me.Controls.Add(Me.UsernameStr)
        Me.Name = "EmployeeInfo"
        Me.Text = "EmployeeInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PhoneBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipBox As System.Windows.Forms.TextBox
    Friend WithEvents StateBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressBox As System.Windows.Forms.TextBox
    Friend WithEvents CityBox As System.Windows.Forms.TextBox
    Friend WithEvents LnameBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UserNameBox As System.Windows.Forms.TextBox
    Friend WithEvents PassWordBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LoginDetailsStr As System.Windows.Forms.Label
    Friend WithEvents PasswordStr As System.Windows.Forms.Label
    Friend WithEvents UsernameStr As System.Windows.Forms.Label
    Friend WithEvents ResultBox As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDateBox As System.Windows.Forms.TextBox
    Friend WithEvents HourlyRateBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HourlyRateStr As System.Windows.Forms.Label
    Friend WithEvents PositionBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddUpdateButton As System.Windows.Forms.Button
    Friend WithEvents NewEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents FindIDButton As System.Windows.Forms.Button
    Friend WithEvents LinkCustStr As System.Windows.Forms.Label
    Friend WithEvents DeleteEmployeeButton As System.Windows.Forms.Button
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SSNumbBox As System.Windows.Forms.TextBox
End Class
