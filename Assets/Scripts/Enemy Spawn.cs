using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float screenWidth = 8;
    public float screenHeight = 5;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy()
    { 
        float xCord = Random.Range(-screenWidth, screenWidth);
        
        float yCord = Random.Range(10, screenHeight);
        
        Vector2 spawnPoint = new Vector2 (xCord, yCord);
        
        Instantiate(enemyPrefab, spawnPoint, Quaternion.identity); 
    }
}
