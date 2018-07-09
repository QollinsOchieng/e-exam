<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Exam
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboetype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbowk = New System.Windows.Forms.ComboBox()
        Me.cboterm = New System.Windows.Forms.ComboBox()
        Me.txtexamname = New System.Windows.Forms.TextBox()
        Me.txtexamcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 37)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(44, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add/Schedule Exam"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboetype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbowk)
        Me.GroupBox1.Controls.Add(Me.cboterm)
        Me.GroupBox1.Controls.Add(Me.txtexamname)
        Me.GroupBox1.Controls.Add(Me.txtexamcode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 459)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Exam"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(501, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "(i.e 20171,20172 etc)"
        '
        'cboetype
        '
        Me.cboetype.FormattingEnabled = True
        Me.cboetype.Items.AddRange(New Object() {"Normal", "Full Paper"})
        Me.cboetype.Location = New System.Drawing.Point(227, 167)
        Me.cboetype.Name = "cboetype"
        Me.cboetype.Size = New System.Drawing.Size(151, 24)
        Me.cboetype.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Exam type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 47)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbowk
        '
        Me.cbowk.FormattingEnabled = True
        Me.cbowk.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbowk.Location = New System.Drawing.Point(227, 267)
        Me.cbowk.Name = "cbowk"
        Me.cbowk.Size = New System.Drawing.Size(151, 24)
        Me.cbowk.TabIndex = 11
        '
        'cboterm
        '
        Me.cboterm.FormattingEnabled = True
        Me.cboterm.Items.AddRange(New Object() {"1", "2", "3" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cboterm.Location = New System.Drawing.Point(227, 212)
        Me.cboterm.Name = "cboterm"
        Me.cboterm.Size = New System.Drawing.Size(151, 24)
        Me.cboterm.TabIndex = 10
        '
        'txtexamname
        '
        Me.txtexamname.Location = New System.Drawing.Point(227, 109)
        Me.txtexamname.Name = "txtexamname"
        Me.txtexamname.Size = New System.Drawing.Size(254, 22)
        Me.txtexamname.TabIndex = 6
        '
        'txtexamcode
        '
        Me.txtexamcode.Location = New System.Drawing.Point(227, 51)
        Me.txtexamcode.Name = "txtexamcode"
        Me.txtexamcode.Size = New System.Drawing.Size(254, 22)
        Me.txtexamcode.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Week Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Term"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam Code"
        '
        'Add_Exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(807, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Add_Exam"
        Me.Text = "Add_Exam"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbowk As System.Windows.Forms.ComboBox
    Friend WithEvents cboterm As System.Windows.Forms.ComboBox
    Friend WithEvents txtexamname As System.Windows.Forms.TextBox
    Friend WithEvents txtexamcode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboetype As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
