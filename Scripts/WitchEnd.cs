using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchEnd : MonoBehaviour
{
    public GameObject dialogue;

    public GameObject witch;

    public GameObject dialogue2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogue.SetActive(false);
            Destroy(gameObject);
            witch.SetActive(false);
            dialogue2.SetActive(true);


        }
    }
}
