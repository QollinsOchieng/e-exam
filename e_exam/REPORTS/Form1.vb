Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class Form1
    Public connstring As String = "Data source=" & getServerName() & ";Initial catalog=EXAM;Integrated security=true"
    ' Public connstring As String = "Data source=" & getServerName() & ";Initial catalog=EXAM;Integrated security=true"
    Public sqlconn As New SqlConnection(connstring)
    Public da As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dt As DataTable
    Public ds As DataSet
    Dim crydoc As New ReportDocument
    Dim strPath As String = ""

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
        If CRetype = "Normal" Then
            load_norm_Result()
        Else
            load_fullp_Result()
        End If

    End Sub
    Public Sub load_norm_Result()
        Try
            Openconn()
            strPath = System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.LastIndexOf("\")).LastIndexOf("\"))
            'strPath = strPath + "\Reports\NormExamResult_class.rpt"
            'crydoc.Load(strPath)
            If CRstream = "" Then
                strPath = strPath + "\Reports\NormExamResult_class.rpt"
                crydoc.Load(strPath)
                'class report      
                CRstream = ""
                cmd = New SqlCommand("exec dbo.manage_results '" & CRclass & "','" & CRclsyear & "','" & eid & "'," &
               " '" & term & "','" & week & "','',1", sqlconn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                ds = New DataSet
                da.Fill(dt)
                ' ds.Tables("NormExam").Rows()
                da.Fill(ds, "NormExam")

                crydoc.SetDataSource(ds)
                NormReportView.ReportSource = crydoc
            Else
                'stream report
                strPath = strPath + "\Reports\NormExamResult.rpt"
                crydoc.Load(strPath)
                cmd = New SqlCommand("exec dbo.manage_results '" & CRclass & "','" & CRclsyear & "','" & eid & "','" & term & "','" & week & "','" & CRstream & "',2", sqlconn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                ds = New DataSet
                da.Fill(dt)
                da.Fill(ds, "NormExam")

                crydoc.SetDataSource(ds)
                NormReportView.ReportSource = crydoc
            End If
        Catch ex As Exception

        Finally
            closeconn()
        End Try
    End Sub

    Public Sub load_fullp_Result()
        Try
            Openconn()
            strPath = System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.LastIndexOf("\")).LastIndexOf("\"))
            'strPath = strPath + "\Reports\NormExamResult_class.rpt"
            'crydoc.Load(strPath)
            If CRstream = "" Then
                strPath = strPath + "\Reports\fullp_cls_report.rpt"
                crydoc.Load(strPath)
                'class report      
                CRstream = ""
                cmd = New SqlCommand("exec dbo.manage_results '" & CRclass & "','" & CRclsyear & "','" & eid & "'," &
               " '" & term & "','" & week & "','',3", sqlconn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                ds = New DataSet
                da.Fill(dt)
                ' ds.Tables("NormExam").Rows()
                da.Fill(ds, "FullPaperExam")

                crydoc.SetDataSource(ds)
                NormReportView.ReportSource = crydoc
            Else
                'stream report
                strPath = strPath + "\Reports\fullp_report.rpt"
                crydoc.Load(strPath)
                cmd = New SqlCommand("exec dbo.manage_results '" & CRclass & "','" & CRclsyear & "','" & eid & "','" & term & "','" & week & "','" & CRstream & "',4", sqlconn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                ds = New DataSet
                da.Fill(dt)
                da.Fill(ds, "FullPaperExam")

                crydoc.SetDataSource(ds)
                NormReportView.ReportSource = crydoc
            End If
        Catch ex As Exception

        Finally
            closeconn()
        End Try
    End Sub

End Class