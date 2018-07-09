Imports System.Windows.Forms

Public Class main_startpage

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber

        ''ChildForm.Show()
        MarksEntry_Normal.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Marks_Entry_full_paper.Show()
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ContentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Add_Stream.ShowDialog()
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Add_Subjects.ShowDialog()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Add_Student.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Add_Exam.ShowDialog()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        SetServer.ShowDialog()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub ExamReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExamReportsToolStripMenuItem.Click
        ''demoreport.Show()
        Exam_Report.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub ExamToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExamToolStripMenuItem.Click
        Manage_Exams.ShowDialog()
    End Sub

    Private Sub StreamsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StreamsToolStripMenuItem.Click
        manage_streams.ShowDialog()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        manage_students.ShowDialog()
    End Sub

    Private Sub TermlyExamReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TermlyExamReportToolStripMenuItem.Click
        Termly_report.ShowDialog()
    End Sub
End Class
