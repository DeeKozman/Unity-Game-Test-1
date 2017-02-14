using GameStuff.Utility.Enums;

using GameStuff.Interfaces;
using System;

namespace ItemGen
{
    public class MeleeWeapon : IWeapon, IBaseItem// Implementation of the IWeapon & IBaseItem Interfaces
    {

        public Random Rando; //Rhymes with "Lando"
        private int _itemLevel;



        /*
        public string ItemName { get; private set; }
        public string BaseName { get; private set; }
        public string PrefixName { get; private set; }
        public string SuffixName { get; private set; }
        public int Level { get; private set; }
        public StatsModifierTypes StatsModType { get; private set; }
        public int StatsModAmount { get; private set; }
        public int PriceBuy { get; private set; }
        public int PriceSell { get; private set; }*/
        public WeaponGroups WeaponGroup { get; set; }
        public WeaponQualityTypes WeaponQualityType { get; set; }
        public int Level {
            get
            {
                
                return _itemLevel;
            }
            set
            {
                _itemLevel = value;
            }
        }
        public string ItemName { get; set; }
        public string BaseName { get; set; }
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }

        public int AttackSpeed { get; set; }
        public int ChanceToHit { get; set; }
        public int DamageOnHit { get; set; }
        public int DamagePerSecond { get; set; }

        public StatsModifierTypes StatsModType { get; set; }
        public int StatsModAmount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        

        public void GetItemQuality()
        {

        }

        public void GetLevel()
        {
           _level = Rando.Next(1, 11);
        }

        public void GetItemName()
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