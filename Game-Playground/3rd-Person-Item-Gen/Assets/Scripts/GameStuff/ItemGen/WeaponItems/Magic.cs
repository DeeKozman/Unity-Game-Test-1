using GameStuff.Interfaces;
using GameStuff.ItemGen;
using GameStuff.Utility.Enums;
using System.Collections.Generic;
using System;

namespace GameStuff.ItemGen.WeaponItems
{

    public class Magic : GameItem, IWeapon, IBaseItem
    {
        private static List<string> magicSuffixes = new List<string>
            {
                "Ephemeral",
                "Unholy",
                "Windborne",
                "Mocking",
                "Forgotten",
                "Vile",
                "Unnatural",
                "Mythical",
                "Fiery",
                "Glowing",
                "Electric",
                "Hellish",
                "Sacred",
                "Lupine",
                "Spider's",
                "Chaotic",
                "Ghost Touch",
                "Heliacal",
                "Unearthed",
                "Lunar",
                "Quantum",
                "Corrosive",
                "Consecrated",
                "Malediction",
                "Enchanting",
                "Murderous",
                "Nullifying",
                "Southern",
                "Maligning",
                "Voltaic",
                "Courser's",
                "Dark",
                "Forbiden",
                "Conjurer's",
                "Grim",
                "Hellfire",
                ""
            };

        public WeaponGroups WeaponGroup { get; set; }
        public WeaponQualityTypes WeaponQualityType { get; set; }
        public float AttackSpeed { get; set; }
        public float ChanceToHit { get; set; }
        public float DamageOnHit { get; set; }
        public float DamagePerSecond { get; set; }
        public void CalcAttackSpeed()
        {
            throw new System.NotImplementedException();
        }

        public void CalcChanceToHit()
        {
            throw new System.NotImplementedException();
        }

        public void CalcDamageOnHit()
        {
            throw new System.NotImplementedException();
        }

        public void CalcDmagePerSecond()
        {
            throw new System.NotImplementedException();
        }

        public string ItemName { get; set; }
        public string BaseName { get; set; }
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }
        public int Level { get; set; }
        public StatsModifierTypes StatsModType { get; set; }
        public int StatsModAmount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }
        public void CalcItemQuality()
        {
            throw new System.NotImplementedException();
        }

        public void CalcLevel()
        {
            throw new System.NotImplementedException();
        }

        public void CalcItemName()
        {
            throw new System.NotImplementedException();
        }

        public void CalcStatModifications()
        {
            throw new System.NotImplementedException();
        }

        public void CalcPrices()
        {
            throw new System.NotImplementedException();
        }
    }
}