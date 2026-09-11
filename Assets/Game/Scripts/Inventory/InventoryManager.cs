using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<ItemData> _items = new List<ItemData>();

    public List<ItemData> Items => _items;

    public void AddItems(ItemData item)
    {
        Items.Add(item);
    }

    public void RemoveItem(ItemData item)
    {
        Items.Remove(item);
    }

    public bool CheckItem(string id)
    {
        bool isExisting = Items.Exists(ItemData => string.Equals(ItemData.ID, id));
        return isExisting;
    }
}
