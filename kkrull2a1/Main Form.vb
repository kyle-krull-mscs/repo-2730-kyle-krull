' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Kyle Krull on 10/2/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'class-level variable for storing salesclerk's name
    Private strClerk As String

    Public Property PrintForm1 As Object

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const strPrompt As String = "Salesclerk's name."
        Const strTITLE As String = "Name Entry"
        Const decITEM_Price As Decimal = 0.5D
        Const dexTAX_RATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        'assign name to class-level variable
        strClerk = InputBox(strPrompt, strTITLE, strClerk)

        'Calculate total number of items sold
        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins

        'Calculate the subtoal
        decSubTotal = intTotalItems * decITEM_Price

        'Calculate the sales tax
        decSalesTax = decSubTotal * dexTAX_RATE

        'Calculate the total Sales
        decTotalSales = decSubTotal + decSalesTax

        'Display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        'Display tax and Slaesclerk's name
        lblMsg.Text = "The Sales Tax was " &
            decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'assign name to class-level variable
        ' Const strPrompt As String = "Salesclerk's name."
        'Const strTITLE As String = "Name Entry"
        'strClerk = InputBox(strPrompt, strTITLE)
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
            Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class
