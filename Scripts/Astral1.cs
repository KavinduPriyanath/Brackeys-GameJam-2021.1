using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astral1 : MonoBehaviour
{
    public GameObject dialogue1;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogue1.SetActive(true);
        }
    }
}
