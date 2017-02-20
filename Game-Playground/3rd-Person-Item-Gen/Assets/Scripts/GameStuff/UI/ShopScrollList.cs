using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameStuff.ItemGen.Inventory;

namespace GameStuff.UI
{
    

    public class ShopScrollList : MonoBehaviour
    {

        //public generatedItemsList list
        public List<GameInventoryItem> itemList;
        public Transform contentPanel;
        //public ShopScrollList otherShop;
        
        public SimpleObjectPool buttonObjectPool;

       


        // Use this for initialization
        private void Start()
        {
            RefreshDisplay();
        }

        public void RefreshDisplay()
        {
           
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
                GameInventoryItem item = itemList[i];
                GameObject newButton = buttonObjectPool.GetObject();
                newButton.transform.SetParent(contentPanel);

                GameInventoryItem itemButton = newButton.GetComponent<GameInventoryItem>();
               //itemButton.StartItem( item, this);
            }
        }

        public void TryTransferItemToOtherShop(GameInventoryItem item)
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

        void AddItem(GameInventoryItem itemToAdd, ShopScrollList shopList)
        {
            shopList.itemList.Add(itemToAdd);
        }

        private void RemoveItem(GameInventoryItem itemToRemove, ShopScrollList shopList)
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

