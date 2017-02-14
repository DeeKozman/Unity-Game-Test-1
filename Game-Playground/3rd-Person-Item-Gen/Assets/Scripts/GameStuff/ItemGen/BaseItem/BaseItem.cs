using System.Collections;
using System.Collections.Generic;
using GameStuff.Interfaces;
using GameStuff.Utility.Enums;
using UnityEngine;

namespace GameStuff.ItemGen.BaseItem
{

    public class BaseItem : IBaseItem
    {
        public string ItemName { get; set; }
        public string BaseName { get; set; }
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }
        public int Level { get; set; }
        public StatsModifierTypes StatsModType { get; set; }
        public int StatsModAmount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }
        public void GetLevel()
        {
            throw new System.NotImplementedException();
        }

        public void GetItemName()
        {
            throw new System.NotImplementedException();
        }

        public void GetStatModifications()
        {
            throw new System.NotImplementedException();
        }

        public void GetPrices()
        {
            throw new System.NotImplementedException();
        }
    }

}

