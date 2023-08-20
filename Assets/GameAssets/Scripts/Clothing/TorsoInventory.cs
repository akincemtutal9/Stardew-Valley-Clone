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

        private void RefreshImage()
        {
            currentTorsoImage.sprite = options[CurrentOption].itemSprite;
        }
        
    }
}
