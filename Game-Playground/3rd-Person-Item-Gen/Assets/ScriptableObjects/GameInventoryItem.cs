using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStuff.ItemGen;
[System.Serializable]
public class GameInventoryItem : ScriptableObject
{

    [NonSerialized]
    public GameItem Item;
    [SerializeField] public string Name;
    [SerializeField] public string Description;
    [SerializeField] public string Level;
    [SerializeField] public string Modifier;
    [SerializeField] public string Damage;
    [SerializeField] public string AttackSpeed;
    [SerializeField] public string ChanceOfHit;
    [SerializeField] public string DPS;
    [SerializeField] public string Price;
    [SerializeField] public string ImageName;

    private void OnEnable()
    {
        makeGameItem();

        Name = Item.ItemQuality+" "+Item.Name;
        Description = Item.ItemClass;
        Level = "Level " + Item.ItemLevel.ToString();
        
        Price = "Buy: $" + Item.PriceBuy.ToString() + " / Sell: $" + Item.PriceSell.ToString();
        addDetails();
    }

    private GameItem makeGameItem()
    {
        Debug.Log("Making an Item.");
        Item = GameItem.Generate();
        return Item;
    }

    private void addDetails()
    {
        if (Item.StatsModAmount != 0)
        {
            Modifier = "Modifier: " + Item.StatsModType + " / Amount: " + Item.StatsModAmount;
        }
        else
        {
            Modifier = "";
        }
        if (Item.DamageOnHit != 0)
        {
            Damage = "Damage On Hit: " + Item.DamageOnHit.ToString();
            AttackSpeed = "Attack Speed: " + Item.AttackSpeed.ToString();
            ChanceOfHit = "Chance of Hit: " + Item.ChanceToHit.ToString();
            DPS = "Damage Per Second: " + Item.DamagePerSecond.ToString();
        }
        else
        {
            Damage = "Damage Reduction: " + Item.DamageReductionAmount.ToString();
            AttackSpeed = "";
            ChanceOfHit = "";
            DPS = "";
        }

        
        
        ImageName = "Resources/Sprites/"+Item.ItemSlug+".png";
    }
}
