using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunGraphic : MonoBehaviour
{

    public GameObject textDisplay;

    public ParticleSystem gunPickUpEffect;

    public AudioSource gunPickUp;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            gunPickUp.Play();
            gunPickUpEffect.Play();
            Destroy(gameObject);
            textDisplay.SetActive(false);
            
            
        }
    }
}
