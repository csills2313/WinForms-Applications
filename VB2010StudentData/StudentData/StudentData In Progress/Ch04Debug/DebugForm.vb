'Program:			Chapter 4 Debugging
'Programmer:        Bradley/Millspaugh
'Date:				June 2008
'Description:		This program is designed to be used as a
'					debugging exercise.
'Folder:            Ch04Debug

Public Class DebugForm
    ' Declare module-level variables.
    Private BlueTotalDecimal, RedTotalDecimal, WhiteTotalDecimal, _
      WhiteDecimal As Decimal

    Private Sub CalculateButton_Click(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculate the summary.

        Dim QuantityDecimal, TotalDecimal As Decimal

        ' Try
        ' Convert input to numeric.
        QuantityDecimal = Decimal.Parse(QuantityTextBox.Text)

        ' Add to the correct total.
        If BlueRadioButton.Checked Then
            BlueTotalDecimal += QuantityDecimal
        ElseIf RedRadioButton.Checked Then
            RedTotalDecimal = QuantityDecimal
        ElseIf WhiteRadioButton.Checked Then
            WhiteTotalDecimal += 1
        End If

        ' Format totals for output.
        BlueTotalTextBox.Text = BlueTotalDecimal.ToString()
        RedTotalTextBox.Text = RedTotalDecimal.ToString()
        WhiteTotalTextBox.Text = WhiteTotalDecimal.ToString()

        ' Calculate total of all colors.
        TotalDecimal = BlueTotalDecimal + RedTotalDecimal + WhiteTotalDecimal

        ' Calculate and format the percentages.
        If TotalDecimal > 0 Then
            BluePercentTextBox.Text = (BlueTotalDecimal / TotalDecimal).ToString("P")
            RedPercentTextBox.Text = (RedTotalDecimal / TotalDecimal).ToString("P")
            WhitePercentTextBox.Text = (WhiteTotalDecimal / TotalDecimal).ToString("P")
        End If

        ' Clear the quantity and reset the focus.
        With QuantityTextBox
            .Clear()
            .Focus()
        End With

        'Catch
        '    MessageBox.Show("Enter numeric data.", "Data Error", _
        '      MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    With QuantityTextBox
        '        .Focus()
        '        .SelectAll()
        '    End With
        'End Try
    End Sub

    Private Sub ExitButton_Click(ByVal eventSender As System.Object, _
     ByVal eventArgs As System.EventArgs) Handles ExitButton.Click
        ' End the project.

        Me.Close()
    End Sub
End Class
