using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameStuff.ItemGen.Inventory
{
    public class GameInventoryItemDisplay : MonoBehaviour
    {

        public GameInventoryItem Item;

        public Text NameText,
            DescriptionText,
            LevelText,
            ModifierText,
            DamageText,
            AttackText,
            ChanceText,
            DpsText,
            PriceText,
            iconText;

        public Image icon;

        // Use this for initialization
        void Start()
        {
            if (Item != null)
                SetupItem(Item);
        }

        public void SetupItem(GameInventoryItem item)
        {
            this.Item = item;
            NameText.text = Item.Name;
            DescriptionText.text = Item.Description;
            LevelText.text = Item.Level;
            ModifierText.text = Item.Modifier;
            DamageText.text = Item.Damage;
            AttackText.text = Item.AttackSpeed;
            ChanceText.text = Item.ChanceOfHit;
            DpsText.text = Item.DPS;
           
            PriceText.text = Item.Price;
            //iconText.text = Item.ImageName;
            icon.sprite = new Sprite();
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


