﻿
using System.Collections.Generic;
using System;
using GameStuff.Utility.Enums;
using UnityEngine;
using Random = System.Random;

namespace GameStuff.ItemGen
{
    public class GameItem : ScriptableObject
    {

        public string ItemName;
        public int ItemLevel;
        public string ItemGroup;
        public string ItemQuality;
        public static StatsModifierTypes StatsModType;
        public static bool HasMods;
        public static int StatsModAmount;
        public static int PriceBuy;
        public static int PriceSell;

        protected static Random random = new Random();

        ///TODO: Would Love to use my Enums for Items to populate this list, but need figure out a simple way to do it.
        private static List<Type> itemType = new List<Type> {
            typeof(Weapon),
            typeof(Armor)
        };

        public static GameItem Generate()
        {
            GameItem newItem = CreateInstance(itemType[random.Next(0, itemType.Count)]) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = random.Next(1, 11);
            CalcStatModifications(newItem.ItemLevel);
            Debug.Log("Name: " + newItem.ItemName+" / Level: " + newItem.ItemLevel + " / StatsModType: " + StatsModType+ " / StatsModAmount: "+StatsModAmount);
            return newItem;
        }

        public static GameItem Generate(Type itemType)
        {
            GameItem newItem = Activator.CreateInstance(itemType) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = random.Next(1, 11);
            CalcStatModifications(newItem.ItemLevel);
            Debug.Log("Level: " + newItem.ItemLevel + "/ Name: " + newItem.ItemName);
            return newItem;
        }

        public static GameItem Generate(int itemLevel)
        {
            GameItem newItem = Activator.CreateInstance(itemType[random.Next(0, itemType.Count)]) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = itemLevel;
            CalcStatModifications(newItem.ItemLevel);
            Debug.Log("Level: " + newItem.ItemLevel + "/ Name: " + newItem.ItemName);
            return newItem;
        }

        private static void GenerateName(GameItem item)
        {
            if (item is Weapon)
                item.ItemName = "weapon";

            if (item is Armor)
                item.ItemName = "armor";

        }

        private static void CalcStatModifications(int level)
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

        private static StatsModifierTypes GetStatType()
        {
            return RandomEnumValue<StatsModifierTypes>();
        }

    }
}
