<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_flights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Show_flights))
        Me.DepartingFlightsListBox = New System.Windows.Forms.ListBox()
        Me.ReturningFlightsListBox = New System.Windows.Forms.ListBox()
        Me.DepartingFlightsLabel = New System.Windows.Forms.Label()
        Me.ReturningFlightsLabel = New System.Windows.Forms.Label()
        Me.ShowsCustomerFlightsListBox = New System.Windows.Forms.TextBox()
        Me.FlightChosenContinueBtn = New System.Windows.Forms.Button()
        Me.YourItineraryLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DepartingFlightsListBox
        '
        Me.DepartingFlightsListBox.FormattingEnabled = True
        Me.DepartingFlightsListBox.Location = New System.Drawing.Point(23, 84)
        Me.DepartingFlightsListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DepartingFlightsListBox.Name = "DepartingFlightsListBox"
        Me.DepartingFlightsListBox.Size = New System.Drawing.Size(301, 69)
        Me.DepartingFlightsListBox.TabIndex = 0
        '
        'ReturningFlightsListBox
        '
        Me.ReturningFlightsListBox.FormattingEnabled = True
        Me.ReturningFlightsListBox.Location = New System.Drawing.Point(23, 205)
        Me.ReturningFlightsListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReturningFlightsListBox.Name = "ReturningFlightsListBox"
        Me.ReturningFlightsListBox.Size = New System.Drawing.Size(301, 69)
        Me.ReturningFlightsListBox.TabIndex = 1
        '
        'DepartingFlightsLabel
        '
        Me.DepartingFlightsLabel.AutoSize = True
        Me.DepartingFlightsLabel.BackColor = System.Drawing.Color.Transparent
        Me.DepartingFlightsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartingFlightsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DepartingFlightsLabel.Location = New System.Drawing.Point(19, 56)
        Me.DepartingFlightsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DepartingFlightsLabel.Name = "DepartingFlightsLabel"
        Me.DepartingFlightsLabel.Size = New System.Drawing.Size(213, 29)
        Me.DepartingFlightsLabel.TabIndex = 2
        Me.DepartingFlightsLabel.Text = "Departing Flights"
        '
        'ReturningFlightsLabel
        '
        Me.ReturningFlightsLabel.AutoSize = True
        Me.ReturningFlightsLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReturningFlightsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturningFlightsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReturningFlightsLabel.Location = New System.Drawing.Point(19, 176)
        Me.ReturningFlightsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReturningFlightsLabel.Name = "ReturningFlightsLabel"
        Me.ReturningFlightsLabel.Size = New System.Drawing.Size(193, 26)
        Me.ReturningFlightsLabel.TabIndex = 3
        Me.ReturningFlightsLabel.Text = "Returning Flights"
        '
        'ShowsCustomerFlightsListBox
        '
        Me.ShowsCustomerFlightsListBox.Location = New System.Drawing.Point(23, 320)
        Me.ShowsCustomerFlightsListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ShowsCustomerFlightsListBox.Multiline = True
        Me.ShowsCustomerFlightsListBox.Name = "ShowsCustomerFlightsListBox"
        Me.ShowsCustomerFlightsListBox.Size = New System.Drawing.Size(374, 80)
        Me.ShowsCustomerFlightsListBox.TabIndex = 4
        Me.ShowsCustomerFlightsListBox.Text = "Shows Customers Flights" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                  " &
    "                                                    Estimated Total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FlightChosenContinueBtn
        '
        Me.FlightChosenContinueBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlightChosenContinueBtn.Location = New System.Drawing.Point(224, 438)
        Me.FlightChosenContinueBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlightChosenContinueBtn.Name = "FlightChosenContinueBtn"
        Me.FlightChosenContinueBtn.Size = New System.Drawing.Size(172, 36)
        Me.FlightChosenContinueBtn.TabIndex = 5
        Me.FlightChosenContinueBtn.Text = "Continue"
        Me.FlightChosenContinueBtn.UseVisualStyleBackColor = True
        '
        'YourItineraryLabel
        '
        Me.YourItineraryLabel.AutoSize = True
        Me.YourItineraryLabel.BackColor = System.Drawing.Color.Transparent
        Me.YourItineraryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourItineraryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.YourItineraryLabel.Location = New System.Drawing.Point(19, 292)
        Me.YourItineraryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.YourItineraryLabel.Name = "YourItineraryLabel"
        Me.YourItineraryLabel.Size = New System.Drawing.Size(157, 26)
        Me.YourItineraryLabel.TabIndex = 6
        Me.YourItineraryLabel.Text = "Your Itinerary"
        '
        'Show_flights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(430, 507)
        Me.Controls.Add(Me.YourItineraryLabel)
        Me.Controls.Add(Me.FlightChosenContinueBtn)
        Me.Controls.Add(Me.ShowsCustomerFlightsListBox)
        Me.Controls.Add(Me.ReturningFlightsLabel)
        Me.Controls.Add(Me.DepartingFlightsLabel)
        Me.Controls.Add(Me.ReturningFlightsListBox)
        Me.Controls.Add(Me.DepartingFlightsListBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Show_flights"
        Me.Text = "Flight Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DepartingFlightsListBox As ListBox
    Friend WithEvents ReturningFlightsListBox As ListBox
    Friend WithEvents DepartingFlightsLabel As Label
    Friend WithEvents ReturningFlightsLabel As Label
    Friend WithEvents ShowsCustomerFlightsListBox As TextBox
    Friend WithEvents FlightChosenContinueBtn As Button
    Friend WithEvents YourItineraryLabel As Label
End Class
