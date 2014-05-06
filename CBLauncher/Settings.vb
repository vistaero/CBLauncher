Imports System.Windows.Forms
Imports System.Resources


Public Class Settings

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If FolderBrowserDialog1.SelectedPath.Length > 0 Then
                TextBox2.Text = FolderBrowserDialog1.SelectedPath

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If FolderBrowserDialog1.SelectedPath.Length > 0 Then
                TextBox1.Text = FolderBrowserDialog1.SelectedPath

            End If
        End If
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        My.Settings.Save()
        Form1.CheckIfShowMaxMemory()
        Form1.MemoryText.Text = My.Settings.DefaultMaxMemory

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 350

        If My.Settings.ForceStop = False Then
            StopRadio.Checked = True
        End If
        CheckAutoArgs()
        
    End Sub

    Private Sub CheckAutoArgs()
        Select Case CheckBox1.Checked
            Case True

                NonAutoArgs.Enabled = False
            Case False

                NonAutoArgs.Enabled = True
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckAutoArgs()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim reply = MessageBox.Show(Form1.LocRM.GetString("AreYouSure"), Form1.LocRM.GetString("AreYouSure"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        My.Settings.Reset()
        My.Settings.Save()
        InitializeComponent()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.Height = 350
        Else
            Me.Height = 400
        End If
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim DefaultCBversion As New DownloadBuild
        DefaultCBversion.SetAsDefaultToolStripMenuItem.Visible = True
        DefaultCBversion.AddToolStripMenuItem.Visible = False
        DefaultCBversion.CheckForUpdatesToolStripMenuItem.Visible = False
        DefaultCBversion.RemoveToolStripMenuItem.Visible = False
        DefaultCBversion.CopyToolStripMenuItem.Visible = False
        DefaultCBversion.ShowDialog()

    End Sub
End Class
