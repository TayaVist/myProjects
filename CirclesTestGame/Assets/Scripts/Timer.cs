using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
       myText.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        myText.text = Math.Round(currentTime,2).ToString();
    }
}
