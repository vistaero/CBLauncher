Public Class AddFavorite



    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Form1.NewFavoriteName = TextBox1.Text
        System.IO.File.WriteAllText(Form1.documentspath & Form1.NewFavoriteName & ".cblfav", Form1.JarPath)
        Form1.RefreshFavorites()
        Me.Hide()
        ParentForm.Hide()





    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Dispose()
        Form1.OutPutTextBox.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Equals("") Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub

    Private Sub AddFavorite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fi As New IO.FileInfo(Form1.JarPath)
        TextBox1.Text = fi.Directory.Name
        TextBox1.Focus()

    End Sub
End Class
