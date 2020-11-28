using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour

{

    public int Coin = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameController.instance.AddScore(Coin);
            Destroy(gameObject);




        }
    }
}



