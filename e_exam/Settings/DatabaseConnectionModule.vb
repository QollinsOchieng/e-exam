Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.EntityClient

Module DatabaseConnectionModule
    Private strServerName As String
    Private serverNameRetrived As Boolean = False
    Public connstring As String = "Data source=" & getServerName() & ";Initial catalog=EXAM;Integrated security=true"
    ' Public connstring As String = "Data source=" & getServerName() & ";Initial catalog=EXAM;Integrated security=true"
    Public sqlconn As New SqlConnection(connstring)
    Public da As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dt As DataTable
    Public etype As String = ""
    Public ename As String = ""
    Public eid As Integer = 0
    Public term As Integer = 0
    Public week As Integer = 0
    Public CRclass As String = ""
    Public CRclsyear As Integer = 0
    Public CRstream As String = ""
    Public CRetype As String = ""
    Public Sub connection()
        'If My.Settings.LocalConn = True Then
        '    'local connection is true

        'Else
        '    'local connection c is false i.e production
        'End If
    End Sub
    Public Sub Openconn()
        If sqlconn.State <> ConnectionState.Open Then
            sqlconn.Open()
        End If
    End Sub
    Public Sub closeconn()
        If sqlconn.State <> ConnectionState.Closed Then
            sqlconn.Close()
        End If
    End Sub
    Public Function getServerName() As String

        If serverNameRetrived Then Return strServerName

        Try
            Dim freader As System.IO.StreamReader
            freader = System.IO.File.OpenText("serverpath")

            strServerName = freader.ReadLine()

            freader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox(ex.Message & "Please go to Tools menu, server configuration to configure the server", MsgBoxStyle.Critical)
            Return ""
        End Try
        Return strServerName
    End Function

    Public Sub post_streams(txtsname As String, type As Integer)

        Try
            Openconn()
            cmd = New SqlCommand("post_streams", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@strname", txtsname.ToUpper)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record Saved!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub exams_manage(eid As Integer, ecode As Integer, ename As String, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("exam_manage", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@eid", eid)
            cmd.Parameters.AddWithValue("@ecode", ecode)
            cmd.Parameters.AddWithValue("@ename", ename)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Operation complete!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub checkbox_control(chk1 As CheckBox, chk2 As CheckBox)
        If chk1.Checked = True Then
            chk2.Checked = False
        Else
            chk2.Checked = False
        End If
    End Sub
    Public Sub streams_manage(strid As Integer, strname As String, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("manage_streams", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@strid", strid)
            cmd.Parameters.AddWithValue("@strname", strname)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Operation complete!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub post_exams(Exam_code As String, Exam_type As String, Exam_name As String, Term As Integer, Week_no As Integer,
                           Created_by As String, type As Integer)

        Try
            Openconn()
            cmd = New SqlCommand("post_exams", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Exam_code", Exam_code.ToUpper)
            cmd.Parameters.AddWithValue("@Exam_type", Exam_type.ToUpper)
            cmd.Parameters.AddWithValue("@Exam_name", Exam_name.ToUpper)
            cmd.Parameters.AddWithValue("@Term", Term)
            cmd.Parameters.AddWithValue("@Week_no", Week_no)
            ' cmd.Parameters.AddWithValue("@Target_class", Target_class.ToUpper)
            cmd.Parameters.AddWithValue("@Created_by", Created_by.ToUpper)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record Saved!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub post_Students(Student_number As String, Student_name As String, DOB As Date, Address As String, Gender As String, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("post_Students", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Student_number", Student_number)
            cmd.Parameters.AddWithValue("@Student_name", Student_name.ToUpper)
            cmd.Parameters.AddWithValue("@DOB", DOB)
            cmd.Parameters.AddWithValue("@Address", Address.ToUpper)
            cmd.Parameters.AddWithValue("@Gender", Gender.ToUpper)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record Saved!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub Students_manage(Student_number As String, sid As Integer, Student_name As String, DOB As Date, Address As String, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("manage_Students", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Student_number", Student_number)
            cmd.Parameters.AddWithValue("@StudentID", sid)
            cmd.Parameters.AddWithValue("@Student_name", Student_name.ToUpper)
            cmd.Parameters.AddWithValue("@DOB", DOB)
            cmd.Parameters.AddWithValue("@Address", Address.ToUpper)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record update!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub post_NormalExam(Student_ID As Integer, Student_num As String, Student_name As String, ExamID As Integer, ExamName As String,
  ExamCode As String, Stream As String, eClass As String, class_year As Integer, ENG As Integer, KIS As Integer, KSL As Integer,
  MAT As Integer, BIO As Integer, CHEM As Integer, PHYC As Integer, GENSCI As Integer, HIST As Integer, RELIGION As String, RELIGION_MARKS As Integer,
  GEO As Integer, HSCI As Integer, ARTD As Integer, AGRIC As Integer, COMP As Integer, BUS As Integer, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("post_NormalExam_marks", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Student_ID", Student_ID)
            cmd.Parameters.AddWithValue("@Student_num", Student_num.ToUpper)
            cmd.Parameters.AddWithValue("@Student_name", Student_name.ToUpper)
            cmd.Parameters.AddWithValue("@ExamID", ExamID)
            cmd.Parameters.AddWithValue("@ExamName", ExamName.ToUpper)
            cmd.Parameters.AddWithValue("@ExamCode", ExamCode)
            cmd.Parameters.AddWithValue("@Stream", Stream.ToUpper)
            cmd.Parameters.AddWithValue("@Class", eClass.ToUpper)
            cmd.Parameters.AddWithValue("@class_year", class_year)
            cmd.Parameters.AddWithValue("@ENG", ENG)
            cmd.Parameters.AddWithValue("@KIS", KIS)
            cmd.Parameters.AddWithValue("@KSL", KSL)
            cmd.Parameters.AddWithValue("@MAT", MAT)
            cmd.Parameters.AddWithValue("@BIO", BIO)
            cmd.Parameters.AddWithValue("@CHEM", CHEM)
            cmd.Parameters.AddWithValue("@PHYC", PHYC)
            cmd.Parameters.AddWithValue("@GENSCI", GENSCI)
            cmd.Parameters.AddWithValue("@HIST", HIST)
            cmd.Parameters.AddWithValue("@RELIGION", RELIGION.ToUpper)
            cmd.Parameters.AddWithValue("@RELIGION_MARKS", RELIGION_MARKS)
            cmd.Parameters.AddWithValue("@GEO", GEO)
            cmd.Parameters.AddWithValue("@HSCI", HSCI)
            cmd.Parameters.AddWithValue("@ARTD", ARTD)
            cmd.Parameters.AddWithValue("@AGRIC", AGRIC)
            cmd.Parameters.AddWithValue("@COMP", COMP)
            cmd.Parameters.AddWithValue("@BUS", BUS)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record Saved!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub fill_grid(dgv As DataGridView, sql As String)
        Try
            Openconn()
            cmd = New SqlCommand(sql, sqlconn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            'Dim ds As New DataSet
            'da.Fill(ds)
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("Error! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Function check_duplicates(sql As String)
        Dim cnt As Integer = 0
        Try
            Openconn()
            cmd = New SqlCommand(sql, sqlconn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)

            cnt = dt.Rows.Count
        Catch ex As Exception
            MsgBox("Error! " & ex.Message)
        Finally
            closeconn()
        End Try
        Return cnt
    End Function
    Public Sub fill_combo(cbo As ComboBox, sql As String)
        Try
            Openconn()
            cmd = New SqlCommand(sql, sqlconn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader
            cbo.Items.Clear()
            While dr.Read
                'Dim col As String = dr(0)
                With cbo.Items
                    .Add(dr(0))
                End With
            End While

        Catch ex As Exception
            MsgBox("Error! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    
    Public Sub clear_PanelgroupBox(p As Panel)
        Dim cbo As ComboBox
        Dim txt As TextBox
        Dim num As NumericUpDown

        For Each compt As Control In p.Controls
            If TypeOf compt Is GroupBox Then
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
                    End If
                Next
            Else

            End If
        Next

    End Sub
    Public Sub post_FullPaperExam(Student_ID As Integer, Student_num As String, Student_name As String, ExamID As Integer, ExamName As String,
     ExamCode As String, Stream As String, Cls As String, class_year As Integer,
  ENG1 As Integer, ENG2 As Integer, ENG3 As Integer, KISW1 As Integer, KISW2 As Integer, KISW3 As Integer,
 KSL1 As Integer, KSL2 As Integer, KSL3 As Integer, MATA1 As Integer, MATA2 As Integer,
  MATB1 As Integer, MATB2 As Integer, BIO1 As Integer, BIO2 As Integer, BIO3 As Integer, CHEM1 As Integer,
  CHEM2 As Integer, CHEM3 As Integer, PHYC1 As Integer, PHYC2 As Integer, PHYC3 As Integer, GENSCI As Integer,
  HIST1 As Integer, HIST2 As Integer, RELIGION As String, REL1 As Integer, REL2 As Integer, GEO1 As Integer,
  GEO2 As Integer, GRP4_SELECT As String, GRP4_P1 As Integer, GRP4_P2 As Integer, GRP4_P3 As Integer, GRP5_SELECT As String,
  GRP5_P1 As Integer, GRP5_P2 As Integer, GRP5_P3 As Integer, type As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("post_Student_marks", sqlconn)
            cmd.Transaction = cmd.Connection.BeginTransaction
            ' cmd.commandText= stored proc name
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Student_ID", Student_ID)
            cmd.Parameters.AddWithValue("@Student_num", Student_num.ToUpper)
            cmd.Parameters.AddWithValue("@Student_name ", Student_name.ToUpper)
            cmd.Parameters.AddWithValue("@ExamID", ExamID)
            cmd.Parameters.AddWithValue("@ExamName ", ExamName.ToUpper)
            cmd.Parameters.AddWithValue("@ExamCode ", ExamCode.ToUpper)
            cmd.Parameters.AddWithValue("@Stream ", Stream.ToUpper)
            cmd.Parameters.AddWithValue("@Class ", Cls.ToUpper)
            cmd.Parameters.AddWithValue("@class_year", class_year)
            cmd.Parameters.AddWithValue("@ENG1", ENG1)
            cmd.Parameters.AddWithValue("@ENG2", ENG2)
            cmd.Parameters.AddWithValue("@ENG3", ENG3)
            cmd.Parameters.AddWithValue("@KISW1", KISW1)
            cmd.Parameters.AddWithValue("@KISW2", KISW2)
            cmd.Parameters.AddWithValue("@KISW3", KISW3)
            cmd.Parameters.AddWithValue("@KSL1", KSL1)
            cmd.Parameters.AddWithValue("@KSL2", KSL2)
            cmd.Parameters.AddWithValue("@KSL3", KSL3)
            cmd.Parameters.AddWithValue("@MATA1", MATA1)
            cmd.Parameters.AddWithValue("@MATA2", MATA2)
            cmd.Parameters.AddWithValue("@MATB1", MATB1)
            cmd.Parameters.AddWithValue("@MATB2", MATB2)
            cmd.Parameters.AddWithValue("@BIO1", BIO1)
            cmd.Parameters.AddWithValue("@BIO2", BIO2)
            cmd.Parameters.AddWithValue("@BIO3", BIO3)
            cmd.Parameters.AddWithValue("@CHEM1", CHEM1)
            cmd.Parameters.AddWithValue("@CHEM2", CHEM2)
            cmd.Parameters.AddWithValue("@CHEM3", CHEM3)
            cmd.Parameters.AddWithValue("@PHYC1", PHYC1)
            cmd.Parameters.AddWithValue("@PHYC2", PHYC2)
            cmd.Parameters.AddWithValue("@PHYC3", PHYC3)
            cmd.Parameters.AddWithValue("@GENSCI", GENSCI)
            cmd.Parameters.AddWithValue("@HIST1", HIST1)
            cmd.Parameters.AddWithValue("@HIST2", HIST2)
            cmd.Parameters.AddWithValue("@RELIGION ", RELIGION.ToUpper)
            cmd.Parameters.AddWithValue("@REL1", REL1)
            cmd.Parameters.AddWithValue("@REL2", REL2)
            cmd.Parameters.AddWithValue("@GEO1", GEO1)
            cmd.Parameters.AddWithValue("@GEO2", GEO2)
            cmd.Parameters.AddWithValue("@GRP4_SELECT", GRP4_SELECT.ToUpper)
            cmd.Parameters.AddWithValue("@GRP4_P1", GRP4_P1)
            cmd.Parameters.AddWithValue("@GRP4_P2", GRP4_P2)
            cmd.Parameters.AddWithValue("@GRP4_P3", GRP4_P3)
            cmd.Parameters.AddWithValue("@GRP5_SELECT", GRP5_SELECT.ToUpper)
            cmd.Parameters.AddWithValue("@GRP5_P1", GRP5_P1)
            cmd.Parameters.AddWithValue("@GRP5_P2", GRP5_P2)
            cmd.Parameters.AddWithValue("@GRP5_P3", GRP5_P3)
            cmd.Parameters.AddWithValue("@type ", type)

            cmd.ExecuteNonQuery()

            cmd.Transaction.Commit()
            MsgBox("Record Saved!")
        Catch ex As Exception
            cmd.Transaction.Rollback()
            MsgBox("Error saving! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    Public Sub calc_average(eid As Integer, cls As String, clsyr As Integer)
        Try
            Openconn()
            cmd = New SqlCommand("[calculate_average]", sqlconn)
            ' cmd.Transaction = cmd.Connection.BeginTransaction
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@eid", eid)
            cmd.Parameters.AddWithValue("@cls", cls)
            cmd.Parameters.AddWithValue("@year", clsyr)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            ' cmd.Transaction.Rollback()
            MsgBox("Error during operation! " & ex.Message)
        Finally
            closeconn()
        End Try
    End Sub
    
End Module
