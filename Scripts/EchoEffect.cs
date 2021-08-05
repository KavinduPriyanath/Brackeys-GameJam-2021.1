using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    private float timeBtwSpawns;

    public float startTimeBtwSpawns;

    public GameObject echo;
    private PlayerMovement1 player;

    void Start ()
    {
        player = GetComponent<PlayerMovement1>();
    }

    void Update ()
    {

        if (player.horizontalMove != 0)
        {
            if (timeBtwSpawns <= 0)
            {
                GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 2f);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
        
    }
}
