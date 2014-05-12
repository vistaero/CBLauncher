Imports Newtonsoft.Json


Public Class Form2

#Region "DeserializeJson"

    Private WhiteListFile As String = Form1.JarFolder & "whitelist.json"
    Private OperatorsFile As String = Form1.JarFolder & "ops.json"
    Private BannedPlayersFile As String = Form1.JarFolder & "banned-players.json"
    Private UserCacheFile As String = Form1.JarFolder & "usercache.json"

    ' White List

    Dim WhiteListJson As String = System.IO.File.ReadAllText(WhiteListFile)
    Dim WhiteListPlayers As List(Of Player) = JsonConvert.DeserializeObject(Of List(Of Player))(WhiteListJson)

    ' OPs

    Dim OperatorsJson As String = System.IO.File.ReadAllText(OperatorsFile)
    Dim OperatorsPlayers As List(Of Player) = JsonConvert.DeserializeObject(Of List(Of Player))(OperatorsJson)

    ' Banned Players

    Dim BannedPlayersJson As String = System.IO.File.ReadAllText(BannedPlayersFile)
    Dim BannedPlayers As List(Of BannedPlayer) = JsonConvert.DeserializeObject(Of List(Of BannedPlayer))(BannedPlayersJson)

    ' User Cache

    Dim UserCacheJson As String = System.IO.File.ReadAllText(UserCacheFile)
    Dim UserCacheList As List(Of UserCache) = JsonConvert.DeserializeObject(Of List(Of UserCache))(UserCacheJson)

#End Region

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
        FillWithData()

    End Sub

    Private Sub FillWithData()
        Dim PlayersTable As New List(Of ListViewItem)

        Dim YesString As String = "Yes"
        Dim NoString As String = "No"

        For Each UserCache In UserCacheList
            Dim PlayerToAdd As New ListViewItem(UserCache.name)
            PlayerToAdd.Name = UserCache.name
            For contador = 0 To 8
                PlayerToAdd.SubItems.Add("")
            Next
            '' Start settings player attributes

            ' Is in White List
            PlayerToAdd.SubItems.Item(1).Text = NoString
            For Each Player In WhiteListPlayers
                If Player.uuid.Equals(UserCache.uuid) Then
                    PlayerToAdd.SubItems.Item(1).Text = YesString
                    Exit For
                Else

                End If
            Next

            ' Is an operator

            For Each Player In OperatorsPlayers
                If Player.uuid.Equals(UserCache.uuid) Then
                    PlayerToAdd.SubItems.Item(2).Text = YesString
                    Exit For
                Else
                    PlayerToAdd.SubItems.Item(2).Text = NoString
                End If
            Next

            ' Is banned
            For Each Player In BannedPlayers
                If Player.uuid.Equals(UserCache.uuid) Then
                    PlayerToAdd.SubItems.Item(3).Text = YesString
                    PlayerToAdd.SubItems.Item(4).Text = Player.created
                    PlayerToAdd.SubItems.Item(5).Text = Player.reason
                    PlayerToAdd.SubItems.Item(6).Text = Player.expires
                    PlayerToAdd.SubItems.Item(7).Text = Player.source
                    Exit For
                Else
                    PlayerToAdd.SubItems.Item(3).Text = NoString
                End If
            Next

            ' Player UUID
            PlayerToAdd.SubItems.Item(8).Text = UserCache.uuid
            ListView1.Items.Add(PlayerToAdd)
        Next

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub WhiteListButton_Click(sender As Object, e As EventArgs) Handles WhiteListButton.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim IsWhiteListed As Boolean = False

            For Each Player In WhiteListPlayers
                If Player.name.Equals(ListView1.FocusedItem.Text) Then
                    IsWhiteListed = True
                    WhiteListPlayers.Remove(Player)
                    ListView1.Items.Clear()
                    FillWithData()

                    Exit For
                End If

            Next

            If IsWhiteListed = False Then
                For Each Usercache In UserCacheList
                    If Usercache.name.Equals(ListView1.FocusedItem.Text) Then
                        Dim NewWhiteListedPlayer As New Player
                        NewWhiteListedPlayer.name = Usercache.name
                        NewWhiteListedPlayer.uuid = Usercache.uuid
                        WhiteListPlayers.Add(NewWhiteListedPlayer)
                        ListView1.Items.Clear()
                        FillWithData()
                        Exit For
                    End If
                Next
            End If

        End If

    End Sub

    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles OperatorButton.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim IsOperator As Boolean = False

            For Each Player In OperatorsPlayers
                If Player.name.Equals(ListView1.FocusedItem.Text) Then
                    IsOperator = True
                    OperatorsPlayers.Remove(Player)
                    ListView1.Items.Clear()
                    FillWithData()

                    Exit For
                End If

            Next

            If IsOperator = False Then
                For Each Usercache In UserCacheList
                    If Usercache.name.Equals(ListView1.FocusedItem.Text) Then
                        Dim NewOperatorPlayer As New Player
                        NewOperatorPlayer.name = Usercache.name
                        NewOperatorPlayer.uuid = Usercache.uuid
                        OperatorsPlayers.Add(NewOperatorPlayer)
                        ListView1.Items.Clear()
                        FillWithData()
                        Exit For
                    End If
                Next
            End If


        End If
    End Sub

    Private Sub BannedButton_Click(sender As Object, e As EventArgs) Handles BannedButton.Click
        If ListView1.SelectedItems.Count > 0 Then

            For Each bannedPlayer In BannedPlayers
                If bannedPlayer.name.Equals(ListView1.FocusedItem.Text) Then
                    BannedPlayers.Remove(bannedPlayer)
                    ListView1.Items.Clear()
                    FillWithData()

                    Exit For
                End If

            Next

        End If
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

Public Class UserCache
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

    Public Property expiresOn() As String
        Get
            Return m_expiresOn
        End Get
        Set(value As String)
            m_expiresOn = value
        End Set
    End Property
    Private m_expiresOn As String


End Class