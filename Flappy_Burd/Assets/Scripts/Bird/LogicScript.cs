using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int playerScore = 0;
    public int totalCoin = 0;
    public Text scoreText;
    public Text coinText;

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
        coinText.text = totalCoin.ToString();

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
