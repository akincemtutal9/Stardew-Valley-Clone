using UnityEngine;

namespace GameAssets.Scripts.Clothing
{
    [CreateAssetMenu(fileName = "New Clothing Item", menuName = "Clothing/Clothing Item")]
    
    public class Item : ScriptableObject
    {
        public string itemName;
        public int itemPrice;
        public ClothType clothType;
        public Sprite itemIcon;
        public Sprite itemSprite;
    }

    public enum ClothType
    {
        Hood,
        Torso
    }
    
}