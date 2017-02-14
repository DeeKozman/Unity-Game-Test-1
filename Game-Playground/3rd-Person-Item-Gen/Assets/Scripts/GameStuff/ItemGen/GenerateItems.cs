using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.ItemGen.Database;

namespace GameStuff.ItemGen
{
    public class GenerateItems
    {

        // Create Database
        public void OnEnable()
        {
            Console.WriteLine("OnEnable is happening.");
            NameLibrary lib = new NameLibrary();
            Console.Write("lib length=" + lib.nameDictionary.Count);
            for (int i = 0; i < GameItemDatabase.GetAssetCount(); i++)
            {
                var asset = GameItemDatabase.GetAt(i);
                if (asset != null)
                {
                    Console.Write("Database is not empty!");
                }
                else
                {

                }
            }
        }
    }
}