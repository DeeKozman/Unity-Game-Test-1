
using System.Collections.Generic;
using System;
using GameStuff.ItemGen.ArmorItems;
using GameStuff.ItemGen.WeaponItems;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen
{
    public class GameItem
    {
        
        public string ItemName;
        public int ItemLevel;
        protected static Random random = new Random();

        private static List<Type> itemType = new List<Type> {
            typeof(Weapon),
            typeof(Armor)
            
        };

        public static GameItem Generate()
        {
            GameItem newItem = Activator.CreateInstance(itemType[random.Next(0, itemType.Count)]) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = random.Next(1, 11);
            return newItem;
        }

        public static GameItem Generate(Type itemType)
        {
            GameItem newItem = Activator.CreateInstance(itemType) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = random.Next(1, 11);

            return newItem;
        }

        public static GameItem Generate(int itemLevel)
        {
            GameItem newItem = Activator.CreateInstance(itemType[random.Next(0, itemType.Count)]) as GameItem;
            GenerateName(newItem);
            newItem.ItemLevel = itemLevel;

            return newItem;
        }

        private static void GenerateName(GameItem item)
        {
            if (item is Weapon)
                item.ItemName = weaponPrefixes[random.Next(0, weaponPrefixes.Count - 1)] + " " + item.Name;

            if (item is Armor)
                item.ItemName = armorPrefixes[random.Next(0, weaponPrefixes.Count - 1)] + " " + item.Name;

            if (item is Magic)
                item.ItemName = item.ItemName + " of " + magicSuffixes[random.Next(0, magicSuffixes.Count)];
        }

        
    }
}

        private static int iClamp(int val, int min, int max)
        {
            if (val < min)
            {
                val = min;
            }

            if (val > max)
            {
                val = max;
            }
            return val;
        }
        /*
        public QualityType getQuality()
        {

            return RandomEnumValue<QualityType>();
        }

        public static int getRange(ItemTypes type, QualityType quality, Random r)
        {
            int range;
            switch (type)
            {*/
            }
}