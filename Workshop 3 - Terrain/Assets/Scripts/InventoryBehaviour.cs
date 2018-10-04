using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour {

    private List<InventoryItemBehaviour> inventory = new List<InventoryItemBehaviour>();

    public void AddToInventory(InventoryItemBehaviour item)
    {
        Debug.Log("Adding item: " + item.itemName);
        Debug.Log(item);

        inventory.Add(item);
    }

    public void RemoveFromInventory(InventoryItemBehaviour item)
    {
        Debug.Log("Removing item: " + item.itemName);
        inventory.Remove(item);
    }

    public bool InInventory(InventoryItemBehaviour item)
    {
        return inventory.Contains(item);
    }
}
