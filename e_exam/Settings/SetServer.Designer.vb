<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetServer
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
        Me.txtservername = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OK_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtservername
        '
        Me.txtservername.Location = New System.Drawing.Point(91, 70)
        Me.txtservername.Name = "txtservername"
        Me.txtservername.Size = New System.Drawing.Size(192, 22)
        Me.txtservername.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OK_button
        '
        Me.OK_button.Location = New System.Drawing.Point(315, 120)
        Me.OK_button.Name = "OK_button"
        Me.OK_button.Size = New System.Drawing.Size(113, 44)
        Me.OK_button.TabIndex = 2
        Me.OK_button.Text = "Save"
        Me.OK_button.UseVisualStyleBackColor = True
        '
        'SetServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 336)
        Me.Controls.Add(Me.OK_button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtservername)
        Me.Name = "SetServer"
        Me.Text = "SetServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtservername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OK_button As System.Windows.Forms.Button
End Class
