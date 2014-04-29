<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Properties
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Properties))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MaxPlayers = New System.Windows.Forms.NumericUpDown()
        Me.MaxPlayersLabel = New System.Windows.Forms.Label()
        Me.ResourcePackTextBox = New System.Windows.Forms.TextBox()
        Me.ResourcePackLabel = New System.Windows.Forms.Label()
        Me.WhiteListCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RconPassword = New System.Windows.Forms.MaskedTextBox()
        Me.RconPasswordLabel = New System.Windows.Forms.Label()
        Me.ViewDistance = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnableCommandBlock = New System.Windows.Forms.CheckBox()
        Me.OnlineMode = New System.Windows.Forms.CheckBox()
        Me.SnooperCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServerIPTextBox = New System.Windows.Forms.TextBox()
        Me.ServerIPLabel = New System.Windows.Forms.Label()
        Me.EnableRconCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServerPort = New System.Windows.Forms.NumericUpDown()
        Me.ServerPortLabel = New System.Windows.Forms.Label()
        Me.EnableQueryCheckBox = New System.Windows.Forms.CheckBox()
        Me.OpPermLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.OpPermLevelLabel = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GenerateStructures = New System.Windows.Forms.CheckBox()
        Me.SpawnProtection = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SpawnMonstersCheckBox = New System.Windows.Forms.CheckBox()
        Me.SpawnAnimalsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SpawnNPCsCheckBox = New System.Windows.Forms.CheckBox()
        Me.MaxBuildHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LevelSeedTextBox = New System.Windows.Forms.TextBox()
        Me.SeedLabel = New System.Windows.Forms.Label()
        Me.LevelTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.LevelTypeLabel = New System.Windows.Forms.Label()
        Me.LevelNameTextBox = New System.Windows.Forms.TextBox()
        Me.LevelNameLabel = New System.Windows.Forms.Label()
        Me.AllowNetherCheckBox = New System.Windows.Forms.CheckBox()
        Me.GeneratorSettingsTextBox = New System.Windows.Forms.TextBox()
        Me.GeneratorSettingsLabel = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GamemodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PlayerIdlTimeout = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HardcoreCheckBox = New System.Windows.Forms.CheckBox()
        Me.DifficultyLabel = New System.Windows.Forms.Label()
        Me.DifficultyComboBox = New System.Windows.Forms.ComboBox()
        Me.PVPCheckBox = New System.Windows.Forms.CheckBox()
        Me.ForceGamemodeCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnnouncePArchsCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowFlightCheckBox = New System.Windows.Forms.CheckBox()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Regen = New System.Windows.Forms.ToolStripButton()
        Me.Content = New System.Windows.Forms.Panel()
        Me.GroupBox5.SuspendLayout()
        CType(Me.MaxPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ViewDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.SpawnProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxBuildHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PlayerIdlTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Controls.Add(Me.MaxPlayers)
        Me.GroupBox5.Controls.Add(Me.MaxPlayersLabel)
        Me.GroupBox5.Controls.Add(Me.ResourcePackTextBox)
        Me.GroupBox5.Controls.Add(Me.ResourcePackLabel)
        Me.GroupBox5.Controls.Add(Me.WhiteListCheckBox)
        Me.GroupBox5.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox5.Controls.Add(Me.DescriptionLabel)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'MaxPlayers
        '
        resources.ApplyResources(Me.MaxPlayers, "MaxPlayers")
        Me.MaxPlayers.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.MaxPlayers.Name = "MaxPlayers"
        '
        'MaxPlayersLabel
        '
        resources.ApplyResources(Me.MaxPlayersLabel, "MaxPlayersLabel")
        Me.MaxPlayersLabel.Name = "MaxPlayersLabel"
        '
        'ResourcePackTextBox
        '
        resources.ApplyResources(Me.ResourcePackTextBox, "ResourcePackTextBox")
        Me.ResourcePackTextBox.Name = "ResourcePackTextBox"
        '
        'ResourcePackLabel
        '
        resources.ApplyResources(Me.ResourcePackLabel, "ResourcePackLabel")
        Me.ResourcePackLabel.Name = "ResourcePackLabel"
        '
        'WhiteListCheckBox
        '
        resources.ApplyResources(Me.WhiteListCheckBox, "WhiteListCheckBox")
        Me.WhiteListCheckBox.Name = "WhiteListCheckBox"
        Me.WhiteListCheckBox.UseVisualStyleBackColor = True
        '
        'DescriptionTextBox
        '
        resources.ApplyResources(Me.DescriptionTextBox, "DescriptionTextBox")
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        '
        'DescriptionLabel
        '
        resources.ApplyResources(Me.DescriptionLabel, "DescriptionLabel")
        Me.DescriptionLabel.Name = "DescriptionLabel"
        '
        'GroupBox6
        '
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Controls.Add(Me.RconPassword)
        Me.GroupBox6.Controls.Add(Me.RconPasswordLabel)
        Me.GroupBox6.Controls.Add(Me.ViewDistance)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.EnableCommandBlock)
        Me.GroupBox6.Controls.Add(Me.OnlineMode)
        Me.GroupBox6.Controls.Add(Me.SnooperCheckBox)
        Me.GroupBox6.Controls.Add(Me.ServerIPTextBox)
        Me.GroupBox6.Controls.Add(Me.ServerIPLabel)
        Me.GroupBox6.Controls.Add(Me.EnableRconCheckBox)
        Me.GroupBox6.Controls.Add(Me.ServerPort)
        Me.GroupBox6.Controls.Add(Me.ServerPortLabel)
        Me.GroupBox6.Controls.Add(Me.EnableQueryCheckBox)
        Me.GroupBox6.Controls.Add(Me.OpPermLevelComboBox)
        Me.GroupBox6.Controls.Add(Me.OpPermLevelLabel)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'RconPassword
        '
        resources.ApplyResources(Me.RconPassword, "RconPassword")
        Me.RconPassword.Name = "RconPassword"
        Me.RconPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.RconPassword.ShortcutsEnabled = False
        '
        'RconPasswordLabel
        '
        resources.ApplyResources(Me.RconPasswordLabel, "RconPasswordLabel")
        Me.RconPasswordLabel.Name = "RconPasswordLabel"
        '
        'ViewDistance
        '
        resources.ApplyResources(Me.ViewDistance, "ViewDistance")
        Me.ViewDistance.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ViewDistance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ViewDistance.Name = "ViewDistance"
        Me.ViewDistance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'EnableCommandBlock
        '
        resources.ApplyResources(Me.EnableCommandBlock, "EnableCommandBlock")
        Me.EnableCommandBlock.Name = "EnableCommandBlock"
        Me.EnableCommandBlock.UseVisualStyleBackColor = True
        '
        'OnlineMode
        '
        resources.ApplyResources(Me.OnlineMode, "OnlineMode")
        Me.OnlineMode.Name = "OnlineMode"
        Me.OnlineMode.UseVisualStyleBackColor = True
        '
        'SnooperCheckBox
        '
        resources.ApplyResources(Me.SnooperCheckBox, "SnooperCheckBox")
        Me.SnooperCheckBox.Name = "SnooperCheckBox"
        Me.SnooperCheckBox.UseVisualStyleBackColor = True
        '
        'ServerIPTextBox
        '
        resources.ApplyResources(Me.ServerIPTextBox, "ServerIPTextBox")
        Me.ServerIPTextBox.Name = "ServerIPTextBox"
        '
        'ServerIPLabel
        '
        resources.ApplyResources(Me.ServerIPLabel, "ServerIPLabel")
        Me.ServerIPLabel.Name = "ServerIPLabel"
        '
        'EnableRconCheckBox
        '
        resources.ApplyResources(Me.EnableRconCheckBox, "EnableRconCheckBox")
        Me.EnableRconCheckBox.Name = "EnableRconCheckBox"
        Me.EnableRconCheckBox.UseVisualStyleBackColor = True
        '
        'ServerPort
        '
        resources.ApplyResources(Me.ServerPort, "ServerPort")
        Me.ServerPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.ServerPort.Name = "ServerPort"
        '
        'ServerPortLabel
        '
        resources.ApplyResources(Me.ServerPortLabel, "ServerPortLabel")
        Me.ServerPortLabel.Name = "ServerPortLabel"
        '
        'EnableQueryCheckBox
        '
        resources.ApplyResources(Me.EnableQueryCheckBox, "EnableQueryCheckBox")
        Me.EnableQueryCheckBox.Name = "EnableQueryCheckBox"
        Me.EnableQueryCheckBox.UseVisualStyleBackColor = True
        '
        'OpPermLevelComboBox
        '
        resources.ApplyResources(Me.OpPermLevelComboBox, "OpPermLevelComboBox")
        Me.OpPermLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OpPermLevelComboBox.FormattingEnabled = True
        Me.OpPermLevelComboBox.Items.AddRange(New Object() {resources.GetString("OpPermLevelComboBox.Items"), resources.GetString("OpPermLevelComboBox.Items1"), resources.GetString("OpPermLevelComboBox.Items2"), resources.GetString("OpPermLevelComboBox.Items3")})
        Me.OpPermLevelComboBox.Name = "OpPermLevelComboBox"
        '
        'OpPermLevelLabel
        '
        resources.ApplyResources(Me.OpPermLevelLabel, "OpPermLevelLabel")
        Me.OpPermLevelLabel.Name = "OpPermLevelLabel"
        '
        'GroupBox7
        '
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.Controls.Add(Me.GenerateStructures)
        Me.GroupBox7.Controls.Add(Me.SpawnProtection)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.SpawnMonstersCheckBox)
        Me.GroupBox7.Controls.Add(Me.SpawnAnimalsCheckBox)
        Me.GroupBox7.Controls.Add(Me.SpawnNPCsCheckBox)
        Me.GroupBox7.Controls.Add(Me.MaxBuildHeight)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.LevelSeedTextBox)
        Me.GroupBox7.Controls.Add(Me.SeedLabel)
        Me.GroupBox7.Controls.Add(Me.LevelTypeComboBox)
        Me.GroupBox7.Controls.Add(Me.LevelTypeLabel)
        Me.GroupBox7.Controls.Add(Me.LevelNameTextBox)
        Me.GroupBox7.Controls.Add(Me.LevelNameLabel)
        Me.GroupBox7.Controls.Add(Me.AllowNetherCheckBox)
        Me.GroupBox7.Controls.Add(Me.GeneratorSettingsTextBox)
        Me.GroupBox7.Controls.Add(Me.GeneratorSettingsLabel)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'GenerateStructures
        '
        resources.ApplyResources(Me.GenerateStructures, "GenerateStructures")
        Me.GenerateStructures.Name = "GenerateStructures"
        Me.GenerateStructures.UseVisualStyleBackColor = True
        '
        'SpawnProtection
        '
        resources.ApplyResources(Me.SpawnProtection, "SpawnProtection")
        Me.SpawnProtection.Name = "SpawnProtection"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'SpawnMonstersCheckBox
        '
        resources.ApplyResources(Me.SpawnMonstersCheckBox, "SpawnMonstersCheckBox")
        Me.SpawnMonstersCheckBox.Name = "SpawnMonstersCheckBox"
        Me.SpawnMonstersCheckBox.UseVisualStyleBackColor = True
        '
        'SpawnAnimalsCheckBox
        '
        resources.ApplyResources(Me.SpawnAnimalsCheckBox, "SpawnAnimalsCheckBox")
        Me.SpawnAnimalsCheckBox.Name = "SpawnAnimalsCheckBox"
        Me.SpawnAnimalsCheckBox.UseVisualStyleBackColor = True
        '
        'SpawnNPCsCheckBox
        '
        resources.ApplyResources(Me.SpawnNPCsCheckBox, "SpawnNPCsCheckBox")
        Me.SpawnNPCsCheckBox.Name = "SpawnNPCsCheckBox"
        Me.SpawnNPCsCheckBox.UseVisualStyleBackColor = True
        '
        'MaxBuildHeight
        '
        resources.ApplyResources(Me.MaxBuildHeight, "MaxBuildHeight")
        Me.MaxBuildHeight.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.MaxBuildHeight.Name = "MaxBuildHeight"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LevelSeedTextBox
        '
        resources.ApplyResources(Me.LevelSeedTextBox, "LevelSeedTextBox")
        Me.LevelSeedTextBox.Name = "LevelSeedTextBox"
        '
        'SeedLabel
        '
        resources.ApplyResources(Me.SeedLabel, "SeedLabel")
        Me.SeedLabel.Name = "SeedLabel"
        '
        'LevelTypeComboBox
        '
        Me.LevelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelTypeComboBox.FormattingEnabled = True
        Me.LevelTypeComboBox.Items.AddRange(New Object() {resources.GetString("LevelTypeComboBox.Items"), resources.GetString("LevelTypeComboBox.Items1"), resources.GetString("LevelTypeComboBox.Items2"), resources.GetString("LevelTypeComboBox.Items3")})
        resources.ApplyResources(Me.LevelTypeComboBox, "LevelTypeComboBox")
        Me.LevelTypeComboBox.Name = "LevelTypeComboBox"
        '
        'LevelTypeLabel
        '
        resources.ApplyResources(Me.LevelTypeLabel, "LevelTypeLabel")
        Me.LevelTypeLabel.Name = "LevelTypeLabel"
        '
        'LevelNameTextBox
        '
        resources.ApplyResources(Me.LevelNameTextBox, "LevelNameTextBox")
        Me.LevelNameTextBox.Name = "LevelNameTextBox"
        '
        'LevelNameLabel
        '
        resources.ApplyResources(Me.LevelNameLabel, "LevelNameLabel")
        Me.LevelNameLabel.Name = "LevelNameLabel"
        '
        'AllowNetherCheckBox
        '
        resources.ApplyResources(Me.AllowNetherCheckBox, "AllowNetherCheckBox")
        Me.AllowNetherCheckBox.Name = "AllowNetherCheckBox"
        Me.AllowNetherCheckBox.UseVisualStyleBackColor = True
        '
        'GeneratorSettingsTextBox
        '
        resources.ApplyResources(Me.GeneratorSettingsTextBox, "GeneratorSettingsTextBox")
        Me.GeneratorSettingsTextBox.Name = "GeneratorSettingsTextBox"
        '
        'GeneratorSettingsLabel
        '
        resources.ApplyResources(Me.GeneratorSettingsLabel, "GeneratorSettingsLabel")
        Me.GeneratorSettingsLabel.Name = "GeneratorSettingsLabel"
        '
        'GroupBox8
        '
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.Controls.Add(Me.GamemodeComboBox)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.PlayerIdlTimeout)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.HardcoreCheckBox)
        Me.GroupBox8.Controls.Add(Me.DifficultyLabel)
        Me.GroupBox8.Controls.Add(Me.DifficultyComboBox)
        Me.GroupBox8.Controls.Add(Me.PVPCheckBox)
        Me.GroupBox8.Controls.Add(Me.ForceGamemodeCheckBox)
        Me.GroupBox8.Controls.Add(Me.AnnouncePArchsCheckBox)
        Me.GroupBox8.Controls.Add(Me.AllowFlightCheckBox)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'GamemodeComboBox
        '
        Me.GamemodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GamemodeComboBox.FormattingEnabled = True
        Me.GamemodeComboBox.Items.AddRange(New Object() {resources.GetString("GamemodeComboBox.Items"), resources.GetString("GamemodeComboBox.Items1"), resources.GetString("GamemodeComboBox.Items2")})
        resources.ApplyResources(Me.GamemodeComboBox, "GamemodeComboBox")
        Me.GamemodeComboBox.Name = "GamemodeComboBox"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'PlayerIdlTimeout
        '
        resources.ApplyResources(Me.PlayerIdlTimeout, "PlayerIdlTimeout")
        Me.PlayerIdlTimeout.Name = "PlayerIdlTimeout"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'HardcoreCheckBox
        '
        resources.ApplyResources(Me.HardcoreCheckBox, "HardcoreCheckBox")
        Me.HardcoreCheckBox.Name = "HardcoreCheckBox"
        Me.HardcoreCheckBox.UseVisualStyleBackColor = True
        '
        'DifficultyLabel
        '
        resources.ApplyResources(Me.DifficultyLabel, "DifficultyLabel")
        Me.DifficultyLabel.Name = "DifficultyLabel"
        '
        'DifficultyComboBox
        '
        Me.DifficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DifficultyComboBox.FormattingEnabled = True
        Me.DifficultyComboBox.Items.AddRange(New Object() {resources.GetString("DifficultyComboBox.Items"), resources.GetString("DifficultyComboBox.Items1"), resources.GetString("DifficultyComboBox.Items2"), resources.GetString("DifficultyComboBox.Items3")})
        resources.ApplyResources(Me.DifficultyComboBox, "DifficultyComboBox")
        Me.DifficultyComboBox.Name = "DifficultyComboBox"
        '
        'PVPCheckBox
        '
        resources.ApplyResources(Me.PVPCheckBox, "PVPCheckBox")
        Me.PVPCheckBox.Name = "PVPCheckBox"
        Me.PVPCheckBox.UseVisualStyleBackColor = True
        '
        'ForceGamemodeCheckBox
        '
        resources.ApplyResources(Me.ForceGamemodeCheckBox, "ForceGamemodeCheckBox")
        Me.ForceGamemodeCheckBox.Name = "ForceGamemodeCheckBox"
        Me.ForceGamemodeCheckBox.UseVisualStyleBackColor = True
        '
        'AnnouncePArchsCheckBox
        '
        resources.ApplyResources(Me.AnnouncePArchsCheckBox, "AnnouncePArchsCheckBox")
        Me.AnnouncePArchsCheckBox.Name = "AnnouncePArchsCheckBox"
        Me.AnnouncePArchsCheckBox.UseVisualStyleBackColor = True
        '
        'AllowFlightCheckBox
        '
        resources.ApplyResources(Me.AllowFlightCheckBox, "AllowFlightCheckBox")
        Me.AllowFlightCheckBox.Name = "AllowFlightCheckBox"
        Me.AllowFlightCheckBox.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.UndoToolStripButton, Me.Regen})
        resources.ApplyResources(Me.MenuBar, "MenuBar")
        Me.MenuBar.Name = "MenuBar"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.SaveToolStripButton, "SaveToolStripButton")
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.UndoToolStripButton, "UndoToolStripButton")
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        '
        'Regen
        '
        Me.Regen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.Regen, "Regen")
        Me.Regen.Name = "Regen"
        '
        'Content
        '
        resources.ApplyResources(Me.Content, "Content")
        Me.Content.Controls.Add(Me.GroupBox5)
        Me.Content.Controls.Add(Me.GroupBox6)
        Me.Content.Controls.Add(Me.GroupBox7)
        Me.Content.Controls.Add(Me.GroupBox8)
        Me.Content.Name = "Content"
        '
        'Properties
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.MenuBar)
        Me.Name = "Properties"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.MaxPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ViewDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.SpawnProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxBuildHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PlayerIdlTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Content.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MaxPlayers As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaxPlayersLabel As System.Windows.Forms.Label
    Friend WithEvents ResourcePackTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResourcePackLabel As System.Windows.Forms.Label
    Friend WithEvents WhiteListCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents LevelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LevelNameLabel As System.Windows.Forms.Label
    Friend WithEvents AllowNetherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GeneratorSettingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneratorSettingsLabel As System.Windows.Forms.Label
    Friend WithEvents LevelTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LevelTypeLabel As System.Windows.Forms.Label
    Friend WithEvents MaxBuildHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LevelSeedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeedLabel As System.Windows.Forms.Label
    Friend WithEvents SpawnNPCsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SpawnMonstersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SpawnAnimalsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GamemodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PlayerIdlTimeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HardcoreCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents DifficultyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PVPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ForceGamemodeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AnnouncePArchsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowFlightCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OpPermLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpPermLevelLabel As System.Windows.Forms.Label
    Friend WithEvents ServerIPLabel As System.Windows.Forms.Label
    Friend WithEvents EnableRconCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServerPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents ServerPortLabel As System.Windows.Forms.Label
    Friend WithEvents EnableQueryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServerIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewDistance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EnableCommandBlock As System.Windows.Forms.CheckBox
    Friend WithEvents OnlineMode As System.Windows.Forms.CheckBox
    Friend WithEvents SnooperCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenerateStructures As System.Windows.Forms.CheckBox
    Friend WithEvents SpawnProtection As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Regen As System.Windows.Forms.ToolStripButton
    Friend WithEvents Content As System.Windows.Forms.Panel
    Friend WithEvents RconPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents RconPassword As System.Windows.Forms.MaskedTextBox

End Class
