Public Class Form1
    Private Sub btnPretestDoWhile_Click(sender As Object, e As EventArgs) Handles btnPretestDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPretestDoUntil_Click(sender As Object, e As EventArgs) Handles btnPretestDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPosttestLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopWhile.Click
        lblEven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnPosttestLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopUntil.Click
        lblEven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine

        For i As Integer = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine

        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As String
        Dim intSum As String
        Dim intCount As String
        Dim dblAvg As Double

        strNum = InputBox(strPROMPT, strTITLE, "0")

        Do
            Int32.TryParse(strNum, intNum)

            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            intCount += 1
            intSum = intSum + intNum
            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop Until strNum <> String.Empty

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If


    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As String
        Dim intSum As String
        Dim intCount As String
        Dim dblAvg As Double

        strNum = InputBox(strPROMPT, strTITLE, "0")

        Do While strNum <> String.Empty
            Int32.TryParse(strNum, intNum)

            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            intCount += 1
            intSum = intSum + intNum
            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop
        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"

        Dim intNum As String
        Dim intSum As String
        Dim intCount As String
        Dim dblAvg As Double
        Dim intSalesQuant As Integer
        Dim strInputCount As String = InputBox("Enter quantity of numbers", "Quanity", "0")
        Integer.TryParse(strInputCount, intSalesQuant)

        'strNum = InputBox(strPROMPT, strTITLE, "0")

        For strNum = 1 To intSalesQuant
            Int32.TryParse(strNum, intNum)

            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            intCount += 1
            intSum = intSum + intNum
            strNum = InputBox(strPROMPT, strTITLE, "0")
        Next strnum

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
