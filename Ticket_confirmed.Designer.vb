<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_confirmedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticket_confirmedForm))
        Me.ConfirmedTicketLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ConfirmedTicketLabel
        '
        Me.ConfirmedTicketLabel.AutoSize = True
        Me.ConfirmedTicketLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmedTicketLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmedTicketLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConfirmedTicketLabel.Location = New System.Drawing.Point(96, 128)
        Me.ConfirmedTicketLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConfirmedTicketLabel.Name = "ConfirmedTicketLabel"
        Me.ConfirmedTicketLabel.Size = New System.Drawing.Size(387, 78)
        Me.ConfirmedTicketLabel.TabIndex = 0
        Me.ConfirmedTicketLabel.Text = "Your payment has been confirmed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and your itinerary has been sent to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " your emai" &
    "l address " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ConfirmedTicketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ticket_confirmedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ConfirmedTicketLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ticket_confirmedForm"
        Me.Text = "Ticket confirmed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmedTicketLabel As Label
End Class
