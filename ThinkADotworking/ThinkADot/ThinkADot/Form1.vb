'Program:       ThinkaDot
'Programmer:    Team B(Carter Sills)
'Date:          19 March 2014
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
    End Sub

    Private Sub LeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftButton.Click
        Me.Flipper1.MarblePath()
    End Sub

    Private Sub MiddleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleButton.Click
        Me.Flipper2.MarblePath()
    End Sub

    Private Sub RightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightButton.Click
        Me.Flipper3.MarblePath()
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        Flipper1.reset()
        Flipper2.reset()
        Flipper3.reset()
        Flipper4.reset()
        Flipper5.reset()
        Flipper6.reset()
        Flipper7.reset()
        Flipper8.reset()


    End Sub
End Class