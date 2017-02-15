using GameStuff.Utility.Enums;

namespace GameStuff.Interfaces
{
    public interface IArmor
    {

        
        ArmorQualityTypes ArmorQualityType { get; set; }
        int DamageReductionAmount { get; set; } //This was not in the requirements, but I think Armor needs do something.
        
    }
}
