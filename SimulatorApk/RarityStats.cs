﻿using System;
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
            File.Delete(@"C:\Users\Admin\Desktop\Games\SimulatorApk\dictRarity.txt");
        }
        public static void ClearInstances2()
        {
            File.Delete(@"C:\Users\Admin\Desktop\Games\SimulatorApk\dictRarity2.txt");
        }


        // Creating rarity stats and values
        public static void CreateInstance()
        {
            string strSeparator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            for (var i = 1; i <= 5; i++)
            {
                RarityBonus["button"+i] = new RarityStats(
                    armorPen:       Random.Next(12, 22),
                    hitRate:        Random.Next(100, 250),
                    basicDmg:       Random.Next(300, 900),
                    critChance:     Random.Next(4, 11),
                    stunChance:     Random.Next(1, 4),
                    elementalDmg:   Random.Next(150, 900),
                    dmg:            Random.Next(8, 18),
                    highMonster:    Random.Next(17, 29),
                    lowMonster:     Random.Next(14, 32));
            } 
            sbOutput.AppendLine(string.Join(strSeparator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\SimulatorApk\dictRarity.txt", sbOutput.ToString());
        }


        // Overload Changing rarity and stats for just selected item
        public static void CreateInstance(string s)
        {
            string strSeparator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            var x = SharedClass.RarityLvlValue.Rarity;
            
                RarityBonus[s] = new RarityStats(
                    armorPen:       Random.Next(12 * x, 22 * x),
                    hitRate:        Random.Next(100 * x, 250 * x),
                    basicDmg:       Random.Next(300 * x, 900 * x),
                    critChance:     Random.Next(4 * x, 11 * x),
                    stunChance:     Random.Next(1 * x, 4 * x),
                    elementalDmg:   Random.Next(150 * x, 900 * x),
                    dmg:            Random.Next(8 * x, 18 * x),
                    highMonster:    Random.Next(17 * x, 29 * x),
                    lowMonster:     Random.Next(14 * x, 32 * x));

            sbOutput.AppendLine(string.Join(strSeparator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\SimulatorApk\dictRarity2.txt", sbOutput.ToString());
        }
    }
}
