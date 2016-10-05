<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MiddleButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.LeftTextBox = New System.Windows.Forms.TextBox()
        Me.RightTextBox = New System.Windows.Forms.TextBox()
        Me.FlipperExitRight = New ThinkADot.Flipper()
        Me.FlipperExitLeft = New ThinkADot.Flipper()
        Me.Flipper8 = New ThinkADot.Flipper()
        Me.Flipper7 = New ThinkADot.Flipper()
        Me.Flipper6 = New ThinkADot.Flipper()
        Me.Flipper5 = New ThinkADot.Flipper()
        Me.Flipper4 = New ThinkADot.Flipper()
        Me.Flipper3 = New ThinkADot.Flipper()
        Me.Flipper2 = New ThinkADot.Flipper()
        Me.Flipper1 = New ThinkADot.Flipper()
        Me.SuspendLayout()
        '
        'LeftButton
        '
        Me.LeftButton.Location = New System.Drawing.Point(119, 35)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(68, 23)
        Me.LeftButton.TabIndex = 8
        Me.LeftButton.Text = "Left"
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'MiddleButton
        '
        Me.MiddleButton.Location = New System.Drawing.Point(223, 35)
        Me.MiddleButton.Name = "MiddleButton"
        Me.MiddleButton.Size = New System.Drawing.Size(75, 23)
        Me.MiddleButton.TabIndex = 9
        Me.MiddleButton.Text = "Middle"
        Me.MiddleButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Location = New System.Drawing.Point(333, 35)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(75, 23)
        Me.RightButton.TabIndex = 10
        Me.RightButton.Text = "Right"
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(232, 351)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 11
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'LeftTextBox
        '
        Me.LeftTextBox.Location = New System.Drawing.Point(142, 351)
        Me.LeftTextBox.Name = "LeftTextBox"
        Me.LeftTextBox.ReadOnly = True
        Me.LeftTextBox.Size = New System.Drawing.Size(45, 20)
        Me.LeftTextBox.TabIndex = 14
        Me.LeftTextBox.Text = "0"
        '
        'RightTextBox
        '
        Me.RightTextBox.Location = New System.Drawing.Point(358, 351)
        Me.RightTextBox.Name = "RightTextBox"
        Me.RightTextBox.ReadOnly = True
        Me.RightTextBox.Size = New System.Drawing.Size(50, 20)
        Me.RightTextBox.TabIndex = 15
        Me.RightTextBox.Text = "0"
        '
        'FlipperExitRight
        '
        Me.FlipperExitRight.flipLeft = Nothing
        Me.FlipperExitRight.flipRight = Nothing
        Me.FlipperExitRight.Location = New System.Drawing.Point(447, 365)
        Me.FlipperExitRight.Name = "FlipperExitRight"
        Me.FlipperExitRight.Size = New System.Drawing.Size(34, 34)
        Me.FlipperExitRight.TabIndex = 13
        Me.FlipperExitRight.Visible = False
        '
        'FlipperExitLeft
        '
        Me.FlipperExitLeft.flipLeft = Nothing
        Me.FlipperExitLeft.flipRight = Nothing
        Me.FlipperExitLeft.Location = New System.Drawing.Point(65, 365)
        Me.FlipperExitLeft.Name = "FlipperExitLeft"
        Me.FlipperExitLeft.Size = New System.Drawing.Size(34, 34)
        Me.FlipperExitLeft.TabIndex = 12
        Me.FlipperExitLeft.Visible = False
        '
        'Flipper8
        '
        Me.Flipper8.flipLeft = Nothing
        Me.Flipper8.flipRight = Nothing
        Me.Flipper8.Location = New System.Drawing.Point(374, 279)
        Me.Flipper8.Name = "Flipper8"
        Me.Flipper8.Size = New System.Drawing.Size(34, 34)
        Me.Flipper8.TabIndex = 7
        '
        'Flipper7
        '
        Me.Flipper7.flipLeft = Nothing
        Me.Flipper7.flipRight = Nothing
        Me.Flipper7.Location = New System.Drawing.Point(251, 279)
        Me.Flipper7.Name = "Flipper7"
        Me.Flipper7.Size = New System.Drawing.Size(34, 34)
        Me.Flipper7.TabIndex = 6
        '
        'Flipper6
        '
        Me.Flipper6.flipLeft = Me.FlipperExitLeft
        Me.Flipper6.flipRight = Me.FlipperExitRight
        Me.Flipper6.Location = New System.Drawing.Point(119, 279)
        Me.Flipper6.Name = "Flipper6"
        Me.Flipper6.Size = New System.Drawing.Size(34, 34)
        Me.Flipper6.TabIndex = 5
        '
        'Flipper5
        '
        Me.Flipper5.flipLeft = Nothing
        Me.Flipper5.flipRight = Nothing
        Me.Flipper5.Location = New System.Drawing.Point(310, 176)
        Me.Flipper5.Name = "Flipper5"
        Me.Flipper5.Size = New System.Drawing.Size(34, 34)
        Me.Flipper5.TabIndex = 4
        '
        'Flipper4
        '
        Me.Flipper4.flipLeft = Me.Flipper6
        Me.Flipper4.flipRight = Me.Flipper7
        Me.Flipper4.Location = New System.Drawing.Point(178, 176)
        Me.Flipper4.Name = "Flipper4"
        Me.Flipper4.Size = New System.Drawing.Size(34, 34)
        Me.Flipper4.TabIndex = 3
        '
        'Flipper3
        '
        Me.Flipper3.flipLeft = Nothing
        Me.Flipper3.flipRight = Nothing
        Me.Flipper3.Location = New System.Drawing.Point(374, 84)
        Me.Flipper3.Name = "Flipper3"
        Me.Flipper3.Size = New System.Drawing.Size(34, 34)
        Me.Flipper3.TabIndex = 2
        '
        'Flipper2
        '
        Me.Flipper2.flipLeft = Nothing
        Me.Flipper2.flipRight = Nothing
        Me.Flipper2.Location = New System.Drawing.Point(251, 84)
        Me.Flipper2.Name = "Flipper2"
        Me.Flipper2.Size = New System.Drawing.Size(34, 34)
        Me.Flipper2.TabIndex = 1
        '
        'Flipper1
        '
        Me.Flipper1.flipLeft = Me.Flipper6
        Me.Flipper1.flipRight = Me.Flipper4
        Me.Flipper1.Location = New System.Drawing.Point(119, 84)
        Me.Flipper1.Name = "Flipper1"
        Me.Flipper1.Size = New System.Drawing.Size(34, 34)
        Me.Flipper1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 442)
        Me.Controls.Add(Me.RightTextBox)
        Me.Controls.Add(Me.LeftTextBox)
        Me.Controls.Add(Me.FlipperExitRight)
        Me.Controls.Add(Me.FlipperExitLeft)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.RightButton)
        Me.Controls.Add(Me.MiddleButton)
        Me.Controls.Add(Me.LeftButton)
        Me.Controls.Add(Me.Flipper8)
        Me.Controls.Add(Me.Flipper7)
        Me.Controls.Add(Me.Flipper6)
        Me.Controls.Add(Me.Flipper5)
        Me.Controls.Add(Me.Flipper4)
        Me.Controls.Add(Me.Flipper3)
        Me.Controls.Add(Me.Flipper2)
        Me.Controls.Add(Me.Flipper1)
        Me.Name = "Form1"
        Me.Text = "ThinkADot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Flipper1 As ThinkADot.Flipper
    Friend WithEvents Flipper2 As ThinkADot.Flipper
    Friend WithEvents Flipper3 As ThinkADot.Flipper
    Friend WithEvents Flipper4 As ThinkADot.Flipper
    Friend WithEvents Flipper5 As ThinkADot.Flipper
    Friend WithEvents Flipper6 As ThinkADot.Flipper
    Friend WithEvents Flipper7 As ThinkADot.Flipper
    Friend WithEvents Flipper8 As ThinkADot.Flipper
    Friend WithEvents LeftButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MiddleButton As System.Windows.Forms.Button
    Friend WithEvents RightButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents FlipperExitLeft As ThinkADot.Flipper
    Friend WithEvents FlipperExitRight As ThinkADot.Flipper
    Friend WithEvents LeftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RightTextBox As System.Windows.Forms.TextBox
End Class
