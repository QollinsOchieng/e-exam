<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Exams
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
        Me.dgvExams = New System.Windows.Forms.DataGridView()
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.chkClose = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtecode = New System.Windows.Forms.TextBox()
        Me.txtetype = New System.Windows.Forms.TextBox()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txteame = New System.Windows.Forms.TextBox()
        Me.btnRo = New System.Windows.Forms.Button()
        Me.chkro = New System.Windows.Forms.CheckBox()
        Me.secode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExams
        '
        Me.dgvExams.AllowUserToAddRows = False
        Me.dgvExams.AllowUserToDeleteRows = False
        Me.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExams.Location = New System.Drawing.Point(35, 127)
        Me.dgvExams.Name = "dgvExams"
        Me.dgvExams.ReadOnly = True
        Me.dgvExams.RowTemplate.Height = 24
        Me.dgvExams.Size = New System.Drawing.Size(942, 276)
        Me.dgvExams.TabIndex = 0
        '
        'chkDelete
        '
        Me.chkDelete.AutoSize = True
        Me.chkDelete.Location = New System.Drawing.Point(35, 26)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(389, 21)
        Me.chkDelete.TabIndex = 2
        Me.chkDelete.Text = "DELETE (List of exams that dont have any student entry)"
        Me.chkDelete.UseVisualStyleBackColor = True
        '
        'chkClose
        '
        Me.chkClose.AutoSize = True
        Me.chkClose.Location = New System.Drawing.Point(485, 26)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(118, 21)
        Me.chkClose.TabIndex = 3
        Me.chkClose.Text = "CLOSE EXAM"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(331, 551)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 46)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(509, 551)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 46)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Exam ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Exam Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Exam code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 484)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Exam type"
        '
        'txtecode
        '
        Me.txtecode.Enabled = False
        Me.txtecode.Location = New System.Drawing.Point(474, 427)
        Me.txtecode.Name = "txtecode"
        Me.txtecode.Size = New System.Drawing.Size(191, 22)
        Me.txtecode.TabIndex = 10
        '
        'txtetype
        '
        Me.txtetype.Enabled = False
        Me.txtetype.Location = New System.Drawing.Point(474, 484)
        Me.txtetype.Name = "txtetype"
        Me.txtetype.Size = New System.Drawing.Size(191, 22)
        Me.txtetype.TabIndex = 11
        '
        'txtExamID
        '
        Me.txtExamID.Enabled = False
        Me.txtExamID.Location = New System.Drawing.Point(160, 432)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.Size = New System.Drawing.Size(177, 22)
        Me.txtExamID.TabIndex = 12
        '
        'txteame
        '
        Me.txteame.Enabled = False
        Me.txteame.Location = New System.Drawing.Point(160, 484)
        Me.txteame.Name = "txteame"
        Me.txteame.Size = New System.Drawing.Size(177, 22)
        Me.txteame.TabIndex = 13
        '
        'btnRo
        '
        Me.btnRo.Location = New System.Drawing.Point(701, 551)
        Me.btnRo.Name = "btnRo"
        Me.btnRo.Size = New System.Drawing.Size(107, 46)
        Me.btnRo.TabIndex = 14
        Me.btnRo.Text = "Open"
        Me.btnRo.UseVisualStyleBackColor = True
        '
        'chkro
        '
        Me.chkro.AutoSize = True
        Me.chkro.Location = New System.Drawing.Point(726, 26)
        Me.chkro.Name = "chkro"
        Me.chkro.Size = New System.Drawing.Size(88, 21)
        Me.chkro.TabIndex = 15
        Me.chkro.Text = "Re-Open"
        Me.chkro.UseVisualStyleBackColor = True
        '
        'secode
        '
        Me.secode.Location = New System.Drawing.Point(399, 86)
        Me.secode.Name = "secode"
        Me.secode.Size = New System.Drawing.Size(203, 22)
        Me.secode.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Search by exam code"
        '
        'Manage_Exams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 615)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.secode)
        Me.Controls.Add(Me.chkro)
        Me.Controls.Add(Me.btnRo)
        Me.Controls.Add(Me.txteame)
        Me.Controls.Add(Me.txtExamID)
        Me.Controls.Add(Me.txtetype)
        Me.Controls.Add(Me.txtecode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.chkClose)
        Me.Controls.Add(Me.chkDelete)
        Me.Controls.Add(Me.dgvExams)
        Me.Name = "Manage_Exams"
        Me.Text = "Manage_Exams"
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvExams As System.Windows.Forms.DataGridView
    Friend WithEvents chkDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chkClose As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtecode As System.Windows.Forms.TextBox
    Friend WithEvents txtetype As System.Windows.Forms.TextBox
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
    Friend WithEvents txteame As System.Windows.Forms.TextBox
    Friend WithEvents btnRo As System.Windows.Forms.Button
    Friend WithEvents chkro As System.Windows.Forms.CheckBox
    Friend WithEvents secode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
