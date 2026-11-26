using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace Inventory
{
    public class ItemSlots : MonoBehaviour, IPointerClickHandler
    {
        //Data
<<<<<<< HEAD
        public string itemName;
        public Sprite itemIcon;
        public string itemDescription;
        public Sprite emptySprite;
        public bool hasItem;
        public bool isSelected;
        
        //Item Slot
        [SerializeField] private Image itemImage;
=======
        public ItemBase heldItem;
>>>>>>> cb3cd94239007b524840d5fd138f6aca84bfa4a3

        [SerializeField] private Image itemImage;
        public GameObject selectedShader;
        
        private InventoryManager inventoryManager;
        
        public void Start()
        {
<<<<<<< HEAD
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
            
=======
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>(); 
>>>>>>> cb3cd94239007b524840d5fd138f6aca84bfa4a3
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
<<<<<<< HEAD
        {
            inventoryManager.DeselectAllSlots();
            selectedShader.SetActive(true);
            isSelected = true;
            itemDescriptionName.text = itemName;
            itemDescriptionText.text = itemDescription;
            itemDescriptionImage.sprite = itemIcon;
            if (itemDescriptionImage.sprite == null)
            {
                itemDescriptionImage.sprite = emptySprite;
            }
=======
        { 
            if (heldItem != null)
            {
                inventoryManager.DeselectAllSlots();
                selectedShader.SetActive(true);
                isSelected = true;

                inventoryManager.ShowItem(heldItem);
            }
          
>>>>>>> cb3cd94239007b524840d5fd138f6aca84bfa4a3
        }
        
    }
}
