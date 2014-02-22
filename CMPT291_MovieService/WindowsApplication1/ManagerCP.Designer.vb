<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerCP
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
        Me.ViewEmployeeButton = New System.Windows.Forms.Button()
        Me.ViewAccountPlansButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MoviesButton = New System.Windows.Forms.Button()
        Me.ViewRentalsButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.LoggedInStr = New System.Windows.Forms.Label()
        Me.ActorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ViewEmployeeButton
        '
        Me.ViewEmployeeButton.Location = New System.Drawing.Point(12, 42)
        Me.ViewEmployeeButton.Name = "ViewEmployeeButton"
        Me.ViewEmployeeButton.Size = New System.Drawing.Size(102, 38)
        Me.ViewEmployeeButton.TabIndex = 0
        Me.ViewEmployeeButton.Text = "View Employees"
        Me.ViewEmployeeButton.UseVisualStyleBackColor = True
        '
        'ViewAccountPlansButton
        '
        Me.ViewAccountPlansButton.Location = New System.Drawing.Point(135, 42)
        Me.ViewAccountPlansButton.Name = "ViewAccountPlansButton"
        Me.ViewAccountPlansButton.Size = New System.Drawing.Size(103, 38)
        Me.ViewAccountPlansButton.TabIndex = 1
        Me.ViewAccountPlansButton.Text = "View Account Plans"
        Me.ViewAccountPlansButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Manager Control Panel"
        '
        'MoviesButton
        '
        Me.MoviesButton.Location = New System.Drawing.Point(12, 99)
        Me.MoviesButton.Name = "MoviesButton"
        Me.MoviesButton.Size = New System.Drawing.Size(101, 35)
        Me.MoviesButton.TabIndex = 3
        Me.MoviesButton.Text = "Movies"
        Me.MoviesButton.UseVisualStyleBackColor = True
        '
        'ViewRentalsButton
        '
        Me.ViewRentalsButton.Location = New System.Drawing.Point(135, 97)
        Me.ViewRentalsButton.Name = "ViewRentalsButton"
        Me.ViewRentalsButton.Size = New System.Drawing.Size(102, 36)
        Me.ViewRentalsButton.TabIndex = 4
        Me.ViewRentalsButton.Text = "View Rentals"
        Me.ViewRentalsButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(73, 211)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(93, 31)
        Me.LogoutButton.TabIndex = 5
        Me.LogoutButton.Text = "Log Out"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'LoggedInStr
        '
        Me.LoggedInStr.AutoSize = True
        Me.LoggedInStr.Location = New System.Drawing.Point(35, 177)
        Me.LoggedInStr.Name = "LoggedInStr"
        Me.LoggedInStr.Size = New System.Drawing.Size(0, 13)
        Me.LoggedInStr.TabIndex = 6
        Me.LoggedInStr.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ActorButton
        '
        Me.ActorButton.Location = New System.Drawing.Point(17, 149)
        Me.ActorButton.Name = "ActorButton"
        Me.ActorButton.Size = New System.Drawing.Size(95, 28)
        Me.ActorButton.TabIndex = 7
        Me.ActorButton.Text = "View Actors"
        Me.ActorButton.UseVisualStyleBackColor = True
        '
        'ManagerCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 254)
        Me.Controls.Add(Me.ActorButton)
        Me.Controls.Add(Me.LoggedInStr)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ViewRentalsButton)
        Me.Controls.Add(Me.MoviesButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewAccountPlansButton)
        Me.Controls.Add(Me.ViewEmployeeButton)
        Me.Name = "ManagerCP"
        Me.Text = "ManagerCP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents ViewAccountPlansButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MoviesButton As System.Windows.Forms.Button
    Friend WithEvents ViewRentalsButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents LoggedInStr As System.Windows.Forms.Label
    Friend WithEvents ActorButton As System.Windows.Forms.Button
End Class
