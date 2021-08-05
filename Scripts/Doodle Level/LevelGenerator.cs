using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;

    public int numberofPlatforms = 100;

    public float levelwidth = 3f;

    public float minY = .2f;

    public float maxY = 1.5f;

    void Start ()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberofPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelwidth, levelwidth);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }


}
