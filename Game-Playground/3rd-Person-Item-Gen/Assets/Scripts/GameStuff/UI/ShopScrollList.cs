using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameStuff.ItemGen;

namespace GameStuff.UI
{
    [System.Serializable]
    public class Item
    {
        //public string itemName;
        public Sprite icon;
        //public float price = 1;
        //public Button ItemButton;
        public string NameTxt;
        public string GroupTxt;
        public float LevelTxt;
        public float DamageTxt;
        public float AttackTxt;
        public float ChanceTxt;
        public float DPSTxt;
        public float BuyTxt =1;
        public float SellTxt;
    }

    public class ShopScrollList : MonoBehaviour
    {

        //public generatedItemsList list
        public List<Item> itemList;
        public Transform contentPanel;
        //public ShopScrollList otherShop;
        public Text myGoldDisplay;
        public SimpleObjectPool buttonObjectPool;

        public float gold = 200f;


        // Use this for initialization
        private void Start()
        {
            RefreshDisplay();
        }

        public void RefreshDisplay()
        {
            myGoldDisplay.text = "Gold: " + gold.ToString();
            RemoveButtons();
            AddButtons();
        }

        private void RemoveButtons()
        {
            while (contentPanel.childCount > 0)
            {
                GameObject toRemove = transform.GetChild(0).gameObject;
                buttonObjectPool.ReturnObject(toRemove);
            }
        }

        private void AddButtons()
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                Item item = itemList[i];
                GameObject newButton = buttonObjectPool.GetObject();
                newButton.transform.SetParent(contentPanel);

                SampleButton sampleButton = newButton.GetComponent<SampleButton>();
               sampleButton.Setup(item, this);
            }
        }

        public void TryTransferItemToOtherShop(Item item)
        {
            /*if (otherShop.gold >= item.BuyTxt)
            {
                gold += item.BuyTxt;
                otherShop.gold -= item.BuyTxt;

                AddItem(item, otherShop);
                RemoveItem(item, this);

                RefreshDisplay();
                otherShop.RefreshDisplay();
                Debug.Log("enough gold");

            }
            Debug.Log("attempted");*/
        }

        void AddItem(Item itemToAdd, ShopScrollList shopList)
        {
            shopList.itemList.Add(itemToAdd);
        }

        private void RemoveItem(Item itemToRemove, ShopScrollList shopList)
        {
            for (int i = shopList.itemList.Count - 1; i >= 0; i--)
            {
                if (shopList.itemList[i] == itemToRemove)
                {
                    shopList.itemList.RemoveAt(i);
                }
            }
        }
    }

}

