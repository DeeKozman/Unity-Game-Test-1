using System;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen.Weapons
{
    public class Weapon : IWeapon, IBaseItem
    {





        private IEnumerable<int> _itemLevels = Enumerable.Range(1, 10);
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

        public Random Rando;

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