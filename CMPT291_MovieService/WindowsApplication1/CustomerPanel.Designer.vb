<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPanel
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
        Me.LoggedInStr = New System.Windows.Forms.Label()
        Me.AccountInfoButton = New System.Windows.Forms.Button()
        Me.ActorSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(92, 181)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(114, 46)
        Me.LogOutButton.TabIndex = 0
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'LoggedInStr
        '
        Me.LoggedInStr.AutoSize = True
        Me.LoggedInStr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoggedInStr.Location = New System.Drawing.Point(60, 16)
        Me.LoggedInStr.Name = "LoggedInStr"
        Me.LoggedInStr.Size = New System.Drawing.Size(0, 13)
        Me.LoggedInStr.TabIndex = 1
        '
        'AccountInfoButton
        '
        Me.AccountInfoButton.Location = New System.Drawing.Point(92, 51)
        Me.AccountInfoButton.Name = "AccountInfoButton"
        Me.AccountInfoButton.Size = New System.Drawing.Size(95, 35)
        Me.AccountInfoButton.TabIndex = 2
        Me.AccountInfoButton.Text = "Account Info."
        Me.AccountInfoButton.UseVisualStyleBackColor = True
        '
        'ActorSearch
        '
        Me.ActorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActorSearch.Location = New System.Drawing.Point(94, 136)
        Me.ActorSearch.Name = "ActorSearch"
        Me.ActorSearch.Size = New System.Drawing.Size(93, 39)
        Me.ActorSearch.TabIndex = 3
        Me.ActorSearch.Text = "Seach Actors"
        Me.ActorSearch.UseVisualStyleBackColor = True
        '
        'CustomerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ActorSearch)
        Me.Controls.Add(Me.AccountInfoButton)
        Me.Controls.Add(Me.LoggedInStr)
        Me.Controls.Add(Me.LogOutButton)
        Me.Name = "CustomerPanel"
        Me.Text = "CustomerPanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents LoggedInStr As System.Windows.Forms.Label
    Friend WithEvents AccountInfoButton As System.Windows.Forms.Button
    Friend WithEvents ActorSearch As System.Windows.Forms.Button
End Class
