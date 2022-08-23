﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPositionY = 30;

    private float startDelay = 1.5f;
    private float spawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
         // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPositionY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        //balls now spawn at random intervals
        Invoke("SpawnRandomBall", Random.Range(startDelay, spawnInterval));
    }

}
