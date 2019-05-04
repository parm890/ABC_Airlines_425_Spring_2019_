<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_details))
        Me.CardNumberLabel = New System.Windows.Forms.Label()
        Me.ExpirationDateLabel = New System.Windows.Forms.Label()
        Me.CardTypeLabel = New System.Windows.Forms.Label()
        Me.SecurityCodeLabel = New System.Windows.Forms.Label()
        Me.CardholderNameLabel = New System.Windows.Forms.Label()
        Me.CityNamePaymentLabel = New System.Windows.Forms.Label()
        Me.AddressLine1PaymentLabel = New System.Windows.Forms.Label()
        Me.AddressLine2PaymentLabel = New System.Windows.Forms.Label()
        Me.StateNamePaymentLabel = New System.Windows.Forms.Label()
        Me.ZipCodePaymentLabel = New System.Windows.Forms.Label()
        Me.CountryNamePaymentLabel = New System.Windows.Forms.Label()
        Me.PurchaseBtn = New System.Windows.Forms.Button()
        Me.PaymentAmountLabel = New System.Windows.Forms.Label()
        Me.PaymentAmountTextBox = New System.Windows.Forms.TextBox()
        Me.CardTypeTextBox = New System.Windows.Forms.TextBox()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ExpirationDateTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CardholderNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLine1PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.AdressLine2PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.CityNamePaymentTextBox = New System.Windows.Forms.TextBox()
        Me.CountryNamePaymentTextBox = New System.Windows.Forms.TextBox()
        Me.StateNamePaymentTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodePaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CardNumberLabel
        '
        Me.CardNumberLabel.AutoSize = True
        Me.CardNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.CardNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CardNumberLabel.Location = New System.Drawing.Point(45, 119)
        Me.CardNumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CardNumberLabel.Name = "CardNumberLabel"
        Me.CardNumberLabel.Size = New System.Drawing.Size(79, 13)
        Me.CardNumberLabel.TabIndex = 14
        Me.CardNumberLabel.Text = "* Card Number:"
        '
        'ExpirationDateLabel
        '
        Me.ExpirationDateLabel.AutoSize = True
        Me.ExpirationDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExpirationDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExpirationDateLabel.Location = New System.Drawing.Point(36, 157)
        Me.ExpirationDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExpirationDateLabel.Name = "ExpirationDateLabel"
        Me.ExpirationDateLabel.Size = New System.Drawing.Size(89, 13)
        Me.ExpirationDateLabel.TabIndex = 16
        Me.ExpirationDateLabel.Text = "* Expiration Date:"
        '
        'CardTypeLabel
        '
        Me.CardTypeLabel.AutoSize = True
        Me.CardTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CardTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CardTypeLabel.Location = New System.Drawing.Point(58, 80)
        Me.CardTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CardTypeLabel.Name = "CardTypeLabel"
        Me.CardTypeLabel.Size = New System.Drawing.Size(66, 13)
        Me.CardTypeLabel.TabIndex = 18
        Me.CardTypeLabel.Text = "* Card Type:"
        '
        'SecurityCodeLabel
        '
        Me.SecurityCodeLabel.AutoSize = True
        Me.SecurityCodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SecurityCodeLabel.Location = New System.Drawing.Point(42, 192)
        Me.SecurityCodeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SecurityCodeLabel.Name = "SecurityCodeLabel"
        Me.SecurityCodeLabel.Size = New System.Drawing.Size(83, 13)
        Me.SecurityCodeLabel.TabIndex = 20
        Me.SecurityCodeLabel.Text = "* Security Code:"
        '
        'CardholderNameLabel
        '
        Me.CardholderNameLabel.AutoSize = True
        Me.CardholderNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CardholderNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CardholderNameLabel.Location = New System.Drawing.Point(25, 228)
        Me.CardholderNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CardholderNameLabel.Name = "CardholderNameLabel"
        Me.CardholderNameLabel.Size = New System.Drawing.Size(99, 13)
        Me.CardholderNameLabel.TabIndex = 23
        Me.CardholderNameLabel.Text = "* Cardholder Name:"
        '
        'CityNamePaymentLabel
        '
        Me.CityNamePaymentLabel.AutoSize = True
        Me.CityNamePaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityNamePaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CityNamePaymentLabel.Location = New System.Drawing.Point(303, 119)
        Me.CityNamePaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CityNamePaymentLabel.Name = "CityNamePaymentLabel"
        Me.CityNamePaymentLabel.Size = New System.Drawing.Size(34, 13)
        Me.CityNamePaymentLabel.TabIndex = 26
        Me.CityNamePaymentLabel.Text = "* City:"
        '
        'AddressLine1PaymentLabel
        '
        Me.AddressLine1PaymentLabel.AutoSize = True
        Me.AddressLine1PaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLine1PaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddressLine1PaymentLabel.Location = New System.Drawing.Point(250, 41)
        Me.AddressLine1PaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddressLine1PaymentLabel.Name = "AddressLine1PaymentLabel"
        Me.AddressLine1PaymentLabel.Size = New System.Drawing.Size(86, 13)
        Me.AddressLine1PaymentLabel.TabIndex = 27
        Me.AddressLine1PaymentLabel.Text = "* Address line 1: "
        '
        'AddressLine2PaymentLabel
        '
        Me.AddressLine2PaymentLabel.AutoSize = True
        Me.AddressLine2PaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLine2PaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddressLine2PaymentLabel.Location = New System.Drawing.Point(266, 80)
        Me.AddressLine2PaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddressLine2PaymentLabel.Name = "AddressLine2PaymentLabel"
        Me.AddressLine2PaymentLabel.Size = New System.Drawing.Size(70, 13)
        Me.AddressLine2PaymentLabel.TabIndex = 28
        Me.AddressLine2PaymentLabel.Text = "Adress line 2:"
        '
        'StateNamePaymentLabel
        '
        Me.StateNamePaymentLabel.AutoSize = True
        Me.StateNamePaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.StateNamePaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StateNamePaymentLabel.Location = New System.Drawing.Point(296, 192)
        Me.StateNamePaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StateNamePaymentLabel.Name = "StateNamePaymentLabel"
        Me.StateNamePaymentLabel.Size = New System.Drawing.Size(42, 13)
        Me.StateNamePaymentLabel.TabIndex = 29
        Me.StateNamePaymentLabel.Text = "* State:"
        '
        'ZipCodePaymentLabel
        '
        Me.ZipCodePaymentLabel.AutoSize = True
        Me.ZipCodePaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZipCodePaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ZipCodePaymentLabel.Location = New System.Drawing.Point(305, 228)
        Me.ZipCodePaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ZipCodePaymentLabel.Name = "ZipCodePaymentLabel"
        Me.ZipCodePaymentLabel.Size = New System.Drawing.Size(32, 13)
        Me.ZipCodePaymentLabel.TabIndex = 30
        Me.ZipCodePaymentLabel.Text = "* Zip:"
        '
        'CountryNamePaymentLabel
        '
        Me.CountryNamePaymentLabel.AutoSize = True
        Me.CountryNamePaymentLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountryNamePaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CountryNamePaymentLabel.Location = New System.Drawing.Point(284, 157)
        Me.CountryNamePaymentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CountryNamePaymentLabel.Name = "CountryNamePaymentLabel"
        Me.CountryNamePaymentLabel.Size = New System.Drawing.Size(53, 13)
        Me.CountryNamePaymentLabel.TabIndex = 31
        Me.CountryNamePaymentLabel.Text = "* Country:"
        '
        'PurchaseBtn
        '
        Me.PurchaseBtn.Location = New System.Drawing.Point(278, 277)
        Me.PurchaseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PurchaseBtn.Name = "PurchaseBtn"
        Me.PurchaseBtn.Size = New System.Drawing.Size(182, 33)
        Me.PurchaseBtn.TabIndex = 37
        Me.PurchaseBtn.Text = "Purchase"
        Me.PurchaseBtn.UseVisualStyleBackColor = True
        '
        'PaymentAmountLabel
        '
        Me.PaymentAmountLabel.AutoSize = True
        Me.PaymentAmountLabel.BackColor = System.Drawing.Color.Transparent
        Me.PaymentAmountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PaymentAmountLabel.Location = New System.Drawing.Point(26, 37)
        Me.PaymentAmountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PaymentAmountLabel.Name = "PaymentAmountLabel"
        Me.PaymentAmountLabel.Size = New System.Drawing.Size(97, 13)
        Me.PaymentAmountLabel.TabIndex = 38
        Me.PaymentAmountLabel.Text = "* Payment Amount:"
        '
        'PaymentAmountTextBox
        '
        Me.PaymentAmountTextBox.Location = New System.Drawing.Point(126, 37)
        Me.PaymentAmountTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PaymentAmountTextBox.Name = "PaymentAmountTextBox"
        Me.PaymentAmountTextBox.ReadOnly = True
        Me.PaymentAmountTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PaymentAmountTextBox.TabIndex = 39
        '
        'CardTypeTextBox
        '
        Me.CardTypeTextBox.Location = New System.Drawing.Point(126, 76)
        Me.CardTypeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CardTypeTextBox.Name = "CardTypeTextBox"
        Me.CardTypeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CardTypeTextBox.TabIndex = 40
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.Location = New System.Drawing.Point(126, 115)
        Me.CardNumberTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CardNumberTextBox.MaxLength = 16
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CardNumberTextBox.TabIndex = 41
        '
        'ExpirationDateTextBox
        '
        Me.ExpirationDateTextBox.Location = New System.Drawing.Point(126, 153)
        Me.ExpirationDateTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExpirationDateTextBox.Name = "ExpirationDateTextBox"
        Me.ExpirationDateTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpirationDateTextBox.TabIndex = 42
        '
        'SecurityCodeTextBox
        '
        Me.SecurityCodeTextBox.Location = New System.Drawing.Point(126, 188)
        Me.SecurityCodeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SecurityCodeTextBox.MaxLength = 3
        Me.SecurityCodeTextBox.Name = "SecurityCodeTextBox"
        Me.SecurityCodeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SecurityCodeTextBox.TabIndex = 43
        '
        'CardholderNameTextBox
        '
        Me.CardholderNameTextBox.Location = New System.Drawing.Point(126, 224)
        Me.CardholderNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CardholderNameTextBox.Name = "CardholderNameTextBox"
        Me.CardholderNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CardholderNameTextBox.TabIndex = 44
        '
        'AddressLine1PaymentTextBox
        '
        Me.AddressLine1PaymentTextBox.Location = New System.Drawing.Point(340, 37)
        Me.AddressLine1PaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressLine1PaymentTextBox.Name = "AddressLine1PaymentTextBox"
        Me.AddressLine1PaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressLine1PaymentTextBox.TabIndex = 45
        '
        'AdressLine2PaymentTextBox
        '
        Me.AdressLine2PaymentTextBox.Location = New System.Drawing.Point(340, 76)
        Me.AdressLine2PaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AdressLine2PaymentTextBox.Name = "AdressLine2PaymentTextBox"
        Me.AdressLine2PaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AdressLine2PaymentTextBox.TabIndex = 46
        '
        'CityNamePaymentTextBox
        '
        Me.CityNamePaymentTextBox.Location = New System.Drawing.Point(340, 115)
        Me.CityNamePaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CityNamePaymentTextBox.Name = "CityNamePaymentTextBox"
        Me.CityNamePaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CityNamePaymentTextBox.TabIndex = 47
        '
        'CountryNamePaymentTextBox
        '
        Me.CountryNamePaymentTextBox.Location = New System.Drawing.Point(340, 154)
        Me.CountryNamePaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CountryNamePaymentTextBox.Name = "CountryNamePaymentTextBox"
        Me.CountryNamePaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CountryNamePaymentTextBox.TabIndex = 48
        '
        'StateNamePaymentTextBox
        '
        Me.StateNamePaymentTextBox.Location = New System.Drawing.Point(340, 192)
        Me.StateNamePaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StateNamePaymentTextBox.MaxLength = 2
        Me.StateNamePaymentTextBox.Name = "StateNamePaymentTextBox"
        Me.StateNamePaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StateNamePaymentTextBox.TabIndex = 49
        '
        'ZipCodePaymentTextBox
        '
        Me.ZipCodePaymentTextBox.Location = New System.Drawing.Point(340, 226)
        Me.ZipCodePaymentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ZipCodePaymentTextBox.Name = "ZipCodePaymentTextBox"
        Me.ZipCodePaymentTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ZipCodePaymentTextBox.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(86, 273)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "* indicates required field"
        '
        'Payment_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 339)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ZipCodePaymentTextBox)
        Me.Controls.Add(Me.StateNamePaymentTextBox)
        Me.Controls.Add(Me.CountryNamePaymentTextBox)
        Me.Controls.Add(Me.CityNamePaymentTextBox)
        Me.Controls.Add(Me.AdressLine2PaymentTextBox)
        Me.Controls.Add(Me.AddressLine1PaymentTextBox)
        Me.Controls.Add(Me.CardholderNameTextBox)
        Me.Controls.Add(Me.SecurityCodeTextBox)
        Me.Controls.Add(Me.ExpirationDateTextBox)
        Me.Controls.Add(Me.CardNumberTextBox)
        Me.Controls.Add(Me.CardTypeTextBox)
        Me.Controls.Add(Me.PaymentAmountTextBox)
        Me.Controls.Add(Me.PaymentAmountLabel)
        Me.Controls.Add(Me.PurchaseBtn)
        Me.Controls.Add(Me.CountryNamePaymentLabel)
        Me.Controls.Add(Me.ZipCodePaymentLabel)
        Me.Controls.Add(Me.StateNamePaymentLabel)
        Me.Controls.Add(Me.AddressLine2PaymentLabel)
        Me.Controls.Add(Me.AddressLine1PaymentLabel)
        Me.Controls.Add(Me.CityNamePaymentLabel)
        Me.Controls.Add(Me.CardholderNameLabel)
        Me.Controls.Add(Me.SecurityCodeLabel)
        Me.Controls.Add(Me.CardTypeLabel)
        Me.Controls.Add(Me.ExpirationDateLabel)
        Me.Controls.Add(Me.CardNumberLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Payment_details"
        Me.Text = "Payment Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CardNumberLabel As Label
    Friend WithEvents ExpirationDateLabel As Label
    Friend WithEvents CardTypeLabel As Label
    Friend WithEvents SecurityCodeLabel As Label
    Friend WithEvents CardholderNameLabel As Label
    Friend WithEvents CityNamePaymentLabel As Label
    Friend WithEvents AddressLine1PaymentLabel As Label
    Friend WithEvents AddressLine2PaymentLabel As Label
    Friend WithEvents StateNamePaymentLabel As Label
    Friend WithEvents ZipCodePaymentLabel As Label
    Friend WithEvents CountryNamePaymentLabel As Label
    Friend WithEvents PurchaseBtn As Button
    Friend WithEvents PaymentAmountLabel As Label
    Friend WithEvents PaymentAmountTextBox As TextBox
    Friend WithEvents CardTypeTextBox As TextBox
    Friend WithEvents CardNumberTextBox As TextBox
    Friend WithEvents ExpirationDateTextBox As TextBox
    Friend WithEvents SecurityCodeTextBox As TextBox
    Friend WithEvents CardholderNameTextBox As TextBox
    Friend WithEvents AddressLine1PaymentTextBox As TextBox
    Friend WithEvents AdressLine2PaymentTextBox As TextBox
    Friend WithEvents CityNamePaymentTextBox As TextBox
    Friend WithEvents CountryNamePaymentTextBox As TextBox
    Friend WithEvents StateNamePaymentTextBox As TextBox
    Friend WithEvents ZipCodePaymentTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
