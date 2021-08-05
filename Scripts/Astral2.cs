using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astral2 : MonoBehaviour
{
    public GameObject dialogue2;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogue2.SetActive(false);
        }
    }
}
