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
    void Start()
    {
       myText.text = 0.ToString();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        myText.text = Math.Round(currentTime,2).ToString();
    }
}
