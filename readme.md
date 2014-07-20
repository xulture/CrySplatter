CrySplatter - Splatmap importer for CRYENGINE
=============================================

CrySplatter lets you import splatmap and assign terrain layer material to it.  This material is then distributed across terrain, as marked by the splatmap.

Splatmap is typically a black and white image (or grayscale), where white colour represents areas where selected layer will be painted, and black represents areas that will not be touched by this splat.  In case you are importing a colour bitmap, note that only blue channel is tested when it comes to splatmap, for optimization reasons.

After distributing, click on 'Save to Engine' and reload the level in CRYENGINE Sandbox

CrySplatter requires .NET Framework 4.5 installed.  It is compatible with CRYENGINE Sandbox 3.6.x (tested with 3.6.4) and CryEngine FreeSDK 3.5.x (tested with 3.5.4)

This is completely free, open source tool.  Everyone is welcome to use the code and program, whichever way they want (including, but not limited to, redistribution and inclusion into other tools), without any restrictions.

We developed this tool to aid in our level design workflow.  Future releases of CRYENGINE Sandbox may change data formats, and the tool may stop working.  Be cautious when attempting to use this tool with new versions of CRYENGINE.  In the near future, 'Segmented Terrain' feature is expected to be released, and this may affect CrySplatter functionality.

Basic usage
-----------

1. Fetch and compile using VS2013, or download compiled binary (Windows) from http://www.crydev.net/viewtopic.php?f=311&p=1227618#p1227618

2. Create a level in CRYENGINE Sandbox

3. Add texture layers (eg, grass, sand, cliffs, etc)

4. Save the level

5. Run CrySplatter, find your CRYENGINE 'game' folder, eg C:\Program Files (x86)\Steam\SteamApps\common\CRYENGINE\GameSDK

6. From the list of available levels, select the one you wish to edit

7. Select the layer to distribute, and 'Load Bitmap' to splat this layer across terrain.  Enable 'Rotate Maps When Loading' if the map needs to be rotated (see note on Rotation below)

8. Adjust white threshold using the slider below the image (see note on Blending below)

9. Click 'Save to Engine' (see note on Backup files below)

10. Re-open level in CRYENGINE Sandbox


Notes
-----

* Rotation: CRYENGINE Sandbox has a feature to import heightmap (grayscale image) for terrain.  During this import, image is rotated 90 degrees clockwise.  
  Other textures (eg terrain texture) and splatmaps will need to apply the same rotation, in order to be applied to the correct place.  Enable 'Rotate maps when loading' if this is the case for your level, or leave it unticked if you are exporting / modifying / and reimporting splatmap

* Blending: CRYENGINE applies automatic crossblending between two terrain layers.  From the Splatmap point of view, we have no access to tweak this blending.  Result of this is that each layer has to be painted with full opacity.  Various map-generating tools will, however, output splatmaps as grayscale.  Use the slider to tweak cutoff value.  Note that this value is 'applied' as soon as you select a different layer, or 'Save to Engine'  

* Backup files: although unlikely, it is possible that CrySplatter will corrupt your level.  To provide some level of protection, CrySplatter rotates 3 backup files, each time you save.  These files are with names GameSDK\Levels\<levelName>\LevelData\Heightmap.dat.crysplat.bak, .bak2, and .bak3


Internals
---------

CrySplatter rewrites LevelData\Heightmap.dat file.  This file stores information about texture layers (this part is saved as XML, and obtainable via 'View XML' button), heightmap itself, layermap, and few other components that we haven't attempted to reverse engineer.

Since its rewriting CRYENGINE Sandbox internal format, it is possible that it can, unintentionally, corrupt your level.  We recommend use of source control system for your levels so you can revert back to 'last good' version.  Alternatively, use the backup files as described above.


CrySplatter License
-------------------
CrySplatter - CRYENGINE Splatmap load tool
Copyright (C) 2014  Allegra Games

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.