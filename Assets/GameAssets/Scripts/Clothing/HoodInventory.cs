using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts.Clothing
{
    public class HoodInventory : OutfitInventory
    {
        [SerializeField] private Image currentHoodImage;

        private void OnEnable()
        {
            currentHoodImage.sprite = options[CurrentOption].itemSprite;
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

        private void RefreshImage()
        {
            currentHoodImage.sprite = options[CurrentOption].itemSprite;
        }
    }
}
