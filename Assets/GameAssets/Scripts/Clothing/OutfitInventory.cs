using System.Collections.Generic;
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

            bodyPart.sprite = options[currentOption].itemSprite;
        }

        public void PreviousOption()
        {
            currentOption--;
            if (currentOption <= 0)
            {
                currentOption = options.Count - 1;
            }
            bodyPart.sprite = options[currentOption].itemSprite;
        }
    }
}
