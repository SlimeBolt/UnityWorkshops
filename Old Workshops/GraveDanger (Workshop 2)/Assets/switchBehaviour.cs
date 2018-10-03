using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchBehaviour : MonoBehaviour {



	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var script = other.gameObject.GetComponent<AgentBehaviour>();
            if (script.keycard1 && gameObject.CompareTag("switch"))
            {

                gameObject.SetActive(false);
            }
            if (script.keycard2 && gameObject.CompareTag("switch1"))
            {

                gameObject.SetActive(false);
            }
        }
    }
}
