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
    [Serializable]
    public class Weapon : GameItem
    {
        
        private  WeaponGroups _weaponGroup;
        private  WeaponQualityTypes _weaponQualityType;
        private  string _statsModType = "";
        private string _baseName;

        //protected static Random random = new Random();
        public Weapon()
        {
            _weaponGroup = GetWeaponType();
            StatsModType = GetStatType();
            _statsModType = getStatsModifierTypes();
            Debug.Log("FromWeapon mod is:" + StatsModType.ToString());
            Debug.Log("FromWeapon _statsModType mod is:" + _statsModType.ToString());
            ItemGroup = _weaponGroup.ToString();
            ItemKind = "Weapon";
           
        }

        protected override void GenerateQuality()
        {
            _weaponQualityType = GetWeaponQuality();
            ItemQuality = _weaponQualityType.ToString();
            if (HasMods)
            {
                ItemClass = ItemGroup + " Weapon with " + _statsModType + " Modifier";
            }
            else
            {
                ItemClass = ItemGroup + " Weapon";
            }
        }

        protected override void GenerateItemName()
        {
            Name = GetItemName(Name, HasMods, _statsModType);
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
            DamageReductionAmount = 0;
            //Debug.Log("_baseName = " + _baseName);
            ItemSlug = "weapon-"+(ItemGroup.ToLower() )+ "-" + ItemLevel.ToString() + "-" + (_baseName.ToLower());
           // Debug.Log("Weapon! Name:" + Name +"/ Class:"+ItemClass+ "/ Level:" + ItemLevel + "/ ItemGroup: " + ItemGroup + "/ ItemQuality:" + ItemQuality + "/ PriceBuy:" + PriceBuy + "/ PriceSell:" + PriceSell+"/ DamageOnHit: " + DamageOnHit +"/ AttackSpeed: "+AttackSpeed+"/ ChanceToHit: "+ChanceToHit+"/ DPS: "+DamagePerSecond+"/ StatsModAmount: "+ StatsModAmount+"/ slug: "+ItemSlug +".png");
        }


        private  string GetItemName(string name, bool stats, string statType)
        {
            name = "";
            var addend = "";
            var prefix = weaponPrefixes[random.Next(0, weaponPrefixes.Count)];
            if (!stats)
            {
                statType = "";
            }
            else
            {
                if (_weaponGroup != WeaponGroups.Magic) {
                    addend = " of " + statType;
                    
                }
                else
                 {
                     addend = ", Enhancing " + statType;
                     
                 }
            }
           

            switch (_weaponGroup)
            {
                case WeaponGroups.Melee:
                    _baseName = meleeList[random.Next(0, meleeList.Count)];
                    name = prefix + " " +_baseName + addend;
                    break;

                case WeaponGroups.Ranged:
                    _baseName = rangedList[random.Next(0, rangedList.Count)];
                    name =  prefix + " " + _baseName + addend;
                    break;

                case WeaponGroups.Magic:
                    _baseName = magicList[random.Next(0, magicList.Count)];
                    name = _baseName + " of " + magicSuffixes[random.Next(0, magicSuffixes.Count)] + addend;
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
                "Corpse Excrement",
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
                "Throwing Turd",
                "Sling"
            };

        private List<string> magicList = new List<string>
            {
                "Ring",
                "Wand",
                "Spell Book",
                "Pouch",
                "Staff",
                "Stone",
                "Crystal",
                "Orb",
                "Talisman",
                "Amulet",
                "Scroll",
                "Bane"
            };

    }
}