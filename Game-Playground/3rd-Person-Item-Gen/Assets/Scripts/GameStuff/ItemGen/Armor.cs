using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Enums;
using Random = System.Random;

namespace GameStuff.ItemGen
{
    public class Armor : GameItem
    {
        private ArmorGroups _armorGroup;
        private ArmorQualityTypes _armorQualityType;
        private string _statsModType;
        public int DamageReductionAmount;
        //protected Random random = new Random();

        public Armor()
        {
            _armorGroup = GetArmorType();
            
            _statsModType = getStatsModifierTypes();
            ItemGroup = _armorGroup.ToString();
         
        }

        protected override void GenerateQuality()
        {
            _armorQualityType = GetArmorQuality();
            ItemQuality = _armorQualityType.ToString();

            
        }

        protected override void GenerateItemName()
        {
            Name = GetItemName(Name, ItemQuality, HasMods, _statsModType);
        }

        protected override void GenerateTheDetails()
        {
            
            DamageReductionAmount = random.Next(1, 3) * ItemLevel;
            PriceBuy = ((ItemLevel * DamageReductionAmount) + (ItemLevel * StatsModAmount)) * 100;
            PriceSell = (PriceBuy * random.Next(2, 6)) / 10;
            Debug.Log("Armor! Name:"+Name+" / Level:"+ItemLevel+" / ItemGroup: "+ItemGroup+" / ItemQuality:"+ItemQuality+" / PriceBuy:"+PriceBuy+" / PriceSell:"+PriceSell+" / Damage Reduction: "+ DamageReductionAmount+" / StatsModAmount: "+ StatsModAmount);
        }

        private string GetItemName(string name, string quality, bool stats, string statType)
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

        private ArmorGroups GetArmorType()
        {
            return RandomEnumValue<ArmorGroups>();
        }

        private ArmorQualityTypes GetArmorQuality()
        {
           
            return (ArmorQualityTypes)ItemLevel;
        }

        private string getStatsModifierTypes()
        {
           
            return StatsModType.ToString();
        }


        private List<string> armorPrefixes = new List<string>
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

        private List<string> headList = new List<string>
            {
                "Cap",
                "Helm",
                "Helmet",
                "Mask",
                "Bucket"
            };

        private List<string> chestList = new List<string>
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

        private List<string> feetList = new List<string>
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