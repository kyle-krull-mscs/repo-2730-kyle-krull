'Name:        Photo Project
'Purpose:     Displays the gross pay, FWT, FICA, state income tax, and net pay
'Programmer:  Kyle Krull on 9/26/2016

Option Strict On

Public Class MainForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Preparing for next input
        txtHours.Text = String.Empty
        txtName.Text = String.Empty
        txtRate.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        txtName.Focus()
        'send the foucs to name
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, withholdings, and net pay
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text), "fixed")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
