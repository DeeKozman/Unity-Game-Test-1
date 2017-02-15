
using GameStuff.Utility.Enums;
using JetBrains.Annotations;

// Common Interface used by all game items. (Weapons & Armor)

namespace GameStuff.Interfaces
{
    public interface IBaseItem
    {
        string Name { get; set; }
        
       
        int Level { get; set; }
        StatsModifierTypes StatsModType { get; set; }
        int StatsModAmount { get; set; }
        int PriceBuy { get; set; }
        int PriceSell { get; set; }
        
        
        void CalcItemQuality();

        void CalcLevel();

        void CalcItemName();

        void CalcStatModifications();

        void CalcPrices();
    }
}