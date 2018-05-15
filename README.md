# G230_Final_SP
Digital Arts G230 Final Project Steam Punk

Requires Unity 64 bit, 2017.3.0f3

Developer Build:
Used the following assets from the Unity Asset Store:
Requires UNITY TECHNOLOGIES "ProBuilder", UNITY TECHNOLOGIES "ProGrids",
AARO4130 "Scene OBJ Exporter"* from the Unity Asset Store.
Used the following assets from 3rd party sites:
Colosseum 3d Model (https://free3d.com/3d-model/colosseum-37887.html)

Tester Build:
Requires TERRAMORPH WORKSHOP "Natural Tiling Textures", 
LEX4ART "Real Materials Vol.0 [FREE]" from the Unity Asset Store.


For more information about Unity see: https://unity3d.com/
For more information about the Unity Asset Store see: https://assetstore.unity.com/

Connect with me if you have any questions:
https://connect.unity.com/u/581a1ac032b306001b43e432







* The following changes where applied to .cs from the Asset Store Link:
https://assetstore.unity.com/packages/tools/utilities/scene-obj-exporter-22250

	small fixes for 5.6		a year ago
	andrew-lukasik			on version 2.01
Open OBJExporter.cs and:

- Delete this line:
"tImporter.textureType = TextureImporterType.Advanced;"

- Replace:
"catch ( System.Exception ex ) {"
with:
"catch {"

- Replace:
"Application.loadedLevelName"
with:
"UnityEngine.SceneManagement.SceneManager.GetActiveScene().name"

