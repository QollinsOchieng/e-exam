Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Add_Stream
    Dim fun As New FunctionLib
    'Dim dcon As New EXAMEntities
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Openconn()
        Dim cnt As Integer = fun.count_dataset("select count(Stream_name) from dbo.[Streams] where [Stream_name] like '%" + txtstrname.Text.ToUpper + "%'")
        'MsgBox(cnt.ToString)
        If cnt = 0 Then
            post_streams(txtstrname.Text.ToUpper, 1)
            fill_grid(dgvStreams, "select * from dbo.streams")
            txtstrname.Text = ""
        Else
            MsgBox("There exist duplicate name of stream. Stream names should be unique!", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Add_Stream_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamDataSets.Streams' table. You can move, or remove it, as needed.
        fill_grid(dgvStreams, "select stream_name from dbo.streams")
    End Sub

    

    Private Function StreamsTableAdapter() As Object
        Throw New NotImplementedException
    End Function

End Class
