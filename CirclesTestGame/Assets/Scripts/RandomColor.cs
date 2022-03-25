using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField]
    public Color[] colors;

    void Start()
    {
        transform.GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0, colors.Length - 1)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
