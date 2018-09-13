using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    // Use this for initialization
    private Text m_MyText;
    private bool isFinished;
    private string finishedTime;

    void Start()
    {
        //Text sets your text to say this message
        m_MyText = GetComponent<Text>();
        isFinished = false;
    }

    void Update()
    {
        if (!isFinished)
        {
            m_MyText.text = Time.time.ToString();
        }
        if(isFinished)
        {
            finishedTime = Time.time.ToString();
        }
    }
}
