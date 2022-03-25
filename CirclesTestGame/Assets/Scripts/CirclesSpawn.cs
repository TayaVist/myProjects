using UnityEngine;

public class CirclesSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Circles; // объект, который будм спавнить
    [SerializeField]
    public float startTimeSpawns; // базовое время между спавном шариков
    public float timeBtwSpawns; // текущее время до спавна следующего шарика
    private float randPosition; // позиция спавна шариков по оси x
    int level = 0; // уровень игры
    [SerializeField]
    float initialTimeBtwLevels = 10; // время между увеличением уровня
    [SerializeField]
    float timeBtwLevels; // текущее время до увеличения уровня на 1

    // ивент повышения уровня для увеличения базовых скоростей шариков и времени между их появлением
    public static event levelUp LevelUp;
    public delegate void levelUp(int level);

    void Start()
    {
        timeBtwSpawns = startTimeSpawns;
        timeBtwLevels = initialTimeBtwLevels;
    }

    void Update()
    {
       level = levelDifficulty();
       switch(level)
        {
            case 0: {
                startTimeSpawns = 3f;
                    break;
                } 
            case 1:
                startTimeSpawns = 2f;
                break;
            case 2:
                startTimeSpawns = 1;
                break;
            case 3:
                startTimeSpawns = 0.5f;
                break;
            default: 
                break;
        }
        Spawns();        
    }
    void Spawns()
    {
        if (timeBtwSpawns <= 0)
        {
            float x = Random.Range(30, 90);
            randPosition = Random.Range(0+x, 640-x);
            Circles.transform.localScale = new Vector3(transform.localScale.x * x,
            transform.localScale.y * x, transform.localScale.z * 1f);

            Instantiate(Circles,new Vector3(randPosition, 420f+(x/2), -10f), Quaternion.identity);
            timeBtwSpawns = startTimeSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

public int levelDifficulty ()
    {        
        timeBtwLevels -= Time.deltaTime;
        if (timeBtwLevels <= 0)
        {  
            level ++;
            LevelUp.Invoke(level);
            timeBtwLevels = initialTimeBtwLevels;
        }
        return level;
    }

}
