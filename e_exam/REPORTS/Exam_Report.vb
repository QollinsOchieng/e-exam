Imports Microsoft.Office.Interop

Public Class Exam_Report
   
    Private Sub Exam_Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chkclass.Enabled = False
        chkstream.Enabled = False
        cboclass.Enabled = False
        cbostream.Enabled = False
        cboyear.Enabled = False

        btnview.Enabled = False
        fill_grid(dgvexams, "SELECT [Exam_ID] ,[Exam_code],[Exam_name],Exam_type,term,week_no FROM [EXAM].[dbo].[Exams]")
        For i As Int16 = 2000 To Today.Year Step 1
            Me.cboyear.Items.Add(i)
        Next (i)

    End Sub

    Private Sub dgvexams_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvexams.CellClick
        chkclass.Enabled = True
        chkstream.Enabled = True
        cboyear.Enabled = True

        dgvres.DataSource = Nothing
        Try
            etype = dgvexams.Rows(e.RowIndex).Cells(3).Value
            ename = dgvexams.Rows(e.RowIndex).Cells(2).Value
            eid = dgvexams.Rows(e.RowIndex).Cells(0).Value
            term = dgvexams.Rows(e.RowIndex).Cells(4).Value
            week = dgvexams.Rows(e.RowIndex).Cells(5).Value
            txteid.Text = eid
            'dgvexams.
            txtetype.Text = etype
            If etype = "Normal" Then
                fill_combo(cboyear, "select distinct Class_year FROM [EXAM].[dbo].[Normal_exam_marks]")
                fill_combo(cboclass, "select distinct Class FROM [EXAM].[dbo].[Normal_exam_marks]")
                fill_combo(cbostream, "select distinct Stream FROM [EXAM].[dbo].[Normal_exam_marks]")
            Else
                fill_combo(cboyear, "select distinct Class_year FROM [EXAM].[dbo].[Student_marks]")
                fill_combo(cboclass, "select distinct Class FROM [EXAM].[dbo].[Student_marks]")
                fill_combo(cbostream, "select distinct Stream FROM [EXAM].[dbo].[Student_marks]")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkclass_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkclass.CheckedChanged
        If chkclass.Checked = True Then
            chkstream.Checked = False
            cboclass.Enabled = True
            btnview.Enabled = True
            cbostream.Enabled = False
            cbostream.SelectedIndex = -1
        Else
            chkstream.Checked = True
        End If
    End Sub

    Private Sub chkstream_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkstream.CheckedChanged
        If chkstream.Checked = True Then
            chkclass.Checked = False
            cboclass.Enabled = True
            cbostream.Enabled = True
            btnview.Enabled = True

            'fill_combo(cboclass, "select distinct Class FROM [EXAM].[dbo].[Normal_exam_marks]")
            'fill_combo(cboclass, "select distinct Stream FROM [EXAM].[dbo].[Normal_exam_marks]")
        Else
            chkclass.Checked = True
            cbostream.SelectedIndex = -1
        End If
    End Sub

    Private Sub dgvexams_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvexams.CellContentClick

    End Sub
    Public Sub summary_Report()
        txtclass.Text = cboclass.Text
        txtyear.Text = cboyear.Text
        CRclass = cboclass.Text
        CRclsyear = cboyear.Text
        CRetype = txtetype.Text
        If cbostream.Enabled = True Then
            txtstream.Text = cbostream.Text
            CRstream = cbostream.Text
        End If
        txtename.Text = ename

        If etype = "Normal" Then
            'NORMAL EXAM
            If chkclass.Checked = True Then
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG]," &
           "[KIS],[KSL],[MAT],[BIO],[PHYC],[CHEM],[HIST],[GEO],[RELIGION],[RELIGION_MARKS],[AGRIC],[COMP],[HSCI],[ARTD],[BUS]," &
            "(cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) AS AVERAGE " &
           "FROM [EXAM].[dbo].[Normal_exam_marks] where Exam_ID='" & eid & "' and Class='" & txtclass.Text & "' and Class_year='" & txtyear.Text & "'" &
           " order by (cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) DESC ")
                MsgBox("Operation complete!")
            End If

            If chkstream.Checked = True Then
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG]," &
           "[KIS],[KSL],[MAT],[BIO],[PHYC],[CHEM],[HIST],[GEO],[RELIGION],[RELIGION_MARKS],[AGRIC],[COMP],[HSCI],[ARTD],[BUS]," &
            "(cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) AS AVERAGE " &
           "FROM [EXAM].[dbo].[Normal_exam_marks] where Exam_ID='" & eid & "' and Class='" & txtclass.Text & "' and Class_year='" & txtyear.Text & "' and Stream='" & txtstream.Text & "'" &
           " order by (cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) DESC ")
                MsgBox("Operation complete!")
            End If


        Else
            'FULL PAPER EXAM
            If chkclass.Checked = True Then
                'CLASS REPORT
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG],[KISW],[KSL],[MATA],[MATB],[BIO],[CHEM],[PHYC],[GENSCI]" &
              ",[HIST],[RELIGION],[REL_TOTAL],[GEO],[GRP4_SELECT],[GRP4_TOTAL],[GRP5_SELECT],[GRP5_TOTAL],[SUBJECTS_DONE],[AVERAGE]" &
                " FROM [EXAM].[dbo].[Student_marks] where ExamID ='" & eid & "' and Class ='" & txtclass.Text & "' and class_year ='" & txtyear.Text & "'" &
                " ORDER BY [AVERAGE] DESC")
                MsgBox("Operation complete!")
            End If

            If chkstream.Checked = True Then
                'per stream results
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG],[KISW],[KSL],[MATA],[MATB],[BIO],[CHEM],[PHYC],[GENSCI]" &
                 ",[HIST],[RELIGION],[REL_TOTAL],[GEO],[GRP4_SELECT],[GRP4_TOTAL],[GRP5_SELECT],[GRP5_TOTAL],[SUBJECTS_DONE],[AVERAGE]" &
                " FROM [EXAM].[dbo].[Student_marks] where ExamID ='" & eid & "' and Class ='" & txtclass.Text & "' and " &
                "  Stream='" & txtstream.Text & "' and class_year ='" & txtyear.Text & "'" &
                " ORDER BY [AVERAGE] DESC")
                MsgBox("Operation complete!")
            End If

        End If
    End Sub
    Public Sub full_report()
        txtclass.Text = cboclass.Text
        txtyear.Text = cboyear.Text
        CRclass = cboclass.Text
        CRclsyear = cboyear.Text
        CRetype = txtetype.Text
        If cbostream.Enabled = True Then
            txtstream.Text = cbostream.Text
            CRstream = cbostream.Text
        End If
        txtename.Text = ename

        If etype = "Normal" Then
            'NORMAL EXAM
            If chkclass.Checked = True Then
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG]," &
           "[KIS],[KSL],[MAT],[BIO],[PHYC],[CHEM],[HIST],[GEO],[RELIGION],[RELIGION_MARKS],[AGRIC],[COMP],[HSCI],[ARTD],[BUS]," &
            "(cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) AS AVERAGE " &
           "FROM [EXAM].[dbo].[Normal_exam_marks] where Exam_ID='" & eid & "' and Class='" & txtclass.Text & "' and Class_year='" & txtyear.Text & "'" &
           " order by (cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) DESC ")
                MsgBox("Operation complete!")
            End If

            If chkstream.Checked = True Then
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG]," &
           "[KIS],[KSL],[MAT],[BIO],[PHYC],[CHEM],[HIST],[GEO],[RELIGION],[RELIGION_MARKS],[AGRIC],[COMP],[HSCI],[ARTD],[BUS]," &
            "(cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) AS AVERAGE " &
           "FROM [EXAM].[dbo].[Normal_exam_marks] where Exam_ID='" & eid & "' and Class='" & txtclass.Text & "' and Class_year='" & txtyear.Text & "' and Stream='" & txtstream.Text & "'" &
           " order by (cast((ENG+KSL+MAT+BIO+PHYC+CHEM+HIST+GEO+RELIGION_MARKS+AGRIC+COMP+HSCI+ARTD+BUS) as float)/14) DESC ")
                MsgBox("Operation complete!")
            End If


        Else
            'FULL PAPER EXAM
            If chkclass.Checked = True Then
                'CLASS REPORT
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG],[ENG1],[ENG2],[ENG3],[KISW],[KISW1],[KISW2],[KISW3]" &
      ",[KSL],[KSL1],[KSL2],[KSL3],[MATA],[MATA1],[MATA2],[MATB],[MATB1],[MATB2] ,[BIO] ,[BIO1],[BIO2] ,[BIO3] ,[CHEM],[CHEM1]" &
     " ,[CHEM2] ,[CHEM3] ,[PHYC],[PHYC1] ,[PHYC2],[PHYC3],[GENSCI] ,[HIST],[HIST1],[HIST2] ,[RELIGION],[REL1],[REL2],[REL_TOTAL]" &
     " ,[GEO],[GEO1],[GEO2],[GRP4_SELECT] ,[GRP4_P1] ,[GRP4_P2],[GRP4_P3],[GRP4_TOTAL],[GRP5_SELECT],[GRP5_P1],[GRP5_P2],[GRP5_P3]" &
      ",[GRP5_TOTAL],[SUBJECTS_DONE],[AVERAGE]" &
        " FROM [EXAM].[dbo].[Student_marks] where ExamID ='" & eid & "' and Class ='" & txtclass.Text & "' and class_year ='" & txtyear.Text & "'" &
        " ORDER BY [AVERAGE] DESC")
                MsgBox("Operation complete!")
            End If

            If chkstream.Checked = True Then
                'per stream results
                fill_grid(dgvres, "SELECT [Student_num],[Student_name],[ENG],[ENG1],[ENG2],[ENG3],[KISW],[KISW1],[KISW2],[KISW3]" &
      ",[KSL],[KSL1],[KSL2],[KSL3],[MATA],[MATA1],[MATA2],[MATB],[MATB1],[MATB2] ,[BIO] ,[BIO1],[BIO2] ,[BIO3] ,[CHEM],[CHEM1]" &
     " ,[CHEM2] ,[CHEM3] ,[PHYC],[PHYC1] ,[PHYC2],[PHYC3],[GENSCI] ,[HIST],[HIST1],[HIST2] ,[RELIGION],[REL1],[REL2],[REL_TOTAL]" &
     " ,[GEO],[GEO1],[GEO2],[GRP4_SELECT] ,[GRP4_P1] ,[GRP4_P2],[GRP4_P3],[GRP4_TOTAL],[GRP5_SELECT],[GRP5_P1],[GRP5_P2],[GRP5_P3]" &
      ",[GRP5_TOTAL],[SUBJECTS_DONE],[AVERAGE]" &
                " FROM [EXAM].[dbo].[Student_marks] where ExamID ='" & eid & "' and Class ='" & txtclass.Text & "' and " &
                "  Stream='" & txtstream.Text & "' and class_year ='" & txtyear.Text & "' ORDER BY [AVERAGE] DESC")
                MsgBox("Operation complete!")
            End If

        End If
    End Sub
    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        ' MsgBox(etype)
        CRclass = cboclass.Text
        CRclsyear = cboyear.Text
        CRetype = txtetype.Text
        CRstream = cbostream.Text
        eid = txteid.Text
        btnavg.Enabled = True
        fill_grid(dgvres, "EXEC [dbo].[calculate_average] '" & eid & "','" & cboclass.Text & "','" & cboyear.Text & "'")
        summary_Report()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        summary_Report()
    End Sub

    Private Sub btnFull_Click(sender As System.Object, e As System.EventArgs) Handles btnFull.Click
        dgvres.DataSource = Nothing
        full_report()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnavg.Click
        Try
            calc_average(txteid.Text, cboclass.Text, cboyear.Text)
            'summary_Report()
            MsgBox("Operation Complete!")
        Catch ex As Exception
            MsgBox("Operation Failed! " & ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtc.TextChanged
        If LTrim(RTrim(txtc.Text)) = "" Then
            fill_grid(dgvexams, "SELECT [Exam_ID] ,[Exam_code],[Exam_name],Exam_type,term,week_no  FROM [EXAM].[dbo].[Exams]")
        Else
            fill_grid(dgvexams, "SELECT [Exam_ID] ,[Exam_code],[Exam_name],Exam_type,term,week_no  FROM [EXAM].[dbo].[Exams] where Exam_code like '%" + txtc.Text + "%'")
        End If

    End Sub

    
    Private Sub txteid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txteid.TextChanged
        'If txteid.Text = "" Then
        '    btnavg.Enabled = False

        'Else
        '    btnavg.Enabled = True
        'End If
    End Sub

    Private Sub dgvres_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvres.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CRclass = cboclass.Text
        CRclsyear = cboyear.Text
        CRetype = txtetype.Text
        CRstream = cbostream.Text
        eid = txteid.Text
        Form1.ShowDialog()
    End Sub
End Class