using System;
using System.Collections;
using System.Collections.Generic;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen.ArmorItems
{
    public class Armor : GameItem, IArmor
    {
        

        private static ArmorGroups _armorGroup = GetArmorType();
        private static ArmorQualityTypes _armorQualityType = GetArmorQuality();
        private static string _statsModType = getStatsModifierTypes();

        public int DamageReductionAmount { get; set; }
        private static string _ItemName;

        private static int Level;
        public int StatsModAmount { get; set; }
        

        protected static Random random = new Random();

        public Armor()
        {

            ItemGroup = _armorGroup.ToString();
            Level = ItemLevel;
            ItemQuality = _armorQualityType.ToString();
            ItemName = GetItemName(ItemName, ItemQuality, HasMods, _statsModType);
            PriceBuy = 1;
            PriceSell = 1;
        }

        private static string GetItemName(string name, string quality, bool stats, string statType)
        {
            name = "";
           
            var addend = "";
            if (!stats)
            {
                statType = "";
            }
            else
            {
                addend = " of " + statType;
            }
            switch (_armorGroup)
            {
                case ArmorGroups.Head:
                    name = quality + " " + armorPrefixes[random.Next(0, armorPrefixes.Count)] + " " + headList[random.Next(0, (headList.Count))] + addend;
                    break;

                case ArmorGroups.Chest:
                    name = quality + " " + armorPrefixes[random.Next(0, armorPrefixes.Count)] + " " + chestList[random.Next(0, (chestList.Count))] + addend;
                    break;

                case ArmorGroups.Feet:
                    name = quality + " " + armorPrefixes[random.Next(0, armorPrefixes.Count)] + " " + feetList[random.Next(0, (feetList.Count))] + addend;
                    break;

                default:
                    name = "Shield";
                    break;

            }
            return name;
            
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

        private static ArmorQualityTypes GetArmorQuality()
        {
            _armorQualityType = (ArmorQualityTypes)Level;
            return _armorQualityType;
        }
        private static string getStatsModifierTypes()
        {
            _statsModType = StatsModType.ToString();
            return _statsModType;
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
    }
}