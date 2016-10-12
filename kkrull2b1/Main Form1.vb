'Name:          Cranston Berries Project
'Purpose:       Calculates projected sales
'Programmer:    Kyle Krull on 10/9/2016

Option Strict On
Option Infer Off
Option Explicit On
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblProjIncrease_Click(sender As Object, e As EventArgs) Handles lblProjIncrease.Click

    End Sub

    Private Sub lblProjStraw_Click(sender As Object, e As EventArgs) Handles lblProjStraw.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decProj As Decimal = 0.05D
        Dim intStraw As Integer
        Dim intBlue As Integer
        Dim intRas As Integer
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRas As Decimal

        Integer.TryParse(txtStraw.Text, intStraw)
        Integer.TryParse(txtBlue.Text, intBlue)
        Integer.TryParse(txtRasp.Text, intRas)

        decStraw = intStraw * decProj
        decBlue = intBlue * decProj
        decRas = intRas * decProj

        lblProjStraw.Text = Convert.ToString(decStraw)
        lblBlue.Text = Convert.ToString(decBlue)
        lblRasp.Text = Convert.ToString(decRas)

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
