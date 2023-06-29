using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore = 0;
    public bool gameStarted = false;
    public Text scoreText;
    public bool isAlive = true;
    public GameObject gameOver;
    public GameObject gameMenu;
    public BirdController bird;

    [ContextMenu("Increase  Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        isAlive = true;
        gameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        startGame();
    }

    public void showGameOver()
    {
        isAlive = false;
        gameOver.SetActive(true); 
    }

    public void startGame()
    {
        isAlive = true;
        gameStarted = true;
        bird.gameObject.SetActive(true);
        gameMenu.SetActive(false);
    }
}
