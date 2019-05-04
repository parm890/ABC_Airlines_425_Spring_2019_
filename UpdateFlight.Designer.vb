<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateFlight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlightNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsForAdmin2DataSet = New Final_425.FlightsForAdmin2DataSet()
        Me.TimeOfDepartureTextBox = New System.Windows.Forms.TextBox()
        Me.TimeOfArrivalTextBox = New System.Windows.Forms.TextBox()
        Me.LocationOfArrivalTextBox = New System.Windows.Forms.TextBox()
        Me.LocationOfDepartureTextBox = New System.Windows.Forms.TextBox()
        Me.CostOfFlightTextBox = New System.Windows.Forms.TextBox()
        Me.TypeOfPlaneTextBox = New System.Windows.Forms.TextBox()
        Me.BoardingTimeTextBox = New System.Windows.Forms.TextBox()
        Me.GateNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FllightNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOfDepartureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOfArrivalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationOfDepartureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationOfArrivalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostOfFlightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfPlaneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoardingTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GateNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlightsTableAdapter = New Final_425.FlightsForAdmin2DataSetTableAdapters.FlightsTableAdapter()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsForAdmin2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(109, 330)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewButton.TabIndex = 1
        Me.AddNewButton.Text = "Add New"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(14, 330)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 2
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(14, 365)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(200, 365)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(200, 330)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 5
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(109, 365)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Flight Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Time Of Departure"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Time Of Arrival"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Location Of Arrival"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Location Of Departure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cost Of Flight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Type Of Plane"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Boarding Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Gate Number"
        '
        'FlightNumberTextBox
        '
        Me.FlightNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "FllightNumber", True))
        Me.FlightNumberTextBox.Location = New System.Drawing.Point(169, 25)
        Me.FlightNumberTextBox.Name = "FlightNumberTextBox"
        Me.FlightNumberTextBox.Size = New System.Drawing.Size(176, 22)
        Me.FlightNumberTextBox.TabIndex = 16
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.FlightsForAdmin2DataSet
        '
        'FlightsForAdmin2DataSet
        '
        Me.FlightsForAdmin2DataSet.DataSetName = "FlightsForAdmin2DataSet"
        Me.FlightsForAdmin2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeOfDepartureTextBox
        '
        Me.TimeOfDepartureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsForAdmin2DataSet, "Flights.TimeOfDeparture", True))
        Me.TimeOfDepartureTextBox.Location = New System.Drawing.Point(169, 53)
        Me.TimeOfDepartureTextBox.Name = "TimeOfDepartureTextBox"
        Me.TimeOfDepartureTextBox.Size = New System.Drawing.Size(176, 22)
        Me.TimeOfDepartureTextBox.TabIndex = 17
        '
        'TimeOfArrivalTextBox
        '
        Me.TimeOfArrivalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TimeOfArrival", True))
        Me.TimeOfArrivalTextBox.Location = New System.Drawing.Point(169, 81)
        Me.TimeOfArrivalTextBox.Name = "TimeOfArrivalTextBox"
        Me.TimeOfArrivalTextBox.Size = New System.Drawing.Size(176, 22)
        Me.TimeOfArrivalTextBox.TabIndex = 18
        '
        'LocationOfArrivalTextBox
        '
        Me.LocationOfArrivalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "LocationOfArrival", True))
        Me.LocationOfArrivalTextBox.Location = New System.Drawing.Point(169, 117)
        Me.LocationOfArrivalTextBox.Name = "LocationOfArrivalTextBox"
        Me.LocationOfArrivalTextBox.Size = New System.Drawing.Size(176, 22)
        Me.LocationOfArrivalTextBox.TabIndex = 19
        '
        'LocationOfDepartureTextBox
        '
        Me.LocationOfDepartureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "LocationOfDeparture", True))
        Me.LocationOfDepartureTextBox.Location = New System.Drawing.Point(169, 149)
        Me.LocationOfDepartureTextBox.Name = "LocationOfDepartureTextBox"
        Me.LocationOfDepartureTextBox.Size = New System.Drawing.Size(176, 22)
        Me.LocationOfDepartureTextBox.TabIndex = 20
        '
        'CostOfFlightTextBox
        '
        Me.CostOfFlightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "CostOfFlight", True))
        Me.CostOfFlightTextBox.Location = New System.Drawing.Point(169, 183)
        Me.CostOfFlightTextBox.Name = "CostOfFlightTextBox"
        Me.CostOfFlightTextBox.Size = New System.Drawing.Size(176, 22)
        Me.CostOfFlightTextBox.TabIndex = 21
        '
        'TypeOfPlaneTextBox
        '
        Me.TypeOfPlaneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TypeOfPlane", True))
        Me.TypeOfPlaneTextBox.Location = New System.Drawing.Point(169, 211)
        Me.TypeOfPlaneTextBox.Name = "TypeOfPlaneTextBox"
        Me.TypeOfPlaneTextBox.Size = New System.Drawing.Size(176, 22)
        Me.TypeOfPlaneTextBox.TabIndex = 22
        '
        'BoardingTimeTextBox
        '
        Me.BoardingTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "BoardingTime", True))
        Me.BoardingTimeTextBox.Location = New System.Drawing.Point(169, 243)
        Me.BoardingTimeTextBox.Name = "BoardingTimeTextBox"
        Me.BoardingTimeTextBox.Size = New System.Drawing.Size(176, 22)
        Me.BoardingTimeTextBox.TabIndex = 23
        '
        'GateNumberTextBox
        '
        Me.GateNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "GateNumber", True))
        Me.GateNumberTextBox.Location = New System.Drawing.Point(169, 281)
        Me.GateNumberTextBox.Name = "GateNumberTextBox"
        Me.GateNumberTextBox.Size = New System.Drawing.Size(176, 22)
        Me.GateNumberTextBox.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CloseButton)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.GateNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.AddNewButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.BoardingTimeTextBox)
        Me.GroupBox1.Controls.Add(Me.PreviousButton)
        Me.GroupBox1.Controls.Add(Me.TypeOfPlaneTextBox)
        Me.GroupBox1.Controls.Add(Me.NextButton)
        Me.GroupBox1.Controls.Add(Me.CostOfFlightTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LocationOfDepartureTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LocationOfArrivalTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TimeOfArrivalTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TimeOfDepartureTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.FlightNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 394)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1106, 394)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FllightNumberDataGridViewTextBoxColumn, Me.TimeOfDepartureDataGridViewTextBoxColumn, Me.TimeOfArrivalDataGridViewTextBoxColumn, Me.LocationOfDepartureDataGridViewTextBoxColumn, Me.LocationOfArrivalDataGridViewTextBoxColumn, Me.CostOfFlightDataGridViewTextBoxColumn, Me.TypeOfPlaneDataGridViewTextBoxColumn, Me.BoardingTimeDataGridViewTextBoxColumn, Me.GateNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FlightsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1047, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FllightNumberDataGridViewTextBoxColumn
        '
        Me.FllightNumberDataGridViewTextBoxColumn.DataPropertyName = "FllightNumber"
        Me.FllightNumberDataGridViewTextBoxColumn.HeaderText = "FllightNumber"
        Me.FllightNumberDataGridViewTextBoxColumn.Name = "FllightNumberDataGridViewTextBoxColumn"
        '
        'TimeOfDepartureDataGridViewTextBoxColumn
        '
        Me.TimeOfDepartureDataGridViewTextBoxColumn.DataPropertyName = "TimeOfDeparture"
        Me.TimeOfDepartureDataGridViewTextBoxColumn.HeaderText = "TimeOfDeparture"
        Me.TimeOfDepartureDataGridViewTextBoxColumn.Name = "TimeOfDepartureDataGridViewTextBoxColumn"
        '
        'TimeOfArrivalDataGridViewTextBoxColumn
        '
        Me.TimeOfArrivalDataGridViewTextBoxColumn.DataPropertyName = "TimeOfArrival"
        Me.TimeOfArrivalDataGridViewTextBoxColumn.HeaderText = "TimeOfArrival"
        Me.TimeOfArrivalDataGridViewTextBoxColumn.Name = "TimeOfArrivalDataGridViewTextBoxColumn"
        '
        'LocationOfDepartureDataGridViewTextBoxColumn
        '
        Me.LocationOfDepartureDataGridViewTextBoxColumn.DataPropertyName = "LocationOfDeparture"
        Me.LocationOfDepartureDataGridViewTextBoxColumn.HeaderText = "LocationOfDeparture"
        Me.LocationOfDepartureDataGridViewTextBoxColumn.Name = "LocationOfDepartureDataGridViewTextBoxColumn"
        '
        'LocationOfArrivalDataGridViewTextBoxColumn
        '
        Me.LocationOfArrivalDataGridViewTextBoxColumn.DataPropertyName = "LocationOfArrival"
        Me.LocationOfArrivalDataGridViewTextBoxColumn.HeaderText = "LocationOfArrival"
        Me.LocationOfArrivalDataGridViewTextBoxColumn.Name = "LocationOfArrivalDataGridViewTextBoxColumn"
        '
        'CostOfFlightDataGridViewTextBoxColumn
        '
        Me.CostOfFlightDataGridViewTextBoxColumn.DataPropertyName = "CostOfFlight"
        Me.CostOfFlightDataGridViewTextBoxColumn.HeaderText = "CostOfFlight"
        Me.CostOfFlightDataGridViewTextBoxColumn.Name = "CostOfFlightDataGridViewTextBoxColumn"
        '
        'TypeOfPlaneDataGridViewTextBoxColumn
        '
        Me.TypeOfPlaneDataGridViewTextBoxColumn.DataPropertyName = "TypeOfPlane"
        Me.TypeOfPlaneDataGridViewTextBoxColumn.HeaderText = "TypeOfPlane"
        Me.TypeOfPlaneDataGridViewTextBoxColumn.Name = "TypeOfPlaneDataGridViewTextBoxColumn"
        '
        'BoardingTimeDataGridViewTextBoxColumn
        '
        Me.BoardingTimeDataGridViewTextBoxColumn.DataPropertyName = "BoardingTime"
        Me.BoardingTimeDataGridViewTextBoxColumn.HeaderText = "BoardingTime"
        Me.BoardingTimeDataGridViewTextBoxColumn.Name = "BoardingTimeDataGridViewTextBoxColumn"
        '
        'GateNumberDataGridViewTextBoxColumn
        '
        Me.GateNumberDataGridViewTextBoxColumn.DataPropertyName = "GateNumber"
        Me.GateNumberDataGridViewTextBoxColumn.HeaderText = "GateNumber"
        Me.GateNumberDataGridViewTextBoxColumn.Name = "GateNumberDataGridViewTextBoxColumn"
        '
        'FlightsTableAdapter
        '
        Me.FlightsTableAdapter.ClearBeforeFill = True
        '
        'UpdateFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 483)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UpdateFlight"
        Me.Text = "Form1"
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsForAdmin2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddNewButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FlightNumberTextBox As TextBox
    Friend WithEvents TimeOfDepartureTextBox As TextBox
    Friend WithEvents TimeOfArrivalTextBox As TextBox
    Friend WithEvents LocationOfArrivalTextBox As TextBox
    Friend WithEvents LocationOfDepartureTextBox As TextBox
    Friend WithEvents CostOfFlightTextBox As TextBox
    Friend WithEvents TypeOfPlaneTextBox As TextBox
    Friend WithEvents BoardingTimeTextBox As TextBox
    Friend WithEvents GateNumberTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlightsForAdmin2DataSet As FlightsForAdmin2DataSet
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As FlightsForAdmin2DataSetTableAdapters.FlightsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FllightNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOfDepartureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOfArrivalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationOfDepartureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationOfArrivalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostOfFlightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfPlaneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BoardingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GateNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
