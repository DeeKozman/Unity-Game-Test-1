using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.Utility.Databases.BaseDatabase;

namespace GameStuff.ItemGen.Database
{
    public class GameItemTypeDatabase : BaseDatabase<GameItemTypeAsset>
    {
        private const string DatabasePath = @"Resources/GameItemGen/Databases/";
        private const string DatabaseName = @"GameItemDatabase.asset";

        static private GameItemTypeDatabase _instance = null;

        static public GameItemTypeDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GetDatabase<GameItemTypeDatabase>(DatabasePath, DatabaseName);
                }
                return _instance;
            }
        }

        static public GameItemTypeAsset GetAt(int index)
        {
            return Instance.GetAtIndex(index);
        }

        static public GameItemTypeAsset GeAsset(int id)
        {
            return Instance.GetById(id);
        }

        static public int GetAssetCount()
        {
            return Instance.Count;
        }

    }
}