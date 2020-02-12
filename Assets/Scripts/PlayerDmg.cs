using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmg : MonoBehaviour
{
    private Rigidbody2D body;
    public static int health;
    public static int maxHealth = 4;

    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    [SerializeField] private GameObject heart4;
    [SerializeField] private GameObject panelLose;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        health = maxHealth;
        Time.timeScale = 1;
    }

    void Update()
    {
        
        HealthStatus();

        if (health == 0)
        {
            heart4.SetActive(false);
            panelLose.SetActive(true);
            Time.timeScale = 0;
            //body.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
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
