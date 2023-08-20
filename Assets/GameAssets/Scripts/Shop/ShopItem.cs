using GameAssets.Scripts.Clothing;
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
        }
        
        // Inventory için FindObjectOfType atılabilir
        public void BuyItem()
        {
            inventory.options.Add(item);
        }
    }
}
