Public Class Flipper
    Private droppedLeftBoolean As Boolean = False
    Private directionLeft, directionRight As Flipper

    ReadOnly Property droppedLeft() As Boolean      ' example: If Flipper1.droppedLeft then...
        Get
            Return droppedLeftBoolean   'do flip before reading
        End Get
    End Property

    Public Property flipLeft() As Flipper
        Get
            Return directionLeft
        End Get
        Set(ByVal value As Flipper)
            directionLeft = value
        End Set
    End Property

    Public Property flipRight() As Flipper
        Get
            Return directionRight
        End Get
        Set(ByVal value As Flipper)
            directionRight = value
        End Set
    End Property

    Public Sub flip()                               ' example: Flipper1.flip()
        droppedLeftBoolean = Not droppedLeftBoolean
        Dot.ImageIndex = 1 - Dot.ImageIndex 'alternate dot color
    End Sub

    Public Sub reset()                              ' example: Flipper1.reset()
        Dot.ImageIndex = 0              'reset image to yellow dot
        droppedLeftBoolean = False      'default direction
    End Sub

    Public Sub MarblePath()
        Me.flip()
        If droppedLeftBoolean And Not IsNothing(Me.flipLeft) Then
            Me.flipLeft.MarblePath()
        ElseIf Not IsNothing(Me.flipRight) Then
            Me.flipRight.MarblePath()
        End If
    End Sub
End Class
