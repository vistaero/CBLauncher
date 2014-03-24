Imports System.IO
Imports IWshRuntimeLibrary

Public Class Form1


    Dim PathJavaw As String = "C:\Program Files\Java\jre7\bin\javaw.exe"
    Dim output As String
    Dim serverprocess As New Process()
    Dim log As String
    Dim JarPath As String = ""
    Dim JarFolder As String
    Dim IsStarted As Boolean = False

    Private Function CheckJavaw(ByVal download As Boolean)
        Dim ExistsJavaw As Boolean = System.IO.File.Exists(PathJavaw)
        If ExistsJavaw = False And download = True Then
            MessageBox.Show("Java is not installed.", "Java not found")
            Process.Start("https://www.java.com/es/download/")
        End If
        If ExistsJavaw = False Then
            Return (False)
        Else
            Return (True)
        End If

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BackgroundWorker1.IsBusy Then
            OutPutTextBox.Text = log
            OutPutTextBox.Select(OutPutTextBox.TextLength, 0)
            OutPutTextBox.ScrollToCaret()
        Else
            StopButton.Enabled = False
            ForceStopButton.Enabled = False
            PauseLogToolStripMenuItem.Enabled = False
            StartButton.Enabled = True
            SelectJarButton.Enabled = True
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Do
                output = serverprocess.StandardOutput.ReadLine()
                If Not output.ToString.Length < 1 Then
                    log += output & vbNewLine
                End If
            Loop
        Catch ex As Exception
            BackgroundWorker1.Dispose()
            IsStarted = False
        End Try
    End Sub

    Private Sub StopServer(ByVal forzado As Boolean)
        Try
            Select Case forzado
                Case True
                    serverprocess.Kill()
                Case False
                    serverprocess.StandardInput.WriteLine("stop")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IsStarted = True Then
            Dim reply As DialogResult = MessageBox.Show("You should click Stop before exit. Are you sure?", "Click Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Select Case reply
                Case Windows.Forms.DialogResult.Yes
                    StopServer(True)
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub InputTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputTextBox.KeyDown
        If e.KeyCode = Keys.Enter And IsStarted = True Then
            e.SuppressKeyPress = True
            serverprocess.StandardInput.WriteLine(InputTextBox.Text)
            InputTextBox.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartServer(MemoryText.Text)

    End Sub

    Private Sub StartServer(ByVal memory As String)
        If CheckJavaw(False) = True Then
            Try
                serverprocess.StartInfo.RedirectStandardOutput = True
                serverprocess.StartInfo.RedirectStandardInput = True
                serverprocess.StartInfo.FileName = PathJavaw
                serverprocess.StartInfo.Arguments = "-Xmx" & memory & "M -jar " & """" & JarPath & """"
                serverprocess.StartInfo.UseShellExecute = False
                serverprocess.StartInfo.CreateNoWindow = True
                serverprocess.StartInfo.WorkingDirectory = JarFolder
                serverprocess.Start()
                My.Settings.LastJavawPID = serverprocess.Id
                My.Settings.Save()
                BackgroundWorker1.RunWorkerAsync()
                Timer1.Enabled = True
                IsStarted = True
                StopButton.Enabled = True
                ForceStopButton.Enabled = True
                StartButton.Enabled = False
                PauseLogToolStripMenuItem.Enabled = True
                SelectJarButton.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("You have not installed Java yet.")
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StopServer(False)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ForceStopButton.Click
        StopServer(True)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles SelectJarButton.Click
        Dim Dialog As New OpenFileDialog
        Dialog.Filter = "Java Files|*.jar"
        Dialog.InitialDirectory = My.Settings.DefaultJarPath
        Dialog.ShowDialog()
        JarPath = Dialog.FileName
        If Not JarPath = "" Then
            JarFolder = JarPath.Replace(Dialog.SafeFileName, "")
            JarPathText.Text = JarPath
            If IsStarted = False Then
                StartButton.Enabled = True
            End If
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'AboutBox1.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim processlist As Object = Process.GetProcesses
        For Each process As Process In processlist
            Dim Process2 As String = process.Id
            If Process2.Equals(My.Settings.LastJavawPID) Then
                MessageBox.Show("The last server you launched (with " & My.Settings.LastJavawPID & " PID) with this application was not stopped. Probably due to a crash of the launcher. And probably the server is frozen. The only thing you (and us) can do, is killing the process." & vbNewLine & vbNewLine & "Let's go?", "Oups, we are so sorry...", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                process.Kill()
            End If
        Next


        CheckJavaw(True)
        If My.Application.CommandLineArgs.Count > 0 Then
            MemoryText.Text = My.Application.CommandLineArgs.First
            JarPath = Path.GetFullPath(My.Application.CommandLineArgs.Last)
            JarFolder = Path.GetDirectoryName(JarPath)
            JarPathText.Text = JarPath
            If System.IO.File.Exists(JarPath) Then
                StartServer(MemoryText.Text)
            End If
        End If
    End Sub

    Private Sub PauseLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseLogToolStripMenuItem.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        OutPutTextBox.Clear()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not JarPath.Equals("") Then
            Dim SaveShortCutDialog As New SaveFileDialog
            SaveShortCutDialog.Filter = "Shortcut|*.lnk"
            SaveShortCutDialog.InitialDirectory = My.Settings.DefaultShortcutPath
            SaveShortCutDialog.ShowDialog()
            Try
                If Not SaveShortCutDialog.FileName.Equals("") Then CreateShortCut(Application.ExecutablePath, System.IO.Path.GetDirectoryName(SaveShortCutDialog.FileName), System.IO.Path.GetFileName(SaveShortCutDialog.FileName))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("You have not selected any Jar.", "Can not create shortcut", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Dim oShell2 As WshShell 'import IWshRuntimeLibrary 'Project > Add Reference > COM > Windows Script Host Object Model.

    Private Function CreateShortCut(TargetName As String, ShortCutPath As String, ShortCutName As String) As Boolean
        Dim oShell As Object
        Dim oLink As Object

        oShell = CreateObject("WScript.Shell")

        oLink = oShell.CreateShortcut(ShortCutPath & "\" & ShortCutName & ".lnk")
        oLink.Arguments = MemoryText.Text & " " & JarPathText.Text
        oLink.TargetPath = TargetName
        oLink.WindowStyle = 1
        oLink.Save()


    End Function

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()

    End Sub

    Private Sub InputTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputTextBox.TextChanged

    End Sub
End Class
