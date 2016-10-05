'Project: Charter Information Application
'Created by Carter Sills
'Version 1.0
'Date: May 05 2014
'Description:  This program takes inputs and calculates total cost of a boat charter using hours, boat size and rate per hour values. 
'              Program also performs Summary calculations and prints them to a print preview window before printing. 

Option Strict On
Option Explicit On
Public Class Form1
    ' Global Variables declared and initialized 
    Dim totalRevenue As Decimal = 0
    Dim numberOfCharters As Integer = 0
    Dim averageHoursPerCharter As Decimal = 0
    Dim hourlyRate As Decimal = 0
    Dim yachtSize As Integer = 0
    Dim totalhours As Decimal = 0
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Sub closes the current form and exits program
        Me.Close()
    End Sub
    Private Sub CalculateSummaryReport()
        ' Sub performs calculations and sums totals to be used on main form and summary report 
        Dim responsibleparty As String = Nothing
        Dim hoursChartered As Decimal = 0
        Dim totalCost As Decimal = 0
        Dim hours As Decimal = 0

        Try

            hours = Decimal.Parse(TextHoursChartered.Text)
            totalCost = hours * hourlyRate
            TextTotalCost.Text = totalCost.ToString("C")
            numberOfCharters += 1
            totalhours += hours

            averageHoursPerCharter = totalhours / numberOfCharters
            totalRevenue += totalCost
            responsibleparty = TextResponsibleParty.Text.ToString()
            TextAmount.Text = TextTotalCost.Text
            TextName.Text = TextResponsibleParty.Text
            TextHours.Text = TextHoursChartered.Text
            TextHourlyRate.Text = hourlyRate.ToString("C")


        Catch ex As FormatException
            MessageBox.Show("Please enter numerical value for hours:", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try



    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Sub shows About Form information that has copyright info.
        AboutBox1.ShowDialog()
    End Sub


    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        'Button closes current form and exits program. 
        Me.Close()
    End Sub

    Private Sub ComboYachtLength_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboYachtLength.SelectedIndexChanged
        ' Sub determines yacht size and sets hourly rate accordingly

        yachtSize = Integer.Parse(ComboYachtLength.Text)

        If yachtSize = 22 Then
            hourlyRate = CDec(95.0)
        ElseIf yachtSize = 24 Then
            hourlyRate = CDec(137.0)
        ElseIf yachtSize = 30 Then
            hourlyRate = CDec(160.0)
        ElseIf yachtSize = 32 Then
            hourlyRate = CDec(192.0)
        ElseIf yachtSize = 36 Then
            hourlyRate = CDec(250.0)
        ElseIf yachtSize = 38 Then
            hourlyRate = CDec(400.0)
        ElseIf yachtSize = 45 Then
            hourlyRate = CDec(550.0)
        Else
            hourlyRate = CDec(0)

        End If
    End Sub

    Private Sub ButtonAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAccept.Click
        ' Button click event causes Group Box element to become visible and then calls the sub to calculate values on Form. 
        GroupBoxSummary.Visible = True

        If TextResponsibleParty.Text = "" Then
            MessageBox.Show("Please enter your name:", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ComboYachtType.Text = "" Then
            MessageBox.Show("Please select a yacht type:", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CalculateSummaryReport()
        End If


    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        'Sub clears entries on current form so that next charter can be entered
        Dim ResponseDialogResult As DialogResult
        ResponseDialogResult = MessageBox.Show("Clear the selected items?", "Clear Selections", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then

            ComboYachtType.ResetText()
            ComboYachtLength.SelectedIndex = 0
            TextHoursChartered.Clear()
            TextResponsibleParty.Clear()
            TextHoursChartered.Text = "0"
            TextTotalCost.Clear()
            TextName.Clear()
            TextHours.Clear()
            TextAmount.Clear()
            TextHourlyRate.Clear()
            GroupBoxSummary.Visible = False
        End If
    End Sub

    Private Sub ClearForNextCharterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearForNextCharterToolStripMenuItem.Click
        ' Sub clears all entries on form so that next Charter or customer info can be entered.
        Dim ResponseDialogResult As DialogResult
        ResponseDialogResult = MessageBox.Show("Clear the selected items?", "Clear Selections", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then

            ComboYachtType.ResetText()
            ComboYachtLength.SelectedIndex = 0
            TextHoursChartered.Clear()
            TextResponsibleParty.Clear()
            TextHoursChartered.Text = "0"
            TextTotalCost.Clear()
            TextName.Clear()
            TextHours.Clear()
            TextAmount.Clear()
            GroupBoxSummary.Visible = False

        End If
    End Sub

    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click
        ' Sub displays count of yacht items in messagebox window
        Dim MessageString As String
        MessageString = "The number of Yacht Types is " &
            ComboYachtType.Items.Count & "."
        MessageBox.Show(MessageString, "Yacht Type Count ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        ' Sub adds new item to yacht types in combobox list
        With ComboYachtType
            If .Text <> "" Then
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else : ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate Item found.", "Cannot Add Item",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a Yacht type to add", "Missing Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        'Sub removes item from list in combobox for yacht types. 
        With ComboYachtType
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("Please select an item to remove", "Selection required",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub PrintYachtTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintYachtTypesToolStripMenuItem.Click
        ' Sub calls function to print list of Yacht Types to a print preview window 
        PrintPreviewDialog1.Document = PrintYachtTypes

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintYachtTypes_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintYachtTypes.PrintPage
        ' Sub formats and sets up document to print out list of yacht types and send them to print preview window. 
        Dim PrintFont As New Font("Verdana", 14)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 4
        Dim HorizontalPrintLocationSingle As Single = 200
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String


        Using HeadingFont As New Font("Verdana", 14, FontStyle.Bold)
            e.Graphics.DrawString("Yacht Types", HeadingFont,
                                  Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using
        VerticalPrintLocationSingle += 50
        For ListIndexInteger As Integer = 0 To ComboYachtType.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle

            PrintLineString = ComboYachtType.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, _
                                  Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger
    End Sub





    Private Sub PrintSummaryDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSummaryDocument.PrintPage
        ' Sub sets up and formats document to send to print preview window for Summary printout which outputs Total Revenue, Average Hours, and Number of Charters to be sent to print preview window.
        Dim PrintFont As New Font("Verdana", 14)
        Dim PrintFontLabel As New Font("Verdana", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 4
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim HorizontalPrintLocationSingle2 As Single = 200
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim ColumnEndSingle As Single = 600.0
        Dim ColumnXSingle As Single
        Dim FontSizeF As New SizeF()
        Dim totalRevenueString As String = Nothing
        Dim totalNumberofChartersString As String = Nothing
        Dim averageHoursPerCharterString As String = Nothing

        totalRevenueString = totalRevenue.ToString("N")
        totalNumberofChartersString = numberOfCharters.ToString("N")
        averageHoursPerCharterString = averageHoursPerCharter.ToString("N")
        FontSizeF = e.Graphics.MeasureString(totalRevenueString, PrintFont)
        ColumnXSingle = ColumnEndSingle - FontSizeF.Width

        Using HeadingFont As New Font("Verdana", 18, FontStyle.Bold)
            e.Graphics.DrawString("Summary Report Programmed by Carter Sills", HeadingFont,
                                  Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using
        VerticalPrintLocationSingle += 75
        e.Graphics.DrawString("Number of Charters:" & " ", PrintFontLabel, Brushes.Black,
                              HorizontalPrintLocationSingle2, VerticalPrintLocationSingle)
        e.Graphics.DrawString(totalNumberofChartersString, PrintFont, Brushes.Black,
                              ColumnXSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        VerticalPrintLocationSingle += 75
        e.Graphics.DrawString("Average Hours:" & " ", PrintFontLabel, Brushes.Black,
                              HorizontalPrintLocationSingle2, VerticalPrintLocationSingle)
        e.Graphics.DrawString(averageHoursPerCharterString, PrintFont, Brushes.Black,
                              ColumnXSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        VerticalPrintLocationSingle += 75
        e.Graphics.DrawString("Total Revenue is:" & " ", PrintFontLabel, Brushes.Black,
                              HorizontalPrintLocationSingle2, VerticalPrintLocationSingle)
        e.Graphics.DrawString("$" & totalRevenueString, PrintFont, Brushes.Black,
                              ColumnXSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle


    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        ' Sub calls function to send document for Summary which outputs Total Revenue, Average Hours, and Number of Charters to be sent to print preview window.
        PrintPreviewDialog1.Document = PrintSummaryDocument

        PrintPreviewDialog1.ShowDialog()
    End Sub

   
End Class
