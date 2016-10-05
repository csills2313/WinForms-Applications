Option Strict On
Option Explicit On
Public Class Form1
    Private grid(2, 2) As Panel
    Private p1turn As Boolean
    Private r As New Random

#Region "New/End game"

    Private Sub newgame()
        For i As Integer = pnl_Grid.Controls.Count - 1 To 0 Step -1
            pnl_Grid.Controls.RemoveAt(i)
        Next

        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                Dim pnl As New Panel
                With pnl
                    .BackgroundImage = Nothing
                    .BackgroundImageLayout = ImageLayout.Zoom
                    .BorderStyle = BorderStyle.FixedSingle
                    .Enabled = True
                    .Location = New Point(x * 100, y * 100)
                    .Size = New Size(100, 100)
                    .Tag = ""
                End With

                pnl_Grid.Controls.Add(pnl)
                grid(x, y) = pnl

                AddHandler pnl.Click, AddressOf pnl_Click
            Next
        Next

        p1turn = True
    End Sub

    Private Function checkend() As Boolean

        'Horizontal
        If grid(0, 0).Tag.ToString = "p1" AndAlso grid(1, 0).Tag.ToString = "p1" AndAlso grid(2, 0).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 0).Tag.ToString = "p2" AndAlso grid(1, 0).Tag.ToString = "p2" AndAlso grid(2, 0).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 1).Tag.ToString = "p1" AndAlso grid(1, 1).Tag.ToString = "p1" AndAlso grid(2, 1).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 1).Tag.ToString = "p2" AndAlso grid(1, 1).Tag.ToString = "p2" AndAlso grid(2, 1).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 2).Tag.ToString = "p1" AndAlso grid(1, 2).Tag.ToString = "p1" AndAlso grid(2, 2).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 2).Tag.ToString = "p2" AndAlso grid(1, 2).Tag.ToString = "p2" AndAlso grid(2, 2).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True

            'Horizontal
        ElseIf grid(0, 0).Tag.ToString = "p1" AndAlso grid(0, 1).Tag.ToString = "p1" AndAlso grid(0, 2).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 0).Tag.ToString = "p2" AndAlso grid(0, 1).Tag.ToString = "p2" AndAlso grid(0, 2).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        ElseIf grid(1, 0).Tag.ToString = "p1" AndAlso grid(1, 1).Tag.ToString = "p1" AndAlso grid(1, 2).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(1, 0).Tag.ToString = "p2" AndAlso grid(1, 1).Tag.ToString = "p2" AndAlso grid(1, 2).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        ElseIf grid(2, 0).Tag.ToString = "p1" AndAlso grid(2, 1).Tag.ToString = "p1" AndAlso grid(2, 2).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(2, 0).Tag.ToString = "p2" AndAlso grid(2, 1).Tag.ToString = "p2" AndAlso grid(2, 2).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True

            'Diagonal
        ElseIf grid(0, 0).Tag.ToString = "p1" AndAlso grid(1, 1).Tag.ToString = "p1" AndAlso grid(2, 2).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 0).Tag.ToString = "p2" AndAlso grid(1, 1).Tag.ToString = "p2" AndAlso grid(2, 2).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 2).Tag.ToString = "p1" AndAlso grid(1, 1).Tag.ToString = "p1" AndAlso grid(2, 0).Tag.ToString = "p1" Then
            MessageBox.Show("Player1 wins")
            Call newgame()
            Return True
        ElseIf grid(0, 2).Tag.ToString = "p2" AndAlso grid(1, 1).Tag.ToString = "p2" AndAlso grid(2, 0).Tag.ToString = "p2" Then
            MessageBox.Show("Player2 wins")
            Call newgame()
            Return True
        Else

            Return False
        End If

    End Function

#End Region

#Region "Draw Bitmap and AI"

    Private Function drawpiece() As Bitmap
        drawpiece = New Bitmap(50, 50)
        Dim g As Graphics = Graphics.FromImage(drawpiece)

        'p1 is x
        'cpu is o
        If p1turn Then
            Dim pt1, pt2, pt3, pt4 As Point
            pt1 = New Point(1, 1) 'Upper-Left
            pt2 = New Point(49, 49) 'Lower-Right
            pt3 = New Point(1, 49) 'Lower-Left
            pt4 = New Point(49, 1) 'Upper-Right

            g.DrawLine(Pens.Red, pt1, pt2)
            g.DrawLine(Pens.Red, pt3, pt4)

            g.Save()
        Else
            Dim rect As New Rectangle(1, 1, 48, 48)
            g.DrawEllipse(Pens.Blue, rect)
            g.Save()
        End If

        Return drawpiece
    End Function

    Private Function rndPanel() As Panel
        Dim i As Integer = 0
        Dim templist As New List(Of Panel)

        For Each pnl As Panel In pnl_Grid.Controls.OfType(Of Panel)()
            If pnl.Enabled = True Then
                i += 1
                templist.Add(pnl)
            End If
        Next

        rndPanel = templist.Item(r.Next(0, i))

        Return rndPanel
    End Function

#End Region

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call newgame()
    End Sub

    Private Sub pnl_Click(sender As Object, e As EventArgs)
        Dim pnl As Panel = DirectCast(sender, Panel)
        pnl.BackgroundImage = drawpiece() : pnl.Tag = "p1" : pnl.Enabled = False
        p1turn = False

        If checkend() = True Then
            Exit Sub
        End If

        Dim randpnl As Panel = rndPanel()
        randpnl.BackgroundImage = drawpiece() : randpnl.Tag = "p2" : randpnl.Enabled = False
        p1turn = True

        If checkend() = True Then
            Exit Sub
        End If
    End Sub

End Class