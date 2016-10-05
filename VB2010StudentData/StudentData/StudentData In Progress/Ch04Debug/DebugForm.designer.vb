Partial Public Class DebugForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.WhiteRadioButton = New System.Windows.Forms.RadioButton
        Me.RedRadioButton = New System.Windows.Forms.RadioButton
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.WhitePercentTextBox = New System.Windows.Forms.TextBox
        Me.RedPercentTextBox = New System.Windows.Forms.TextBox
        Me.BluePercentTextBox = New System.Windows.Forms.TextBox
        Me.WhiteTotalTextBox = New System.Windows.Forms.TextBox
        Me.RedTotalTextBox = New System.Windows.Forms.TextBox
        Me.BlueTotalTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CalculateButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WhiteRadioButton)
        Me.GroupBox1.Controls.Add(Me.RedRadioButton)
        Me.GroupBox1.Controls.Add(Me.BlueRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Color"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(142, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Quantity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(227, 31)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(31, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'WhiteRadioButton
        '
        Me.WhiteRadioButton.Location = New System.Drawing.Point(11, 69)
        Me.WhiteRadioButton.Name = "WhiteRadioButton"
        Me.WhiteRadioButton.Size = New System.Drawing.Size(83, 24)
        Me.WhiteRadioButton.TabIndex = 2
        Me.WhiteRadioButton.Text = "&White"
        '
        'RedRadioButton
        '
        Me.RedRadioButton.Location = New System.Drawing.Point(11, 44)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(67, 24)
        Me.RedRadioButton.TabIndex = 1
        Me.RedRadioButton.Text = "&Red"
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.Checked = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(11, 19)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(83, 23)
        Me.BlueRadioButton.TabIndex = 0
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "&Blue"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WhitePercentTextBox)
        Me.GroupBox2.Controls.Add(Me.RedPercentTextBox)
        Me.GroupBox2.Controls.Add(Me.BluePercentTextBox)
        Me.GroupBox2.Controls.Add(Me.WhiteTotalTextBox)
        Me.GroupBox2.Controls.Add(Me.RedTotalTextBox)
        Me.GroupBox2.Controls.Add(Me.BlueTotalTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 104)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'WhitePercentTextBox
        '
        Me.WhitePercentTextBox.Location = New System.Drawing.Point(314, 64)
        Me.WhitePercentTextBox.Name = "WhitePercentTextBox"
        Me.WhitePercentTextBox.ReadOnly = True
        Me.WhitePercentTextBox.Size = New System.Drawing.Size(86, 20)
        Me.WhitePercentTextBox.TabIndex = 11
        Me.WhitePercentTextBox.TabStop = False
        '
        'RedPercentTextBox
        '
        Me.RedPercentTextBox.Location = New System.Drawing.Point(314, 40)
        Me.RedPercentTextBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RedPercentTextBox.Name = "RedPercentTextBox"
        Me.RedPercentTextBox.ReadOnly = True
        Me.RedPercentTextBox.Size = New System.Drawing.Size(86, 20)
        Me.RedPercentTextBox.TabIndex = 9
        Me.RedPercentTextBox.TabStop = False
        '
        'BluePercentTextBox
        '
        Me.BluePercentTextBox.Location = New System.Drawing.Point(314, 16)
        Me.BluePercentTextBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.BluePercentTextBox.Name = "BluePercentTextBox"
        Me.BluePercentTextBox.ReadOnly = True
        Me.BluePercentTextBox.Size = New System.Drawing.Size(86, 20)
        Me.BluePercentTextBox.TabIndex = 7
        Me.BluePercentTextBox.TabStop = False
        '
        'WhiteTotalTextBox
        '
        Me.WhiteTotalTextBox.Location = New System.Drawing.Point(101, 64)
        Me.WhiteTotalTextBox.Name = "WhiteTotalTextBox"
        Me.WhiteTotalTextBox.ReadOnly = True
        Me.WhiteTotalTextBox.Size = New System.Drawing.Size(70, 20)
        Me.WhiteTotalTextBox.TabIndex = 5
        Me.WhiteTotalTextBox.TabStop = False
        '
        'RedTotalTextBox
        '
        Me.RedTotalTextBox.Location = New System.Drawing.Point(101, 40)
        Me.RedTotalTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.RedTotalTextBox.Name = "RedTotalTextBox"
        Me.RedTotalTextBox.ReadOnly = True
        Me.RedTotalTextBox.Size = New System.Drawing.Size(70, 20)
        Me.RedTotalTextBox.TabIndex = 3
        Me.RedTotalTextBox.TabStop = False
        '
        'BlueTotalTextBox
        '
        Me.BlueTotalTextBox.Location = New System.Drawing.Point(101, 16)
        Me.BlueTotalTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.BlueTotalTextBox.Name = "BlueTotalTextBox"
        Me.BlueTotalTextBox.ReadOnly = True
        Me.BlueTotalTextBox.Size = New System.Drawing.Size(70, 20)
        Me.BlueTotalTextBox.TabIndex = 1
        Me.BlueTotalTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(187, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Percent White"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(187, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Percent Red"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(187, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Percent Blue"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total White"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Red"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Blue"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(377, 50)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(64, 30)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(377, 92)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(64, 26)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        '
        'DebugForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 257)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DebugForm"
        Me.Text = "Visual Basic Debugging Exercise"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhiteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents WhitePercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RedPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BluePercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhiteTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RedTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BlueTotalTextBox As System.Windows.Forms.TextBox

End Class
