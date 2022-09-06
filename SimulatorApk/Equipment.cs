using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SimulatorApk
{
    public class Equipment : IEquatable<Equipment>
    {
        // dictionary is better
        //public static readonly List<Equipment> Equipments = new List<Equipment>();

        public static Dictionary<string, Equipment> Equipments { get; } = new();


        //Weapon properties
        private int DmgMin { get; set; }
        private int DmgMax { get; set; }
        private int HitRate { get; set; }
        private int CritChance { get; set; }
        private int CritDmg { get; set; }
        public int Rarity { get; set; }
        public int UpgradeLevel { get; set; }


        // display
        public override string ToString()
        {
            return " Dmg: " + DmgMin + " - " + DmgMax + "\n" +
                   " HitRate: " + HitRate + "\n" +
                   " CritChance: " + CritChance + "\n" +
                   " CritDmg: " + CritDmg + "\n" +
                   " Rarity: " + Rarity + "\n" +
                   " Upgrade Lvl: " + UpgradeLevel;
        }


        public bool Equals(Equipment other)
        {
            return other is not null && ReferenceEquals(this, other);
        }
        

        public override bool Equals(object other)
        {
            return Equals(other as Equipment);
        }


        public override int GetHashCode()
        {
            return (Equipments != null ? Equipments.GetHashCode() : 0);
        }


        //Equipment constructor
        private Equipment(int dmgMax, int dmgMin, int hitRate,
                          int critChance, int critDmg, int rarity, int upgradeLvl)
        {
            DmgMax = dmgMax;
            DmgMin = dmgMin;
            HitRate = hitRate;
            CritChance = critChance;
            CritDmg = critDmg;
            Rarity = rarity;
            UpgradeLevel = upgradeLvl;
        }


        public static void ClearInstancesOne()
        {
            File.Delete(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dict2.txt");
        }


        // creates instance of Equipment class and assigns it's parameters
        public static void CreateInstance()
        {
            const string separator = ";";
            StringBuilder sbOutput = new();
            var random = new Random();

            for (var i = 1; i <= 5; i++)
            {
                Equipments["button" + i] = new Equipment(
                    dmgMin: random.Next(150 * i, 500 * i),
                    dmgMax: random.Next(550 * i, 1200 * i),
                    hitRate: random.Next(100 * i, 350 * i),
                    critChance: random.Next(8, 22),
                    critDmg: random.Next(175, 450),
                    rarity: random.Next(1, 3),
                    upgradeLvl: random.Next(0, 0));
            }
            sbOutput.AppendLine(string.Join(separator, Equipments));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dict.txt", sbOutput.ToString());
        }


        // overload, changing values of just selected item of Equipment
        public static void CreateInstance(string s)
        {
            const string separator = ";";
            StringBuilder sbOutput = new(); 
            var random = new Random();

            s ??= "button1";

            var y = int.Parse(s.Replace("button", ""));

            Equipments[s] = new Equipment(
                dmgMin: random.Next(150 * y, 500 * y),
                dmgMax: random.Next(550 * y, 1200 * y),
                hitRate: random.Next(100 * y, 350 * y),
                critChance: random.Next(8, 22),
                critDmg: random.Next(175, 450),
                rarity: random.Next(1, 3),
                upgradeLvl: random.Next(0, 0));

            sbOutput.AppendLine(string.Join(separator, Equipments));
            File.AppendAllText(@"C:\Users\Admin\Desktop\Games\Repos\SimulatorApk\dict2.txt", sbOutput.ToString());
        }


        //debug list for equipment
        public static void EqList()
        {
            foreach (var aPart in Equipments)
            {
                Debug.WriteLine(aPart);
            }
        }
    }
}