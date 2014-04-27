Imports System.Windows.Forms
Imports System.Resources


Public Class Settings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.Save()
        Me.Close()
    End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        My.Settings.History = ""
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
