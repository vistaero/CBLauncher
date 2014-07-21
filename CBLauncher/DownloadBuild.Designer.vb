<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadBuild
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadBuild))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FileURLCalculator = New System.ComponentModel.BackgroundWorker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LatestRecommendedBuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatestBetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatestDevelopmentBuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.SetAsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'FileURLCalculator
        '
        '
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Name = "ListBox1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AddToolStripMenuItem, Me.SetAsDefaultToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.CopyToolStripMenuItem, Me.UpdateToolStripMenuItem})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LatestRecommendedBuildToolStripMenuItem, Me.LatestBetaToolStripMenuItem, Me.LatestDevelopmentBuildToolStripMenuItem})
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        resources.ApplyResources(Me.CheckForUpdatesToolStripMenuItem, "CheckForUpdatesToolStripMenuItem")
        '
        'LatestRecommendedBuildToolStripMenuItem
        '
        Me.LatestRecommendedBuildToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.LatestRecommendedBuildToolStripMenuItem.Name = "LatestRecommendedBuildToolStripMenuItem"
        resources.ApplyResources(Me.LatestRecommendedBuildToolStripMenuItem, "LatestRecommendedBuildToolStripMenuItem")
        '
        'LatestBetaToolStripMenuItem
        '
        Me.LatestBetaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.LatestBetaToolStripMenuItem.Name = "LatestBetaToolStripMenuItem"
        resources.ApplyResources(Me.LatestBetaToolStripMenuItem, "LatestBetaToolStripMenuItem")
        '
        'LatestDevelopmentBuildToolStripMenuItem
        '
        Me.LatestDevelopmentBuildToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LatestDevelopmentBuildToolStripMenuItem.Name = "LatestDevelopmentBuildToolStripMenuItem"
        resources.ApplyResources(Me.LatestDevelopmentBuildToolStripMenuItem, "LatestDevelopmentBuildToolStripMenuItem")
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.AddToolStripMenuItem, "AddToolStripMenuItem")
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        '
        'SetAsDefaultToolStripMenuItem
        '
        Me.SetAsDefaultToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.SetAsDefaultToolStripMenuItem, "SetAsDefaultToolStripMenuItem")
        Me.SetAsDefaultToolStripMenuItem.Name = "SetAsDefaultToolStripMenuItem"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.RemoveToolStripMenuItem, "RemoveToolStripMenuItem")
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.CopyToolStripMenuItem, "CopyToolStripMenuItem")
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.UpdateToolStripMenuItem, "UpdateToolStripMenuItem")
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'DownloadBuild
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MinimizeBox = False
        Me.Name = "DownloadBuild"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FileURLCalculator As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LatestDevelopmentBuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LatestRecommendedBuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LatestBetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SetAsDefaultToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
