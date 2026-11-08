using System.Collections.Generic;
using Mutagen.Bethesda.Synthesis.Settings;

namespace ClearSmallWaterfallsPatcher
{
    public enum ColourStyle
    {
        Auto,
        Vanilla,
        ENB,
    }

    public class Settings
    {
        [SynthesisTooltip("How stream tints are derived from your water mod's colours. Auto: ENB style if an ENB is installed in the game folder, otherwise vanilla/Community Shaders style.")]
        public ColourStyle ColourStyle = ColourStyle.Auto;

        [SynthesisTooltip("ENB only: stream/ripple colour per area, as Area=R,G,B. Area = a worldspace editor ID (WhiterunWorld, RiftenWorld...), a weather region editor ID (WeatherWhiterun, WeatherFallForest, WeatherPineForest, WeatherTundra, WeatherReach, WeatherSnow...), Interior, or Default. First match wins in this order: worldspace, weather region, Interior, Default. Defaults were calibrated on screenshots of Water for ENB under ENB: keep each water's on-screen hue at a darkness that stays visible on stone.")]
        public List<string> EnbColours = new()
        {
            "WhiterunWorld=15,19,28",
            "WeatherWhiterun=15,19,28",
            "RiftenWorld=19,42,47",
            "WeatherFFRiften=19,42,47",
            "WeatherFallForest=19,42,47",
            "Interior=14,22,26",
            "Default=14,22,26",
        };

        [SynthesisTooltip("Streams to leave completely vanilla (stream and its foam). One reference per line, as shown by the console when you click it: e.g. 00092100, or Plugin.esp:092100 for streams added by mods. The defaults are the wide waterfall sheets of Markarth.")]
        public List<string> KeepVanilla = new()
        {
            "00092100",
            "000920FF",
            "00092115",
            "00092118",
        };

        [SynthesisTooltip("Tint every small stream with the colour of the water it falls into (from your final load order).")]
        public bool TintStreams = true;

        [SynthesisTooltip("Cut each stream so it ends at its own floor or water surface.")]
        public bool FitStreamLength = true;

        [SynthesisTooltip("Under small drains only: soften splashes, remove heavy churn foam, turn foam rings on water into clear ripples, recentre splashes on the stream. Cascades are never touched.")]
        public bool HandleSplashes = true;
    }
}
