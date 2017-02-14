
using System;
using GameStuff.Interfaces;

namespace GameStuff.Player

{
    public class Player : IPlayer, IBaseStats, IEquipable
    {
        private bool _actHeadArmor;
        private bool _actChestArmor;
        private bool _actFeetArmor;
        private bool _actMeleeWeapon;
        private bool _actRangedWeapon;
        private bool _actMagicWeapon;

        //Implementation of the IPlayer interface
        public int Experience { get; set; }
        public int Level { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }


        //Implementation of the IBaseStats interface
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int IntellectBase { get; set; }
        public int StrengthBase { get; set; }
        public int AgilityBase { get; set; }
        public int IntellectModAmount { get; set; }
        public int StrengthModAmount { get; set; }
        public int AgilityModAmount { get; set; }

        public void GenerateStats()
        {
            throw new System.NotImplementedException();
        }

        public bool ActHeadArmor { get; set; }
        public bool ActChestArmor { get; set; }
        public bool ActFeetArmor { get; set; }
        public bool ActMeleeWeapon { get; set; }
        public bool ActRangedWeapon { get; set; }
        public bool ActMagicWeapon { get; set; }

        
    }
}