' Nme:          Average Project
'Purpose:       Displays the average of 3 test scores
'Programmer:    Kyle Krull on 9/25/2016

Option Strict On


Public Class frmMain
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepare calculator for next input
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        lblAverage.Text = String.Empty
        txtTest1.Focus()
        'Send the focus to Test1 
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calulates the average of all 3 test scores
        lblAverage.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3)
    End Sub
End Class
