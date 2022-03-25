using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour
{
    [SerializeField]
    public Button closeButton; // кнопка закрытия игры
    
    void Start()
    {
        closeButton.onClick.AddListener(CloseApp);
    }
    void CloseApp() {
        Application.Quit();
    }
}
