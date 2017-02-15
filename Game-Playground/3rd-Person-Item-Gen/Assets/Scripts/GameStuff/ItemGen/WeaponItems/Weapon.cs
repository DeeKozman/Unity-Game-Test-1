using System;
using System.Collections;
using System.Collections.Generic;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen.WeaponItems
{
    public class Weapon : GameItem, IWeapon, IBaseItem
    {
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

        private string[] _modAppendNames = new string[3] { "of Strength", "of Agility", "of Intellect" };



        //private IEnumerable<int> _itemLevels = Enumerable.Range(1, 10);
        private int _itemLevel;
        private string _itemName;
        private string _baseName;
        private string _prefixName;
        private string _suffixName;
        private string _itemSlug;
        private string _weaponQuality;
        private int _weaponGroup;

        private float _attackSpeed;
        private float _chanceToHit;
        private float _damageOnHit;
        private float _damagePerSecond;

        private int _statsModAmount;
        private int _statsModType;
        private int _priceToBuy;
        private int _priceToSell;

        protected static Random random = new Random();

        public Weapon()
        {


        }
        public string getPrefix()
        {
            return weaponPrefixes[random.Next(weaponPrefixes.Count)];
        }

        public string getSuffix()
        {
            return " of "+magicSuffixes[random.Next(magicSuffixes.Count)];
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

        // Implementation of the IBaseItem Interface
        public string ItemName { get; set; }
        public string BaseName { get; set; }
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }
        public int Level { get; set; }
        public StatsModifierTypes StatsModType { get; set; }
        public int StatsModAmount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        // Implementation of the IWeapon Interface
        public WeaponGroups WeaponGroup { get; set; }
        public WeaponQualityTypes WeaponQualityType { get; set; }
        public float AttackSpeed { get; set; }
        public float ChanceToHit { get; set; }
        public float DamageOnHit { get; set; }
        public float DamagePerSecond { get; set; }

        public void CalcItemQuality()
        {
            
        }

        public void CalcLevel()
        {
            
        }

        public void CalcItemName()
        {
            
        }

        public void CalcStatModifications()
        {
           // var randomfactor = Random.Range(1, 5);
           // _modifierAmount = _itemLevel / 2 * randomfactor;
        }

        public void CalcPrices()
        {
            
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

       
    }
}