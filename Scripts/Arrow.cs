using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float speed = 10f;

    public float yspeed = 10f;

    private Rigidbody2D rb;

    //public GameObject hitExplosion;

    //public AudioSource arrowHit;

    void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, -yspeed);
        
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            //arrowHit.Play();
            Destroy(gameObject);
            //hitExplosion.Play();
            //Instantiate(hitExplosion, transform.position, Quaternion.identity);
        }
    }

    

}
