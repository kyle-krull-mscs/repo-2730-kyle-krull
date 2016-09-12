' Name           Richardson County Property Tax Project   
' Purpose        Calucaltes property tax
' Programmer:    Kyle Krull 9/1/2016

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAssessed_TextChanged(sender As Object, e As EventArgs) Handles txtAssessed.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepair screen for next sale
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        txtAssessed.Focus()

        ' send the focus to the assessed value box
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub
End Class
