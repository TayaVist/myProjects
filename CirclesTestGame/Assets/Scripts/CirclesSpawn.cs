using UnityEngine;

public class CirclesSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Circles; // объект, который будем спавнить
    private float randPosition; // позиция спавна шариков по оси x
    private float timeBtwSpawns; // время до спавна следующего шарика
    private float levelTimeBtwSpawns; // заданное время между спавном шариков   

    void Start()
    {
        Difficulty.levelUpSpawns += ReduceStartTimeSpawns; // подписка на событие лопанья шарика
        GameObject go = GameObject.Find("EventSystem"); // ищем объект, к которому прикреплен скрипт сложности
        Difficulty difficulty = go.GetComponent<Difficulty>(); // делаем экземпляр скрипта сложности
        levelTimeBtwSpawns = difficulty.levelTimeBtwSpawns[0];
        // берем поле, где проинициализирован промежуток времени между спавном шариков для 1го уровня

        timeBtwSpawns = levelTimeBtwSpawns;
    }

    void Update()
    {
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
            timeBtwSpawns = levelTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

    public void ReduceStartTimeSpawns(float time) {
        levelTimeBtwSpawns = time;
    }

}
