<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_streams
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
        Me.dgvstreams = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstrid = New System.Windows.Forms.TextBox()
        Me.txtstrname = New System.Windows.Forms.TextBox()
        Me.chkedit = New System.Windows.Forms.CheckBox()
        Me.chkdelete = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.sstream = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvstreams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvstreams
        '
        Me.dgvstreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstreams.Location = New System.Drawing.Point(25, 98)
        Me.dgvstreams.Name = "dgvstreams"
        Me.dgvstreams.RowTemplate.Height = 24
        Me.dgvstreams.Size = New System.Drawing.Size(359, 368)
        Me.dgvstreams.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "StreamID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stream name"
        '
        'txtstrid
        '
        Me.txtstrid.Enabled = False
        Me.txtstrid.Location = New System.Drawing.Point(510, 139)
        Me.txtstrid.Name = "txtstrid"
        Me.txtstrid.Size = New System.Drawing.Size(89, 22)
        Me.txtstrid.TabIndex = 3
        '
        'txtstrname
        '
        Me.txtstrname.Enabled = False
        Me.txtstrname.Location = New System.Drawing.Point(510, 220)
        Me.txtstrname.Name = "txtstrname"
        Me.txtstrname.Size = New System.Drawing.Size(259, 22)
        Me.txtstrname.TabIndex = 4
        '
        'chkedit
        '
        Me.chkedit.AutoSize = True
        Me.chkedit.Location = New System.Drawing.Point(36, 26)
        Me.chkedit.Name = "chkedit"
        Me.chkedit.Size = New System.Drawing.Size(61, 21)
        Me.chkedit.TabIndex = 5
        Me.chkedit.Text = "EDIT"
        Me.chkedit.UseVisualStyleBackColor = True
        '
        'chkdelete
        '
        Me.chkdelete.AutoSize = True
        Me.chkdelete.Location = New System.Drawing.Point(189, 26)
        Me.chkdelete.Name = "chkdelete"
        Me.chkdelete.Size = New System.Drawing.Size(84, 21)
        Me.chkdelete.TabIndex = 6
        Me.chkdelete.Text = "DELETE"
        Me.chkdelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(510, 285)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 51)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(651, 285)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 51)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'sstream
        '
        Me.sstream.Location = New System.Drawing.Point(159, 67)
        Me.sstream.Name = "sstream"
        Me.sstream.Size = New System.Drawing.Size(166, 22)
        Me.sstream.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "search by sream"
        '
        'manage_streams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 478)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sstream)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.chkdelete)
        Me.Controls.Add(Me.chkedit)
        Me.Controls.Add(Me.txtstrname)
        Me.Controls.Add(Me.txtstrid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvstreams)
        Me.Name = "manage_streams"
        Me.Text = "manage_streams"
        CType(Me.dgvstreams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvstreams As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstrid As System.Windows.Forms.TextBox
    Friend WithEvents txtstrname As System.Windows.Forms.TextBox
    Friend WithEvents chkedit As System.Windows.Forms.CheckBox
    Friend WithEvents chkdelete As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents sstream As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
