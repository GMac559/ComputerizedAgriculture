Public Class Sprinklers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        StartScreen.Show()
    End Sub
    Private Sub btnField1On_Click(sender As Object, e As EventArgs) Handles btnField1On.Click
        If pbField1.BackColor = Color.ForestGreen Then
            MessageBox.Show("This field already has the sprinklers turned on.")
        ElseIf pbField1.BackColor = Color.Red Then
            pbField1.BackColor = Color.ForestGreen
            MessageBox.Show("The sprinklers for Field 1 have now been turned on.")
        End If
    End Sub
    Private Sub btnField1Off_Click(sender As Object, e As EventArgs) Handles btnField1Off.Click
        If pbField1.BackColor = Color.Red Then
            MessageBox.Show("This field already has the sprinklers turned off.")
        ElseIf pbField1.BackColor = Color.ForestGreen Then
            pbField1.BackColor = Color.Red
            MessageBox.Show("The sprinklers for Field 1 have now been turned off.")
        End If
    End Sub
    Private Sub btnField2On_Click(sender As Object, e As EventArgs) Handles btnField2On.Click
        If pbField2.BackColor = Color.ForestGreen Then
            MessageBox.Show("This field already has the sprinklers turned on.")
        ElseIf pbField2.BackColor = Color.Red Then
            pbField2.BackColor = Color.ForestGreen
            MessageBox.Show("The sprinklers for Field 2 have now been turned on.")
        End If
    End Sub
    Private Sub btnField2Off_Click(sender As Object, e As EventArgs) Handles btnField2Off.Click
        If pbField2.BackColor = Color.Red Then
            MessageBox.Show("This field already has the sprinklers turned off.")
        ElseIf pbField2.BackColor = Color.ForestGreen Then
            pbField2.BackColor = Color.Red
            MessageBox.Show("The sprinklers for Field 2 have now been turned off.")
        End If
    End Sub
    Private Sub btnField3On_Click(sender As Object, e As EventArgs) Handles btnField3On.Click
        If pbField3.BackColor = Color.ForestGreen Then
            MessageBox.Show("This field already has the sprinklers turned on.")
        ElseIf pbField3.BackColor = Color.Red Then
            pbField3.BackColor = Color.ForestGreen
            MessageBox.Show("The sprinklers for Field 3 have now been turned on.")
        End If
    End Sub
    Private Sub btnField3Off_Click(sender As Object, e As EventArgs) Handles btnField3Off.Click
        If pbField3.BackColor = Color.Red Then
            MessageBox.Show("This field already has the sprinklers turned off.")
        ElseIf pbField3.BackColor = Color.ForestGreen Then
            pbField3.BackColor = Color.Red
            MessageBox.Show("The sprinklers for Field 3 have now been turned off.")
        End If
    End Sub
    Private Sub btnField4On_Click(sender As Object, e As EventArgs) Handles btnField4On.Click
        If pbField4.BackColor = Color.ForestGreen Then
            MessageBox.Show("This field already has the sprinklers turned on.")
        ElseIf pbField4.BackColor = Color.Red Then
            pbField4.BackColor = Color.ForestGreen
            MessageBox.Show("The sprinklers for Field 4 have now been turned on.")
        End If
    End Sub
    Private Sub btnField4Off_Click(sender As Object, e As EventArgs) Handles btnField4Off.Click
        If pbField4.BackColor = Color.Red Then
            MessageBox.Show("This field already has the sprinklers turned off.")
        ElseIf pbField4.BackColor = Color.ForestGreen Then
            pbField4.BackColor = Color.Red
            MessageBox.Show("The sprinklers for Field 4 have now been turned off.")
        End If
    End Sub
End Class