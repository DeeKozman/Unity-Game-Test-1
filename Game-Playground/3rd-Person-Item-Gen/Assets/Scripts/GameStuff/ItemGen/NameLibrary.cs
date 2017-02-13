using System;
using System.Collections.Generic;

namespace ItemGen
{
    public class NameLibrary
    {
        public List<string> ArmorPrefixList;
        public List<string> MagicSuffixList;
        public List<string> ModSuffixList;
        // public Dictionary<ItemTypes, List<string>> itemTypeDictionary = new Dictionary<ItemTypes, List<string>>();
        public Dictionary<ItemKind, List<string>> nameDictionary = new Dictionary<ItemKind, List<string>>();
        public Random Rando; //Rhymes with "Lando"

        public List<string> WeaponPrefixList;

        public NameLibrary()
        {
            Rando = new Random();
            fillWeapons();
            fillArmor();
            fillWeaponPrefix();
            fillArmorPrefix();
            fillMagicSuffix();
            fillModSuffix();
            Console.Write("NameDictKeys: " + nameDictionary.Keys);
            Console.Write("COUNT: " + nameDictionary.Count);
        }

        private void fillWeaponPrefix()
        {
            WeaponPrefixList = new List<string>
            {
                "Savage",
                "Cold Iron",
                "Bloodthirsty",
                "Windborne",
                "Mocking",
                "Primeval",
                "Etched",
                "Master's",
                "Victorious",
                "Heroic",
                "Reliable",
                "Coroded",
                "Rusty",
                "Decrepid",
                "Shiny",
                "Metallic",
                "Chromium",
                "Mythical",
                "Draconic",
                "Glowing",
                "Furious",
                "Angry",
                "Destroyed",
                "Forged",
                "Unearthed",
                "Jagged",
                "Barbed",
                "Artist's",
                "Liar's",
                "Mauling",
                "Widow Making",
                "Woodsman's",
                "Swift",
                "Slayer's",
                "Mage Killer's",
                "Trusty",
                "Assassin's",
                "Quicksilver",
                "Drunkard's",
                "Earthen",
                "Crashing",
                "Cruel",
                ""
            };
        }

        private void fillArmorPrefix()
        {
            ArmorPrefixList = new List<string>
            {
                "Blessed",
                "Ephemeral",
                "Unholy",
                "Windborne",
                "Mocking",
                "Bonded",
                "Unnatural",
                "Arborean",
                "Vulpine",
                "Restrained",
                "Regal",
                "Druid's",
                "Burglar's",
                "Vital",
                "Protective",
                "Righteous",
                "Mortals'",
                "Coroded",
                "Rusty",
                "Ancient",
                "Decrepid",
                "Fairweather",
                "Shielding",
                "Favored",
                "Zircon",
                "Spiked",
                "Reflexive",
                "Artisan's",
                "Arcadian",
                "Acolyte's",
                "Elysian",
                "Concealing",
                "Guardian",
                "Destroyed",
                "Forged",
                "Pious",
                "Evasive",
                "Translucent",
                "Holy",
                "Etherbound",
                "Favored",
                "Dazzling",
                "Smith's",
                "Bonded",
                "Vigilant",
                "Southern",
                "Eastern",
                "Defensive",
                ""
            };
        }

        private void fillMagicSuffix()
        {
            MagicSuffixList = new List<string>
            {
                "Ephemeral",
                "Unholy",
                "Windborne",
                "Mocking",
                "Forgotten",
                "Vile",
                "Unnatural",
                "Mythical",
                "Fiery",
                "Glowing",
                "Electric",
                "Hellish",
                "Sacred",
                "Lupine",
                "Spider's",
                "Chaotic",
                "Ghost Touch",
                "Heliacal",
                "Unearthed",
                "Lunar",
                "Quantum",
                "Corrosive",
                "Consecrated",
                "Malediction",
                "Enchanting",
                "Murderous",
                "Nullifying",
                "Southern",
                "Maligning",
                "Voltaic",
                "Courser's",
                "Dark",
                "Forbiden",
                "Conjurer's",
                "Grim",
                "Hellfire",
                ""
            };
        }

