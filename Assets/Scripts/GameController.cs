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

    private static int Coin = 0;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
        AddScore(0);
    }
    public void AddScore(int src)
    {
        Coin = src;
        scoreText.text = "Kunai :  " + Coin;
    }
    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
       // gameOverScoreText.text = "Final Kunai :" + Coin;
        gameOverText.SetActive(true);
    }
}
