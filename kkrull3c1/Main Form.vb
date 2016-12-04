' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   <Kyle Krull> on <11/30/2016>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
        radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0


        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)
        End If

        lblResult.Text = dblResult.ToString("n2")

    End Sub



    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Return dblMeas * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        Return dblMeas / 2.54
    End Function

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlantes.Items.Add("Earth")
        cboPlantes.Items.Add("Mercury")
        cboPlantes.Items.Add("Venus")
        cboPlantes.Items.Add("Mars")
        cboPlantes.Items.Add("Jupiter")
        cboPlantes.Items.Add("Saturn")
        cboPlantes.Items.Add("Uranus")
        cboPlantes.Items.Add("Neptune")
        cboPlantes.Items.Add("Pluto")
        cboPlantes.Text = "Earth"
    End Sub

    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        Dim dblGravity As Double = 0.0
        Select Case cboPlantes.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        Return intWeight * dblGravity
    End Function

    Private Sub InputChanged(sender As Object, e As EventArgs) _
            Handles txtEarthWeight.TextChanged, rdoPlanetSub.CheckedChanged, rdoPlanetFunc.CheckedChanged
        Dim intWeight As Integer




    End Sub
End Class
