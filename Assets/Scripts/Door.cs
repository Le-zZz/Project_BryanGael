using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject doorOpen;

    public GameObject doorClose;

    public GameObject key;
    public GameObject keyUI;

    private bool getKey = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            key.SetActive(false);
            keyUI.SetActive(true);
            getKey = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "player" && getKey)
        {
            doorClose.SetActive(false);
            doorOpen.SetActive(true);
            keyUI.SetActive(false);
        }
    }
}
