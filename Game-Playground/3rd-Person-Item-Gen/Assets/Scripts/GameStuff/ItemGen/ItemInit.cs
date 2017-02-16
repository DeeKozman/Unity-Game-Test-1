using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameStuff.ItemGen.Database;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen
{
    public class ItemInit : ScriptableObject
    {
        private void OnEnable()
        {
            Main();
           
        }

        private void Main()
        {
            List<GameItem> items = new List<GameItem>();

            for (var i = 0; i < 10; i++)
            {
                items.Add(GameItem.Generate());
            }
            Debug.Log("There Are "+items.Count+" Items.");
            foreach (var item in items)
            {
                //Debug.Log("name: "+GameItem.Name+" / Group: "+ GameItem.ItemGroup + " /  Quality:"+ GameItem.ItemQuality+" / price:"+ GameItem.PriceBuy + " / sell:" +GameItem.PriceSell);
            }
        }
    }
}

