using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class ItemSlots : MonoBehaviour
    {
        //Data
        public string itemName;
        public Sprite itemIcon;
        public string itemDescription;
        public bool hasItem;

        //Item Slot
        [SerializeField] private Image itemImage;
        
        public void AddItem(string itemName, string itemDescription, Sprite itemIcon)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemIcon = itemIcon;

            itemImage.sprite = itemIcon;
        }


    }
}
