using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmg : MonoBehaviour
{
    private int health = 3;

    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "playerDmg")
        {
            health -= 1;
            Debug.Log(health);
        }
    }
    
}
