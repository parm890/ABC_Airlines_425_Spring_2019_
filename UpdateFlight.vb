Public Class UpdateFlight
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsForAdmin2DataSet.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.FlightsForAdmin2DataSet.Flights)

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        FlightsBindingSource.MovePrevious()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        FlightsBindingSource.AddNew()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        FlightsBindingSource.MoveNext()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        On Error GoTo SaveErr
        FlightsBindingSource.EndEdit()
        FlightsTableAdapter.Update(FlightsForAdmin2DataSet.Flights)
        MessageBox.Show("Entered Successfully")
SaveErr:
        Exit Sub
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        FlightsBindingSource.RemoveCurrent()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class