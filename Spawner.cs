using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    public float spawnTime, spawnDelay;
    public float delay = 2f;
    public float speed = 3f;
    float nextTimeToSpawn;

    void Start()
    {
        nextTimeToSpawn = Time.time;
        InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
    }

    void SpawnRandom()
    {
        Instantiate(item, transform.position, Quaternion.identity);
    }
    // Update is called once per frame

    void Update()
    {

    }
}

