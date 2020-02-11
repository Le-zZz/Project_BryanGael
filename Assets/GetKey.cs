using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject doorOpen;

    public GameObject doorClose;

    public GameObject key;
    public GameObject keyUI;

    private bool getKey = false;

    // Start is called before the first frame update
    void Start()
    {
        doorClose.SetActive(true);
        doorOpen.SetActive(false);
        key.SetActive(true);
        keyUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "key")
        {
            key.SetActive(false);
            keyUI.SetActive(true);
            getKey = true;
        }
        if (collision.gameObject.tag == "opendoor" && getKey)
        {
        
                doorClose.SetActive(false);
                doorOpen.SetActive(true);
            
        }
    }
}
