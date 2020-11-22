using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWall : MonoBehaviour
{
    public GameObject obstacleObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boungdry")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(),
                gameObject.GetComponent<Collider2D>());
            return;
        }
        if (collision.gameObject.tag == "Ground")
        {
            obstacleObject.transform.localScale =
                new Vector3(-obstacleObject.transform.localScale.x,
                obstacleObject.transform.localScale.y,
                obstacleObject.transform.localScale.z);
        }
    }

}
