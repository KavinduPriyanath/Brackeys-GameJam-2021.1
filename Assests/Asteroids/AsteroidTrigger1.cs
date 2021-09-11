using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidTrigger1 : MonoBehaviour
{
    public GameObject asteroid1;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            asteroid1.SetActive(true);
            Destroy(gameObject);
        }
    }
}
