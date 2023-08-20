using System.Collections.Generic;
using GameAssets.Scripts.Clothing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts.Shop
{
    public class ShopPanel : MonoBehaviour
    {
        [Header("UI Elements")]
        public TMP_Text itemNameText;
        public TMP_Text itemPriceText;
        public Image itemSpriteImage;
        public Button buyButton;

        public OutfitInventory inventory;
        
        
        [Header("Items for Sale")]
        public List<Item> itemsForSale;

        private int currentItemIndex = 0;

        private void Start()
        {
            UpdateUIWithCurrentItem();
        }

        public void BuyCurrentItem()
        {
            if (currentItemIndex < itemsForSale.Count)
            { 
                inventory.options.Add(itemsForSale[currentItemIndex]);
                currentItemIndex++;
                UpdateUIWithCurrentItem();
            }
        }
        private void UpdateUIWithCurrentItem()
        {
            if (currentItemIndex < itemsForSale.Count)
            {
                Item currentItem = itemsForSale[currentItemIndex];
                itemNameText.text = currentItem.itemName;
                itemPriceText.text = "0"; 
                itemSpriteImage.sprite = currentItem.itemSprite;
            }
            else
            {
                
                itemNameText.text = "";
                itemPriceText.text = "";
                itemSpriteImage.sprite = null;
            }
        }
    }
}
