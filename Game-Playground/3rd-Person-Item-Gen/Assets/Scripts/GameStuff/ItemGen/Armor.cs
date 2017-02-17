using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Enums;
using Random = System.Random;

/// <summary>
/// Class that builds Armor Types and inherits from the GameItem.
/// </summary>

namespace GameStuff.ItemGen
{
    [Serializable]
    public class Armor : GameItem
    {
        private ArmorGroups _armorGroup;
        private ArmorQualityTypes _armorQualityType;
        private string _statsModType;
        private string _baseName;
        //protected Random random = new Random();

        public Armor()
        {
            _armorGroup = GetArmorType();
            
            _statsModType = getStatsModifierTypes();
            ItemGroup = _armorGroup.ToString();
            ItemKind = "Armor";
        }

        protected override void GenerateQuality()
        {
            _armorQualityType = GetArmorQuality();
            ItemQuality = _armorQualityType.ToString();
            if (HasMods)
            {
                ItemClass = ItemQuality + " " + ItemGroup + " Armor of " + _statsModType;
            }
            else
            {
                ItemClass = ItemQuality + " " + ItemGroup + " Armor";
            }
        }

        protected override void GenerateItemName()
        {
            Name = GetItemName(Name, HasMods, _statsModType);
        }

        protected override void GenerateTheDetails()
        {

        
            DamageReductionAmount = random.Next(1, 3) * ItemLevel;
            PriceBuy = ((ItemLevel * DamageReductionAmount) + (ItemLevel * StatsModAmount)) * 100;
            PriceSell = (PriceBuy * random.Next(2, 6)) / 10;
            AttackSpeed = 0;
            ChanceToHit = 0;
            DamageOnHit = 0;
            DamagePerSecond = 0;
            ItemSlug = "armor-" + (ItemGroup.ToLower()) + "-" + ItemLevel.ToString() + "-" + (_baseName.ToLower());
            Debug.Log("Armor! Name:"+Name+ "/ Class:" + ItemClass + "/ Level:" +ItemLevel+"/ ItemGroup: "+ItemGroup+"/ ItemQuality:"+ItemQuality+"/ PriceBuy:"+PriceBuy+"/ PriceSell:"+PriceSell+"/ Damage Reduction: "+ DamageReductionAmount+"/ StatsModAmount: "+ StatsModAmount + "/ slug: " + ItemSlug +
                       ".png");
        }

        private string GetItemName(string name, bool stats, string statType)
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
            var prefix = armorPrefixes[random.Next(0, armorPrefixes.Count)];
            switch (_armorGroup)
            {
                case ArmorGroups.Head:
                    _baseName = headList[random.Next(0, (headList.Count))];
                    name = prefix + " " + _baseName + addend;
                    break;

                case ArmorGroups.Chest:
                    _baseName = chestList[random.Next(0, (chestList.Count))];
                   name = prefix + " " + _baseName + addend;
                    break;

                case ArmorGroups.Feet:
                    _baseName = feetList[random.Next(0, (feetList.Count))];
                   name = prefix + " " + _baseName + addend;
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
                "Collar Armor",
                "Plate Armor",
                "Padded Armor",
                "Half Plate",
                "Ring Mail",
                "Scale Mail",
                "Breastplate",
                "Armor Skinsuit",
                "Dragon Mail Armor",
                "Chain Mail Armor",
                "Shell Armor",
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