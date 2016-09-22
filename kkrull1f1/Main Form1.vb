Option Strict On
Public Class frmMain
    'Name:          Cranston Berries Project
    'Purpose:       Calculates projected sales
    'Programmer:    Kyle Krull



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblProjIncrease_Click(sender As Object, e As EventArgs) Handles lblProjIncrease.Click

    End Sub

    Private Sub lblProjStraw_Click(sender As Object, e As EventArgs) Handles lblProjStraw.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtProjIncrease_TextChanged(sender As Object, e As EventArgs) Handles txtProjIncrease.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing screen for next input
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        txtStraw.Focus()
        'Send the focus to the strawberries box



    End Sub
End Class
