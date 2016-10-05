'Project: Weekly Sales and Commission Calculator
'Created by Carter Sills
'Version 1.0
'Date: April 26 2014
'Description:  This program takes inputs from Sales Person and calculates total sales, commissions and pay
'                and keeps a running total that can be displayed by clicking on summary. 
Option Explicit On
Option Strict On
Public Class Form1
    ' Constants and Global Variables used to calculate sales, commissions and pay
    Const BASE_PAY As Decimal = 250D
    Const QUOTA As Decimal = 1000D
    Const COMMISSION_RATE As Decimal = 0.15D
    Dim TotalSales As Decimal = 0
    Dim TotalCommissions As Decimal = 0
    Dim TotalPay As Decimal = 0


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the application 
        Me.Close()
    End Sub

    Private Sub PayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayToolStripMenuItem.Click
        ' Sub uses weekly sales  to calculate commission and pay if sales persons meets quota. If quota not met then no commission is calculated.
        Try
            Dim weeklySales As Decimal = Decimal.Parse(TextWeeklySales.Text)
            Dim commisson As Decimal = 0
            Dim pay As Decimal = 0

            If weeklySales >= QUOTA Then
                TotalSales += weeklySales
                commisson = COMMISSION_RATE * weeklySales
                TotalCommissions += commisson
                pay = commisson + BASE_PAY
                TotalPay += pay
                textName.Text = TextFirstName.Text.ToString & " " & TextLastName.Text.ToString
                TextCommission.Text = commisson.ToString("N")
                TextPay.Text = pay.ToString("N")
            Else
                pay = BASE_PAY
                TotalSales += weeklySales
                TotalCommissions += commisson
                TotalPay += pay
                textName.Text = TextFirstName.Text.ToString & " " & TextLastName.Text.ToString
                TextCommission.Text = ""
                TextPay.Text = pay.ToString("N")
            End If
        Catch exception As FormatException
            ' Catches error if user enters invalid data in Weekly Sales textbox. 
            MessageBox.Show("Please enter a numerical value for Weekly Sales", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears all textboxes on the form and sets focus to First Name 
        TextFirstName.Clear()
        TextLastName.Clear()
        TextCommission.Clear()
        TextPay.Clear()
        textName.Clear()
        TextWeeklySales.Clear()
        With TextFirstName
            .Focus()
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allows user to change text color for read only text boxes. Backcolor must be set before textcolor can be changed.
        With ColorDialog1
            .Color = textName.ForeColor
            .ShowDialog()
            Me.textName.BackColor = Me.textName.BackColor
            Me.TextCommission.BackColor = Me.TextCommission.BackColor
            Me.TextPay.BackColor = Me.TextPay.BackColor
            textName.ForeColor = .Color
            TextCommission.ForeColor = .Color
            TextPay.ForeColor = .Color

        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Allow user to select and change font type and size for read only textboxes. 
        With FontDialog1
            .Font = textName.Font
            .ShowDialog()
            textName.Font = .Font
            TextCommission.Font = .Font
            TextPay.Font = .Font

        End With
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Sub opens messagebox and displays running total of sales, commissions and pay for all Salespersons. 
        MessageBox.Show("Sales:" & " " & TotalSales.ToString("C") & Environment.NewLine & Environment.NewLine & "Commissions:" & " " & _
                        TotalCommissions.ToString("C") & Environment.NewLine & Environment.NewLine & "Pay:" & " " & TotalPay.ToString("C"), "Total Amounts")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays author information for application. 
        Dim aboutMessage As String
        aboutMessage = "Total Sales and Commission Calculator:" & Environment.NewLine &
            "Programmed by Carter Sills April 26 2014"
        MessageBox.Show(aboutMessage, "About Total Sales and Commission Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
