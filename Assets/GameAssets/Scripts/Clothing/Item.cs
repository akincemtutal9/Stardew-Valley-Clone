using UnityEngine;

namespace GameAssets.Scripts.Clothing
{
    [CreateAssetMenu(fileName = "New Clothing Item", menuName = "Clothing/Clothing Item")]
    public class Item : ScriptableObject
    {
        public string itemName;
        public int itemPrice;
        public Sprite itemIcon;
        public Sprite itemSprite;
    }
}