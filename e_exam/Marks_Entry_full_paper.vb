Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.EntityClient
Public Class Marks_Entry_full_paper

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            kisp1.Enabled = True
            kisp2.Enabled = True
            kisp3.Enabled = True
        Else
            kisp1.Enabled = False
            kisp2.Enabled = False
            kisp3.Enabled = False
        End If
    End Sub

    Private Sub Marks_Entry_full_paper_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DataEntryPanel2.Enabled = False
        Me.txtSnum.Enabled = False
        Me.dgvStudents.Enabled = False
        matbp1.Enabled = False
        matbp2.Enabled = False
        gensci.Enabled = False
        txtEdit.Enabled = False
        txtEdit.Checked = False
        btnUpdate.Enabled = False
        'selrelp1.SelectedIndex = 0

        fill_grid(Me.dgvStudents, "select [StudentID],[Student_number],[Student_name] from [dbo].[Students]")
        fill_combo(Me.cboename, "select [Exam_name] FROM [dbo].[Exams] WHERE Status='OPEN' and Exam_type<>'Normal'")
        fill_combo(Me.cbostream, "select distinct [Stream_name] FROM [dbo].[Streams]")
        For i As Int16 = 2000 To Today.Year Step 1
            Me.cboyear.Items.Add(i)
        Next (i)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Me.cboename.Text = "" Or Me.cboclass.Text = "" Or Me.cbostream.Text = "" Or Me.cboyear.Text = "" Then
            MsgBox("One or more fields is blank!", MessageBoxIcon.Information)
        Else
            Me.txtSnum.Enabled = True
            Me.dgvStudents.Enabled = True
            MsgBox("Please now proceed to search the student by Student ID/Student Number!", MessageBoxIcon.Information)
        End If
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

    Private Sub txtSnum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSnum.TextChanged
        fill_grid(Me.dgvStudents, "select StudentID,Student_number,Student_name from [dbo].[Students] where Student_number like '%" & txtSnum.Text & "%'")
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        DataEntryPanel2.Enabled = True
        txtEdit.Enabled = True

        txtsid.Text = dgvStudents.Rows(e.RowIndex).Cells(0).Value
        txtsnumber.Text = dgvStudents.Rows(e.RowIndex).Cells(1).Value
        txtsname.Text = dgvStudents.Rows(e.RowIndex).Cells(2).Value
       
    End Sub


    Private Sub btnNewClass_Click(sender As System.Object, e As System.EventArgs) Handles btnNewClass.Click
        Select Case MsgBox("Are you sure you want to enter marks for another Class?", MsgBoxStyle.YesNo, "Confirmation")
            Case MsgBoxResult.Yes
                DataEntryPanel2.Enabled = False
                dgvStudents.Enabled = False
                txtSnum.Enabled = False
                clear_frmFull(Me)
            Case MsgBoxResult.No
                MsgBox("Operation Canceled!", MessageBoxIcon.Information)
        End Select
    End Sub
    Public Sub clear_frmFull(frm As Form)
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

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub selg5p1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles selg5.SelectedIndexChanged
        g4p1.Enabled = False
        g4p2.Enabled = False
        g4p3.Enabled = False

        g5p1.Enabled = True
        g5p2.Enabled = True
        g5p3.Enabled = True

        selg4.SelectedIndex = -1
        If selg5.Text = "BUS" Then
            g5p3.Enabled = False
        Else
            g5p3.Enabled = True
        End If
    End Sub

    Private Sub selg4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles selg4.SelectedIndexChanged
        g5p1.Enabled = False
        g5p2.Enabled = False
        g5p3.Enabled = False

        g4p1.Enabled = True
        g4p2.Enabled = True
        g4p3.Enabled = True

        selg5.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim num As Integer = check_duplicates("SELECT * from [dbo].[Student_marks] where [Student_ID]='" & txtsid.Text & "' and [Student_num]='" & txtsnumber.Text & "' and " &
      "[ExamID] ='" & cboeid.Text & "' and [ExamName]='" & cboename.Text & "' and [ExamCode]='" & cboecode.Text & "' and class_year='" & cboyear.Text & "'")

        If num = 0 Then
            'there is no duplicate
            post_FullPaperExam(txtsid.Text, txtsnumber.Text, txtsname.Text, cboeid.Text, cboename.Text, cboecode.Text, cbostream.Text, cboclass.Text, cboyear.Text,
           engp1.Value, engp2.Value, engp3.Value, kisp1.Value, kisp2.Value, kisp3.Value, kslp1.Value, kslp2.Value, kslp3.Value, matap1.Value, matap2.Value,
            matbp1.Value, matbp2.Value, biop1.Value, biop2.Value, biop3.Value, chemp1.Value, chemp2.Value, chemp3.Value, phycp1.Value, phycp2.Value,
            phycp3.Value, gensci.Value, histp1.Value, histp2.Value, selrelp1.Text, relp1.Value, relp2.Value, geop1.Value,
            geop2.Value, selg4.Text, g4p1.Value, g4p2.Value, g4p3.Value, selg5.Text, g5p1.Value, g5p2.Value, g5p3.Value, 1)


            clear_PanelgroupBox(Panel10)
            txtsnumber.Text = ""
            txtsid.Text = ""
            txtsname.Text = ""
        Else
            'there is duplicate
            MsgBox("You cannot enter same student twice for the same exam!", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GroupBox9_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            matbp1.Enabled = True
            matbp2.Enabled = True
        Else
            matbp1.Enabled = False
            matbp2.Enabled = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            gensci.Enabled = True

            chemp1.Enabled = False
            chemp2.Enabled = False
            chemp3.Enabled = False
            biop1.Enabled = False
            biop2.Enabled = False
            biop3.Enabled = False
            phycp1.Enabled = False
            phycp2.Enabled = False
            phycp3.Enabled = False
        Else
            gensci.Enabled = False

            chemp1.Enabled = True
            chemp2.Enabled = True
            chemp3.Enabled = True
            biop1.Enabled = True
            biop2.Enabled = True
            biop3.Enabled = True
            phycp1.Enabled = True
            phycp2.Enabled = True
            phycp3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            GroupBox7.Enabled = True
        Else
            GroupBox7.Enabled = False
        End If

    End Sub

    Private Sub engp1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles engp1.ValueChanged
        'If engp1.Value > engp1.Maximum Then
        '    MsgBox("Exceeds maximum of 60")
        '    engp1.BackColor = Color.Red
        'End If
    End Sub

    Public Sub load_marks(studId As Integer, exid As Integer, cls As String, clsyr As Integer, stream As String)

        Try
            Openconn()
            cmd = New SqlCommand("select * from [dbo].[Student_marks] where Student_ID ='" & studId & "' AND ExamID ='" & exid & "'" &
                                 " AND Class ='" & cls & "' AND class_year ='" & clsyr & "' and Stream ='" & stream & "' ", sqlconn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                engp1.Value = dt.Rows(0).Item("ENG1")
                engp2.Value = dt.Rows(0).Item("ENG2")
                engp3.Value = dt.Rows(0).Item("ENG3")
                kisp1.Value = dt.Rows(0).Item("KISW1")
                kisp2.Value = dt.Rows(0).Item("KISW2")
                kisp3.Value = dt.Rows(0).Item("KISW3")
                kslp1.Value = dt.Rows(0).Item("KSL1")
                kslp2.Value = dt.Rows(0).Item("KSL2")
                kslp3.Value = dt.Rows(0).Item("KSL3")
                matap1.Value = dt.Rows(0).Item("MATA1")
                matap2.Value = dt.Rows(0).Item("MATA2")
                matbp1.Value = dt.Rows(0).Item("MATB1")
                matbp2.Value = dt.Rows(0).Item("MATB2")
                biop1.Value = dt.Rows(0).Item("BIO1")
                biop2.Value = dt.Rows(0).Item("BIO2")
                biop3.Value = dt.Rows(0).Item("BIO3")
                phycp1.Value = dt.Rows(0).Item("PHYC1")
                phycp2.Value = dt.Rows(0).Item("PHYC2")
                phycp3.Value = dt.Rows(0).Item("PHYC3")
                chemp1.Value = dt.Rows(0).Item("CHEM1")
                chemp2.Value = dt.Rows(0).Item("CHEM2")
                chemp3.Value = dt.Rows(0).Item("CHEM3")
                gensci.Value = dt.Rows(0).Item("GENSCI")
                histp1.Value = dt.Rows(0).Item("HIST1")
                histp2.Value = dt.Rows(0).Item("HIST2")
                geop1.Value = dt.Rows(0).Item("GEO1")
                geop2.Value = dt.Rows(0).Item("GEO2")
                g4p1.Value = dt.Rows(0).Item("GRP4_P1")
                g4p2.Value = dt.Rows(0).Item("GRP4_P2")
                g4p3.Value = dt.Rows(0).Item("GRP4_P3")
                selg4.SelectedItem = dt.Rows(0).Item("GRP4_SELECT")
                g5p1.Value = dt.Rows(0).Item("GRP5_P1")
                g5p2.Value = dt.Rows(0).Item("GRP5_P2")
                g5p3.Value = dt.Rows(0).Item("GRP5_P3")
                selg5.SelectedItem = dt.Rows(0).Item("GRP5_SELECT")
            Else
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
    
    Private Sub dgvStudents_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

    End Sub

    Private Sub txtEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles txtEdit.CheckedChanged
        If txtEdit.Checked = True Then
            load_marks(txtsid.Text, cboeid.Text, cboclass.Text, cboyear.Text, cbostream.Text)
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        post_FullPaperExam(txtsid.Text, txtsnumber.Text, txtsname.Text, cboeid.Text, cboename.Text, cboecode.Text, cbostream.Text, cboclass.Text, cboyear.Text,
         engp1.Value, engp2.Value, engp3.Value, kisp1.Value, kisp2.Value, kisp3.Value, kslp1.Value, kslp2.Value, kslp3.Value, matap1.Value, matap2.Value,
          matbp1.Value, matbp2.Value, biop1.Value, biop2.Value, biop3.Value, chemp1.Value, chemp2.Value, chemp3.Value, phycp1.Value, phycp2.Value,
          phycp3.Value, gensci.Value, histp1.Value, histp2.Value, selrelp1.Text, relp1.Value, relp2.Value, geop1.Value,
          geop2.Value, selg4.Text, g4p1.Value, g4p2.Value, g4p3.Value, selg5.Text, g5p1.Value, g5p2.Value, g5p3.Value, 2)
    End Sub
End Class