
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Sdk.Sfc

Public Class SetServer
    Private strServerName As String
    Private serverNameRetrived As Boolean = False
    Dim myservername As String
    Dim success As Boolean = False
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim servername As String = txtservername.Text
            '  MsgBox(servername)

            Dim myServer As New Server(servername)

            MsgBox("Connection Successful to " & myServer.Information.NetName, MsgBoxStyle.Information)
            myservername = myServer.Name

            success = True
            OK_Button.Enabled = success
        Catch ex As Exception
            MsgBox("connection Failed: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub saveconfiguration()
        'saving server name to a file where it can be accessed
        Try

            Dim fwriter As System.IO.StreamWriter

            If System.IO.File.Exists("serverpath") Then
                System.IO.File.Delete("serverpath")
            End If

            fwriter = System.IO.File.CreateText("serverpath")
            System.IO.File.SetAttributes("serverpath", IO.FileAttributes.Hidden)
            fwriter.WriteLine(myservername)
            fwriter.Flush()
            fwriter.Close()
            If MsgBox("Settings saved successfully, " & vbNewLine & "Application will have to close and be reopened to effect changes, Continue? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Application.Restart()
            Else
                MsgBox("Changes have not been effected, manually close and reopen application for the changes to take effect", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Failed to save: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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

    Private Sub OK_button_Click(sender As System.Object, e As System.EventArgs) Handles OK_button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If success Then
            saveconfiguration()
        Else
            MsgBox("connection is not available. Cannot save the configuration settings", MsgBoxStyle.Critical)
            Application.Exit()
        End If
        Me.Visible = False
    End Sub
End Class