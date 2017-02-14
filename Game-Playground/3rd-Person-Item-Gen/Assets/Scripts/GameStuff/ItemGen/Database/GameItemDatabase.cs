using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Databases.BaseDatabase;

namespace GameStuff.ItemGen.Database
{
    public class GameItemDatabase : BaseDatabase<GameItemAsset>
    {
        private const string DatabasePath = @"Resources/GameItemGen/Databases/";
        private const string DatabaseName = @"GameItemsDatabase.asset";

        static private GameItemDatabase _instance = null;

        static public GameItemDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GetDatabase<GameItemDatabase>(DatabasePath, DatabaseName);
                }
                return _instance;
            }
        }

        static public GameItemAsset GetAt(int index)
        {
            return Instance.GetAtIndex(index);
        }

        static public GameItemAsset GetAsset(int id)
        {
            return Instance.GetById(id);
        }

        static public int GetAssetCount()
        {
            return Instance.Count;
        }

    }
}