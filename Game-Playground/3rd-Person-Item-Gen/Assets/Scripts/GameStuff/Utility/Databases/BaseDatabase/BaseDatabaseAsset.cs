using GameStuff.Interfaces;
using System.Collections;
using System;
using UnityEngine;

namespace GameStuff.Utility.Databases.BaseDatabase
{
    [System.Serializable]
    public class BaseDatabaseAsset : IDatabaseAsset
    {
        [SerializeField]
        private int _id;

        [SerializeField]
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BaseDatabaseAsset()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public BaseDatabaseAsset(int id)
        {
            this.Id = id;
            this.Name = string.Empty;
        }

        public BaseDatabaseAsset(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

}

