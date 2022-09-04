using System.Drawing;

namespace SimulatorApk
{
    internal static class SharedClass
    {
        public static Image ImageToDisplay { get; set; }
        public static Equipment UpgradeLvlValue { get; set; }
        public static Equipment RarityLvlValue { get; set; }
        public static string ItemId { get; set; }
    }
}
