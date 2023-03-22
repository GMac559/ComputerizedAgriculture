Public Class StartScreen
    Private Sub btnSprinklers_Click(sender As Object, e As EventArgs) Handles btnSprinklers.Click
        Me.Hide()
        Sprinklers.Show()
    End Sub
    Private Sub btnFarmer_Click(sender As Object, e As EventArgs) Handles btnFarmer.Click
        Me.Hide()
        Farmers.Show()
    End Sub
    Private Sub btnTractor_Click(sender As Object, e As EventArgs) Handles btnTractor.Click
        Me.Hide()
        TractorCourses.Show()
    End Sub
End Class
