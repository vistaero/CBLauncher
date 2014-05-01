Public Class Worlds

    Private Sub Worlds_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub Worlds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWorlds()
    End Sub

    Private Sub LoadWorlds()
        ListBox1.Items.Clear()
        For Each folder In System.IO.Directory.EnumerateDirectories(Form1.JarFolder)
            If IO.File.Exists(folder & "\level.dat") Then
                Dim fi As New IO.FileInfo(folder & "\level.dat")
                ListBox1.Items.Add(fi.Directory.Name)
            End If
        Next
    End Sub

    Private Sub OnlyTerrainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyTerrainToolStripMenuItem.Click

        If System.IO.Directory.Exists(Form1.JarFolder & ListBox1.SelectedItem & "\DIM1\region") = True Then
            Try
                System.IO.Directory.Delete(Form1.JarFolder & ListBox1.SelectedItem & "\DIM1\region", True)
                MessageBox.Show(Form1.LocRM.GetString("WorldRegen"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf System.IO.Directory.Exists(Form1.JarFolder & ListBox1.SelectedItem & "\DIM-1\region") = True Then
            Try
                System.IO.Directory.Delete(Form1.JarFolder & ListBox1.SelectedItem & "\DIM-1\region", True)
                MessageBox.Show(Form1.LocRM.GetString("WorldRegen"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf System.IO.Directory.Exists(Form1.JarFolder & ListBox1.SelectedItem & "\region") = True Then
            Try
                System.IO.Directory.Delete(Form1.JarFolder & ListBox1.SelectedItem & "\region", True)
                MessageBox.Show(Form1.LocRM.GetString("WorldRegen"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show(Form1.LocRM.GetString("WorldRegen"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub IncludePlayersDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EverythingDataToolStripMenuItem.Click
        Dim ThereIsFolders As Boolean
        For Each folder In System.IO.Directory.EnumerateDirectories(Form1.JarFolder & ListBox1.SelectedItem)
            If System.IO.Directory.Exists(folder) = True Then
                ThereIsFolders = True
                Try
                    System.IO.Directory.Delete(folder, True)
                    ThereIsFolders = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ThereIsFolders = False
            End If
        Next
        If ThereIsFolders = False Then MessageBox.Show(Form1.LocRM.GetString("WorldRegen"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form1.BackgroundWorker1.IsBusy = True Then
            ToolStripButton1.ToolTipText = Form1.LocRM.GetString("WaitingToBeStopped")
            ToolStripButton1.Enabled = False
        Else
            ToolStripButton1.ToolTipText = ""
            ToolStripButton1.Enabled = True
            LoadWorlds()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            OnlyTerrainToolStripMenuItem.Enabled = True
            EverythingDataToolStripMenuItem.Enabled = True
        Else
            OnlyTerrainToolStripMenuItem.Enabled = False
            EverythingDataToolStripMenuItem.Enabled = False

        End If
    End Sub
End Class