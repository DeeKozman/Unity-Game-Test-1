
using System.Collections.Generic;
using System;
using GameStuff.Utility.Enums;
using UnityEngine;
using Random = System.Random;

namespace GameStuff.ItemGen
{
    public class GameItem : ScriptableObject
    {

        public string Name;
        public int ItemLevel;
        public string ItemGroup;
        public string ItemQuality;
        public StatsModifierTypes StatsModType;
        public bool HasMods;
        public int StatsModAmount;
        public int PriceBuy;
        public int PriceSell;

        protected static Random random = new Random();

        ///TODO: Would Love to use my Enums for Items to populate this list, but need figure out a simple way to do it.
        private static List<Type> itemType = new List<Type> {
            typeof(Weapon),
            typeof(Armor)
        };

        public static GameItem Generate()
        {
            GameItem newItem = (GameItem)CreateInstance(itemType[random.Next(0, itemType.Count)]);
            return newItem;
        }

        public static GameItem Generate(Type itemType)
        {
            GameItem newItem = (GameItem)CreateInstance(itemType);
            return newItem;
        }

        public static GameItem Generate(int itemLevel)
        {
            GameItem newItem = (GameItem)CreateInstance(itemType[random.Next(0, itemType.Count)]);
            return newItem;
        }

        private void GenerateName(GameItem item)
        {
            /*if (item is Weapon)
                item.Name = "weapon";

            if (item is Armor)
                item.Name = "armor";
                */
        }

        public void CalcStatModifications(int level)
        {
            StatsModType = GetStatType();
            level = random.Next(1, 11);
            
            if (random.Next(0, 100) < level * 8)
            {
                StatsModAmount = level / 2 * random.Next(1, 5);
                HasMods = true;
            }
            else
            {
                StatsModAmount = 0;
                HasMods = false;
            }  
        }

        public static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }

        private StatsModifierTypes GetStatType()
        {
            return RandomEnumValue<StatsModifierTypes>();
        }

    }
}
