# Clear Small Waterfalls – Synthesis patcher

Optional companion patcher for **Clear Small Waterfalls** (Skyrim SE/AE). It fits every small stream to your own load order:

- **Colour.** Each stream and ripple gets the colour of the water it falls into. Under ENB it uses a per-area colour table (Whiterun, the Rift, the rest), which you can edit in the settings. Without ENB (vanilla or Community Shaders) it reads the water colour from your water mods.
- **Length.** Each stream ends exactly at its own floor or water surface.
- **Splashes.** Under small drains only, splashes are softened, heavy churn foam is removed, foam rings become clear ripples, and splashes are recentred on the stream. Big cascades are never touched.
- **Other mods.** Drains added by other mods and DLC are handled too.

## Requirements
- Clear Small Waterfalls **7.3 or newer** (ENB, or CS & Open Shaders version), installed and enabled.
- [Synthesis](https://github.com/Mutagen-Modding/Synthesis), launched from your mod manager.

## Install
- **Easiest:** download the `.synth` file from the Nexus page. In Synthesis, click your patcher group, then double-click the `.synth` file.
- **Manual:** in Synthesis, click **+** next to a group, choose **Git Repository**, paste this repository's URL, then pick the project `ClearSmallWaterfallsPatcher`.

## Run
1. Put it after any other water patcher (for example the Water for ENB patcher) in the same group.
2. Run Synthesis.
3. The generated meshes and textures are written next to the output plugin. In MO2 they go to your Synthesis output mod, or to Overwrite.
4. Keep `ClearSmallWaterfalls.esp` enabled. The patcher recalculates and replaces its edits.
5. Run Synthesis again whenever you change water mods, ENB or lighting.

## Settings
| Setting | What it does |
|---|---|
| ColourStyle | Auto (ENB if `enbseries.ini` is in the game folder), Vanilla, or ENB |
| EnbColours | ENB colour per area, as `Area=R,G,B`. Area can be a worldspace editor ID, a weather region editor ID, `Interior` or `Default` |
| KeepVanilla | Streams to leave fully vanilla. Use the ref ID from the console, e.g. `00092100`, or `Plugin.esp:092100` |
| TintStreams / FitStreamLength / HandleSplashes | Turn each part on or off |

## Troubleshooting
- **The build fails under MO2** (access denied, or a blocked build): run `Synthesis.exe` once directly, outside MO2. Let it build the patcher, close it, then run it from MO2 as usual.
- **Check what it did:** `ClearSmallWaterfalls_log.txt` is next to the built patcher, and the Synthesis log has the same lines prefixed with `[CSW]`.
