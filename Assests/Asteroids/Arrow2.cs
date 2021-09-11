using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow2 : MonoBehaviour
{
    public AudioSource arrow;

    void Update ()
    {
        arrow.Play();
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
