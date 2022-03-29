using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction; // направление движения
    private float baseSpeed = 1;  
  
    void Start()
    {
        Difficulty.levelUpSpeed += baseSpeedUp;
    }
    /// <summary>
    /// Увеличение базовых скоростей при увеличении уровня
    /// </summary>
    /// <param name="baseSpeedCoef">коэффициент ускорения</param>
    public void baseSpeedUp (float speed)
    {
        baseSpeed *= speed;
    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * baseSpeed * (150 - transform.localScale.x)); // движение шарика

        if (transform.position.y + transform.localScale.x / 2 < 0)
        {
            Destroy(gameObject); // разрушение шарика, когда он уходит из кадра
        }
    }
}
