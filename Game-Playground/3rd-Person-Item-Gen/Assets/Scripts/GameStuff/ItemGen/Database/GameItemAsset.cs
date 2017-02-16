using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameStuff.Utility.Databases.BaseDatabase;

namespace GameStuff.ItemGen.Database
{
    [System.Serializable]
    public class GameItemAsset : BaseDatabaseAsset
    {
        [SerializeField] private string _itemName;

        [SerializeField] private string _itemGroup;

        [SerializeField] private string _itemQuality;

        [SerializeField] private Sprite _icon;

        public String ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public String ItemGroup
        {
            get { return _itemGroup; }
            set { _itemGroup = value; }
        }
        public String ItemQuality
        {
            get { return _itemQuality; }
            set { _itemQuality = value; }
        }

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public GameItemAsset() : base()
        {
            this.ItemName = String.Empty;
            this.ItemGroup = String.Empty;
            this.ItemQuality = String.Empty;
            this.Icon = null;
        }

        public GameItemAsset(int id) : base(id)
        {
            this.ItemName = String.Empty;
            this.ItemGroup = String.Empty;
            this.ItemQuality = String.Empty;
            this.Icon = null;
        }

        public GameItemAsset(int id, string name) : base(id, name)
        {
            this.ItemName = String.Empty;
            this.ItemGroup = String.Empty;
            this.ItemQuality = String.Empty;
            this.Icon = null;
        }

        public GameItemAsset(int id, string name, string itemName, string itemGroup, string itemQuality, Sprite icon) : base(id, name)
        {
            this.ItemName = itemName;
            this.ItemGroup = itemGroup;
            this.ItemQuality = itemQuality;
            this.Icon = icon;
        }
    }
}




