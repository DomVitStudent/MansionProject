using UnityEngine;

namespace Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool menuActivated = false;

        void Update()
        {
            if (Input.GetButtonDown("") && menuActivated == true)
            {
                InventoryMenu.SetActive(false);
                menuActivated = false;
                Debug.Log("Inventory Menu Deactivated");
            }
            else if (Input.GetButtonDown("") && menuActivated == false)
            {
                InventoryMenu.SetActive(true);
                menuActivated = true;
                Debug.Log("Inventory Menu Activated");
            }
        }


    }
    

}