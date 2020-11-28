using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{

    public float loseHight = -15f;

    private void Update()
    {
        if (gameObject.transform.position.y < loseHight)
        {
            gameObject.SetActive(false);
            PlayerController.instance.GameOver();
            Time.timeScale = 0;
        }
    }
}
