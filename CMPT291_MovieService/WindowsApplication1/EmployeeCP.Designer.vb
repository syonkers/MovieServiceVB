<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeCP
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
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.UserAccountButton = New System.Windows.Forms.Button()
        Me.ViewEmployeeButton = New System.Windows.Forms.Button()
        Me.MailingListButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(79, 181)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(111, 42)
        Me.LogOutButton.TabIndex = 0
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'UserAccountButton
        '
        Me.UserAccountButton.Location = New System.Drawing.Point(33, 32)
        Me.UserAccountButton.Name = "UserAccountButton"
        Me.UserAccountButton.Size = New System.Drawing.Size(84, 48)
        Me.UserAccountButton.TabIndex = 1
        Me.UserAccountButton.Text = "User Accounts"
        Me.UserAccountButton.UseVisualStyleBackColor = True
        '
        'ViewEmployeeButton
        '
        Me.ViewEmployeeButton.Location = New System.Drawing.Point(169, 31)
        Me.ViewEmployeeButton.Name = "ViewEmployeeButton"
        Me.ViewEmployeeButton.Size = New System.Drawing.Size(81, 48)
        Me.ViewEmployeeButton.TabIndex = 2
        Me.ViewEmployeeButton.Text = "View Employees"
        Me.ViewEmployeeButton.UseVisualStyleBackColor = True
        '
        'MailingListButton
        '
        Me.MailingListButton.Location = New System.Drawing.Point(33, 99)
        Me.MailingListButton.Name = "MailingListButton"
        Me.MailingListButton.Size = New System.Drawing.Size(84, 45)
        Me.MailingListButton.TabIndex = 3
        Me.MailingListButton.Text = "Mailing List"
        Me.MailingListButton.UseVisualStyleBackColor = True
        '
        'EmployeeCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MailingListButton)
        Me.Controls.Add(Me.ViewEmployeeButton)
        Me.Controls.Add(Me.UserAccountButton)
        Me.Controls.Add(Me.LogOutButton)
        Me.Name = "EmployeeCP"
        Me.Text = "EmployeeCP"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents UserAccountButton As System.Windows.Forms.Button
    Friend WithEvents ViewEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents MailingListButton As System.Windows.Forms.Button
End Class
