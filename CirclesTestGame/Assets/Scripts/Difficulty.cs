using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    [SerializeField]
    public float[] levelSpeed;
    private int level = 0;
    public float[] levelTimeBtwSpawns; // массив промежутков времени между спавнами шариков по уровням
    [SerializeField]
    float initialTimeBtwLevels; // время между увеличением уровня
    float timeBtwLevels; // текущее время до увеличения уровня на 1

    // ивент увеличения сложность и уменьшения времени между спавном шариков
    public static event LevelUpSpawns levelUpSpawns;
    public delegate void LevelUpSpawns(float time);

    // ивент увеличения сложность и увеличения базовых скоростей шариков
    public static event LevelUpSpeed levelUpSpeed;
    public delegate void LevelUpSpeed(float time);

    void Start()
    {
        timeBtwLevels = initialTimeBtwLevels;
    }

    void Update()
    {
        levelDifficulty();
        
    }
    /// <summary>
    /// Отсчет времени до уменьшения времени между спавнами шариков
    /// </summary>
    public void levelDifficulty()
    {         
        timeBtwLevels -= Time.deltaTime;
        if (timeBtwLevels <= 0 && level < levelTimeBtwSpawns.Length - 1)
        {
            level++;
            levelUpSpawns.Invoke(levelTimeBtwSpawns[level]);
            levelUpSpeed.Invoke(levelSpeed[level]);
            timeBtwLevels = initialTimeBtwLevels;
        }        
    }
}
