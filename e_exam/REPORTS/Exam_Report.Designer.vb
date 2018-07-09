<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam_Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvexams = New System.Windows.Forms.DataGridView()
        Me.chkclass = New System.Windows.Forms.CheckBox()
        Me.chkstream = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.dgvres = New System.Windows.Forms.DataGridView()
        Me.btnview = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclass = New System.Windows.Forms.TextBox()
        Me.txtstream = New System.Windows.Forms.TextBox()
        Me.txtename = New System.Windows.Forms.TextBox()
        Me.btnavg = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtetype = New System.Windows.Forms.TextBox()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txteid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvexams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvexams
        '
        Me.dgvexams.AllowUserToAddRows = False
        Me.dgvexams.AllowUserToDeleteRows = False
        Me.dgvexams.AllowUserToOrderColumns = True
        Me.dgvexams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexams.Location = New System.Drawing.Point(40, 81)
        Me.dgvexams.Name = "dgvexams"
        Me.dgvexams.ReadOnly = True
        Me.dgvexams.RowTemplate.Height = 24
        Me.dgvexams.Size = New System.Drawing.Size(458, 150)
        Me.dgvexams.TabIndex = 0
        '
        'chkclass
        '
        Me.chkclass.AutoSize = True
        Me.chkclass.Location = New System.Drawing.Point(558, 41)
        Me.chkclass.Name = "chkclass"
        Me.chkclass.Size = New System.Drawing.Size(106, 21)
        Me.chkclass.TabIndex = 1
        Me.chkclass.Text = "Class report"
        Me.chkclass.UseVisualStyleBackColor = True
        '
        'chkstream
        '
        Me.chkstream.AutoSize = True
        Me.chkstream.Location = New System.Drawing.Point(717, 40)
        Me.chkstream.Name = "chkstream"
        Me.chkstream.Size = New System.Drawing.Size(122, 21)
        Me.chkstream.TabIndex = 2
        Me.chkstream.Text = "Stream Report"
        Me.chkstream.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(558, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(820, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stream"
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(628, 102)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(131, 24)
        Me.cboclass.TabIndex = 5
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(887, 98)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(121, 24)
        Me.cbostream.TabIndex = 6
        '
        'dgvres
        '
        Me.dgvres.AllowUserToAddRows = False
        Me.dgvres.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvres.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvres.Location = New System.Drawing.Point(40, 323)
        Me.dgvres.Name = "dgvres"
        Me.dgvres.ReadOnly = True
        Me.dgvres.RowTemplate.Height = 24
        Me.dgvres.Size = New System.Drawing.Size(1338, 353)
        Me.dgvres.TabIndex = 7
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(862, 142)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(146, 31)
        Me.btnview.TabIndex = 8
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1195, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Summary"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(1290, 266)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(88, 30)
        Me.btnFull.TabIndex = 10
        Me.btnFull.Text = "Full"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 682)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 689)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 686)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Stream"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(658, 686)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ExamName"
        '
        'txtclass
        '
        Me.txtclass.Enabled = False
        Me.txtclass.Location = New System.Drawing.Point(95, 686)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Size = New System.Drawing.Size(113, 22)
        Me.txtclass.TabIndex = 15
        '
        'txtstream
        '
        Me.txtstream.Enabled = False
        Me.txtstream.Location = New System.Drawing.Point(479, 686)
        Me.txtstream.Name = "txtstream"
        Me.txtstream.Size = New System.Drawing.Size(143, 22)
        Me.txtstream.TabIndex = 17
        '
        'txtename
        '
        Me.txtename.Enabled = False
        Me.txtename.Location = New System.Drawing.Point(744, 686)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(129, 22)
        Me.txtename.TabIndex = 18
        '
        'btnavg
        '
        Me.btnavg.Enabled = False
        Me.btnavg.Location = New System.Drawing.Point(1208, 685)
        Me.btnavg.Name = "btnavg"
        Me.btnavg.Size = New System.Drawing.Size(170, 41)
        Me.btnavg.TabIndex = 19
        Me.btnavg.Text = "Calculate Average"
        Me.btnavg.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Default (summerized)"
        '
        'cboyear
        '
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Location = New System.Drawing.Point(628, 149)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(131, 24)
        Me.cboyear.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(539, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Class year"
        '
        'txtyear
        '
        Me.txtyear.Enabled = False
        Me.txtyear.Location = New System.Drawing.Point(288, 686)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(113, 22)
        Me.txtyear.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(281, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "exam type"
        '
        'txtetype
        '
        Me.txtetype.Enabled = False
        Me.txtetype.Location = New System.Drawing.Point(359, 280)
        Me.txtetype.Name = "txtetype"
        Me.txtetype.Size = New System.Drawing.Size(140, 22)
        Me.txtetype.TabIndex = 25
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(204, 46)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(186, 22)
        Me.txtc.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Exam Code"
        '
        'txteid
        '
        Me.txteid.Enabled = False
        Me.txteid.Location = New System.Drawing.Point(71, 248)
        Me.txteid.Name = "txteid"
        Me.txteid.Size = New System.Drawing.Size(140, 22)
        Me.txteid.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "eid"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(992, 684)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 42)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Exam_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1405, 753)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txteid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.txtetype)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnavg)
        Me.Controls.Add(Me.txtename)
        Me.Controls.Add(Me.txtstream)
        Me.Controls.Add(Me.txtclass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFull)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.dgvres)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkstream)
        Me.Controls.Add(Me.chkclass)
        Me.Controls.Add(Me.dgvexams)
        Me.Name = "Exam_Report"
        Me.Text = "Exam_Report"
        CType(Me.dgvexams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvexams As System.Windows.Forms.DataGridView
    Friend WithEvents chkclass As System.Windows.Forms.CheckBox
    Friend WithEvents chkstream As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents dgvres As System.Windows.Forms.DataGridView
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnFull As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtclass As System.Windows.Forms.TextBox
    Friend WithEvents txtstream As System.Windows.Forms.TextBox
    Friend WithEvents txtename As System.Windows.Forms.TextBox
    Friend WithEvents btnavg As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtetype As System.Windows.Forms.TextBox
    Friend WithEvents txtc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txteid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
