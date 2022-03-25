using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;
    private float baseSpeed = 1;  
  
    void Start()
    {
        CirclesSpawn.LevelUp += baseSpeedUp;
    }
    public void baseSpeedUp (int level)
    {
        switch (level)
        {
            case 1:
                baseSpeed = 1.1f;
                break;
            case 2:
                baseSpeed = 1.2f;
                break;
            case 3:
                baseSpeed = 1.5f;
                break;
            default:
                break;
        }
    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * baseSpeed * (150 - transform.localScale.x));

        if (transform.position.y + transform.localScale.x / 2 < 0)
        {
            Destroy(gameObject);
        }
    }
}
