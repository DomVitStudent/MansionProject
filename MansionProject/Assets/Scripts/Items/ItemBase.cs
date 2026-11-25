using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "AddItemData/ItemBase")]
public class ItemBase : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
}
