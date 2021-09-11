using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float speed = 10f;

    public float yspeed = 10f;

    private Rigidbody2D rb;

    //public GameObject hitExplosion;

    public AudioSource fireBallHit;

    void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, -yspeed);
        
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            fireBallHit.Play();
            Destroy(gameObject);
            //hitExplosion.Play();
            //Instantiate(hitExplosion, transform.position, Quaternion.identity);
        }
    }

}
