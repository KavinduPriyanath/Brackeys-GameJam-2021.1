using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour
{

    public GameObject potionUI;

    public ParticleSystem potionRetrieve;

    public AudioSource potionSound;

    public GameObject dialogue;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {

            potionUI.SetActive(true);
            potionRetrieve.Play();
            Destroy(gameObject);
            potionSound.Play();
            dialogue.SetActive(false);
        }
    }


}
