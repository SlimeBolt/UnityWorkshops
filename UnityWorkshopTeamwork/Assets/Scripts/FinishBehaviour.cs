using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FinishBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    private void OnTriggerEnter(Collider other)
    {
        EditorUtility.DisplayDialog("Congratulations", "You've won the game!", "Continue", "Continue");
    }
}
