﻿Imports System.IO
Imports System.Text
Imports System.Resources
Imports System.Media
Imports System.Threading
Imports System.Globalization
Imports System.IO.Compression

Public Class Form1

    Private serverprocess As New Process()
    Public JarPath As String = ""
    Public JarFolder As String
    Private RunWithDefaultJar As Boolean = False
    Public Favorites As New List(Of Favorite)
    Public documentspath As String = (System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) & "\CBLauncher\"
    Private InputHistorial As New List(Of String)
    Public LocRM As New ResourceManager("CBLauncher.Strings", GetType(Form1).Assembly)
    Private TextBuffer As String = ""
    Private Delegate Sub DelegateUpdateStatus(ByVal statusText As String)
    Private ShouldExitWhenBackgroundWorkerEnds As Boolean
    Private SelectedInputHistorial As Integer = 0
    Private SelectingText As Boolean = False
    Private SelectionStart As Integer
    Private SelectionLenght As Integer
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Private Sub LoadInEnglish()
        Dim targetCulture As String = "en-US"
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(targetCulture)
        Me.Controls.Clear()
        InitializeComponent()
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
            If IO.File.Exists(My.Application.CommandLineArgs.Last) Or IO.Directory.Exists(My.Application.CommandLineArgs.Last.Replace("""", "")) Then
                SelectJar(My.Application.CommandLineArgs.Last, False)
                MemoryText.Text = My.Application.CommandLineArgs.First
                StartServer(MemoryText.Text)
            Else
                MessageBox.Show(LocRM.GetString("NotFound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MemoryText.Text = My.Settings.DefaultMaxMemory
        End If
        EasterEgg()
        CheckIfShowMaxMemory()

        If Not Directory.Exists(documentspath) Then
            Directory.CreateDirectory(documentspath)
        End If
        RefreshFavorites()
    End Sub

    Public Sub CheckIfShowMaxMemory()
        If My.Settings.ShowMaxMemory = False Then
            MaxMemoryLabel.Visible = False
            MemoryText.Visible = False
        Else
            MaxMemoryLabel.Visible = True
            MemoryText.Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do
            Dim output As String = serverprocess.StandardOutput.ReadLine()

            If output.Length <> 0 Then

                If SelectingText = False Then
                    If Not TextBuffer.Equals("") Then
                        Invoke(Sub() OutPutTextBox.AppendText(TextBuffer))
                        TextBuffer = ""
                        Invoke(Sub() OutPutTextBox.ScrollToCaret())
                    End If
                    Invoke(Sub() OutPutTextBox.AppendText(output & vbNewLine))
                Else
                    TextBuffer += output & vbNewLine
                End If

            End If
        Loop

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BackgroundWorker1.Dispose()
        If ShouldExitWhenBackgroundWorkerEnds = True Then
            Environment.Exit(0)
        End If
        StopButton.Enabled = False
        ForceStopButton.Enabled = False
        StartButton.Enabled = True
        SelectJarButton.Enabled = True
        FavoritesButton.Enabled = True
        Reload.Enabled = False
        StatusCircle.ForeColor = Color.Orange
    End Sub

    Public Sub SelectJar(ByVal InputJarPath As String, ByVal defaultjar As Boolean)

        If System.IO.Directory.Exists(InputJarPath) = True Then
            If defaultjar = True Then
                JarFolder = InputJarPath
                JarPathText.Text = JarFolder
                StatusCircle.ForeColor = Color.Orange
                ExtrasToolStripMenuItem.Enabled = True
                UpdateCraftbukkitToolStripMenuItem.Enabled = False
                RunWithDefaultJar = True
                If BackgroundWorker1.IsBusy = False Then
                    StartButton.Enabled = True
                End If
            Else
                SelectByFolder(InputJarPath)
            End If
        ElseIf System.IO.File.Exists(InputJarPath) Then
            JarPath = InputJarPath
            If Not JarPath = "" Then
                JarFolder = JarPath.Replace(Path.GetFileName(InputJarPath), "")
                JarPathText.Text = JarPath
                StatusCircle.ForeColor = Color.Orange
                ExtrasToolStripMenuItem.Enabled = True
                UpdateCraftbukkitToolStripMenuItem.Enabled = True
                RunWithDefaultJar = False
                If BackgroundWorker1.IsBusy = False Then
                    StartButton.Enabled = True
                End If
            End If
        End If





    End Sub

    Private Function SearchJar(ByVal Path As String)

        Dim Files = IO.Directory.GetFiles(Path)
        Dim FilesList As New List(Of String)

        For Each file In Files
            If file.EndsWith("-cblauncher.jar") Then
                Dim Result As New List(Of String)
                Result.Add(file)
                Return Result
            End If
            If file.EndsWith(".jar") Then
                FilesList.Add(file)
            End If
        Next

        If FilesList.Count = 1 Then
            Dim Result As New List(Of String)
            Result.Add(FilesList(0))
            Return Result
        ElseIf FilesList.Count > 1 Then
            Return FilesList

        End If
        FilesList.Clear()
        Return FilesList

    End Function

    Private Sub StartServer(ByVal memory As String)
        If CheckJavaw(False) = True Then

            If Not IO.File.Exists(JarFolder & "\" & "server.properties") Then
                Dim reply = MessageBox.Show(LocRM.GetString("NoServerProps1"), LocRM.GetString("NoServerProps2"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If reply = Windows.Forms.DialogResult.Yes Then
                    PropertiesWindow.ShowDialog()
                End If
            End If

            ' /////////
            ' IT STARTS
            ' /////////
            serverprocess.StartInfo.RedirectStandardOutput = True
            serverprocess.StartInfo.RedirectStandardInput = True
            serverprocess.StartInfo.RedirectStandardError = True
            serverprocess.StartInfo.FileName = My.Settings.JavawPath
            Select Case My.Settings.AutoArgs
                Case True
                    If RunWithDefaultJar = False Then
                        serverprocess.StartInfo.Arguments = "-Xmx" & memory & "M -jar " & """" & JarPath & """"
                    Else
                        serverprocess.StartInfo.Arguments = "-Xmx" & memory & "M -jar " & """" & documentspath & "versions\" & My.Settings.DefaultCraftBukkitPath & ".jar" & """"

                    End If
                Case False
                    serverprocess.StartInfo.Arguments = My.Settings.NonAutoArgsText
            End Select
            serverprocess.StartInfo.UseShellExecute = False
            serverprocess.StartInfo.CreateNoWindow = True
            serverprocess.StartInfo.WorkingDirectory = JarFolder
            serverprocess.Start()
            BackgroundWorker1.RunWorkerAsync()
            My.Settings.LastJavawPID = serverprocess.Id
            If Not My.Settings.History.Contains(JarPath) Then My.Settings.History += vbNewLine & JarPath
            My.Settings.Save()
            StopButton.Enabled = True
            ForceStopButton.Enabled = True
            StartButton.Enabled = False
            SelectJarButton.Enabled = False
            FavoritesButton.Enabled = False
            Reload.Enabled = True
            ListBox1.Visible = False
            OutPutTextBox.Visible = True
            StatusCircle.ForeColor = Color.Green

        Else
            MessageBox.Show(LocRM.GetString("NotInstalledJavaYet"))
        End If
    End Sub

    Private Sub StopServer(ByVal Forced As Boolean)
        Try
            Select Case Forced
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
        If BackgroundWorker1.IsBusy = True Then
            If My.Settings.AskBeforeExit = True Then
                Dim reply As DialogResult = MessageBox.Show(LocRM.GetString("ShouldClickStop1"), LocRM.GetString("AreYouSure"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Select Case reply
                    Case Windows.Forms.DialogResult.Yes
                        ShouldExitWhenBackgroundWorkerEnds = True
                        Select Case My.Settings.ForceStop
                            Case True
                                e.Cancel = True
                                StopServer(True)
                            Case False
                                e.Cancel = True
                                StopServer(False)
                        End Select
                    Case Windows.Forms.DialogResult.No
                        e.Cancel = True
                End Select
            Else
                ShouldExitWhenBackgroundWorkerEnds = True
                Select Case My.Settings.ForceStop
                    Case True
                        e.Cancel = True
                        StopServer(True)
                    Case False
                        e.Cancel = True
                        StopServer(False)
                End Select
            End If

        End If
    End Sub

    Private Sub EasterEgg()

        If My.Computer.Clock.LocalTime.Month = 1 And My.Computer.Clock.LocalTime.Day = 1 Then
            Me.Text = "Happy " & My.Computer.Clock.LocalTime.Year & "!"
            HuevoToolStripMenuItem.Visible = True
        End If

        If My.Computer.Clock.LocalTime.Month = 12 And My.Computer.Clock.LocalTime.Day = 13 Then
            Me.Text = "Happy birthday, vistaero!"
            HuevoToolStripMenuItem.Visible = True
        End If

        If My.Computer.Clock.LocalTime.Month = 4 And My.Computer.Clock.LocalTime.Day = 1 Then
            Me.Text = "Space Rocket Launcher"
            HuevoToolStripMenuItem.Visible = True
        End If

        If My.Computer.Clock.LocalTime.Month = 7 And My.Computer.Clock.LocalTime.Day = 23 Then
            Me.Text = "Happy birthday Dinnerbone!"
            HuevoToolStripMenuItem.Visible = True
        End If

        If My.Computer.Clock.LocalTime.Month = 5 And My.Computer.Clock.LocalTime.Day = 18 Then
            Me.Text = "Happy birthday Jeb!"
            HuevoToolStripMenuItem.Visible = True
        End If

    End Sub

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

                Dim FavWindow As New Form
                Dim FavWindowContent As New AddFavorite
                FavWindowContent.Dock = DockStyle.Fill
                With FavWindow
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                    .MaximizeBox = False
                    .MinimizeBox = False
                    .Controls.Add(FavWindowContent)
                    .ShowInTaskbar = False
                    .ShowIcon = False
                    .Size = New Size(320, 105)
                    .StartPosition = FormStartPosition.CenterParent
                    .Text = LocRM.GetString("HowToNameIt")
                    .ShowDialog()
                End With

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
            End If
        Next
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

    Private Sub InputTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputTextBox.KeyDown

        If e.KeyCode = Keys.Enter And BackgroundWorker1.IsBusy = True Then
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

        If e.KeyCode = Keys.Escape Then
            InputTextBox.Clear()
        End If

        If e.KeyCode = Keys.H And e.Control = True Then
            MsgBox(My.Settings.History)

        End If

        If e.KeyCode = Keys.J And e.Control = True Then
            e.SuppressKeyPress = True

            My.Settings.History = ""
            My.Settings.Save()
            MessageBox.Show("Historial cleared", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If e.KeyCode = Keys.E And e.Control = True Then
            e.SuppressKeyPress = True
            LoadInEnglish()

        End If

    End Sub

    Private Sub OutPutTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles OutPutTextBox.MouseDown
        SelectingText = True
    End Sub

    Private Sub OutPutTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles OutPutTextBox.MouseUp
        SelectionStart = OutPutTextBox.SelectionStart
        SelectionLenght = OutPutTextBox.SelectionLength

        SelectingText = False
        If Not TextBuffer.Equals("") Then
            OutPutTextBox.Text += TextBuffer
            TextBuffer = ""
        End If
    End Sub

    Private Sub InputTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles InputTextBox.KeyUp
        InputTextBox.Select(InputTextBox.Text.Length + 1, 0)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartServer(MemoryText.Text)

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StopServer(False)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ForceStopButton.Click
        StopServer(True)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        OutPutTextBox.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim SaveShortCutDialog As New SaveFileDialog
        SaveShortCutDialog.Filter = LocRM.GetString("lnkFormat")
        SaveShortCutDialog.InitialDirectory = My.Settings.DefaultShortcutPath
        Dim fi As New IO.FileInfo(JarPath)
        SaveShortCutDialog.FileName = fi.Directory.Name
        SaveShortCutDialog.ShowDialog()
        Try
            If Not SaveShortCutDialog.FileName.Equals("") Then
                CreateShortCut(Application.ExecutablePath, System.IO.Path.GetDirectoryName(SaveShortCutDialog.FileName), _
                               System.IO.Path.GetFileName(SaveShortCutDialog.FileName))

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Dim oShell2 As WshShell 'import IWshRuntimeLibrary 'Project > Add Reference > COM > Windows Script Host Object Model.

    Private Function CreateShortCut(TargetName As String, ShortCutPath As String, ShortCutName As String) As Boolean
        Dim oShell As Object
        Dim oLink As Object
        oShell = CreateObject("WScript.Shell")
        oLink = oShell.CreateShortcut(ShortCutPath & "\" & ShortCutName)
        Dim Arguments As String = MemoryText.Text & " " & """" & JarPath.Replace(System.IO.Path.GetFileName(JarPath), "") & """"
        Arguments = Arguments.Remove(Arguments.Length - 2, 1)
        MsgBox(Arguments)
        oLink.Arguments = Arguments
        oLink.TargetPath = TargetName
        oLink.WindowStyle = 1
        oLink.Save()
        Return True

    End Function

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(LocRM.GetString("About"), LocRM.GetString("AboutTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "http://github.com/vistaero")

    End Sub

    Private Sub DownloadCraftBukkitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadCraftBukkitToolStripMenuItem.Click
        DownloadBuild.ShowDialog()

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

    Private Sub OutPutTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutPutTextBox.TextChanged
        If Not SelectingText = True Or OutPutTextBox.SelectionLength > 0 Then
            OutPutTextBox.SelectionStart = OutPutTextBox.TextLength
            OutPutTextBox.SelectionLength = 0
            If SelectionStart > 0 Or SelectionLenght > 0 Then
                OutPutTextBox.SelectionStart = SelectionStart
                OutPutTextBox.SelectionLength = SelectionLenght
            End If

        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If SelectionStart = 0 And SelectionLenght = 0 Then OutPutTextBox.ScrollToCaret()
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            IO.File.Delete(documentspath & ListBox1.SelectedItem & ".cblfav")
            RefreshFavorites()

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            For Each item As Favorite In Favorites
                If item.FavName.Equals(ListBox1.SelectedItem.ToString) Then
                    SelectJar(item.FavPath, False)
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
        If Not e.KeyCode = Keys.ControlKey Then
            InputTextBox.Focus()
            Try
                keybd_event(e.KeyCode, "0", "0", "0")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CopyAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllToolStripMenuItem.Click
        Clipboard.SetText(OutPutTextBox.Text)
    End Sub

    Private Sub HuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuevoToolStripMenuItem.Click
        Me.Text = "CraftBukkit Launcher"
        HuevoToolStripMenuItem.Visible = False
    End Sub

    Private Sub EditPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPropertiesToolStripMenuItem.Click
        PropertiesWindow.ShowDialog()

    End Sub

    '/////////////////////////
    'FONT STYLE MENU
    '/////////////////////////

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        ' Dim color As Color = System.Drawing.ColorTranslator.FromHtml("#EEEEEE")

        Dim console As New Font("Lucida Console", 8.25, FontStyle.Bold)
        With OutPutTextBox
            .Font = console
            .ForeColor = Color.LightGray
            .BackColor = Color.Black
        End With
        With InputTextBox
            .Font = console
            .ForeColor = Color.LightGray
            .BackColor = Color.Black
        End With
    End Sub

    Private Sub PersonalizedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        InputTextBox.ForeColor = ColorDialog1.Color
        OutPutTextBox.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        OutPutTextBox.Font = FontDialog1.Font
        InputTextBox.Font = FontDialog1.Font
    End Sub

    Private Sub ChangeBackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackcolorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        InputTextBox.BackColor = ColorDialog1.Color
        OutPutTextBox.BackColor = ColorDialog1.Color

    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        Dim Logswindow As New Logs
        Logswindow.Show()

    End Sub

    Private Sub RegenerateWorldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegenerateWorldToolStripMenuItem.Click
        Dim reply = MessageBox.Show(LocRM.GetString("RegenerateWorld"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If reply = Windows.Forms.DialogResult.Yes Then
            If BackgroundWorker1.IsBusy = True Then StopServer(False)
            Worlds.ShowDialog()

        End If

    End Sub

    Private Sub UpdateCraftbukkitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCraftbukkitToolStripMenuItem.Click
        Dim ChangeBuild As New DownloadBuild
        ChangeBuild.RemoveToolStripMenuItem.Visible = False
        ChangeBuild.AddToolStripMenuItem.Visible = False
        ChangeBuild.CopyToolStripMenuItem.Visible = False
        ChangeBuild.SetAsDefaultToolStripMenuItem.Visible = False
        ChangeBuild.UpdateToolStripMenuItem.Visible = True
        ChangeBuild.ShowDialog()
        RefreshFavorites()

    End Sub

    Private Sub SelectByFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectByFileToolStripMenuItem.Click
        Dim Dialog As New OpenFileDialog
        Dialog.Filter = LocRM.GetString("JarFormat")
        Dialog.InitialDirectory = My.Settings.DefaultJarPath
        Dim reply = Dialog.ShowDialog()
        If reply = Windows.Forms.DialogResult.OK Then
            SelectJar(Dialog.FileName, False)
        End If
    End Sub

    Private Sub SelectByFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectByFolderToolStripMenuItem.Click
        SelectByFolder()

    End Sub

    Private Sub SelectByFolder(Optional ByVal path As String = "")
        Dim OpenByFolder As New FolderBrowserDialog

        If Not path.Length > 0 Then
            OpenByFolder.ShowNewFolderButton = False
            OpenByFolder.ShowDialog()
            path = OpenByFolder.SelectedPath
        End If

        If path <> Nothing Then


            If My.Settings.DefaultJar = False Then


                Dim Result As New List(Of String)

                Result = SearchJar(path)

                Select Case Result.Count
                    Case Is = 0
                        MessageBox.Show(LocRM.GetString("CBNotFound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case Is = 1
                        Dim filepath As String = Result(0)
                        SelectJar(filepath, False)
                    Case Is > 1
                        MessageBox.Show(LocRM.GetString("SelectOneCB"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim ListOfJarsWindow As New ListOfJars

                        For Each item In Result
                            ListOfJarsWindow.ListBox1.Items.Add(System.IO.Path.GetFileName(item))
                        Next

                        ListOfJarsWindow.ShowDialog()
                        Dim Dest As String = path & "\" & System.IO.Path.GetFileNameWithoutExtension(path & "\" & ListOfJarsWindow.ListBox1.SelectedItem) & "-cblauncher.jar"
                        System.IO.File.Move(path & "\" & ListOfJarsWindow.ListBox1.SelectedItem, Dest)
                        SelectJar(Dest, False)
                        RunWithDefaultJar = False
                End Select
            Else
                SelectJar(path, True)
                RunWithDefaultJar = True
            End If

        End If
    End Sub

    Private Sub OpenServerFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenServerFolderToolStripMenuItem.Click
        Process.Start(JarFolder)
    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles Reload.Click
        serverprocess.StandardInput.WriteLine("reload")
    End Sub

    Private Sub RunMinecraftToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RunMinecraftToolStripMenuItem.Click
        If Not My.Settings.MinecraftPath.Equals("") Then
            Process.Start(My.Settings.MinecraftPath)
        Else
            Dim MinecraftPath As New OpenFileDialog
            MinecraftPath.ShowDialog()
            My.Settings.MinecraftPath = MinecraftPath.FileName
            Process.Start(My.Settings.MinecraftPath)
        End If
    End Sub

    Private Sub ManagePlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePlayersToolStripMenuItem.Click
        Form2.ShowDialog()

    End Sub

    Private Sub ConfigToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Config.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Config.ShowDialog()

    End Sub
End Class
