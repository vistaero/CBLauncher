Imports System.IO
Imports IWshRuntimeLibrary
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Text
Imports System.Resources


Public Class Form1

    Dim output As String
    Dim serverprocess As New Process()
    Dim log As String
    Public JarPath As String = ""
    Dim JarFolder As String
    Dim IsStarted As Boolean = False
    Public Favorites As New List(Of Favorite)
    Public NewFavoriteName As String
    Public documentspath As String = (System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) & "\CBLauncher\"
    Private InputHistorial As New List(Of String)
    Dim LocRM As New ResourceManager("CBLauncher.Strings", GetType(Form1).Assembly)



    Private Sub AddFavoriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFavoriteToolStripMenuItem.Click
        Dim Exists As Boolean = False
        For Each Favorite In Favorites
            If Favorite.FavPath.Equals(JarPath) Then
                MessageBox.Show(LocRM.GetString("FavoriteExists") & """" & Favorite.FavName & """" & ".")
                Exists = True

                Exit For
            End If

        Next

        If Exists = False Then
            If Not JarPath.Equals("") Then
                Dim Nuevo As Boolean = True
                Select Case Nuevo
                    Case True
                        Dim FavWindow As New Form
                        Dim FavWindowContent As New AddFavorite

                        FavWindow.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                        FavWindow.MaximizeBox = False
                        FavWindow.MinimizeBox = False

                        FavWindow.Controls.Add(FavWindowContent)
                        FavWindowContent.Dock = DockStyle.Fill

                        FavWindow.Size = New Size(300, 130)
                        FavWindow.StartPosition = FormStartPosition.CenterParent
                        FavWindow.ShowDialog()

                    Case False

                        Dim Ventanuco As New AddFavorite
                        Ventanuco.Dock = DockStyle.Fill
                        OutPutTextBox.Hide()
                        Me.OutPutPanel.Controls.Add(Ventanuco)
                        Ventanuco.Show()

                        If ListBox1.Visible = True Then
                            ListBox1.Visible = False
                        End If

                End Select

            End If
        End If



    End Sub

    Public Sub RefreshFavorites()
        Favorites.Clear()
        ListBox1.Items.Clear()

        For Each file In System.IO.Directory.EnumerateFiles(documentspath)
            Dim filepath = Path.GetFullPath(file)
            Dim filename = Path.GetFileNameWithoutExtension(file)
            Dim contenido As Object = System.IO.File.ReadAllText(filepath)
            Dim IsValid As Boolean = True
            Try
                System.IO.Path.GetDirectoryName(contenido)
            Catch ex As Exception
                IsValid = False
            End Try
            If IsValid = True Then
                Dim NewFavorite As New Favorite
                NewFavorite.FavName = filename
                NewFavorite.FavPath = contenido
                Favorites.Add(NewFavorite)
                ListBox1.Items.Add(NewFavorite.FavName)
            Else
                MsgBox("Not valid")
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim processlist As Object = Process.GetProcesses
        For Each process As Process In processlist
            Dim Process2 As String = process.Id
            If Process2.Equals(My.Settings.LastJavawPID) And process.ProcessName.Equals("javaw") Then

                Dim AlertWindow = MessageBox.Show(LocRM.GetString("LastPIDAlert") & process.ProcessName & " (" & My.Settings.LastJavawPID & ").", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

                If AlertWindow = Windows.Forms.DialogResult.Yes Then
                    process.Kill()
                Else
                    My.Settings.LastJavawPID = ""
                End If
            End If
        Next

        CheckJavaw(True)
        If My.Application.CommandLineArgs.Count > 0 Then
            MsgBox("Ruta Jar: " & My.Application.CommandLineArgs.Last & vbNewLine & "Nombre de archivo: " & Path.GetFileName(My.Application.CommandLineArgs.Last))
            SelectJar(My.Application.CommandLineArgs.Last, Path.GetFileName(My.Application.CommandLineArgs.Last))
        End If

        RefreshFavorites()
    End Sub

    Private Function CheckJavaw(ByVal download As Boolean)
        Dim ExistsJavaw As Boolean = System.IO.File.Exists(My.Settings.JavawPath)
        If ExistsJavaw = False And download = True And My.Settings.JavawPath.Equals("C:\Program Files\Java\jre7\bin\javaw.exe") Then
            MessageBox.Show(LocRM.GetString("JavaNotInstalled1"), LocRM.GetString("JavaNotInstalled2"))
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
            Dim Select1 As Integer = OutPutTextBox.SelectionStart
            Dim Select2 As Integer = OutPutTextBox.SelectionLength

            If Not OutPutTextBox.Text.Equals(log) Then
                OutPutTextBox.Text = log
                OutPutTextBox.Select(OutPutTextBox.TextLength, 0)
                OutPutTextBox.ScrollToCaret()
                OutPutTextBox.SelectionStart = Select1
                OutPutTextBox.SelectionLength = Select2
            End If

        Else
            StopButton.Enabled = False
            ForceStopButton.Enabled = False
            StartButton.Enabled = True
            SelectJarButton.Enabled = True
            FavoritesButton.Enabled = True
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
            Dim reply As DialogResult = MessageBox.Show(LocRM.GetString("ShouldClickStop1"), LocRM.GetString("ShouldClickStop2"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Select Case reply
                Case Windows.Forms.DialogResult.Yes
                    StopServer(True)
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private SelectedInputHistorial As Integer = 0

    Private Sub InputTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputTextBox.KeyDown
        If e.KeyCode = Keys.Enter And IsStarted = True Then
            e.SuppressKeyPress = True
            serverprocess.StandardInput.WriteLine(InputTextBox.Text)
            InputHistorial.Add(InputTextBox.Text)
            SelectedInputHistorial = InputHistorial.Count
            InputTextBox.Text = ""
        End If

        If e.KeyCode = Keys.Up Then
            If SelectedInputHistorial > 0 And InputHistorial.Count > 0 Then
                SelectedInputHistorial -= 1
                InputTextBox.Text = InputHistorial(SelectedInputHistorial)
            End If
            InputTextBox.Select(InputTextBox.Text.Length + 1, 0)
        End If

        If e.KeyCode = Keys.Down Then
            If SelectedInputHistorial < (InputHistorial.Count - 1) And InputHistorial.Count > 0 Then
                SelectedInputHistorial += 1
                InputTextBox.Text = InputHistorial(SelectedInputHistorial)
            End If
            InputTextBox.Select(InputTextBox.Text.Count, 0)

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
                serverprocess.StartInfo.FileName = My.Settings.JavawPath
                Select Case My.Settings.AutoArgs
                    Case True
                        serverprocess.StartInfo.Arguments = "-Xmx" & memory & "M -jar " & """" & JarPath & """"
                    Case False
                        serverprocess.StartInfo.Arguments = My.Settings.NonAutoArgsText
                End Select
                serverprocess.StartInfo.UseShellExecute = False
                serverprocess.StartInfo.CreateNoWindow = True
                serverprocess.StartInfo.WorkingDirectory = JarFolder
                serverprocess.Start()
                My.Settings.LastJavawPID = serverprocess.Id
                My.Settings.History += vbNewLine & JarPath
                My.Settings.Save()
                BackgroundWorker1.RunWorkerAsync()
                Timer1.Enabled = True
                IsStarted = True
                StopButton.Enabled = True
                ForceStopButton.Enabled = True
                StartButton.Enabled = False
                SelectJarButton.Enabled = False
                FavoritesButton.Enabled = False
                ListBox1.Visible = False
                OutPutTextBox.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show(LocRM.GetString("NotInstalledJavaYet"))
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
        Dialog.Filter = LocRM.GetString("JarFormat")
        Dialog.InitialDirectory = My.Settings.DefaultJarPath
        Dim reply = Dialog.ShowDialog()
        If reply = Windows.Forms.DialogResult.OK Then
            SelectJar(Dialog.FileName, Dialog.SafeFileName)

        End If


    End Sub

    Private Sub SelectJar(ByVal InputJarPath As String, ByVal InputSafeFileName As String)
        JarPath = InputJarPath
        If Not JarPath = "" Then
            JarFolder = JarPath.Replace(InputSafeFileName, "")
            JarPathText.Text = JarPath
            If IsStarted = False Then
                StartButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        log = ""
        OutPutTextBox.Clear()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim SaveShortCutDialog As New SaveFileDialog
        SaveShortCutDialog.Filter = LocRM.GetString("lnkFormat")
        SaveShortCutDialog.InitialDirectory = My.Settings.DefaultShortcutPath
        SaveShortCutDialog.ShowDialog()
        Try
            If Not SaveShortCutDialog.FileName.Equals("") Then CreateShortCut(Application.ExecutablePath, System.IO.Path.GetDirectoryName(SaveShortCutDialog.FileName), System.IO.Path.GetFileName(SaveShortCutDialog.FileName))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Dim oShell2 As WshShell 'import IWshRuntimeLibrary 'Project > Add Reference > COM > Windows Script Host Object Model.

    Private Function CreateShortCut(TargetName As String, ShortCutPath As String, ShortCutName As String) As Boolean
        Dim oShell As Object
        Dim oLink As Object

        oShell = CreateObject("WScript.Shell")

        oLink = oShell.CreateShortcut(ShortCutPath & "\" & ShortCutName & ".lnk")
        oLink.Arguments = MemoryText.Text & " " & """" & JarPathText.Text & """"
        oLink.TargetPath = TargetName
        oLink.WindowStyle = 1
        oLink.Save()

    End Function

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()

    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(LocRM.GetString("About"), LocRM.GetString("AboutTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "http://github.com/vistaero")

    End Sub

    Private Sub DownloadCraftBukkitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadCraftBukkitToolStripMenuItem.Click
        VersionEditor.ShowDialog()

    End Sub

    Private Sub JarPathText_TextChanged(sender As Object, e As EventArgs) Handles JarPathText.TextChanged
        If Not JarPathText.Text.Equals("") Then
            AddFavoriteToolStripMenuItem.Enabled = True
            ToolStripMenuItem1.Enabled = True
        Else
            AddFavoriteToolStripMenuItem.Enabled = False
            ToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            MsgBox(ListBox1.SelectedIndex)
            IO.File.Delete(documentspath & ListBox1.SelectedItem & ".cblfav")
            RefreshFavorites()

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            For Each item As Favorite In Favorites
                If item.FavName.Equals(ListBox1.SelectedItem.ToString) Then
                    SelectJar(item.FavPath, Path.GetFileName(item.FavPath))
                End If
            Next
        End If

    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles FavoritesButton.Click
        Select Case OutPutTextBox.Visible
            Case True
                OutPutTextBox.Visible = False
                ListBox1.Visible = True
            Case False
                OutPutTextBox.Visible = True
                ListBox1.Visible = False
        End Select

    End Sub

    Private Sub OutPutTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles OutPutTextBox.KeyDown
        InputTextBox.Focus()
        Try
            keybd_event(e.KeyCode, "0", "0", "0")
        Catch ex As Exception

        End Try

    End Sub

    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)


    Private Sub OutPutTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles OutPutTextBox.MouseDown
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub OutPutTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles OutPutTextBox.MouseUp
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub CopyAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllToolStripMenuItem.Click
        Clipboard.SetText(OutPutTextBox.Text)
    End Sub

End Class
