using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchDialogue : MonoBehaviour
{
    public GameObject dialogue;

    public GameObject witch;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogue.SetActive(true);
            Destroy(gameObject);
            witch.SetActive(true);


        }
    }
}
