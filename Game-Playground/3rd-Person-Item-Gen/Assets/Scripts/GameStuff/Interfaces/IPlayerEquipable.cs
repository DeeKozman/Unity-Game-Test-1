namespace GameStuff.Interfaces
{
    //Tracking what Items the Player is using

    public interface IPlayerEquipable
    {
        bool ActHeadArmor { get; set; }
        bool ActChestArmor { get; set; }
        bool ActFeetArmor { get; set; }
        bool ActMeleeWeapon { get; set; }
        bool ActRangedWeapon { get; set; }
        bool ActMagicWeapon { get; set; }
    }
}