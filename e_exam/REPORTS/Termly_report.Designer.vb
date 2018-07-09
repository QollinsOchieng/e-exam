<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Termly_report
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboetype = New System.Windows.Forms.ComboBox()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Class year"
        '
        'cboyear
        '
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Location = New System.Drawing.Point(401, 32)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(131, 24)
        Me.cboyear.TabIndex = 28
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(551, 69)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(146, 31)
        Me.btnview.TabIndex = 27
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(400, 85)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(121, 24)
        Me.cbostream.TabIndex = 26
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(137, 85)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(131, 24)
        Me.cboclass.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Stream"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Class"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.dgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(49, 157)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(1162, 386)
        Me.dgvReport.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Exam type"
        '
        'cboetype
        '
        Me.cboetype.FormattingEnabled = True
        Me.cboetype.Items.AddRange(New Object() {"Normal", "Full Paper"})
        Me.cboetype.Location = New System.Drawing.Point(147, 32)
        Me.cboetype.Name = "cboetype"
        Me.cboetype.Size = New System.Drawing.Size(121, 24)
        Me.cboetype.TabIndex = 32
        '
        'Termly_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 638)
        Me.Controls.Add(Me.cboetype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Termly_report"
        Me.Text = "Termly_report"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboetype As System.Windows.Forms.ComboBox
End Class
