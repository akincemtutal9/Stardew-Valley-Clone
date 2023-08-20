using GameAssets.Scripts.Clothing;
using GameAssets.Scripts.Economy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts.Shop
{
    public class ShopItem : MonoBehaviour
    {
        public Item item;

        [Header("UI Elements")] public TMP_Text itemNameText;
        public TMP_Text itemPriceText;
        public Image itemSpriteImage;
        public Button buyButton;
        public OutfitInventory inventory;

        private void OnEnable()
        {
            itemNameText.text = item.itemName;
            itemPriceText.text = item.itemPrice.ToString();
            itemSpriteImage.sprite = item.itemSprite;

            if (item.clothType == ClothType.Hood)
            {
                inventory = FindObjectOfType<HoodInventory>();
            }
            else if (item.clothType == ClothType.Torso)
            {
                inventory = FindObjectOfType<TorsoInventory>();
            }

        }
        public void BuyItem()
        {
            if (MoneySystem.instance.balance < item.itemPrice)
            {
                return;
            }
            else
            {
                MoneySystem.instance.SubtractMoney(item.itemPrice);
            }
            
            
            if (inventory.options == null)
            {
                inventory.options.Add(item);
            }

            bool itemAlreadyExists = false;

            // Daha önce eklenmiş mi kontrol et
            foreach (var existingItem in inventory.options)
            {
                if (existingItem.itemName == item.itemName)
                {
                    itemAlreadyExists = true;
                    Debug.Log("Already exist: " + item.itemName);
                    break;
                }
            }

            if (!itemAlreadyExists)
            {
                inventory.options.Add(item);
            }
        }

    }
}
