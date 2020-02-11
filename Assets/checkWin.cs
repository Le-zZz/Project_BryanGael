using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkWin : MonoBehaviour
{
    [SerializeField] GameObject panelWin;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        panelWin.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "checkWin")
        {
            Time.timeScale = 0;
            panelWin.SetActive(true);
        }
    }
}
