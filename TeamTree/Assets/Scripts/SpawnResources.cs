using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnResources : MonoBehaviour
{
    public GameObject resource;
    public Transform[] SpawnPoint;
    float spawnTimer;
    public float maxTimer;

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= maxTimer)
        {
            Instantiate(resource, SpawnPoint[Random.Range(0, SpawnPoint.Length)]);
            spawnTimer = 0;
        }
    }
}
