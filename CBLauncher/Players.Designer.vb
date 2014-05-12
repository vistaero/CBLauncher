<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PlayerNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PlayerWhiteListedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IsOperatorColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItIsBannedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BanDateColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BanReasonColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BanExpiresColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BanSourceColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PlayerUUIDColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.WhiteListButton = New System.Windows.Forms.ToolStripButton()
        Me.OperatorButton = New System.Windows.Forms.ToolStripButton()
        Me.BannedButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PlayerNameColumn, Me.PlayerWhiteListedColumn, Me.IsOperatorColumn, Me.ItIsBannedColumn, Me.BanDateColumn, Me.BanReasonColumn, Me.BanExpiresColumn, Me.BanSourceColumn, Me.PlayerUUIDColumn})
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PlayerNameColumn
        '
        resources.ApplyResources(Me.PlayerNameColumn, "PlayerNameColumn")
        '
        'PlayerWhiteListedColumn
        '
        resources.ApplyResources(Me.PlayerWhiteListedColumn, "PlayerWhiteListedColumn")
        '
        'IsOperatorColumn
        '
        resources.ApplyResources(Me.IsOperatorColumn, "IsOperatorColumn")
        '
        'ItIsBannedColumn
        '
        resources.ApplyResources(Me.ItIsBannedColumn, "ItIsBannedColumn")
        '
        'BanDateColumn
        '
        resources.ApplyResources(Me.BanDateColumn, "BanDateColumn")
        '
        'BanReasonColumn
        '
        resources.ApplyResources(Me.BanReasonColumn, "BanReasonColumn")
        '
        'BanExpiresColumn
        '
        resources.ApplyResources(Me.BanExpiresColumn, "BanExpiresColumn")
        '
        'BanSourceColumn
        '
        resources.ApplyResources(Me.BanSourceColumn, "BanSourceColumn")
        '
        'PlayerUUIDColumn
        '
        resources.ApplyResources(Me.PlayerUUIDColumn, "PlayerUUIDColumn")
        '
        'ToolStrip4
        '
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhiteListButton, Me.OperatorButton, Me.BannedButton, Me.ToolStripSeparator1, Me.AddButton})
        resources.ApplyResources(Me.ToolStrip4, "ToolStrip4")
        Me.ToolStrip4.Name = "ToolStrip4"
        '
        'WhiteListButton
        '
        Me.WhiteListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.WhiteListButton, "WhiteListButton")
        Me.WhiteListButton.Name = "WhiteListButton"
        '
        'OperatorButton
        '
        Me.OperatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.OperatorButton, "OperatorButton")
        Me.OperatorButton.Name = "OperatorButton"
        '
        'BannedButton
        '
        Me.BannedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.BannedButton, "BannedButton")
        Me.BannedButton.Name = "BannedButton"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'AddButton
        '
        Me.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.AddButton, "AddButton")
        Me.AddButton.Name = "AddButton"
        '
        'Form2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ToolStrip4)
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PlayerNameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PlayerWhiteListedColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents IsOperatorColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItIsBannedColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BanDateColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BanReasonColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BanExpiresColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BanSourceColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PlayerUUIDColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents WhiteListButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OperatorButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BannedButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddButton As System.Windows.Forms.ToolStripButton
End Class
