<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flight_Search
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent2()
        Me.SearchForFlightLable = New System.Windows.Forms.Label()
        Me.FromLocationLabel = New System.Windows.Forms.Label()
        Me.ToLocationLabel = New System.Windows.Forms.Label()
        Me.FromLocationsListBox = New System.Windows.Forms.ListBox()
        Me.ToLocationListBox = New System.Windows.Forms.ListBox()
        Me.StartDateMonthlyCalender = New System.Windows.Forms.MonthCalendar()
        Me.ReturnDateMonthlyCalender = New System.Windows.Forms.MonthCalendar()
        Me.SearchFlightBtn = New System.Windows.Forms.Button()
        Me.SearchTypeFlightLabel = New System.Windows.Forms.Label()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.ReturnDateLabel = New System.Windows.Forms.Label()
        Me.RoundTripRadioBttn = New System.Windows.Forms.RadioButton()
        Me.OneWayRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'SearchForFlightLable
        '
        Me.SearchForFlightLable.AutoSize = True
        Me.SearchForFlightLable.Location = New System.Drawing.Point(518, 9)
        Me.SearchForFlightLable.Name = "SearchForFlightLable"
        Me.SearchForFlightLable.Size = New System.Drawing.Size(148, 17)
        Me.SearchForFlightLable.TabIndex = 0
        Me.SearchForFlightLable.Text = "Search for flights here"
        '
        'FromLocationLabel
        '
        Me.FromLocationLabel.AutoSize = True
        Me.FromLocationLabel.Location = New System.Drawing.Point(482, 49)
        Me.FromLocationLabel.Name = "FromLocationLabel"
        Me.FromLocationLabel.Size = New System.Drawing.Size(40, 17)
        Me.FromLocationLabel.TabIndex = 3
        Me.FromLocationLabel.Text = "From"
        '
        'ToLocationLabel
        '
        Me.ToLocationLabel.AutoSize = True
        Me.ToLocationLabel.Location = New System.Drawing.Point(655, 49)
        Me.ToLocationLabel.Name = "ToLocationLabel"
        Me.ToLocationLabel.Size = New System.Drawing.Size(25, 17)
        Me.ToLocationLabel.TabIndex = 4
        Me.ToLocationLabel.Text = "To"
        '
        'FromLocationsListBox
        '
        Me.FromLocationsListBox.FormattingEnabled = True
        Me.FromLocationsListBox.ItemHeight = 16
        Me.FromLocationsListBox.Items.AddRange(New Object() {"Buffalo", "Chicago ", "JFK"})
        Me.FromLocationsListBox.Location = New System.Drawing.Point(446, 71)
        Me.FromLocationsListBox.Name = "FromLocationsListBox"
        Me.FromLocationsListBox.Size = New System.Drawing.Size(120, 84)
        Me.FromLocationsListBox.TabIndex = 5
        '
        'ToLocationListBox
        '
        Me.ToLocationListBox.FormattingEnabled = True
        Me.ToLocationListBox.ItemHeight = 16
        Me.ToLocationListBox.Items.AddRange(New Object() {"Buffalo", "Chicago ", "JFK"})
        Me.ToLocationListBox.Location = New System.Drawing.Point(609, 71)
        Me.ToLocationListBox.Name = "ToLocationListBox"
        Me.ToLocationListBox.Size = New System.Drawing.Size(120, 84)
        Me.ToLocationListBox.TabIndex = 6
        '
        'StartDateMonthlyCalender
        '
        Me.StartDateMonthlyCalender.Location = New System.Drawing.Point(17, 225)
        Me.StartDateMonthlyCalender.Name = "StartDateMonthlyCalender"
        Me.StartDateMonthlyCalender.TabIndex = 7
        '
        'ReturnDateMonthlyCalender
        '
        Me.ReturnDateMonthlyCalender.Location = New System.Drawing.Point(321, 225)
        Me.ReturnDateMonthlyCalender.Name = "ReturnDateMonthlyCalender"
        Me.ReturnDateMonthlyCalender.TabIndex = 8
        '
        'SearchFlightBtn
        '
        Me.SearchFlightBtn.Location = New System.Drawing.Point(625, 344)
        Me.SearchFlightBtn.Name = "SearchFlightBtn"
        Me.SearchFlightBtn.Size = New System.Drawing.Size(139, 33)
        Me.SearchFlightBtn.TabIndex = 9
        Me.SearchFlightBtn.Text = "Search for Flights"
        Me.SearchFlightBtn.UseVisualStyleBackColor = True
        '
        'SearchTypeFlightLabel
        '
        Me.SearchTypeFlightLabel.AutoSize = True
        Me.SearchTypeFlightLabel.Location = New System.Drawing.Point(118, 9)
        Me.SearchTypeFlightLabel.Name = "SearchTypeFlightLabel"
        Me.SearchTypeFlightLabel.Size = New System.Drawing.Size(161, 17)
        Me.SearchTypeFlightLabel.TabIndex = 10
        Me.SearchTypeFlightLabel.Text = "Select type of flight here"
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Location = New System.Drawing.Point(110, 189)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(70, 17)
        Me.StartDateLabel.TabIndex = 11
        Me.StartDateLabel.Text = "Start date"
        '
        'ReturnDateLabel
        '
        Me.ReturnDateLabel.AutoSize = True
        Me.ReturnDateLabel.Location = New System.Drawing.Point(406, 189)
        Me.ReturnDateLabel.Name = "ReturnDateLabel"
        Me.ReturnDateLabel.Size = New System.Drawing.Size(85, 17)
        Me.ReturnDateLabel.TabIndex = 12
        Me.ReturnDateLabel.Text = "Return Date"
        '
        'RoundTripRadioBttn
        '
        Me.RoundTripRadioBttn.AutoSize = True
        Me.RoundTripRadioBttn.Location = New System.Drawing.Point(57, 60)
        Me.RoundTripRadioBttn.Name = "RoundTripRadioBttn"
        Me.RoundTripRadioBttn.Size = New System.Drawing.Size(101, 21)
        Me.RoundTripRadioBttn.TabIndex = 13
        Me.RoundTripRadioBttn.TabStop = True
        Me.RoundTripRadioBttn.Text = "Round-Trip"
        Me.RoundTripRadioBttn.UseVisualStyleBackColor = True
        '
        'OneWayRadioBtn
        '
        Me.OneWayRadioBtn.AutoSize = True
        Me.OneWayRadioBtn.Location = New System.Drawing.Point(250, 60)
        Me.OneWayRadioBtn.Name = "OneWayRadioBtn"
        Me.OneWayRadioBtn.Size = New System.Drawing.Size(85, 21)
        Me.OneWayRadioBtn.TabIndex = 14
        Me.OneWayRadioBtn.TabStop = True
        Me.OneWayRadioBtn.Text = "One-way"
        Me.OneWayRadioBtn.UseVisualStyleBackColor = True
        '
        'Flight_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OneWayRadioBtn)
        Me.Controls.Add(Me.RoundTripRadioBttn)
        Me.Controls.Add(Me.ReturnDateLabel)
        Me.Controls.Add(Me.StartDateLabel)
        Me.Controls.Add(Me.SearchTypeFlightLabel)
        Me.Controls.Add(Me.SearchFlightBtn)
        Me.Controls.Add(Me.ReturnDateMonthlyCalender)
        Me.Controls.Add(Me.StartDateMonthlyCalender)
        Me.Controls.Add(Me.ToLocationListBox)
        Me.Controls.Add(Me.FromLocationsListBox)
        Me.Controls.Add(Me.ToLocationLabel)
        Me.Controls.Add(Me.FromLocationLabel)
        Me.Controls.Add(Me.SearchForFlightLable)
        Me.Name = "Flight_Search"
        Me.Text = "Flight Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchForFlightLable As Label
    Friend WithEvents FromLocationLabel As Label
    Friend WithEvents ToLocationLabel As Label
    Friend WithEvents FromLocationsListBox As ListBox
    Friend WithEvents ToLocationListBox As ListBox
    Friend WithEvents StartDateMonthlyCalender As MonthCalendar
    Friend WithEvents ReturnDateMonthlyCalender As MonthCalendar
    Friend WithEvents SearchFlightBtn As Button
    Friend WithEvents SearchTypeFlightLabel As Label
    Friend WithEvents ReturnDateLabel As Label
    Friend WithEvents RoundTripRadioBttn As RadioButton
    Friend WithEvents OneWayRadioBtn As RadioButton
    Friend WithEvents StartDateLabel As Label
    Friend WithEvents SelectFlightLabel As Label
    Friend WithEvents RoundTripRadioButton As RadioButton
    Friend WithEvents OneWayRadioButton As RadioButton
    Friend WithEvents FromListBox As ListBox
    Friend WithEvents ToListBox As ListBox
    Friend WithEvents DepartDateMonthCalendar As MonthCalendar
    Friend WithEvents ReturnDateMonthCalendar As MonthCalendar
    Friend WithEvents DepartLabel As Label
    Friend WithEvents ReturnLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchForflightsButton As Button
End Class
