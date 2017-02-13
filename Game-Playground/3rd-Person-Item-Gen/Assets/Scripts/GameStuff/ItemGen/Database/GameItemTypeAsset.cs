using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Databases.BaseDatabase;

namespace GameStuff.ItemGen.Database
{
    [System.Serializable]
    public class GameItemTypeAsset : BaseDatabaseAsset
    {
        [SerializeField] private string _nameShort;

        [SerializeField] private string _description;

        [SerializeField] private Sprite _icon;

        public String NameShort
        {
            get { return _nameShort;} set { _nameShort = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public GameItemTypeAsset() : base()
        {
            this.NameShort = String.Empty;
            this.Description = String.Empty;
            this.Icon = null;
        }

        public GameItemTypeAsset(int id) : base(id)
        {
            this.NameShort = String.Empty;
            this.Description = String.Empty;
            this.Icon = null;
        }

        public GameItemTypeAsset(int id, string name) : base(id, name)
        {
            this.NameShort = String.Empty;
            this.Description = String.Empty;
            this.Icon = null;
        }

        public GameItemTypeAsset(int id, string name, string nameShort, string description, Sprite icon) : base(id, name)
        {
            this.NameShort = nameShort;
            this.Description = description;
            this.Icon = icon;
        }
    }
}
