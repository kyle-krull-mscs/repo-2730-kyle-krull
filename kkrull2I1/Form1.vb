Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04Substring.Text
        strItem = strItem.Substring(2, 4)
        lbl04Substring.Text = strItem

        '#05a Length
        Dim strsize As String = txt05aLength.Text
        strsize = strsize.Length
        lbl05aLength.Text = strsize

        '#05b Trim
        Dim strstate As String = txt05bTrim.Text
        strstate = strstate.Trim
        lbl05bTrim.Text = strstate

        '05c Remove/Insert
        Dim strword1 As String = txt05cRemoveInsert.Text
        strword1 = strword1.Remove(1, 1)
        strword1 = strword1.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strword1

        '05d Insert
        Dim strword2 As String = txt05dInsert.Text
        strword2 = strword2.Insert(0, "Mon")
        lbl05dInsert.Text = strword2

        '05e Pad
        Dim strPay As String = txt05ePad.Text
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '06 Remove
        Dim strAmount As String = txt06Remove.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06Remove.Text = strAmount

        '07 Contains
        Dim strAddress As String = txt07Contains.Text
        Dim blnIscontained As Boolean
        strAddress = strAddress.ToLower
        blnIscontained = strAddress.Contains("jefferson street")
        lbl07Contains.Text = blnIscontained

        '12 Len/Remove
        Dim strTaxRate As String = txt12LenRemove.Text
        strTaxRate = strTaxRate.Remove(4)
        lbl12LenRemove.Text = strTaxRate

        '13 Like
        Dim strzip As String = txt13Like.Text
        If strzip Like "605##" Then
            lbl13Like.Text = "Shipping $25"
        ElseIf strzip Like "606##" Then
            lbl13Like.Text = "Shipping $30"
        Else
            lbl13Like.Text = "Invalid Zip"
        End If




    End Sub
End Class
