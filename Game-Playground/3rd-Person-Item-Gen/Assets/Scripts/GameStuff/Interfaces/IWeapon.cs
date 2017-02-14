using GameStuff.Utility.Enums;

namespace GameStuff.Interfaces
{
    public interface IWeapon
    {
        WeaponGroups WeaponGroup { get; set; }
        WeaponQualityTypes WeaponQualityType { get; set; }
        float AttackSpeed { get; set; }
        float ChanceToHit { get; set; }
        float DamageOnHit { get; set; }
        float DamagePerSecond { get; set; }
        
        void CalcAttackSpeed();

        void CalcChanceToHit();

        void CalcDamageOnHit();

        void CalcDmagePerSecond();
    }
}
