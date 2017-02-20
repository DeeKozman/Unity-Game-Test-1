using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

using GameStuff.Utility;
using GameStuff.Utility.Enums;

/// <summary>
/// Class I am using to initialize the GameItems. This will be replaced with an editor control and also in game scripts.
/// </summary>

namespace GameStuff.ItemGen
{

    [System.Serializable]
    public class ItemInit : ScriptableObject
    {
        
        public GameItem Item;
        [SerializeField] public String Name;
        [SerializeField] public String Level;
        [SerializeField] public String Type;
        [SerializeField] public String Modifier;
        [SerializeField] public String DamageOnHit;
        [SerializeField] public String AttackSpeed;
        [SerializeField] public String ChanceOfHit;
        [SerializeField] public String DPS;
        [SerializeField] public String DamageReduction;
        [SerializeField] public String Price;
        [SerializeField] public String ImageName;
        private string filePath;
        private string jsonString;

        private void OnEnable()
        {
            //Main();
           // makeGameItem();
            string day = Item.Name;
            /*Name = Item.Name;
            Level = "Level "+Item.ItemLevel.ToString();
            Type = Item.ItemClass;
            Modifier = "Type: "+Item.StatsModType + " / Amount: " + Item.StatsModAmount;
            Price = "Buy: $"+Item.PriceBuy.ToString() +" / Sell: $"+Item.PriceSell.ToString();
            addDetails();*/
            filePath = Path.Combine(Application.streamingAssetsPath, "Item.json");
           // Debug.Log(filePath);
            //Debug.Log("item name is:"+Item.Name);
            jsonString = JsonUtility.ToJson(day);
            File.WriteAllText(filePath, jsonString);
        }
        

        private GameItem makeGameItem()
        {
            Debug.Log("Making an Item.");
            Item = GameItem.Generate();
            return Item;
        }

        private void addDetails()
        {
            
            DamageOnHit = Item.DamageOnHit.ToString();
            AttackSpeed = Item.AttackSpeed.ToString();
            ChanceOfHit = Item.ChanceToHit.ToString();
            DPS = Item.DamagePerSecond.ToString();
            DamageReduction = Item.DamageReductionAmount.ToString();
            ImageName = Item.ItemSlug+".png";
        }

        private void Main()
        {
            List<GameItem> generatedItemsList = new List<GameItem>();
            for (var i = 0; i < 100; i++)
            {
               
                generatedItemsList.Add(GameItem.Generate());
            }
            Debug.Log("There Are "+ generatedItemsList.Count+" Items.");
            foreach (var item in generatedItemsList)
            {
                Debug.Log("name: "+item.Name+" / Group: "+ item.ItemGroup + " /  Quality:"+ item.ItemQuality+" / price:"+ item.PriceBuy + " / sell:" +item.PriceSell);
            }
        }
    }
}

