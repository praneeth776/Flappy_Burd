using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    

    [SerializeField] Button _playAgainGame;
    // Start is called before the first frame update
    void Start()
    {
        if (_playAgainGame != null)
        {
            _playAgainGame.onClick.AddListener(LoadNewGame);
        }
        else
        {
            Debug.LogWarning("Play Again Button reference not assigned.");
        }
    }

    private void LoadNewGame()
    {
        
        ScenesManager.Instance.LoadNewGame();
        Time.timeScale = 1;
    }

   
}
