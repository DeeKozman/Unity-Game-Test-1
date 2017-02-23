using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class That takes the GameInventoryItem Scriptable Object and injects it into the prefab.
/// </summary>

namespace GameStuff.ItemGen.Inventory
{
    [Serializable]
    public class GameInventoryItem : MonoBehaviour
    {
        private int _arrayIdx;
        private Image _iconImage;
        private Sprite _itemIconSprite;
        public Button buttonComponent;

        private string imageName;
        private GameInventoryItem item;

        public GameInventoryItemTemplate Item;
        public Sprite[] ItemIconSprites;

        public Text NameText,
            DescriptionText,
            LevelText,
            ModifierText,
            DamageText,
            AttackText,
            ChanceText,
            DpsText,
            PriceText;

        // Use this for initialization
        public void Start()
        {
            buttonComponent.onClick.AddListener(HandleClick);
            if (Item != null)
                SetupItem(Item);
        }

        public void SetupItem(GameInventoryItemTemplate item)
        {
            Item = item;

            NameText.text = Item.Name;
            DescriptionText.text = Item.Description;
            LevelText.text = Item.Level;
            ModifierText.text = Item.Modifier;
            DamageText.text = Item.Damage;
            AttackText.text = Item.AttackSpeed;
            ChanceText.text = Item.ChanceOfHit;
            DpsText.text = Item.DPS;
            PriceText.text = Item.Price;

            imageName = Item.ImageName;
            ChangeImage();
        }

        public void ChangeImage()
        {
            _arrayIdx = 0;
            switch (imageName)
            {
                case "Melee":
                    _arrayIdx = 0;
                    break;

                case "Ranged":
                    _arrayIdx = 1;
                    break;

                case "Magic":
                    _arrayIdx = 2;
                    break;

                case "Head":
                    _arrayIdx = 3;
                    break;

                case "Chest":
                    _arrayIdx = 4;
                    break;

                case "Foot":
                    _arrayIdx = 5;
                    break;
            }
            _itemIconSprite = ItemIconSprites[_arrayIdx];

            if (transform.GetChild(1).transform.name == "Icon")
            {
                Debug.Log("_itemIconSprite" + _itemIconSprite + " /_arrayIdx" + _arrayIdx);
                _iconImage = transform.GetChild(1).transform.GetComponent<Image>();
                _iconImage.sprite = _itemIconSprite;
            }
            else
            {
                Debug.Log("Didn't Find It");
            }
        }

        public void HandleClick()
        {
            Debug.Log("Clicked");
            //scrollList.TryTransferItemToOtherShop(item);
        }
    }
}