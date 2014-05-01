Public Class PropertiesWindow

    Private Sub PropertiesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Content As New Properties
        Me.Controls.Add(Content)
        Content.Dock = DockStyle.Fill
        Me.Size = New Size(800, 800)
        Me.Icon = My.Resources.cblauncher
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = Form1.LocRM.GetString("PropsTitle")

    End Sub


End Class