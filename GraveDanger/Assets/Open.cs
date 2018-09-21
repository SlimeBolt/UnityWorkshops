using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour {

    public GameObject switch1;
    public GameObject switch2;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        if (!switch1.activeSelf && !switch2.activeSelf)
        {
            Destroy(gameObject);
        }
	}
}
