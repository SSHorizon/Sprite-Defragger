# Sprite-Defragger
Re-arranges sprites from NDS Pokémon ROMs

![License](https://img.shields.io/badge/License-GPLv3-blue.svg)

Sprites in NDS pokémon ROMS such as those find in the Trainer cards or the backs of player characters are stored in a fragmented way which can make them hard to edit.

The aim of this program is to open these sprites, defragment them into how they will appear in the game and then save them. After editing the software can then be used to fragment the sprite again ready to be uploaded back into the ROM using software such as [Tinke](https://github.com/pleonex/tinke)

## Building

This is a Windows Forms application which requires [.NET Framework v4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)

### Build Configurations

You can use the Debug or Release build configurations when building.

### IDE

The defragger can be opened with IDEs such as [Visual Studio](https://visualstudio.microsoft.com/downloads/) by opening the .sln or .csproj file.

### GNU/Linux

GNU/Linux is not the Operating System of developer of this program so there may be bugs; other users may not be able to reproduce the error you are experiencing.
