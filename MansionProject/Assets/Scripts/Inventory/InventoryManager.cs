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