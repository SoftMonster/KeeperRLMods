Public Class frmVanillaViewer

    Public VanillaFolder As String = "C:\Program Files (x86)\Steam\steamapps\common\KeeperRL\data_free\game_config\vanilla"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPlayerCreatures.AutoGenerateColumns = True

        'txt.StartsWith("{""") Or
        'txt.StartsWith("type =") Or
        Dim gridData1 As New clsCreaturePopulator
        gridData1.FileName = VanillaFolder + "\player_creatures.txt"
        gridData1.lineBreak = "{ """
        gridData1.lineBreak2 = "creatureId = "
        gridData1.Load()
        dgvPlayerCreatures.DataSource = gridData1.DisplayData

        Dim gridData2 As New clsCreaturePopulator
        gridData2.FileName = VanillaFolder + "\creatures.txt"
        gridData2.lineBreak = """"
        gridData2.Load()
        dgvCreatures.DataSource = gridData2.DisplayData

        Dim gridData3 As New clsCreaturePopulator
        gridData3.FileName = VanillaFolder + "\creature_inventory.txt"
        gridData3.lineBreak = "{"""
        gridData3.Load()
        dgvCreatureInventory.DataSource = gridData3.DisplayData

        Dim gridData4 As New clsCreaturePopulator
        gridData4.FileName = VanillaFolder + "\technology.txt"
        gridData4.lineBreak = """"
        gridData4.Load()
        dgvTechnology.DataSource = gridData4.DisplayData

        Dim gridData5 As New clsCreaturePopulator
        gridData5.FileName = VanillaFolder + "\immigration.txt"
        gridData5.lineBreak = """"
        gridData5.lineBreak2 = "ids = "
        gridData5.Load()
        dgvImmigration.DataSource = gridData5.DisplayData

        Dim gridData6 As New clsCreaturePopulator
        gridData6.FileName = VanillaFolder + "\workshops_menu.txt"
        gridData6.lineBreak = "{item ="
        gridData6.lineBreak2 = "{{"
        gridData6.Load()
        dgvWorkshopsMenu.DataSource = gridData6.DisplayData

        Dim gridData7 As New clsCreaturePopulator
        gridData7.FileName = VanillaFolder + "\build_menu.txt"
        gridData7.lineBreak = """"
        gridData7.lineBreak2 = "{"
        gridData7.Load()
        dgvBuildMenu.DataSource = gridData7.DisplayData

        Dim gridData8 As New clsCreaturePopulator
        gridData8.FileName = VanillaFolder + "\campaign_villains.txt"
        gridData8.lineBreak = ""
        gridData8.Load()
        DgvCampaignVillains.DataSource = gridData8.DisplayData

        Dim gridData9 As New clsCreaturePopulator
        gridData9.FileName = VanillaFolder + "\zlevels.txt"
        gridData9.lineBreak = "type ="
        gridData9.Load()
        dgvZLevels.DataSource = gridData9.DisplayData

        Dim gridData10 As New clsCreaturePopulator
        gridData10.FileName = VanillaFolder + "\resources.txt"
        gridData10.lineBreak = "counts ="
        gridData10.Load()
        dgvResources.DataSource = gridData10.DisplayData

        Dim gridData11 As New clsCreaturePopulator
        gridData11.FileName = VanillaFolder + "\enemies.txt"
        gridData11.lineBreak = """"
        gridData11.Load()
        dgvResources.DataSource = gridData11.DisplayData
    End Sub

End Class
