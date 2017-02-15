using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.ItemGen.Database;
using GameStuff.Utility.Enums;

namespace GameStuff.ItemGen
{
    public class ItemInit : MonoBehaviour
    {

        private void Start()
        {
            Main();
        }

        private static void Main()
        {
            NameLibrary Lib = new NameLibrary();
            Debug.Log("NameDictKeys: " + Lib.nameDictionary.Keys);
            //Debug.Log("COUNT: " + Lib.nameDictionary.Count);
            Debug.Log("Count" + Lib.nameDictionary.Keys.ToString());
        }
    }
}

