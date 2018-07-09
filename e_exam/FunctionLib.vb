Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.EntityClient
Imports Microsoft.SqlServer.Management.Smo

Public Class FunctionLib
    Dim sql As String
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ecmd As New EntityCommand
    Private strServerName As String
    Private serverNameRetrived As Boolean = False

    Dim connstring As String = "Data source=" & getServerName() & ";Initial catalog=EXAM;Integrated security=true"
    Dim sqlconn As New SqlConnection(connstring)

    ' Dim dcon As New EXAMEntities

    Public Function validatefrm(grp As GroupBox)
        Dim cbo As ComboBox
        Dim txt As TextBox
        Dim num As NumericUpDown
        Dim blank As Boolean = False
        For Each compt As Control In grp.Controls
            If TypeOf compt Is TextBox Then
                txt = compt
                If txt.Text = "" Then
                    'if it is blank return 1 and restrict saving
                    blank = True
                    txt.BackColor = Color.Red
                Else
                    blank = False
                    txt.BackColor = Color.White
                End If
            ElseIf TypeOf compt Is ComboBox Then
                cbo = compt
                If cbo.SelectedIndex = -1 Then
                    'if it is blank return 1 and restrict saving
                    blank = True
                    cbo.BackColor = Color.Red
                Else
                    blank = False
                    cbo.BackColor = Color.White
                End If
            ElseIf TypeOf compt Is NumericUpDown Then
                num = compt
                If num.Value = 0 Then
                    'if it is 0 return 1 and restrict saving
                    blank = True
                    num.BackColor = Color.Red
                Else
                    blank = False
                    num.BackColor = Color.White
                End If
            End If
        Next

        Return blank
    End Function
   
    Public Function count_dataset(sql As String)
        Dim cnt As Integer = 0
        Try
            'dcon.Connection.Open()
            'ecmd = New EntityCommand(sql, dcon.Connection)
            'cnt = ecmd.ExecuteNonQuery()
            sqlconn.Open()
            cmd = New SqlCommand(sql, sqlconn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cnt = dt.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox("ERROR retrieving records!" + ex.Message)
        Finally
            sqlconn.Close()
        End Try

        Return cnt
    End Function
  
    'Public Function getServerName() As String

    '    If serverNameRetrived Then Return strServerName

    '    Try
    '        Dim freader As System.IO.StreamReader
    '        freader = System.IO.File.OpenText("serverpath")

    '        strServerName = freader.ReadLine()

    '        freader.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        'MsgBox(ex.Message & "Please go to Tools menu, server configuration to configure the server", MsgBoxStyle.Critical)
    '        Return ""
    '    End Try
    '    Return strServerName
    'End Function
    
End Class
