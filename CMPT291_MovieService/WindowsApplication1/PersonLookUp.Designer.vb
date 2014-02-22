<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonLookUp
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
        Me.LnameBox = New System.Windows.Forms.TextBox()
        Me.FnameBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PersonIDBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PhoneBox
        '
        Me.PhoneBox.HideSelection = False
        Me.PhoneBox.Location = New System.Drawing.Point(103, 178)
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(240, 20)
        Me.PhoneBox.TabIndex = 35
        '
        'ZipBox
        '
        Me.ZipBox.HideSelection = False
        Me.ZipBox.Location = New System.Drawing.Point(103, 143)
        Me.ZipBox.Name = "ZipBox"
        Me.ZipBox.Size = New System.Drawing.Size(240, 20)
        Me.ZipBox.TabIndex = 34
        '
        'LnameBox
        '
        Me.LnameBox.HideSelection = False
        Me.LnameBox.Location = New System.Drawing.Point(103, 98)
        Me.LnameBox.Name = "LnameBox"
        Me.LnameBox.Size = New System.Drawing.Size(240, 20)
        Me.LnameBox.TabIndex = 30
        '
        'FnameBox
        '
        Me.FnameBox.HideSelection = False
        Me.FnameBox.Location = New System.Drawing.Point(103, 67)
        Me.FnameBox.Name = "FnameBox"
        Me.FnameBox.Size = New System.Drawing.Size(240, 20)
        Me.FnameBox.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Phone No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Postal/Zip Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = " Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = " First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Person ID Lookup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Search By:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(236, 237)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(107, 42)
        Me.SearchButton.TabIndex = 39
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ResultBox
        '
        Me.ResultBox.FormattingEnabled = True
        Me.ResultBox.Location = New System.Drawing.Point(412, 67)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(308, 173)
        Me.ResultBox.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Results:"
        '
        'PersonIDBox
        '
        Me.PersonIDBox.Enabled = False
        Me.PersonIDBox.Location = New System.Drawing.Point(505, 249)
        Me.PersonIDBox.Name = "PersonIDBox"
        Me.PersonIDBox.Size = New System.Drawing.Size(215, 20)
        Me.PersonIDBox.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "PersonID No."
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(103, 237)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(102, 41)
        Me.CloseButton.TabIndex = 44
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(550, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 36)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Export Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PersonLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 333)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PersonIDBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.ZipBox)
        Me.Controls.Add(Me.LnameBox)
        Me.Controls.Add(Me.FnameBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "PersonLookUp"
        Me.Text = "PersonLookUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PhoneBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipBox As System.Windows.Forms.TextBox
    Friend WithEvents LnameBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ResultBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PersonIDBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
