using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts.Clothing
{
    public class OutfitGrid : MonoBehaviour
    {
        public OutfitInventory outfitInventory; // Reference to your OutfitInventory component
        public GameObject gridItemPrefab; // Prefab of the item grid cell

        public Transform gridParent; // The parent transform for the grid items

        private void OnEnable()
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            // Clear existing grid items
            foreach (Transform child in gridParent)
            {
                //Destroy(child.gameObject);
            }

            int numRows = 3;
            int numColumns = 3;
            int currentIndex = 0;

            // Loop through the outfit options and create grid items
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numColumns; col++)
                {
                    if (currentIndex >= outfitInventory.options.Count)
                    {
                        // All items displayed, break out of the loop
                        return;
                    }

                    Item item = outfitInventory.options[currentIndex];
                    
                    // Instantiate the grid item prefab
                    GameObject gridItem = Instantiate(gridItemPrefab, gridParent);
                    
                    // Set the UI elements of the grid item with item data
                    gridItem.transform.GetChild(0).GetComponent<Text>().text = item.itemName;
                    gridItem.transform.GetChild(1).GetComponent<Text>().text = "Price: " + item.itemPrice.ToString();
                    gridItem.transform.GetChild(2).GetComponent<Image>().sprite = item.itemIcon;

                    // Increment the index
                    currentIndex++;
                }
            }
        }
    }
}