using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDmg : MonoBehaviour
{
    private int health = 1;
    
    [SerializeField] private AudioSource deathSound;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            deathSound.Play();
            health -= 1;
            Debug.Log(health);
        }
    }
}
