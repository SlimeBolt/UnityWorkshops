using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    private InventoryBehaviour inventory;

	// Use this for initialization
	void Start () {
        inventory = GetComponent<InventoryBehaviour>();
    }
	
	public InventoryBehaviour GetInventory()
    {
        return inventory;
    }
}
