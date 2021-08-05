using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : MonoBehaviour
{
    public PlayerMovement1 movement;

    public float newSpeed = 0f;

    public AudioSource electricSound;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            electricSound.Stop();
            movement.speed = newSpeed;
            
        }
    }
}
