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
        Me.Flipper1 = New ThinkADot.Flipper()
        Me.SuspendLayout()
        '
        'Flipper1
        '
        Me.Flipper1.Location = New System.Drawing.Point(151, 98)
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
        Me.Controls.Add(Me.Flipper1)
        Me.Name = "Form1"
        Me.Text = "ThinkADot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Flipper1 As ThinkADot.Flipper
End Class
