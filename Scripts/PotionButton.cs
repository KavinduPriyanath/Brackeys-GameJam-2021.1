using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionButton : MonoBehaviour
{
    public GameObject potionButton;

    public ParticleSystem lightning;

    public GameObject dialogue1;

    public GameObject dialogue2;

    public AudioSource potionAppearance;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            potionButton.SetActive(true);
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
            Destroy(gameObject);
            potionAppearance.Play();
            
        }
    }
}
