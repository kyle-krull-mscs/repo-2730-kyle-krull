' Name:      Ch4 Lesson B, IF staements, message boxes
' Purpose:   Currency, Tea, Elctric, Quotient
'Programmer: Kyle Krull 10/24/2016


Public Class Form1
    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        ' convert American dollars to the Euro, the
        ' Britich Pound, and the South African rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEruo As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty



        Double.TryParse(txtAmdollar.Text, dblAmDollar)
        If txtAmdollar.Text = String.Empty Then


            MessageBox.Show("Please enter the number of american dollars", "currency converter",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            dblEruo = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE


            lblEuro.Text = dblEruo.ToString
            lblPound.Text = dblPound.ToString
            lblRand.Text = dblRand.ToString

        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click

        Dim dblOrder As Double
        Dim dblPrice As Double
        Dim dblTotal As Double

        Double.TryParse(txtOrdered.Text, dblOrder)
        Double.TryParse(txtPrice.Text, dblPrice)

        dblTotal = dblOrder * dblPrice

        dblTotal = dblTotal + 15

        lblTotalDue.Text = dblTotal.ToString


    End Sub
End Class
