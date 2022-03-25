using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    float totalPoints = 0;
   
    void Start()
    {
        myText.text = "Points: 0";
        ClickReceiver.PointsTaken += pointsReceive; // подписка на событие лопанья шарика
    }
    /// <summary>
    /// Увеличение счетчика очков
    /// </summary>
    /// <param name="points">очки за один шарик</param>
    public void pointsReceive (float points)
    {
        totalPoints += points;
        myText.text = "Points: " + totalPoints.ToString();

    }    
}
