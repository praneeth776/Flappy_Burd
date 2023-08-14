using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int playerScore = 0;
    public int totalCoin;
    public Text scoreText;
    public Text coinText;

   
    private void Awake()
    {
        totalCoin = PlayerPrefs.GetInt("Total Coins", 0);
    }

    private void Update()
    {
        coinText.text = totalCoin.ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        
        scoreText.text = playerScore.ToString();
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
