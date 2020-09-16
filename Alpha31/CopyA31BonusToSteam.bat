xcopy "C:\Program Files (x86)\Steam\steamapps\common\KeeperRL\mods\A31Bonus\version_info" "C:\KeeperRLMods\Alpha31\A31Bonus\version_info" /y
RMDIR /S /Q "C:\Program Files (x86)\Steam\steamapps\common\KeeperRL\mods\A31Bonus\"
xcopy /s /i "C:\KeeperRLMods\Alpha31\A31Bonus" "C:\Program Files (x86)\Steam\steamapps\common\KeeperRL\mods\A31Bonus"
