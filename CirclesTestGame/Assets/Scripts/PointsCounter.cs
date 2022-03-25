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
        ClickReceiver.PointsTaken += pointsReceive;
    }

    public void pointsReceive (float points)
    {
        totalPoints += points;
        myText.text = "Points: " + totalPoints.ToString();

    }    
}
