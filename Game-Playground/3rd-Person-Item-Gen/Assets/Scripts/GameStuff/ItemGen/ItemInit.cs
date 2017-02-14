using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStuff.ItemGen
{
    public class ItemInit : MonoBehaviour
    {

        void OnAwake()
        {
            Main();
        }

        private static void Main()
        {
            NameLibrary Lib = new NameLibrary();
            Debug.Log("NameDictKeys: " + Lib.nameDictionary.Keys);
            Debug.Log("COUNT: " + Lib.nameDictionary.Count);
        }
    }
}

