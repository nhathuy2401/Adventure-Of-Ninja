using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathScrip : MonoBehaviour
{
    public float startHealth;
    public float hp;
    void Start()
    {
        hp = startHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp<= 0f)
        {
            Die();
        }
    }
    void Die()
    {
       // if(die)
    }
}
