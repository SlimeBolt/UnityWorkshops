using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour {
    public SwitchBehaviour[] switchList;

    private bool isOpen = false;

    private void Update()
    {
        if (!isOpen)
        {
            // Check if all keys for this switch are in the inventory
            foreach (SwitchBehaviour switchBehaviour in switchList)
            {
                isOpen = !switchBehaviour.isActive();
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
