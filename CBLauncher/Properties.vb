Imports System.IO

Public Class Properties

    Private Properties As New Dictionary(Of String, String)
    Private s As String
    Private PropertyReading As String
    Private ReconstructedProperties As String


    Public Sub SetDictionary(Optional ByVal LoadDefaults As Boolean = False)
        Select Case LoadDefaults
            Case True
                Properties("generator-settings") = ""
                Properties("op-permission-level") = "4"
                Properties("allow-nether") = "true"
                Properties("level-name") = "world"
                Properties("enable-query") = "false"
                Properties("allow-flight") = "false"
                Properties("rcon.password") = ""
                Properties("announce-player-achievements") = "true"
                Properties("server-port") = "25565"
                Properties("level-type") = "DEFAULT"
                Properties("enable-rcon") = "false"
                Properties("force-gamemode") = "false"
                Properties("level-seed") = ""
                Properties("server-ip") = ""
                Properties("max-build-height") = "256"
                Properties("spawn-npcs") = "true"
                Properties("white-list") = "true"
                Properties("spawn-animals") = "true"
                Properties("snooper-enabled") = "false"
                Properties("hardcore") = "false"
                Properties("online-mode") = "true"
                Properties("resource-pack") = ""
                Properties("pvp") = "true"
                Properties("difficulty") = "1"
                Properties("enable-command-block") = "false"
                Properties("player-idle-timeout") = "0"
                Properties("gamemode") = "0"
                Properties("max-players") = "20"
                Properties("spawn-monsters") = "true"
                Properties("view-distance") = "10"
                Properties("generate-structures") = "true"
                Properties("spawn-protection") = "16"
                Properties("motd") = "A Minecraft Server"
            Case False
                Properties.Add("generator-settings", "")
                Properties.Add("op-permission-level", "4")
                Properties.Add("allow-nether", "true")
                Properties.Add("level-name", "world")
                Properties.Add("enable-query", "false")
                Properties.Add("allow-flight", "false")
                Properties.Add("rcon.password", "")
                Properties.Add("announce-player-achievements", "true")
                Properties.Add("server-port", "25565")
                Properties.Add("level-type", "DEFAULT")
                Properties.Add("enable-rcon", "false")
                Properties.Add("force-gamemode", "false")
                Properties.Add("level-seed", "")
                Properties.Add("server-ip", "")
                Properties.Add("max-build-height", "256")
                Properties.Add("spawn-npcs", "true")
                Properties.Add("white-list", "true")
                Properties.Add("spawn-animals", "true")
                Properties.Add("snooper-enabled", "false")
                Properties.Add("hardcore", "false")
                Properties.Add("online-mode", "true")
                Properties.Add("resource-pack", "")
                Properties.Add("pvp", "true")
                Properties.Add("difficulty", "1")
                Properties.Add("enable-command-block", "false")
                Properties.Add("player-idle-timeout", "0")
                Properties.Add("gamemode", "0")
                Properties.Add("max-players", "20")
                Properties.Add("spawn-monsters", "true")
                Properties.Add("view-distance", "10")
                Properties.Add("generate-structures", "true")
                Properties.Add("spawn-protection", "16")
                Properties.Add("motd", "A Minecraft Server")
        End Select

        
    End Sub


    Private Sub SetValuesOnUI()

        Properties.TryGetValue("generator-settings", GeneratorSettingsTextBox.Text)
        Dim OpPermLevel As Byte
        Properties.TryGetValue("op-permission-level", OpPermLevel)
        OpPermLevelComboBox.SelectedIndex = OpPermLevel - 1
        Properties.TryGetValue("allow-nether", AllowNetherCheckBox.Checked)
        Properties.TryGetValue("level-name", LevelNameTextBox.Text)
        Properties.TryGetValue("enable-query", EnableQueryCheckBox.Checked)
        Properties.TryGetValue("allow-flight", AllowFlightCheckBox.Checked)
        Properties.TryGetValue("rcon.password", RconPassword.Text)
        Properties.TryGetValue("announce-player-achievements", AnnouncePArchsCheckBox.Checked)
        Properties.TryGetValue("server-port", ServerPort.Value)
        Properties.TryGetValue("level-type", LevelTypeComboBox.SelectedItem)
        Properties.TryGetValue("enable-rcon", EnableRconCheckBox.Checked)
        Properties.TryGetValue("force-gamemode", ForceGamemodeCheckBox.Checked)
        Properties.TryGetValue("level-seed", LevelSeedTextBox.Text)
        Properties.TryGetValue("server-ip", ServerIPTextBox.Text)
        Properties.TryGetValue("max-build-height", MaxBuildHeight.Value)
        Properties.TryGetValue("spawn-npcs", SpawnNPCsCheckBox.Checked)
        Properties.TryGetValue("white-list", WhiteListCheckBox.Checked)
        Properties.TryGetValue("spawn-animals", SpawnAnimalsCheckBox.Checked)
        Properties.TryGetValue("snooper-enabled", SnooperCheckBox.Checked)
        Properties.TryGetValue("hardcore", HardcoreCheckBox.Checked)
        Properties.TryGetValue("online-mode", OnlineMode.Checked)
        Properties.TryGetValue("resource-pack", ResourcePackTextBox.Text)
        Properties.TryGetValue("pvp", PVPCheckBox.Checked)
        Properties.TryGetValue("difficulty", DifficultyComboBox.SelectedIndex)
        Properties.TryGetValue("enable-command-block", EnableCommandBlock.Checked)
        Properties.TryGetValue("player-idle-timeout", PlayerIdlTimeout.Value)
        Dim gamemode As Integer
        Properties.TryGetValue("gamemode", gamemode)
        GamemodeComboBox.SelectedIndex = gamemode
        Properties.TryGetValue("max-players", MaxPlayers.Value)
        Properties.TryGetValue("spawn-monsters", SpawnMonstersCheckBox.Checked)
        Properties.TryGetValue("view-distance", ViewDistance.Value)
        Properties.TryGetValue("generate-structures", GenerateStructures.Checked)
        Properties.TryGetValue("spawn-protection", SpawnProtection.Value)
        Properties.TryGetValue("motd", DescriptionTextBox.Text)

    End Sub

    Private Sub SaveValues()
        Properties("generator-settings") = GeneratorSettingsTextBox.Text
        Properties("op-permission-level") = OpPermLevelComboBox.SelectedIndex + 1
        Properties("allow-nether") = AllowNetherCheckBox.Checked
        Properties("level-name") = LevelNameTextBox.Text
        Properties("enable-query") = EnableQueryCheckBox.Checked
        Properties("allow-flight") = AllowFlightCheckBox.Checked
        Properties("rcon.password") = RconPassword.Text
        Properties("announce-player-achievements") = AnnouncePArchsCheckBox.Checked
        Properties("server-port") = ServerPort.Value
        Properties("level-type") = LevelTypeComboBox.SelectedItem
        Properties("enable-rcon") = EnableRconCheckBox.Checked
        Properties("force-gamemode") = ForceGamemodeCheckBox.Checked
        Properties("level-seed") = LevelSeedTextBox.Text
        Properties("server-ip") = ServerIPTextBox.Text
        Properties("max-build-height") = MaxBuildHeight.Value
        Properties("spawn-npcs") = SpawnNPCsCheckBox.Checked
        Properties("white-list") = WhiteListCheckBox.Checked
        Properties("spawn-animals") = SpawnAnimalsCheckBox.Checked
        Properties("snooper-enabled") = SnooperCheckBox.Checked
        Properties("hardcore") = HardcoreCheckBox.Checked
        Properties("online-mode") = OnlineMode.Checked
        Properties("resource-pack") = ResourcePackTextBox.Text
        Properties("pvp") = PVPCheckBox.Checked
        Properties("difficulty") = DifficultyComboBox.SelectedIndex
        Properties("enable-command-block") = EnableCommandBlock.Checked
        Properties("player-idle-timeout") = PlayerIdlTimeout.Value
        Properties("gamemode") = GamemodeComboBox.SelectedIndex
        Properties("max-players") = MaxPlayers.Value
        Properties("spawn-monsters") = SpawnMonstersCheckBox.Checked
        Properties("view-distance") = ViewDistance.Value
        Properties("generate-structures") = GenerateStructures.Checked
        Properties("spawn-protection") = SpawnProtection.Value
        Properties("motd") = DescriptionTextBox.Text
        GenerateServerPropertiesText()
        Try
            System.IO.File.WriteAllText(Form1.JarFolder & "\server.properties", ReconstructedProperties)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ReadProperties(ByVal SP_Path)
        Dim readText() As String
        Try
            readText = File.ReadAllLines(SP_Path)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            For Each s In readText
                Dim split As String() = s.Split(New [Char]() {"="c})

                For Each s As String In split
                    If s.Trim <> "" And Not s.StartsWith("#") Then
                        If Properties.ContainsKey(s) Then
                            PropertyReading = s
                        Else
                            If Not Properties.ContainsKey(s) Then
                                Properties(PropertyReading) = s
                                Dim key As String = PropertyReading
                            End If
                        End If
                    End If
                Next s
            Next
        Catch ex As Exception
            MsgBox("File not valid.")

        End Try
        GenerateServerPropertiesText()

    End Sub

    Private Sub GenerateServerPropertiesText()
        ReconstructedProperties = ""
        Dim ActualValue

        For Each key In Properties.Keys
            Properties.TryGetValue(key, ActualValue)
            ReconstructedProperties = ReconstructedProperties & key & "=" & ActualValue & vbNewLine

        Next

    End Sub

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDictionary()
        If System.IO.File.Exists(Form1.JarFolder & "\server.properties") Then
            ReadProperties(Form1.JarFolder & "\server.properties")
            SetValuesOnUI()
        Else
            SetDictionary(True)
            SetValuesOnUI()

        End If


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        SetValuesOnUI()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles Regen.Click
        Dim reply = MessageBox.Show(Form1.LocRM.GetString("LdDfProps"), Form1.LocRM.GetString("AreYouSure"), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If reply = DialogResult.OK Then
            SetDictionary(True)
            SetValuesOnUI()
        End If


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveValues()
        ParentForm.Dispose()

    End Sub

End Class
