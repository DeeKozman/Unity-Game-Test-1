using GameStuff.Utility.Enums;

namespace GameStuff.Interfaces
{
    public interface IWeapon : IGameItem
    {
        WeaponGroups WeaponGroup();
        WeaponQualityTypes WeaponQualityType();
        int AttackSpeed();
        int ChanceToHit();
        int DamageOnHit();
        int DamagePerSecond();
       
    }
}
