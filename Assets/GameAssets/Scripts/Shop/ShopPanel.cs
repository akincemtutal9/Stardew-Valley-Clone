using System.Collections.Generic;
using UnityEngine;

namespace GameAssets.Scripts.Shop
{
    public class ShopPanel : MonoBehaviour
    {
        [SerializeField] private List<GameObject> panelList = new List<GameObject>();

        private int currentOption = 0;

        private void OnEnable()
        {
            // Activate the indexed object and deactivate all others
            for (int i = 0; i < panelList.Count; i++)
            {
                panelList[i].SetActive(i == currentOption);
            }
        }

        public void ShowNextShopList()
        {
            // Deactivate the currently displayed object
            panelList[currentOption].SetActive(false);

            // Move to the next option
            currentOption++;
            if (currentOption >= panelList.Count)
            {
                currentOption = 0;
            }

            // Activate the new indexed object
            panelList[currentOption].SetActive(true);
        }

        public void ShowPreviousShopList()
        {
            // Deactivate the currently displayed object
            panelList[currentOption].SetActive(false);

            // Move to the previous option
            currentOption--;
            if (currentOption < 0)
            {
                currentOption = panelList.Count - 1;
            }

            // Activate the new indexed object
            panelList[currentOption].SetActive(true);
        }
    }
}