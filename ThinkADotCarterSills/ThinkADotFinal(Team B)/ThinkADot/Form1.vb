﻿'Program:       ThinkaDot
'Programmer:    Team B(Michael Rice, Jacob Jorae, Destinee McClure, Sheila Prater, Trevor Pruchniewski,  Carter Sills)
'Date:          7 May 2014
'Description:   This project creates a virtual Think-a-Dot machine. In the original
'               machine, eight windows would alternately display a yellow dot or a
'               blue dot each time a marble passed through its underlying flipper. 
'               The placement of these flippers looked like this:
'
'                       Flipper1                Flipper2                Flipper3
'
'
'                                   Flipper4                Flipper5
'
'
'                       Flipper6                Flipper7                Flipper8
'
'               If the dot had been yellow, the marble would drop down and to the left;
'               if the dot had been blue, the marble would drop down and to the right. 
'               Each time a marble dropped, two or three flippers would change color.
'
'               Flipper is a new control that can be dragged on to the design view of ThinkaDot
'               Review Flipper.vb for properties and methods useful in coding ThinkaDot
' 
Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' This section initializes all Flipper Object Properties to their correct paths so that they drop in the proper direction when the routemarble() method is called. 
        Flipper1.flipLeft = Flipper6
        Flipper1.flipRight = Flipper4
        Flipper2.flipLeft = Flipper4
        Flipper2.flipRight = Flipper5
        Flipper3.flipLeft = Flipper5
        Flipper3.flipRight = Flipper8
        Flipper4.flipLeft = Flipper6
        Flipper4.flipRight = Flipper7
        Flipper5.flipLeft = Flipper7
        Flipper5.flipRight = Flipper8
        Flipper6.flipLeft = FlipperExitLeft
        Flipper6.flipRight = FlipperExitLeft
        Flipper7.flipLeft = FlipperExitLeft
        Flipper7.flipRight = FlipperExitRight
        Flipper8.flipLeft = FlipperExitRight
        Flipper8.flipRight = FlipperExitRight
    End Sub


    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click

        For Each Item In Me.Controls 'Loops through each Control on the Form, resets if a Flipper and sets to 0 if a Text Box

            If TypeOf Item Is Flipper Then

                CType(Item, Flipper).reset() 'Item must be cast to access the reset() method

            ElseIf TypeOf Item Is TextBox Then

                CType(Item, TextBox).Text = "0" 'Item must be cast to access the Text property

            End If

        Next

    End Sub

    Private Sub LeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftButton.Click
        ' Button click event for left button calls recursive method for 1st flipper object
        Me.Flipper1.MarblePath()
    End Sub

    Private Sub MiddleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleButton.Click
        ' Button click event for middle button calls recursive method for 2nd flipper object
        Me.Flipper2.MarblePath()
    End Sub

    Private Sub RightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightButton.Click
        ' Button click event for Right button calls recursive method for 3rd flipper object
        Me.Flipper3.MarblePath()
    End Sub
End Class