﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D3 : MonoBehaviour
{
    public GameObject dialogue;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogue.SetActive(true);
            Destroy(gameObject);

        }
    }
}
