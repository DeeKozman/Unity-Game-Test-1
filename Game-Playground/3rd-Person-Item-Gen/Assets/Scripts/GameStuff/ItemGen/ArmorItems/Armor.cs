using System;
using System.Collections;
using System.Collections.Generic;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen.ArmorItems
{
    public class Armor : GameItem, IArmor, IBaseItem
    {
        private static List<string> armorPrefixes = new List<string>
            {
                "Blessed",
                "Ephemeral",
                "Unholy",
                "Windborne",
                "Mocking",
                "Bonded",
                "Unnatural",
                "Arborean",
                "Vulpine",
                "Restrained",
                "Regal",
                "Druid's",
                "Burglar's",
                "Vital",
                "Protective",
                "Righteous",
                "Mortals'",
                "Coroded",
                "Rusty",
                "Ancient",
                "Decrepid",
                "Fairweather",
                "Shielding",
                "Favored",
                "Zircon",
                "Spiked",
                "Reflexive",
                "Artisan's",
                "Arcadian",
                "Acolyte's",
                "Elysian",
                "Concealing",
                "Guardian",
                "Destroyed",
                "Forged",
                "Pious",
                "Evasive",
                "Translucent",
                "Holy",
                "Etherbound",
                "Favored",
                "Dazzling",
                "Smith's",
                "Bonded",
                "Vigilant",
                "Southern",
                "Eastern",
                "Defensive",
                ""
            };

        private static List<string> headList = new List<string>
            {
                "Cap",
                "Helm",
                "Helmet",
                "Mask",
                "Bucket"
            };

        private static List<string> chestList = new List<string>
            {
                "Studded Leather Armor",
                "Leather Armor",
                "Cloak",
                "Collar",
                "Plate",
                "Padded Armor",
                "Half Plate",
                "Ring Mail",
                "Scale Mail",
                "Breastplate",
                "Skinsuit",
                "Dragon Mail",
                "Chain Mail",
                "Shell",
                "Chain Shirt"
            };

        private static List<string> feetList = new List<string>
            {
                "Gaitors",
                "Greives",
                "Boots",
                "Shoes",
                "Sandals",
                "Stompers"
            };

        public static ArmorGroups ArmorGroup;
        public ArmorQualityTypes ArmorQualityType { get; set; }
        public int DamageReductionAmount { get; set; }
        public string Name;
        
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }
        public int Level;
        public StatsModifierTypes StatsModType { get; set; }
        public int StatsModAmount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        protected static Random random = new Random();

        public Armor()
        {
            this.Name = ItemName;
            this.Level = ItemLevel;
            ArmorGroup = GetArmorType();
        }

        public string getPrefix()
        {
            return armorPrefixes[random.Next(armorPrefixes.Count)];
        }
        

        private static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }

        private static ArmorGroups GetArmorType()
        {
            return RandomEnumValue<ArmorGroups>();
        }

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