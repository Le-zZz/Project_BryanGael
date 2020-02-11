using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmg : MonoBehaviour
{
    [SerializeField] int health = 4;

    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    [SerializeField] private GameObject heart4;
    [SerializeField] private GameObject panelLose;

    void Update()
    {
        
        HealthStatus();

        if (health == 0)
        {
            heart4.SetActive(false);
            Destroy(gameObject);
            panelLose.SetActive(true);
            Time.timeScale = 0;
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

    void HealthStatus()
    {
        if (health >= 4)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
        }
        
        if (health == 3)
        {
            heart1.SetActive(false);
            heart2.SetActive(true);
            heart3.SetActive(false);
            heart4.SetActive(false);
        }
        
        if (health == 2)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(true);
            heart4.SetActive(false);
        }
        if (health == 1)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(true);
        }   
    }
    
}
