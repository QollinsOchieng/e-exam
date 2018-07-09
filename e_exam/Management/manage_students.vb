Public Class manage_students

    Private Sub manage_students_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fill_grid(dgvstud, "select * from dbo.students")
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            fill_grid(dgvstud, "select * from dbo.students")
        Else
            fill_grid(dgvstud, "select * from dbo.students where [Student_number] like '%" + TextBox1.Text + "%'")
        End If
    End Sub

    Private Sub chksnum_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chksnum.CheckedChanged
        If chksnum.Checked = True Then
            txtsnum.Enabled = True
            txtsname.Enabled = False
            txtaddr.Enabled = False
            dob.Enabled = False
        Else
            txtsnum.Enabled = False
            txtsname.Enabled = True
            txtaddr.Enabled = True
            dob.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If chksnum.Checked = True Then
            Students_manage(txtsnum.Text, txtsid.Text, txtsname.Text, dob.Text, txtaddr.Text, 2)
            fill_grid(dgvstud, "select * from dbo.students")
        Else
            If LTrim(RTrim(txtsname.Text)) <> "" Then
                Students_manage(txtsnum.Text, txtsid.Text, txtsname.Text, dob.Text, txtaddr.Text, 1)
                fill_grid(dgvstud, "select * from dbo.students")
            Else
                MsgBox("cannot insert null values in (student name)!")
                txtsname.Focus()
            End If
            
        End If
    End Sub

    Private Sub dgvstud_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstud.CellClick
        txtsid.Text = dgvstud.Rows(e.RowIndex).Cells(0).Value
        txtsnum.Text = dgvstud.Rows(e.RowIndex).Cells(1).Value
        txtsname.Text = dgvstud.Rows(e.RowIndex).Cells(2).Value
        txtaddr.Text = dgvstud.Rows(e.RowIndex).Cells(4).Value
        dob.Text = dgvstud.Rows(e.RowIndex).Cells(3).Value
        btnUpdate.Enabled = True
    End Sub

    Private Sub dgvstud_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstud.CellContentClick

    End Sub
End Class