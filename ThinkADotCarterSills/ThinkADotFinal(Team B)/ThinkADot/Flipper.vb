Option Strict On
Option Explicit On
Public Class Flipper
    Private droppedLeftBoolean As Boolean = False
    Private directionLeft As Flipper = Nothing   'Values that are passed to the Public Properties flipleft() and flipright()
    Private directionRight As Flipper = Nothing

    ReadOnly Property droppedLeft() As Boolean      ' example: If Flipper1.droppedLeft then...
        Get
            Return droppedLeftBoolean   'do flip before reading
        End Get
    End Property
    Public Property flipLeft() As Flipper 'Property is used to initialize each flipper object when form load event occurs. Sets the values for directionLeft and directionRight
        Get
            Return directionLeft
        End Get
        Set(ByVal value As Flipper)
            directionLeft = value
        End Set
    End Property

    Public Property flipRight() As Flipper  'Property is used to initialize each flipper object when form load event occurs
        Get
            Return directionRight
        End Get
        Set(ByVal value As Flipper)
            directionRight = value
        End Set
    End Property
    Public Sub flip()                               ' example: Flipper1.flip() This is the method used to change the color of the flippers. 
        droppedLeftBoolean = Not droppedLeftBoolean
        Dot.ImageIndex = 1 - Dot.ImageIndex 'alternate dot color
    End Sub

    Public Sub reset()                              ' example: Flipper1.reset()
        Dot.ImageIndex = 0              'reset image to yellow dot
        droppedLeftBoolean = False      'default direction
    End Sub
    Public Sub MarblePath()
        ' Recursive Method used to flip flipper objects.  Method is called by the right, middle, and left buttons on Form1.
        Me.flip()

        If droppedLeftBoolean And Not IsNothing(Me.flipLeft) Then

            Me.flipLeft.MarblePath()

        ElseIf Not IsNothing(Me.flipRight) Then

            Me.flipRight.MarblePath()

        End If

        ' This section increments the counters for the right and left textboxes so as to keep count for each marble that is dropped. 
        If Me.Name = "FlipperExitLeft" Then
            Form1.LeftTextBox.Text = (Integer.Parse(Form1.LeftTextBox.Text) + 1).ToString

        ElseIf Me.Name = "FlipperExitRight" Then


            Form1.RightTextBox.Text = (Integer.Parse(Form1.RightTextBox.Text) + 1).ToString

        End If

        
    End Sub

End Class
