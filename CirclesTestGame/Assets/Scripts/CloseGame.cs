using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour
{
    [SerializeField]
    public Button closeButton;
    
    // Start is called before the first frame update
    void Start()
    {
        closeButton.onClick.AddListener(CloseApp);
    }

    void CloseApp() {
        Application.Quit();
    }
}
