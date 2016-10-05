'Project: Checking Account Balance 
'Created by Carter Sills
'Version 1.0
'Date: April 19 2014
'Description:  This program takes inputs from customer and calculates total balance using
'                deposits, withdrawals, and service charges. 
Option Strict On
Option Explicit On
Public Class Form1
    'Module level variables declared and initialized here
    Dim serviceChargeDecimal As Decimal = 0.15
    Dim depositDecimal As Decimal = 0
    Dim balanceDecimal As Decimal = 0
    Dim checkDecimal As Decimal = 0
    Private Sub Calculate_Add_Deposit()
        'Adds deposit to current balance
        Try
            Dim totalbalanceDecimal As Decimal
            balanceDecimal = balanceDecimal + Decimal.Parse(textDeposit.Text)
            totalbalanceDecimal += balanceDecimal
            textBalance.Text = totalbalanceDecimal.ToString("C")
        Catch CalculateException As FormatException
            'Handles data entry exception for Deposit entry.
            MessageBox.Show("Please enter a valid amount in dollars. Valid amount required for Deposit", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch AnException As Exception
            'Handles any other exceptions
            MessageBox.Show("Error:" & AnException.Message)
        End Try

    End Sub
    Private Sub Calculate_Withdrawal()
        'Subtracts withdrawal from current Balance
        Try
            If balanceDecimal > -1 Then
                Dim totalbalanceDecimal As Decimal
                balanceDecimal = balanceDecimal - Decimal.Parse(textCheck.Text)

                totalbalanceDecimal -= balanceDecimal
                textBalance.Text = totalbalanceDecimal.ToString("C")
            Else
                balanceDecimal = 0
                textBalance.Text = balanceDecimal.ToString("C")
                MessageBox.Show("You have overdrawn your account, Please deposit more money.", "Account Overdrawn Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch WithdrawalException As FormatException
            'Handles data entry exception for Withdrawal entry.
            MessageBox.Show("Please enter a valid amount in dollars. Valid amount required for Withdrawal", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch AnException As Exception
            'Handles any other exceptions
            MessageBox.Show("Error:" & AnException.Message)
        End Try
    End Sub
    Private Sub Calculate_Service_Charge()
        ' Sub calculates service charge using known rate of 15 percent. 
        Try
            Dim totalServiceChargeDecimal As Decimal = balanceDecimal * serviceChargeDecimal
            textServiceCharge.Text = totalServiceChargeDecimal.ToString("N")
        Catch ServiceChargeException As FormatException
            'Handles data entry exception for service charge entry.
            MessageBox.Show("Please enter a valid amount in dollars. Valid amount required for Service Charge", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch AnException As Exception
            'Handles any other exceptions
            MessageBox.Show("Error:" & AnException.Message)
            balanceDecimal = 0
            textBalance.Text = balanceDecimal.ToString("C")
        End Try
    End Sub
    Private Sub Subtract_Service_Charge()
        'Sub that subtracts service charge from current balance
        Try
            If balanceDecimal > -1 Then
                Dim totalbalanceDecimal As Decimal
                balanceDecimal = balanceDecimal - Decimal.Parse(textServiceCharge.Text)
                totalbalanceDecimal -= balanceDecimal
                textBalance.Text = totalbalanceDecimal.ToString("C")
            Else
                balanceDecimal = 0
                textBalance.Text = balanceDecimal.ToString("C")
                MessageBox.Show("You have overdrawn your account, Please deposit more money.", "Account Overdrawn Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                
            End If

        Catch ServiceChargeException As FormatException
            'Handles data entry exception for service charge entry.
            MessageBox.Show("Please enter a valid amount in dollars. Valid amount required for Service Charge", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch AnException As Exception
            'Handles any other exceptions
            MessageBox.Show("Error:" & AnException.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form loads intial balance of $500.00
        radioDeposit.Select()
        balanceDecimal = 500
        textBalance.Text = balanceDecimal.ToString("C")


    End Sub


    Private Sub Set_Focus()
        'Sets Focus on form to deposit field and resets radio buttons
        textDeposit.ReadOnly = False
        textCheck.ReadOnly = True
        textServiceCharge.ReadOnly = True
        radioDeposit.Focus()
        With textDeposit

            .Focus()

        End With
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Resets and clears all texboxes on form except for textBalance. 
        Set_Focus()
        textServiceCharge.Clear()
        textCheck.Clear()
        textDeposit.Clear()
        textServiceCharge.Text = "0"
        textDeposit.Text = "0"
        textCheck.Text = "0"
        With textDeposit
            .SelectAll()
        End With

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit Button closes program 
        Me.Close()
    End Sub


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Calculate Button calls subs that peform calculations to  add deposit, subtract withdrawal and service charge amounts

        Calculate_Add_Deposit()

        Calculate_Withdrawal()

        Subtract_Service_Charge()



    End Sub


    Private Sub radioDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioDeposit.CheckedChanged
        'Deposit radio button sets focuts to Deposit data entry  field and clears other textboxes
        textDeposit.Focus()
        textCheck.Text = "0"
        textServiceCharge.Text = "0"
        textDeposit.ReadOnly = False
        textCheck.ReadOnly = True
        textServiceCharge.ReadOnly = True

    End Sub

    Private Sub radioCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioCheck.CheckedChanged
        'Check radio button sets focuts to Check data entry  field and clears other textboxes
        textDeposit.Text = "0"
        textServiceCharge.Text = "0"
        textDeposit.ReadOnly = True
        textCheck.Focus()
        textCheck.ReadOnly = False
        textServiceCharge.ReadOnly = True
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Prints a print preview of the current form in use
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub radioServiceCharge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioServiceCharge.CheckedChanged
        'Service Charge radio button sets focuts to Service Charge data entry  field and clears other textboxes.
        textDeposit.Text = "0"
        textCheck.Text = "0"
        textDeposit.ReadOnly = True
        textCheck.ReadOnly = True
        textServiceCharge.ReadOnly = False
        textServiceCharge.Focus()
        Calculate_Service_Charge()
    End Sub
End Class
