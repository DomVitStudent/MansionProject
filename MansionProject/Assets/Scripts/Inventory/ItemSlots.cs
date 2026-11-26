using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace Inventory
{
    public class ItemSlots : MonoBehaviour, IPointerClickHandler
    {
        //Data
        public ItemBase heldItem;

        [SerializeField] private Image itemImage;
        public GameObject selectedShader;
        public bool isSelected;
        
        private InventoryManager inventoryManager;
        
        public void Start()
        {
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>(); 
        }
        
        public void AddItem(ItemBase item)
        {
            heldItem = item;
            itemImage.sprite = item.itemIcon;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                OnLeftClick();
            }
        }

        public void OnLeftClick()
        { 
            if (heldItem)
            {
                inventoryManager.DeselectAllSlots();
                selectedShader.SetActive(true);
                isSelected = true;

                inventoryManager.ShowItem(heldItem);
            }
          
        }
        
    }
}
