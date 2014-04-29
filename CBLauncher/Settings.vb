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
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class
