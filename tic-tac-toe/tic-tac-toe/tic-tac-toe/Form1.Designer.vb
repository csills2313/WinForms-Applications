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
        Me.pnl_Grid = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnl_Grid
        '
        Me.pnl_Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Grid.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Grid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_Grid.Name = "pnl_Grid"
        Me.pnl_Grid.Size = New System.Drawing.Size(226, 249)
        Me.pnl_Grid.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 249)
        Me.Controls.Add(Me.pnl_Grid)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(242, 287)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_Grid As System.Windows.Forms.Panel

End Class
