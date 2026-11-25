using UnityEngine;
using UnityEngine.EventSystems;

namespace Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool menuActivated = false;
        public ItemSlots[] itemSlots;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab) && menuActivated == true)
            {
                InventoryMenu.SetActive(false);
                menuActivated = false;
                Debug.Log("Inventory Menu Deactivated");
            }
            else if (Input.GetKeyDown(KeyCode.Tab) && menuActivated == false)
            {
                InventoryMenu.SetActive(true);
                menuActivated = true;
                Debug.Log("Inventory Menu Activated");
            }
        }

        public void AddItem(string itemName, string itemDescription, Sprite itemIcon)
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {

                if (itemSlots[i].hasItem == false)
                {
                    itemSlots[i].AddItem(itemName, itemDescription, itemIcon);
                    return;
                }
                
            }
            
        }

        public void DeselectAllSlots()
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {
                itemSlots[i].selectedShader.SetActive(false);
                itemSlots[i].isSelected = false;
            }
        }

    }
    

}