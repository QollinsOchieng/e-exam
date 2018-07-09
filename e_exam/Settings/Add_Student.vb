Imports System.Data
Imports System.Data.SqlClient
Imports System


Public Class Add_Student
    ' Dim exammodel As New EXAMEntities
    Dim fun As New FunctionLib

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim c As Integer = check_duplicates("select * from dbo.Students where Student_number='" + txtstudnum.Value + "'")
        If c = 0 Then
            post_Students(txtstudnum.Value, txtstudname.Text, dob.Text, txtaddr.Text, cbogender.Text, 1)
            txtstudnum.Value = 0
            txtstudname.Text = ""
            dob.Text = Today
            txtaddr.Text = ""
            cbogender.SelectedIndex = -1
        Else
            MsgBox("Duplicate student number exists!")
            Exit Sub
        End If

    End Sub
End Class