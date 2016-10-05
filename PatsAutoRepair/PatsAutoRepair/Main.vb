'Project: Pat's Auto Repair Billing Application
'Created by Carter Sills
'Version 1.0
'Date: May 04 2014
'Description:  This program takes inputs and calculates total cost of repair including parts, labor and sales tax and displays information in a summary 
Public Class Main

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the current form named Main 
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays modal about box with information about application 
        AboutBox1.ShowDialog()
    End Sub

    Private Sub JobInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobInformationToolStripMenuItem.Click
        'Launches and displays the JobInformation Form modally 
        JobInformation.ShowDialog()
    End Sub
End Class
