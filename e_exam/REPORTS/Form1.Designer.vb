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
        Me.NormReportView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'NormReportView
        '
        Me.NormReportView.ActiveViewIndex = -1
        Me.NormReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NormReportView.Cursor = System.Windows.Forms.Cursors.Default
        Me.NormReportView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NormReportView.Location = New System.Drawing.Point(0, 0)
        Me.NormReportView.Name = "NormReportView"
        Me.NormReportView.Size = New System.Drawing.Size(965, 512)
        Me.NormReportView.TabIndex = 0
        Me.NormReportView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 512)
        Me.Controls.Add(Me.NormReportView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NormReportView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
