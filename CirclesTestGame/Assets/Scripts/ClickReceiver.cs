using UnityEngine;
using UnityEngine.EventSystems;

public class ClickReceiver : MonoBehaviour, IPointerClickHandler
{
    float points = 0;

    public static event pointsTaken PointsTaken;
    public delegate void pointsTaken(float points);

    /// <summary>
    /// Разрушение шарика после клика и передача полученного кол-ва очков
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        points += (100 - transform.localScale.x); // зачисляется кол-во очков, звисящее от масштаба шарика, чем больше шарик, тем меньше очков
        PointsTaken.Invoke(points);
        Destroy(gameObject);
    }

    void Start()
    {
    }
}
