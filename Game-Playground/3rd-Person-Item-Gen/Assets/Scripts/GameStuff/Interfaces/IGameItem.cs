using GameStuff.Utility.Enums;

// Common Interface used by all game items. (Weapons & Armor)

namespace GameStuff.Interfaces
{
    public interface IGameItem  
    {
        string ItemName { get; }
        string BaseName { get; }
        string PrefixName { get; }
        string SuffixName { get; }
        int Level { get; }
        StatsModifierTypes StatsModType { get; }
        int StatsModAmount { get; }
        int PriceBuy { get; }
        int PriceSell { get; }

        void GetLevel();

        void GetItemName();

        void GetStatModifications();

        void GetPrices();
    }
}