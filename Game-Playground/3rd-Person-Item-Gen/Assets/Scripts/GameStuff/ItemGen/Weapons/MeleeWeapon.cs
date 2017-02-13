using GameStuff.Utility.Enums;

using GameStuff.Interfaces;

namespace ItemGen
{
    public class MeleeWeapon : IWeapon
    {
        // Implementation of the IWeapon Interface

       

        //Implementation of the IGameItem Interface.
        

        // Need the Level of the Item First because so much is generated based on the level.
        public void GetLevel()
        {
            throw new System.NotImplementedException();
        }

        public void GetItemName()
        {
            throw new System.NotImplementedException();
        }

        public void GetStatModifications()
        {
            throw new System.NotImplementedException();
        }

        public void GetPrices()
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

        public void CalcDamagePerSecond()
        {
            throw new System.NotImplementedException();
        }

        WeaponGroups IWeapon.WeaponGroup()
        {
            throw new System.NotImplementedException();
        }

        WeaponQualityTypes IWeapon.WeaponQualityType()
        {
            throw new System.NotImplementedException();
        }

        int IWeapon.AttackSpeed()
        {
            throw new System.NotImplementedException();
        }

        int IWeapon.ChanceToHit()
        {
            throw new System.NotImplementedException();
        }

        int IWeapon.DamageOnHit()
        {
            throw new System.NotImplementedException();
        }

        int IWeapon.DamagePerSecond()
        {
            throw new System.NotImplementedException();
        }

        public string ItemName { get; private set; }
        public string BaseName { get; private set; }
        public string PrefixName { get; private set; }
        public string SuffixName { get; private set; }
        public int Level { get; private set; }
        public StatsModifierTypes StatsModType { get; private set; }
        public int StatsModAmount { get; private set; }
        public int PriceBuy { get; private set; }
        public int PriceSell { get; private set; }
    }
}