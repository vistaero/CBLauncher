Imports System.Windows.Forms
Imports System.IO

Public Class DownloadBuild

    Dim wc As New System.Net.WebClient
    Dim FileName
    Dim FileToDownload
    Private LatestVersionFolder As String
    Private LatestVersionFile As String
    Private UrlDownload

    Private Sub FileURLCalculator_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FileURLCalculator.DoWork
        Dim CraftBukkitUrl As String = "http://repo.bukkit.org/content/groups/public/org/bukkit/craftbukkit/"
        FileToDownload = CraftBukkitUrl & "maven-metadata.xml"
        FileName = "maven-metadata.xml"
        wc = New System.Net.WebClient()
        AddHandler wc.DownloadProgressChanged, AddressOf OnDownloadProgressChanged
        AddHandler wc.DownloadFileCompleted, AddressOf OnFileDownloadCompleted
        Try
            wc.DownloadFile(New Uri(FileToDownload), Form1.documentspath & "\versions\temp\" & FileName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim xmlfile As Object = System.IO.File.ReadAllLines(Form1.documentspath & "\versions\temp\" & "maven-metadata.xml")
        For Each line As String In xmlfile
            If line.StartsWith("    <latest>") Then
                Dim line2 As String
                Dim line2l As Integer
                line2 = line.Remove(0, 12)
                line2l = line2.Count - 9
                line2 = line2.Remove(line2l, 9)
                LatestVersionFolder = line2
            End If
        Next

        Dim Url1 As String = CraftBukkitUrl & "/" & LatestVersionFolder & "/" & FileName
        wc.DownloadFile(New Uri(Url1), Form1.documentspath & "\versions\temp\" & FileName & "2")
        wc.Dispose()
        Dim xmlfile2 As Object = System.IO.File.ReadAllLines(Form1.documentspath & "\versions\temp\" & "maven-metadata.xml2")
        For Each line As String In xmlfile2
            If line.StartsWith("        <value>") Then
                Dim line2 As String
                Dim line2l As Integer
                line2 = line.Remove(0, 15)
                line2l = line2.Count - 8
                line2 = line2.Remove(line2l, 8)
                LatestVersionFile = line2
            End If
        Next

        UrlDownload = CraftBukkitUrl & LatestVersionFolder & "/craftbukkit-" & LatestVersionFile & ".jar"

        Intermediario()
    End Sub

    Private Sub OnDownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Dim totalSize As Long = e.TotalBytesToReceive
        Dim downloadedBytes As Long = e.BytesReceived
        Dim percentage As Integer = e.ProgressPercentage
        ProgressBar1.Value = percentage
        'Put your progress UI here, you can cancel download by uncommenting the line below
        'wc.CancelAsync()
    End Sub

    Private Sub OnFileDownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        If e.Cancelled Then
            'Cancelled
            DownloadError()

            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
        ElseIf Not e.Error Is Nothing Then
            'Error occured
            DownloadError()
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
        Else
            'File Downloaded Successfuly
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            ListVersions()

        End If





    End Sub

    Private Sub DownloadError()
        Try
            System.IO.File.Delete(Form1.documentspath & "versions\" & LatestVersionFile & ".jar")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Intermediario()
        If InvokeRequired Then
            Invoke(Sub() DownloadBuild())
        Else
            DownloadBuild()

        End If
    End Sub

    Private Sub DownloadBuild()

        Dim SavePath As String = Form1.documentspath & "\versions\" & LatestVersionFile & ".jar"
        Dim Updated As Boolean = System.IO.File.Exists(SavePath)
        Select Case Updated
            Case True
                MessageBox.Show(Form1.LocRM.GetString("CBUpdated1"), Form1.LocRM.GetString("CBUpdated2"), MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case False
                Try
                    wc.CancelAsync()
                    wc.Dispose()
                    wc.DownloadFileAsync(New Uri(UrlDownload), SavePath)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    wc.Dispose()
                End Try

                ProgressBar1.Visible = True
        End Select

    End Sub


    Private Sub VersionEditor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not wc Is Nothing Then
            wc.CancelAsync()
            Try
                System.IO.Directory.Delete(Form1.documentspath & "versions\temp", True)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Dispose()

        End If

    End Sub

    Private Sub VersionEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListVersions()
    End Sub

    Private Sub ListVersions()
        Dim fileNames() As String
        Dim result As String
        If Not System.IO.Directory.Exists(Form1.documentspath & "\versions\temp") Then
            System.IO.Directory.CreateDirectory(Form1.documentspath & "\versions\temp")
        End If
        fileNames = System.IO.Directory.GetFiles(Form1.documentspath & "\versions")
        For Each file In fileNames
            result = Path.GetFileNameWithoutExtension(file)
            If Not ListBox1.Items.Contains(result) Then
                ListBox1.Items.Add(result)
            End If
        Next
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim couldbedeleted As Boolean
        Try
            System.IO.File.Delete(Form1.documentspath & "\versions\" & ListBox1.SelectedItem & ".jar")
            couldbedeleted = True
        Catch ex As Exception
            MsgBox(ex.Message)
            couldbedeleted = False
        End Try
        Select Case couldbedeleted
            Case True
                ListBox1.Items.Remove(ListBox1.SelectedItem)
        End Select
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        If FileURLCalculator.IsBusy = False Then
            FileURLCalculator.RunWorkerAsync()
        End If

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim CopyJar As New SaveFileDialog
        CopyJar.Title = Form1.LocRM.GetString("WhereCopy") & ListBox1.SelectedItem
        CopyJar.FileName = ListBox1.SelectedItem
        CopyJar.Filter = Form1.LocRM.GetString("JarFormat")
        CopyJar.ShowDialog()
        System.IO.File.Copy(Form1.documentspath & "\versions\" & ListBox1.SelectedItem & ".jar", CopyJar.FileName)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            RemoveToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
            UpdateToolStripMenuItem.Enabled = False
        Else
            CopyToolStripMenuItem.Enabled = True
            RemoveToolStripMenuItem.Enabled = True
            UpdateToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim CopyJar As New OpenFileDialog

        CopyJar.Title = Form1.LocRM.GetString("SelectJar")
        CopyJar.Filter = "JAR|*.jar"
        CopyJar.ShowDialog()

        If Not CopyJar.FileName.Equals("") Then
            Try
                System.IO.File.Copy(CopyJar.FileName, Form1.documentspath & "\versions\" & CopyJar.SafeFileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ListVersions()
        End If


    End Sub

    Private Sub UpdateToThisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim Remove As String
        Dim Removed As Boolean
        Try
            Remove = Form1.JarFolder & Path.GetFileName(Form1.JarPath)
            System.IO.File.Delete(Remove)
            Dim Dest As String = Form1.JarFolder & ListBox1.SelectedItem & ".jar"
            System.IO.File.Copy(Form1.documentspath & "\versions\" & ListBox1.SelectedItem & ".jar", Form1.JarFolder & ListBox1.SelectedItem & ".jar")
            Form1.SelectJar(Dest)
            Removed = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Removed = True Then
            For Each Favorite In Form1.Favorites
                If Favorite.FavPath = Remove Then
                    System.IO.File.WriteAllText(Form1.documentspath & Favorite.FavName & ".cblfav", Form1.JarPath)
                    MessageBox.Show(Form1.LocRM.GetString("UpdatedCorrectly"), Form1.LocRM.GetString("Done"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                End If
            Next
        End If

    End Sub
End Class