        private void fillModSuffix()
        {
            ModSuffixList = new List<string>
            {
                "Agility",
                "Intellect",
                "Strength",
                ""
            };
        }

        private void fillWeapons()
        {
            var wepList = new List<string>
            {
                "Dagger",
                "Knife",
                "Mace",
                "Scepter",
                "Rapier",
                "Sword",
                "Morningstar",
                "Hatchet",
                "Cleaver",
                "foil",
                "Saber",
                "Machete",
                "Quarterstaff",
                "Baton",
                "Axe",
                "Lance",
                "Pike",
                "Club",
                "Staff",
                "Stick",
                "Flail",
                "Claymore",
                "Bastard",
                "Hammer",
                "Longsword",
                "Greatsword",
                "Waraxe",
                "Harpoon",
                "Trident",
                "Sledgehammer",
                "Greataxe",
                "Greathammer"
            };

            nameDictionary.Add(ItemKind.Melee, wepList);
            //itemTypeDictionary.Add(ItemTypes.Weapon, wepList);

            var rangedList = new List<string>
            {
                "Blow Gun",
                "Throwing Knife",
                "Bowcaster",
                "Crossbow",
                "Bow",
                "Longbow",
                "Sling"
            };

            nameDictionary.Add(ItemKind.Ranged, rangedList);
            // itemTypeDictionary.Add(ItemTypes.Weapon, rangedList);

            var magicList = new List<string>
            {
                "Ring",
                "Wand",
                "Orb",
                "Amulet",
                "Scroll",
                "Bane",
                "Dart"
            };

            nameDictionary.Add(ItemKind.Magic, magicList);
            //itemTypeDictionary.Add(ItemTypes.Weapon, magicList);
        }


        private void fillArmor()
        {
            var itemList = new List<string>
            {
                "Cap",
                "Helm",
                "Helmet",
                "Mask",
                "Bucket"
            };

            nameDictionary.Add(ItemKind.Head, itemList);
            // itemTypeDictionary.Add(ItemTypes.Armor, magicList);
            itemList = new List<string>
            {
                "Studded Leather Armor",
                "Leather Armor",
                "Cloak",
                "Collar",
                "Plate",
                "Padded Armor",
                "Half Plate",
                "Ring Mail",
                "Scale Mail",
                "Breastplate",
                "Skinsuit",
                "Dragon Mail",
                "Chain Mail",
                "Shell",
                "Chain Shirt"
            };
            nameDictionary.Add(ItemKind.Chest, itemList);

            itemList = new List<string>
            {
                "Gaitors",
                "Greives",
                "Boots",
                "Shoes",
                "Sandals",
                "Stompers"
            };
            nameDictionary.Add(ItemKind.Feet, itemList);
        }


        public T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T) v.GetValue(Rando.Next(v.Length));
        }


        public ItemTypes GetItemType()
        {
            return RandomEnumValue<ItemTypes>();
        }

        public ItemKind GetItemKind()
        {
            return RandomEnumValue<ItemKind>();
        }

        public QualityType GetQuality()
        {
            return RandomEnumValue<QualityType>();
        }

        public string GetBaseNameForItemKind(ItemKind kindOf)
        {
            var itemList = nameDictionary[kindOf];
            return itemList[Rando.Next(itemList.Count)];
        }

        public string GetWeaponPrefix()
        {
            return WeaponPrefixList[Rando.Next(WeaponPrefixList.Count)];
        }

        public string GetArmorPrefix()
        {
            return ArmorPrefixList[Rando.Next(ArmorPrefixList.Count)];
        }

        public string GetMagicSuffix()
        {
            return "of " + MagicSuffixList[Rando.Next(MagicSuffixList.Count)];
        }
    }
}