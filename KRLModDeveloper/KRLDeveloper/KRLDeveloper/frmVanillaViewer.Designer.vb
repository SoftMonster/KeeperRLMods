<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVanillaViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbEditors = New System.Windows.Forms.TabControl()
        Me.tbPlayerCreatures = New System.Windows.Forms.TabPage()
        Me.dgvPlayerCreatures = New System.Windows.Forms.DataGridView()
        Me.tbCreatures = New System.Windows.Forms.TabPage()
        Me.dgvCreatures = New System.Windows.Forms.DataGridView()
        Me.tbCreatureInventory = New System.Windows.Forms.TabPage()
        Me.dgvCreatureInventory = New System.Windows.Forms.DataGridView()
        Me.tbTechnology = New System.Windows.Forms.TabPage()
        Me.dgvTechnology = New System.Windows.Forms.DataGridView()
        Me.tbImmigration = New System.Windows.Forms.TabPage()
        Me.dgvImmigration = New System.Windows.Forms.DataGridView()
        Me.tbWorkShopsMenu = New System.Windows.Forms.TabPage()
        Me.dgvWorkshopsMenu = New System.Windows.Forms.DataGridView()
        Me.tbBuildMenu = New System.Windows.Forms.TabPage()
        Me.dgvBuildMenu = New System.Windows.Forms.DataGridView()
        Me.tbCampaignVillains = New System.Windows.Forms.TabPage()
        Me.DgvCampaignVillains = New System.Windows.Forms.DataGridView()
        Me.tbZLevels = New System.Windows.Forms.TabPage()
        Me.dgvZLevels = New System.Windows.Forms.DataGridView()
        Me.tbEnemies = New System.Windows.Forms.TabPage()
        Me.dgvResources = New System.Windows.Forms.DataGridView()
        Me.tbEditors.SuspendLayout()
        Me.tbPlayerCreatures.SuspendLayout()
        CType(Me.dgvPlayerCreatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCreatures.SuspendLayout()
        CType(Me.dgvCreatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCreatureInventory.SuspendLayout()
        CType(Me.dgvCreatureInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTechnology.SuspendLayout()
        CType(Me.dgvTechnology, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbImmigration.SuspendLayout()
        CType(Me.dgvImmigration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbWorkShopsMenu.SuspendLayout()
        CType(Me.dgvWorkshopsMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBuildMenu.SuspendLayout()
        CType(Me.dgvBuildMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCampaignVillains.SuspendLayout()
        CType(Me.DgvCampaignVillains, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbZLevels.SuspendLayout()
        CType(Me.dgvZLevels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbEnemies.SuspendLayout()
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEditors
        '
        Me.tbEditors.Controls.Add(Me.tbPlayerCreatures)
        Me.tbEditors.Controls.Add(Me.tbCreatures)
        Me.tbEditors.Controls.Add(Me.tbCreatureInventory)
        Me.tbEditors.Controls.Add(Me.tbTechnology)
        Me.tbEditors.Controls.Add(Me.tbImmigration)
        Me.tbEditors.Controls.Add(Me.tbWorkShopsMenu)
        Me.tbEditors.Controls.Add(Me.tbBuildMenu)
        Me.tbEditors.Controls.Add(Me.tbCampaignVillains)
        Me.tbEditors.Controls.Add(Me.tbZLevels)
        Me.tbEditors.Controls.Add(Me.tbEnemies)
        Me.tbEditors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEditors.Location = New System.Drawing.Point(0, 0)
        Me.tbEditors.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEditors.Name = "tbEditors"
        Me.tbEditors.SelectedIndex = 0
        Me.tbEditors.Size = New System.Drawing.Size(1067, 554)
        Me.tbEditors.TabIndex = 0
        '
        'tbPlayerCreatures
        '
        Me.tbPlayerCreatures.Controls.Add(Me.dgvPlayerCreatures)
        Me.tbPlayerCreatures.Location = New System.Drawing.Point(4, 25)
        Me.tbPlayerCreatures.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPlayerCreatures.Name = "tbPlayerCreatures"
        Me.tbPlayerCreatures.Padding = New System.Windows.Forms.Padding(4)
        Me.tbPlayerCreatures.Size = New System.Drawing.Size(1059, 525)
        Me.tbPlayerCreatures.TabIndex = 0
        Me.tbPlayerCreatures.Text = "Player Creatures"
        Me.tbPlayerCreatures.UseVisualStyleBackColor = True
        '
        'dgvPlayerCreatures
        '
        Me.dgvPlayerCreatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayerCreatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPlayerCreatures.Location = New System.Drawing.Point(4, 4)
        Me.dgvPlayerCreatures.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPlayerCreatures.Name = "dgvPlayerCreatures"
        Me.dgvPlayerCreatures.RowHeadersWidth = 51
        Me.dgvPlayerCreatures.Size = New System.Drawing.Size(1051, 517)
        Me.dgvPlayerCreatures.TabIndex = 1
        '
        'tbCreatures
        '
        Me.tbCreatures.Controls.Add(Me.dgvCreatures)
        Me.tbCreatures.Location = New System.Drawing.Point(4, 25)
        Me.tbCreatures.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCreatures.Name = "tbCreatures"
        Me.tbCreatures.Padding = New System.Windows.Forms.Padding(4)
        Me.tbCreatures.Size = New System.Drawing.Size(1059, 525)
        Me.tbCreatures.TabIndex = 1
        Me.tbCreatures.Text = "Creatures"
        Me.tbCreatures.UseVisualStyleBackColor = True
        '
        'dgvCreatures
        '
        Me.dgvCreatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCreatures.Location = New System.Drawing.Point(4, 4)
        Me.dgvCreatures.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCreatures.Name = "dgvCreatures"
        Me.dgvCreatures.RowHeadersWidth = 51
        Me.dgvCreatures.Size = New System.Drawing.Size(1051, 517)
        Me.dgvCreatures.TabIndex = 2
        '
        'tbCreatureInventory
        '
        Me.tbCreatureInventory.Controls.Add(Me.dgvCreatureInventory)
        Me.tbCreatureInventory.Location = New System.Drawing.Point(4, 25)
        Me.tbCreatureInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCreatureInventory.Name = "tbCreatureInventory"
        Me.tbCreatureInventory.Size = New System.Drawing.Size(1059, 525)
        Me.tbCreatureInventory.TabIndex = 2
        Me.tbCreatureInventory.Text = "Creature Inventory"
        Me.tbCreatureInventory.UseVisualStyleBackColor = True
        '
        'dgvCreatureInventory
        '
        Me.dgvCreatureInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreatureInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCreatureInventory.Location = New System.Drawing.Point(0, 0)
        Me.dgvCreatureInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCreatureInventory.Name = "dgvCreatureInventory"
        Me.dgvCreatureInventory.RowHeadersWidth = 51
        Me.dgvCreatureInventory.Size = New System.Drawing.Size(1059, 525)
        Me.dgvCreatureInventory.TabIndex = 2
        '
        'tbTechnology
        '
        Me.tbTechnology.Controls.Add(Me.dgvTechnology)
        Me.tbTechnology.Location = New System.Drawing.Point(4, 25)
        Me.tbTechnology.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTechnology.Name = "tbTechnology"
        Me.tbTechnology.Size = New System.Drawing.Size(1059, 525)
        Me.tbTechnology.TabIndex = 3
        Me.tbTechnology.Text = "Technology"
        Me.tbTechnology.UseVisualStyleBackColor = True
        '
        'dgvTechnology
        '
        Me.dgvTechnology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTechnology.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTechnology.Location = New System.Drawing.Point(0, 0)
        Me.dgvTechnology.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTechnology.Name = "dgvTechnology"
        Me.dgvTechnology.RowHeadersWidth = 51
        Me.dgvTechnology.Size = New System.Drawing.Size(1059, 525)
        Me.dgvTechnology.TabIndex = 2
        '
        'tbImmigration
        '
        Me.tbImmigration.Controls.Add(Me.dgvImmigration)
        Me.tbImmigration.Location = New System.Drawing.Point(4, 25)
        Me.tbImmigration.Margin = New System.Windows.Forms.Padding(4)
        Me.tbImmigration.Name = "tbImmigration"
        Me.tbImmigration.Size = New System.Drawing.Size(1059, 525)
        Me.tbImmigration.TabIndex = 4
        Me.tbImmigration.Text = "Immigration"
        Me.tbImmigration.UseVisualStyleBackColor = True
        '
        'dgvImmigration
        '
        Me.dgvImmigration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImmigration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvImmigration.Location = New System.Drawing.Point(0, 0)
        Me.dgvImmigration.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvImmigration.Name = "dgvImmigration"
        Me.dgvImmigration.RowHeadersWidth = 51
        Me.dgvImmigration.Size = New System.Drawing.Size(1059, 525)
        Me.dgvImmigration.TabIndex = 2
        '
        'tbWorkShopsMenu
        '
        Me.tbWorkShopsMenu.Controls.Add(Me.dgvWorkshopsMenu)
        Me.tbWorkShopsMenu.Location = New System.Drawing.Point(4, 25)
        Me.tbWorkShopsMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tbWorkShopsMenu.Name = "tbWorkShopsMenu"
        Me.tbWorkShopsMenu.Size = New System.Drawing.Size(1059, 525)
        Me.tbWorkShopsMenu.TabIndex = 5
        Me.tbWorkShopsMenu.Text = "Workshops Menu"
        Me.tbWorkShopsMenu.UseVisualStyleBackColor = True
        '
        'dgvWorkshopsMenu
        '
        Me.dgvWorkshopsMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkshopsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkshopsMenu.Location = New System.Drawing.Point(0, 0)
        Me.dgvWorkshopsMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvWorkshopsMenu.Name = "dgvWorkshopsMenu"
        Me.dgvWorkshopsMenu.RowHeadersWidth = 51
        Me.dgvWorkshopsMenu.Size = New System.Drawing.Size(1059, 525)
        Me.dgvWorkshopsMenu.TabIndex = 2
        '
        'tbBuildMenu
        '
        Me.tbBuildMenu.Controls.Add(Me.dgvBuildMenu)
        Me.tbBuildMenu.Location = New System.Drawing.Point(4, 25)
        Me.tbBuildMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tbBuildMenu.Name = "tbBuildMenu"
        Me.tbBuildMenu.Size = New System.Drawing.Size(1059, 525)
        Me.tbBuildMenu.TabIndex = 6
        Me.tbBuildMenu.Text = "Build Menu"
        Me.tbBuildMenu.UseVisualStyleBackColor = True
        '
        'dgvBuildMenu
        '
        Me.dgvBuildMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuildMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBuildMenu.Location = New System.Drawing.Point(0, 0)
        Me.dgvBuildMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBuildMenu.Name = "dgvBuildMenu"
        Me.dgvBuildMenu.RowHeadersWidth = 51
        Me.dgvBuildMenu.Size = New System.Drawing.Size(1059, 525)
        Me.dgvBuildMenu.TabIndex = 2
        '
        'tbCampaignVillains
        '
        Me.tbCampaignVillains.Controls.Add(Me.DgvCampaignVillains)
        Me.tbCampaignVillains.Location = New System.Drawing.Point(4, 25)
        Me.tbCampaignVillains.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCampaignVillains.Name = "tbCampaignVillains"
        Me.tbCampaignVillains.Size = New System.Drawing.Size(1059, 525)
        Me.tbCampaignVillains.TabIndex = 7
        Me.tbCampaignVillains.Text = "Campaign Villains"
        Me.tbCampaignVillains.UseVisualStyleBackColor = True
        '
        'DgvCampaignVillains
        '
        Me.DgvCampaignVillains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCampaignVillains.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCampaignVillains.Location = New System.Drawing.Point(0, 0)
        Me.DgvCampaignVillains.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvCampaignVillains.Name = "DgvCampaignVillains"
        Me.DgvCampaignVillains.RowHeadersWidth = 51
        Me.DgvCampaignVillains.Size = New System.Drawing.Size(1059, 525)
        Me.DgvCampaignVillains.TabIndex = 2
        '
        'tbZLevels
        '
        Me.tbZLevels.Controls.Add(Me.dgvZLevels)
        Me.tbZLevels.Location = New System.Drawing.Point(4, 25)
        Me.tbZLevels.Margin = New System.Windows.Forms.Padding(4)
        Me.tbZLevels.Name = "tbZLevels"
        Me.tbZLevels.Size = New System.Drawing.Size(1059, 525)
        Me.tbZLevels.TabIndex = 8
        Me.tbZLevels.Text = "ZLevels"
        Me.tbZLevels.UseVisualStyleBackColor = True
        '
        'dgvZLevels
        '
        Me.dgvZLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZLevels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvZLevels.Location = New System.Drawing.Point(0, 0)
        Me.dgvZLevels.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvZLevels.Name = "dgvZLevels"
        Me.dgvZLevels.RowHeadersWidth = 51
        Me.dgvZLevels.Size = New System.Drawing.Size(1059, 525)
        Me.dgvZLevels.TabIndex = 2
        '
        'tbEnemies
        '
        Me.tbEnemies.Controls.Add(Me.dgvResources)
        Me.tbEnemies.Location = New System.Drawing.Point(4, 25)
        Me.tbEnemies.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEnemies.Name = "tbEnemies"
        Me.tbEnemies.Size = New System.Drawing.Size(1059, 525)
        Me.tbEnemies.TabIndex = 9
        Me.tbEnemies.Text = "Enemies"
        Me.tbEnemies.UseVisualStyleBackColor = True
        '
        'dgvResources
        '
        Me.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResources.Location = New System.Drawing.Point(0, 0)
        Me.dgvResources.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvResources.Name = "dgvResources"
        Me.dgvResources.RowHeadersWidth = 51
        Me.dgvResources.Size = New System.Drawing.Size(1059, 525)
        Me.dgvResources.TabIndex = 2
        '
        'frmVanillaViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.tbEditors)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVanillaViewer"
        Me.Text = "Vanilla viewer"
        Me.tbEditors.ResumeLayout(False)
        Me.tbPlayerCreatures.ResumeLayout(False)
        CType(Me.dgvPlayerCreatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCreatures.ResumeLayout(False)
        CType(Me.dgvCreatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCreatureInventory.ResumeLayout(False)
        CType(Me.dgvCreatureInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTechnology.ResumeLayout(False)
        CType(Me.dgvTechnology, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbImmigration.ResumeLayout(False)
        CType(Me.dgvImmigration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbWorkShopsMenu.ResumeLayout(False)
        CType(Me.dgvWorkshopsMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBuildMenu.ResumeLayout(False)
        CType(Me.dgvBuildMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCampaignVillains.ResumeLayout(False)
        CType(Me.DgvCampaignVillains, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbZLevels.ResumeLayout(False)
        CType(Me.dgvZLevels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbEnemies.ResumeLayout(False)
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbEditors As TabControl
    Friend WithEvents tbPlayerCreatures As TabPage
    Friend WithEvents dgvPlayerCreatures As DataGridView
    Friend WithEvents tbCreatures As TabPage
    Friend WithEvents dgvCreatures As DataGridView
    Friend WithEvents tbCreatureInventory As TabPage
    Friend WithEvents tbTechnology As TabPage
    Friend WithEvents tbImmigration As TabPage
    Friend WithEvents tbWorkShopsMenu As TabPage
    Friend WithEvents tbBuildMenu As TabPage
    Friend WithEvents tbCampaignVillains As TabPage
    Friend WithEvents tbZLevels As TabPage
    Friend WithEvents tbEnemies As TabPage
    Friend WithEvents dgvCreatureInventory As DataGridView
    Friend WithEvents dgvTechnology As DataGridView
    Friend WithEvents dgvImmigration As DataGridView
    Friend WithEvents dgvWorkshopsMenu As DataGridView
    Friend WithEvents dgvBuildMenu As DataGridView
    Friend WithEvents DgvCampaignVillains As DataGridView
    Friend WithEvents dgvZLevels As DataGridView
    Friend WithEvents dgvResources As DataGridView
End Class
