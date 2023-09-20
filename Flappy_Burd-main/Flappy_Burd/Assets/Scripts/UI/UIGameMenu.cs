using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameMenu : MonoBehaviour
{
    
    [SerializeField] Button _pause;
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
        _pause.onClick.AddListener(setPauseScreen);
    }

   

    private void setPauseScreen()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
