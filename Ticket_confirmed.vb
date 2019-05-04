Public Class Ticket_confirmedForm
    Private Sub Ticket_confirmedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Imports EASendMail ' Add EASendMail namespace
    'Module Module1
    'Sub Main()
    'Dim oMail As New SmtpMail("TryIt")
    'Dim oSmtp As New SmtpClient()

    ' Set sender email address, please change it to yours
    '        oMail.From = "test@emailarchitect.net"

    ' Set recipient email address, please change it to yours
    '       oMail.To = "support@emailarchitect.net"

    ' Set email subject
    '      oMail.Subject = "test email from VB.NET project"

    ' Set email body
    '     oMail.TextBody = "this is a test email sent from VB.NET project, do not reply"

    ' Your SMTP server address
    'Dim oServer As New SmtpServer("smtp.emailarchitect.net")

    ' User and password for ESMTP authentication, if your server doesn't require
    ' User authentication, please remove the following codes.
    '       oServer.User = "test@emailarchitect.net"
    '      oServer.Password = "testpassword"

    ' If your smtp server requires SSL connection, please add this line
    ' oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

    'Try
    '         Console.WriteLine("start to send email ...")
    '          oSmtp.SendMail(oServer, oMail)
    '         Console.WriteLine("email was sent successfully!")
    'Catch ep As Exception
    '           Console.WriteLine("failed to send email with the following error:")
    '          Console.WriteLine(ep.Message)
    'End Try
    'End Sub
    'End Module
    'End Sub

    Private Sub ConfirmedTicketLabel_Click(sender As Object, e As EventArgs) Handles ConfirmedTicketLabel.Click

    End Sub
End Class