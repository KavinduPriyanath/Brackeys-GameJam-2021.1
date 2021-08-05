using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterPotionTouch : MonoBehaviour
{

    public ParticleSystem explosionEffect;

    public GameObject Player1;

    public GameObject Player2;

    public GameObject potionButton;

    public GameObject dialogue2;

    public GameObject player3;

    public GameObject invisibleBoulder;

    public GameObject dialogue3;

    public GameObject bossLevelButton;

    public AudioSource potionButtonTouch;
    
    public void PotionTouch ()
    {
        explosionEffect.Play();
        Player1.SetActive(false);
        Player2.SetActive(false);
        potionButton.SetActive(false);
        dialogue2.SetActive(false);
        player3.SetActive(true);
        invisibleBoulder.SetActive(false);
        dialogue3.SetActive(true);
        bossLevelButton.SetActive(true);
        potionButtonTouch.Play();

    }


}
