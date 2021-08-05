using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect1 : MonoBehaviour
{
    private float timeBtwSpawns;

    public float startTimeBtwSpawns;

    public GameObject echo;
    private Player player;

    void Start ()
    {
        player = GetComponent<Player>();
    }

    void Update ()
    {

        if (player.movement != 0)
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
