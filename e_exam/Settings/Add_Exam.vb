Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Add_Exam
    ' Dim dcon As New EXAMEntities

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim c As Integer = check_duplicates("select * from dbo.Exams where [Exam_code]='" + txtexamcode.Text + "'")
        If c = 0 Then
            post_exams(txtexamcode.Text, cboetype.Text, txtexamname.Text, cboterm.Text, cbowk.Text, "Qollo", 1)
            txtexamcode.Text = ""
            txtexamname.Text = ""
            cboetype.SelectedIndex = -1
            cboterm.SelectedIndex = -1
            cbowk.SelectedIndex = -1
        Else
            MsgBox("Duplicate Exam code!")
        End If


    End Sub
End Class