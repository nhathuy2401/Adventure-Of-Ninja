using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{

    public static GameController instance;

    public Text scoreText;
    public Text gameOverScoreText;
    public GameObject gameOverText;
    public bool isGameOver = false;

    private static int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
        score = 0;
        score = PlayerPrefs.GetInt("Score: " + score);
        
    }
    public void AddScore(int src)
    {
        score += src;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        gameOverScoreText.text = "Final Score:" + score;
        gameOverText.SetActive(true);
    }
    
}
