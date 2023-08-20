using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts.Clothing
{
    public class TorsoInventory : OutfitInventory
    {
        [SerializeField] private Image currentTorsoImage;
        private void OnEnable()
        {
            currentTorsoImage.sprite = options[CurrentOption].itemSprite;
        }

        private void Start()
        {
            // Add initial item to inventory ! in inspector or here 
        }
        public void NextItemAndRefreshImage()
        {
            NextOption();
            RefreshImage();
        }

        public void PreviousItemAndRefreshImage()
        {
            PreviousOption();
            RefreshImage();
        }

        public void OnSellItem()
        {
            SellItemFromInventory();
            RefreshImage();
        }

        private void RefreshImage()
        {
            if (options.Count > 0)
            {
                currentTorsoImage.sprite = options[CurrentOption].itemSprite;
            }
            else
            {
                currentTorsoImage.sprite = null;
            }
        }
    }
}
