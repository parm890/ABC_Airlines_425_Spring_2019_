<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_data))
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.MiddleNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.DateOfBirthLabel = New System.Windows.Forms.Label()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.ConfirmEmailLabel = New System.Windows.Forms.Label()
        Me.CountryNameLabel = New System.Windows.Forms.Label()
        Me.AddressLine1Label = New System.Windows.Forms.Label()
        Me.AddressLine2Label = New System.Windows.Forms.Label()
        Me.CityNameLabel = New System.Windows.Forms.Label()
        Me.StateNameLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.MaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.DayTextbox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLine1TextBox = New System.Windows.Forms.TextBox()
        Me.AddressLine2TextBox = New System.Windows.Forms.TextBox()
        Me.CityNameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryNameTextBox = New System.Windows.Forms.TextBox()
        Me.StateNameTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmEmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ContinueToPaymentBtn = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstNameLabel.Location = New System.Drawing.Point(54, 38)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "* First Name:"
        '
        'MiddleNameLabel
        '
        Me.MiddleNameLabel.AutoSize = True
        Me.MiddleNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.MiddleNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MiddleNameLabel.Location = New System.Drawing.Point(44, 80)
        Me.MiddleNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MiddleNameLabel.Name = "MiddleNameLabel"
        Me.MiddleNameLabel.Size = New System.Drawing.Size(79, 13)
        Me.MiddleNameLabel.TabIndex = 1
        Me.MiddleNameLabel.Text = "* Middle Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.LastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastNameLabel.Location = New System.Drawing.Point(280, 38)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(68, 13)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "* Last Name:"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GenderLabel.Location = New System.Drawing.Point(69, 124)
        Me.GenderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(52, 13)
        Me.GenderLabel.TabIndex = 3
        Me.GenderLabel.Text = "* Gender:"
        '
        'DateOfBirthLabel
        '
        Me.DateOfBirthLabel.AutoSize = True
        Me.DateOfBirthLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateOfBirthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateOfBirthLabel.Location = New System.Drawing.Point(50, 163)
        Me.DateOfBirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateOfBirthLabel.Name = "DateOfBirthLabel"
        Me.DateOfBirthLabel.Size = New System.Drawing.Size(75, 13)
        Me.DateOfBirthLabel.TabIndex = 5
        Me.DateOfBirthLabel.Text = "* Date of birth:"
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(40, 490)
        Me.PhoneNumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(78, 13)
        Me.PhoneNumberLabel.TabIndex = 9
        Me.PhoneNumberLabel.Text = "Phone Number"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmailLabel.Location = New System.Drawing.Point(80, 427)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(42, 13)
        Me.EmailLabel.TabIndex = 10
        Me.EmailLabel.Text = "* Email:"
        '
        'ConfirmEmailLabel
        '
        Me.ConfirmEmailLabel.AutoSize = True
        Me.ConfirmEmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConfirmEmailLabel.Location = New System.Drawing.Point(37, 458)
        Me.ConfirmEmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConfirmEmailLabel.Name = "ConfirmEmailLabel"
        Me.ConfirmEmailLabel.Size = New System.Drawing.Size(80, 13)
        Me.ConfirmEmailLabel.TabIndex = 11
        Me.ConfirmEmailLabel.Text = "* Confirm Email:"
        '
        'CountryNameLabel
        '
        Me.CountryNameLabel.AutoSize = True
        Me.CountryNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountryNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CountryNameLabel.Location = New System.Drawing.Point(68, 311)
        Me.CountryNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CountryNameLabel.Name = "CountryNameLabel"
        Me.CountryNameLabel.Size = New System.Drawing.Size(53, 13)
        Me.CountryNameLabel.TabIndex = 8
        Me.CountryNameLabel.Text = "* Country:"
        '
        'AddressLine1Label
        '
        Me.AddressLine1Label.AutoSize = True
        Me.AddressLine1Label.BackColor = System.Drawing.Color.Transparent
        Me.AddressLine1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddressLine1Label.Location = New System.Drawing.Point(40, 201)
        Me.AddressLine1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddressLine1Label.Name = "AddressLine1Label"
        Me.AddressLine1Label.Size = New System.Drawing.Size(83, 13)
        Me.AddressLine1Label.TabIndex = 12
        Me.AddressLine1Label.Text = "* Address line 1:"
        '
        'AddressLine2Label
        '
        Me.AddressLine2Label.AutoSize = True
        Me.AddressLine2Label.BackColor = System.Drawing.Color.Transparent
        Me.AddressLine2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddressLine2Label.Location = New System.Drawing.Point(46, 240)
        Me.AddressLine2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddressLine2Label.Name = "AddressLine2Label"
        Me.AddressLine2Label.Size = New System.Drawing.Size(76, 13)
        Me.AddressLine2Label.TabIndex = 13
        Me.AddressLine2Label.Text = "Address line 2:"
        '
        'CityNameLabel
        '
        Me.CityNameLabel.AutoSize = True
        Me.CityNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CityNameLabel.Location = New System.Drawing.Point(90, 275)
        Me.CityNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CityNameLabel.Name = "CityNameLabel"
        Me.CityNameLabel.Size = New System.Drawing.Size(34, 13)
        Me.CityNameLabel.TabIndex = 14
        Me.CityNameLabel.Text = "* City:"
        '
        'StateNameLabel
        '
        Me.StateNameLabel.AutoSize = True
        Me.StateNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.StateNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StateNameLabel.Location = New System.Drawing.Point(80, 351)
        Me.StateNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StateNameLabel.Name = "StateNameLabel"
        Me.StateNameLabel.Size = New System.Drawing.Size(42, 13)
        Me.StateNameLabel.TabIndex = 15
        Me.StateNameLabel.Text = "* State:"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZipCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ZipCodeLabel.Location = New System.Drawing.Point(90, 391)
        Me.ZipCodeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(32, 13)
        Me.ZipCodeLabel.TabIndex = 16
        Me.ZipCodeLabel.Text = "* Zip:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(125, 36)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.FirstNameTextBox.TabIndex = 17
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(352, 34)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(126, 20)
        Me.LastNameTextBox.TabIndex = 18
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(125, 77)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.MiddleNameTextBox.TabIndex = 19
        '
        'MaleRadioBtn
        '
        Me.MaleRadioBtn.AutoSize = True
        Me.MaleRadioBtn.BackColor = System.Drawing.Color.Transparent
        Me.MaleRadioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaleRadioBtn.Location = New System.Drawing.Point(128, 123)
        Me.MaleRadioBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaleRadioBtn.Name = "MaleRadioBtn"
        Me.MaleRadioBtn.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioBtn.TabIndex = 20
        Me.MaleRadioBtn.TabStop = True
        Me.MaleRadioBtn.Text = "Male"
        Me.MaleRadioBtn.UseVisualStyleBackColor = False
        '
        'FemaleRadioBtn
        '
        Me.FemaleRadioBtn.AutoSize = True
        Me.FemaleRadioBtn.BackColor = System.Drawing.Color.Transparent
        Me.FemaleRadioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FemaleRadioBtn.Location = New System.Drawing.Point(176, 123)
        Me.FemaleRadioBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FemaleRadioBtn.Name = "FemaleRadioBtn"
        Me.FemaleRadioBtn.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioBtn.TabIndex = 21
        Me.FemaleRadioBtn.TabStop = True
        Me.FemaleRadioBtn.Text = "Female"
        Me.FemaleRadioBtn.UseVisualStyleBackColor = False
        '
        'MonthTextBox
        '
        Me.MonthTextBox.Location = New System.Drawing.Point(125, 159)
        Me.MonthTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MonthTextBox.MaxLength = 2
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.Size = New System.Drawing.Size(45, 20)
        Me.MonthTextBox.TabIndex = 22
        Me.MonthTextBox.Text = "MM"
        '
        'DayTextbox
        '
        Me.DayTextbox.Location = New System.Drawing.Point(174, 159)
        Me.DayTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DayTextbox.MaxLength = 2
        Me.DayTextbox.Name = "DayTextbox"
        Me.DayTextbox.Size = New System.Drawing.Size(45, 20)
        Me.DayTextbox.TabIndex = 23
        Me.DayTextbox.Text = "DD"
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(223, 159)
        Me.YearTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.YearTextBox.MaxLength = 4
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(45, 20)
        Me.YearTextBox.TabIndex = 24
        Me.YearTextBox.Text = "YYYY"
        '
        'AddressLine1TextBox
        '
        Me.AddressLine1TextBox.Location = New System.Drawing.Point(125, 197)
        Me.AddressLine1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressLine1TextBox.Name = "AddressLine1TextBox"
        Me.AddressLine1TextBox.Size = New System.Drawing.Size(143, 20)
        Me.AddressLine1TextBox.TabIndex = 25
        '
        'AddressLine2TextBox
        '
        Me.AddressLine2TextBox.Location = New System.Drawing.Point(125, 236)
        Me.AddressLine2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressLine2TextBox.Name = "AddressLine2TextBox"
        Me.AddressLine2TextBox.Size = New System.Drawing.Size(143, 20)
        Me.AddressLine2TextBox.TabIndex = 26
        '
        'CityNameTextBox
        '
        Me.CityNameTextBox.Location = New System.Drawing.Point(125, 272)
        Me.CityNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CityNameTextBox.Name = "CityNameTextBox"
        Me.CityNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.CityNameTextBox.TabIndex = 27
        '
        'CountryNameTextBox
        '
        Me.CountryNameTextBox.Location = New System.Drawing.Point(125, 307)
        Me.CountryNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CountryNameTextBox.Name = "CountryNameTextBox"
        Me.CountryNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.CountryNameTextBox.TabIndex = 28
        '
        'StateNameTextBox
        '
        Me.StateNameTextBox.Location = New System.Drawing.Point(125, 347)
        Me.StateNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StateNameTextBox.Name = "StateNameTextBox"
        Me.StateNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.StateNameTextBox.TabIndex = 29
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(125, 388)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(143, 20)
        Me.ZipCodeTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(125, 422)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(143, 20)
        Me.EmailTextBox.TabIndex = 31
        '
        'ConfirmEmailTextBox
        '
        Me.ConfirmEmailTextBox.Location = New System.Drawing.Point(125, 454)
        Me.ConfirmEmailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ConfirmEmailTextBox.Name = "ConfirmEmailTextBox"
        Me.ConfirmEmailTextBox.Size = New System.Drawing.Size(143, 20)
        Me.ConfirmEmailTextBox.TabIndex = 32
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(125, 486)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(143, 20)
        Me.PhoneNumberTextBox.TabIndex = 33
        '
        'ContinueToPaymentBtn
        '
        Me.ContinueToPaymentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueToPaymentBtn.Location = New System.Drawing.Point(266, 518)
        Me.ContinueToPaymentBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ContinueToPaymentBtn.Name = "ContinueToPaymentBtn"
        Me.ContinueToPaymentBtn.Size = New System.Drawing.Size(174, 46)
        Me.ContinueToPaymentBtn.TabIndex = 34
        Me.ContinueToPaymentBtn.Text = "Continue"
        Me.ContinueToPaymentBtn.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(352, 77)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(126, 20)
        Me.PasswordTextBox.TabIndex = 35
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordLabel.Location = New System.Drawing.Point(280, 77)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(60, 13)
        Me.PasswordLabel.TabIndex = 36
        Me.PasswordLabel.Text = "* Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(280, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "* Confirm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(352, 124)
        Me.ConfirmPasswordTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(126, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 38
        Me.ConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(294, 486)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "* indicates a required field"
        '
        'Customer_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(496, 609)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.ContinueToPaymentBtn)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.ConfirmEmailTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateNameTextBox)
        Me.Controls.Add(Me.CountryNameTextBox)
        Me.Controls.Add(Me.CityNameTextBox)
        Me.Controls.Add(Me.AddressLine2TextBox)
        Me.Controls.Add(Me.AddressLine1TextBox)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.DayTextbox)
        Me.Controls.Add(Me.MonthTextBox)
        Me.Controls.Add(Me.FemaleRadioBtn)
        Me.Controls.Add(Me.MaleRadioBtn)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateNameLabel)
        Me.Controls.Add(Me.CityNameLabel)
        Me.Controls.Add(Me.AddressLine2Label)
        Me.Controls.Add(Me.AddressLine1Label)
        Me.Controls.Add(Me.ConfirmEmailLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.CountryNameLabel)
        Me.Controls.Add(Me.DateOfBirthLabel)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.MiddleNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Customer_data"
        Me.Text = "Traveler Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents MiddleNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents ConfirmEmailLabel As Label
    Friend WithEvents CountryNameLabel As Label
    Friend WithEvents AddressLine1Label As Label
    Friend WithEvents AddressLine2Label As Label
    Friend WithEvents CityNameLabel As Label
    Friend WithEvents StateNameLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents MaleRadioBtn As RadioButton
    Friend WithEvents FemaleRadioBtn As RadioButton
    Friend WithEvents MonthTextBox As TextBox
    Friend WithEvents DayTextbox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents AddressLine1TextBox As TextBox
    Friend WithEvents AddressLine2TextBox As TextBox
    Friend WithEvents CityNameTextBox As TextBox
    Friend WithEvents CountryNameTextBox As TextBox
    Friend WithEvents StateNameTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ConfirmEmailTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents ContinueToPaymentBtn As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
