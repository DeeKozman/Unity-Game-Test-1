using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Enums;
using Random = System.Random;

namespace GameStuff.ItemGen
{
    public class Armor : ScriptableObject
    {

        private static int Level;
        private static ArmorGroups _armorGroup = GetArmorType();
        private static ArmorQualityTypes _armorQualityType = GetArmorQuality();
        private static string _statsModType = getStatsModifierTypes();
        private static int _statsModAmount = GameItem.StatsModAmount;
        public static int DamageReductionAmount;
        protected static Random random = new Random();

        public Armor()
        {

            GameItem.ItemGroup = _armorGroup.ToString();
            Level = GameItem.ItemLevel;
            GameItem.ItemQuality = _armorQualityType.ToString();
            GameItem.Name = GetItemName(GameItem.Name, GameItem.ItemQuality, GameItem.HasMods, _statsModType);
            DamageReductionAmount = random.Next(1, 3) * Level;
            GameItem.PriceBuy = ((Level * DamageReductionAmount)+(Level * _statsModAmount))*100;
            GameItem.PriceSell = (GameItem.PriceBuy * random.Next(2, 6))/10;
            Debug.Log("Armor!" + " / PriceBuy: " + GameItem.PriceBuy + " / PriceSell: " + GameItem.PriceSell);


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

        private static ArmorGroups GetArmorType()
        {
            return GameItem.RandomEnumValue<ArmorGroups>();
        }

        private static ArmorQualityTypes GetArmorQuality()
        {
            _armorQualityType = (ArmorQualityTypes)Level;
            return _armorQualityType;
        }
        private static string getStatsModifierTypes()
        {
            _statsModType = GameItem.StatsModType.ToString();
            return _statsModType;
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