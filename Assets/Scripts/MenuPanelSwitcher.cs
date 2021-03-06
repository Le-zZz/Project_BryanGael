﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanelSwitcher : MonoBehaviour {
    [SerializeField] GameObject panelMainMenu;
    [SerializeField] GameObject panelCredits;
    
    void Start()
    {
        panelMainMenu.SetActive(true);
        panelCredits.SetActive(false);
    }

    void Update()
    {
        
    }

    public void ChangePanel(GameObject panel) {
        panelMainMenu.SetActive(false);
        panelCredits.SetActive(false);

        if (panel == panelCredits) {
            panelCredits.SetActive(true);
            panelMainMenu.SetActive(false);
        }
    }
}
