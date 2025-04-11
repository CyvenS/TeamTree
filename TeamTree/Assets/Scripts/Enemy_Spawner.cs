using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemyToSpawn;

    public float timeBetweenSpawns = 6f;
    public float spawnRatioMult; // time multiplier for the spawn speed as game progresses 
    public static float enemy_Limit;
    public Vector2 spawnRangeX = new Vector2(1, -1);
    public Vector2 spawnRangeY = new Vector2(1, -1);
    
    private void Start()
    {
        InvokeRepeating(nameof(spawnEnemy), timeBetweenSpawns, timeBetweenSpawns);
        enemy_Limit++;

        if (enemy_Limit >= 10f)
        {
            
            enemy_Limit--;
        }
    }

    
    void Update()
    {
        
    }
    private void spawnEnemy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float randomY = Random.Range(spawnRangeY.x, spawnRangeY.y);
        Vector2 spawnPosition = new Vector2(randomX, randomY);


        Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(Vector2.zero, new Vector3(spawnRangeX.y - spawnRangeX.x, spawnRangeY.y - spawnRangeY.x, 0));
    }
}
