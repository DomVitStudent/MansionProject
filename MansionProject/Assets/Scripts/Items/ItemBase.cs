using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "AddItemData/ItemBase")]
public class ItemBase : ScriptableObject
{
    [SerializeField]
    public string itemName;
    
    [TextArea]
    [SerializeField]
    public string itemDescription;
    
    [SerializeField]
    public Sprite itemIcon;
}
