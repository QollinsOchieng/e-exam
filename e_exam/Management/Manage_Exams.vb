Public Class Manage_Exams

    Private Sub Manage_Exams_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnClose.Enabled = False
        btnDelete.Enabled = False
        btnRo.Enabled = False
        fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams]")
        '       fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where Exam_ID not in(select Exam_ID  from dbo.Normal_exam_marks ) " &
        '"and Exam_ID not in (select ExamID from dbo.Student_marks)")
    End Sub
    Private Sub chkDelete_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDelete.CheckedChanged
        checkbox_control(chkDelete, chkClose)
        checkbox_control(chkDelete, chkro)
        If chkDelete.Checked = True Then
            btnDelete.Enabled = True
            'select only those that dont have any  mark entry
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where Exam_ID not in(select Exam_ID  from dbo.Normal_exam_marks ) " &
     "and Exam_ID not in (select ExamID from dbo.Student_marks)")
        Else
            btnDelete.Enabled = False
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams]")
        End If
    End Sub
   

    Private Sub chkClose_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkClose.CheckedChanged
        checkbox_control(chkClose, chkDelete)
        checkbox_control(chkClose, chkro)
        If chkClose.Checked = True Then
            btnClose.Enabled = True
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where status='OPEN'")
        Else
            btnClose.Enabled = False
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams]")
        End If
    End Sub

    Private Sub dgvExams_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvExams.CellClick
        txteame.Text = dgvExams.Rows(e.RowIndex).Cells(2).Value
        txtecode.Text = dgvExams.Rows(e.RowIndex).Cells(1).Value
        txtetype.Text = dgvExams.Rows(e.RowIndex).Cells(3).Value
        txtExamID.Text = dgvExams.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dgvExams_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvExams.CellContentClick
       
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        ' exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 1)
        If MsgBox("Are you sure you want to DELETE the exam?", vbYesNo) = vbYes Then
            'MsgBox("yse")
            exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 2)
            MsgBox("EXAM DELETED!")
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where Exam_ID not in(select Exam_ID  from dbo.Normal_exam_marks ) " &
   "and Exam_ID not in (select ExamID from dbo.Student_marks)")
        Else
            'MsgBox("no")
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        ' exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 1)
        If MsgBox("Are you sure you want to close the exam?", vbYesNo) = vbYes Then
            'MsgBox("yse")
            exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 1)
            MsgBox("EXAM CLOSED!")
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where status='OPEN'")
        Else
            'MsgBox("no")
        End If
    End Sub

    Private Sub chkro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkro.CheckedChanged
        checkbox_control(chkro, chkDelete)
        checkbox_control(chkro, chkClose)
        If chkro.Checked = True Then
            btnRo.Enabled = True
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where status='CLOSED'")
        Else
            btnRo.Enabled = False
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams]")
        End If
    End Sub

    Private Sub btnRo_Click(sender As System.Object, e As System.EventArgs) Handles btnRo.Click
        ' exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 1)
        If MsgBox("Are you sure you want to OPEN the exam?", vbYesNo) = vbYes Then
            'MsgBox("yse")
            exams_manage(txtExamID.Text, txtecode.Text, txteame.Text, 3)
            MsgBox("EXAM OPENED!")
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where status='CLOSED'")
        Else
            'MsgBox("no")
        End If
    End Sub

   
    Private Sub secode_TextChanged(sender As System.Object, e As System.EventArgs) Handles secode.TextChanged
        If secode.Text = "" Then
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] ")
        Else
            fill_grid(dgvExams, "select * FROM [EXAM].[dbo].[Exams] where Exam_code like '%" + secode.Text + "%'")
        End If

    End Sub
End Class