## Alaska ATV Simulator for VR or WebGL

This is a Unity application that simulates an All-Terrain Vehicle (ATV), and is designed to be usable via either VR (SteamVR) or WebGL.


## WebGL link:
The WebGL version is playable at:
   https://scifi6546.github.io/ATV_GL_EXPORT/

### WebGL Keys:
- p: Pause
- b: Rewind
- r: Respawn
- w: forward
- a: left
- s: back
- d: right
- space: brake

## Developer Guide
We currently target Unity 2019.4 LTS.

For WebGL development, use Unity Scene Assets/Scenes/WebGL/procedural_terrain.scene.  To build the WebGL version, Window -> Rendering -> Lighting Settings and Generate the lightmap (takes several minutes, depending on your CPU speed).  Then make the HTML and WASM with File -> Build Settings, make sure WebGL/Menu and WebGL/procedural_terrain are in the build, and Build and Run to the "AK_ATV/docs" folder (takes about 10 minutes).

For VR development, use Unity Scene Assets/Scenes/VR/procedural_terrain.scene.
In VR, we are developing a lightweight portable "flight simulator" with handlebars.


## Download and Development
This repo takes 1.8GB of network to clone, and 5GB of disk space to build.

For ease of development, these versions of these Unity Assets are included.
They're from the Unity Asset store:
- Terrain Tools Sample Asset Pack, by Unity
        https://assetstore.unity.com/packages/2d/textures-materials/terrain-tools-sample-asset-pack-145808

- Rocks and Boulders 2, by K4
        https://assetstore.unity.com/packages/3d/props/exterior/rock-and-boulders-2-6947

- US Road Signs Free, by Covalence Studios
        https://assetstore.unity.com/packages/3d/props/exterior/us-road-signs-free-164941
        
- Black Bear 3D Model, by umar6419
        https://free3d.com/3d-model/black-bear-87483.html
        
- Planes & Choppers - PolyPack, by Alstra Infinite
        https://assetstore.unity.com/packages/3d/vehicles/air/planes-choppers-polypack-194946
        
- Grass Flowers Pack Free, by ALP8310
        https://assetstore.unity.com/packages/2d/textures-materials/grass-flowers-pack-free-138810

- SteamVR, by Steam
        https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647

They each have their own licenses.

## Developer History
Originally developed by Dr. Orion Lawlor <lawlor@alaska.edu> in 2019-2020.

In Spring 2020 this was massively extended by Kim Fairbanks (graphics), Chris McClure (menus), Curtis Fortenberry (VR), and Jacob Guenther (time rewind).

In Spring 2021 this project was further developed by Dylan Palmieri, Tailon Russell, Greg Talotta, and Ben Talotta. Major additions include documentation with Doxygen, bugfixes, and new scenarios. Greg also worked on adding a script that can spin a chair when the ATV turns, his work is located here: https://github.com/GregTalotta/241_chair_spin

In Spring 2022 this project was further developed by Nicholas Alexeev (aesthetic design), Riley Maranville (mobile port and VR), Rose Peters (vehicle physics and models, UI), and Yali Wang (scenarios logic design). Major additions include bugfixes, new 3D models, new scenarios, new minimap, new UI and menu design, and mobile deployment. Script especially for triggering audios within scenarios was added too. VR deployment has been developed but the team found many obstacles to further implement that.

This work has been funded by the US Department of Transportation's Univerity Transportation Center program, Grant #DTRT13-G-UTC4O through the Pacific Northwest Regional University Transportation Center (PacTrans).  

