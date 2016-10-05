'Project: Pat's Auto Repair Billing Application
'Created by Carter Sills
'Version 1.0
'Date: May 04 2014
'Description:  This program takes inputs and calculates total cost of repair including parts, labor and sales tax and displays information in a summary 

Option Explicit On
Option Strict On

Public Class JobInformation
    'Rates for Hourly Labor charges and Sales Tax declared here
    Public Const HOURLY_LABOR_Charge As Decimal = 50
    Public Const SALES_TAX_RATE As Decimal = CDec(0.08)
    Private Sub JobInformation_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Hides the Main Menu Form but does not close it when JobInformation form is activated. 
        Main.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        'Closes the current job information form, resets all textboxes and unhides main menu window
        TextCostofParts.Clear()
        TextCustomerName.Clear()
        TextFullName.Clear()
        TextJobNo.Clear()
        TextLaborHours.Clear()
        TextParts.Clear()
        TextLabor.Clear()
        TextSubtotal.Clear()
        TextSalesTax.Clear()
        TextTotal.Clear()
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCalculate.Click
        ' Sub performs calculations  using salestax * PartsCost and  calculates subtotal.  Total amount is calculated by adding  sales tax, labor cost, and parts cost.
        Try
            Dim salesTax As Decimal = 0
            Dim partsCost As Decimal = 0
            Dim laborCost As Decimal = 0
            Dim totalCost As Decimal = 0
            Dim subTotal As Decimal = 0
            partsCost = Decimal.Parse(TextCostofParts.Text)
            laborCost = Decimal.Parse(TextLaborHours.Text) * HOURLY_LABOR_Charge
            salesTax = partsCost * SALES_TAX_RATE
            subTotal = partsCost + laborCost
            totalCost = salesTax + laborCost + partsCost
            TextParts.Text = partsCost.ToString("C")
            TextLabor.Text = laborCost.ToString("C")
            TextSalesTax.Text = salesTax.ToString("C")
            TextTotal.Text = totalCost.ToString("C")
            TextSubtotal.Text = subTotal.ToString("C")
            TextFullName.Text = TextCustomerName.Text.ToString()
            'Catch block beldow checks for numeric entry and displays error message if letters or invalid characters are entered. 
        Catch exception As FormatException
            MessageBox.Show("Quantity must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With TextJobNo
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClear.Click
        'Sub clears all textboxes on the current form and sets focus backto the TextJobNo Field. 
        TextCostofParts.Clear()
        TextCustomerName.Clear()
        TextFullName.Clear()
        TextJobNo.Clear()
        TextLaborHours.Clear()
        TextParts.Clear()
        TextLabor.Clear()
        TextSubtotal.Clear()
        TextSalesTax.Clear()
        TextTotal.Clear()
        With TextJobNo
            .Focus()
        End With
    End Sub

    Private Sub JobInformation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Closes the current job information form, resets all textboxes and unhides main menu window when the form is closed using the X in the upper right of form. 
        TextCostofParts.Clear()
        TextCustomerName.Clear()
        TextFullName.Clear()
        TextJobNo.Clear()
        TextLaborHours.Clear()
        TextParts.Clear()
        TextLabor.Clear()
        TextSubtotal.Clear()
        TextSalesTax.Clear()
        TextTotal.Clear()
        Main.Show()
        Me.Close()
    End Sub
End Class