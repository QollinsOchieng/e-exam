Public Class Termly_report

    

    Private Sub Termly_report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'For i As Int16 = 2000 To Today.Year Step 1
        '    Me.cboyear.Items.Add(i)
        'Next (i)
        fill_combo(cboclass, "select distinct Class FROM [dbo].[Termly_Student_marks] ")
        fill_combo(cbostream, "select distinct Stream FROM [dbo].[Termly_Student_marks]")
        fill_combo(cboyear, "select distinct class_year FROM [dbo].[Termly_Student_marks]")
    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        If cboetype.Text = "Normal" Then
           
            If cboclass.Text <> "" And cbostream.Text <> "" And cboyear.Text <> "" Then
                fill_grid(dgvReport, "select * from [dbo].[Termly_Student_marks] where Class='" + cboclass.Text + "' " &
                      "and Stream='" + cbostream.Text + "' and class_year='" + cboyear.Text + "' order by AVERAGE DESC")
                MsgBox("Search complete!")
            Else
                MsgBox("One or more fields is blank!")
            End If
        Else
           
            If cboclass.Text <> "" And cbostream.Text <> "" And cboyear.Text <> "" Then
                fill_grid(dgvReport, "select * from [dbo].[Termly_Student_marks_fp] where Class='" + cboclass.Text + "' " &
                      "and Stream='" + cbostream.Text + "' and class_year='" + cboyear.Text + "' order by AVERAGE DESC")
                MsgBox("Search complete!")
            Else
                MsgBox("One or more fields is blank!")
            End If
        End If
        


    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cboetype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboetype.SelectedIndexChanged
        cboclass.Text = ""
        cbostream.Text = ""
        cboyear.Text = ""
        If cboetype.Text = "Normal" Then
            fill_combo(cboclass, "select distinct Class FROM [dbo].[Termly_Student_marks] ")
            fill_combo(cbostream, "select distinct Stream FROM [dbo].[Termly_Student_marks]")
            fill_combo(cboyear, "select distinct class_year FROM [dbo].[Termly_Student_marks]")

        Else
            fill_combo(cboclass, "select distinct Class FROM [dbo].[Termly_Student_marks_fp] ")
            fill_combo(cbostream, "select distinct Stream FROM [dbo].[Termly_Student_marks_fp]")
            fill_combo(cboyear, "select distinct class_year FROM [dbo].[Termly_Student_marks_fp]")

        End If
    End Sub
End Class