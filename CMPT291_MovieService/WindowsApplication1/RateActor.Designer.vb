<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RateActor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RateStatusStr = New System.Windows.Forms.Label()
        Me.AvgRateBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.ActorIDStr = New System.Windows.Forms.Label()
        Me.RadioBox = New System.Windows.Forms.GroupBox()
        Me.RadioBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rating for:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(52, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(89, 12)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(126, 12)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(163, 12)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Excellent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Poor"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(173, 207)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(79, 25)
        Me.SubmitButton.TabIndex = 8
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(88, 207)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(79, 25)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Average Rating:"
        '
        'RateStatusStr
        '
        Me.RateStatusStr.AutoSize = True
        Me.RateStatusStr.Location = New System.Drawing.Point(119, 131)
        Me.RateStatusStr.Name = "RateStatusStr"
        Me.RateStatusStr.Size = New System.Drawing.Size(83, 13)
        Me.RateStatusStr.TabIndex = 11
        Me.RateStatusStr.Text = "What you rated:"
        '
        'AvgRateBox
        '
        Me.AvgRateBox.Enabled = False
        Me.AvgRateBox.Location = New System.Drawing.Point(122, 72)
        Me.AvgRateBox.Name = "AvgRateBox"
        Me.AvgRateBox.Size = New System.Drawing.Size(186, 20)
        Me.AvgRateBox.TabIndex = 12
        '
        'NameBox
        '
        Me.NameBox.Enabled = False
        Me.NameBox.Location = New System.Drawing.Point(122, 46)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(186, 20)
        Me.NameBox.TabIndex = 13
        '
        'ActorIDStr
        '
        Me.ActorIDStr.AutoSize = True
        Me.ActorIDStr.Location = New System.Drawing.Point(55, 20)
        Me.ActorIDStr.Name = "ActorIDStr"
        Me.ActorIDStr.Size = New System.Drawing.Size(46, 13)
        Me.ActorIDStr.TabIndex = 14
        Me.ActorIDStr.Text = "ActorID:"
        '
        'RadioBox
        '
        Me.RadioBox.Controls.Add(Me.RadioButton1)
        Me.RadioBox.Controls.Add(Me.RadioButton2)
        Me.RadioBox.Controls.Add(Me.RadioButton3)
        Me.RadioBox.Controls.Add(Me.RadioButton4)
        Me.RadioBox.Controls.Add(Me.RadioButton5)
        Me.RadioBox.Location = New System.Drawing.Point(58, 147)
        Me.RadioBox.Name = "RadioBox"
        Me.RadioBox.Size = New System.Drawing.Size(203, 34)
        Me.RadioBox.TabIndex = 15
        Me.RadioBox.TabStop = False
        '
        'RateActor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 261)
        Me.Controls.Add(Me.RadioBox)
        Me.Controls.Add(Me.ActorIDStr)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.AvgRateBox)
        Me.Controls.Add(Me.RateStatusStr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RateActor"
        Me.Text = "RateActor"
        Me.RadioBox.ResumeLayout(False)
        Me.RadioBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RateStatusStr As System.Windows.Forms.Label
    Friend WithEvents AvgRateBox As System.Windows.Forms.TextBox
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents ActorIDStr As System.Windows.Forms.Label
    Friend WithEvents RadioBox As System.Windows.Forms.GroupBox
End Class
