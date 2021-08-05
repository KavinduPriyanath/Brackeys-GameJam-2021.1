using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnabler : MonoBehaviour
{
    public GameObject gunHandler;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "GunGraphic")
        {
            gunHandler.SetActive(true);
        }
    }
}
