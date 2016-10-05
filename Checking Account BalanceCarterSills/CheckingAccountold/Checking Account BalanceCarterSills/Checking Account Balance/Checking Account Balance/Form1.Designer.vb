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
        Me.textBalance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioServiceCharge = New System.Windows.Forms.RadioButton()
        Me.radioCheck = New System.Windows.Forms.RadioButton()
        Me.radioDeposit = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textDeposit = New System.Windows.Forms.TextBox()
        Me.textCheck = New System.Windows.Forms.TextBox()
        Me.textServiceCharge = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBalance
        '
        Me.textBalance.Location = New System.Drawing.Point(238, 39)
        Me.textBalance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textBalance.Name = "textBalance"
        Me.textBalance.ReadOnly = True
        Me.textBalance.Size = New System.Drawing.Size(170, 26)
        Me.textBalance.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Checking Account Balance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioServiceCharge)
        Me.GroupBox1.Controls.Add(Me.radioCheck)
        Me.GroupBox1.Controls.Add(Me.radioDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(499, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 186)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'radioServiceCharge
        '
        Me.radioServiceCharge.AutoSize = True
        Me.radioServiceCharge.Location = New System.Drawing.Point(23, 115)
        Me.radioServiceCharge.Name = "radioServiceCharge"
        Me.radioServiceCharge.Size = New System.Drawing.Size(98, 17)
        Me.radioServiceCharge.TabIndex = 11
        Me.radioServiceCharge.TabStop = True
        Me.radioServiceCharge.Text = "&Service Charge"
        Me.radioServiceCharge.UseVisualStyleBackColor = True
        '
        'radioCheck
        '
        Me.radioCheck.AutoSize = True
        Me.radioCheck.Location = New System.Drawing.Point(23, 74)
        Me.radioCheck.Name = "radioCheck"
        Me.radioCheck.Size = New System.Drawing.Size(56, 17)
        Me.radioCheck.TabIndex = 10
        Me.radioCheck.TabStop = True
        Me.radioCheck.Text = "&Check"
        Me.radioCheck.UseVisualStyleBackColor = True
        '
        'radioDeposit
        '
        Me.radioDeposit.AutoSize = True
        Me.radioDeposit.Location = New System.Drawing.Point(23, 36)
        Me.radioDeposit.Name = "radioDeposit"
        Me.radioDeposit.Size = New System.Drawing.Size(61, 17)
        Me.radioDeposit.TabIndex = 9
        Me.radioDeposit.TabStop = True
        Me.radioDeposit.Text = "&Deposit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radioDeposit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deposit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Check"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Service Charge"
        '
        'textDeposit
        '
        Me.textDeposit.Location = New System.Drawing.Point(238, 137)
        Me.textDeposit.Name = "textDeposit"
        Me.textDeposit.Size = New System.Drawing.Size(170, 26)
        Me.textDeposit.TabIndex = 3
        Me.textDeposit.Text = "0"
        '
        'textCheck
        '
        Me.textCheck.Location = New System.Drawing.Point(238, 184)
        Me.textCheck.Name = "textCheck"
        Me.textCheck.Size = New System.Drawing.Size(170, 26)
        Me.textCheck.TabIndex = 5
        Me.textCheck.Text = "0"
        '
        'textServiceCharge
        '
        Me.textServiceCharge.Location = New System.Drawing.Point(238, 231)
        Me.textServiceCharge.Name = "textServiceCharge"
        Me.textServiceCharge.Size = New System.Drawing.Size(170, 26)
        Me.textServiceCharge.TabIndex = 7
        Me.textServiceCharge.Text = "0"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(120, 348)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(86, 28)
        Me.CalculateButton.TabIndex = 12
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(238, 348)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(86, 28)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(356, 348)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(86, 27)
        Me.PrintButton.TabIndex = 14
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(474, 348)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(86, 28)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 463)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.textServiceCharge)
        Me.Controls.Add(Me.textCheck)
        Me.Controls.Add(Me.textDeposit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBalance)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Checking Account Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioServiceCharge As System.Windows.Forms.RadioButton
    Friend WithEvents radioCheck As System.Windows.Forms.RadioButton
    Friend WithEvents radioDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textDeposit As System.Windows.Forms.TextBox
    Friend WithEvents textCheck As System.Windows.Forms.TextBox
    Friend WithEvents textServiceCharge As System.Windows.Forms.TextBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
