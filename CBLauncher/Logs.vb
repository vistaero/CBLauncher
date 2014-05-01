Imports System.IO
Imports System.IO.Compression

Public Class Logs


    Private JarFolder = Form1.JarFolder

    Private Sub Logs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each item In ListBox1.Items
            System.IO.File.Delete(JarFolder & "\logs\" & item)
        Next
        Me.Dispose()

    End Sub

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim directoryPath As String = JarFolder & "\logs"
        If System.IO.Directory.Exists(directoryPath) Then
            Dim directorySelected As DirectoryInfo = New DirectoryInfo(directoryPath)

            For Each fileToDecompress As FileInfo In directorySelected.GetFiles("*.gz")
                Decompress(fileToDecompress)
            Next


            For Each File As FileInfo In directorySelected.GetFiles("*.log")
                If Not File.ToString.StartsWith("latest") Then
                    ListBox1.Items.Add(Path.GetFileName(File.FullName))
                End If
            Next
        End If

    End Sub

    Private Sub Decompress(ByVal fileToDecompress As FileInfo)
        Using originalFileStream As FileStream = fileToDecompress.OpenRead()
            Dim currentFileName As String = fileToDecompress.FullName
            Dim newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length)

            Using decompressedFileStream As FileStream = File.Create(newFileName)
                Using decompressionStream As GZipStream = New GZipStream(originalFileStream, CompressionMode.Decompress)
                    decompressionStream.CopyTo(decompressedFileStream)
                    Console.WriteLine("Decompressed: {0}", fileToDecompress.Name)
                End Using
            End Using
        End Using
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim FileToRead As String = JarFolder & "\logs\" & ListBox1.SelectedItem
        If IO.File.Exists(FileToRead) = True Then TextBox1.Text = System.IO.File.ReadAllText(FileToRead)

    End Sub
End Class