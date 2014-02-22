<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActorInfo
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.ListBox()
        Me.LnameBox = New System.Windows.Forms.TextBox()
        Me.FnameBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RateBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DeleteEmployeeButton = New System.Windows.Forms.Button()
        Me.NewEmployeeButton = New System.Windows.Forms.Button()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.DayBox = New System.Windows.Forms.TextBox()
        Me.MonthBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ActedInButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ActorIDBox = New System.Windows.Forms.TextBox()
        Me.RateActorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(393, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Actors:"
        '
        'ResultBox
        '
        Me.ResultBox.FormattingEnabled = True
        Me.ResultBox.Location = New System.Drawing.Point(396, 61)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(337, 316)
        Me.ResultBox.TabIndex = 46
        '
        'LnameBox
        '
        Me.LnameBox.Enabled = False
        Me.LnameBox.Location = New System.Drawing.Point(92, 92)
        Me.LnameBox.Name = "LnameBox"
        Me.LnameBox.Size = New System.Drawing.Size(240, 20)
        Me.LnameBox.TabIndex = 45
        '
        'FnameBox
        '
        Me.FnameBox.Enabled = False
        Me.FnameBox.Location = New System.Drawing.Point(92, 61)
        Me.FnameBox.Name = "FnameBox"
        Me.FnameBox.Size = New System.Drawing.Size(240, 20)
        Me.FnameBox.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "* Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "* First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "* Gender:"
        '
        'AgeBox
        '
        Me.AgeBox.Enabled = False
        Me.AgeBox.Location = New System.Drawing.Point(92, 183)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(240, 20)
        Me.AgeBox.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "* Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "* Rating:"
        '
        'RateBox
        '
        Me.RateBox.Enabled = False
        Me.RateBox.Location = New System.Drawing.Point(92, 237)
        Me.RateBox.Name = "RateBox"
        Me.RateBox.Size = New System.Drawing.Size(240, 20)
        Me.RateBox.TabIndex = 54
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(92, 132)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(240, 21)
        Me.GenderComboBox.TabIndex = 56
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(279, 473)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(93, 42)
        Me.CancelButton.TabIndex = 64
        Me.CancelButton.Text = "Close"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'DeleteEmployeeButton
        '
        Me.DeleteEmployeeButton.Location = New System.Drawing.Point(399, 473)
        Me.DeleteEmployeeButton.Name = "DeleteEmployeeButton"
        Me.DeleteEmployeeButton.Size = New System.Drawing.Size(93, 42)
        Me.DeleteEmployeeButton.TabIndex = 63
        Me.DeleteEmployeeButton.Text = "Remove Actor"
        Me.DeleteEmployeeButton.UseVisualStyleBackColor = True
        '
        'NewEmployeeButton
        '
        Me.NewEmployeeButton.Location = New System.Drawing.Point(518, 473)
        Me.NewEmployeeButton.Name = "NewEmployeeButton"
        Me.NewEmployeeButton.Size = New System.Drawing.Size(93, 42)
        Me.NewEmployeeButton.TabIndex = 62
        Me.NewEmployeeButton.Text = "New Actor"
        Me.NewEmployeeButton.UseVisualStyleBackColor = True
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Location = New System.Drawing.Point(644, 473)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(93, 42)
        Me.AddUpdateButton.TabIndex = 61
        Me.AddUpdateButton.Text = "Update Actor"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        '
        'DayBox
        '
        Me.DayBox.Enabled = False
        Me.DayBox.Location = New System.Drawing.Point(92, 318)
        Me.DayBox.Name = "DayBox"
        Me.DayBox.Size = New System.Drawing.Size(240, 20)
        Me.DayBox.TabIndex = 65
        '
        'MonthBox
        '
        Me.MonthBox.Enabled = False
        Me.MonthBox.Location = New System.Drawing.Point(92, 353)
        Me.MonthBox.Name = "MonthBox"
        Me.MonthBox.Size = New System.Drawing.Size(240, 20)
        Me.MonthBox.TabIndex = 66
        '
        'YearBox
        '
        Me.YearBox.Enabled = False
        Me.YearBox.Location = New System.Drawing.Point(92, 389)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(240, 20)
        Me.YearBox.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "* Day:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "* Month:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "* Year:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Birth Date Info:"
        '
        'ActedInButton
        '
        Me.ActedInButton.Location = New System.Drawing.Point(32, 473)
        Me.ActedInButton.Name = "ActedInButton"
        Me.ActedInButton.Size = New System.Drawing.Size(93, 42)
        Me.ActedInButton.TabIndex = 72
        Me.ActedInButton.Text = "View Moives Acted In"
        Me.ActedInButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 395)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Actor ID:"
        '
        'ActorIDBox
        '
        Me.ActorIDBox.Enabled = False
        Me.ActorIDBox.Location = New System.Drawing.Point(466, 392)
        Me.ActorIDBox.Name = "ActorIDBox"
        Me.ActorIDBox.Size = New System.Drawing.Size(240, 20)
        Me.ActorIDBox.TabIndex = 73
        '
        'RateActorButton
        '
        Me.RateActorButton.Location = New System.Drawing.Point(529, 418)
        Me.RateActorButton.Name = "RateActorButton"
        Me.RateActorButton.Size = New System.Drawing.Size(82, 24)
        Me.RateActorButton.TabIndex = 75
        Me.RateActorButton.Text = "Rate Actor"
        Me.RateActorButton.UseVisualStyleBackColor = True
        '
        'ActorInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.RateActorButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ActorIDBox)
        Me.Controls.Add(Me.ActedInButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.MonthBox)
        Me.Controls.Add(Me.DayBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DeleteEmployeeButton)
        Me.Controls.Add(Me.NewEmployeeButton)
        Me.Controls.Add(Me.AddUpdateButton)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RateBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.LnameBox)
        Me.Controls.Add(Me.FnameBox)
        Me.Name = "ActorInfo"
        Me.Text = "ActorInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ResultBox As System.Windows.Forms.ListBox
    Friend WithEvents LnameBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AgeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RateBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents DeleteEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents NewEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents AddUpdateButton As System.Windows.Forms.Button
    Friend WithEvents DayBox As System.Windows.Forms.TextBox
    Friend WithEvents MonthBox As System.Windows.Forms.TextBox
    Friend WithEvents YearBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ActedInButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ActorIDBox As System.Windows.Forms.TextBox
    Friend WithEvents RateActorButton As System.Windows.Forms.Button
End Class
