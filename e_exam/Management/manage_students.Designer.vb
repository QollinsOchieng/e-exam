<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_students
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
        Me.dgvstud = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chksnum = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsid = New System.Windows.Forms.TextBox()
        Me.txtsnum = New System.Windows.Forms.TextBox()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvstud
        '
        Me.dgvstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstud.Location = New System.Drawing.Point(21, 128)
        Me.dgvstud.Name = "dgvstud"
        Me.dgvstud.RowTemplate.Height = 24
        Me.dgvstud.Size = New System.Drawing.Size(979, 301)
        Me.dgvstud.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by student number"
        '
        'chksnum
        '
        Me.chksnum.AutoSize = True
        Me.chksnum.Location = New System.Drawing.Point(105, 454)
        Me.chksnum.Name = "chksnum"
        Me.chksnum.Size = New System.Drawing.Size(343, 21)
        Me.chksnum.TabIndex = 3
        Me.chksnum.Text = "UPDATE STUDENT NUMBER (need to be admin)"
        Me.chksnum.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 494)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 597)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Student number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(597, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 601)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DOB"
        '
        'txtsid
        '
        Me.txtsid.Enabled = False
        Me.txtsid.Location = New System.Drawing.Point(274, 491)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(112, 22)
        Me.txtsid.TabIndex = 8
        '
        'txtsnum
        '
        Me.txtsnum.Enabled = False
        Me.txtsnum.Location = New System.Drawing.Point(274, 594)
        Me.txtsnum.Name = "txtsnum"
        Me.txtsnum.Size = New System.Drawing.Size(187, 22)
        Me.txtsnum.TabIndex = 9
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(675, 596)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 22)
        Me.dob.TabIndex = 10
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(675, 528)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(200, 22)
        Me.txtaddr.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Student name"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(274, 545)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(271, 22)
        Me.txtsname.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(755, 647)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 42)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'manage_students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 720)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaddr)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.txtsnum)
        Me.Controls.Add(Me.txtsid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chksnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvstud)
        Me.Name = "manage_students"
        Me.Text = "manage_students"
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvstud As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chksnum As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsid As System.Windows.Forms.TextBox
    Friend WithEvents txtsnum As System.Windows.Forms.TextBox
    Friend WithEvents dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
