﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< HEAD
    private void Start()
    {
        Destroy(gameObject,1f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
=======
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject,1f);
>>>>>>> master
    }

}
