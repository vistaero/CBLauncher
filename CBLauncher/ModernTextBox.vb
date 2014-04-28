Public Class ModernTextBox

    Private ControlText As String
    Private DefaultControlText As String


    Overrides Property Text() As String
        Get
            Return ControlText
        End Get
        Set(value As String)
            ControlText = value
        End Set
    End Property

    Public Property DefaultText() As String
        Get
            Return DefaultControlText
        End Get
        Set(value As String)
            DefaultControlText = value
        End Set
    End Property


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.MouseDown
        If TextBox1.Text.Equals(DefaultText) Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ModernTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = DefaultText
    End Sub

    Private Sub TextBoxStyle(ByVal DefaultStyle As Boolean)
        Select Case DefaultStyle
            Case True
                'TextBox1.Font.it()
        End Select
    End Sub

End Class
