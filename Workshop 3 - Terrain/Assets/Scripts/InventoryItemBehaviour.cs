using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemBehaviour : MonoBehaviour {

    public string itemName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InventoryBehaviour playerInventory = other.gameObject.GetComponent<PlayerBehaviour>().GetInventory();

            playerInventory.AddToInventory(this);

            gameObject.SetActive(false);
        }
    }

}
