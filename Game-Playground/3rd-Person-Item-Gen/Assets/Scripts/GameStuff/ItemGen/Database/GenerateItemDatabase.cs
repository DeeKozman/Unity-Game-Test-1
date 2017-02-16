using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace GameStuff.ItemGen.Database
{
    public class GenerateItemDatabase : MonoBehaviour
    {
        
        // Create Database
        public void OnAwake()
        {
            Console.WriteLine("OnEnable is happening.");
           
            for (int i = 0; i < GameItemDatabase.GetAssetCount(); i++)
            {
                var asset = GameItemDatabase.GetAt(i);
                if (asset != null)
                {
                    Debug.Log("Database is not empty!");
                }
                else
                {
                    Debug.Log("Database is empty!");
                    ConstructItemDatabase();
                    //var newAsset = new GameItemAsset(GameItemDatabase.Instance.GetNextId());
                    //GameItemDatabase.Instance.Add(newAsset);
                }
            }
        }

        private void ConstructItemDatabase()
        {
            Debug.Log("Database is being Made!");
        }
    }
}