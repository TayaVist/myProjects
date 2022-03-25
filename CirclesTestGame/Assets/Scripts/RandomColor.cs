using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField]
    public Color[] colors; // массив возможных цветов шариков
    /// <summary>
    /// При спавне шарика ему присваивается один рандомных цвет из заданных в массиве
    /// </summary>
    void Start()
    {
        transform.GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0, colors.Length - 1)];
    }

}
