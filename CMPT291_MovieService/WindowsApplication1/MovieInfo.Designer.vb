<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieInfo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.movieNameBox = New System.Windows.Forms.TextBox()
        Me.movieRatingBox = New System.Windows.Forms.TextBox()
        Me.movieCopiesBox = New System.Windows.Forms.TextBox()
        Me.movieCostBox = New System.Windows.Forms.TextBox()
        Me.actorMovieBox = New System.Windows.Forms.ComboBox()
        Me.movieListBox = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addMovieBtn = New System.Windows.Forms.Button()
        Me.editMovieBtn = New System.Windows.Forms.Button()
        Me.deleteMovieBtn = New System.Windows.Forms.Button()
        Me.addActorBtn = New System.Windows.Forms.Button()
        Me.deleteActorBtn = New System.Windows.Forms.Button()
        Me.movieGenreBox = New System.Windows.Forms.ComboBox()
        Me.allActorBox = New System.Windows.Forms.ListBox()
        Me.addedActorsBox = New System.Windows.Forms.ListBox()
        Me.addGenreBtn = New System.Windows.Forms.Button()
        Me.removeGenreBtn = New System.Windows.Forms.Button()
        Me.allGenreBox = New System.Windows.Forms.ListBox()
        Me.addedGenreBox = New System.Windows.Forms.ListBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.warningLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Info:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Movie Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Actors:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rating:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Copies:"
        '
        'movieNameBox
        '
        Me.movieNameBox.Location = New System.Drawing.Point(119, 56)
        Me.movieNameBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieNameBox.Name = "movieNameBox"
        Me.movieNameBox.Size = New System.Drawing.Size(185, 20)
        Me.movieNameBox.TabIndex = 7
        '
        'movieRatingBox
        '
        Me.movieRatingBox.Enabled = False
        Me.movieRatingBox.Location = New System.Drawing.Point(119, 234)
        Me.movieRatingBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieRatingBox.Name = "movieRatingBox"
        Me.movieRatingBox.Size = New System.Drawing.Size(185, 20)
        Me.movieRatingBox.TabIndex = 9
        '
        'movieCopiesBox
        '
        Me.movieCopiesBox.Location = New System.Drawing.Point(119, 196)
        Me.movieCopiesBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieCopiesBox.Name = "movieCopiesBox"
        Me.movieCopiesBox.Size = New System.Drawing.Size(185, 20)
        Me.movieCopiesBox.TabIndex = 10
        '
        'movieCostBox
        '
        Me.movieCostBox.Location = New System.Drawing.Point(119, 164)
        Me.movieCostBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieCostBox.Name = "movieCostBox"
        Me.movieCostBox.Size = New System.Drawing.Size(185, 20)
        Me.movieCostBox.TabIndex = 11
        '
        'actorMovieBox
        '
        Me.actorMovieBox.FormattingEnabled = True
        Me.actorMovieBox.Location = New System.Drawing.Point(119, 130)
        Me.actorMovieBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.actorMovieBox.Name = "actorMovieBox"
        Me.actorMovieBox.Size = New System.Drawing.Size(185, 21)
        Me.actorMovieBox.TabIndex = 13
        '
        'movieListBox
        '
        Me.movieListBox.FormattingEnabled = True
        Me.movieListBox.Location = New System.Drawing.Point(315, 56)
        Me.movieListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieListBox.Name = "movieListBox"
        Me.movieListBox.Size = New System.Drawing.Size(227, 199)
        Me.movieListBox.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Movies:"
        '
        'addMovieBtn
        '
        Me.addMovieBtn.Location = New System.Drawing.Point(26, 272)
        Me.addMovieBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addMovieBtn.Name = "addMovieBtn"
        Me.addMovieBtn.Size = New System.Drawing.Size(71, 28)
        Me.addMovieBtn.TabIndex = 16
        Me.addMovieBtn.Text = "Add Movie"
        Me.addMovieBtn.UseVisualStyleBackColor = True
        '
        'editMovieBtn
        '
        Me.editMovieBtn.Location = New System.Drawing.Point(231, 272)
        Me.editMovieBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.editMovieBtn.Name = "editMovieBtn"
        Me.editMovieBtn.Size = New System.Drawing.Size(71, 28)
        Me.editMovieBtn.TabIndex = 17
        Me.editMovieBtn.Text = "Edit Movie"
        Me.editMovieBtn.UseVisualStyleBackColor = True
        '
        'deleteMovieBtn
        '
        Me.deleteMovieBtn.Location = New System.Drawing.Point(119, 272)
        Me.deleteMovieBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.deleteMovieBtn.Name = "deleteMovieBtn"
        Me.deleteMovieBtn.Size = New System.Drawing.Size(94, 28)
        Me.deleteMovieBtn.TabIndex = 18
        Me.deleteMovieBtn.Text = "Delete Movie"
        Me.deleteMovieBtn.UseVisualStyleBackColor = True
        '
        'addActorBtn
        '
        Me.addActorBtn.Location = New System.Drawing.Point(22, 317)
        Me.addActorBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addActorBtn.Name = "addActorBtn"
        Me.addActorBtn.Size = New System.Drawing.Size(120, 25)
        Me.addActorBtn.TabIndex = 19
        Me.addActorBtn.Text = "Add Actor"
        Me.addActorBtn.UseVisualStyleBackColor = True
        Me.addActorBtn.Visible = False
        '
        'deleteActorBtn
        '
        Me.deleteActorBtn.Location = New System.Drawing.Point(159, 317)
        Me.deleteActorBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.deleteActorBtn.Name = "deleteActorBtn"
        Me.deleteActorBtn.Size = New System.Drawing.Size(120, 25)
        Me.deleteActorBtn.TabIndex = 20
        Me.deleteActorBtn.Text = "Delete Actor"
        Me.deleteActorBtn.UseVisualStyleBackColor = True
        Me.deleteActorBtn.Visible = False
        '
        'movieGenreBox
        '
        Me.movieGenreBox.FormattingEnabled = True
        Me.movieGenreBox.Location = New System.Drawing.Point(119, 92)
        Me.movieGenreBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.movieGenreBox.Name = "movieGenreBox"
        Me.movieGenreBox.Size = New System.Drawing.Size(185, 21)
        Me.movieGenreBox.TabIndex = 21
        '
        'allActorBox
        '
        Me.allActorBox.Enabled = False
        Me.allActorBox.FormattingEnabled = True
        Me.allActorBox.Location = New System.Drawing.Point(22, 347)
        Me.allActorBox.Name = "allActorBox"
        Me.allActorBox.Size = New System.Drawing.Size(120, 95)
        Me.allActorBox.TabIndex = 22
        Me.allActorBox.Visible = False
        '
        'addedActorsBox
        '
        Me.addedActorsBox.Enabled = False
        Me.addedActorsBox.FormattingEnabled = True
        Me.addedActorsBox.Location = New System.Drawing.Point(159, 347)
        Me.addedActorsBox.Name = "addedActorsBox"
        Me.addedActorsBox.Size = New System.Drawing.Size(120, 95)
        Me.addedActorsBox.TabIndex = 23
        Me.addedActorsBox.Visible = False
        '
        'addGenreBtn
        '
        Me.addGenreBtn.Location = New System.Drawing.Point(315, 317)
        Me.addGenreBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addGenreBtn.Name = "addGenreBtn"
        Me.addGenreBtn.Size = New System.Drawing.Size(120, 25)
        Me.addGenreBtn.TabIndex = 24
        Me.addGenreBtn.Text = "Add Genre"
        Me.addGenreBtn.UseVisualStyleBackColor = True
        Me.addGenreBtn.Visible = False
        '
        'removeGenreBtn
        '
        Me.removeGenreBtn.Location = New System.Drawing.Point(442, 317)
        Me.removeGenreBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.removeGenreBtn.Name = "removeGenreBtn"
        Me.removeGenreBtn.Size = New System.Drawing.Size(120, 25)
        Me.removeGenreBtn.TabIndex = 25
        Me.removeGenreBtn.Text = "Delete Genre"
        Me.removeGenreBtn.UseVisualStyleBackColor = True
        Me.removeGenreBtn.Visible = False
        '
        'allGenreBox
        '
        Me.allGenreBox.Enabled = False
        Me.allGenreBox.FormattingEnabled = True
        Me.allGenreBox.Location = New System.Drawing.Point(316, 347)
        Me.allGenreBox.Name = "allGenreBox"
        Me.allGenreBox.Size = New System.Drawing.Size(120, 95)
        Me.allGenreBox.TabIndex = 26
        Me.allGenreBox.Visible = False
        '
        'addedGenreBox
        '
        Me.addedGenreBox.Enabled = False
        Me.addedGenreBox.FormattingEnabled = True
        Me.addedGenreBox.Location = New System.Drawing.Point(442, 347)
        Me.addedGenreBox.Name = "addedGenreBox"
        Me.addedGenreBox.Size = New System.Drawing.Size(120, 95)
        Me.addedGenreBox.TabIndex = 27
        Me.addedGenreBox.Visible = False
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(318, 272)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 28)
        Me.cancelBtn.TabIndex = 28
        Me.cancelBtn.Text = "Close"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'confirmBtn
        '
        Me.confirmBtn.Enabled = False
        Me.confirmBtn.Location = New System.Drawing.Point(26, 272)
        Me.confirmBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(71, 28)
        Me.confirmBtn.TabIndex = 29
        Me.confirmBtn.Text = "Confirm"
        Me.confirmBtn.UseVisualStyleBackColor = True
        Me.confirmBtn.Visible = False
        '
        'warningLbl
        '
        Me.warningLbl.AutoSize = True
        Me.warningLbl.Location = New System.Drawing.Point(76, 302)
        Me.warningLbl.Name = "warningLbl"
        Me.warningLbl.Size = New System.Drawing.Size(450, 13)
        Me.warningLbl.TabIndex = 30
        Me.warningLbl.Text = "Warning: Editing erases all genre and actors. Please re-add all genres and actors" & _
    " when editing"
        Me.warningLbl.Visible = False
        '
        'MovieInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 452)
        Me.Controls.Add(Me.warningLbl)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.addedGenreBox)
        Me.Controls.Add(Me.allGenreBox)
        Me.Controls.Add(Me.removeGenreBtn)
        Me.Controls.Add(Me.addGenreBtn)
        Me.Controls.Add(Me.addedActorsBox)
        Me.Controls.Add(Me.allActorBox)
        Me.Controls.Add(Me.movieGenreBox)
        Me.Controls.Add(Me.deleteActorBtn)
        Me.Controls.Add(Me.addActorBtn)
        Me.Controls.Add(Me.deleteMovieBtn)
        Me.Controls.Add(Me.editMovieBtn)
        Me.Controls.Add(Me.addMovieBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.movieListBox)
        Me.Controls.Add(Me.actorMovieBox)
        Me.Controls.Add(Me.movieCostBox)
        Me.Controls.Add(Me.movieCopiesBox)
        Me.Controls.Add(Me.movieRatingBox)
        Me.Controls.Add(Me.movieNameBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MovieInfo"
        Me.Text = "editMovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents movieNameBox As System.Windows.Forms.TextBox
    Friend WithEvents movieRatingBox As System.Windows.Forms.TextBox
    Friend WithEvents movieCopiesBox As System.Windows.Forms.TextBox
    Friend WithEvents movieCostBox As System.Windows.Forms.TextBox
    Friend WithEvents actorMovieBox As System.Windows.Forms.ComboBox
    Friend WithEvents movieListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents addMovieBtn As System.Windows.Forms.Button
    Friend WithEvents editMovieBtn As System.Windows.Forms.Button
    Friend WithEvents deleteMovieBtn As System.Windows.Forms.Button
    Friend WithEvents addActorBtn As System.Windows.Forms.Button
    Friend WithEvents deleteActorBtn As System.Windows.Forms.Button
    Friend WithEvents movieGenreBox As System.Windows.Forms.ComboBox
    Friend WithEvents allActorBox As System.Windows.Forms.ListBox
    Friend WithEvents addedActorsBox As System.Windows.Forms.ListBox
    Friend WithEvents addGenreBtn As System.Windows.Forms.Button
    Friend WithEvents removeGenreBtn As System.Windows.Forms.Button
    Friend WithEvents allGenreBox As System.Windows.Forms.ListBox
    Friend WithEvents addedGenreBox As System.Windows.Forms.ListBox
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents confirmBtn As System.Windows.Forms.Button
    Friend WithEvents warningLbl As System.Windows.Forms.Label
End Class
