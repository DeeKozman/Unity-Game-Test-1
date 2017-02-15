using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GameStuff.Utility.Enums;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = System.Random;

namespace GameStuff.ItemGen
{
    public class NameLibrary
    {
        
        // Make the names;
        public Dictionary<ItemTypes, List<string>> nameDictionary = new Dictionary<ItemTypes, List<string>>();
       
       
        public List<string> WeaponPrefixList;
        public List<string> ArmorPrefixList;
        public List<string> MagicSuffixList;
        public List<string> ModSuffixList;

        public List<string> MeleeList;
        public List<string> RangedList;
        public List<string> MagicList;
        public List<string> HeadList;
        public List<string> ChestList;
        public List<string> FeetList;
        private int counter;

        public Random Rando; //Rhymes with "Lando"
        private int rando;

        public NameLibrary()
        {
            Rando = new Random();
            fillWeapons();
            fillArmor();
            fillWeaponPrefix();
            fillArmorPrefix();
            fillMagicSuffix();
            fillModSuffix();
           //Debug.Log("MeleeList: " + MeleeList.Count);
            //Debug.Log("WeaponPrefixList: " + WeaponPrefixList.Count);
            foreach (var _item in nameDictionary[ItemTypes.Melee])
            {
                var baseName = _item;
                var pre = WeaponPrefixList[rando];
                Debug.Log("Name="+ pre + _item);
            }
        }

        private void SeeLists()
        {
            
            for (int index = 0; index < nameDictionary.Count; index++)
            {
                var item = nameDictionary.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;
                var s = item.Value.Count;
                foreach (var d in itemValue)
                {
                    
                    counter++;
                }
               var itemValuex = Rando.Next(1,11);
                
                Debug.Log("Key:" + itemKey +"/ Count:"+s);
               
            }
            Debug.Log("Counter Says:" + counter);
            

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
                "of Agility",
                "of Intellect",
                "of Strength",
                ""
            };
        }

        private void fillWeapons()
        {
            MeleeList = new List<string>
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

            nameDictionary.Add(ItemTypes.Melee, MeleeList);
           Debug.Log("MeleeList:" + MeleeList.Count);
            //Debug.Log("namedic:" + nameDictionary.ElementAt(6).Value);
            RangedList = new List<string>
            {
                "Blow Gun",
                "Throwing Knife",
                "Bowcaster",
                "Crossbow",
                "Bow",
                "Longbow",
                "Sling"
            };

            nameDictionary.Add(ItemTypes.Ranged, RangedList);
            

            MagicList = new List<string>
            {
                "Ring",
                "Wand",
                "Orb",
                "Amulet",
                "Scroll",
                "Bane",
                "Dart"
            };

            nameDictionary.Add(ItemTypes.Magic, MagicList);
            Debug.Log("MagicList:"+MagicList.Count);
            
        }


        private void fillArmor()
        {
            HeadList = new List<string>
            {
                "Cap",
                "Helm",
                "Helmet",
                "Mask",
                "Bucket"
            };

            nameDictionary.Add(ItemTypes.Head, HeadList);
           
            ChestList = new List<string>
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
            nameDictionary.Add(ItemTypes.Chest, ChestList);

            FeetList = new List<string>
            {
                "Gaitors",
                "Greives",
                "Boots",
                "Shoes",
                "Sandals",
                "Stompers"
            };
            nameDictionary.Add(ItemTypes.Feet, FeetList);
            SeeLists();
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

        public WeaponQualityTypes GetWeaponQuality()
        {
            return RandomEnumValue<WeaponQualityTypes>();
        }

        public ArmorQualityTypes GetArmorQuality()
        {
            return RandomEnumValue<ArmorQualityTypes>();
        }

        public string GetBaseNameForItemTypes(ItemTypes kindOf)
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