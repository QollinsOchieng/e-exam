Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.EntityClient

Public Class MarksEntry_Normal
    Private Property ExamDataSets As Object

    Private Sub StudentMarksEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamDataSets.Students' table. You can move, or remove it, as needed.
        DataEntryPanel.Enabled = False
        txtSnum.Enabled = False
        dgvStudents.Enabled = False
        kis.Enabled = False
        rel.Enabled = False


        fill_grid(dgvStudents, "select [StudentID],[Student_number],[Student_name] from [dbo].[Students]")
        fill_combo(cboename, "select [Exam_name] FROM [dbo].[Exams] where status='OPEN' and Exam_type='Normal'")
        fill_combo(cbostream, "select distinct [Stream_name] FROM [dbo].[Streams]")
        For i As Int16 = 2000 To Today.Year Step 1
            Me.cboyear.Items.Add(i)
        Next (i)

    End Sub

    Private Sub chkgensci_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkgensci.CheckedChanged
        If chkgensci.Checked = True Then
            gensci.Enabled = True
        Else
            gensci.Enabled = False
        End If
    End Sub

    Private Sub txtSnum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSnum.TextChanged
        fill_grid(dgvStudents, "select StudentID,Student_number,Student_name from [dbo].[Students] where Student_number like '%" & txtSnum.Text & "%'")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        If cboename.Text = "" Or cboclass.Text = "" Or cbostream.Text = "" Or cboyear.Text = "" Then
            MsgBox("One or more fields is blank!", MessageBoxIcon.Information)
        Else
            txtSnum.Enabled = True
            dgvStudents.Enabled = True
            MsgBox("Please now proceed to search the student by Student ID/Student Number!", MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        DataEntryPanel.Enabled = True
        txtsid.Text = dgvStudents.Rows(e.RowIndex).Cells(0).Value
        txtsnumber.Text = dgvStudents.Rows(e.RowIndex).Cells(1).Value
        txtsname.Text = dgvStudents.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub cboename_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboename.SelectedIndexChanged
        If cboename.Text = "" Then
        Else
            fill_combo(cboeid, "select Exam_ID FROM [dbo].[Exams] where Exam_name='" & cboename.Text & "'")
            fill_combo(cboecode, "select Exam_code FROM [dbo].[Exams] where Exam_name='" & cboename.Text & "'")
            cboeid.SelectedIndex = 0
            cboecode.SelectedIndex = 0
            cboeid.Enabled = False
            cboecode.Enabled = False
        End If

    End Sub


    Private Sub btnNewClass_Click(sender As System.Object, e As System.EventArgs) Handles btnNewClass.Click
        Select Case MsgBox("Are you sure you want to enter marks for another Class?", MsgBoxStyle.YesNo, "Confirmation")
            Case MsgBoxResult.Yes
                DataEntryPanel.Enabled = False
                dgvStudents.Enabled = False
                txtSnum.Enabled = False
                clear_frmNormal(Me)
            Case MsgBoxResult.No
                MsgBox("Operation Canceled!", MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub selksl_ksw_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'ksl_ksw.Enabled = True

    End Sub

    Private Sub sel_rel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sel_rel.SelectedIndexChanged
        rel.Enabled = True
    End Sub
    Public Sub clear_frmNormal(frm As Form)
        Dim cbo As ComboBox
        Dim txt As TextBox
        Dim num As NumericUpDown

        For Each compt As Control In frm.Controls
            If TypeOf compt Is Panel Then
                For Each c As Control In compt.Controls
                    If TypeOf c Is TextBox Then
                        txt = c
                        txt.Text = ""
                    ElseIf TypeOf c Is ComboBox Then
                        cbo = c
                        cbo.SelectedIndex = -1
                    ElseIf TypeOf c Is NumericUpDown Then
                        num = c
                        num.Value = 0
                    ElseIf TypeOf c Is Panel Then
                        For Each c2 As Control In c.Controls
                            If TypeOf c2 Is TextBox Then
                                txt = c2
                                txt.Text = ""
                            ElseIf TypeOf c2 Is ComboBox Then
                                cbo = c2
                                cbo.SelectedIndex = -1
                            ElseIf TypeOf c2 Is NumericUpDown Then
                                num = c2
                                num.Value = 0
                            ElseIf TypeOf c2 Is GroupBox Then
                                For Each c3 As Control In c2.Controls
                                    If TypeOf c3 Is TextBox Then
                                        txt = c3
                                        txt.Text = ""
                                    ElseIf TypeOf c3 Is ComboBox Then
                                        cbo = c3
                                        cbo.SelectedIndex = -1
                                    ElseIf TypeOf c3 Is NumericUpDown Then
                                        num = c3
                                        num.Value = 0
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Else

            End If
        Next

    End Sub


    Private Sub chkkis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkkis.CheckedChanged
        If chkkis.Checked = True Then
            kis.Enabled = True
        Else
            kis.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim num As Integer = check_duplicates("SELECT * from [dbo].[Normal_exam_marks] where [Student_ID]='" & txtsid.Text & "' and [Student_num]='" & txtsnumber.Text & "' and " &
        "[Exam_ID] ='" & cboeid.Text & "' and [Exam_name]='" & cboename.Text & "' and [Exam_code]='" & cboecode.Text & "'")

        If num = 0 Then
            'there is no duplicate
            post_NormalExam(txtsid.Text, txtsnumber.Text, txtsname.Text, cboeid.Text, cboename.Text,
          cboecode.Text, cbostream.Text, cboclass.Text, cboyear.Text, eng.Text, kis.Text, ksl.Text,
          mat.Text, bio.Text, chem.Text, phyc.Text, gensci.Text, hist.Text, sel_rel.Text, rel.Text,
          geo.Text, hsci.Text, artd.Text, agric.Text, comp.Text, bus.Text, 1)

            clear_PanelgroupBox(Panel4)
            txtsnumber.Text = ""
            txtsid.Text = ""
            txtsname.Text = ""
        Else
            'there is duplicate
            MsgBox("You cannot enter same student twice for the same exam!", MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Public Sub load_marks_normal(studId As Integer, exid As Integer, cls As String, clsyr As Integer, stream As String)

        Try
            Openconn()
            cmd = New SqlCommand("select * from [dbo].[Normal_exam_marks] where Student_ID ='" & studId & "' AND Exam_ID ='" & exid & "'" &
                                 " AND Class ='" & cls & "' AND class_year ='" & clsyr & "' and Stream ='" & stream & "' ", sqlconn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                eng.Value = dt.Rows(0).Item("ENG")
                kis.Value = dt.Rows(0).Item("KIS")
                ksl.Value = dt.Rows(0).Item("KSL")
                mat.Value = dt.Rows(0).Item("MAT")
                bio.Value = dt.Rows(0).Item("BIO")
                phyc.Value = dt.Rows(0).Item("PHYC")
                chem.Value = dt.Rows(0).Item("CHEM")
                gensci.Value = dt.Rows(0).Item("GENSCI")
                hist.Value = dt.Rows(0).Item("HIST")
                geo.Value = dt.Rows(0).Item("GEO")
                sel_rel.SelectedItem = dt.Rows(0).Item("RELIGION")
                rel.Value = dt.Rows(0).Item("RELIGION_MARKS")
                agric.Value = dt.Rows(0).Item("AGRIC")
                comp.Value = dt.Rows(0).Item("COMP")
                hsci.Value = dt.Rows(0).Item("HSCI")
                artd.Value = dt.Rows(0).Item("ARTD")
                bus.Value = dt.Rows(0).Item("BUS")

            Else
                MsgBox("Record not found!", MsgBoxStyle.Critical)
                Exit Sub
            End If


            MsgBox("Operation Complete!")
        Catch ex As Exception
            ' cmd.Transaction.Rollback()
            MsgBox("Error during operation! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        post_NormalExam(txtsid.Text, txtsnumber.Text, txtsname.Text, cboeid.Text, cboename.Text,
         cboecode.Text, cbostream.Text, cboclass.Text, cboyear.Text, eng.Text, kis.Text, ksl.Text,
         mat.Text, bio.Text, chem.Text, phyc.Text, gensci.Text, hist.Text, sel_rel.Text, rel.Text,
         geo.Text, hsci.Text, artd.Text, agric.Text, comp.Text, bus.Text, 2)

        clear_PanelgroupBox(Panel4)
        txtsnumber.Text = ""
        txtsid.Text = ""
        txtsname.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles txtEdit.CheckedChanged
        If txtEdit.Checked = True Then
            load_marks_normal(txtsid.Text, cboeid.Text, cboclass.Text, cboyear.Text, cbostream.Text)
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub
End Class