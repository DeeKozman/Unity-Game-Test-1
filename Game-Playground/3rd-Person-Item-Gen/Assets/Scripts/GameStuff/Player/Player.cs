using System;
using GameStuff.Interfaces;

/// <summary>
/// TODO: Get all character controllers and movement classes refined.
/// </summary>

namespace GameStuff.Player

{
    public class Player : IPlayer, IPlayerStats, IPlayerEquipable
    {
        private bool _actChestArmor;
        private bool _actFeetArmor;
        private bool _actHeadArmor;
        private bool _actMagicWeapon;
        private bool _actMeleeWeapon;
        private bool _actRangedWeapon;

        //Implementation of the IPlayer interface
        public int Experience { get; set; }
        public int Level { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public void GenerateStats()
        {
            throw new NotImplementedException();
        }

        public bool ActHeadArmor { get; set; }
        public bool ActChestArmor { get; set; }
        public bool ActFeetArmor { get; set; }
        public bool ActMeleeWeapon { get; set; }
        public bool ActRangedWeapon { get; set; }
        public bool ActMagicWeapon { get; set; }

        public int IntellectBase { get; set; }
        public int StrengthBase { get; set; }
        public int AgilityBase { get; set; }
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int IntellectModAmount { get; set; }
        public int StrengthModAmount { get; set; }
        public int AgilityModAmount { get; set; }

        public void AddMods()
        {
            throw new NotImplementedException();
        }

        public void RemoveMods()
        {
            throw new NotImplementedException();
        }


        //Implementation of the IBaseStats interface
    }
}