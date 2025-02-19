''' <summary>
''' Author: King_Frandy
''' Date: 20/02/25
''' Title: Number Formatter
''' </summary>
Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Variables 
        Dim numbertobeformatted As Decimal
        Dim StringInput As String = txtInputNumber.Text

        'Trys to convert string to decimal 
        If Decimal.TryParse(StringInput, numbertobeformatted) Then
            'The coversion process
            numbertobeformatted = StringInput.ToString()
        Else
            'If could not covert
            lblOutput.Text = "Could Not Covert"
        End If
        ' If statement that check if the radio button is selected
        If radWholeNumbers.Checked = True Then
            'Uses the Math.Round method to round to whole number
            numbertobeformatted = Math.Round(numbertobeformatted)
            lblOutput.Text = numbertobeformatted
            ' If statement that check if the radio button is selected
        ElseIf radCurrency.Checked = True Then
            numbertobeformatted = FormatCurrency(numbertobeformatted)
            lblOutput.Text = numbertobeformatted
            ' If statement that check if the radio button is selected
        ElseIf radThreeDecimals.Checked = True Then
            'Uses the Math.Round method to round to three decimals places
            numbertobeformatted = Math.Round(numbertobeformatted, 3)
            lblOutput.Text = numbertobeformatted
            ' If statement that check if the radio button is selected
        ElseIf radTwoDecimals.Checked = True Then
            'Uses the Math.Round method to round to two decimals places
            numbertobeformatted = Math.Round(numbertobeformatted, 2)
            lblOutput.Text = numbertobeformatted
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets all varibles
        lblOutput.Text = ""
        txtInputNumber.Text = ""
        radCurrency.Checked = False
        radThreeDecimals.Checked = False
        radTwoDecimals.Checked = False
        radWholeNumbers.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Kills application
    End Sub
End Class
