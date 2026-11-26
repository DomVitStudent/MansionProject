using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool menuActivated = false;
        public ItemSlots[] itemSlots;

        [SerializeField] private List<ItemBase> ownedItems = new List<ItemBase>();

        public Image itemDescriptionImage;
        public TMP_Text itemDescriptionName;
        public TMP_Text itemDescriptionText;

        private void Start()
        { 
            foreach (ItemBase item in ownedItems)
            {
                AddItem(item);
            }
     
        }

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

        public void AddItem(ItemBase item)
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {

                if (itemSlots[i].heldItem == null)
                {
                    itemSlots[i].AddItem(item);
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
        public void ShowItem(ItemBase item)
        {
            itemDescriptionName.text = item.itemName;
            itemDescriptionText.text = item.itemDescription;
            itemDescriptionImage.sprite = item.itemIcon;
        }

    }
    

}