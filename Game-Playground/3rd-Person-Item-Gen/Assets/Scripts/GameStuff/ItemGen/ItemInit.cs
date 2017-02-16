using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameStuff.ItemGen.Database;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen
{
    public class ItemInit : MonoBehaviour
    {
        private void OnEnable()
        {
            Main();
            print("script was enabled");
        }

        private void Start()
        {
           
        }

        private static void Main()
        {
            List<GameItem> items = new List<GameItem>();

            for (var i = 0; i < 10; i++)
            {
                items.Add(GameItem.Generate());
            }
            Debug.Log("There Are "+items.Count+" Items.");
            foreach (var item in items)
            {
                //Debug.Log(ItemName);
            }
        }
    }
}

