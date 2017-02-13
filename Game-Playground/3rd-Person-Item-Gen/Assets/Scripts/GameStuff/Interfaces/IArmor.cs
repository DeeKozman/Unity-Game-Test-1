using GameStuff.Utility.Enums;

namespace GameStuff.Interfaces
{
    public interface IArmor : IGameItem
    {
        
        ArmorGroups ArmorGroup { get; }
        ArmorQualityTypes ArmorQualityType { get; }
        int DamageReductionAmount { get; } //This was not in the requirements, but I think Armor needs do something.
        
    }
}
