Imports System.Data.SqlClient

Public Class UserNamePass

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        UpdateFlight.Show()



        'Dim connection As New SqlConnection("Server= SAMSNG-PC; Database = TestDB; Integrated Security = true")

        ' Dim command As New SqlCommand("select * from Table_login where Username = @username and Password = @password", connection)

        'Command.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text
        'Command.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordTextBox.Text

        'Dim adapter As New SqlDataAdapter(command)

        'Dim table As New DataTable()

        'adapter.Fill(table)
        'If table.Rows.Count() <= 0 Then

        'MessageBox.Show("UserName or Password Are Incorrect")

        'Else
        'MessageBox.Show("Login successful")
        '
        'Me.Close()
        'End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UserNamePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
