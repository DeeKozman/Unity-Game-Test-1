using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using LitJson;
using System.IO;
using GameStuff.ItemGen;

namespace GameStuff.Utility
{
    
    public class WriteJson : MonoBehaviour
    {
        //private GameItem Item;
        //private JsonWriter writer1 = new JsonWriter();
        //private JsonData jsonData;
        //private string ted;


        void Awake()
        {
           /*Item = GameItem.Generate();
            ted =  Item.Name.ToString();
            Debug.Log("starting WriteJson: " + ted);
            jsonData = JsonMapper.ToJson(ted, writer1);
            Debug.Log("jsonData: " + jsonData);

           File.WriteAllText(Application.dataPath + "/StreamingAssets/Items.json", jsonData.ToString());*/
        }

       
    }

}

