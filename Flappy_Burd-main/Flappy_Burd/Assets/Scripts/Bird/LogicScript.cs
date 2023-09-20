using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public GameObject gameOverScreen;
    public int playerScore = 0;
    public int totalCoin;
    public int highScore;
    public Text scoreText;
    public Text coinText;
    public Text highScoreText;

   
    private void Awake()
    {
        totalCoin = PlayerPrefs.GetInt("Total Coins", 0);
        highScore = PlayerPrefs.GetInt("High Score", 0);
    }

    private void Update()
    {
        highScoreText.text = highScore.ToString();
        coinText.text = totalCoin.ToString();
        
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        
        scoreText.text = playerScore.ToString();

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("High Score", highScore);
        }
    }
    [ContextMenu("Increase Coin")]
    public void addCoin(int coinToAdd)
    {
        totalCoin += coinToAdd;
        PlayerPrefs.SetInt("Total Coins", totalCoin);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
