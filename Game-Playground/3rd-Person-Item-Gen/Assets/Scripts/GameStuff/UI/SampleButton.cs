using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using GameStuff.ItemGen;

namespace GameStuff.UI
{
    public class SampleButton : MonoBehaviour
    {
        public Button buttonComponent;
        public Image IconImage;
        public Text NameLabel;
        public Text DescriptionLabel;
        public Text LevelLabel;
        public Text DamageLabel;
       
        public Text PriceLabel;
       

        private Item item;
        private ShopScrollList scrollList;
       // private generatedItemsList;

        // Use this for initialization
        void Start()
        {
            buttonComponent.onClick.AddListener(HandleClick);
        }

        // Update is called once per frame
        public void Setup(Item currentItem, ShopScrollList currentScrollList)
        {
            item = currentItem;
            NameLabel.text = item.NameTxt;
            IconImage.sprite = item.icon;

            DescriptionLabel.text = item.GroupTxt.ToString();
            LevelLabel.text = item.LevelTxt.ToString();
            DamageLabel.text = item.DamageTxt.ToString()+ item.AttackTxt.ToString() + item.ChanceTxt.ToString() + item.DPSTxt.ToString();
            PriceLabel.text = item.BuyTxt.ToString()+item.SellTxt.ToString();
            
            scrollList = currentScrollList;

        }

        public void HandleClick()
        {
            //scrollList.TryTransferItemToOtherShop(item);
        }
    }


}

