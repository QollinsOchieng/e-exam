Public Class manage_streams

    Private Sub chkedit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkedit.CheckedChanged
        checkbox_control(chkedit, chkdelete)
        If chkedit.Checked = True Then
            btnUpdate.Enabled = True
            txtstrname.Enabled = True
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
            " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
            " and Stream_name not in (select distinct Stream from dbo.Student_marks)")
        Else
            btnUpdate.Enabled = False
            txtstrname.Enabled = False
            fill_grid(dgvstreams, "select * FROM [EXAM].[dbo].[Streams]")
        End If
    End Sub

    Private Sub chkdelete_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkdelete.CheckedChanged
        checkbox_control(chkdelete, chkedit)
        If chkdelete.Checked = True Then
            btnDelete.Enabled = True
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
            " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
            " and Stream_name not in (select distinct Stream from dbo.Student_marks)")
        Else
            btnDelete.Enabled = False
            fill_grid(dgvstreams, "select * FROM [EXAM].[dbo].[Streams]")
        End If
    End Sub

    Private Sub dgvstreams_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstreams.CellClick
        txtstrid.Text = dgvstreams.Rows(e.RowIndex).Cells(0).Value
        txtstrname.Text = dgvstreams.Rows(e.RowIndex).Cells(1).Value
    End Sub

  
    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If MsgBox("Are you sure you want to edit the stream details?", vbYesNo) = vbYes Then
            'MsgBox("yse")
            streams_manage(txtstrid.Text, txtstrname.Text, 1)
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
            " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
            " and Stream_name not in (select distinct Stream from dbo.Student_marks)")
        Else
            'MsgBox("no")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete the stream ?", vbYesNo) = vbYes Then
            'MsgBox("yse")
            streams_manage(txtstrid.Text, txtstrname.Text, 2)
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
            " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
            " and Stream_name not in (select distinct Stream from dbo.Student_marks)")
        Else
            'MsgBox("no")
        End If
    End Sub

    Private Sub manage_streams_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles sstream.TextChanged
        If chkdelete.Checked = True Then
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
         " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
         " and Stream_name not in (select distinct Stream from dbo.Student_marks) and Stream_name like '%" + sstream.Text + "%'")
        ElseIf chkedit.Checked = True Then
            fill_grid(dgvstreams, "SELECT  [StreamID] ,[Stream_name] FROM [EXAM].[dbo].[Streams] " &
           " where Stream_name not in (select distinct Stream from dbo.Normal_exam_marks) " &
           " and Stream_name not in (select distinct Stream from dbo.Student_marks) and Stream_name like '%" + sstream.Text + "%'")
        Else
            MsgBox("you have to select the action (edit or delete)!")
        End If
    End Sub
End Class