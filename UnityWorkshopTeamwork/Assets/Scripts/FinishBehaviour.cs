using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FinishBehaviour : MonoBehaviour {

    public Text Wintext;
    public Text timer;

    private void OnTriggerEnter(Collider other)
    {
        Wintext.text = "Congratulations, you won!       " + timer.text;
    }
}
