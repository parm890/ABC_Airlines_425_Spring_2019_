﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_SignUP_Guest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_SignUP_Guest))
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.ContinueAsGuestButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogInButton
        '
        Me.LogInButton.Location = New System.Drawing.Point(168, 157)
        Me.LogInButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(64, 37)
        Me.LogInButton.TabIndex = 0
        Me.LogInButton.Text = "LogIn"
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'SignUpButton
        '
        Me.SignUpButton.Location = New System.Drawing.Point(269, 157)
        Me.SignUpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(65, 37)
        Me.SignUpButton.TabIndex = 1
        Me.SignUpButton.Text = "Sign Up"
        Me.SignUpButton.UseVisualStyleBackColor = True
        '
        'ContinueAsGuestButton
        '
        Me.ContinueAsGuestButton.Location = New System.Drawing.Point(377, 157)
        Me.ContinueAsGuestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ContinueAsGuestButton.Name = "ContinueAsGuestButton"
        Me.ContinueAsGuestButton.Size = New System.Drawing.Size(74, 37)
        Me.ContinueAsGuestButton.TabIndex = 2
        Me.ContinueAsGuestButton.Text = "Continue As Guest"
        Me.ContinueAsGuestButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(83, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to ABC Airlines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please log in, sign up , or contiue as guest."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(648, 55)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Login_SignUP_Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(621, 246)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContinueAsGuestButton)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.LogInButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login_SignUP_Guest"
        Me.Text = "Login_SignUP_Guest"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInButton As Button
    Friend WithEvents SignUpButton As Button
    Friend WithEvents ContinueAsGuestButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
