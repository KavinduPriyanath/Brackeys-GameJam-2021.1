using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{

    public float speed = 10f;

    public float yspeed = 10f;

    private Rigidbody2D rb;

    //public GameObject hitExplosion;

    //public AudioSource fireBallHit;

    //public GameObject dialogue;

    void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, -yspeed);
        
    }

    //void OnTriggerEnter2D (Collider2D other)
    //{
        //if (other.tag == "Player")
        //{

            //dialogue.SetActive(true);
            //fireBallHit.Play();
            //Destroy(gameObject);
            //hitExplosion.Play();
            //Instantiate(hitExplosion, transform.position, Quaternion.identity);
        //}
    //}

}
