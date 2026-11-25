using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace Inventory
{
    public class ItemSlots : MonoBehaviour, IPointerClickHandler
    {
        //Data
        public string itemName;
        public Sprite itemIcon;
        public string itemDescription;
        public Sprite emptySprite;
        public bool hasItem;
        
        
        //Item Slot
        [SerializeField] private Image itemImage;

        public GameObject selectedShader;
        public bool isSelected;
        
        private InventoryManager inventoryManager;
        
        //Description Slot
        public Image itemDescriptionImage;
        public TMP_Text itemDescriptionName;
        public TMP_Text itemDescriptionText;
        

        public void Start()
        {
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        }
        
        public void AddItem(string itemName, string itemDescription, Sprite itemIcon)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemIcon = itemIcon;

            itemImage.sprite = itemIcon;
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
        }
        
    }
}
