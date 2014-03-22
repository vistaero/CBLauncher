Imports System.Windows.Forms

Public Class Settings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

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
End Class
