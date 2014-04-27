<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OutPutTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.JarPathText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FavoritesButton = New System.Windows.Forms.ToolStripButton()
        Me.SelectJarButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartButton = New System.Windows.Forms.ToolStripButton()
        Me.StopButton = New System.Windows.Forms.ToolStripButton()
        Me.ForceStopButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadCraftBukkitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.MemoryText = New System.Windows.Forms.ToolStripTextBox()
        Me.OutPutPanel = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.OutPutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutPutTextBox
        '
        resources.ApplyResources(Me.OutPutTextBox, "OutPutTextBox")
        Me.OutPutTextBox.BackColor = System.Drawing.Color.Black
        Me.OutPutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutPutTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.OutPutTextBox.Name = "OutPutTextBox"
        Me.OutPutTextBox.ReadOnly = True
        Me.OutPutTextBox.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        '
        'InputTextBox
        '
        Me.InputTextBox.AcceptsReturn = True
        resources.ApplyResources(Me.InputTextBox, "InputTextBox")
        Me.InputTextBox.BackColor = System.Drawing.Color.Black
        Me.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.InputTextBox.Name = "InputTextBox"
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JarPathText})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Name = "StatusStrip1"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.FavoritesButton, Me.SelectJarButton, Me.ToolStripSeparator1, Me.StartButton, Me.StopButton, Me.ForceStopButton, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.MemoryText})
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
        Me.SelectJarButton.Name = "SelectJarButton"
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
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.CopyAllToolStripMenuItem, Me.ToolStripSeparator3, Me.AddFavoriteToolStripMenuItem, Me.ToolStripMenuItem1, Me.DownloadCraftBukkitToolStripMenuItem, Me.ToolStripSeparator5, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HuevoToolStripMenuItem})
        Me.ToolStripButton2.Name = "ToolStripButton2"
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
        'DownloadCraftBukkitToolStripMenuItem
        '
        resources.ApplyResources(Me.DownloadCraftBukkitToolStripMenuItem, "DownloadCraftBukkitToolStripMenuItem")
        Me.DownloadCraftBukkitToolStripMenuItem.Name = "DownloadCraftBukkitToolStripMenuItem"
        '
        'ToolStripSeparator5
        '
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
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
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'ToolStripLabel2
        '
        resources.ApplyResources(Me.ToolStripLabel2, "ToolStripLabel2")
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
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
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Name = "ListBox1"
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents StartButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForceStopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents JarPathText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SelectJarButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
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

End Class
