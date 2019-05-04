Public Class Show_flights
    Private Sub Show_flights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DepartingFlightsLabel_Click(sender As Object, e As EventArgs) Handles DepartingFlightsLabel.Click

    End Sub

    Private Sub DepartingFlightsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartingFlightsListBox.SelectedIndexChanged

    End Sub

    Private Sub ReturningFlightsLabel_Click(sender As Object, e As EventArgs) Handles ReturningFlightsLabel.Click

    End Sub

    Private Sub ReturningFlightsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReturningFlightsListBox.SelectedIndexChanged

    End Sub

    Private Sub YourItineraryLabel_Click(sender As Object, e As EventArgs) Handles YourItineraryLabel.Click

    End Sub

    Private Sub ShowsCustomerFlightsListBox_TextChanged(sender As Object, e As EventArgs) Handles ShowsCustomerFlightsListBox.TextChanged

    End Sub

    Private Sub FlightChosenContinueBtn_Click(sender As Object, e As EventArgs) Handles FlightChosenContinueBtn.Click
        Payment_details.Show()
    End Sub
End Class