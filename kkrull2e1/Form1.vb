Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim dblAmount As Double
        Dim dblCard As Double
        Dim dblShipping As Double

        lblShip.Text = String.Empty

        Double.TryParse(txtOrder.Text, dblAmount)

        If txtOrder.Text >= 100 Then
            dblShipping = 0
        Else
            dblShipping = dblAmount + 9

            lblShip.Text = dblShipping.ToString
        End If


    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim dblAmount As Double
        Dim strCard As String
        Dim dblShipping As Double

        lblShip.Text = String.Empty
        txtCard.Text = strCard.ToUpper


        Double.TryParse(txtOrder.Text, dblAmount)



        If strCard.ToUpper = "y" OrElse dblAmount >= 100 Then
            dblShipping = 0
        Else
            dblShipping = 9

            lblShip.Text = dblShipping.ToString
        End If
    End Sub
End Class
