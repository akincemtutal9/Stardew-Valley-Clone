using System.Collections.Generic;
using UnityEngine;

namespace GameAssets.Scripts
{
    public class OutfitChanger : MonoBehaviour
    {
        [Header("Sprite To Changer")] 
        public SpriteRenderer bodyPart;

        [Header("Sprite to Cycle Through")]
        public List<Sprite> options = new List<Sprite>();

        private int currentOption = 0;

        public void NextOption()
        {
            currentOption++;
            if (currentOption >= options.Count)
            {
                currentOption = 0;
            }

            bodyPart.sprite = options[currentOption];
        }

        public void PreviousOption()
        {
            currentOption--;
            if (currentOption <= 0)
            {
                currentOption = options.Count - 1;
            }
            bodyPart.sprite = options[currentOption];
        }
    }
}
