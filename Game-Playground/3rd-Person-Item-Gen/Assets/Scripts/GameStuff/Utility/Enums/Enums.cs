//--------------------------------------------------------------------------------------------------
//  All Enums in one place. Hate it when I have to go looking for an Enum and it is buried under a class.
//  I actually did this first because it gave me clues to the polymorphic Interfaces I could use.
//  I like to look at every property and play the "____ is a ____." and "_____ has a _____." 
//  Eventhough I want to not use a lot of inheritance, this feels like a good way to start to try and 
//  determine what design pattern I will try to follow. */
//---------------------------------------------------------------------------------------------------

namespace GameStuff.Utility.Enums
{
    public enum ItemTypes
    {
        Weapon = 1,
        Armor
    }

    public enum WeaponGroups
    {
        Melee = 1,
        Ranged,
        Magic
    }

    public enum ArmorGroups
    {
        Head = 1,
        Chest,
        Feet
    }

    public enum WeaponQualityTypes
    {
        Poor = 1,
        Basic,
        Mighty,
        Hefty,
        Crafted,
        Rigid,
        Epic,
        Exalted,
        Colossal,
        Mythological,
        Legendary
    }

    public enum ArmorQualityTypes
    {
        Poor = 1,
        Common,
        Reinforced,
        Roughhewn,
        Worn,
        Durable,
        Sturdy,
        Rugged,
        Robust,
        Über,
        Legendary
    }

    public enum StatsModifierTypes
    {
        None,
        Strength,
        Agility,
        Intellect
    }
}