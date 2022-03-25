using UnityEngine;
using UnityEngine.EventSystems;

public class ClickReceiver : MonoBehaviour, IPointerClickHandler
{
    float points = 0;

    public static event pointsTaken PointsTaken;
    public delegate void pointsTaken(float points);

    public void OnPointerClick(PointerEventData eventData)
    {
        points += transform.localScale.x;
        PointsTaken.Invoke(points);
        Destroy(gameObject);
    }

    void Start()
    {
    }
}
