# KoikatuPlugins

Various koikatu plugins.  
ConfigurationManager from BepisPlugins is required to change settings for some of the plugins.

## Installation
1. Make sure BepInEx and BepisPlugins are installed.
2. Download the latest release from [here](https://github.com/Keelhauled/KoikatuPlugins/releases).
3. Drop the dll files you want into the folder `Koikatu\BepInEx`.

## Plugins

#### BlendShaper (*Not yet released*)
Simple and easy UI for blendshape editing.

#### CharaEditTool
Makes it easier to change hair colors when using accessories to create hair. [Video preview](https://gfycat.com/MiserlyViciousJaeger)  
To use this, save a color by selecting a color from an accessory and then press the hotkey (V by default).  
Then you can hold the hotkey to apply the saved color to every accessory color slot that has the same color as the selected color.

#### CharaStateX
Allows editing the state of multiple studio characters at once.  
Normally only a few parameters such as animation speed/pattern can be edited for multiple characters at once.
But now with this you can very easily load poses, change blinking state, switch animation, change clothing state, correct joints and so on for multiple characters at once.

Another feature in this plugin is H animation matching.  
By selecting a male and a female, and then clicking on an H anim in the list while holding the ctrl key, the plugin will automatically choose the right H animation based on their sex.

#### DefaultParamEditor
Allows editing default settings for character/scene parameters such as eye blinking or shadow density.  
This only affects parameters that make sense to be saved.

To use, set your preferred settings normally and then save them in ConfigurationManager.  
Now when loading a character or starting the studio these settings will be the defaults.

#### FixCompilation
Various fixes and tweaks for the game.

```
- Hide the cameratarget
- Avoid exceptions caused by certain hair accessories
- Huge performance gains in chara maker
- Disable character name in maker
- Prevent cursor movement in maker while moving the camera
```

#### GraphicsSettings
Exposes the game's graphics settings and some other values for editing.  
The default settings on the plugin may be too heavy for some computers so remember to tweak them.

#### HideUIKK (*Not yet released*)
Hide all the UI with one click, hotkey is `M` by default.  
More menus can be added by editing `HideUI.txt`.

#### LockOnPluginKK
Pretty much the same as the [HS version](https://keelhauled.github.io/LockOnPlugin/).  
The only changes are that now data files are contained inside the dll and that individual FK/IK points can be locked on to.  
Default hotkey to lock on is one of the extra mouse buttons. If you don't have those, change the key with ConfigurationManager.

#### MakerBridge
Press the hotkey to send the selected character from maker to studio and vice versa.  
Default hotkey is B.

#### StudioAddonLite (*Not yet released*)
A few HSStudioAddon features ported over to KK.  
Simultaneous FK & IK and better object manipulation controls.

#### TitleShortcuts
Title menu keyboard shortcuts to open different modes.  
For example, press F to open the female editor.  
Also has a setting to start certain modes automatically during startup.  
Hold esc just before the title screen to cancel automatic startup.

#### TogglePOVKK (*Not yet released*)
A port of the TogglePOV mod from HS.

#### UnlockHPositions
Unlock all H positions right away without having a save file to unlock them.  
Optionally every possible position can be unlocked regardless of if it was meant to be used in that spot or not.

## Credits
Keelhauled  
MarC0 for a few FixCompilation features  
Original maker of TogglePOV
