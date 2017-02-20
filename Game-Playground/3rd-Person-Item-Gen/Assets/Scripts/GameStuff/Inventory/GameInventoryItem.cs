using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameStuff.ItemGen;
using GameStuff.UI;

namespace GameStuff.ItemGen.Inventory
{
    public class GameInventoryItem : MonoBehaviour
    {

        public GameInventoryItemTemplate Item;
        public Button buttonComponent;
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
        private GameInventoryItem item;
        private ShopScrollList scrollList;
        // Use this for initialization
        public void Start()
        {

            buttonComponent.onClick.AddListener(HandleClick);
            if (Item != null)
               SetupItem(Item );
            
        }

        public void SetupItem(GameInventoryItemTemplate item)
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
            //
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void HandleClick()
        {
            Debug.Log("Clicked");
            //scrollList.TryTransferItemToOtherShop(item);
        }
    }

}


