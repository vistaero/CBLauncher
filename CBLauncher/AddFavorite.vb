Public Class AddFavorite

    Private Sub AddFavorite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fi As New IO.FileInfo(Form1.JarPath)
        TextBox1.Text = fi.Directory.Name
        TextBox1.Focus()

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Done()

    End Sub

    Private Sub Done()
        Form1.NewFavoriteName = TextBox1.Text
        System.IO.File.WriteAllText(Form1.documentspath & Form1.NewFavoriteName & ".cblfav", Form1.JarPath)
        Form1.RefreshFavorites()
        ParentForm.Dispose()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Done()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Equals("") Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub


End Class
