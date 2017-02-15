using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Activation;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen.WeaponItems
{
    public class Weapon : GameItem, IWeapon
    {



        //private IEnumerable<int> _itemLevels = Enumerable.Range(1, 10);
        private int _itemLevel;
        private static string _itemName;
        private string _baseName;
        private string _prefixName;
        private string _suffixName;
        private string _itemSlug;
        private string _weaponQuality;


        private float _attackSpeed;
        private float _chanceToHit;
        private float _damageOnHit;
        private float _damagePerSecond;

        private int _statsModAmount;
        
        private int _priceToBuy;
        private int _priceToSell;
        // Implementation of the IBaseItem Interface
        public string Name;

        public static int Level;
        //public static StatsModifierTypes StatsModType;

        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        // Implementation of the IWeapon Interface
        private static WeaponGroups _weaponGroup = GetWeaponType();
        private static WeaponQualityTypes _weaponQualityType = GetWeaponQuality();
        private static string _statsModType = getStatsModifierTypes();
        public float AttackSpeed { get; set; }
        public float ChanceToHit { get; set; }
        public float DamageOnHit { get; set; }
        public float DamagePerSecond { get; set; }
        protected static Random random = new Random();

        public Weapon()
        {
            ItemGroup = _weaponGroup.ToString();
            Level = ItemLevel;
            ItemQuality = _weaponQualityType.ToString();
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


        private static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }

        private static WeaponGroups GetWeaponType()
        {
            return RandomEnumValue<WeaponGroups>();
        }

        private static WeaponQualityTypes GetWeaponQuality()
        {
            _weaponQualityType = (WeaponQualityTypes) Level;
            return _weaponQualityType;
        }

        private static string getStatsModifierTypes()
        {
            _statsModType = StatsModType.ToString();
            return _statsModType;
        } 

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

        private static List<string> weaponPrefixes = new List<string>
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

        private static List<string> magicSuffixes = new List<string>
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

        private static List<string> meleeList = new List<string>
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

        private static List<string> rangedList = new List<string>
            {
                "Blow Gun",
                "Throwing Knife",
                "Bowcaster",
                "Crossbow",
                "Bow",
                "Longbow",
                "Sling"
            };

        private static List<string> magicList = new List<string>
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