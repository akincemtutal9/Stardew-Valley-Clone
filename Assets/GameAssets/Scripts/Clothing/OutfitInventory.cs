using System.Collections.Generic;
using GameAssets.Scripts.Economy;
using UnityEditor;
using UnityEngine;

namespace GameAssets.Scripts.Clothing
{
    public class OutfitInventory : MonoBehaviour
    {
        [Header("Sprite To Changer")] 
        public SpriteRenderer bodyPart;

        [Header("Sprite to Cycle Through")]
        public List<Item> options = new List<Item>();

        private int currentOption = 0;

        public int CurrentOption => currentOption;

        public void NextOption()
        {
            currentOption++;
            if (currentOption >= options.Count)
            {
                currentOption = 0;
            }
            UpdateVisual();
        }

        public void PreviousOption()
        {
            currentOption--;
            if (currentOption <= 0)
            {
                currentOption = options.Count - 1;
            }

            UpdateVisual();
        }

        protected void SellItemFromInventory()
        {
            options.Remove(options[currentOption]);
            if (currentOption >= options.Count)
            {
                currentOption = options.Count - 1;
            }

            MoneySystem.instance.AddMoney(options[currentOption].itemPrice);
            
            UpdateVisual();
        }

        private void UpdateVisual()
        {
            if (options.Count > 0)
            {
                bodyPart.sprite = options[currentOption].itemSprite;
            }
            else
            {
                bodyPart.sprite = null;
            }
        }
        
        
    }
}
