Public Class Flight_Search
    Public Sub New()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchFlightBtn.Click
        Show_flights.Show()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles ReturnDateLabel.Click

    End Sub



    Private Sub SearchTypeFlightLabel_Click(sender As Object, e As EventArgs) Handles SearchTypeFlightLabel.Click

    End Sub

    Private Sub SearchForFlightLable_Click(sender As Object, e As EventArgs) Handles SearchForFlightLable.Click

    End Sub

    Private Sub RoundTripRadioBttn_CheckedChanged(sender As Object, e As EventArgs) Handles RoundTripRadioBttn.CheckedChanged

    End Sub

    Private Sub OneWayRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles OneWayRadioBtn.CheckedChanged

    End Sub

    Private Sub FromLocationLabel_Click(sender As Object, e As EventArgs) Handles FromLocationLabel.Click

    End Sub

    Private Sub ToLocationLabel_Click(sender As Object, e As EventArgs) Handles ToLocationLabel.Click

    End Sub

    Private Sub FromLocationsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FromLocationsListBox.SelectedIndexChanged

    End Sub

    Private Sub ToLocationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToLocationListBox.SelectedIndexChanged

    End Sub

    Private Sub StartDateLabel_Click(sender As Object, e As EventArgs) Handles StartDateLabel.Click

    End Sub

    Private Sub StartDateMonthlyCalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles StartDateMonthlyCalender.DateChanged

    End Sub

    Private Sub ReturnDateMonthlyCalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles ReturnDateMonthlyCalender.DateChanged

    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flight_Search))
        Me.SelectFlightLabel = New System.Windows.Forms.Label()
        Me.RoundTripRadioButton = New System.Windows.Forms.RadioButton()
        Me.OneWayRadioButton = New System.Windows.Forms.RadioButton()
        Me.FromListBox = New System.Windows.Forms.ListBox()
        Me.ToListBox = New System.Windows.Forms.ListBox()
        Me.DepartDateMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.ReturnDateMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.DepartLabel = New System.Windows.Forms.Label()
        Me.ReturnLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchForflightsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectFlightLabel
        '
        Me.SelectFlightLabel.AutoSize = True
        Me.SelectFlightLabel.BackColor = System.Drawing.Color.Transparent
        Me.SelectFlightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectFlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SelectFlightLabel.Location = New System.Drawing.Point(79, 29)
        Me.SelectFlightLabel.Name = "SelectFlightLabel"
        Me.SelectFlightLabel.Size = New System.Drawing.Size(187, 17)
        Me.SelectFlightLabel.TabIndex = 0
        Me.SelectFlightLabel.Text = "Select type of flight here"
        '
        'RoundTripRadioButton
        '
        Me.RoundTripRadioButton.AutoSize = True
        Me.RoundTripRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.RoundTripRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundTripRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RoundTripRadioButton.Location = New System.Drawing.Point(57, 64)
        Me.RoundTripRadioButton.Name = "RoundTripRadioButton"
        Me.RoundTripRadioButton.Size = New System.Drawing.Size(111, 21)
        Me.RoundTripRadioButton.TabIndex = 1
        Me.RoundTripRadioButton.TabStop = True
        Me.RoundTripRadioButton.Text = "Round-Trip"
        Me.RoundTripRadioButton.UseVisualStyleBackColor = False
        '
        'OneWayRadioButton
        '
        Me.OneWayRadioButton.AutoSize = True
        Me.OneWayRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.OneWayRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneWayRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OneWayRadioButton.Location = New System.Drawing.Point(166, 64)
        Me.OneWayRadioButton.Name = "OneWayRadioButton"
        Me.OneWayRadioButton.Size = New System.Drawing.Size(92, 21)
        Me.OneWayRadioButton.TabIndex = 2
        Me.OneWayRadioButton.TabStop = True
        Me.OneWayRadioButton.Text = "One-way"
        Me.OneWayRadioButton.UseVisualStyleBackColor = False
        '
        'FromListBox
        '
        Me.FromListBox.FormattingEnabled = True
        Me.FromListBox.ItemHeight = 16
        Me.FromListBox.Items.AddRange(New Object() {"Buffalo", "Chicago", "JFK"})
        Me.FromListBox.Location = New System.Drawing.Point(356, 45)
        Me.FromListBox.Name = "FromListBox"
        Me.FromListBox.Size = New System.Drawing.Size(120, 68)
        Me.FromListBox.TabIndex = 3
        '
        'ToListBox
        '
        Me.ToListBox.FormattingEnabled = True
        Me.ToListBox.ItemHeight = 16
        Me.ToListBox.Items.AddRange(New Object() {"Buffalo", "Chicago", "JFK"})
        Me.ToListBox.Location = New System.Drawing.Point(523, 45)
        Me.ToListBox.Name = "ToListBox"
        Me.ToListBox.Size = New System.Drawing.Size(120, 68)
        Me.ToListBox.TabIndex = 4
        '
        'DepartDateMonthCalendar
        '
        Me.DepartDateMonthCalendar.Location = New System.Drawing.Point(38, 174)
        Me.DepartDateMonthCalendar.Name = "DepartDateMonthCalendar"
        Me.DepartDateMonthCalendar.TabIndex = 5
        '
        'ReturnDateMonthCalendar
        '
        Me.ReturnDateMonthCalendar.Location = New System.Drawing.Point(356, 174)
        Me.ReturnDateMonthCalendar.MaxDate = New Date(2250, 12, 31, 0, 0, 0, 0)
        Me.ReturnDateMonthCalendar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.ReturnDateMonthCalendar.Name = "ReturnDateMonthCalendar"
        Me.ReturnDateMonthCalendar.TabIndex = 6
        '
        'DepartLabel
        '
        Me.DepartLabel.AutoSize = True
        Me.DepartLabel.BackColor = System.Drawing.Color.Transparent
        Me.DepartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DepartLabel.Location = New System.Drawing.Point(115, 152)
        Me.DepartLabel.Name = "DepartLabel"
        Me.DepartLabel.Size = New System.Drawing.Size(82, 17)
        Me.DepartLabel.TabIndex = 7
        Me.DepartLabel.Text = "Start Date"
        '
        'ReturnLabel
        '
        Me.ReturnLabel.AutoSize = True
        Me.ReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReturnLabel.Location = New System.Drawing.Point(448, 152)
        Me.ReturnLabel.Name = "ReturnLabel"
        Me.ReturnLabel.Size = New System.Drawing.Size(96, 17)
        Me.ReturnLabel.TabIndex = 8
        Me.ReturnLabel.Text = "Return Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(403, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(573, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To"
        '
        'SearchForflightsButton
        '
        Me.SearchForflightsButton.Location = New System.Drawing.Point(576, 410)
        Me.SearchForflightsButton.Name = "SearchForflightsButton"
        Me.SearchForflightsButton.Size = New System.Drawing.Size(110, 28)
        Me.SearchForflightsButton.TabIndex = 11
        Me.SearchForflightsButton.Text = "Search For Flights"
        Me.SearchForflightsButton.UseVisualStyleBackColor = True
        '
        'Flight_Search
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 463)
        Me.Controls.Add(Me.SearchForflightsButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReturnLabel)
        Me.Controls.Add(Me.DepartLabel)
        Me.Controls.Add(Me.ReturnDateMonthCalendar)
        Me.Controls.Add(Me.DepartDateMonthCalendar)
        Me.Controls.Add(Me.ToListBox)
        Me.Controls.Add(Me.FromListBox)
        Me.Controls.Add(Me.OneWayRadioButton)
        Me.Controls.Add(Me.RoundTripRadioButton)
        Me.Controls.Add(Me.SelectFlightLabel)
        Me.Name = "Flight_Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub FromListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FromListBox.SelectedIndexChanged

    End Sub

    Private Sub Flight_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
