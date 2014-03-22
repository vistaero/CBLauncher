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
        Me.SelectJarButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartButton = New System.Windows.Forms.ToolStripButton()
        Me.StopButton = New System.Windows.Forms.ToolStripButton()
        Me.ForceStopButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.MemoryText = New System.Windows.Forms.ToolStripTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutPutTextBox
        '
        Me.OutPutTextBox.BackColor = System.Drawing.Color.White
        Me.OutPutTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutPutTextBox.Location = New System.Drawing.Point(0, 0)
        Me.OutPutTextBox.Multiline = True
        Me.OutPutTextBox.Name = "OutPutTextBox"
        Me.OutPutTextBox.ReadOnly = True
        Me.OutPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutPutTextBox.Size = New System.Drawing.Size(515, 262)
        Me.OutPutTextBox.TabIndex = 2
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
        Me.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputTextBox.Location = New System.Drawing.Point(0, 0)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(515, 20)
        Me.InputTextBox.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JarPathText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 307)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(515, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'JarPathText
        '
        Me.JarPathText.Name = "JarPathText"
        Me.JarPathText.Size = New System.Drawing.Size(91, 17)
        Me.JarPathText.Text = "No JAR selected"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.SelectJarButton, Me.ToolStripSeparator1, Me.StartButton, Me.StopButton, Me.ForceStopButton, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.MemoryText})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(515, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'SelectJarButton
        '
        Me.SelectJarButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SelectJarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SelectJarButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SelectJarButton.Image = CType(resources.GetObject("SelectJarButton.Image"), System.Drawing.Image)
        Me.SelectJarButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectJarButton.Name = "SelectJarButton"
        Me.SelectJarButton.Size = New System.Drawing.Size(70, 22)
        Me.SelectJarButton.Text = "Select JAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'StartButton
        '
        Me.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StartButton.Enabled = False
        Me.StartButton.Image = CType(resources.GetObject("StartButton.Image"), System.Drawing.Image)
        Me.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(35, 22)
        Me.StartButton.Text = "Start"
        '
        'StopButton
        '
        Me.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StopButton.Enabled = False
        Me.StopButton.Image = CType(resources.GetObject("StopButton.Image"), System.Drawing.Image)
        Me.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(35, 22)
        Me.StopButton.Text = "Stop"
        '
        'ForceStopButton
        '
        Me.ForceStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ForceStopButton.Enabled = False
        Me.ForceStopButton.Image = CType(resources.GetObject("ForceStopButton.Image"), System.Drawing.Image)
        Me.ForceStopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForceStopButton.Name = "ForceStopButton"
        Me.ForceStopButton.Size = New System.Drawing.Size(67, 22)
        Me.ForceStopButton.Text = "Force Stop"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.PauseLogToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripMenuItem1, Me.ToolStripSeparator4, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton2.Text = "More"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'PauseLogToolStripMenuItem
        '
        Me.PauseLogToolStripMenuItem.Enabled = False
        Me.PauseLogToolStripMenuItem.Name = "PauseLogToolStripMenuItem"
        Me.PauseLogToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PauseLogToolStripMenuItem.Text = "Pause/Resume Log"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(172, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem1.Text = "Generate Shortcut"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(172, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel2.Text = "Max Memory:"
        '
        'MemoryText
        '
        Me.MemoryText.Name = "MemoryText"
        Me.MemoryText.Size = New System.Drawing.Size(45, 25)
        Me.MemoryText.Text = "1024"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.InputTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 20)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.OutPutTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 262)
        Me.Panel2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 329)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CraftBukkit Launcher"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SelectJarButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MemoryText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

End Class
