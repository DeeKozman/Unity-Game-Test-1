using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Enums;
using Random = System.Random;

/// <summary>
/// Class that builds Weapons and inherits from the GameItem.
/// </summary>

namespace GameStuff.ItemGen
{
    public class Weapon : GameItem
    {
        
        private  WeaponGroups _weaponGroup;
        private  WeaponQualityTypes _weaponQualityType;
        private  string _statsModType;
        
        // Specific weapon stats.
        public float AttackSpeed;
        public float ChanceToHit;
        public int DamageOnHit;
        public int DamagePerSecond { get; set; }
        //protected static Random random = new Random();
        public Weapon()
        {
            _weaponGroup = GetWeaponType();
            _statsModType = getStatsModifierTypes();
            ItemGroup = _weaponGroup.ToString();
           
        }

        protected override void GenerateQuality()
        {
            _weaponQualityType = GetWeaponQuality();
            ItemQuality = _weaponQualityType.ToString();
            
        }

        protected override void GenerateItemName()
        {
            Name = GetItemName(Name, ItemQuality, HasMods, _statsModType);
        }

        protected override void GenerateTheDetails()
        {
            
            AttackSpeed = (float)random.Next(5, 26) / 10;
            ChanceToHit = (0.9f + (float)ItemLevel) * .05f;
            DamageOnHit = random.Next(5, 11) * ItemLevel;
            /// <summary>
            /// DPS = Math.Ceiling((((minDamageOnHit+MaxDamageOnHit)/2)*(AttackSpeed + ChanceToHit)));
            /// </summary>
           
            DamagePerSecond = (int)Math.Ceiling((((1 + DamageOnHit) / 2) * (AttackSpeed + ChanceToHit)));
            PriceBuy = ((ItemLevel * DamagePerSecond) + (ItemLevel * StatsModAmount)) * 100;
            PriceSell = (PriceBuy * random.Next(2, 6)) / 10;
            Debug.Log("Weapon! Name:" + Name + " / Level:" + ItemLevel + " / ItemGroup: " + ItemGroup + " / ItemQuality:" + ItemQuality + " / PriceBuy:" + PriceBuy + " / PriceSell:" + PriceSell+" / DamageOnHit: " + DamageOnHit +" / AttackSpeed: "+AttackSpeed+" / ChanceToHit: "+ChanceToHit+" / DPS: "+DamagePerSecond+" / StatsModAmount: "+ StatsModAmount);
        }


        private  string GetItemName(string name, string quality, bool stats, string statType)
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

            switch (_weaponGroup)
            {
                case WeaponGroups.Melee:
                    name = quality+" "+weaponPrefixes[random.Next(0, weaponPrefixes.Count)] + " " +
                           meleeList[random.Next(0, meleeList.Count)] + addend;
                    break;

                case WeaponGroups.Ranged:
                    name = quality + " "+weaponPrefixes[random.Next(0, weaponPrefixes.Count)] + " " +
                           rangedList[random.Next(0, rangedList.Count)] + addend;
                    break;

                case WeaponGroups.Magic:
                    name = quality + " "+magicList[random.Next(0, magicList.Count)] + " of " +
                           magicSuffixes[random.Next(0, magicSuffixes.Count)] + addend;
                    break;

                default:
                    name = "God's Turd Hammer";
                    break;
            }

            return name;
        }


        private WeaponGroups GetWeaponType()
        {
            return RandomEnumValue<WeaponGroups>();
        }

        private  WeaponQualityTypes GetWeaponQuality()
        {
            return (WeaponQualityTypes) ItemLevel;
        }

        private string getStatsModifierTypes()
        {
            
            return StatsModType.ToString(); 
        } 

        public bool CalcChanceToHit()
        {
            var hit =(0.9f + (float)ItemLevel) * .05f;
            var noHit = (float)random.Next(9, 15) / 10;
            if (noHit < hit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<string> weaponPrefixes = new List<string>
            {
                "Savage",
                "Cold Iron",
                "Bloodthirsty",
                "Windborne",
                "Mocking",
                "Primeval",
                "Etched",
                "Master's",
                "Victorious",
                "Heroic",
                "Reliable",
                "Coroded",
                "Rusty",
                "Decrepid",
                "Shiny",
                "Metallic",
                "Chromium",
                "Mythical",
                "Draconic",
                "Glowing",
                "Furious",
                "Angry",
                "Destroyed",
                "Forged",
                "Unearthed",
                "Jagged",
                "Barbed",
                "Artist's",
                "Liar's",
                "Mauling",
                "Widow Making",
                "Woodsman's",
                "Swift",
                "Slayer's",
                "Mage Killer's",
                "Trusty",
                "Assassin's",
                "Quicksilver",
                "Drunkard's",
                "Earthen",
                "Crashing",
                "Cruel",
                ""
            };

        private List<string> magicSuffixes = new List<string>
            {

                "Unholiness",
                "Widows Tears",
                "Mocking",
                "the Forgotten Nightmares",
                "Vileness",
                "Unnatural Origin",
                "Mythical Realms",
                "Fiery Core",
                "the Damned",
                "Calamatious Intent",
                "Sacred Rituals",
                "Lupine Material",
                "Revenge",
                "Chaotic Tendencies",
                "Ghost Touch",
                "Quantum Misalignment",
                "Corrosive Morality",
                "Consecrated Flesh",
                "Enchanting Niceness",
                "Murderous Intrigue",
                "Nullifying Toxins",
                "The Southern Isles",
                "Maligning Debaucery",
                "Voltaic Curse",
                "Courser's Delight",
                "Darkness Stone",
                "Forbiden Intent",
                "Conjurer's Select Batch",
                "Dragon's Fire",
                "Hellfire",
                ""
            };

        private List<string> meleeList = new List<string>
            {
                "Dagger",
                "Knife",
                "Mace",
                "Scepter",
                "Rapier",
                "Sword",
                "Morningstar",
                "Hatchet",
                "Cleaver",
                "foil",
                "Saber",
                "Machete",
                "Quarterstaff",
                "Axe",
                "Lance",
                "Pike",
                "Club",
                "Staff",
                "Stick",
                "Claymore",
                "Bastard",
                "Hammer",
                "Longsword",
                "Greatsword",
                "Waraxe",
                "Harpoon",
                "Trident",
                "Sledgehammer",
                "Greataxe",
                "Greathammer"
            };

        private List<string> rangedList = new List<string>
            {
                "Blow Gun",
                "Throwing Knife",
                "Bowcaster",
                "Crossbow",
                "Bow",
                "Longbow",
                "Sling"
            };

        private List<string> magicList = new List<string>
            {
                "Ring",
                "Wand",
                "Orb",
                "Talisman",
                "Amulet",
                "Scroll",
                "Bane"
            };

    }
}