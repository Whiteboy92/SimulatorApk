using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimulatorApk
{
    internal class RarityStats
    {
        private static readonly Random Random = new();

        public static Dictionary<string, RarityStats> RarityBonus { get; } = new();

        private int ArmorPenetration { get; set; }
        private int BonusHitRate { get; set; }
        private int BonusBasicDmg { get; set; }
        private int BonusCritChance { get; set; }
        private int StunChance { get; set; }
        private int ElementalDmg { get; set; }
        private int BonusDmg { get; set; }
        private int HighLvlMonsterDmg { get; set; }
        private int LowLvlMonsterDmg { get; set; }


        // RarityStats constructor
        private RarityStats(int armorPen, int hitRate, int basicDmg, int critChance, int stunChance,
                            int elementalDmg, int dmg, int highMonster, int lowMonster)
        {
            ArmorPenetration = armorPen;
            BonusHitRate = hitRate;
            BonusBasicDmg = basicDmg;
            BonusCritChance = critChance;
            StunChance = stunChance;
            ElementalDmg = elementalDmg;
            BonusDmg = dmg;
            HighLvlMonsterDmg = highMonster;
            LowLvlMonsterDmg = lowMonster;
        }


        // display rarity stats
        public override string ToString()
        {
            return " ArmorPenetration: " + ArmorPenetration + "\n" +
                   " BonusHitRate " + BonusHitRate + "\n" +
                   " BonusBasicDmg: " + BonusBasicDmg + "\n" +
                   " BonusCritChance: " + BonusCritChance + "%" + "\n" +
                   " StunChance: " + StunChance + "%" + "\n" +
                   " ElementalDmg: " + ElementalDmg + "\n" +
                   " BonusDmg: " + BonusDmg + "\n" +
                   " HighLvlMonsterDmg: " + HighLvlMonsterDmg + "\n" +
                   " LowLvlMonsterDmg: " + LowLvlMonsterDmg;
        }


        public static void ClearInstances()
        {
            File.Delete(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dictRarity.txt");
        }
        public static void ClearInstances2()
        {
            File.Delete(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dictRarity2.txt");
        }


        private static int GetRandomNumberFromRange(int min, int max)
        {
            _ = new Random();
            return Random.Next(min, max);
        }

        // Creating rarity stats and values
        public static void CreateInstance()
        {
            const string separator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            for (var i = 1; i <= 5; i++)
            {
                RarityBonus["button"+i] = new RarityStats(
                    armorPen:       GetRandomNumberFromRange(12, 22),
                    hitRate:        GetRandomNumberFromRange(100, 250),
                    basicDmg:       GetRandomNumberFromRange(300, 900),
                    critChance:     GetRandomNumberFromRange(4, 11),
                    stunChance:     GetRandomNumberFromRange(1, 4),
                    elementalDmg:   GetRandomNumberFromRange(150, 900),
                    dmg:            GetRandomNumberFromRange(8, 18),
                    highMonster:    GetRandomNumberFromRange(17, 29),
                    lowMonster:     GetRandomNumberFromRange(14, 32));
            } 
            sbOutput.AppendLine(string.Join(separator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dictRarity.txt", sbOutput.ToString());
        }


        // Overload Changing rarity and stats for just selected item
        public static void CreateInstance(string s)
        {
            const string separator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            var x = SharedClass.RarityLvlValue.Rarity;
            
                RarityBonus[s] = new RarityStats(
                    armorPen:       GetRandomNumberFromRange(12 * x, 22 * x),
                    hitRate:        GetRandomNumberFromRange(100 * x, 250 * x),
                    basicDmg:       GetRandomNumberFromRange(300 * x, 900 * x),
                    critChance:     GetRandomNumberFromRange(4 * x, 11 * x),
                    stunChance:     GetRandomNumberFromRange(1 * x, 4 * x),
                    elementalDmg:   GetRandomNumberFromRange(150 * x, 900 * x),
                    dmg:            GetRandomNumberFromRange(8 * x, 18 * x),
                    highMonster:    GetRandomNumberFromRange(17 * x, 29 * x),
                    lowMonster:     GetRandomNumberFromRange(14 * x, 32 * x));

            sbOutput.AppendLine(string.Join(separator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dictRarity2.txt", sbOutput.ToString());
        }
    }
}
