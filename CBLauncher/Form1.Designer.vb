﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusCircle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.JarPathText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FavoritesButton = New System.Windows.Forms.ToolStripButton()
        Me.SelectJarButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SelectByFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectByFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartButton = New System.Windows.Forms.ToolStripButton()
        Me.StopButton = New System.Windows.Forms.ToolStripButton()
        Me.ForceStopButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenServerFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateCraftbukkitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegenerateWorldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackcolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DownloadCraftBukkitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreCommands = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleDownfallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThunderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearWeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetNightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaxMemoryLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MemoryText = New System.Windows.Forms.ToolStripTextBox()
        Me.OutPutPanel = New System.Windows.Forms.Panel()
        Me.OutPutTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.OutPutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusCircle, Me.JarPathText})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'StatusCircle
        '
        resources.ApplyResources(Me.StatusCircle, "StatusCircle")
        Me.StatusCircle.ForeColor = System.Drawing.Color.Red
        Me.StatusCircle.Name = "StatusCircle"
        '
        'JarPathText
        '
        resources.ApplyResources(Me.JarPathText, "JarPathText")
        Me.JarPathText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.JarPathText.Name = "JarPathText"
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.FavoritesButton, Me.SelectJarButton, Me.ToolStripSeparator1, Me.StartButton, Me.StopButton, Me.ForceStopButton, Me.ToolStripButton2, Me.MoreCommands, Me.ToolStripSeparator2, Me.MaxMemoryLabel, Me.MemoryText})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.ShowItemToolTips = False
        '
        'ToolStripLabel1
        '
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        '
        'FavoritesButton
        '
        resources.ApplyResources(Me.FavoritesButton, "FavoritesButton")
        Me.FavoritesButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FavoritesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FavoritesButton.Name = "FavoritesButton"
        '
        'SelectJarButton
        '
        resources.ApplyResources(Me.SelectJarButton, "SelectJarButton")
        Me.SelectJarButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SelectJarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SelectJarButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectByFolderToolStripMenuItem, Me.SelectByFileToolStripMenuItem})
        Me.SelectJarButton.Name = "SelectJarButton"
        '
        'SelectByFolderToolStripMenuItem
        '
        resources.ApplyResources(Me.SelectByFolderToolStripMenuItem, "SelectByFolderToolStripMenuItem")
        Me.SelectByFolderToolStripMenuItem.Name = "SelectByFolderToolStripMenuItem"
        '
        'SelectByFileToolStripMenuItem
        '
        resources.ApplyResources(Me.SelectByFileToolStripMenuItem, "SelectByFileToolStripMenuItem")
        Me.SelectByFileToolStripMenuItem.Name = "SelectByFileToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'StartButton
        '
        resources.ApplyResources(Me.StartButton, "StartButton")
        Me.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StartButton.Name = "StartButton"
        '
        'StopButton
        '
        resources.ApplyResources(Me.StopButton, "StopButton")
        Me.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StopButton.Name = "StopButton"
        '
        'ForceStopButton
        '
        resources.ApplyResources(Me.ForceStopButton, "ForceStopButton")
        Me.ForceStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ForceStopButton.Name = "ForceStopButton"
        '
        'ToolStripButton2
        '
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtrasToolStripMenuItem, Me.ToolStripSeparator4, Me.ClearToolStripMenuItem, Me.CopyAllToolStripMenuItem, Me.FontTypeToolStripMenuItem, Me.ToolStripSeparator3, Me.AddFavoriteToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator5, Me.DownloadCraftBukkitToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HuevoToolStripMenuItem})
        Me.ToolStripButton2.Name = "ToolStripButton2"
        '
        'ExtrasToolStripMenuItem
        '
        resources.ApplyResources(Me.ExtrasToolStripMenuItem, "ExtrasToolStripMenuItem")
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenServerFolderToolStripMenuItem, Me.ToolStripSeparator6, Me.UpdateCraftbukkitToolStripMenuItem, Me.EditPropertiesToolStripMenuItem, Me.LogsToolStripMenuItem, Me.RegenerateWorldToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        '
        'OpenServerFolderToolStripMenuItem
        '
        resources.ApplyResources(Me.OpenServerFolderToolStripMenuItem, "OpenServerFolderToolStripMenuItem")
        Me.OpenServerFolderToolStripMenuItem.Name = "OpenServerFolderToolStripMenuItem"
        '
        'ToolStripSeparator6
        '
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        '
        'UpdateCraftbukkitToolStripMenuItem
        '
        resources.ApplyResources(Me.UpdateCraftbukkitToolStripMenuItem, "UpdateCraftbukkitToolStripMenuItem")
        Me.UpdateCraftbukkitToolStripMenuItem.Name = "UpdateCraftbukkitToolStripMenuItem"
        '
        'EditPropertiesToolStripMenuItem
        '
        resources.ApplyResources(Me.EditPropertiesToolStripMenuItem, "EditPropertiesToolStripMenuItem")
        Me.EditPropertiesToolStripMenuItem.Name = "EditPropertiesToolStripMenuItem"
        '
        'LogsToolStripMenuItem
        '
        resources.ApplyResources(Me.LogsToolStripMenuItem, "LogsToolStripMenuItem")
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        '
        'RegenerateWorldToolStripMenuItem
        '
        resources.ApplyResources(Me.RegenerateWorldToolStripMenuItem, "RegenerateWorldToolStripMenuItem")
        Me.RegenerateWorldToolStripMenuItem.Name = "RegenerateWorldToolStripMenuItem"
        '
        'ToolStripSeparator4
        '
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        '
        'ClearToolStripMenuItem
        '
        resources.ApplyResources(Me.ClearToolStripMenuItem, "ClearToolStripMenuItem")
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        '
        'CopyAllToolStripMenuItem
        '
        resources.ApplyResources(Me.CopyAllToolStripMenuItem, "CopyAllToolStripMenuItem")
        Me.CopyAllToolStripMenuItem.Name = "CopyAllToolStripMenuItem"
        '
        'FontTypeToolStripMenuItem
        '
        resources.ApplyResources(Me.FontTypeToolStripMenuItem, "FontTypeToolStripMenuItem")
        Me.FontTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleToolStripMenuItem, Me.ChangeFontToolStripMenuItem, Me.ForeColorToolStripMenuItem, Me.ChangeBackcolorToolStripMenuItem})
        Me.FontTypeToolStripMenuItem.Name = "FontTypeToolStripMenuItem"
        '
        'ConsoleToolStripMenuItem
        '
        resources.ApplyResources(Me.ConsoleToolStripMenuItem, "ConsoleToolStripMenuItem")
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        '
        'ChangeFontToolStripMenuItem
        '
        resources.ApplyResources(Me.ChangeFontToolStripMenuItem, "ChangeFontToolStripMenuItem")
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        '
        'ForeColorToolStripMenuItem
        '
        resources.ApplyResources(Me.ForeColorToolStripMenuItem, "ForeColorToolStripMenuItem")
        Me.ForeColorToolStripMenuItem.Name = "ForeColorToolStripMenuItem"
        '
        'ChangeBackcolorToolStripMenuItem
        '
        resources.ApplyResources(Me.ChangeBackcolorToolStripMenuItem, "ChangeBackcolorToolStripMenuItem")
        Me.ChangeBackcolorToolStripMenuItem.Name = "ChangeBackcolorToolStripMenuItem"
        '
        'ToolStripSeparator3
        '
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        '
        'AddFavoriteToolStripMenuItem
        '
        resources.ApplyResources(Me.AddFavoriteToolStripMenuItem, "AddFavoriteToolStripMenuItem")
        Me.AddFavoriteToolStripMenuItem.Name = "AddFavoriteToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'ToolStripSeparator5
        '
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        '
        'DownloadCraftBukkitToolStripMenuItem
        '
        resources.ApplyResources(Me.DownloadCraftBukkitToolStripMenuItem, "DownloadCraftBukkitToolStripMenuItem")
        Me.DownloadCraftBukkitToolStripMenuItem.Name = "DownloadCraftBukkitToolStripMenuItem"
        '
        'SettingsToolStripMenuItem
        '
        resources.ApplyResources(Me.SettingsToolStripMenuItem, "SettingsToolStripMenuItem")
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        '
        'AboutToolStripMenuItem
        '
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        '
        'HuevoToolStripMenuItem
        '
        resources.ApplyResources(Me.HuevoToolStripMenuItem, "HuevoToolStripMenuItem")
        Me.HuevoToolStripMenuItem.Name = "HuevoToolStripMenuItem"
        '
        'MoreCommands
        '
        resources.ApplyResources(Me.MoreCommands, "MoreCommands")
        Me.MoreCommands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MoreCommands.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.ToggleDownfallToolStripMenuItem, Me.ThunderToolStripMenuItem, Me.ClearWeatherToolStripMenuItem, Me.SetDayToolStripMenuItem, Me.SetNightToolStripMenuItem})
        Me.MoreCommands.Name = "MoreCommands"
        '
        'ReloadToolStripMenuItem
        '
        resources.ApplyResources(Me.ReloadToolStripMenuItem, "ReloadToolStripMenuItem")
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        '
        'ToggleDownfallToolStripMenuItem
        '
        resources.ApplyResources(Me.ToggleDownfallToolStripMenuItem, "ToggleDownfallToolStripMenuItem")
        Me.ToggleDownfallToolStripMenuItem.Name = "ToggleDownfallToolStripMenuItem"
        '
        'ThunderToolStripMenuItem
        '
        resources.ApplyResources(Me.ThunderToolStripMenuItem, "ThunderToolStripMenuItem")
        Me.ThunderToolStripMenuItem.Name = "ThunderToolStripMenuItem"
        '
        'ClearWeatherToolStripMenuItem
        '
        resources.ApplyResources(Me.ClearWeatherToolStripMenuItem, "ClearWeatherToolStripMenuItem")
        Me.ClearWeatherToolStripMenuItem.Name = "ClearWeatherToolStripMenuItem"
        '
        'SetDayToolStripMenuItem
        '
        resources.ApplyResources(Me.SetDayToolStripMenuItem, "SetDayToolStripMenuItem")
        Me.SetDayToolStripMenuItem.Name = "SetDayToolStripMenuItem"
        '
        'SetNightToolStripMenuItem
        '
        resources.ApplyResources(Me.SetNightToolStripMenuItem, "SetNightToolStripMenuItem")
        Me.SetNightToolStripMenuItem.Name = "SetNightToolStripMenuItem"
        '
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'MaxMemoryLabel
        '
        resources.ApplyResources(Me.MaxMemoryLabel, "MaxMemoryLabel")
        Me.MaxMemoryLabel.Name = "MaxMemoryLabel"
        '
        'MemoryText
        '
        resources.ApplyResources(Me.MemoryText, "MemoryText")
        Me.MemoryText.Name = "MemoryText"
        '
        'OutPutPanel
        '
        resources.ApplyResources(Me.OutPutPanel, "OutPutPanel")
        Me.OutPutPanel.Controls.Add(Me.OutPutTextBox)
        Me.OutPutPanel.Controls.Add(Me.ListBox1)
        Me.OutPutPanel.Name = "OutPutPanel"
        '
        'OutPutTextBox
        '
        resources.ApplyResources(Me.OutPutTextBox, "OutPutTextBox")
        Me.OutPutTextBox.BackColor = Global.CBLauncher.My.MySettings.Default.PersonalizedBackColor
        Me.OutPutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutPutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.CBLauncher.My.MySettings.Default, "PersonalizedColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OutPutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.CBLauncher.My.MySettings.Default, "PersonalizedBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OutPutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CBLauncher.My.MySettings.Default, "PersonalizedFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OutPutTextBox.Font = Global.CBLauncher.My.MySettings.Default.PersonalizedFont
        Me.OutPutTextBox.ForeColor = Global.CBLauncher.My.MySettings.Default.PersonalizedColor
        Me.OutPutTextBox.HideSelection = False
        Me.OutPutTextBox.Name = "OutPutTextBox"
        Me.OutPutTextBox.ReadOnly = True
        Me.OutPutTextBox.TabStop = False
        '
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Name = "ListBox1"
        '
        'InputTextBox
        '
        Me.InputTextBox.AcceptsReturn = True
        resources.ApplyResources(Me.InputTextBox, "InputTextBox")
        Me.InputTextBox.BackColor = Global.CBLauncher.My.MySettings.Default.PersonalizedBackColor
        Me.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.CBLauncher.My.MySettings.Default, "PersonalizedFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InputTextBox.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.CBLauncher.My.MySettings.Default, "PersonalizedColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InputTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.CBLauncher.My.MySettings.Default, "PersonalizedBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InputTextBox.Font = Global.CBLauncher.My.MySettings.Default.PersonalizedFont
        Me.InputTextBox.ForeColor = Global.CBLauncher.My.MySettings.Default.PersonalizedColor
        Me.InputTextBox.Name = "InputTextBox"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OutPutPanel)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.OutPutPanel.ResumeLayout(False)
        Me.OutPutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutPutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents StartButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForceStopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents JarPathText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaxMemoryLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MemoryText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DownloadCraftBukkitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddFavoriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPutPanel As System.Windows.Forms.Panel
    Friend WithEvents FavoritesButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegenerateWorldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents MoreCommands As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToggleDownfallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThunderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetNightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearWeatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ChangeBackcolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusCircle As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UpdateCraftbukkitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectJarButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SelectByFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectByFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenServerFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
