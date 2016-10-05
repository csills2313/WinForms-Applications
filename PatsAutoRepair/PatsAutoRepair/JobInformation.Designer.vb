<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobInformation
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
        Me.buttonCalculate = New System.Windows.Forms.Button()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextJobNo = New System.Windows.Forms.TextBox()
        Me.TextCustomerName = New System.Windows.Forms.TextBox()
        Me.TextCostofParts = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextLaborHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextParts = New System.Windows.Forms.TextBox()
        Me.TextLabor = New System.Windows.Forms.TextBox()
        Me.TextSubtotal = New System.Windows.Forms.TextBox()
        Me.TextSalesTax = New System.Windows.Forms.TextBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextFullName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonCalculate
        '
        Me.buttonCalculate.Location = New System.Drawing.Point(27, 411)
        Me.buttonCalculate.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.buttonCalculate.Name = "buttonCalculate"
        Me.buttonCalculate.Size = New System.Drawing.Size(162, 49)
        Me.buttonCalculate.TabIndex = 0
        Me.buttonCalculate.Text = "Calculate"
        Me.buttonCalculate.UseVisualStyleBackColor = True
        '
        'buttonClear
        '
        Me.buttonClear.Location = New System.Drawing.Point(225, 411)
        Me.buttonClear.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(162, 49)
        Me.buttonClear.TabIndex = 1
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(424, 411)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(162, 49)
        Me.ButtonOk.TabIndex = 2
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Job No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cost of Parts"
        '
        'TextJobNo
        '
        Me.TextJobNo.Location = New System.Drawing.Point(189, 60)
        Me.TextJobNo.Name = "TextJobNo"
        Me.TextJobNo.Size = New System.Drawing.Size(220, 34)
        Me.TextJobNo.TabIndex = 6
        '
        'TextCustomerName
        '
        Me.TextCustomerName.Location = New System.Drawing.Point(189, 111)
        Me.TextCustomerName.Name = "TextCustomerName"
        Me.TextCustomerName.Size = New System.Drawing.Size(220, 34)
        Me.TextCustomerName.TabIndex = 7
        '
        'TextCostofParts
        '
        Me.TextCostofParts.Location = New System.Drawing.Point(189, 169)
        Me.TextCostofParts.Name = "TextCostofParts"
        Me.TextCostofParts.Size = New System.Drawing.Size(220, 34)
        Me.TextCostofParts.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Labor Hours"
        '
        'TextLaborHours
        '
        Me.TextLaborHours.Location = New System.Drawing.Point(189, 223)
        Me.TextLaborHours.Name = "TextLaborHours"
        Me.TextLaborHours.Size = New System.Drawing.Size(220, 34)
        Me.TextLaborHours.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Summary of Charges For:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Parts"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(508, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Labor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(508, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(508, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Sales Tax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(508, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Total "
        '
        'TextParts
        '
        Me.TextParts.Location = New System.Drawing.Point(626, 90)
        Me.TextParts.Name = "TextParts"
        Me.TextParts.ReadOnly = True
        Me.TextParts.Size = New System.Drawing.Size(160, 34)
        Me.TextParts.TabIndex = 17
        '
        'TextLabor
        '
        Me.TextLabor.Location = New System.Drawing.Point(626, 143)
        Me.TextLabor.Name = "TextLabor"
        Me.TextLabor.ReadOnly = True
        Me.TextLabor.Size = New System.Drawing.Size(160, 34)
        Me.TextLabor.TabIndex = 18
        '
        'TextSubtotal
        '
        Me.TextSubtotal.Location = New System.Drawing.Point(626, 196)
        Me.TextSubtotal.Name = "TextSubtotal"
        Me.TextSubtotal.ReadOnly = True
        Me.TextSubtotal.Size = New System.Drawing.Size(160, 34)
        Me.TextSubtotal.TabIndex = 19
        '
        'TextSalesTax
        '
        Me.TextSalesTax.Location = New System.Drawing.Point(626, 249)
        Me.TextSalesTax.Name = "TextSalesTax"
        Me.TextSalesTax.ReadOnly = True
        Me.TextSalesTax.Size = New System.Drawing.Size(160, 34)
        Me.TextSalesTax.TabIndex = 20
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(626, 302)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.ReadOnly = True
        Me.TextTotal.Size = New System.Drawing.Size(160, 34)
        Me.TextTotal.TabIndex = 21
        '
        'TextFullName
        '
        Me.TextFullName.Location = New System.Drawing.Point(626, 19)
        Me.TextFullName.Name = "TextFullName"
        Me.TextFullName.ReadOnly = True
        Me.TextFullName.Size = New System.Drawing.Size(260, 34)
        Me.TextFullName.TabIndex = 22
        '
        'JobInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 549)
        Me.Controls.Add(Me.TextFullName)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.TextSalesTax)
        Me.Controls.Add(Me.TextSubtotal)
        Me.Controls.Add(Me.TextLabor)
        Me.Controls.Add(Me.TextParts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextLaborHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextCostofParts)
        Me.Controls.Add(Me.TextCustomerName)
        Me.Controls.Add(Me.TextJobNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.buttonCalculate)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "JobInformation"
        Me.Text = "Job Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonCalculate As System.Windows.Forms.Button
    Friend WithEvents buttonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextJobNo As System.Windows.Forms.TextBox
    Friend WithEvents TextCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TextCostofParts As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextLaborHours As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextParts As System.Windows.Forms.TextBox
    Friend WithEvents TextLabor As System.Windows.Forms.TextBox
    Friend WithEvents TextSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents TextSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextFullName As System.Windows.Forms.TextBox
End Class
