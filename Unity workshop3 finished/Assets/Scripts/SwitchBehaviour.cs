using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour {
    public InventoryItemBehaviour[] keyList;

    private bool isOpen = false;

    public bool isActive()
    {
        return !isOpen;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isOpen)
        {
            InventoryBehaviour playerInventory = other.gameObject.GetComponent<PlayerBehaviour>().GetInventory();

            // Check if all keys for this switch are in the inventory
            foreach(InventoryItemBehaviour key in keyList)
            {
                isOpen = playerInventory.InInventory(key);
                if (!isOpen)
                {
                    break;
                }
            }

            // Set the object inactive if it is open
            gameObject.SetActive(!isOpen);
        }
    }
}
