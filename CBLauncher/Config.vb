Imports SharpYaml
Imports SharpYaml.Serialization


Public Class Config

    Private Path As String = "C:\Users\vista_000\Documents\Servidor de pruebas\bukkit.yml"

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim config As New ConfigFile
        Dim configyml As Object = System.IO.File.ReadAllLines(Path)
        For Each line As String In configyml
            If Not line.StartsWith("#") And Not line.Equals("") And Not line.Equals("settings:") And Not line.Equals("spawn-limits:") And Not line.Equals("chunk-gc:") And Not line.Equals("ticks-per:") And Not line.Equals("auto-updater:") And Not line.Equals("database:") Then
                Dim split As String() = line.Split(New [Char]() {":"c})
                For Each s As String In split
                    MsgBox(s.ToString)
                Next
            End If
        Next
    End Sub

    Private Sub Serialize()
        Dim serializer = New Serializer()
        Dim text = serializer.Serialize(New With { _
            Key .List = New List(Of Integer)() From {1, 2, 3}, Key .Name = "Hello", Key .Value = "World!"})
        TextBox1.Text = text
    End Sub
End Class

Public Class ConfigFile
    Public Property allowend
        Get
            Return m_allowend
        End Get
        Set(value)
            m_allowend = value
        End Set
    End Property
    Private m_allowend As String

End Class