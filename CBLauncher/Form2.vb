Imports Newtonsoft.Json


Public Class Form2

    Private WhiteListFile As String = Form1.JarFolder & "whitelist.json"
    Private OperatorsFile As String = Form1.JarFolder & "ops.json"
    Private BannedPlayersFile As String = Form1.JarFolder & "banned-players.json"

    ' White List

    Dim WhiteListJson As String = System.IO.File.ReadAllText(WhiteListFile)
    Dim WhiteListPlayers As List(Of Player) = JsonConvert.DeserializeObject(Of List(Of Player))(WhiteListJson)

    ' OPs

    Dim OperatorsJson As String = System.IO.File.ReadAllText(OperatorsFile)
    Dim OperatorsPlayers As List(Of Player) = JsonConvert.DeserializeObject(Of List(Of Player))(OperatorsJson)

    ' Banned Players

    Dim BannedPlayersJson As String = System.IO.File.ReadAllText(BannedPlayersFile)
    Dim BannedPlayers As List(Of BannedPlayer) = JsonConvert.DeserializeObject(Of List(Of BannedPlayer))(BannedPlayersJson)

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim WhiteListSerialized As String = JsonConvert.SerializeObject(WhiteListPlayers)
        Dim OperatorsSerialized As String = JsonConvert.SerializeObject(OperatorsPlayers)
        Dim BannedPlayersSerialized As String = JsonConvert.SerializeObject(BannedPlayers)

        Try
            IO.File.WriteAllText(WhiteListFile, WhiteListSerialized)
            IO.File.WriteAllText(OperatorsFile, OperatorsSerialized)
            IO.File.WriteAllText(BannedPlayersFile, BannedPlayersSerialized)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Dispose()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WhiteListBox.Items.Clear()
        OperatorsListBox.Items.Clear()
        BannedPlayersListBox.Items.Clear()

        For Each Player In WhiteListPlayers
            WhiteListBox.Items.Add(Player.name)
        Next

        For Each Player In OperatorsPlayers
            OperatorsListBox.Items.Add(Player.name)
        Next

        For Each BannedPlayer In BannedPlayers
            BannedPlayersListBox.Items.Add(BannedPlayer.name)
        Next

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If BannedPlayersListBox.SelectedIndex > -1 Then
            MessageBox.Show(BannedPlayers(BannedPlayersListBox.SelectedIndex).uuid & vbNewLine & _
                            BannedPlayers(BannedPlayersListBox.SelectedIndex).created & vbNewLine & _
                            BannedPlayers(BannedPlayersListBox.SelectedIndex).source & vbNewLine & _
                            BannedPlayers(BannedPlayersListBox.SelectedIndex).expires & vbNewLine & _
                            BannedPlayers(BannedPlayersListBox.SelectedIndex).reason, _
                            BannedPlayers(BannedPlayersListBox.SelectedIndex).name, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If WhiteListBox.SelectedIndex > -1 Then
            MessageBox.Show(whitelistplayers(WhiteListBox.SelectedIndex).uuid, whitelistplayers(WhiteListBox.SelectedIndex).name, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If OperatorsListBox.SelectedIndex > -1 Then
            MessageBox.Show(OperatorsPlayers(OperatorsListBox.SelectedIndex).uuid, OperatorsPlayers(OperatorsListBox.SelectedIndex).name, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles RemoveFromWhiteListButton.Click
        For Each Player In whitelistplayers
            If Player.name.Equals(WhiteListBox.SelectedItem) Then
                WhiteListBox.Items.Remove(WhiteListBox.SelectedItem)
                WhiteListPlayers.Remove(Player)
                Exit For
            End If
        Next

    End Sub

    Private Sub RemoveOperatorButton_Click(sender As Object, e As EventArgs) Handles RemoveOperatorButton.Click
        For Each Player In OperatorsPlayers
            If Player.name.Equals(OperatorsListBox.SelectedItem) Then
                OperatorsListBox.Items.Remove(OperatorsListBox.SelectedItem)
                OperatorsPlayers.Remove(Player)
                Exit For
            End If
        Next
    End Sub

    Private Sub UnBanButton_Click(sender As Object, e As EventArgs) Handles UnBanButton.Click
        For Each BannedPlayer In bannedplayers
            If BannedPlayer.name.Equals(BannedPlayersListBox.SelectedItem) Then
                BannedPlayersListBox.Items.Remove(BannedPlayersListBox.SelectedItem)
                BannedPlayers.Remove(BannedPlayer)
                Exit For
            End If
        Next
    End Sub
End Class

Public Class Player
    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String

    Public Property uuid() As String
        Get
            Return m_uuid
        End Get
        Set(value As String)
            m_uuid = value
        End Set
    End Property
    Private m_uuid As String
End Class

Public Class BannedPlayer

    Public Property uuid() As String
        Get
            Return m_uuid
        End Get
        Set(value As String)
            m_uuid = value
        End Set
    End Property
    Private m_uuid As String

    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String

    Public Property created() As String
        Get
            Return m_created
        End Get
        Set(value As String)
            m_created = value
        End Set
    End Property
    Private m_created As String

    Public Property source() As String
        Get
            Return m_source
        End Get
        Set(value As String)
            m_source = value
        End Set
    End Property
    Private m_source As String

    Public Property expires() As String
        Get
            Return m_expires
        End Get
        Set(value As String)
            m_expires = value
        End Set
    End Property
    Private m_expires As String

    Public Property reason() As String
        Get
            Return m_reason
        End Get
        Set(value As String)
            m_reason = value
        End Set
    End Property
    Private m_reason As String

End Class
