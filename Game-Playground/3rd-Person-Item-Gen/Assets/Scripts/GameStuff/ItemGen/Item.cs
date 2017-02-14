using System;
using GameStuff.ItemGen;
namespace GameStuff.ItemGen
{
    public class Item
    {
        public string Name;
        private string BaseName;
        private string Prefix;
        private string Suffix;

        public int QualityType;
        public int ItemType;
        public int Level;

        //Debug.Log("_lib length=" + Lib.nameDictionary.Count);
        //public Random r = new Random();

        
        /*
        public Item(string prefix, string baseName, string suffix, QualityType qualityType, ItemType itemType, int level)
        {
            this._prefix = prefix;
            this._baseName = baseName;
            this._suffix = suffix;
            this._qualityType = qualityType;
            this._itemType = itemType;

            this.level = level;

            init();
        }

        public Item(string prefix, string baseName, string suffix, QualityType qualityType, ItemType itemType)
        {
            this.prefix = prefix;
            this.baseName = baseName;
            this.suffix = suffix;
            this.qualityType = qualityType;
            this.itemType = itemType;

            this.level = r.Next(10) + 1;

            init();
        }
        */
        public Item()
        {
            
        }

    }
}