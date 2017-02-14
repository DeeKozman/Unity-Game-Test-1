using GameStuff.Utility.Enums;
using System;

namespace GameStuff.ItemGen
{
    public class GameItemFactory
    {
        
        private string[] _modAppendNames = new string[3] { "of Strength", "of Agility", "of Intellect" };

        public GameItemFactory()
        {
            
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