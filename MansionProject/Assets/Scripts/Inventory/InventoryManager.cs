using UnityEngine;

namespace Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool menuActivated = false;

        void Update()
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("Input funkar");
            }
            
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


    }
    

}