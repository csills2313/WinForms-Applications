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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCountOfYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboYachtType = New System.Windows.Forms.ComboBox()
        Me.ComboYachtLength = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextResponsibleParty = New System.Windows.Forms.TextBox()
        Me.TextHoursChartered = New System.Windows.Forms.TextBox()
        Me.TextTotalCost = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintSummary = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintYachtTypes = New System.Drawing.Printing.PrintDocument()
        Me.GroupBoxSummary = New System.Windows.Forms.GroupBox()
        Me.TextHourlyRate = New System.Windows.Forms.TextBox()
        Me.TextAmount = New System.Windows.Forms.TextBox()
        Me.TextHours = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintSummaryDocument = New System.Drawing.Printing.PrintDocument()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "&Print Summary"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print &Yacht Types"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextCharterToolStripMenuItem, Me.ToolStripSeparator2, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(52, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearForNextCharterToolStripMenuItem
        '
        Me.ClearForNextCharterToolStripMenuItem.Name = "ClearForNextCharterToolStripMenuItem"
        Me.ClearForNextCharterToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.ClearForNextCharterToolStripMenuItem.Text = "&Clear for Next Charter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(313, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.AddYachtTypeToolStripMenuItem.Text = "&Add Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        '
        'DisplayCountOfYachtTypesToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Name = "DisplayCountOfYachtTypesToolStripMenuItem"
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Text = "&Display Count of Yacht Types"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ComboYachtType
        '
        Me.ComboYachtType.FormattingEnabled = True
        Me.ComboYachtType.Items.AddRange(New Object() {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"})
        Me.ComboYachtType.Location = New System.Drawing.Point(153, 87)
        Me.ComboYachtType.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboYachtType.Name = "ComboYachtType"
        Me.ComboYachtType.Size = New System.Drawing.Size(199, 26)
        Me.ComboYachtType.Sorted = True
        Me.ComboYachtType.TabIndex = 1
        '
        'ComboYachtLength
        '
        Me.ComboYachtLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboYachtLength.FormattingEnabled = True
        Me.ComboYachtLength.Items.AddRange(New Object() {"0", "22", "24", "30", "32", "36", "38", "45"})
        Me.ComboYachtLength.Location = New System.Drawing.Point(153, 188)
        Me.ComboYachtLength.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboYachtLength.Name = "ComboYachtLength"
        Me.ComboYachtLength.Size = New System.Drawing.Size(199, 26)
        Me.ComboYachtLength.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Yacht Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Yacht Length"
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Location = New System.Drawing.Point(100, 468)
        Me.ButtonAccept.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(125, 32)
        Me.ButtonAccept.TabIndex = 5
        Me.ButtonAccept.Text = "&Accept"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(256, 468)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(125, 32)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextResponsibleParty
        '
        Me.TextResponsibleParty.Location = New System.Drawing.Point(742, 75)
        Me.TextResponsibleParty.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextResponsibleParty.Name = "TextResponsibleParty"
        Me.TextResponsibleParty.Size = New System.Drawing.Size(194, 26)
        Me.TextResponsibleParty.TabIndex = 7
        '
        'TextHoursChartered
        '
        Me.TextHoursChartered.Location = New System.Drawing.Point(742, 137)
        Me.TextHoursChartered.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextHoursChartered.Name = "TextHoursChartered"
        Me.TextHoursChartered.Size = New System.Drawing.Size(194, 26)
        Me.TextHoursChartered.TabIndex = 8
        Me.TextHoursChartered.Text = "0"
        '
        'TextTotalCost
        '
        Me.TextTotalCost.Location = New System.Drawing.Point(742, 203)
        Me.TextTotalCost.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextTotalCost.Name = "TextTotalCost"
        Me.TextTotalCost.ReadOnly = True
        Me.TextTotalCost.Size = New System.Drawing.Size(194, 26)
        Me.TextTotalCost.TabIndex = 9
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(416, 468)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(125, 32)
        Me.ButtonExit.TabIndex = 10
        Me.ButtonExit.Text = "E&xit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(558, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Responsible Party"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(558, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hours Chartered"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Cost"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintYachtTypes
        '
        '
        'GroupBoxSummary
        '
        Me.GroupBoxSummary.Controls.Add(Me.Label9)
        Me.GroupBoxSummary.Controls.Add(Me.TextHourlyRate)
        Me.GroupBoxSummary.Controls.Add(Me.TextAmount)
        Me.GroupBoxSummary.Controls.Add(Me.TextHours)
        Me.GroupBoxSummary.Controls.Add(Me.Label8)
        Me.GroupBoxSummary.Controls.Add(Me.Label7)
        Me.GroupBoxSummary.Controls.Add(Me.TextName)
        Me.GroupBoxSummary.Controls.Add(Me.Label6)
        Me.GroupBoxSummary.Location = New System.Drawing.Point(584, 292)
        Me.GroupBoxSummary.Name = "GroupBoxSummary"
        Me.GroupBoxSummary.Size = New System.Drawing.Size(417, 266)
        Me.GroupBoxSummary.TabIndex = 14
        Me.GroupBoxSummary.TabStop = False
        Me.GroupBoxSummary.Text = "Summary"
        Me.GroupBoxSummary.Visible = False
        '
        'TextHourlyRate
        '
        Me.TextHourlyRate.Location = New System.Drawing.Point(182, 153)
        Me.TextHourlyRate.Name = "TextHourlyRate"
        Me.TextHourlyRate.ReadOnly = True
        Me.TextHourlyRate.Size = New System.Drawing.Size(190, 26)
        Me.TextHourlyRate.TabIndex = 6
        '
        'TextAmount
        '
        Me.TextAmount.Location = New System.Drawing.Point(182, 207)
        Me.TextAmount.Name = "TextAmount"
        Me.TextAmount.ReadOnly = True
        Me.TextAmount.Size = New System.Drawing.Size(190, 26)
        Me.TextAmount.TabIndex = 5
        '
        'TextHours
        '
        Me.TextHours.Location = New System.Drawing.Point(182, 102)
        Me.TextHours.Name = "TextHours"
        Me.TextHours.ReadOnly = True
        Me.TextHours.Size = New System.Drawing.Size(190, 26)
        Me.TextHours.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Hours"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Amount"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(182, 49)
        Me.TextName.Name = "TextName"
        Me.TextName.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(190, 26)
        Me.TextName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Party Billed"
        '
        'PrintSummaryDocument
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Hourly Rate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 595)
        Me.Controls.Add(Me.GroupBoxSummary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.TextTotalCost)
        Me.Controls.Add(Me.TextHoursChartered)
        Me.Controls.Add(Me.TextResponsibleParty)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboYachtLength)
        Me.Controls.Add(Me.ComboYachtType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Chartering Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxSummary.ResumeLayout(False)
        Me.GroupBoxSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearForNextCharterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboYachtType As System.Windows.Forms.ComboBox
    Friend WithEvents ComboYachtLength As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonAccept As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextResponsibleParty As System.Windows.Forms.TextBox
    Friend WithEvents TextHoursChartered As System.Windows.Forms.TextBox
    Friend WithEvents TextTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintSummary As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintYachtTypes As System.Drawing.Printing.PrintDocument
    Friend WithEvents GroupBoxSummary As System.Windows.Forms.GroupBox
    Friend WithEvents TextAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextHours As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintSummaryDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents TextHourlyRate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
