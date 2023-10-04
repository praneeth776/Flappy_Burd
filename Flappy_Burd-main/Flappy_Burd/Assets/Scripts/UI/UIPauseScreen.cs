using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseScreen : MonoBehaviour
{

    [SerializeField] Button _resume;
    [SerializeField] Button _quitGame;
    [SerializeField] Button _newGame;
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        _resume.onClick.AddListener(Resume);
        _quitGame.onClick.AddListener(quit);
        _newGame.onClick.AddListener(LoadNewGame);
    }

    private void Resume()
    {
        pauseScreen.SetActive(false);
        Bird_script.spacecount = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }

    private void quit()
    {
        ScenesManager.Instance.LoadMainMenu();
    }

    private void LoadNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
        Bird_script.spacecount = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }

    
}
